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
        DESApp dESApp;
        DESDB dESDB;
        public InsertKH(MainForm form)
        {
            InitializeComponent();
            khachHangController = new KhachHangController();
            encryptionAlgorithm = new EncryptionUtils();
            this.mainForm = form;
            this.dESApp = new DESApp();
            this.dESDB = new DESDB();
        }

        private bool validateData(string ten, string sdt, string cccd, float sodu, string mk)
        {
            if (string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(cccd) || float.IsNaN(sodu) || string.IsNullOrWhiteSpace(mk))
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
                if ((!sdt.All(char.IsDigit)) && sdt.Length != 10)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ");
                    return false;
                }
                if (cccd.Length != 12)
                {
                    MessageBox.Show("Căn cước công dân không hợp lệ");
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
            float sodu = float.Parse(txt_sodu.Text);
            string mk = txt_mk.Text;
            if (validateData(tenkh, sdt, cccd, sodu, mk))
            {
                sdt = encryptionAlgorithm.encryptMessagePlus(sdt, 10);
                cccd = encryptionAlgorithm.encryptMessageMultiply(cccd, 11);

                string keyString = "private key";
                byte[] keyBytes = Encoding.UTF8.GetBytes(keyString);
                byte[] encodedPass = dESApp.Encrypt(mk, keyBytes);
                mk = Convert.ToBase64String(encodedPass);
                bool check = khachHangController.InsertKhachHang(tenkh, sdt, cccd, sodu, mk);
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
