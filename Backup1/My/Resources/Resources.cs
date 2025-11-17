// Decompiled with JetBrains decompiler
// Type: File_Downloader.My.Resources.Resources
// Assembly: ZeroLauncher, Version=2.0.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 3A2BC2C6-6C50-4584-B700-5D7713B95215
// Assembly location: C:\Mu Konoha 2.0\Launcher.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;


namespace File_Downloader.My.Resources
{

[HideModuleName]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[StandardModule]
[CompilerGenerated]
internal sealed class Resources
{
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
        get
        {
            if (object.ReferenceEquals((object)File_Downloader.My.Resources.Resources.resourceMan, (object)null))
                File_Downloader.My.Resources.Resources.resourceMan = new ResourceManager("File_Downloader.Resources", typeof(File_Downloader.My.Resources.Resources).Assembly);
            return File_Downloader.My.Resources.Resources.resourceMan;
        }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
        get => File_Downloader.My.Resources.Resources.resourceCulture;
        set => File_Downloader.My.Resources.Resources.resourceCulture = value;
    }

    internal static Bitmap main
    {
        get
        {
            return (Bitmap)RuntimeHelpers.GetObjectValue(File_Downloader.My.Resources.Resources.ResourceManager.GetObject(nameof(main), File_Downloader.My.Resources.Resources.resourceCulture));
        }
    }
}
}
