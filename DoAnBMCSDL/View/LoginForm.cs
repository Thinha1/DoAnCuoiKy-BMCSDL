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
using DoAnBMCSDL.View;
using DoAnBMCSDL.utils.Encrytion;

namespace DoAnBMCSDL
{
    public partial class LoginForm : Form
    {
        EncryptionFunc encryptionFunc = new EncryptionFunc();
        EncryptionUtils encryptionUtils = new EncryptionUtils();
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
                try
                {
                    DatabaseUtils.init(host, port, sid, "thinh", "123");
                    DatabaseUtils.Connect();
                    EncryptionFunc.initConnection(DatabaseUtils.GetConnection());
                    //mã hoá để kiểm tra user/password
                    user = encryptionUtils.encryptMessagePlus(user, 11);
                    password = encryptionUtils.encryptMessageMultiply(password, 11);
                    //Tầng cơ sở dữ liệu
                    user = encryptionFunc.encryptCipher_Func(user, 11);
                    password = encryptionFunc.encryptMultiply_Func(password, 11);
                    MessageBox.Show($"{user}, {password}");
                    DatabaseUtils.CloseConnection();
                    DatabaseUtils.init(host, port, sid, user, password);
                    if (DatabaseUtils.Connect())
                    {
                        Test.username = user;
                        OracleConnection o = DatabaseUtils.GetConnection();
                        MessageBox.Show($"Success!\nVersion: {o.ServerVersion}");
                        this.Hide();
                        MainForm m = new MainForm();
                        m.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex}");
                }
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void btn_forgetpassword_Click(object sender, EventArgs e)
        {
            ChangePassword password = new ChangePassword();
            password.ShowDialog();
            this.Hide();
        }
    }
}
