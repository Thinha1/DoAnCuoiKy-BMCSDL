using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnBMCSDL.Controller;
using DoAnBMCSDL.utils.Encrytion;
using OracleConnect.View;

namespace DoAnBMCSDL.View.CRUDView.KhachHang
{
    public partial class InsertKH : Form
    {
        KhachHangController khachHangController;
        EncryptionAlgorithms encryptionAlgorithm;
        public InsertKH()
        {
            InitializeComponent();
            khachHangController = new KhachHangController();
            encryptionAlgorithm = new EncryptionAlgorithms();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string tenkh = txt_tenkh.Text;
            string sdt = txt_sdt.Text;
            string cccd = txt_cccd.Text;
            string mk = txt_mk.Text;
            sdt = encryptionAlgorithm.encryptMessagePlus(sdt, 10);
            cccd = encryptionAlgorithm.encryptMessageMultiply(cccd, 11);
            bool check = khachHangController.insertKhachHang(tenkh, sdt, cccd, mk);
            if (check)
            {
                MessageBox.Show("Thêm thành công!");
                khachHangController.getAllKhachHang();
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btn_cncl_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
        }
    }
}
