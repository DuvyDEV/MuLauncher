// Decompiled with JetBrains decompiler
// Type: File_Downloader.My.MySettingsProperty
// Assembly: ZeroLauncher, Version=2.0.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 3A2BC2C6-6C50-4584-B700-5D7713B95215
// Assembly location: C:\Mu Konoha 2.0\Launcher.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;


namespace File_Downloader.My;

[StandardModule]
[CompilerGenerated]
[DebuggerNonUserCode]
[HideModuleName]
internal sealed class MySettingsProperty
{
    [HelpKeyword("My.Settings")]
    internal static MySettings Settings
    {
        get
        {
            MySettings settings = MySettings.Default;
            return settings;
        }
    }
}
