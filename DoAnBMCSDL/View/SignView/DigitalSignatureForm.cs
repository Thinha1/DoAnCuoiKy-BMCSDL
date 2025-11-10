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

namespace DoAnBMCSDL.View.SignView
{
    public partial class DigitalSignatureForm : Form
    {
        public DigitalSignatureForm()
        {
            CenterToParent();
            InitializeComponent();
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
    }
}
