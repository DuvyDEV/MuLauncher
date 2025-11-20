using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace File_Downloader
{
    /// <summary>
    /// Provides basic DES-based encryption helpers used by the launcher.
    /// </summary>
    [StandardModule]
    internal sealed class EncryptionUtility
    {
        public const string SecretKey = "AOHFREEL";

        private EncryptionUtility()
        {
        }

        public static void EncryptFile(string inputFile, string outputFile, string key)
        {
            using (FileStream sourceStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
            using (DESCryptoServiceProvider provider = new DESCryptoServiceProvider())
            {
                provider.Key = Encoding.ASCII.GetBytes(key);
                provider.IV = Encoding.ASCII.GetBytes(key);

                using (CryptoStream cryptoStream = new CryptoStream(destinationStream, provider.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    byte[] buffer = new byte[sourceStream.Length];
                    sourceStream.Read(buffer, 0, buffer.Length);
                    cryptoStream.Write(buffer, 0, buffer.Length);
                    cryptoStream.FlushFinalBlock();
                }
            }
        }

        public static void DecryptFile(string inputFile, string outputFile, string key)
        {
            using (DESCryptoServiceProvider provider = new DESCryptoServiceProvider())
            {
                provider.Key = Encoding.ASCII.GetBytes(key);
                provider.IV = Encoding.ASCII.GetBytes(key);

                using (CryptoStream cryptoStream = new CryptoStream(new FileStream(inputFile, FileMode.Open, FileAccess.Read), provider.CreateDecryptor(), CryptoStreamMode.Read))
                using (StreamReader reader = new StreamReader(cryptoStream))
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    writer.Write(reader.ReadToEnd());
                }
            }
        }
    }
}
