using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnBMCSDL.Controller;
using DoAnBMCSDL.Model;
using DoAnBMCSDL.utils.Encrytion;
using DoAnBMCSDL.View.CRUDView.KhachHang;
using Oracle.ManagedDataAccess.Client;
using DoAnBMCSDL.Controller;
using DoAnBMCSDL.Model;
using System.IO;
using DoAnBMCSDL.View.CRUDView.MayCRUD;
using DoAnBMCSDL.View.CRUDView.KhachHangCRUD;
//using DoAnBMCSDL.View.ListView;
using DoAnBMCSDL.View.CRUDView.KhachHangCRUD;
using System.Linq.Expressions;
//using DOanBMCSL.View.DichVuView
using DoAnBMCSDL.View.DichVuView;


namespace DoAnBMCSDL.View
{
    public partial class MainForm : Form
    {
        private LoginForm loginForm;
        private MayController mayController;
        private KhachHangController khachHangController;
        private DichVuController dichVuController;
        private HoaDonController hoaDonController;
        private EncryptionUtils encryptionAlgorithm;
        private Timer timer;
        private EncryptionFunc encryptionFunc;

        //kết nối ORCL
        private string yourConnectionString = "User Id=thinh;Password=123;Data Source=//localhost:1521/orcl";

        //===============THÊM CÁC BIẾN MỚI CHO MÃ HÓA FILE KHÁCH HÀNG
        private DESApp desApp;
        private string dataFilePath = Path.Combine(Application.StartupPath, "danhsach_kh_mahoa.txt");
        private string keyFilePath = Path.Combine(Application.StartupPath, "des_key.key");
        
        private RSAApp rsaApp;
        private string rsa_dv_publicKeyPath = Path.Combine(Application.StartupPath, "rsa_dv_public.xml");
        private string rsa_dv_privateKeyPath = Path.Combine(Application.StartupPath, "rsa_dv_private.xml");
        private string rsa_dv_dataFilePath = Path.Combine(Application.StartupPath, "danhsach_dv_mahoa_rsa.txt");



        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            loginForm = new LoginForm();
            mayController = new MayController();
            khachHangController = new KhachHangController();
            dichVuController = new DichVuController();
            hoaDonController = new HoaDonController();
            encryptionAlgorithm = new EncryptionUtils();
            encryptionFunc = new EncryptionFunc();


            //KHỞI TẠO ĐỐI TƯỢNG 
            desApp = new DESApp();
            rsaApp = new RSAApp();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 30000; //Check sau 30 giây
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!DatabaseUtils.checkConnection())
            {
                timer.Stop();
                MessageBox.Show("Mất kết nối, form sẽ đóng!",
                                "Lỗi kết nối",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Close();
            }
        }

        //Chức năng logout, forget password, register
        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (DatabaseUtils.Connect())
            {
                try
                {
                    //Chạy lệnh kill hết session
                    using (OracleCommand omd = new OracleCommand("SYS.P_LOGOUT_USER", DatabaseUtils.GetConnection()))
                    {
                        omd.CommandType = System.Data.CommandType.StoredProcedure;
                        omd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = Test.username;
                        omd.ExecuteNonQuery();
                        DatabaseUtils.CloseConnection();
                    }

                    //Logout ra sau khi kill
                    MessageBox.Show("Bạn đã thực thi việc đăng xuất, form sẽ thoát.");
                    timer.Dispose();
                    this.Hide();
                    loginForm.ShowDialog();
                    return;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Không tìm thấy procedure");
                }
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }
        private void loadMay()
        {
            List<May> list = mayController.GetAllMay();
            dgrv_may.AutoGenerateColumns = false;
            dgrv_may.DataSource = list;
            if (dgrv_may.Rows.Count == 0)
            {
                list = new List<May>
                {
                    new May { MaMay = "N/A", Loai = "N/A", TrangThai = "Trống" }
                };
            }
        }

        private void loadKhachHang()
        {
            List<KhachHang> list = khachHangController.getAllKhachHang();
            //Decrypt
            list.ForEach(kh =>
            {
                kh.SoDienThoai = encryptionAlgorithm.decryptMessagePlus(kh.SoDienThoai, 10);
                kh.CCCD = encryptionAlgorithm.decryptMessageMutiply(kh.CCCD, 11);
            });
            dgrv_kh.AutoGenerateColumns = false;
            dgrv_kh.DataSource = list;
            if (dgrv_kh.Rows.Count == 0)
            {
                list = new List<KhachHang>
                {
                    new KhachHang{MaKH = "N/A", TenKH = "N/A"}
                };
            }
        }

        private void loadDichVu()
        {
            List<DichVu> list = dichVuController.getAllDichVu();
            dgrv_dv.AutoGenerateColumns = false;
            dgrv_dv.DataSource = list;
            if (dgrv_dv.Rows.Count == 0)
            {
                list = new List<DichVu>
                {
                    new DichVu{MaDV = "N/A", TenDV = "N/A"}
                };
            }
        }

        private void loadHoaDon()
        {
            List<HoaDon> list = hoaDonController.getAllHoaDon();
            dgrv_hd.AutoGenerateColumns = false;
            dgrv_hd.DataSource = list;
            if (dgrv_hd.Rows.Count == 0)
            {
                list = new List<HoaDon>
                {
                    new HoaDon{MaHD = "N/A", MaKH = "N/A"}
                };
            }
        }

        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tab_may)
            {
                loadMay();
            }
            else if (e.TabPage == tab_khach)
            {
                loadKhachHang();
            }
            else if(e.TabPage == tab_dichvu)
            {
                loadDichVu();
            }
            else
            {
                loadHoaDon();
            }
        }

        public void refreshData(string tabName)
        {
            if (tabName == "tab_khachhang")
            {
                List<KhachHang> listKH = khachHangController.getAllKhachHang();
                listKH.ForEach(kh =>
                {
                    kh.SoDienThoai = encryptionAlgorithm.decryptMessagePlus(kh.SoDienThoai, 10);
                    kh.CCCD = encryptionAlgorithm.decryptMessageMutiply(kh.CCCD, 11);
                });
                dgrv_kh.DataSource = null;
                dgrv_kh.DataSource = listKH;
                tab_khach.Refresh();
            }
            else if (tabName == "tab_dichvu")
            {
                List<DichVu> listDV = dichVuController.getAllDichVu();
                dgrv_dv.DataSource = null;
                dgrv_dv.DataSource = listDV;
                tab_dichvu.Refresh();
            }
            else if(tabName == "tab_hoadon")
            {
                List<HoaDon> listHD = hoaDonController.getAllHoaDon();
                dgrv_hd.DataSource = null;
                dgrv_hd.DataSource = listHD;
                tab_hoadon.Refresh();
            }
        }

        private void btn_insert_kh_Click(object sender, EventArgs e)
        {
            InsertKH insertKH = new InsertKH(this);
            insertKH.ShowDialog();
        }

        private void btn_delete_kh_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewColumn col in dgrv_kh.Columns)
            //{
            //    Console.WriteLine($"Column Name: {col.Name}, DataPropertyName: {col.DataPropertyName}");
            //}

            if (dgrv_kh.CurrentRow != null)
            {
                string id = dgrv_kh.CurrentRow.Cells["col_makh"].Value.ToString();
                string name = dgrv_kh.CurrentRow.Cells["col_tenkh"].Value.ToString();
                DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xoá khách hàng {name} (Mã KH: {id})?",
                "Xác nhận xoá",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    bool result = khachHangController.DeleteKhachHangById(id);
                    if (result)
                    {
                        MessageBox.Show("Xoá thành công!");
                        refreshData("tab_khachhang"); // load lại grid
                    }
                    else
                    {
                        MessageBox.Show("Xoá thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xoá");
            }
        }

        private void btn_update_kh_Click(object sender, EventArgs e)
        {
            string id = dgrv_kh.CurrentRow.Cells["col_makh"].Value.ToString();
            string name = dgrv_kh.CurrentRow.Cells["col_tenkh"].Value.ToString();
            string sdt = dgrv_kh.CurrentRow.Cells["col_sdt"].Value.ToString();
            string cccd = dgrv_kh.CurrentRow.Cells["col_cccd"].Value.ToString();
            float soDu = float.Parse(dgrv_kh.CurrentRow.Cells["col_sodu"].Value.ToString());
            KhachHang kh = new KhachHang
            {
                MaKH = id,
                TenKH = name,
                SoDienThoai = sdt,
                CCCD = cccd,
                SoDu = soDu
            };
            UpdateKH updateKH = new UpdateKH(kh);
            updateKH.ShowDialog();
        }

        private void icon_refresh_kh_Click(object sender, EventArgs e)
        {
            this.refreshData("tab_khachhang");
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            mayController.GetAllMay();
        }

        //Xử lý máy
        private void btn_insertMay_Click(object sender, EventArgs e)
        {
            InsertMay insertMay = new InsertMay();
            this.Hide();
            insertMay.ShowDialog();
        }

        private void btn_update_may_Click(object sender, EventArgs e)
        {
            string mamay = dgrv_may.CurrentRow.Cells["col_mamay"].Value.ToString();
            string loai = dgrv_may.CurrentRow.Cells["col_loai"].Value.ToString();
            string trangthai = dgrv_may.CurrentRow.Cells["col_trangthai"].Value.ToString();
            May m = new May();
            m.MaMay = mamay;
            m.Loai = loai;
            m.TrangThai = trangthai;
            this.Hide();
            UpdateMay updateMay = new UpdateMay(m);
            updateMay.ShowDialog();
        }

        private void btn_del_may_Click(object sender, EventArgs e)
        {
            if (dgrv_may.CurrentRow != null)
            {
                string id = dgrv_may.CurrentRow.Cells["col_mamay"].Value.ToString();
                DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xoá máy {id} không ?",
                "Xác nhận xoá",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    bool result = mayController.DeleteMayById(id);
                    if (result)
                    {
                        MessageBox.Show("Xoá thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xoá thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn máy để xoá");
            }
        }

        private void btn_rf_dv_Click(object sender, EventArgs e)
        {
            refreshData("tab_dichvu");
        }

        private void btn_rf_hd_Click(object sender, EventArgs e)
        {

        }

        private void btn_xemcthd_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonForm cthd = new ChiTietHoaDonForm(dgrv_hd.CurrentRow.Cells["col_mahd"].Value.ToString());
            cthd.ShowDialog();
        }




        //gọi hàm mã hóa RSA và DES


        //xuất file txt///////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnExportFile_Click(object sender, EventArgs e)
        {
            try
            {
                List<KhachHang> list = dgrv_kh.DataSource as List<KhachHang>;
                if (list == null || list.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu khách hàng để mã hóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //tạo key DES và lưu vào file
                byte[] desKey = desApp.GenerateKey();
                File.WriteAllBytes(keyFilePath, desKey);
                Console.WriteLine($"DES Key đã được lưu vào file: {keyFilePath}");

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("MaKH,TenKH,SoDienThoai,CCCD,SoDu,MatKhau,NguoiTao,NgayTao,NguoiSua,NgaySua");
                foreach (KhachHang kh in list)
                {
                    sb.AppendLine($"{kh.MaKH}, {kh.TenKH},{kh.SoDienThoai}, {kh.CCCD}, {kh.SoDu},{kh.MatKhau},{kh.NgayTao},{kh.NgayTao},{kh.NguoiSua},{kh.NgaySua}");

                }



                byte[] encrytedData = desApp.Encrypt(sb.ToString(), desKey);
                string base64EncryptedData = Convert.ToBase64String(encrytedData);

                //  Lưu file dữ liệu đã mã hóa
                File.WriteAllText(dataFilePath, base64EncryptedData, Encoding.UTF8);

                MessageBox.Show($"Đã mã hóa DES và xuất file thành công!\n\n" +
                                $"Dữ liệu: {dataFilePath}\n" +
                                $"Khóa: {keyFilePath}", "Hoàn tất");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi mã hóa và xuất file: {ex.Message}");
                MessageBox.Show($"Lỗi khi mã hóa và xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //show form decrypt DES cho khách hàng

        private void btnDecryptDes_Click(object sender, EventArgs e)
        {
            DecryptDes decryptDes = new DecryptDes();
            decryptDes.ShowDialog();
        }




        private void btnExportFile_Click_1(object sender, EventArgs e)
        {
           try
    {
        // 1. Lấy dữ liệu từ DataGridView (Giữ nguyên)
        List<KhachHang> list = dgrv_kh.DataSource as List<KhachHang>;
        if (list == null || list.Count == 0)
        {
            MessageBox.Show("Không có dữ liệu khách hàng để mã hóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // 2. Tạo key DES (Giữ nguyên)
        // (Chúng ta sẽ lưu nó sau khi người dùng chọn vị trí)
        byte[] desKey = desApp.GenerateKey();

        // 3. Gom dữ liệu (Giữ nguyên)
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("MaKH,TenKH,SoDienThoai,CCCD,SoDu,MatKhau,NguoiTao,NgayTao,NguoiSua,NgaySua");
        foreach (KhachHang kh in list)
        {
            sb.AppendLine($"{kh.MaKH}, {kh.TenKH},{kh.SoDienThoai}, {kh.CCCD}, {kh.SoDu},{kh.MatKhau},{kh.NgayTao},{kh.NgayTao},{kh.NguoiSua},{kh.NgaySua}");
        }

        // 4. Mã hóa (Giữ nguyên)
        byte[] encrytedData = desApp.Encrypt(sb.ToString(), desKey);
        string base64EncryptedData = Convert.ToBase64String(encrytedData);

        // --- BẮT ĐẦU THAY ĐỔI ---

        // 5. Mở hộp thoại cho người dùng chọn nơi lưu FILE DỮ LIỆU
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Title = "Chọn nơi lưu file Khách Hàng đã mã hóa";
        
        // (Dùng .txt cho nhất quán với các yêu cầu trước của bạn)
        saveFileDialog.Filter = "Text File (*.txt)|*.txt|Encrypted Data File (*.dat)|*.dat|All Files (*.*)|*.*";
        saveFileDialog.DefaultExt = "txt";
        saveFileDialog.FileName = "khachhang_encrypted.txt";

        // 6. Hiển thị hộp thoại và xử lý
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            // Lấy đường dẫn file DỮ LIỆU người dùng chọn
            string userSelectedDataPath = saveFileDialog.FileName;

            // Tự động tạo đường dẫn cho file KEY
            // (Lưu file key cùng chỗ, cùng tên, nhưng đổi đuôi file thành .key)
            string keyFilePath = Path.ChangeExtension(userSelectedDataPath, ".key");

            // 7. Lưu cả 2 file
            // Lưu file dữ liệu đã mã hóa (Base64)
            File.WriteAllText(userSelectedDataPath, base64EncryptedData, Encoding.UTF8);
            // Lưu file key DES
            File.WriteAllBytes(keyFilePath, desKey);

            // 8. Cập nhật thông báo
            MessageBox.Show($"Đã mã hóa DES và xuất file thành công!\n\n" +
                            $"Dữ liệu: {userSelectedDataPath}\n" +
                            $"Khóa: {keyFilePath}", "Hoàn tất");
        }
        else
        {
            // Người dùng đã nhấn "Cancel"
            MessageBox.Show("Thao tác xuất file đã bị hủy.", "Đã hủy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // --- KẾT THÚC THAY ĐỔI ---
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Lỗi khi mã hóa và xuất file: {ex.Message}");
        MessageBox.Show($"Lỗi khi mã hóa và xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
        }




        private void btnExportFileDV_Click(object sender, EventArgs e)
        {
            try
            {
                // === PHẦN 1: THAY ĐỔI - LẤY DỮ LIỆU TỪ ORACLE ===

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("MaDV,TenDV,DonGia,NguoiTao,NgayTao,NguoiSua,NgaySua"); // Thêm header
                int count = 0;

                try
                {
                    // (Bạn cần thay 'yourConnectionString' bằng chuỗi kết nối thật)
                    using (OracleConnection conn = new OracleConnection(yourConnectionString))
                    {
                        conn.Open();
                        // (Thay 'DichVu' bằng tên bảng Dịch Vụ của bạn nếu khác)
                        string sql = "SELECT MaDV, TenDV, DonGia, NguoiTao, NgayTao, NguoiSua, NgaySua FROM DichVu ORDER BY MaDV";

                        using (OracleCommand cmd = new OracleCommand(sql, conn))
                        {
                            using (OracleDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    // Lấy dữ liệu từ các cột
                                    string maDV = reader["MaDV"].ToString();
                                    string tenDV = reader["TenDV"].ToString();
                                    string donGia = reader["DonGia"].ToString();
                                    string nguoiTao = reader["NguoiTao"].ToString();
                                    string ngayTao = reader["NgayTao"].ToString();
                                    string nguoiSua = reader["NguoiSua"].ToString();
                                    string ngaySua = reader["NgaySua"].ToString();
                                    sb.AppendLine($"{maDV},{tenDV},{donGia},{nguoiTao},{ngayTao},{nguoiSua},{ngaySua}");
                                    count++;
                                }
                            }
                        }
                    }
                }
                catch (Exception dbEx)
                {
                    MessageBox.Show($"Lỗi khi đọc dữ liệu từ Oracle: {dbEx.Message}", "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng lại nếu không đọc được DB
                }

                // Kiểm tra nếu không có dữ liệu
                if (count == 0)
                {
                    MessageBox.Show("Không có dữ liệu dịch vụ từ Oracle để mã hóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // 2. Kiểm tra (hoặc tạo) cặp khóa RSA (Giữ nguyên)
                if (!File.Exists(rsa_dv_publicKeyPath) || !File.Exists(rsa_dv_privateKeyPath))
                {
                    Console.WriteLine($"Đang tạo cặp khóa RSA cho Dịch vụ tại: {rsa_dv_publicKeyPath}");
                    rsaApp.GenerateAndSaveKeys(rsa_dv_publicKeyPath, rsa_dv_privateKeyPath);
                }

             
                byte[] encryptedData = rsaApp.EncryptFromFile(sb.ToString(), rsa_dv_publicKeyPath);
                string base64EncryptedData = Convert.ToBase64String(encryptedData);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Chọn nơi lưu file dịch vụ đã mã hóa";

                // Đưa .txt lên làm lựa chọn đầu tiên và mặc định
                saveFileDialog.Filter = "Text File (*.txt)|*.txt|Encrypted Data File (*.dat)|*.dat|All Files (*.*)|*.*";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.FileName = "dichvu_encrypted.txt";




                // 7. Hiển thị hộp thoại và lưu file (Giữ nguyên)
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string userSelectedPath = saveFileDialog.FileName;
                    File.WriteAllText(userSelectedPath, base64EncryptedData, Encoding.UTF8);

                    MessageBox.Show($"Đã mã hóa RSA và xuất file Dịch Vụ thành công!\n\n" +
                                    $"Dữ liệu: {userSelectedPath}\n" +
                                    $"Khóa (Public): {rsa_dv_publicKeyPath}", "Hoàn tất");
                }
                else
                {
                    MessageBox.Show("Thao tác xuất file đã bị hủy.", "Đã hủy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi mã hóa RSA và xuất file: {ex.Message}");
                MessageBox.Show($"Lỗi khi mã hóa RSA và xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //NÚT GIẢI MÃ 
        private void btnDecryptDV_Click(object sender, EventArgs e)
        {
            DecryptRSA decryptRSA = new DecryptRSA();
            decryptRSA.ShowDialog();
        }
    }
}
