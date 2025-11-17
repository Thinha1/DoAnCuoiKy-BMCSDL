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
          
                if (!File.Exists(dataPath) || !File.Exists(keyPath))
                {
                    MessageBox.Show("Không tìm thấy file dữ liệu hoặc file key.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                byte[] desKey = File.ReadAllBytes(keyPath);

                string base64EncryptedData = File.ReadAllText(dataPath);
                byte[] encryptedData = Convert.FromBase64String(base64EncryptedData);

                
                string decryptedText = desApp.Decrypt(encryptedData, desKey);

                string decryptedFilePath = Path.Combine(Application.StartupPath, "danhsach_kh_GIAIMA.txt");
        
                File.WriteAllText(decryptedFilePath, decryptedText, Encoding.UTF8);

             
                MessageBox.Show($"Dữ liệu đã giải mã và lưu thành công!\n\nFile: {decryptedFilePath}", "Hoàn tất Giải mã");
            }
            catch (System.Security.Cryptography.CryptographicException)             {
                MessageBox.Show("Giải mã thất bại. File key không đúng hoặc file dữ liệu đã bị thay đổi.", "Lỗi Giải Mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi giải mã: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
