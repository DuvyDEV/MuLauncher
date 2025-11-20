using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace File_Downloader
{
    [StandardModule]
    internal sealed class IniFileHelper
    {
        [DllImport("kernel32", EntryPoint = "GetPrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetPrivateProfileString(
          string section,
          string key,
          string defaultValue,
          StringBuilder returnValue,
          int size,
          string filePath);

        [DllImport("Kernel32", EntryPoint = "WritePrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool WritePrivateProfileString(
          string section,
          string key,
          string value,
          string filePath);

        public static string ReadValue(string iniFile, string section, string key, string defaultValue)
        {
            StringBuilder buffer = new StringBuilder(512);
            int charsRead = GetPrivateProfileString(section, key, defaultValue ?? string.Empty, buffer, buffer.Capacity, iniFile);
            return charsRead > 0 ? buffer.ToString(0, charsRead) : string.Empty;
        }

        public static void WriteValue(string iniFile, string section, string key, string value)
        {
            string sanitizedValue = (value ?? string.Empty).Replace("\r", string.Empty).Replace("\n", string.Empty);
            WritePrivateProfileString(section, key, sanitizedValue, iniFile);
        }
    }
}
