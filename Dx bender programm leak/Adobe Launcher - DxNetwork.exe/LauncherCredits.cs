// Decompiled with JetBrains decompiler
// Type: DxLauncher.LauncherCredits
// Assembly: DxLauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C43FB74-0009-4DFC-9E5F-74A202E50751
// Assembly location: F:\Users\abtro\Desktop\Adobe Launcher - DxNetwork.exe.exe

using DxLauncher.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DxLauncher
{
public class LauncherCredits : Form
{
private IContainer components = (IContainer) null;
private Label label1;
private PictureBox pictureBox6;
private PictureBox pictureBox5;
private PictureBox pictureBox4;
private PictureBox pictureBox3;
private PictureBox pictureBox1;
private Label label2;
private Label label5;

public LauncherCredits() => this.InitializeComponent();

private void pictureBox3_Click(object sender, EventArgs e) => Process.Start("https://instagram.com/loli_modzz");

private void pictureBox5_Click(object sender, EventArgs e) => Process.Start("https://dxnetwork.at/discord");

private void pictureBox4_Click(object sender, EventArgs e) => Process.Start("https://tiktok.com/@scammingfortnitekids");

private void pictureBox6_Click(object sender, EventArgs e) => Process.Start("https://www.youtube.com/channel/UC-vL0eSahJshwvT9iIrC9FA?");

private void label4_Click(object sender, EventArgs e)
{
}

private void label3_Click(object sender, EventArgs e) => Process.Start("https://cracked-games.org");

private void pictureBox1_Click(object sender, EventArgs e) => Process.Start("https://dxnetwork.at/bender");

private void label6_Click(object sender, EventArgs e) => Process.Start("https://linktr.ee/itspaul");

protected override void Dispose(bool disposing)
{
if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (LauncherCredits));
      this.label1 = new Label();
      this.pictureBox6 = new PictureBox();
      this.pictureBox5 = new PictureBox();
      this.pictureBox4 = new PictureBox();
      this.pictureBox3 = new PictureBox();
      this.pictureBox1 = new PictureBox();
      this.label2 = new Label();
      this.label5 = new Label();
      ((ISupportInitialize) this.pictureBox6).BeginInit();
      ((ISupportInitialize) this.pictureBox5).BeginInit();
      ((ISupportInitialize) this.pictureBox4).BeginInit();
      ((ISupportInitialize) this.pictureBox3).BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(9, 196);
      this.label1.Name = "label1";
      this.label1.Size = new Size(101, 13);
      this.label1.TabIndex = 17;
      this.label1.Text = "Coder and Designer , alle credits an dich Brudi";
      this.pictureBox6.Image = (Image) componentResourceManager.GetObject("pictureBox6.Image");
      this.pictureBox6.Location = new Point(237, 140);
      this.pictureBox6.Name = "pictureBox6";
      this.pictureBox6.Size = new Size(70, 54);
      this.pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
      this.pictureBox6.TabIndex = 16;
      this.pictureBox6.TabStop = false;
      this.pictureBox6.Click += new EventHandler(this.pictureBox6_Click);
      this.pictureBox5.Image = (Image) componentResourceManager.GetObject("pictureBox5.Image");
      this.pictureBox5.Location = new Point(237, 80);
      this.pictureBox5.Name = "pictureBox5";
      this.pictureBox5.Size = new Size(70, 54);
      this.pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
      this.pictureBox5.TabIndex = 15;
      this.pictureBox5.TabStop = false;
      this.pictureBox5.Click += new EventHandler(this.pictureBox5_Click);
      this.pictureBox4.Image = (Image) componentResourceManager.GetObject("pictureBox4.Image");
      this.pictureBox4.Location = new Point(150, 140);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new Size(70, 54);
      this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
      this.pictureBox4.TabIndex = 14;
      this.pictureBox4.TabStop = false;
      this.pictureBox4.Click += new EventHandler(this.pictureBox4_Click);
      this.pictureBox3.Image = (Image) componentResourceManager.GetObject("pictureBox3.Image");
      this.pictureBox3.Location = new Point(150, 80);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new Size(70, 54);
      this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
      this.pictureBox3.TabIndex = 13;
      this.pictureBox3.TabStop = false;
      this.pictureBox3.Click += new EventHandler(this.pictureBox3_Click);
      this.pictureBox1.Image = (Image) Resources.drip_bild;
      this.pictureBox1.Location = new Point(12, 80);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(110, 113);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 12;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
      this.label2.AutoSize = true;
      this.label2.Font = new Font("CF Glitch City", 27.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.DarkRed;
      this.label2.Location = new Point(4, 2);
      this.label2.Name = "label2";
      this.label2.Size = new Size(213, 45);
      this.label2.TabIndex = 34;
      this.label2.Text = "CREDITS";
      this.label2.UseWaitCursor = true;
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Real Young", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(11, 60);
      this.label5.Name = "label5";
      this.label5.Size = new Size(111, 17);
      this.label5.TabIndex = 40;
      this.label5.Text = "S O R R Y B E N D E R";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveBorder;
      this.ClientSize = new Size(325, 218);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.pictureBox6);
      this.Controls.Add((Control) this.pictureBox5);
      this.Controls.Add((Control) this.pictureBox4);
      this.Controls.Add((Control) this.pictureBox3);
      this.Controls.Add((Control) this.pictureBox1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (LauncherCredits);
      this.Text = "Credits lol";
      ((ISupportInitialize) this.pictureBox6).EndInit();
      ((ISupportInitialize) this.pictureBox5).EndInit();
      ((ISupportInitialize) this.pictureBox4).EndInit();
      ((ISupportInitialize) this.pictureBox3).EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
