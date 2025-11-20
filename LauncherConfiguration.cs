using File_Downloader.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Windows.Forms;

namespace File_Downloader
{
    [StandardModule]
    internal static class LauncherConfiguration
    {
        public static string LauncherDataFolder = "Data\\Launcher";
        public static string TimeStamp = DateTime.Now.ToString("yyyyMMddhhmmss");
        public static string TempDirectory = $"{Path.GetTempPath()}\\ZeroLauncherFree_{TimeStamp}";
        public static string ServerName;
        public static string UpdateUrl;
        public static string NewsUrl;
        public static string ConsoleBackground;
        public static string UpdateBackground;
        public static string ClientExecutableName;
        public static string LanguageKey;
        public static string WebsiteUrl;
        public static string FacebookUrl;
        public static string ForumUrl;
        public static int IsUpdated;
        public static int BannerIndex;
        public static int MaxBannerIndex;
        public static int BannerInterval;

        public static void LoadFromDisk()
        {
            MyProject.Computer.FileSystem.CreateDirectory(TempDirectory);
            string encryptedConfigPath = PathHelper.Combine(Application.StartupPath, LauncherDataFolder, "Config.ini");
            string decryptedConfigPath = Path.Combine(TempDirectory, "ConfigDec.ini");
            EncryptionUtility.DecryptFile(encryptedConfigPath, decryptedConfigPath, EncryptionUtility.SecretKey);

            ServerName = IniFileHelper.ReadValue(decryptedConfigPath, "UPDATE", "Nombre_Server", "?");
            UpdateUrl = IniFileHelper.ReadValue(decryptedConfigPath, "UPDATE", "Update_url", "?");
            NewsUrl = IniFileHelper.ReadValue(decryptedConfigPath, "UPDATE", "Noticia_url", "?");
            ConsoleBackground = IniFileHelper.ReadValue(decryptedConfigPath, "UPDATE", "Fondo_console", "?");
            UpdateBackground = IniFileHelper.ReadValue(decryptedConfigPath, "UPDATE", "Fondo_update", "?");
            ClientExecutableName = IniFileHelper.ReadValue(decryptedConfigPath, "UPDATE", "Nombre_Main", "?");
            LanguageKey = IniFileHelper.ReadValue(decryptedConfigPath, "UPDATE", "Lenguaje_UPD", "?");
            WebsiteUrl = IniFileHelper.ReadValue(decryptedConfigPath, "BOTONES", "Url_Web", "?");
            FacebookUrl = IniFileHelper.ReadValue(decryptedConfigPath, "BOTONES", "Url_Facebook", "?");
            ForumUrl = IniFileHelper.ReadValue(decryptedConfigPath, "BOTONES", "Url_Foro", "?");

            BannerIndex = 1;
            MaxBannerIndex = 4;
            BannerInterval = 6000;
        }
    }
}
