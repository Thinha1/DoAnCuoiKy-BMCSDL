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

namespace DoAnBMCSDL.View
{
    public partial class RegisterForm : Form
    {
        private LoginForm loginForm;
        public RegisterForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public bool checkValid(string host, string port, string sid, string user, string password)
        {
            if (string.IsNullOrWhiteSpace(host))
            {
                MessageBox.Show("Host không được rỗng!");
                txt_host.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(port))
            {
                MessageBox.Show("Port không được rỗng!");
                txt_port.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(sid))
            {
                MessageBox.Show("SID không được rỗng!");
                txt_sid.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show("User không được rỗng!");
                txt_user.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password không được rỗng!");
                txt_password.Focus();
                return false;
            }
            else
            {
                host.Trim();
                port.Trim();
                sid.Trim();
                user.Trim();
                password.Trim();
                return true;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string host = txt_host.Text;
            string port = txt_port.Text;
            string sid = txt_sid.Text;
            string user = txt_user.Text;
            string password = txt_password.Text;

            if (checkValid(host, port, sid, user, password))
            {
                try
                {
                    string defaultSQL = "alter session set \"_oracle_script\" = true";
                    using (OracleCommand omd = new OracleCommand(defaultSQL, DatabaseUtils.GetConnection()))
                    {
                        omd.ExecuteNonQuery();
                    }
                    string createSQL = $"create user {user} identified by {password}";
                    using (OracleCommand omd = new OracleCommand(createSQL, DatabaseUtils.GetConnection()))
                    {
                        omd.ExecuteNonQuery();
                    }
                    string grantSQL = $"grant create session to {user}";
                    using (OracleCommand omd = new OracleCommand(grantSQL, DatabaseUtils.GetConnection()))
                    {
                        omd.ExecuteNonQuery();
                    }
                    string logoutGrantSQL = $"grant execute on SYS.P_LOGOUT_USER to {user}";
                    using (OracleCommand omd = new OracleCommand(logoutGrantSQL, DatabaseUtils.GetConnection()))
                    {
                        omd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Đăng ký thành công!\nQuay lại trang đăng nhập");
                    this.Hide();
                    if (loginForm == null)
                    {
                        loginForm = new LoginForm();
                    }
                    loginForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!");
            }
        }
    }
}
