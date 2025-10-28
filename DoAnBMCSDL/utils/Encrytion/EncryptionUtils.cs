using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBMCSDL.utils.Encrytion
{
    internal class EncryptionUtils
    {
        char[] characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+[]{};:<>,./?".ToCharArray();
        int length;

        public EncryptionUtils()
        {
            length = characters.Length;
        }

        private char encryptCharPlus(char c, int k)
        {
            int index = Array.IndexOf(characters, c);
            if (index != -1)
            {
                int newIndex = (index + k) % length;
                return characters[newIndex];
            }
            else
                return c;
        }

        private char encryptCharMutiply(char c, int k)
        {
            int index = Array.IndexOf(characters, c);
            if (index != -1)
            {
                int newIndex = (index * k) % length;
                return characters[newIndex];
            }
            else
                return c;
        }

        private char decryptCharPlus(char c, int k)
        {
            int index = Array.IndexOf(characters, c);
            if (index != -1)
            {
                int newIndex = (index - k) % length;
                if (newIndex < 0)
                {
                    newIndex += length;
                }
                return characters[newIndex];
            }
            else
                return c;
        }

        private int InverseNum(int b, int n)
        {
            int t0 = 0, t1 = 1;
            int r0 = n, r1 = b;

            while (r1 != 0)
            {
                int q = r0 / r1;

                int temp = r0 - q * r1;
                r0 = r1;
                r1 = temp;

                temp = t0 - q * t1;
                t0 = t1;
                t1 = temp;
            }

            if (r0 != 1)
            {
                return 0;
            }

            if (t0 < 0) t0 += n;
            return t0;
        }
        private char decryptCharMutiply(char c, int k)
        {
            int index = Array.IndexOf(characters, c);
            if (index != -1)
            {
                int kInverse = InverseNum(k, length);
                int newIndex = ((index * kInverse) % length);
                if (newIndex < 0)
                {
                    newIndex += length;
                }
                return characters[newIndex];
            }
            else
                return c;
        }

        public string decryptMessagePlus(string msg, int k)
        {
            msg = msg.ToUpper();
            string result = "";
            int len = msg.Length;
            for (int i = 0; i < len; i++)
            {
                result += decryptCharPlus(msg[i], k);
            }
            //Console.WriteLine($"Plus");
            //foreach (char c in msg)
            //{
            //    int idx = Array.IndexOf(characters, c);
            //    Console.WriteLine($"Char={c}, Index={idx}");
            //}

            return result;
        }

        public string decryptMessageMutiply(string msg, int k)
        {
            msg = msg.ToUpper();
            string result = "";
            int len = msg.Length;
            for (int i = 0; i < len; i++)
            {
                result += decryptCharMutiply(msg[i], k);
            }
            //Console.WriteLine($"Multiply");
            //foreach (char c in msg)
            //{
            //    int idx = Array.IndexOf(characters, c);
            //    Console.WriteLine($"Char={c}, Index={idx}");
            //}

            return result;
        }

        public string encryptMessagePlus(string msg, int k)
        {
            string result = "";
            msg = msg.ToUpper();
            int len = msg.Length;
                for (int i = 0; i < len; i++)
                {
                    result += encryptCharPlus(msg[i], k);
                }
            return result;
        }

        public string encryptMessageMultiply(string msg, int k)
        {
            string result = "";
            msg = msg.ToUpper();
            int len = msg.Length;
            for (int i = 0; i < len; i++)
            {
                result += encryptCharMutiply(msg[i], k);
            }
            return result;
        }
    }
}
