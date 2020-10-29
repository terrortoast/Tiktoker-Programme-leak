// Decompiled with JetBrains decompiler
// Type: Privater_Server.Credits
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
  public class Credits : Form
  {
    private IContainer components = (IContainer) null;
    private PictureBox pictureBox1;
    private PictureBox pictureBox3;
    private PictureBox pictureBox4;
    private PictureBox pictureBox5;
    private PictureBox pictureBox6;
    private Label label1;

    public Credits() => this.InitializeComponent();

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e) => Process.Start("https://tiktok.com/@scammingfortnitekids");

    private void pictureBox3_Click(object sender, EventArgs e) => Process.Start("https://instagram.com/loli_modzz");

    private void pictureBox4_Click(object sender, EventArgs e) => Process.Start("https://tiktok.com/@scammingfortnitekids");

    private void pictureBox1_Click(object sender, EventArgs e) => Process.Start("https://www.youtube.com/channel/UC-vL0eSahJshwvT9iIrC9FA?");

    private void pictureBox5_Click(object sender, EventArgs e) => Process.Start("https://www.youtube.com/channel/UC-vL0eSahJshwvT9iIrC9FA?");

    private void pictureBox6_Click(object sender, EventArgs e) => Process.Start("https://www.youtube.com/channel/UC-vL0eSahJshwvT9iIrC9FA?");

    private void pictureBox10_Click(object sender, EventArgs e) => Process.Start("https://instagram.com/loli_modzz");

    private void pictureBox8_Click(object sender, EventArgs e) => Process.Start("https://discord.gg/5fFvh");

    private void pictureBox9_Click(object sender, EventArgs e) => Process.Start("https://tiktok.com/@scammingfortnitekids");

    private void pictureBox7_Click(object sender, EventArgs e)
    {
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
this.components.Dispose();
base.Dispose(disposing);
}

private void InitializeComponent()
{
ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Credits));
this.pictureBox1 = new PictureBox();
this.pictureBox3 = new PictureBox();
this.pictureBox4 = new PictureBox();
this.pictureBox5 = new PictureBox();
this.pictureBox6 = new PictureBox();
this.label1 = new Label();
((ISupportInitialize) this.pictureBox1).BeginInit();
((ISupportInitialize) this.pictureBox3).BeginInit();
((ISupportInitialize) this.pictureBox4).BeginInit();
((ISupportInitialize) this.pictureBox5).BeginInit();
((ISupportInitialize) this.pictureBox6).BeginInit();
this.SuspendLayout();
this.pictureBox1.Image = (Image) Resources.a_9253cacb8be8d10e53b68cfac6440cb5;
this.pictureBox1.Location = new Point(12, 12);
this.pictureBox1.Name = "pictureBox1";
this.pictureBox1.Size = new Size(110, 113);
this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
this.pictureBox1.TabIndex = 0;
this.pictureBox1.TabStop = false;
this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
this.pictureBox3.Image = (Image) componentResourceManager.GetObject("pictureBox3.Image");
this.pictureBox3.Location = new Point(150, 12);
this.pictureBox3.Name = "pictureBox3";
this.pictureBox3.Size = new Size(70, 54);
this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
this.pictureBox3.TabIndex = 3;
this.pictureBox3.TabStop = false;
this.pictureBox3.Click += new EventHandler(this.pictureBox3_Click);
this.pictureBox4.Image = (Image) componentResourceManager.GetObject("pictureBox4.Image");
this.pictureBox4.Location = new Point(150, 72);
this.pictureBox4.Name = "pictureBox4";
this.pictureBox4.Size = new Size(70, 54);
this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
this.pictureBox4.TabIndex = 4;
this.pictureBox4.TabStop = false;
this.pictureBox4.Click += new EventHandler(this.pictureBox4_Click);
this.pictureBox5.Image = (Image) componentResourceManager.GetObject("pictureBox5.Image");
this.pictureBox5.Location = new Point(237, 12);
this.pictureBox5.Name = "pictureBox5";
this.pictureBox5.Size = new Size(70, 54);
this.pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
this.pictureBox5.TabIndex = 5;
this.pictureBox5.TabStop = false;
this.pictureBox5.Click += new EventHandler(this.pictureBox5_Click);
this.pictureBox6.Image = (Image) componentResourceManager.GetObject("pictureBox6.Image");
this.pictureBox6.Location = new Point(237, 72);
this.pictureBox6.Name = "pictureBox6";
this.pictureBox6.Size = new Size(70, 54);
this.pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
this.pictureBox6.TabIndex = 6;
this.pictureBox6.TabStop = false;
this.pictureBox6.Click += new EventHandler(this.pictureBox6_Click);
this.label1.AutoSize = true;
this.label1.Location = new Point(9, 128);
this.label1.Name = "label1";
this.label1.Size = new Size(101, 13);
this.label1.TabIndex = 11;
this.label1.Text = "Cracked by Scammingfortnitekids on Tiktok";
this.label1.Click += new EventHandler(this.label1_Click);
this.AutoScaleDimensions = new SizeF(6f, 13f);
this.AutoScaleMode = AutoScaleMode.Font;
this.BackColor = SystemColors.ControlDark;
this.ClientSize = new Size(320, 148);
this.Controls.Add((Control) this.label1);
this.Controls.Add((Control) this.pictureBox6);
this.Controls.Add((Control) this.pictureBox5);
this.Controls.Add((Control) this.pictureBox4);
this.Controls.Add((Control) this.pictureBox3);
this.Controls.Add((Control) this.pictureBox1);
this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
this.Name = nameof (Credits);
this.Text = nameof (Credits);
((ISupportInitialize) this.pictureBox1).EndInit();
((ISupportInitialize) this.pictureBox3).EndInit();
((ISupportInitialize) this.pictureBox4).EndInit();
((ISupportInitialize) this.pictureBox5).EndInit();
((ISupportInitialize) this.pictureBox6).EndInit();
this.ResumeLayout(false);
this.PerformLayout();
}
}
}
