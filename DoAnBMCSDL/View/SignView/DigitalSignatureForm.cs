using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnBMCSDL.Controller;
using DoAnBMCSDL.utils.pdfExport;

namespace DoAnBMCSDL.View.SignView
{
    public partial class DigitalSignatureForm : Form
    {
        HoaDonExporter exporter;
        string _mahd;
        HoaDonController hoadonController;
        public DigitalSignatureForm(string mahd)
        {
            exporter = new HoaDonExporter();
            CenterToParent();
            InitializeComponent();
            _mahd = mahd;
            hoadonController = new HoaDonController();
        }

        private void btn_genkey_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {

                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog.Title = "Save keys";

                string uniqueFileName = "Keys_" + Path.GetRandomFileName().Replace(".", "").Substring(0, 8);

                saveFileDialog.FileName = uniqueFileName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
                    {
                        string publicKeyPath = Path.Combine(Path.GetDirectoryName(saveFileDialog.FileName), uniqueFileName + "_publicKey.txt");
                        string publicKey = Convert.ToBase64String(rsa.ExportCspBlob(false));
                        File.WriteAllText(publicKeyPath, publicKey);

                        string privateKeyPath = Path.Combine(Path.GetDirectoryName(saveFileDialog.FileName), uniqueFileName + "_privateKey.txt");
                        string privateKey = Convert.ToBase64String(rsa.ExportCspBlob(true));
                        File.WriteAllText(privateKeyPath, privateKey);

                        MessageBox.Show("Tạo key thành công! Kiểm tra file");
                    }
                }
            }
        }

        private void btn_openprivatek_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pem files (*.pem)|*.pem";
                openFileDialog.Title = "Chọn file pem";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_privatekey.Text = openFileDialog.FileName;  // hiển thị lên TextBox
                }
            }
        }

        private void btn_openpdf_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                openFileDialog.Title = "Chọn file pdf";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_pdf.Text = openFileDialog.FileName;
                }
            }
        }

        public string SignPdfFile_CreateSig(string pdfPath, RSACryptoServiceProvider rsa)
        {
            if (!File.Exists(pdfPath))
                throw new FileNotFoundException("File PDF không tồn tại", pdfPath);

            // Đọc toàn bộ file PDF thành mảng byte
            byte[] pdfBytes = File.ReadAllBytes(pdfPath);

            // Ký dữ liệu bằng SHA256 + RSA
            byte[] signature = rsa.SignData(pdfBytes, CryptoConfig.MapNameToOID("SHA256"));

            // Tạo đường dẫn file .sig (cùng thư mục với PDF)
            string sigPath = Path.Combine(Path.GetDirectoryName(pdfPath),
                                          Path.GetFileNameWithoutExtension(pdfPath) + ".sig");

            // Ghi chữ ký ra file .sig
            File.WriteAllBytes(sigPath, signature);

            return sigPath; // trả về đường dẫn file .sig vừa tạo
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            try
            {
                string pdfPath = txt_pdf.Text;
                if (string.IsNullOrWhiteSpace(pdfPath) || !File.Exists(pdfPath))
                {
                    MessageBox.Show("Chưa chọn file PDF hợp lệ.");
                    return;
                }

                string keyText = txt_privatekey.Text;
                if (string.IsNullOrWhiteSpace(keyText))
                {
                    MessageBox.Show("Chưa load private key.");
                    return;
                }

                string outputDir = @"D:\Documents\BaiTap\BMCSDL\DoAn\DoAnBMCSDL\DoAnBMCSDL\hoadondaky";
                if (!Directory.Exists(outputDir))
                    Directory.CreateDirectory(outputDir);

                string signedPdfPath = Path.Combine(outputDir, $"{_mahd}_signed.pdf");

                string certPath = txt_privatekey.Text;
                string keyPath = txt_publickeyfile.Text;

                // 5) Ký PDF trực tiếp
                exporter.SignPdf(pdfPath, signedPdfPath, keyPath, certPath, "QUÁN NET MIXUEGAMING");

                // 6) Lấy email khách hàng và public key path
                string email = hoadonController.getEmailByMaHD(_mahd);
                string publicKeyPath = txt_publickeyfile.Text;

                // 7) Gửi email kèm PDF và public key
                exporter.SendInvoiceEmail(email,
                    "HOÁ ĐƠN ĐIỆN TỬ",
                    "Quán Net Mixuegaming gửi hoá đơn điện tử đến quý khách.",
                    signedPdfPath,
                    publicKeyPath
                );

                MessageBox.Show($"Ký xong.\nĐã gửi mail cho khách hàng");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ký: " + ex.Message);
            }
        }


        private void btn_openpublick_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pem files (*.pem)|*.pem";
                openFileDialog.Title = "Chọn file cert mà bạn muốn gửi";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_publickeyfile.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
