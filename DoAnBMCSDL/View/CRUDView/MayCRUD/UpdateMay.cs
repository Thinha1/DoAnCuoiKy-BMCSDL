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

namespace DoAnBMCSDL.View.CRUDView.MayCRUD
{
    public partial class UpdateMay : Form
    {
        MayController mayController;
        May may;

        List<string> trangThaiList = new List<string>
        {
            "Đang hoạt động", "Bảo trì"
        };
        List<string> loaiList = new List<string>
        {
            "VIP", "Thường"
        };

        public UpdateMay(May may)
        {
            InitializeComponent();
            mayController = new MayController();
            this.may = may;
            cmb_loaimay.DataSource = loaiList;
            cmb_trangthai.DataSource = trangThaiList;
        }

        private void btn_cncl_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.ShowDialog();
        }

        private void UpdateMay_Load(object sender, EventArgs e)
        {
            txt_mamay.Text = may.MaMay;
            cmb_loaimay.Text = may.Loai;
            cmb_trangthai.Text = may.TrangThai;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            May m = new May
            {
                MaMay = txt_mamay.Text,
                Loai = cmb_loaimay.Text,
                TrangThai = cmb_trangthai.Text
            };
            try
            {
                bool check = mayController.UpdateMay(m);
                if (check)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    this.Hide();
                    MainForm main = new MainForm();
                    main.ShowDialog();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
