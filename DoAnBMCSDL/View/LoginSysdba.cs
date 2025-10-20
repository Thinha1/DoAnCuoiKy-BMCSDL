using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnBMCSDL.View
{
    public partial class LoginSysdba : Form
    {
        private string _src;
        public LoginSysdba(string src)
        {
            InitializeComponent();
            CenterToParent();
            _src = src;
        }

        public bool checkValid(string host, string port, string sid, string user, string password)
        {
            if (string.IsNullOrEmpty(host) || string.IsNullOrEmpty(port) || string.IsNullOrEmpty(sid) || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            return true;
        }
        private void btn_loginsysdba_Click(object sender, EventArgs e)
        {
            string host = txt_hostsysdba.Text;
            string port = txt_portsysdba.Text;
            string sid = txt_sidsysdba.Text;
            string user = txt_usernamesysdba.Text;
            string pass = txt_passwordsysdba.Text;
            if (checkValid(host, port, sid, user, pass))
            {
                try
                {
                    if (user.ToUpper() != "SYS")
                    {
                        throw new Exception("Đây không phải quyền của sysdba!");
                    }
                    DatabaseUtils.init(host, port, sid, user, pass);
                    if (DatabaseUtils.Connect())
                    {
                        if (_src == "btn_forgetpassword")
                        {
                            MessageBox.Show("Đăng nhập thành công!\nVui lòng nhập thông tin tài khoản muốn đổi");
                            this.Hide();
                            ChangePassword changePassword = new ChangePassword();
                            changePassword.ShowDialog();
                        }
                        else if (_src == "btn_register")
                        {
                            MessageBox.Show("Đăng nhập thành công!\nChuyển đến trang đăng ký!");
                            this.Hide();
                            RegisterForm registerForm = new RegisterForm();
                            registerForm.ShowDialog();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }
    }
}
