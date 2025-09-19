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
using Oracle.ManagedDataAccess.Client;
using OracleConnect.Controller;
using OracleConnect.Model;

namespace OracleConnect.View
{
    public partial class MainForm : Form
    {
        private LoginForm loginForm;
        private MayController mayController;
        private Timer sessionTimer;
        public MainForm()
        {
            InitializeComponent();
            loginForm = new LoginForm();
            mayController = new MayController();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
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
                    this.Close();
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
                loadMay();
            }
        }

        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage == tab_may)
            {
                loadMay();
            }
        }
    }
}
