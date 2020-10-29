// Decompiled with JetBrains decompiler
// Type: Privater_Server.DxNetwork
// Assembly: Privater Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 632FF662-1919-48CF-90E3-0E83342C95F7
// Assembly location: C:\DxFDev-DxNetwork\Privater Server.exe

using Privater_Server.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Privater_Server
{
  public class DxNetwork : Form
  {
    private IContainer components = (IContainer) null;
    private Button button1;
    private Button button2;
    private PictureBox pictureBox1;
    private Button button3;
    private Button button4;
    private ContextMenuStrip contextMenuStrip1;
    private Label label1;
    private PictureBox pictureBox2;
    private Label label2;
    private Button button5;
    private Button button6;
    private Button button7;

    public DxNetwork() => this.InitializeComponent();

    private void button1_Click(object sender, EventArgs e) => new Installer().Show();

    private void pictureBox1_Click(object sender, EventArgs e)
    {
    }

    private void button2_Click(object sender, EventArgs e) => Process.Start(new ProcessStartInfo()
    {
      FileName = "C:\\DxFDev-DxNetwork\\npm-updater.bat",
      UseShellExecute = true
    });

    private void button3_Click(object sender, EventArgs e) => Process.Start(new ProcessStartInfo()
    {
      FileName = "C:\\DxFDev-DxNetwork\\first-run.bat",
      UseShellExecute = true
    });

    private void button4_Click(object sender, EventArgs e) => Process.Start(new ProcessStartInfo()
    {
      FileName = "C:\\DxFDev-DxNetwork\\launch.bat",
      UseShellExecute = true
    });

    private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
    {
    }

    private void label1_Click(object sender, EventArgs e) => Process.Start("https://dxnetwork.at");

    private void label2_Click(object sender, EventArgs e) => Process.Start("https://dxnetwork.at");

    private void DxNetwork_Load(object sender, EventArgs e)
    {
    }

    private void button5_Click(object sender, EventArgs e) => new Credits().Show();

    private void button6_Click(object sender, EventArgs e) => new Help().Show();

    private void pictureBox2_Click(object sender, EventArgs e) => Process.Start("https://dxnetwork.at");

    private void button7_Click(object sender, EventArgs e) => Process.Start("http://127.0.0.1:5595/");

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
this.components.Dispose();
base.Dispose(disposing);
}

private void InitializeComponent()
{
this.components = (IContainer) new Container();
ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (DxNetwork));
this.button1 = new Button();
this.button2 = new Button();
this.button3 = new Button();
this.button4 = new Button();
this.contextMenuStrip1 = new ContextMenuStrip(this.components);
this.label1 = new Label();
this.label2 = new Label();
this.button5 = new Button();
this.button6 = new Button();
this.pictureBox2 = new PictureBox();
this.pictureBox1 = new PictureBox();
this.button7 = new Button();
((ISupportInitialize) this.pictureBox2).BeginInit();
((ISupportInitialize) this.pictureBox1).BeginInit();
this.SuspendLayout();
this.button1.BackColor = Color.DarkRed;
this.button1.FlatStyle = FlatStyle.Flat;
this.button1.Font = new Font("Microsoft Sans Serif", 18.25f);
this.button1.Location = new Point(12, 143);
this.button1.Name = "button1";
this.button1.Size = new Size(148, 52);
this.button1.TabIndex = 0;
this.button1.Text = "Installer";
this.button1.UseVisualStyleBackColor = false;
this.button1.Click += new EventHandler(this.button1_Click);
this.button2.FlatStyle = FlatStyle.Flat;
this.button2.Font = new Font("Microsoft Sans Serif", 12.25f);
this.button2.Location = new Point(166, 143);
this.button2.Name = "button2";
this.button2.Size = new Size(111, 52);
this.button2.TabIndex = 1;
this.button2.Text = "Update Checker";
this.button2.UseVisualStyleBackColor = true;
this.button2.Click += new EventHandler(this.button2_Click);
this.button3.FlatStyle = FlatStyle.Flat;
this.button3.Font = new Font("Microsoft Sans Serif", 12.25f);
this.button3.Location = new Point(166, 201);
this.button3.Name = "button3";
this.button3.Size = new Size(111, 48);
this.button3.TabIndex = 3;
this.button3.Text = "RUN";
this.button3.UseVisualStyleBackColor = true;
this.button3.Click += new EventHandler(this.button3_Click);
this.button4.BackColor = Color.DarkRed;
this.button4.FlatStyle = FlatStyle.Flat;
this.button4.Font = new Font("Verdana", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
this.button4.ForeColor = Color.White;
this.button4.ImageKey = "(Keine)";
this.button4.Location = new Point(309, 256);
this.button4.Name = "button4";
this.button4.Size = new Size(421, 49);
this.button4.TabIndex = 4;
this.button4.Text = "LAUNCH CRACKED DXFDEV";
this.button4.UseVisualStyleBackColor = false;
this.button4.Click += new EventHandler(this.button4_Click);
this.contextMenuStrip1.Name = "contextMenuStrip1";
this.contextMenuStrip1.Size = new Size(61, 4);
this.contextMenuStrip1.Opening += new CancelEventHandler(this.contextMenuStrip1_Opening);
this.label1.AutoSize = true;
this.label1.Font = new Font("Microsoft Sans Serif", 11.25f);
this.label1.Location = new Point(43, 82);
this.label1.Name = "label1";
this.label1.Size = new Size(153, 18);
this.label1.TabIndex = 1;
this.label1.Text = "©Scammingfortnitekids on Tiktok";
this.label1.Click += new EventHandler(this.label1_Click);
this.label2.AutoSize = true;
this.label2.Font = new Font("Microsoft YaHei UI", 24f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
this.label2.Location = new Point(126, 41);
this.label2.Name = "label2";
this.label2.Size = new Size(102, 42);
this.label2.TabIndex = 8;
this.label2.Text = "FDEV";
this.label2.Click += new EventHandler(this.label2_Click);
this.button5.BackColor = Color.DarkGray;
this.button5.FlatAppearance.BorderSize = 2;
this.button5.FlatStyle = FlatStyle.Flat;
this.button5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
this.button5.ForeColor = Color.Black;
this.button5.Location = new Point(12, 268);
this.button5.Name = "button5";
this.button5.Size = new Size(96, 37);
this.button5.TabIndex = 9;
this.button5.Text = "Credits";
this.button5.UseVisualStyleBackColor = false;
this.button5.Click += new EventHandler(this.button5_Click);
this.button6.BackColor = Color.DarkGray;
this.button6.FlatAppearance.BorderSize = 2;
this.button6.FlatStyle = FlatStyle.Flat;
this.button6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
this.button6.ForeColor = Color.Black;
this.button6.Location = new Point(114, 276);
this.button6.Name = "button6";
this.button6.Size = new Size(82, 29);
this.button6.TabIndex = 10;
this.button6.Text = "Help";
this.button6.UseVisualStyleBackColor = false;
this.button6.Click += new EventHandler(this.button6_Click);
this.pictureBox2.BackColor = Color.Transparent;
this.pictureBox2.Image = (Image) componentResourceManager.GetObject("pictureBox2.Image");
this.pictureBox2.Location = new Point(12, 12);
this.pictureBox2.Name = "pictureBox2";
this.pictureBox2.Size = new Size(148, 88);
this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
this.pictureBox2.TabIndex = 7;
this.pictureBox2.TabStop = false;
this.pictureBox2.Click += new EventHandler(this.pictureBox2_Click);
this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;
this.pictureBox1.Image = (Image) Resources.gif_testdd;
this.pictureBox1.Location = new Point(309, 12);
this.pictureBox1.Name = "pictureBox1";
this.pictureBox1.Size = new Size(416, 238);
this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
this.pictureBox1.TabIndex = 2;
this.pictureBox1.TabStop = false;
this.button7.FlatStyle = FlatStyle.Flat;
this.button7.Font = new Font("Microsoft Sans Serif", 12.25f);
this.button7.Location = new Point(12, 201);
this.button7.Name = "button7";
this.button7.Size = new Size(148, 48);
this.button7.TabIndex = 11;
this.button7.Text = "Interface";
this.button7.UseVisualStyleBackColor = true;
this.button7.Click += new EventHandler(this.button7_Click);
this.AutoScaleDimensions = new SizeF(6f, 13f);
this.AutoScaleMode = AutoScaleMode.Font;
this.BackColor = Color.DarkRed;
this.ClientSize = new Size(737, 313);
this.Controls.Add((Control) this.button7);
this.Controls.Add((Control) this.button6);
this.Controls.Add((Control) this.button5);
this.Controls.Add((Control) this.label2);
this.Controls.Add((Control) this.label1);
this.Controls.Add((Control) this.button4);
this.Controls.Add((Control) this.button3);
this.Controls.Add((Control) this.pictureBox1);
this.Controls.Add((Control) this.button2);
this.Controls.Add((Control) this.button1);
this.Controls.Add((Control) this.pictureBox2);
this.FormBorderStyle = FormBorderStyle.Fixed3D;
this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
this.Name = nameof (DxNetwork);
this.Text = "Cracked DxNetwork - Server";
this.Load += new EventHandler(this.DxNetwork_Load);
((ISupportInitialize) this.pictureBox2).EndInit();
((ISupportInitialize) this.pictureBox1).EndInit();
this.ResumeLayout(false);
this.PerformLayout();
}
}
}
