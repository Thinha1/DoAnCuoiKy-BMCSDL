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
using DoAnBMCSDL.utils.Encrytion;
using Oracle.ManagedDataAccess.Client;

namespace DoAnBMCSDL.View
{
    public partial class RegisterForm : Form
    {
        private LoginForm loginForm;
        private static OracleConnection Conn;
        EncryptionFunc encryptionFunc = new EncryptionFunc();
        EncryptionUtils encryptionUtils = new EncryptionUtils();
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

                //Mượn quyền
                DatabaseUtils.init(host, port, sid, "login", "123");
                DatabaseUtils.Connect();
                EncryptionFunc.initConnection(DatabaseUtils.GetConnection());
                //Mã hoá 2 trường user và password
                //Tầng ứng dụng
                user = encryptionUtils.encryptMessagePlus(user, 11);
                password = encryptionUtils.encryptMessageMultiply(password, 11);
                //Tầng cơ sở dữ liệu
                user = encryptionFunc.encryptCipher_Func(user, 11);
                password = encryptionFunc.encryptMultiply_Func(password, 11);
                MessageBox.Show($"{user}, {password}");
                try
                {
                    Conn = DatabaseUtils.GetConnection();
                    if (Conn.State != ConnectionState.Open)

                        Conn.Open();

                    using (OracleCommand omd = new OracleCommand("sys.P_REGISTER", Conn))
                    {
                        omd.CommandType = CommandType.StoredProcedure;
                        omd.Parameters.Add("p_username", OracleDbType.Varchar2, 100).Value = user;
                        omd.Parameters.Add("p_password", OracleDbType.Varchar2, 100).Value = password;
                        omd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Đăng ký thành công!\nQuay lại trang đăng nhập");
                    DatabaseUtils.CloseConnection();
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

        private void btn_return_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }
    }
}
