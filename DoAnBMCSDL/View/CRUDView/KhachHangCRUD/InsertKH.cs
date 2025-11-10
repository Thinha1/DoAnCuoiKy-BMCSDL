using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using DoAnBMCSDL.Controller;
using DoAnBMCSDL.utils.Encrytion;
using DoAnBMCSDL.View;

namespace DoAnBMCSDL.View.CRUDView.KhachHang
{
    public partial class InsertKH : Form
    {
        KhachHangController khachHangController;
        EncryptionUtils encryptionAlgorithm;
        MainForm mainForm;
        DESApp DESApp;
        DESDB DESDB;
        public InsertKH(MainForm form)
        {
            InitializeComponent();
            khachHangController = new KhachHangController();
            encryptionAlgorithm = new EncryptionUtils();
            this.mainForm = form;
            this.DESApp = new DESApp();
            this.DESDB = new DESDB(DatabaseUtils.GetConnection());
        }

        private bool validateData(string ten, string sdt, string cccd, string email, float sodu, string mk)
        {
            if (string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(cccd) || float.IsNaN(sodu) || string.IsNullOrWhiteSpace(mk) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng điền đầy dủ thông tin!");
                return false;
            }
            else
            {
                if (sodu <= 0)
                {
                    MessageBox.Show("Số dư không được âm hoặc bằng 0!");
                    return false;
                }
                return true;
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string tenkh = txt_tenkh.Text;
            string sdt = txt_sdt.Text;
            string cccd = txt_cccd.Text;
            string email = txt_email.Text;
            float sodu = float.Parse(txt_sodu.Text);
            string mk = txt_mk.Text;
            if (validateData(tenkh, sdt, cccd, email, sodu, mk))
            {
                MessageBox.Show($"CCCD = '{cccd}', Length = {cccd.Length}");
                sdt = encryptionAlgorithm.encryptMessagePlus(sdt, 10);
                cccd = encryptionAlgorithm.encryptMessageMultiply(cccd, 11);

                //Mã hoá tầng ứng dụng
                byte[] key = DESApp.GenerateKey();
                byte[] encodedPass = DESApp.Encrypt(mk, key);
                mk = Convert.ToBase64String(encodedPass);

                //Mã hoá csdl
                string keyStr = Convert.ToBase64String(key);
                byte[] mkBytes = DESDB.encryptDES(mk, keyStr);
                mk = Convert.ToBase64String(mkBytes);
                bool check = khachHangController.InsertKhachHang(tenkh, sdt, email, cccd, sodu, mk);
                if (check)
                {
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                    this.mainForm.refreshData("tab_khach");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
        }

        private void btn_cncl_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
        }
    }
}
