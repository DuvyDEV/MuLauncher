// Decompiled with JetBrains decompiler
// Type: File_Downloader.Manejo_INI
// Assembly: ZeroLauncher, Version=2.0.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 3A2BC2C6-6C50-4584-B700-5D7713B95215
// Assembly location: C:\Mu Konoha 2.0\Launcher.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.InteropServices;


namespace File_Downloader
{

[StandardModule]
internal sealed class Manejo_INI
{
    [DllImport("kernel32", EntryPoint = "GetPrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int GetPrivateProfileStringKey(
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDefault,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpReturnedString,
      int nSize,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

    [DllImport("kernel32", EntryPoint = "GetPrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int GetPrivateProfileStringNullKey(
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName,
      int lpKeyName,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDefault,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpReturnedString,
      int nSize,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

    [DllImport("Kernel32", EntryPoint = "WritePrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern long WritePrivateProfileString(
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName,
      object lpKeyName,
      object lpString,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

    public static string LeerINI(string sINIFile, string sSection, string sKey, string sDefault)
    {
        string lpReturnedString = Strings.Space(256 /*0x0100*/);
        int profileStringKey = Manejo_INI.GetPrivateProfileStringKey(ref sSection, ref sKey, ref sDefault, ref lpReturnedString, (int)byte.MaxValue, ref sINIFile);
        return Strings.Left(lpReturnedString, profileStringKey);
    }

    public static void EscribirINI(string sINIFile, string sSection, string sKey, string sValue)
    {
        string lpString = sValue;
        int num1 = Strings.Len(sValue);
        int num2 = 1;
        while (num2 <= num1)
        {
            if (Operators.CompareString(Strings.Mid(sValue, num2, 1), "\r", false) == 0 | Operators.CompareString(Strings.Mid(sValue, num2, 1), "\n", false) == 0)
                StringType.MidStmtStr(ref sValue, num2, int.MaxValue, "");
            checked { ++num2; }
        }
        int num3 = checked((int)Manejo_INI.WritePrivateProfileString(ref sSection, (object)sKey, (object)lpString, ref sINIFile));
    }
}
}
