// Decompiled with JetBrains decompiler
// Type: File_Downloader.Form_Settings
// Assembly: ZeroLauncher, Version=2.0.9.0, Culture=neutral, PublicKeyToken=null
// MVID: 3A2BC2C6-6C50-4584-B700-5D7713B95215
// Assembly location: C:\Mu Konoha 2.0\Launcher.exe

using File_Downloader.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


namespace File_Downloader;

[DesignerGenerated]
public class Form_Settings : Form
{
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("btn_guardar")]
    private PictureBox _btn_guardar;
    [AccessedThroughProperty("btn_cancelar")]
    private PictureBox _btn_cancelar;
    [AccessedThroughProperty("txt_id")]
    private TextBox _txt_id;
    [AccessedThroughProperty("opp_pantalla")]
    private ComboBox _opp_pantalla;
    [AccessedThroughProperty("opp_languaje")]
    private ComboBox _opp_languaje;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("chk_musica")]
    private CheckBox _chk_musica;
    [AccessedThroughProperty("chk_efectos")]
    private CheckBox _chk_efectos;
    private FileStream fs;
    private const int WM_NCHITTEST = 132;
    private const int HTCLIENT = 1;
    private const int HTCAPTION = 2;

    [DebuggerNonUserCode]
    static Form_Settings()
    {
    }

    [DebuggerNonUserCode]
    public Form_Settings()
    {
        this.Load += new EventHandler(this.Form_Settings_Load);
        Form_Settings.__ENCAddToList((object)this);
        this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
        lock (Form_Settings.__ENCList)
        {
            if (Form_Settings.__ENCList.Count == Form_Settings.__ENCList.Capacity)
            {
                int index1 = 0;
                int num = checked(Form_Settings.__ENCList.Count - 1);
                int index2 = 0;
                while (index2 <= num)
                {
                    if (Form_Settings.__ENCList[index2].IsAlive)
                    {
                        if (index2 != index1)
                            Form_Settings.__ENCList[index1] = Form_Settings.__ENCList[index2];
                        checked { ++index1; }
                    }
                    checked { ++index2; }
                }
                Form_Settings.__ENCList.RemoveRange(index1, checked(Form_Settings.__ENCList.Count - index1));
                Form_Settings.__ENCList.Capacity = Form_Settings.__ENCList.Count;
            }
            Form_Settings.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
        this.btn_guardar = new PictureBox();
        this.btn_cancelar = new PictureBox();
        this.txt_id = new TextBox();
        this.opp_pantalla = new ComboBox();
        this.opp_languaje = new ComboBox();
        this.Label1 = new Label();
        this.Label2 = new Label();
        this.Label3 = new Label();
        this.chk_musica = new CheckBox();
        this.chk_efectos = new CheckBox();
        ((ISupportInitialize)this.btn_guardar).BeginInit();
        ((ISupportInitialize)this.btn_cancelar).BeginInit();
        this.SuspendLayout();
        PictureBox btnGuardar1 = this.btn_guardar;
        Point point1 = new Point(0, 321);
        Point point2 = point1;
        btnGuardar1.Location = point2;
        this.btn_guardar.Name = "btn_guardar";
        PictureBox btnGuardar2 = this.btn_guardar;
        Size size1 = new Size(150, 35);
        Size size2 = size1;
        btnGuardar2.Size = size2;
        this.btn_guardar.TabIndex = 0;
        this.btn_guardar.TabStop = false;
        PictureBox btnCancelar1 = this.btn_cancelar;
        point1 = new Point(150, 321);
        Point point3 = point1;
        btnCancelar1.Location = point3;
        this.btn_cancelar.Name = "btn_cancelar";
        PictureBox btnCancelar2 = this.btn_cancelar;
        size1 = new Size(150, 35);
        Size size3 = size1;
        btnCancelar2.Size = size3;
        this.btn_cancelar.TabIndex = 1;
        this.btn_cancelar.TabStop = false;
        TextBox txtId1 = this.txt_id;
        point1 = new Point(30, 83);
        Point point4 = point1;
        txtId1.Location = point4;
        this.txt_id.Name = "txt_id";
        TextBox txtId2 = this.txt_id;
        size1 = new Size(161, 20);
        Size size4 = size1;
        txtId2.Size = size4;
        this.txt_id.TabIndex = 2;
        this.opp_pantalla.DropDownStyle = ComboBoxStyle.DropDownList;
        this.opp_pantalla.Items.AddRange(new object[6]
        {
      (object) "640 x 480",
      (object) "800 x 600",
      (object) "1024 x 768",
      (object) "1280 x 1024",
      (object) "1366 x 768",
      (object) "1600 x 1280"
        });
        ComboBox oppPantalla1 = this.opp_pantalla;
        point1 = new Point(30, 144 /*0x90*/);
        Point point5 = point1;
        oppPantalla1.Location = point5;
        this.opp_pantalla.Name = "opp_pantalla";
        ComboBox oppPantalla2 = this.opp_pantalla;
        size1 = new Size(205, 21);
        Size size5 = size1;
        oppPantalla2.Size = size5;
        this.opp_pantalla.TabIndex = 3;
        this.opp_languaje.DropDownStyle = ComboBoxStyle.DropDownList;
        this.opp_languaje.FormattingEnabled = true;
        this.opp_languaje.Items.AddRange(new object[3]
        {
      (object) "English",
      (object) "Español",
      (object) "Portugues"
        });
        ComboBox oppLanguaje1 = this.opp_languaje;
        point1 = new Point(30, 211);
        Point point6 = point1;
        oppLanguaje1.Location = point6;
        this.opp_languaje.Name = "opp_languaje";
        ComboBox oppLanguaje2 = this.opp_languaje;
        size1 = new Size(205, 21);
        Size size6 = size1;
        oppLanguaje2.Size = size6;
        this.opp_languaje.TabIndex = 4;
        this.Label1.AutoSize = true;
        this.Label1.BackColor = Color.Transparent;
        this.Label1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
        this.Label1.ForeColor = Color.FromArgb((int)byte.MaxValue, 128 /*0x80*/, 0);
        Label label1_1 = this.Label1;
        point1 = new Point(30, 62);
        Point point7 = point1;
        label1_1.Location = point7;
        this.Label1.Name = "Label1";
        Label label1_2 = this.Label1;
        size1 = new Size(82, 18);
        Size size7 = size1;
        label1_2.Size = size7;
        this.Label1.TabIndex = 5;
        this.Label1.Text = "Default ID";
        this.Label2.AutoSize = true;
        this.Label2.BackColor = Color.Transparent;
        this.Label2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
        this.Label2.ForeColor = Color.FromArgb((int)byte.MaxValue, 128 /*0x80*/, 0);
        Label label2_1 = this.Label2;
        point1 = new Point(30, 123);
        Point point8 = point1;
        label2_1.Location = point8;
        this.Label2.Name = "Label2";
        Label label2_2 = this.Label2;
        size1 = new Size(147, 18);
        Size size8 = size1;
        label2_2.Size = size8;
        this.Label2.TabIndex = 6;
        this.Label2.Text = "Screen Resolution";
        this.Label3.AutoSize = true;
        this.Label3.BackColor = Color.Transparent;
        this.Label3.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
        this.Label3.ForeColor = Color.FromArgb((int)byte.MaxValue, 128 /*0x80*/, 0);
        Label label3_1 = this.Label3;
        point1 = new Point(30, 190);
        Point point9 = point1;
        label3_1.Location = point9;
        this.Label3.Name = "Label3";
        Label label3_2 = this.Label3;
        size1 = new Size(75, 18);
        Size size9 = size1;
        label3_2.Size = size9;
        this.Label3.TabIndex = 7;
        this.Label3.Text = "Lenguaje";
        this.chk_musica.AutoSize = true;
        this.chk_musica.BackColor = Color.Transparent;
        this.chk_musica.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
        this.chk_musica.ForeColor = Color.FromArgb((int)byte.MaxValue, 128 /*0x80*/, 0);
        CheckBox chkMusica1 = this.chk_musica;
        point1 = new Point(33, 262);
        Point point10 = point1;
        chkMusica1.Location = point10;
        this.chk_musica.Name = "chk_musica";
        CheckBox chkMusica2 = this.chk_musica;
        size1 = new Size(76, 20);
        Size size10 = size1;
        chkMusica2.Size = size10;
        this.chk_musica.TabIndex = 8;
        this.chk_musica.Text = "Musica";
        this.chk_musica.UseVisualStyleBackColor = false;
        this.chk_efectos.AutoSize = true;
        this.chk_efectos.BackColor = Color.Transparent;
        this.chk_efectos.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
        this.chk_efectos.ForeColor = Color.FromArgb((int)byte.MaxValue, 128 /*0x80*/, 0);
        CheckBox chkEfectos1 = this.chk_efectos;
        point1 = new Point(115, 262);
        Point point11 = point1;
        chkEfectos1.Location = point11;
        this.chk_efectos.Name = "chk_efectos";
        CheckBox chkEfectos2 = this.chk_efectos;
        size1 = new Size(154, 20);
        Size size11 = size1;
        chkEfectos2.Size = size11;
        this.chk_efectos.TabIndex = 9;
        this.chk_efectos.Text = "Efectos de Sonido";
        this.chk_efectos.UseVisualStyleBackColor = false;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        size1 = new Size(300, 356);
        this.ClientSize = size1;
        this.Controls.Add((Control)this.chk_efectos);
        this.Controls.Add((Control)this.chk_musica);
        this.Controls.Add((Control)this.Label3);
        this.Controls.Add((Control)this.Label2);
        this.Controls.Add((Control)this.Label1);
        this.Controls.Add((Control)this.opp_languaje);
        this.Controls.Add((Control)this.opp_pantalla);
        this.Controls.Add((Control)this.txt_id);
        this.Controls.Add((Control)this.btn_cancelar);
        this.Controls.Add((Control)this.btn_guardar);
        this.FormBorderStyle = FormBorderStyle.None;
        this.Name = nameof(Form_Settings);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Opciones";
        ((ISupportInitialize)this.btn_guardar).EndInit();
        ((ISupportInitialize)this.btn_cancelar).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    internal virtual PictureBox btn_guardar
    {
        [DebuggerNonUserCode]
        get => this._btn_guardar;
        [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler eventHandler1 = new EventHandler(this.btn_guardar_Click);
            EventHandler eventHandler2 = new EventHandler(this.btn_guardar_MouseLeave);
            EventHandler eventHandler3 = new EventHandler(this.btn_guardar_MouseHover);
            if (this._btn_guardar != null)
            {
                this._btn_guardar.Click -= eventHandler1;
                this._btn_guardar.MouseLeave -= eventHandler2;
                this._btn_guardar.MouseHover -= eventHandler3;
            }
            this._btn_guardar = value;
            if (this._btn_guardar == null)
                return;
            this._btn_guardar.Click += eventHandler1;
            this._btn_guardar.MouseLeave += eventHandler2;
            this._btn_guardar.MouseHover += eventHandler3;
        }
    }

    internal virtual PictureBox btn_cancelar
    {
        [DebuggerNonUserCode]
        get => this._btn_cancelar;
        [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            EventHandler eventHandler1 = new EventHandler(this.btn_cancelar_Click);
            EventHandler eventHandler2 = new EventHandler(this.btn_cancelar_MouseLeave);
            EventHandler eventHandler3 = new EventHandler(this.btn_cancelar_MouseHover);
            if (this._btn_cancelar != null)
            {
                this._btn_cancelar.Click -= eventHandler1;
                this._btn_cancelar.MouseLeave -= eventHandler2;
                this._btn_cancelar.MouseHover -= eventHandler3;
            }
            this._btn_cancelar = value;
            if (this._btn_cancelar == null)
                return;
            this._btn_cancelar.Click += eventHandler1;
            this._btn_cancelar.MouseLeave += eventHandler2;
            this._btn_cancelar.MouseHover += eventHandler3;
        }
    }

    internal virtual TextBox txt_id
    {
        [DebuggerNonUserCode]
        get => this._txt_id;
        [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
        set => this._txt_id = value;
    }

    internal virtual ComboBox opp_pantalla
    {
        [DebuggerNonUserCode]
        get => this._opp_pantalla;
        [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            this._opp_pantalla = value;
        }
    }

    internal virtual ComboBox opp_languaje
    {
        [DebuggerNonUserCode]
        get => this._opp_languaje;
        [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            this._opp_languaje = value;
        }
    }

    internal virtual Label Label1
    {
        [DebuggerNonUserCode]
        get => this._Label1;
        [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
        set => this._Label1 = value;
    }

    internal virtual Label Label2
    {
        [DebuggerNonUserCode]
        get => this._Label2;
        [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
        set => this._Label2 = value;
    }

    internal virtual Label Label3
    {
        [DebuggerNonUserCode]
        get => this._Label3;
        [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
        set => this._Label3 = value;
    }

    internal virtual CheckBox chk_musica
    {
        [DebuggerNonUserCode]
        get => this._chk_musica;
        [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            this._chk_musica = value;
        }
    }

    internal virtual CheckBox chk_efectos
    {
        [DebuggerNonUserCode]
        get => this._chk_efectos;
        [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
        set
        {
            this._chk_efectos = value;
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

    private void Cargar_Registros()
    {
        this.chk_efectos.Checked = Conversions.ToBoolean(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "SoundOnOff", (object)null));
        this.chk_musica.Checked = Conversions.ToBoolean(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "MusicOnOff", (object)null));
        switch (Conversions.ToLong(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", (object)null)))
        {
            case 0:
                this.opp_pantalla.Text = "640 x 480";
                break;
            case 1:
                this.opp_pantalla.Text = "800 x 600";
                break;
            case 2:
                this.opp_pantalla.Text = "1024 x 768";
                break;
            case 3:
                this.opp_pantalla.Text = "1280 x 1024";
                break;
            case 4:
                this.opp_pantalla.Text = "1366 x 768";
                break;
            case 5:
                this.opp_pantalla.Text = "1600 x 1280";
                break;
        }
        this.txt_id.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "ID", (object)null));
        string Left = Conversions.ToString(MyProject.Computer.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "LangSelection", (object)null));
        if (Operators.CompareString(Left, "Eng", false) == 0)
            this.opp_languaje.Text = "English";
        else if (Operators.CompareString(Left, "Spn", false) == 0)
        {
            this.opp_languaje.Text = "Español";
        }
        else
        {
            if (Operators.CompareString(Left, "Por", false) != 0)
                return;
            this.opp_languaje.Text = "Portugues";
        }
    }

    private void Guardar_Registros()
    {
        int selectedIndex1 = this.opp_pantalla.SelectedIndex;
        long selectedIndex2 = (long)this.opp_languaje.SelectedIndex;
        int num1 = -(this.chk_musica.Checked ? 1 : 0);
        int num2 = -(this.chk_efectos.Checked ? 1 : 0);
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "ID", (object)this.txt_id.Text);
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", (object)selectedIndex1);
        long num3 = selectedIndex2;
        if (num3 == Conversions.ToLong("0"))
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "LangSelection", (object)"Eng");
        else if (num3 == Conversions.ToLong("1"))
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "LangSelection", (object)"Spn");
        else if (num3 == Conversions.ToLong("2"))
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "LangSelection", (object)"Por");
        int num4 = selectedIndex1;
        if (num4 == Conversions.ToInteger("0"))
        {
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", (object)0);
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "ResolutionA", (object)0);
        }
        else if (num4 == Conversions.ToInteger("1"))
        {
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", (object)1);
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "ResolutionA", (object)0);
        }
        else if (num4 == Conversions.ToInteger("2"))
        {
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", (object)2);
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "ResolutionA", (object)0);
        }
        else if (num4 == Conversions.ToInteger("3"))
        {
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", (object)3);
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "ResolutionA", (object)0);
        }
        else if (num4 == Conversions.ToInteger("4"))
        {
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", (object)4);
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "ResolutionA", (object)1);
        }
        else if (num4 == Conversions.ToInteger("5"))
        {
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "Resolution", (object)5);
            MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "ResolutionA", (object)1);
        }
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "MusicOnOff", (object)(num1 != 0 ? Conversions.ToInteger("1") : Conversions.ToInteger("0")));
        MyProject.Computer.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Webzen\\Mu\\Config", "SoundOnOff", (object)(num2 != 0 ? Conversions.ToInteger("1") : Conversions.ToInteger("0")));
    }

    private void Form_Settings_Load(object sender, EventArgs e)
    {
        this.BackgroundImage = (Image)new Bitmap(Variables_Glob.Def_Carpeta_Temp + "\\opcionbg.bmp");
        this.btn_guardar.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\guardar0.bmp");
        this.btn_cancelar.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\cancelar0.bmp");
        this.Cargar_Registros();
        this.Label1.Text = Variables_Languaje.lng26;
        this.Label2.Text = Variables_Languaje.lng27;
        this.Label3.Text = Variables_Languaje.lng28;
        this.chk_musica.Text = Variables_Languaje.lng29;
        this.chk_efectos.Text = Variables_Languaje.lng30;
    }

    private void btn_guardar_MouseHover(object sender, EventArgs e)
    {
        this.btn_guardar.Cursor = Cursors.Hand;
        this.btn_guardar.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\guardar1.bmp");
    }

    private void btn_guardar_MouseLeave(object sender, EventArgs e)
    {
        this.btn_guardar.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\guardar0.bmp");
    }

    private void btn_guardar_Click(object sender, EventArgs e)
    {
        this.Guardar_Registros();
        this.Close();
    }

    private void btn_cancelar_MouseHover(object sender, EventArgs e)
    {
        this.btn_cancelar.Cursor = Cursors.Hand;
        this.btn_cancelar.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\cancelar1.bmp");
    }

    private void btn_cancelar_MouseLeave(object sender, EventArgs e)
    {
        this.btn_cancelar.Image = (Image)Funciones.LoadImgAOH($"{Application.StartupPath}\\{Variables_Glob.Def_Carpeta_Launcher}\\GRAFICOS\\cancelar0.bmp");
    }

    private void btn_cancelar_Click(object sender, EventArgs e) => this.Close();
}
