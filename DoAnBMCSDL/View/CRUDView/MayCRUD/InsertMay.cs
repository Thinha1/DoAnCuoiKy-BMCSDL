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

namespace DoAnBMCSDL.View.CRUDView.MayCRUD
{
    public partial class InsertMay : Form
    {
        MayController mayController = new MayController();

        List<string> trangThaiList = new List<string>
        {
            "Đang hoạt động", "Bảo trì"
        };
        List<string> loaiList = new List<string>
        {
            "VIP", "Thường"
        };
        public InsertMay()
        {
            InitializeComponent();
            cmb_trangthai.DataSource = trangThaiList;
            cmb_loaimay.DataSource = loaiList;
        }

        private void btn_cncl_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.ShowDialog();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string loai = cmb_loaimay.Text;
            string trangThai = cmb_trangthai.Text;
            if(mayController.InsertMay(loai, trangThai))
            {
                MessageBox.Show("Thêm máy thành công!");
            }
            else
            {
                MessageBox.Show("Thêm máy thất bại!");
            }
        }
    }
}
