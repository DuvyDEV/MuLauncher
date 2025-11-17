using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;


namespace File_Downloader
{

    [StandardModule]
    internal sealed class Manejo_INI
    {
        [DllImport("kernel32", EntryPoint = "GetPrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetPrivateProfileStringKey(
          string lpApplicationName,
          string lpKeyName,
          string lpDefault,
          StringBuilder lpReturnedString,
          int nSize,
          string lpFileName);

        [DllImport("kernel32", EntryPoint = "GetPrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetPrivateProfileStringNullKey(
          string lpApplicationName,
          int lpKeyName,
          string lpDefault,
          StringBuilder lpReturnedString,
          int nSize,
          string lpFileName);

        [DllImport("Kernel32", EntryPoint = "WritePrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool WritePrivateProfileString(
          string lpApplicationName,
          string lpKeyName,
          string lpString,
          string lpFileName);

        public static string LeerINI(string sINIFile, string sSection, string sKey, string sDefault)
        {
            StringBuilder buffer = new StringBuilder(512);
            int charsRead = Manejo_INI.GetPrivateProfileStringKey(sSection, sKey, sDefault ?? string.Empty, buffer, buffer.Capacity, sINIFile);
            return charsRead > 0 ? buffer.ToString(0, charsRead) : string.Empty;
        }

        public static void EscribirINI(string sINIFile, string sSection, string sKey, string sValue)
        {
            string sanitizedValue = sValue ?? string.Empty;
            sanitizedValue = sanitizedValue.Replace("\r", string.Empty).Replace("\n", string.Empty);
            Manejo_INI.WritePrivateProfileString(sSection, sKey, sanitizedValue, sINIFile);
        }
    }
}
