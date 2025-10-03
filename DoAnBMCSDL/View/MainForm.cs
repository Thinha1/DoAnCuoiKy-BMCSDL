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
using OracleConnect.Controller;
using OracleConnect.Model;

namespace OracleConnect.View
{
    public partial class MainForm : Form
    {
        private LoginForm loginForm;
        private MayController mayController;
        private KhachHangController khachHangController;
        private EncryptionAlgorithms encryptionAlgorithm;
        private Timer timer;
        public MainForm()
        {
            InitializeComponent();
            loginForm = new LoginForm();
            mayController = new MayController();
            khachHangController = new KhachHangController();
            encryptionAlgorithm = new EncryptionAlgorithms();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 30000; //Check sau 30 giây
            timer.Tick += Timer_Tick;
            timer.Start();
            //Hiển thị tên user
            OracleConnection o = DatabaseUtils.GetConnection();
            string name = Test.username;
            if (!string.IsNullOrWhiteSpace(name))
            {
                lbl_user.Text = $"Welcome {Test.username}";
                lbl_user.Refresh();
            }
            else
            {
                lbl_user.Text = "Welcome guest";
                lbl_user.Refresh();
            }
            if (Test.username.ToUpper() == "SYS")
            {
                btn_logout_all.Visible = true;
            }
            else
            {
                btn_logout_all.Visible = false;
            }
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
                    using (OracleCommand omd = new OracleCommand("SYS.LOGOUT_USER", DatabaseUtils.GetConnection()))
                    {
                        omd.CommandType = System.Data.CommandType.StoredProcedure;
                        omd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = Test.username;
                        omd.ExecuteNonQuery();
                        DatabaseUtils.CloseConnection();
                    }

                    //Logout ra sau khi kill
                    MessageBox.Show("Bạn đã thực thi việc đăng xuất, form sẽ thoát.");
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

        private void btn_logout_all_Click(object sender, EventArgs e)
        {
            DatabaseUtils.init(Test.host, Test.port, Test.sid, Test.username, Test.password);

            if (DatabaseUtils.Connect())
            {
                try
                {
                    //Chạy lệnh kill hết session
                    using (OracleCommand omd = new OracleCommand("LOGOUT_USER_ALL", DatabaseUtils.GetConnection()))
                    {
                        omd.CommandType = System.Data.CommandType.StoredProcedure;
                        omd.ExecuteNonQuery();
                    }

                    //Logout ra sau khi kill
                    MessageBox.Show("Bạn đã thực thi việc đóng connection của tất cả user, form sẽ thoát.");
                    this.Hide();
                    loginForm.ShowDialog();
                    return;
                }
                catch (OracleException)
                {
                    MessageBox.Show("Không tồn tại procedure này!");
                    this.Hide();
                    loginForm.ShowDialog();
                    return;

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
        }

        public void refreshData(string tabName)
        {
            if (tabName == "tab_khachhang")
            {
                List<KhachHang> listKH = khachHangController.getAllKhachHang();
                dgrv_kh.DataSource = null;
                dgrv_kh.DataSource = listKH;
                tab_khach.Refresh();
            }
        }

        private void btn_insert_kh_Click(object sender, EventArgs e)
        {
            InsertKH insertKH = new InsertKH(this);
            insertKH.ShowDialog();
        }

        private void btn_delete_kh_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in dgrv_kh.Columns)
            {
                Console.WriteLine($"Column Name: {col.Name}, DataPropertyName: {col.DataPropertyName}");
            }

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
                    bool result = khachHangController.deleteKhachHangById(id);
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
    }
}
