using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.IO;
using System.Security.Cryptography;
namespace DoAnBMCSDL.utils.Encrytion
{
    internal class RSAApp
    {
        public string[] GenerateKeys()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048)) // Kích thước khóa 2048 bit
            {
                string[] keys = new string[2];
                keys[0] = rsa.ToXmlString(false); // false = chỉ lấy Public Key
                keys[1] = rsa.ToXmlString(true);  // true = lấy cả Private Key
                return keys;
            }
        }


        // Tạo và lưu trữ cặp khóa ra file
        public void GenerateAndSaveKeys(string publicKeyFilePath, string privateKeyFilePath)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
            {
                // Lấy khóa
                string publicKey = rsa.ToXmlString(false);
                string privateKey = rsa.ToXmlString(true);

                // Ghi ra file
                File.WriteAllText(publicKeyFilePath, publicKey);
                File.WriteAllText(privateKeyFilePath, privateKey);
            }
        }


        // Mã hóa một chuỗi sử dụng Public Key (XML string)
        public byte[] Encrypt(string plainText, string publicKeyXml)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    // Nạp Public Key
                    rsa.FromXmlString(publicKeyXml);

                    // Chuyển chuỗi cần mã hóa sang byte
                    byte[] dataToEncrypt = Encoding.UTF8.GetBytes(plainText);

                    // Thực hiện mã hóa
                    // false = không sử dụng OAEP padding (để tương thích)
                    byte[] encryptedData = rsa.Encrypt(dataToEncrypt, false);
                    return encryptedData;
                }
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        // Mã hóa một chuỗi sử dụng Public Key từ FILE
        public byte[] EncryptFromFile(string plainText, string publicKeyFilePath)
        {
            try
            {
                // Đọc nội dung file public key
                string publicKeyXml = File.ReadAllText(publicKeyFilePath);
                // Gọi hàm mã hóa gốc
                return Encrypt(plainText, publicKeyXml);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw; // Ném lỗi ra ngoài để form xử lý
            }
        }


        // Giải mã một mảng byte sử dụng Private Key (XML string)
        public string Decrypt(byte[] encryptedData, string privateKeyXml)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    // Nạp Private Key
                    rsa.FromXmlString(privateKeyXml);

                    // Thực hiện giải mã
                    byte[] decryptedData = rsa.Decrypt(encryptedData, false);

                    // Chuyển byte đã giải mã về chuỗi UTF8
                    string plainText = Encoding.UTF8.GetString(decryptedData);
                    return plainText;
                }
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        // Giải mã một mảng byte sử dụng Private Key từ FILE
        public string DecryptFromFile(byte[] encryptedData, string privateKeyFilePath)
        {
            try
            {
                // Đọc nội dung file private key
                string privateKeyXml = File.ReadAllText(privateKeyFilePath);
                // Gọi hàm giải mã gốc
                return Decrypt(encryptedData, privateKeyXml);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw; // Ném lỗi ra ngoài để form xử lý
            }
        }




    }
}
