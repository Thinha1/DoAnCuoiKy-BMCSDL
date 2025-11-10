using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Numerics;
using System.Security.Cryptography;
using System.Windows.Forms;
using DoAnBMCSDL.Controller;
using DoAnBMCSDL.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using iTextSharp.text.pdf.security;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace DoAnBMCSDL.utils.pdfExport
{
    internal class HoaDonExporter
    {
        private HoaDonController hoaDonController = new HoaDonController();
        public void Export(string maHD, string filePath)
        {
            List<ChiTietHoaDon> chiTietList = hoaDonController.getAllChiTietHoaDon(maHD);
            // Khởi tạo document A4
            Document
                doc = new Document(PageSize.A4, 50, 50, 50, 50);

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Font Unicode hỗ trợ tiếng Việt
                BaseFont bf = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                Font fontTitle = new Font(bf, 16, Font.BOLD);
                Font fontNormal = new Font(bf, 12, Font.NORMAL);

                // Tiêu đề
                Paragraph title = new Paragraph("HÓA ĐƠN QUÁN NET MIXUEGAMING", fontTitle);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                doc.Add(new Paragraph($"Mã HĐ: {maHD}", fontNormal));
                doc.Add(new Paragraph($"Ngày lập: {DateTime.Now:dd/MM/yyyy}", fontNormal));
                LineSeparator line = new LineSeparator(1f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, -1);
                doc.Add(new Chunk(line));

                // Bảng chi tiết sản phẩm
                PdfPTable table = new PdfPTable(3);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 40, 15, 20 });
                table.AddCell(new Phrase("Mã DV", fontNormal));
                table.AddCell(new Phrase("Số lượng", fontNormal));
                table.AddCell(new Phrase("Thành tiền", fontNormal));

                float tongTien = 0;

                foreach (var ct in chiTietList)
                {
                    table.AddCell(new Phrase(ct.MaDV, fontNormal));
                    table.AddCell(new Phrase(ct.SoLuong.ToString(), fontNormal));
                    table.AddCell(new Phrase(ct.ThanhTien.ToString("N0"), fontNormal));
                    tongTien += ct.ThanhTien;
                }

                doc.Add(table);
                doc.Add(new Chunk(line));
                Paragraph total = new Paragraph($"TỔNG CỘNG: {tongTien:N0} VND", fontNormal);
                total.Alignment = Element.ALIGN_RIGHT;
                doc.Add(total);

                doc.Add(new Paragraph("\n\n"));
                doc.Add(new Paragraph("Người lập hóa đơn", fontNormal));
                doc.Add(new Paragraph("(Ký và ghi rõ họ tên)", fontNormal));

                doc.Close();
            }
        }


        public void SignPdfWithVisibleSignature(string inputPdf, string outputPdf, RSACryptoServiceProvider rsa, string signerName)
        {
            RSAParameters rsaParams = rsa.ExportParameters(true);
            RsaPrivateCrtKeyParameters privateKey = new RsaPrivateCrtKeyParameters(
                new Org.BouncyCastle.Math.BigInteger(1, rsaParams.Modulus),
                new Org.BouncyCastle.Math.BigInteger(1, rsaParams.Exponent),
                new Org.BouncyCastle.Math.BigInteger(1, rsaParams.D),
                new Org.BouncyCastle.Math.BigInteger(1, rsaParams.P),
                new Org.BouncyCastle.Math.BigInteger(1, rsaParams.Q),
                new Org.BouncyCastle.Math.BigInteger(1, rsaParams.DP),
                new Org.BouncyCastle.Math.BigInteger(1, rsaParams.DQ),
                new Org.BouncyCastle.Math.BigInteger(1, rsaParams.InverseQ)
            );
            PdfReader reader = new PdfReader(inputPdf);
            using (FileStream os = new FileStream(outputPdf, FileMode.Create))
            {
                PdfStamper stamper = PdfStamper.CreateSignature(reader, os, '\0');
                PdfSignatureAppearance appearance = stamper.SignatureAppearance;

                // Thiết lập chữ ký hiển thị
                appearance.Reason = "Ký hóa đơn điện tử";
                appearance.Location = "Quán Net Mixuegaming";
                appearance.SignDate = DateTime.Now;
                appearance.SetVisibleSignature(new iTextSharp.text.Rectangle(50, 50, 250, 100), 1, "Signature1");
                appearance.Layer2Text = $"Đã ký bởi {signerName}\nNgày: {DateTime.Now:dd/MM/yyyy HH:mm}";
                //Base font cần chỉnh

                // Ký số bằng SHA-256 + RSA
                IExternalSignature externalSignature = new PrivateKeySignature(privateKey, "SHA-256");
                MakeSignature.SignDetached(appearance, externalSignature, null, null, null, null, 0, CryptoStandard.CMS);

                stamper.Close();
            }
        }

        public void SendInvoiceEmail(string toEmail, string subject, string body, string pdfFilePath, string publicKeyPath)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("Thinhanhdang014@gmail.com", "Quán net mixuegaming"); // Email gửi đi
                mail.To.Add(toEmail); // Email khách hàng
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                // Đính kèm file PDF
                if (!string.IsNullOrEmpty(pdfFilePath) && File.Exists(pdfFilePath))
                {
                    mail.Attachments.Add(new Attachment(pdfFilePath));
                }
                if (!string.IsNullOrEmpty(publicKeyPath) && File.Exists(publicKeyPath))
                {
                    mail.Attachments.Add(new Attachment(publicKeyPath));
                }

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); // server SMTP + port
                smtp.Credentials = new NetworkCredential("Thinhanhdang014@gmail.com", "zncy dhrw yzch zfcx");
                smtp.EnableSsl = true; // bật SSL nếu cần

                smtp.Send(mail);
                MessageBox.Show("Gửi email thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi email: " + ex.Message);
            }
        }
    }
}
