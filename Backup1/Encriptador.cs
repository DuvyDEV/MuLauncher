// Decompiled with JetBrains decompiler
// Type: File_Downloader.Encriptador
// Assembly: ZeroLauncher, Version=2.0.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 3A2BC2C6-6C50-4584-B700-5D7713B95215
// Assembly location: C:\Mu Konoha 2.0\Launcher.exe

using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace File_Downloader
{
    [StandardModule]
    internal sealed class Encriptador
    {
        public const string sSecretKey = "AOHFREEL";

        [DebuggerNonUserCode]
        static Encriptador()
        {
        }

        public static void EncryptFile(string sInputFilename, string sOutputFilename, string sKey)
        {
            FileStream fileStream1 = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
            FileStream fileStream2 = new FileStream(sOutputFilename, FileMode.Create, FileAccess.Write);
            DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
            cryptoServiceProvider.Key = Encoding.ASCII.GetBytes(sKey);
            cryptoServiceProvider.IV = Encoding.ASCII.GetBytes(sKey);
            ICryptoTransform encryptor = cryptoServiceProvider.CreateEncryptor();
            CryptoStream cryptoStream = new CryptoStream((Stream)fileStream2, encryptor, CryptoStreamMode.Write);
            byte[] numArray = new byte[checked((int)(fileStream1.Length - 1L) + 1)];
            fileStream1.Read(numArray, 0, numArray.Length);
            cryptoStream.Write(numArray, 0, numArray.Length);
            cryptoStream.Flush();
            cryptoStream.Close();
        }

        public static void DecryptFile(string sInputFilename, string sOutputFilename, string sKey)
        {
            DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
            cryptoServiceProvider.Key = Encoding.ASCII.GetBytes(sKey);
            cryptoServiceProvider.IV = Encoding.ASCII.GetBytes(sKey);
            CryptoStream cryptoStream = new CryptoStream((Stream)new FileStream(sInputFilename, FileMode.Open, FileAccess.Read), cryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read);
            StreamWriter streamWriter = new StreamWriter(sOutputFilename);
            streamWriter.Write(new StreamReader((Stream)cryptoStream).ReadToEnd());
            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
