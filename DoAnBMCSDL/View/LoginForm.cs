using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using OracleConnect.View;

namespace OracleConnect
{
    public partial class LoginForm : Form
    {
        public LoginForm()
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string host = txt_host.Text;
            string port = txt_port.Text;
            string sid = txt_sid.Text;
            string user = txt_user.Text;
            string password = txt_password.Text;
            if (checkValid(host, port, sid, user, password))
            {
                DatabaseUtils.init(host, port, sid, user, password);
                if (DatabaseUtils.Connect())
                {
                    OracleConnection o = DatabaseUtils.GetConnection();
                    MessageBox.Show($"Success!\nVersion: {o.ServerVersion}");
                    Test.username = user;
                    Test.port = port;
                    Test.sid = sid;
                    Test.host = host;
                    Test.username = user;
                    Test.password = password;
                    this.Hide();
                    MainForm m = new MainForm();
                    m.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            this.Hide();
            LoginSysdba loginSysdba = new LoginSysdba(b.Name);
            loginSysdba.ShowDialog();
        }

        private void btn_forgetpassword_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            LoginSysdba loginSysdba = new LoginSysdba(b.Name);
            this.Hide();
            loginSysdba.ShowDialog();
        }
    }
}
