using File_Downloader.My;
using Launcherlib;
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
    public class Form1 : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components = new Container();
        [AccessedThroughProperty("RichTextBox1")]
        private RichTextBox _RichTextBox1;
        [AccessedThroughProperty("BackgroundWorker1")]
        private BackgroundWorker _BackgroundWorker1;
        [AccessedThroughProperty("Timer1")]
        private System.Windows.Forms.Timer _Timer1;
        [AccessedThroughProperty("cmenu")]
        private ContextMenuStrip _cmenu;
        [AccessedThroughProperty("Timer_close_update")]
        private System.Windows.Forms.Timer _Timer_close_update;
        [AccessedThroughProperty("PanelFormularios")]
        private Panel _PanelFormularios;
        [AccessedThroughProperty("Nav_Noticias")]
        private WebBrowser _Nav_Noticias;
        [AccessedThroughProperty("chk_winmode")]
        private CheckBox _chk_winmode;
        [AccessedThroughProperty("btn_settings")]
        private PictureBox _btn_settings;
        [AccessedThroughProperty("btn_min")]
        private PictureBox _btn_min;
        [AccessedThroughProperty("btn_cerrar")]
        private PictureBox _btn_cerrar;
        [AccessedThroughProperty("lbl_Nombre")]
        private Label _lbl_Nombre;
        [AccessedThroughProperty("btn_start")]
        private PictureBox _btn_start;
        [AccessedThroughProperty("Timer_Salir")]
        private System.Windows.Forms.Timer _Timer_Salir;
        [AccessedThroughProperty("Pic_Banners")]
        private PictureBox _Pic_Banners;
        [AccessedThroughProperty("lbl_news")]
        private Label _lbl_news;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Timer_Main")]
        private System.Windows.Forms.Timer _Timer_Main;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        private string whereToSave;
        private int Version_Actual;
        private int Version_en_Proceso;
        private int Version_Nueva;
        private const int WM_NCHITTEST = 132;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;
        private frmMain f_Form2;

        [DebuggerNonUserCode]
        static Form1()
        {
        }

        [DebuggerNonUserCode]
        private static void __ENCAddToList(object value)
        {
            lock (Form1.__ENCList)
            {
                if (Form1.__ENCList.Count == Form1.__ENCList.Capacity)
                {
                    int index1 = 0;
                    int num = checked(Form1.__ENCList.Count - 1);
                    int index2 = 0;
                    while (index2 <= num)
                    {
                        if (Form1.__ENCList[index2].IsAlive)
                        {
                            if (index2 != index1)
                                Form1.__ENCList[index1] = Form1.__ENCList[index2];
                            checked { ++index1; }
                        }
                        checked { ++index2; }
                    }
                    Form1.__ENCList.RemoveRange(index1, checked(Form1.__ENCList.Count - index1));
                    Form1.__ENCList.Capacity = Form1.__ENCList.Count;
                }
                Form1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
            this.components = (IContainer)new System.ComponentModel.Container();
            this.RichTextBox1 = new RichTextBox();
            this.BackgroundWorker1 = new BackgroundWorker();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmenu = new ContextMenuStrip(this.components);
            this.Timer_close_update = new System.Windows.Forms.Timer(this.components);
            this.PanelFormularios = new Panel();
            this.Nav_Noticias = new WebBrowser();
            this.chk_winmode = new CheckBox();
            this.btn_settings = new PictureBox();
            this.btn_min = new PictureBox();
            this.btn_cerrar = new PictureBox();
            this.lbl_Nombre = new Label();
            this.btn_start = new PictureBox();
            this.Timer_Salir = new System.Windows.Forms.Timer(this.components);
            this.Pic_Banners = new PictureBox();
            this.lbl_news = new Label();
            this.Label1 = new Label();
            this.Timer_Main = new System.Windows.Forms.Timer(this.components);
            this.Label2 = new Label();
            ((ISupportInitialize)this.btn_settings).BeginInit();
            ((ISupportInitialize)this.btn_min).BeginInit();
            ((ISupportInitialize)this.btn_cerrar).BeginInit();
            ((ISupportInitialize)this.btn_start).BeginInit();
            ((ISupportInitialize)this.Pic_Banners).BeginInit();
            this.SuspendLayout();
            this.RichTextBox1.BackColor = Color.Black;
            this.RichTextBox1.BorderStyle = BorderStyle.None;
            RichTextBox richTextBox1_1 = this.RichTextBox1;
            Point point1 = new Point(137, 449);
            Point point2 = point1;
            richTextBox1_1.Location = point2;
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.ReadOnly = true;
            this.RichTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            RichTextBox richTextBox1_2 = this.RichTextBox1;
            Size size1 = new Size(125, 62);
            Size size2 = size1;
            richTextBox1_2.Size = size2;
            this.RichTextBox1.TabIndex = 0;
            this.RichTextBox1.Text = "";
            this.BackgroundWorker1.WorkerSupportsCancellation = true;
            this.cmenu.Name = "cmenu";
            ContextMenuStrip cmenu = this.cmenu;
            size1 = new Size(61, 4);
            Size size3 = size1;
            cmenu.Size = size3;
            this.PanelFormularios.BackColor = Color.Transparent;
            Panel panelFormularios1 = this.PanelFormularios;
            point1 = new Point(496, 452);
            Point point3 = point1;
            panelFormularios1.Location = point3;
            this.PanelFormularios.Name = "PanelFormularios";
            Panel panelFormularios2 = this.PanelFormularios;
            size1 = new Size(260, 50);
            Size size4 = size1;
            panelFormularios2.Size = size4;
            this.PanelFormularios.TabIndex = 3;
            WebBrowser navNoticias1 = this.Nav_Noticias;
            point1 = new Point(137, 163);
            Point point4 = point1;
            navNoticias1.Location = point4;
            WebBrowser navNoticias2 = this.Nav_Noticias;
            size1 = new Size(20, 20);
            Size size5 = size1;
            navNoticias2.MinimumSize = size5;
            this.Nav_Noticias.Name = "Nav_Noticias";
            WebBrowser navNoticias3 = this.Nav_Noticias;
            size1 = new Size(337, 271);
            Size size6 = size1;
            navNoticias3.Size = size6;
            this.Nav_Noticias.TabIndex = 10;
            this.Nav_Noticias.Visible = false;
            this.chk_winmode.AutoSize = true;
            this.chk_winmode.BackColor = Color.Transparent;
            this.chk_winmode.ForeColor = SystemColors.ActiveCaption;
            CheckBox chkWinmode1 = this.chk_winmode;
            point1 = new Point(402, 486);
            Point point5 = point1;
            chkWinmode1.Location = point5;
            this.chk_winmode.Name = "chk_winmode";
            CheckBox chkWinmode2 = this.chk_winmode;
            size1 = new Size(72, 17);
            Size size7 = size1;
            chkWinmode2.Size = size7;
            this.chk_winmode.TabIndex = 12;
            this.chk_winmode.Text = "WinMode";
            this.chk_winmode.UseVisualStyleBackColor = false;
            this.btn_settings.BackColor = SystemColors.Control;
            PictureBox btnSettings1 = this.btn_settings;
            point1 = new Point(762, 449);
            Point point6 = point1;
            btnSettings1.Location = point6;
            this.btn_settings.Name = "btn_settings";
            PictureBox btnSettings2 = this.btn_settings;
            size1 = new Size(36, 51);
            Size size8 = size1;
            btnSettings2.Size = size8;
            this.btn_settings.TabIndex = 11;
            this.btn_settings.TabStop = false;
            this.btn_min.BackColor = Color.Transparent;
            PictureBox btnMin1 = this.btn_min;
            point1 = new Point(879, 86);
            Point point7 = point1;
            btnMin1.Location = point7;
            this.btn_min.Name = "btn_min";
            PictureBox btnMin2 = this.btn_min;
            size1 = new Size(14, 14);
            Size size9 = size1;
            btnMin2.Size = size9;
            this.btn_min.TabIndex = 14;
            this.btn_min.TabStop = false;
            this.btn_cerrar.BackColor = Color.Transparent;
            PictureBox btnCerrar1 = this.btn_cerrar;
            point1 = new Point(898, 86);
            Point point8 = point1;
            btnCerrar1.Location = point8;
            this.btn_cerrar.Name = "btn_cerrar";
            PictureBox btnCerrar2 = this.btn_cerrar;
            size1 = new Size(14, 14);
            Size size10 = size1;
            btnCerrar2.Size = size10;
            this.btn_cerrar.TabIndex = 13;
            this.btn_cerrar.TabStop = false;
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.BackColor = Color.Transparent;
            this.lbl_Nombre.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lbl_Nombre.ForeColor = Color.White;
            Label lblNombre1 = this.lbl_Nombre;
            point1 = new Point(156, 89);
            Point point9 = point1;
            lblNombre1.Location = point9;
            this.lbl_Nombre.Name = "lbl_Nombre";
            Label lblNombre2 = this.lbl_Nombre;
            size1 = new Size(91, 16 /*0x10*/);
            Size size11 = size1;
            lblNombre2.Size = size11;
            this.lbl_Nombre.TabIndex = 19;
            this.lbl_Nombre.Text = "KonohaLauncher";
            this.btn_start.BackColor = SystemColors.Control;
            PictureBox btnStart1 = this.btn_start;
            point1 = new Point(798, 449);
            Point point10 = point1;
            btnStart1.Location = point10;
            this.btn_start.Name = "btn_start";
            PictureBox btnStart2 = this.btn_start;
            size1 = new Size(89, 51);
            Size size12 = size1;
            btnStart2.Size = size12;
            this.btn_start.TabIndex = 20;
            this.btn_start.TabStop = false;
            this.Pic_Banners.BackColor = Color.Red;
            this.Pic_Banners.Enabled = false;
            PictureBox picBanners1 = this.Pic_Banners;
            point1 = new Point(338, 83);
            Point point11 = point1;
            picBanners1.Location = point11;
            this.Pic_Banners.Name = "Pic_Banners";
            PictureBox picBanners2 = this.Pic_Banners;
            size1 = new Size(581, 322);
            Size size13 = size1;
            picBanners2.Size = size13;
            this.Pic_Banners.TabIndex = 21;
            this.Pic_Banners.TabStop = false;
            this.lbl_news.AutoSize = true;
            this.lbl_news.BackColor = Color.Transparent;
            this.lbl_news.Cursor = Cursors.Hand;
            this.lbl_news.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lbl_news.ForeColor = Color.SteelBlue;
            Label lblNews1 = this.lbl_news;
            point1 = new Point(160 /*0xA0*/, 124);
            Point point12 = point1;
            lblNews1.Location = point12;
            this.lbl_news.Name = "lbl_News";
            Label lblNews2 = this.lbl_news;
            size1 = new Size(52, 20);
            Size size14 = size1;
            lblNews2.Size = size14;
            this.lbl_news.TabIndex = 22;
            this.lbl_news.Text = "News";
            this.Label1.AutoSize = true;
            this.Label1.BackColor = Color.Transparent;
            this.Label1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label1.ForeColor = Color.White;
            Label label1_1 = this.Label1;
            point1 = new Point(144 /*0x90*/, 120);
            Point point13 = point1;
            label1_1.Location = point13;
            this.Label1.Name = "Label1";
            Label label1_2 = this.Label1;
            size1 = new Size(21, 24);
            Size size15 = size1;
            label1_2.Size = size15;
            this.Label1.TabIndex = 23;
            this.Label1.Text = "»";
            this.Label2.AutoSize = true;
            this.Label2.BackColor = Color.Transparent;
            this.Label2.ForeColor = Color.White;
            Label label2_1 = this.Label2;
            point1 = new Point(611, 421);
            Point point14 = point1;
            label2_1.Location = point14;
            this.Label2.Name = "Label2";
            Label label2_2 = this.Label2;
            size1 = new Size(126, 13);
            Size size16 = size1;
            label2_2.Size = size16;
            this.Label2.TabIndex = 24;
            this.Label2.Text = "                        ";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Lime;
            this.BackgroundImage = (Image)File_Downloader.My.Resources.Resources.main;
            size1 = new Size(1114, 603);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.Label2);
            this.Controls.Add((Control)this.Label1);
            this.Controls.Add((Control)this.lbl_news);
            this.Controls.Add((Control)this.btn_start);
            this.Controls.Add((Control)this.lbl_Nombre);
            this.Controls.Add((Control)this.btn_min);
            this.Controls.Add((Control)this.btn_cerrar);
            this.Controls.Add((Control)this.chk_winmode);
            this.Controls.Add((Control)this.btn_settings);
            this.Controls.Add((Control)this.Nav_Noticias);
            this.Controls.Add((Control)this.PanelFormularios);
            this.Controls.Add((Control)this.RichTextBox1);
            this.Controls.Add((Control)this.Pic_Banners);
            this.FormBorderStyle = FormBorderStyle.None;
            Icon executableIcon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            if (executableIcon != null)
                this.Icon = executableIcon;
            this.MaximizeBox = false;
            size1 = new Size(1114, 603);
            this.MaximumSize = size1;
            this.Name = nameof(Form1);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "KonohaLauncher";
            this.TransparencyKey = Color.Lime;
            ((ISupportInitialize)this.btn_settings).EndInit();
            ((ISupportInitialize)this.btn_min).EndInit();
            ((ISupportInitialize)this.btn_cerrar).EndInit();
            ((ISupportInitialize)this.btn_start).EndInit();
            ((ISupportInitialize)this.Pic_Banners).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal virtual RichTextBox RichTextBox1
        {
            [DebuggerNonUserCode]
            get => this._RichTextBox1;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._RichTextBox1 = value;
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

        internal virtual System.Windows.Forms.Timer Timer1
        {
            [DebuggerNonUserCode]
            get => this._Timer1;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
                if (this._Timer1 != null)
                    this._Timer1.Tick -= eventHandler;
                this._Timer1 = value;
                if (this._Timer1 == null)
                    return;
                this._Timer1.Tick += eventHandler;
            }
        }

        internal virtual ContextMenuStrip cmenu
        {
            [DebuggerNonUserCode]
            get => this._cmenu;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._cmenu = value;
        }

        internal virtual System.Windows.Forms.Timer Timer_close_update
        {
            [DebuggerNonUserCode]
            get => this._Timer_close_update;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Timer_close_update_Tick);
                if (this._Timer_close_update != null)
                    this._Timer_close_update.Tick -= eventHandler;
                this._Timer_close_update = value;
                if (this._Timer_close_update == null)
                    return;
                this._Timer_close_update.Tick += eventHandler;
            }
        }

        internal virtual Panel PanelFormularios
        {
            [DebuggerNonUserCode]
            get => this._PanelFormularios;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._PanelFormularios = value;
            }
        }

        internal virtual WebBrowser Nav_Noticias
        {
            [DebuggerNonUserCode]
            get => this._Nav_Noticias;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Nav_Noticias = value;
            }
        }

        internal virtual CheckBox chk_winmode
        {
            [DebuggerNonUserCode]
            get => this._chk_winmode;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.chk_winmode_CheckedChanged);
                if (this._chk_winmode != null)
                    this._chk_winmode.CheckedChanged -= eventHandler;
                this._chk_winmode = value;
                if (this._chk_winmode == null)
                    return;
                this._chk_winmode.CheckedChanged += eventHandler;
            }
        }

        internal virtual PictureBox btn_settings
        {
            [DebuggerNonUserCode]
            get => this._btn_settings;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler1 = new EventHandler(this.btn_settings_Click);
                EventHandler eventHandler2 = new EventHandler(this.btn_settings_MouseLeave);
                EventHandler eventHandler3 = new EventHandler(this.btn_settings_MouseHover);
                if (this._btn_settings != null)
                {
                    this._btn_settings.Click -= eventHandler1;
                    this._btn_settings.MouseLeave -= eventHandler2;
                    this._btn_settings.MouseHover -= eventHandler3;
                }
                this._btn_settings = value;
                if (this._btn_settings == null)
                    return;
                this._btn_settings.Click += eventHandler1;
                this._btn_settings.MouseLeave += eventHandler2;
                this._btn_settings.MouseHover += eventHandler3;
            }
        }

        internal virtual PictureBox btn_min
        {
            [DebuggerNonUserCode]
            get => this._btn_min;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler1 = new EventHandler(this.btn_min_Click);
                EventHandler eventHandler2 = new EventHandler(this.btn_min_MouseLeave);
                EventHandler eventHandler3 = new EventHandler(this.btn_min_MouseHover);
                if (this._btn_min != null)
                {
                    this._btn_min.Click -= eventHandler1;
                    this._btn_min.MouseLeave -= eventHandler2;
                    this._btn_min.MouseHover -= eventHandler3;
                }
                this._btn_min = value;
                if (this._btn_min == null)
                    return;
                this._btn_min.Click += eventHandler1;
                this._btn_min.MouseLeave += eventHandler2;
                this._btn_min.MouseHover += eventHandler3;
            }
        }

        internal virtual PictureBox btn_cerrar
        {
            [DebuggerNonUserCode]
            get => this._btn_cerrar;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler1 = new EventHandler(this.btn_cerrar_Click);
                EventHandler eventHandler2 = new EventHandler(this.btn_cerrar_MouseLeave);
                EventHandler eventHandler3 = new EventHandler(this.btn_cerrar_MouseHover);
                if (this._btn_cerrar != null)
                {
                    this._btn_cerrar.Click -= eventHandler1;
                    this._btn_cerrar.MouseLeave -= eventHandler2;
                    this._btn_cerrar.MouseHover -= eventHandler3;
                }
                this._btn_cerrar = value;
                if (this._btn_cerrar == null)
                    return;
                this._btn_cerrar.Click += eventHandler1;
                this._btn_cerrar.MouseLeave += eventHandler2;
                this._btn_cerrar.MouseHover += eventHandler3;
            }
        }

        internal virtual Label lbl_Nombre
        {
            [DebuggerNonUserCode]
            get => this._lbl_Nombre;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lbl_Nombre = value;
            }
        }

        internal virtual PictureBox btn_start
        {
            [DebuggerNonUserCode]
            get => this._btn_start;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler1 = new EventHandler(this.btn_start_MouseLeave);
                EventHandler eventHandler2 = new EventHandler(this.btn_start_MouseHover);
                EventHandler eventHandler3 = new EventHandler(this.btn_start_Click);
                if (this._btn_start != null)
                {
                    this._btn_start.MouseLeave -= eventHandler1;
                    this._btn_start.MouseHover -= eventHandler2;
                    this._btn_start.Click -= eventHandler3;
                }
                this._btn_start = value;
                if (this._btn_start == null)
                    return;
                this._btn_start.MouseLeave += eventHandler1;
                this._btn_start.MouseHover += eventHandler2;
                this._btn_start.Click += eventHandler3;
            }
        }

        internal virtual System.Windows.Forms.Timer Timer_Salir
        {
            [DebuggerNonUserCode]
            get => this._Timer_Salir;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Timer_Salir_Tick);
                if (this._Timer_Salir != null)
                    this._Timer_Salir.Tick -= eventHandler;
                this._Timer_Salir = value;
                if (this._Timer_Salir == null)
                    return;
                this._Timer_Salir.Tick += eventHandler;
            }
        }

        internal virtual PictureBox Pic_Banners
        {
            [DebuggerNonUserCode]
            get => this._Pic_Banners;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Pic_Banners = value;
            }
        }

        internal virtual Label lbl_news
        {
            [DebuggerNonUserCode]
            get => this._lbl_news;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.lbl_news_Click);
                if (this._lbl_news != null)
                    this._lbl_news.Click -= eventHandler;
                this._lbl_news = value;
                if (this._lbl_news == null)
                    return;
                this._lbl_news.Click += eventHandler;
            }
        }

        internal virtual Label Label1
        {
            [DebuggerNonUserCode]
            get => this._Label1;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label1 = value;
        }

        internal virtual System.Windows.Forms.Timer Timer_Main
        {
            [DebuggerNonUserCode]
            get => this._Timer_Main;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Timer_Main_Tick);
                if (this._Timer_Main != null)
                    this._Timer_Main.Tick -= eventHandler;
                this._Timer_Main = value;
                if (this._Timer_Main == null)
                    return;
                this._Timer_Main.Tick += eventHandler;
            }
        }

        internal virtual Label Label2
        {
            [DebuggerNonUserCode]
            get => this._Label2;
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Label2_Click);
                if (this._Label2 != null)
                    this._Label2.Click -= eventHandler;
                this._Label2 = value;
                if (this._Label2 == null)
                    return;
                this._Label2.Click += eventHandler;
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 132)
            {
                base.WndProc(ref m);
                if (!(m.Result == (IntPtr)1))
                    return;
                m.Result = (IntPtr)2;
            }
            else
                base.WndProc(ref m);
        }

        private void Cargar_Config_INI()
        {
            this.lbl_Nombre.Text = Variables_Glob.Config_Nombre_Server;
            this.Nav_Noticias.ScriptErrorsSuppressed = true;
            this.Nav_Noticias.Navigate(Variables_Glob.Config_Noticia_url);
            this.RichTextBox1.BackColor = ColorTranslator.FromHtml(Variables_Glob.Config_Fondo_console);
        }

        private void Cargar_Inicio_Total()
        {
            this.Cargar_Config_INI();
            System.IO.File.Copy($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\main.png", Variables_Glob.Def_Carpeta_Temp + "\\main.png", true);
            System.IO.File.Copy($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\opcionbg.bmp", Variables_Glob.Def_Carpeta_Temp + "\\opcionbg.bmp", true);
            System.IO.File.Copy($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\registerbg.bmp", Variables_Glob.Def_Carpeta_Temp + "\\registerbg.bmp", true);
            this.BackgroundImage = (Image)new Bitmap(Variables_Glob.Def_Carpeta_Temp + "\\main.png");
            this.Pic_Banners.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\banners\\banner1.bmp");
            this.btn_min.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\min1.png");
            this.btn_cerrar.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\exit1.png");
            this.btn_settings.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\opciones0.bmp");
            this.btn_start.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\start0.bmp");
            this.btn_start.Enabled = false;
            this.chk_winmode.Checked = Conversions.ToBoolean(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "WindowMode", (object)null));
        }

        public Form1()
        {
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new EventHandler(this.Form1_Load);
            Form1.__ENCAddToList((object)this);
            this.InitializeComponent();
            this.f_Form2 = new frmMain();
        }

        public void DownloadComplete(bool cancelled)
        {
            if (cancelled)
            {
                Funciones.addConsole(Variables_Languaje.lng02, byte.MaxValue, (byte)0, (byte)0, false, false);
                int num = (int)MessageBox.Show($"{Variables_Languaje.lng03}\r{Variables_Languaje.lng04}", Variables_Languaje.lng05, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                Funciones.addConsole(Variables_Languaje.lng06, (byte)27, (byte)82, (byte)127 /*0x7F*/, false, false);
                this.Version_Actual = Conversions.ToInteger(MyProject.Computer.FileSystem.ReadAllText($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\Update.ini"));
                this.Version_en_Proceso = checked(this.Version_Actual + 1);
                this.Version_Nueva = Conversions.ToInteger(MyProject.Computer.FileSystem.ReadAllText(Variables_Glob.Def_Carpeta_Temp + "\\VEREXE.txt"));
                if (this.Version_Actual < this.Version_Nueva)
                {
                    this.f_Form2.TopLevel = false;
                    this.PanelFormularios.Controls.Add((Control)this.f_Form2);
                    this.f_Form2.BackColor = ColorTranslator.FromHtml(Variables_Glob.Config_Fondo_update);
                    this.f_Form2.Show();
                }
                else
                {
                    Funciones.addConsole(Variables_Languaje.lng07, (byte)27, (byte)82, (byte)127 /*0x7F*/, false, false);
                    this.btn_start.Enabled = true;
                    this.btn_start.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\start1.bmp");
                }
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Variables_Glob.True_Actualizado != 1)
            {
                string[] files = Directory.GetFiles($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\updates\\", "*.zip");
                int index = 0;
                while (index < files.Length)
                {
                    System.IO.File.Delete(files[index]);
                    checked { ++index; }
                }
                ProjectData.EndApp();
            }
            else
                ProjectData.EndApp();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Timer_Main.Interval = 3000;
            this.Timer_Main.Enabled = true;
            if (Directory.Exists(Variables_Glob.Def_Carpeta_Temp))
            {
                foreach (string file in MyProject.Computer.FileSystem.GetFiles(Variables_Glob.Def_Carpeta_Temp))
                {
                    MyProject.Computer.FileSystem.DeleteFile(file);
                }
            }
            Variables_Glob.Load_Config_INI();
            Variables_Languaje.Load_Lenguaje();
            this.Cargar_Inicio_Total();
            MyProject.Computer.FileSystem.DeleteFile(Variables_Glob.Def_Carpeta_Temp + "\\ConfigDec.ini");
            Funciones.addConsole(Variables_Languaje.lng01, byte.MaxValue, byte.MaxValue, byte.MaxValue, false, false);
            this.whereToSave = Variables_Glob.Def_Carpeta_Temp + "\\VEREXE.txt";
            this.BackgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)((HttpWebRequest)WebRequest.Create(Variables_Glob.Config_Update_url + "VEREXE.txt")).GetResponse();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                this.Invoke((Delegate)new Form1.DownloadCompleteSafe(this.DownloadComplete), (object)true);
                ProjectData.ClearProjectError();
                return;
            }
            long contentLength = response.ContentLength;
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
                this.Invoke((Delegate)new Form1.DownloadCompleteSafe(this.DownloadComplete), (object)true);
            }
            else
                this.Invoke((Delegate)new Form1.DownloadCompleteSafe(this.DownloadComplete), (object)false);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.f_Form2 = new frmMain();
            this.f_Form2.TopLevel = false;
            this.PanelFormularios.Controls.Add((Control)this.f_Form2);
            this.f_Form2.BackColor = ColorTranslator.FromHtml(Variables_Glob.Config_Fondo_update);
            this.f_Form2.Show();
            this.Timer1.Enabled = false;
        }

        private void Timer_close_update_Tick(object sender, EventArgs e)
        {
            this.f_Form2.Close();
            this.Timer_close_update.Enabled = false;
        }

        private void btn_cerrar_MouseHover(object sender, EventArgs e)
        {
            this.btn_cerrar.Cursor = Cursors.Hand;
            this.btn_cerrar.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\exit2.png");
        }

        private void btn_cerrar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_cerrar.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\exit1.png");
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private void btn_cerrar_Click(object sender, EventArgs e) => ProjectData.EndApp();

        private void btn_min_MouseHover(object sender, EventArgs e)
        {
            this.btn_min.Cursor = Cursors.Hand;
            this.btn_min.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\min2.png");
        }

        private void btn_min_MouseLeave(object sender, EventArgs e)
        {
            this.btn_min.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\min1.png");
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_settings_MouseHover(object sender, EventArgs e)
        {
            this.btn_settings.Cursor = Cursors.Hand;
            this.btn_settings.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\opciones1.bmp");
        }

        private void btn_settings_MouseLeave(object sender, EventArgs e)
        {
            this.btn_settings.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\opciones0.bmp");
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            MyProject.Forms.Form_Settings.Show();
        }

        private void chk_winmode_CheckedChanged(object sender, EventArgs e)
        {
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "WindowMode", (object)(this.chk_winmode.Checked ? checked((int)Conversions.ToLong("1")) : checked((int)Conversions.ToLong("0"))));
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Process.Start($"{Application.StartupPath}\\{Variables_Glob.Config_Nombre_Main}");
            this.Hide();
            this.Timer_Salir.Enabled = true;
            this.Timer_Salir.Interval = 8000;
        }

        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            this.btn_start.Cursor = Cursors.Hand;
            this.btn_start.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\start2.bmp");
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            this.btn_start.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\start1.bmp");
        }

        private void Timer_Salir_Tick(object sender, EventArgs e)
        {
            this.Timer_Salir.Enabled = false;
            this.Close();
        }

        private void lbl_news_Click(object sender, EventArgs e)
        {
            if (this.Nav_Noticias.Visible)
                this.Nav_Noticias.Visible = false;
            else
                this.Nav_Noticias.Visible = true;
        }

        private void Timer_Main_Tick(object sender, EventArgs e)
        {
            MainEmuF.MainMuEmu();
            this.Timer_Main.Enabled = false;
        }

        private void Label2_Click(object sender, EventArgs e) => Process.Start("http://gamesbit.net/");

        public delegate void ChangeTextsSafe(long length, int position, int percent, double speed);

        public delegate void DownloadCompleteSafe(bool cancelled);
    }
}
