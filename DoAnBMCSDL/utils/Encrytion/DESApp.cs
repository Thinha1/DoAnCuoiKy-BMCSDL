using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBMCSDL.utils.Encrytion
{
    internal class DESApp
    {
        //Vector khởi tạo
        byte[] IV = { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };

        public byte[] GenerateKey()
        {
            byte[] key;
            using(DES des = DES.Create())
            {
                key = des.Key;
            }
            return key;
        }

        public byte[] Encrypt(string plaintext, byte[] key)
        {
            try
            {
                using (MemoryStream mStream = new MemoryStream())
                {
                    using (DES des = DES.Create())
                    using (ICryptoTransform encryptor = des.CreateEncryptor(key, IV))
                    using (var cStream = new CryptoStream(mStream, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] toEncrypt = Encoding.UTF8.GetBytes(plaintext);

                        cStream.Write(toEncrypt, 0, toEncrypt.Length);
                    }

                    byte[] ret = mStream.ToArray();
                    return ret;
                }
            }
            catch (CryptographicException e)
            {
                throw e;
            }
        }

        public string Decrypt(byte[] encrypted, byte[] key)
        {
            try
            {
                byte[] decrypted = new byte[encrypted.Length];
                int offset = 0;
                using (MemoryStream mStream = new MemoryStream(encrypted))
                {
                    //Tạo des
                    using (DES des = DES.Create())
                    //Tạo decryptor
                    using (ICryptoTransform decryptor = des.CreateDecryptor(key, IV))
                    using (var cStream = new CryptoStream(mStream, decryptor, CryptoStreamMode.Read))
                    {
                        int read = 1;
                        while (read > 0)
                        {
                            read = cStream.Read(decrypted, offset, decrypted.Length - offset);
                            offset += read;
                        }
                    }
                    return Encoding.UTF8.GetString(decrypted, 0, offset);
                }
            }
            catch (CryptographicException e)
            {
                throw e;
            }
        }
    }
}
