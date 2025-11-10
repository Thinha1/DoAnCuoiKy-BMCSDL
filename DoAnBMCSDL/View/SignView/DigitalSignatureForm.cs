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
                openFileDialog.Filter = "Text files (*.txt)|*.txt";
                openFileDialog.Title = "Chọn file key";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string key = File.ReadAllText(openFileDialog.FileName);
                    txt_privatekey.Text = key;  // hiển thị lên TextBox
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

        private RSACryptoServiceProvider LoadPrivateKeyFromTextBox(string keyText)
        {
            // Tạo object RSA
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            try
            {
                // Thử interpret keyText như Base64 CspBlob
                byte[] blob = Convert.FromBase64String(keyText); // nếu key lưu theo ExportCspBlob(true)
                rsa.ImportCspBlob(blob); // load key vào RSA
                return rsa;
            }
            catch
            {
                // Nếu không phải Base64, thử interpret như XML (FromXmlString)
                try
                {
                    rsa.FromXmlString(keyText); // key lưu dạng XML string
                    return rsa;
                }
                catch
                {
                    rsa.Dispose();
                    throw new Exception("Không nhận diện được định dạng private key. Hãy truyền Base64(CspBlob) hoặc XML key.");
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

                string keyText = txt_privatekey.Text; // TextBox chứa private key Base64 hoặc XML
                if (string.IsNullOrWhiteSpace(keyText))
                {
                    MessageBox.Show("Chưa load private key.");
                    return;
                }

                // Load private key
                RSACryptoServiceProvider rsa = LoadPrivateKeyFromTextBox(keyText);

                string outputDir = @"D:\Documents\BaiTap\BMCSDL\DoAn\DoAnBMCSDL\DoAnBMCSDL";

                //// 1) Tạo chữ ký số .sig
                //string sigPath = exporter.CreateRSASignature(pdfPath, rsa);

                //// 2) Tạo PDF overlay
                //string signedPdfPath = Path.Combine(Path.GetDirectoryName(pdfPath),
                //                                    Path.GetFileNameWithoutExtension(pdfPath) + "_signed.pdf");
                //exporter.OverlaySignatureOnPdf(pdfPath, signedPdfPath, "QUÁN NET MIXUEGAMING");

                //string email = hoadonController.getEmailByMaHD(_mahd);

                //string publicKeyPath = txt_publickeyfile.Text;

                // 3) Gửi email kèm PDF + file .sig + public key
                //exporter.SendInvoiceEmail(email, "HOÁ ĐƠN ĐIỆN TỬ", "Quán Net Mixuegaming gửi hoá đơn điện tử",
                //                          signedPdfPath, publicKeyPath);

                rsa.Dispose();

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
                openFileDialog.Filter = "PDF files (*.txt)|*.txt";
                openFileDialog.Title = "Chọn file public key cần gửi";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_publickeyfile.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
