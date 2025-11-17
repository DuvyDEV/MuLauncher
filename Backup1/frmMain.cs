// Decompiled with JetBrains decompiler
// Type: File_Downloader.frmMain
// Assembly: ZeroLauncher, Version=2.0.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 3A2BC2C6-6C50-4584-B700-5D7713B95215
// Assembly location: C:\Mu Konoha 2.0\Launcher.exe

using File_Downloader.My;
using Ionic.Zip;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


namespace File_Downloader
{

[DesignerGenerated]
public class frmMain : Form
{
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components = new Container();
    [AccessedThroughProperty("lblpercent")]
    private Label _lblpercent;
    [AccessedThroughProperty("BackgroundWorker1")]
    private BackgroundWorker _BackgroundWorker1;
    [AccessedThroughProperty("ProgressBar1")]
    private ProgressBar _ProgressBar1;
    [AccessedThroughProperty("lblstat")]
    private Label _lblstat;
    [AccessedThroughProperty("Panel2")]
    private Panel _Panel2;
    [AccessedThroughProperty("lbl_estado_gen")]
    private Label _lbl_estado_gen;
    private string whereToSave;
    private int Version_Actual;
    private int Version_en_Proceso;
    private int Version_Nueva;
    private string txt_filename;

    [DebuggerNonUserCode]
    static frmMain()
    {
    }

    [DebuggerNonUserCode]
    public frmMain()
    {
        this.Load += new EventHandler(this.frmMain_Load);
        frmMain.__ENCAddToList((object)this);
        this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
        lock (frmMain.__ENCList)
        {
            if (frmMain.__ENCList.Count == frmMain.__ENCList.Capacity)
            {
                int index1 = 0;
                int num = checked(frmMain.__ENCList.Count - 1);
                int index2 = 0;
                while (index2 <= num)
                {
                    if (frmMain.__ENCList[index2].IsAlive)
                    {
                        if (index2 != index1)
                            frmMain.__ENCList[index1] = frmMain.__ENCList[index2];
                        checked { ++index1; }
                    }
                    checked { ++index2; }
                }
                frmMain.__ENCList.RemoveRange(index1, checked(frmMain.__ENCList.Count - index1));
                frmMain.__ENCList.Capacity = frmMain.__ENCList.Count;
            }
            frmMain.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
        }
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
        try
        {
            if (!disposing || this.components == null)
                return;
            this.components.Dispose();
        }
        finally
        {
            base.Dispose(disposing);
        }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
        this.lblpercent = new Label();
        this.BackgroundWorker1 = new BackgroundWorker();
        this.ProgressBar1 = new ProgressBar();
        this.lblstat = new Label();
        this.Panel2 = new Panel();
        this.lbl_estado_gen = new Label();
        this.Panel2.SuspendLayout();
        this.SuspendLayout();
        this.lblpercent.AutoSize = true;
        this.lblpercent.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
        this.lblpercent.ForeColor = SystemColors.ActiveCaption;
        Label lblpercent1 = this.lblpercent;
        Point point1 = new Point(210, 7);
        Point point2 = point1;
        lblpercent1.Location = point2;
        this.lblpercent.Name = "lblpercent";
        Label lblpercent2 = this.lblpercent;
        Size size1 = new Size(26, 15);
        Size size2 = size1;
        lblpercent2.Size = size2;
        this.lblpercent.TabIndex = 0;
        this.lblpercent.Text = "0 %";
        ProgressBar progressBar1_1 = this.ProgressBar1;
        point1 = new Point(5, 11);
        Point point3 = point1;
        progressBar1_1.Location = point3;
        this.ProgressBar1.Name = "ProgressBar1";
        ProgressBar progressBar1_2 = this.ProgressBar1;
        size1 = new Size(200, 5);
        Size size3 = size1;
        progressBar1_2.Size = size3;
        this.ProgressBar1.TabIndex = 4;
        this.lblstat.AutoSize = true;
        this.lblstat.BackColor = Color.Transparent;
        Label lblstat1 = this.lblstat;
        point1 = new Point(15, 68);
        Point point4 = point1;
        lblstat1.Location = point4;
        this.lblstat.Name = "lblstat";
        Label lblstat2 = this.lblstat;
        size1 = new Size(34, 15);
        Size size4 = size1;
        lblstat2.Size = size4;
        this.lblstat.TabIndex = 5;
        this.lblstat.Text = "stats";
        this.lblstat.Visible = false;
        this.Panel2.BackColor = Color.Transparent;
        this.Panel2.Controls.Add((Control)this.ProgressBar1);
        this.Panel2.Controls.Add((Control)this.lblpercent);
        Panel panel2_1 = this.Panel2;
        point1 = new Point(1, 18);
        Point point5 = point1;
        panel2_1.Location = point5;
        this.Panel2.Name = "Panel2";
        Panel panel2_2 = this.Panel2;
        size1 = new Size(334, 38);
        Size size5 = size1;
        panel2_2.Size = size5;
        this.Panel2.TabIndex = 7;
        this.lbl_estado_gen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        this.lbl_estado_gen.AutoSize = true;
        this.lbl_estado_gen.BackColor = Color.Transparent;
        this.lbl_estado_gen.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
        this.lbl_estado_gen.ForeColor = SystemColors.ActiveCaption;
        Label lblEstadoGen1 = this.lbl_estado_gen;
        point1 = new Point(3, 9);
        Point point6 = point1;
        lblEstadoGen1.Location = point6;
        this.lbl_estado_gen.Name = "lbl_estado_gen";
        Label lblEstadoGen2 = this.lbl_estado_gen;
        size1 = new Size(45, 15);
        Size size6 = size1;
        lblEstadoGen2.Size = size6;
        this.lbl_estado_gen.TabIndex = 10;
        this.lbl_estado_gen.Text = "Label9";
        this.AutoScaleDimensions = new SizeF(7f, 15f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.Red;
        size1 = new Size(357, 88);
        this.ClientSize = size1;
        this.Controls.Add((Control)this.lblstat);
        this.Controls.Add((Control)this.lbl_estado_gen);
        this.Controls.Add((Control)this.Panel2);
        this.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
        this.FormBorderStyle = FormBorderStyle.None;
        this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
        this.MaximizeBox = false;
        this.Name = nameof(frmMain);
        this.StartPosition = FormStartPosition.Manual;
        this.Tag = (object)"";
        this.Text = "File Downloader";
        this.TopMost = true;
        this.TransparencyKey = Color.Red;
        this.Panel2.ResumeLayout(false);
        this.Panel2.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    internal virtual Label lblpercent
    {
        [DebuggerNonUserCode]
        get => this._lblpercent;
        [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            this._lblpercent = value;
        }
    }

    internal virtual BackgroundWorker BackgroundWorker1
    {
        [DebuggerNonUserCode]
        get => this._BackgroundWorker1;
        [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            if (this._BackgroundWorker1 != null)
                this._BackgroundWorker1.DoWork -= workEventHandler;
            this._BackgroundWorker1 = value;
            if (this._BackgroundWorker1 == null)
                return;
            this._BackgroundWorker1.DoWork += workEventHandler;
        }
    }

    internal virtual ProgressBar ProgressBar1
    {
        [DebuggerNonUserCode]
        get => this._ProgressBar1;
        [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            this._ProgressBar1 = value;
        }
    }

    internal virtual Label lblstat
    {
        [DebuggerNonUserCode]
        get => this._lblstat;
        [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
        set => this._lblstat = value;
    }

    internal virtual Panel Panel2
    {
        [DebuggerNonUserCode]
        get => this._Panel2;
        [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
        set => this._Panel2 = value;
    }

    internal virtual Label lbl_estado_gen
    {
        [DebuggerNonUserCode]
        get => this._lbl_estado_gen;
        [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            this._lbl_estado_gen = value;
        }
    }

    public void DownloadComplete(bool cancelled)
    {
        if (cancelled)
        {
            Funciones.addConsole($"{Variables_Languaje.lng08} {Conversions.ToString(this.Version_en_Proceso)} ...", byte.MaxValue, (byte)100, (byte)200, false, false);
        }
        else
        {
            Funciones.addConsole($"{Variables_Languaje.lng09} {Conversions.ToString(this.Version_en_Proceso)} ...", (byte)27, (byte)82, (byte)127 /*0x7F*/, false, false);
            Variables_Glob.True_Actualizado = 1;
            ZipFile.Read($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\updates\\Parche{Conversions.ToString(this.Version_en_Proceso)}.zip").ExtractAll(Application.StartupPath, ExtractExistingFileAction.OverwriteSilently);
            MyProject.Computer.FileSystem.DeleteFile($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\Update.ini");
            MyProject.Computer.FileSystem.WriteAllText($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\Update.ini", Conversions.ToString(this.Version_en_Proceso), true);
            if (this.Version_en_Proceso == this.Version_Nueva)
            {
                MyProject.Forms.Form1.Timer1.Enabled = false;
                MyProject.Forms.Form1.Timer_close_update.Enabled = true;
                MyProject.Forms.Form1.Timer_close_update.Interval = 100;
                MyProject.Forms.Form1.btn_start.Enabled = true;
                MyProject.Forms.Form1.btn_start.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\start1.bmp");
                Funciones.addConsole(Variables_Languaje.lng10, (byte)27, (byte)82, (byte)127 /*0x7F*/, false, false);
                this.Close();
            }
            else if (this.Version_en_Proceso < this.Version_Nueva)
            {
                MyProject.Forms.Form1.Timer_close_update.Enabled = true;
                MyProject.Forms.Form1.Timer_close_update.Interval = 100;
                MyProject.Forms.Form1.Timer1.Enabled = true;
                MyProject.Forms.Form1.Timer1.Interval = 2000;
                this.Close();
            }
            else
            {
                MyProject.Forms.Form1.Timer1.Enabled = false;
                MyProject.Forms.Form1.Timer_close_update.Enabled = true;
                MyProject.Forms.Form1.Timer_close_update.Interval = 100;
                MyProject.Forms.Form1.btn_start.Enabled = true;
                MyProject.Forms.Form1.btn_start.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\start1.bmp");
                Funciones.addConsole(Variables_Languaje.lng10, (byte)27, (byte)82, (byte)127 /*0x7F*/, false, false);
                this.Close();
            }
        }
        this.ProgressBar1.Value = 0;
    }

    public void ChangeTexts(long length, int position, int percent, double speed)
    {
        this.lblpercent.Text = Conversions.ToString(this.ProgressBar1.Value) + " %";
        this.lbl_estado_gen.Text = $"[ {$"{Conversions.ToString(Math.Round((double)position / 1024.0 / 1024.0, 2))} MB of {Conversions.ToString(Math.Round((double)length / 1024.0 / 1024.0, 2))}MB"} ] - {(speed != 0.0 ? Conversions.ToString(Math.Round(speed / 1024.0, 2)) + " KB/s" : Variables_Languaje.lng11)}";
        this.ProgressBar1.Value = percent;
    }

    private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
        HttpWebResponse response;
        try
        {
            response = (HttpWebResponse)((HttpWebRequest)WebRequest.Create(this.txt_filename)).GetResponse();
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            this.Invoke((Delegate)new frmMain.DownloadCompleteSafe(this.DownloadComplete), (object)true);
            ProjectData.ClearProjectError();
            return;
        }
        long contentLength = response.ContentLength;
        frmMain.ChangeTextsSafe method = new frmMain.ChangeTextsSafe(this.ChangeTexts);
        this.Invoke((Delegate)method, (object)contentLength, (object)0, (object)0, (object)0);
        FileStream fileStream = new FileStream(this.whereToSave, FileMode.Create);
        Stopwatch stopwatch = new Stopwatch();
        double num1 = -1.0;
        int num2 = 0;
        int num3 = 0;
        while (!this.BackgroundWorker1.CancellationPending)
        {
            stopwatch.Start();
            byte[] numArray = new byte[4096 /*0x1000*/];
            int count = response.GetResponseStream().Read(numArray, 0, 4096 /*0x1000*/);
            checked { num3 += count; }
            short num4 = checked((short)Math.Round(unchecked((double)num3 / (double)contentLength * 100.0)));
            this.Invoke((Delegate)method, (object)contentLength, (object)num3, (object)num4, (object)num1);
            if (count != 0)
            {
                fileStream.Write(numArray, 0, count);
                stopwatch.Stop();
                checked { ++num2; }
                if (num2 >= 5)
                {
                    num1 = 20480.0 / ((double)stopwatch.ElapsedMilliseconds / 1000.0);
                    stopwatch.Reset();
                    num2 = 0;
                }
            }
            else
                break;
        }
        response.GetResponseStream().Close();
        fileStream.Close();
        if (this.BackgroundWorker1.CancellationPending)
        {
            System.IO.File.Delete(this.whereToSave);
            this.Invoke((Delegate)new frmMain.DownloadCompleteSafe(this.DownloadComplete), (object)true);
        }
        else
            this.Invoke((Delegate)new frmMain.DownloadCompleteSafe(this.DownloadComplete), (object)false);
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        MyProject.Forms.Form1.btn_start.Enabled = false;
        MyProject.Forms.Form1.btn_start.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\start0.bmp");
        this.Version_Actual = Conversions.ToInteger(MyProject.Computer.FileSystem.ReadAllText($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\Update.ini"));
        this.Version_en_Proceso = checked(this.Version_Actual + 1);
        this.Version_Nueva = Conversions.ToInteger(MyProject.Computer.FileSystem.ReadAllText(Variables_Glob.Def_Carpeta_Temp + "\\VEREXE.txt"));
        if (this.Version_Actual < this.Version_Nueva)
        {
            this.txt_filename = $"{Variables_Glob.Config_Update_url}update\\Parche{Conversions.ToString(this.Version_en_Proceso)}.zip";
            if (Operators.CompareString(this.txt_filename, "", false) != 0 && this.txt_filename.StartsWith("http://"))
            {
                this.whereToSave = $"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\updates\\Parche{Conversions.ToString(this.Version_en_Proceso)}.zip";
                this.BackgroundWorker1.RunWorkerAsync();
                Funciones.addConsole($"{Variables_Languaje.lng12} {Conversions.ToString(this.Version_en_Proceso)} ...", byte.MaxValue, byte.MaxValue, byte.MaxValue, false, false);
            }
            else
            {
                int num = (int)MessageBox.Show(Variables_Languaje.lng13, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        else
        {
            Funciones.addConsole(Variables_Languaje.lng07, (byte)27, (byte)82, (byte)127 /*0x7F*/, false, false);
            MyProject.Forms.Form1.btn_start.Enabled = true;
            MyProject.Forms.Form1.btn_start.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\start1.bmp");
        }
    }

    public delegate void ChangeTextsSafe(long length, int position, int percent, double speed);

    public delegate void DownloadCompleteSafe(bool cancelled);
}
}
