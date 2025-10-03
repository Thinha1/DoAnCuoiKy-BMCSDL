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

namespace DoAnBMCSDL.View.CRUDView.KhachHang
{
    public partial class UpdateKH : Form
    {
        KhachHangController KhachHangController;
        public UpdateKH()
        {
            InitializeComponent();
            KhachHangController = new KhachHangController();
        }

        private void UpdateKH_Load(object sender, EventArgs e)
        {
            string tenKH = txt_tenkh.Text;
            string soDienThoai = txt_sdt.Text;
            
        }
    }
}
