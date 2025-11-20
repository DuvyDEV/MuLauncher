using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace File_Downloader.My
{
    [GeneratedCode("MyTemplate", "8.0.0.0")]
    [StandardModule]
    [HideModuleName]
    internal sealed class MyProject
    {
        private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
        private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
        private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
        private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
        private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

        [DebuggerNonUserCode]
        static MyProject()
        {
        }

        [HelpKeyword("My.Computer")]
        internal static MyComputer Computer
        {
            [DebuggerHidden]
            get => MyProject.m_ComputerObjectProvider.GetInstance;
        }

        [HelpKeyword("My.Application")]
        internal static MyApplication Application
        {
            [DebuggerHidden]
            get => MyProject.m_AppObjectProvider.GetInstance;
        }

        [HelpKeyword("My.User")]
        internal static User User
        {
            [DebuggerHidden]
            get => MyProject.m_UserObjectProvider.GetInstance;
        }

        [HelpKeyword("My.Forms")]
        internal static MyProject.MyForms Forms
        {
            [DebuggerHidden]
            get => MyProject.m_MyFormsObjectProvider.GetInstance;
        }

        [HelpKeyword("My.WebServices")]
        internal static MyProject.MyWebServices WebServices
        {
            [DebuggerHidden]
            get => MyProject.m_MyWebServicesObjectProvider.GetInstance;
        }

        [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class MyForms
        {
            public LauncherForm m_LauncherForm;
            public SettingsForm m_SettingsForm;
            public UpdateProgressForm m_UpdateProgressForm;
            [ThreadStatic]
            private static Hashtable m_FormBeingCreated;

            public LauncherForm LauncherForm
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_LauncherForm = MyProject.MyForms.Create__Instance__<LauncherForm>(this.m_LauncherForm);
                    return this.m_LauncherForm;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value == this.m_LauncherForm)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<LauncherForm>(ref this.m_LauncherForm);
                }
            }

            public SettingsForm SettingsForm
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_SettingsForm = MyProject.MyForms.Create__Instance__<SettingsForm>(this.m_SettingsForm);
                    return this.m_SettingsForm;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value == this.m_SettingsForm)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<SettingsForm>(ref this.m_SettingsForm);
                }
            }

            public UpdateProgressForm UpdateProgressForm
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_UpdateProgressForm = MyProject.MyForms.Create__Instance__<UpdateProgressForm>(this.m_UpdateProgressForm);
                    return this.m_UpdateProgressForm;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (value == this.m_UpdateProgressForm)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<UpdateProgressForm>(ref this.m_UpdateProgressForm);
                }
            }

            [DebuggerHidden]
            private static T Create__Instance__<T>(T Instance) where T : Form, new()
            {
                if ((object)Instance != null && !Instance.IsDisposed)
                    return Instance;
                if (MyProject.MyForms.m_FormBeingCreated != null)
                {
                    if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object)typeof(T)))
                        throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
                }
                else
                {
                    MyProject.MyForms.m_FormBeingCreated = new Hashtable();
                }

                MyProject.MyForms.m_FormBeingCreated.Add((object)typeof(T), (object)null);
                try
                {
                    return new T();
                }
                catch (TargetInvocationException ex)
                {
                    if (ex.InnerException == null)
                        throw;

                    throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
                }
                finally
                {
                    MyProject.MyForms.m_FormBeingCreated.Remove((object)typeof(T));
                }
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance) where T : Form
            {
                if ((object)instance != null)
                {
                    instance.Dispose();
                }

                instance = default(T);
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public MyForms()
            {
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode() => base.GetHashCode();

            [EditorBrowsable(EditorBrowsableState.Never)]
            internal new System.Type GetType() => typeof(MyProject.MyForms);

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString() => base.ToString();
        }

        [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class MyWebServices
        {
            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode() => base.GetHashCode();

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            internal new System.Type GetType() => typeof(MyProject.MyWebServices);

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString() => base.ToString();

            [DebuggerHidden]
            private static T Create__Instance__<T>(T instance) where T : new()
            {
                return (object)instance == null ? new T() : instance;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance) => instance = default(T);

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public MyWebServices()
            {
            }
        }

        [ComVisible(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class ThreadSafeObjectProvider<T> where T : new()
        {
            [ThreadStatic]
            private static T m_ThreadStaticValue;

            internal T GetInstance
            {
                [DebuggerHidden]
                get
                {
                    if ((object)ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
                        ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
                    return ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
                }
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public ThreadSafeObjectProvider()
            {
            }
        }
    }
}
