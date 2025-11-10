using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


using DoAnBMCSDL.utils.Encrytion;
using System.Security.Cryptography;


namespace DoAnBMCSDL.View.CRUDView.KhachHangCRUD
{
    public partial class DecryptDes: Form
    {

        private DESApp desApp;

        private string dataFilePathDefault = Path.Combine(Application.StartupPath, "danhsach_kh_mahoa.txt");
        private string keyFilePathDefault = Path.Combine(Application.StartupPath, "des_key.key");





        public DecryptDes()
        {
            InitializeComponent();
            desApp = new DESApp();


            //GÁN SỰ KIỆN CHO NÚT
            btn_decbrow.Click += new System.EventHandler(this.btn_decbrow_Click);
            this.btn_keybrow.Click += new System.EventHandler(this.btn_keybrow_Click);
            this.button1.Click += new System.EventHandler(this.button1_Click); // button1 là nút "Decrypt"


            // Tự động điền đường dẫn mặc định vào TextBox
            txt_filedec.Text = dataFilePathDefault;
            txt_key.Text = keyFilePathDefault;



        }

        private void btn_decbrow_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                ofd.Title = "Chọn file dữ liệu (.txt) đã mã hóa";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txt_filedec.Text = ofd.FileName;
                }
            }
        }

        private void btn_keybrow_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Key Files (*.key)|*.key|All Files (*.*)|*.*";
                ofd.Title = "Chọn file khóa (.key)";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txt_key.Text = ofd.FileName;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataPath = txt_filedec.Text;
            string keyPath = txt_key.Text;

            try
            {
                // 1. Kiểm tra file có tồn tại không
                if (!File.Exists(dataPath) || !File.Exists(keyPath))
                {
                    MessageBox.Show("Không tìm thấy file dữ liệu hoặc file key.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Đọc file key
                byte[] desKey = File.ReadAllBytes(keyPath);

                // 3. Đọc file dữ liệu (Base64)
                string base64EncryptedData = File.ReadAllText(dataPath);
                byte[] encryptedData = Convert.FromBase64String(base64EncryptedData);

                // 4. Giải mã
                string decryptedText = desApp.Decrypt(encryptedData, desKey);

                // 5. === THAY ĐỔI TẠI ĐÂY ===
                // Thay vì hiển thị MessageBox, chúng ta lưu ra file

                // 5.1. Xác định đường dẫn file giải mã (trong thư mục bin/Debug)
                string decryptedFilePath = Path.Combine(Application.StartupPath, "danhsach_kh_GIAIMA.txt");

                // 5.2. Ghi file
                File.WriteAllText(decryptedFilePath, decryptedText, Encoding.UTF8);

                // 5.3. Thông báo cho người dùng
                MessageBox.Show($"Dữ liệu đã giải mã và lưu thành công!\n\nFile: {decryptedFilePath}", "Hoàn tất Giải mã");
                // === KẾT THÚC THAY ĐỔI ===
            }
            catch (System.Security.Cryptography.CryptographicException) // Bắt lỗi cụ thể hơn
            {
                MessageBox.Show("Giải mã thất bại. File key không đúng hoặc file dữ liệu đã bị thay đổi.", "Lỗi Giải Mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi giải mã: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
