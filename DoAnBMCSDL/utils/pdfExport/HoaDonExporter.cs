using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnBMCSDL.Controller;
using DoAnBMCSDL.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;

namespace DoAnBMCSDL.utils.pdfExport
{
    internal class HoaDonExporter
    {
        private HoaDonController hoaDonController = new HoaDonController();
        public void Export(string maHD, string filePath)
        {
            List<ChiTietHoaDon> chiTietList = hoaDonController.getAllChiTietHoaDon(maHD);
            // Khởi tạo document A4
            Document doc = new Document(PageSize.A4, 50, 50, 50, 50);

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
                table.SetWidths(new float[] { 40, 15, 20});
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
    }
}
