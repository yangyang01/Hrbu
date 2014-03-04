using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace WS.Eka.HTHR.Utility
{
    public class EncryptTool
    {
        public static string Encrypt(string text, string key)
        {
            DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            dESCryptoServiceProvider.Key = (Encoding.ASCII.GetBytes(key));
            dESCryptoServiceProvider.IV = (Encoding.ASCII.GetBytes(key));
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(bytes, 0, bytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] array = memoryStream.ToArray();
            return Convert.ToBase64String(array);
        }
        public static string Decrypt(string text, string key)
        {
            DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
            byte[] array = Convert.FromBase64String(text);
            dESCryptoServiceProvider.Key = (Encoding.ASCII.GetBytes(key));
            dESCryptoServiceProvider.IV = (Encoding.ASCII.GetBytes(key));
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(array, 0, array.Length);
            cryptoStream.FlushFinalBlock();
            StringBuilder stringBuilder = new StringBuilder();
            return Encoding.UTF8.GetString(memoryStream.ToArray());
        }

        public static string ToMD5(string text)
        {
            MD5 md5Hasher = MD5.Create();
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(text));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
