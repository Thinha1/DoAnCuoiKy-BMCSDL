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



namespace DoAnBMCSDL.View.DichVuView
{
    public partial class DecryptRSA: Form
    {

        private RSAApp rsaApp = new RSAApp();


        private string dataFilePathDefault = Path.Combine(Application.StartupPath, "danhsach_dv_mahoa_rsa.txt");
        private string keyFilePathDefault = Path.Combine(Application.StartupPath, "rsa_dv_private.xml"); 
        public DecryptRSA()
        {
            InitializeComponent();
            rsaApp = new RSAApp();
        }

        private void btn_decbrow_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                ofd.Title = "Chọn file dữ liệu (.txt) đã mã hóa RSA";
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
                ofd.Filter = "XML Key Files (*.xml)|*.xml|All Files (*.*)|*.*";
                ofd.Title = "Chọn file Private Key (.xml)";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txt_key.Text = ofd.FileName;
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string dataPath = txt_filedec.Text;
            string privateKeyPath = txt_key.Text; 

            try
            {
             
                if (!File.Exists(dataPath) || !File.Exists(privateKeyPath))
                {
                    MessageBox.Show("Không tìm thấy file dữ liệu hoặc file Private Key.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            
                string base64EncryptedData = File.ReadAllText(dataPath);
                byte[] encryptedData = Convert.FromBase64String(base64EncryptedData);

    
                string decryptedText = rsaApp.DecryptFromFile(encryptedData, privateKeyPath);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Chọn nơi lưu file dịch vụ đã giải mã";
                saveFileDialog.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.FileName = "danhsach_dv_GIAIMA.txt"; 

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
           
                    string decryptedFilePath = saveFileDialog.FileName;

          
                    File.WriteAllText(decryptedFilePath, decryptedText, Encoding.UTF8);

              
                    MessageBox.Show($"Dữ liệu Dịch Vụ đã giải mã RSA và lưu thành công!\n\nFile: {decryptedFilePath}", "Hoàn tất Giải mã");
                }
                else
                {
        
                    MessageBox.Show("Thao tác lưu file giải mã đã bị hủy.", "Đã hủy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                MessageBox.Show("Giải mã thất bại. File key không đúng hoặc file dữ liệu đã bị thay đổi.", "Lỗi Giải Mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi giải mã RSA: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
