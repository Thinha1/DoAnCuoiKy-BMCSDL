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

namespace DoAnBMCSDL.View
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string user = txt_usernameuser.Text;
            string pass = txt_passworduser.Text;
            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(pass))
            {
                try
                {
                    using (OracleCommand omd = new OracleCommand("CHANGE_PASSWORD", DatabaseUtils.GetConnection()))
                    {
                        omd.CommandType = System.Data.CommandType.StoredProcedure;

                        //Tham số 1: username cần đổi
                        omd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = user;

                        // Tham số 2: mật khẩu mới
                        omd.Parameters.Add("p_new_pass", OracleDbType.Varchar2).Value = pass;

                        omd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                MessageBox.Show("Bạn đã thực hiện việc đổi mật khẩu thành công!\nQuay lại trang đăng nhập");
                Button btn = sender as Button;
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.ShowDialog();
            }
        }
    }
}
