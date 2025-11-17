using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;


namespace File_Downloader.My
{

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
}
