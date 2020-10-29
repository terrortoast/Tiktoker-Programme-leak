// Decompiled with JetBrains decompiler
// Type: DxLauncher.LauncherDownload
// Assembly: DxLauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C43FB74-0009-4DFC-9E5F-74A202E50751
// Assembly location: F:\Users\abtro\Desktop\Adobe Launcher - DxNetwork.exe.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DxLauncher
{
  public class LauncherDownload : Form
  {
    private IContainer components = (IContainer) null;
    private Label label2;
    private Label label1;
    private Button button5;
    private Button button4;
    private Button button2;
    private Button button1;
    private Button button3;

    public LauncherDownload() => this.InitializeComponent();

    private void button2_Click(object sender, EventArgs e) => Process.Start("https://snaptik.app");

    private void button5_Click(object sender, EventArgs e) => Process.Start("https://instadownloader.co/de/");

    private void button4_Click(object sender, EventArgs e) => Process.Start("https://www.y2mate.com/");

    private void button1_Click(object sender, EventArgs e) => Process.Start("https://de.clipr.xyz");

    private void button3_Click(object sender, EventArgs e) => Process.Start("https://izoomyou.com");

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label2 = new Label();
      this.label1 = new Label();
      this.button5 = new Button();
      this.button4 = new Button();
      this.button2 = new Button();
      this.button1 = new Button();
      this.button3 = new Button();
      this.SuspendLayout();
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Revamped", 21.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(15, 81);
      this.label2.Name = "label2";
      this.label2.Size = new Size(254, 30);
      this.label2.TabIndex = 44;
      this.label2.Text = "Downloader";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("CF Glitch City", 27.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.DarkRed;
      this.label1.Location = new Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(455, 45);
      this.label1.TabIndex = 43;
      this.label1.Text = "DOWNLOAD TOOLS";
      this.label1.UseWaitCursor = true;
      this.button5.BackColor = SystemColors.ActiveCaptionText;
      this.button5.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button5.ForeColor = SystemColors.ButtonHighlight;
      this.button5.Location = new Point(163, 114);
      this.button5.Name = "button5";
      this.button5.Size = new Size(145, 55);
      this.button5.TabIndex = 42;
      this.button5.Text = "Instagram Downloader";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.button4.BackColor = SystemColors.ActiveCaptionText;
      this.button4.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button4.ForeColor = SystemColors.ButtonHighlight;
      this.button4.Location = new Point(314, 114);
      this.button4.Name = "button4";
      this.button4.Size = new Size(145, 55);
      this.button4.TabIndex = 41;
      this.button4.Text = "Youtube Downlaoder";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button2.BackColor = SystemColors.ActiveCaptionText;
      this.button2.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button2.ForeColor = SystemColors.ButtonHighlight;
      this.button2.Location = new Point(12, 114);
      this.button2.Name = "button2";
      this.button2.Size = new Size(145, 55);
      this.button2.TabIndex = 40;
      this.button2.Text = "TikTok Downloader";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button1.BackColor = SystemColors.ActiveCaptionText;
      this.button1.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button1.ForeColor = SystemColors.ButtonHighlight;
      this.button1.Location = new Point(12, 175);
      this.button1.Name = "button1";
      this.button1.Size = new Size(145, 55);
      this.button1.TabIndex = 45;
      this.button1.Text = "Twitch Clips Downloader";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button3.BackColor = SystemColors.ActiveCaptionText;
      this.button3.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button3.ForeColor = SystemColors.ButtonHighlight;
      this.button3.Location = new Point(163, 175);
      this.button3.Name = "button3";
      this.button3.Size = new Size(145, 55);
      this.button3.TabIndex = 46;
      this.button3.Text = "Insta PP Downloader";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveBorder;
      this.ClientSize = new Size(475, 238);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button2);
      this.Name = nameof (LauncherDownload);
      this.Text = "Downlaod Tools";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
