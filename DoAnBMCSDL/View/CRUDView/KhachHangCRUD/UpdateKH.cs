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
using DoAnBMCSDL.Model;
using DoAnBMCSDL.utils.Encrytion;
using DoAnBMCSDL.View;

namespace DoAnBMCSDL.View.CRUDView.KhachHang
{
    public partial class UpdateKH : Form
    {
        MainForm mainForm;
        KhachHangController KhachHangController;
        EncryptionUtils EncryptionAlgorithms;
        private Model.KhachHang kh;

        public UpdateKH(Model.KhachHang kh)
        {
            InitializeComponent();
            KhachHangController = new KhachHangController();
            this.kh = kh;
            this.mainForm = new MainForm();
            EncryptionAlgorithms = new EncryptionUtils();
        }

        private void UpdateKH_Load(object sender, EventArgs e)
        {
            txt_makh.Text = kh.MaKH;
            txt_tenkh.Text = kh.TenKH;
            txt_sdt.Text = kh.SoDienThoai;
            txt_cccd.Text = kh.CCCD;
            txt_sodu.Text = kh.SoDu.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Model.KhachHang khachHangNew = new Model.KhachHang
            {
                MaKH = txt_makh.Text,
                TenKH = txt_tenkh.Text,
                SoDienThoai = txt_sdt.Text,
                CCCD = txt_cccd.Text,
                SoDu = float.Parse(txt_sodu.Text),
                MatKhau = txt_mk.Text
            };
            try
            {
                khachHangNew.SoDienThoai = EncryptionAlgorithms.encryptMessagePlus(khachHangNew.SoDienThoai, 10);
                khachHangNew.CCCD = EncryptionAlgorithms.encryptMessageMultiply(khachHangNew.CCCD, 11);
                bool check = KhachHangController.updateKhachHang(khachHangNew);
                if (check)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                    this.mainForm.refreshData("tab_khach");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }
    }
}
