using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnBMCSDL.utils.pdfExport;

namespace DoAnBMCSDL.View.SignView
{
    public partial class VerifySignature : Form
    {
        HoaDonExporter exporter;
        public VerifySignature()
        {
            CenterToParent();
            exporter = new HoaDonExporter();
            InitializeComponent();
        }

        private void btn_oppdf_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pdf files (*.pdf)|*.pdf";
                openFileDialog.Title = "Chọn file pdf";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_pdf.Text = openFileDialog.FileName;  // hiển thị lên TextBox
                }
            }
        }

        private void btn_opencert_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pem files (*.pem)|*.pem";
                openFileDialog.Title = "Chọn file cert";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_cert.Text = openFileDialog.FileName;  // hiển thị lên TextBox
                }
            }
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            string pdfPath = txt_pdf.Text;
            string certPath = txt_cert.Text;
            if(string.IsNullOrWhiteSpace(pdfPath) || string.IsNullOrWhiteSpace(certPath))
            {
                MessageBox.Show("Bạn chưa đưa đủ file để kiểm tra chữ ký!");
            }
            if (exporter.VerifyPdfSignature(pdfPath, certPath))
            {
                MessageBox.Show("Chữ ký hợp lệ!");
            }
            else
            {
                MessageBox.Show("Lỗi file đã bị chỉnh sửa hoặc chữ ký không hợp lệ!");
            }
        }
    }
}
