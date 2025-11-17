// Decompiled with JetBrains decompiler
// Type: File_Downloader.My.MySettings
// Assembly: ZeroLauncher, Version=2.0.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 3A2BC2C6-6C50-4584-B700-5D7713B95215
// Assembly location: C:\Mu Konoha 2.0\Launcher.exe

using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;


namespace File_Downloader.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
    private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized((SettingsBase)new MySettings());
    private static bool addedHandler;
    private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

    [DebuggerNonUserCode]
    public MySettings()
    {
    }

    [DebuggerNonUserCode]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    private static void AutoSaveSettings(object sender, EventArgs e)
    {
        if (!MyProject.Application.SaveMySettingsOnExit)
            return;
        MySettingsProperty.Settings.Save();
    }

    public static MySettings Default
    {
        get
        {
            if (!MySettings.addedHandler)
            {
                object handlerLockObject = MySettings.addedHandlerLockObject;
                ObjectFlowControl.CheckForSyncLockOnValueType(handlerLockObject);
                Monitor.Enter(handlerLockObject);
                try
                {
                    if (!MySettings.addedHandler)
                    {
                        MyProject.Application.Shutdown += (ShutdownEventHandler)([DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Advanced)] (sender, e) =>
                        {
                            if (!MyProject.Application.SaveMySettingsOnExit)
                                return;
                            MySettingsProperty.Settings.Save();
                        });
                        MySettings.addedHandler = true;
                    }
                }
                finally
                {
                    Monitor.Exit(handlerLockObject);
                }
            }
            MySettings defaultInstance = MySettings.defaultInstance;
            return defaultInstance;
        }
    }
}
