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
using DoAnBMCSDL.View.CRUDView.MayCRUD;

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
    }
}
