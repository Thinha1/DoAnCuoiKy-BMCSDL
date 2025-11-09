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
using DoAnBMCSDL.utils.pdfExport;
using DoAnBMCSDL.View.SignView;

namespace DoAnBMCSDL.View
{
    public partial class ChiTietHoaDonForm : Form
    {
        private HoaDonController hoaDonController;
        private string _maHD;
        public ChiTietHoaDonForm(string maHD)
        {
            CenterToParent();
            InitializeComponent();
            hoaDonController = new HoaDonController();
            _maHD = maHD;
        }

        private List<ChiTietHoaDon> loadAllChiTietHoaDon()
        {
            return hoaDonController.getAllChiTietHoaDon(_maHD);
        }

        private void ChiTietHoaDonForm_Load(object sender, EventArgs e)
        {
            dgrv_cthd.DataSource = loadAllChiTietHoaDon();
            dgrv_cthd.AutoGenerateColumns = false;
        }

        private void btn_rtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_kyhd_Click(object sender, EventArgs e)
        {
            DigitalSignatureForm digitalSignatureForm = new DigitalSignatureForm();
            digitalSignatureForm.ShowDialog();
        }

        private void btn_xuatfilepdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF files (*.pdf)|*.pdf";
            sfd.Title = "Xuất hóa đơn ra file PDF";
            sfd.FileName = $"HoaDon_{_maHD}.pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                HoaDonExporter exporter = new HoaDonExporter();
                exporter.Export(_maHD, sfd.FileName);
                MessageBox.Show("Xuất hóa đơn thành công!");
            }
        }
    }
}
