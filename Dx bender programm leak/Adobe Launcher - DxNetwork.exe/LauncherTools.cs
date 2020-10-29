// Decompiled with JetBrains decompiler
// Type: DxLauncher.LauncherTools
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
  public class LauncherTools : Form
  {
    private IContainer components = (IContainer) null;
    private Label label2;
    private Label label1;
    private Button button5;
    private Button button4;
    private Button button2;
    private Label label3;
    private Button button1;
    private Button button3;
    private Button button6;
    private Button button7;
    private Button button9;
    private Label label4;
    private Button button11;
    private Button button12;
    private Button button13;

    public LauncherTools() => this.InitializeComponent();

    private void button2_Click(object sender, EventArgs e) => Process.Start("https://bit.ly/32oMbBn");

    private void button5_Click(object sender, EventArgs e) => Process.Start("https://bit.ly/3aNz8NV");

    private void button4_Click(object sender, EventArgs e) => Process.Start("https://mega.nz/file/zDwS0YYL#oR3sLyvYYreSluz7T1tgTqL4LSa7d8pb4OZfv-E08tg");

    private void button6_Click(object sender, EventArgs e) => Process.Start("https://www.nvidia.de/Download/index.aspx");

    private void button1_Click(object sender, EventArgs e) => Process.Start("https://www.amd.com/de/support");

    private void button3_Click(object sender, EventArgs e) => Process.Start("https://download.amd.com/Desktop/AMD-Ryzen-Master.exe");

    private void button9_Click(object sender, EventArgs e) => Process.Start("http://download.msi.com/uti_exe/vga/MSIAfterburnerSetup.zip");

    private void button7_Click(object sender, EventArgs e) => Process.Start("http://bit.ly/audio-driver-dx");

    private void button11_Click(object sender, EventArgs e) => Process.Start("https://www.asus.com/campaign/aura/global/download.php");

    private void button12_Click(object sender, EventArgs e) => Process.Start("https://download.msi.com/uti_exe/common/Dragon-Center.zip");

    private void button8_Click(object sender, EventArgs e) => Process.Start("");

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (LauncherTools));
      this.label2 = new Label();
      this.label1 = new Label();
      this.button5 = new Button();
      this.button4 = new Button();
      this.button2 = new Button();
      this.label3 = new Label();
      this.button1 = new Button();
      this.button3 = new Button();
      this.button6 = new Button();
      this.button7 = new Button();
      this.button9 = new Button();
      this.label4 = new Label();
      this.button11 = new Button();
      this.button12 = new Button();
      this.button13 = new Button();
      this.SuspendLayout();
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Revamped", 21.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(5, 81);
      this.label2.Name = "label2";
      this.label2.Size = new Size(302, 30);
      this.label2.TabIndex = 34;
      this.label2.Text = "Windows Tools";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("CF Glitch City", 27.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.DarkRed;
      this.label1.Location = new Point(2, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(437, 45);
      this.label1.TabIndex = 33;
      this.label1.Text = "COMPUTER TOOLS";
      this.label1.UseWaitCursor = true;
      this.button5.BackColor = SystemColors.ActiveCaptionText;
      this.button5.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button5.ForeColor = SystemColors.ButtonHighlight;
      this.button5.Location = new Point(153, 114);
      this.button5.Name = "button5";
      this.button5.Size = new Size(145, 55);
      this.button5.TabIndex = 29;
      this.button5.Text = "Temp Cleaner";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.button4.BackColor = SystemColors.ActiveCaptionText;
      this.button4.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button4.ForeColor = SystemColors.ButtonHighlight;
      this.button4.Location = new Point(304, 114);
      this.button4.Name = "button4";
      this.button4.Size = new Size(145, 55);
      this.button4.TabIndex = 28;
      this.button4.Text = "CCleaner";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button2.BackColor = SystemColors.ActiveCaptionText;
      this.button2.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button2.ForeColor = SystemColors.ButtonHighlight;
      this.button2.Location = new Point(2, 114);
      this.button2.Name = "button2";
      this.button2.Size = new Size(145, 55);
      this.button2.TabIndex = 25;
      this.button2.Text = "Windows Activater";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Revamped", 21.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(5, 194);
      this.label3.Name = "label3";
      this.label3.Size = new Size(164, 30);
      this.label3.TabIndex = 38;
      this.label3.Text = "Drivers";
      this.button1.BackColor = SystemColors.ActiveCaptionText;
      this.button1.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button1.ForeColor = SystemColors.ButtonHighlight;
      this.button1.Location = new Point(153, 227);
      this.button1.Name = "button1";
      this.button1.Size = new Size(145, 55);
      this.button1.TabIndex = 37;
      this.button1.Text = "AMD Radeon Driver";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button3.BackColor = SystemColors.ActiveCaptionText;
      this.button3.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button3.ForeColor = SystemColors.ButtonHighlight;
      this.button3.Location = new Point(304, 227);
      this.button3.Name = "button3";
      this.button3.Size = new Size(145, 55);
      this.button3.TabIndex = 36;
      this.button3.Text = "AMD OC Tool";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button6.BackColor = SystemColors.ActiveCaptionText;
      this.button6.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button6.ForeColor = SystemColors.ButtonHighlight;
      this.button6.Location = new Point(2, 227);
      this.button6.Name = "button6";
      this.button6.Size = new Size(145, 55);
      this.button6.TabIndex = 35;
      this.button6.Text = "NVIDIA Driver";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.button7.BackColor = SystemColors.ActiveCaptionText;
      this.button7.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button7.ForeColor = SystemColors.ButtonHighlight;
      this.button7.Location = new Point(153, 288);
      this.button7.Name = "button7";
      this.button7.Size = new Size(145, 55);
      this.button7.TabIndex = 41;
      this.button7.Text = "Audio Driver";
      this.button7.UseVisualStyleBackColor = false;
      this.button7.Click += new EventHandler(this.button7_Click);
      this.button9.BackColor = SystemColors.ActiveCaptionText;
      this.button9.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button9.ForeColor = SystemColors.ButtonHighlight;
      this.button9.Location = new Point(2, 288);
      this.button9.Name = "button9";
      this.button9.Size = new Size(145, 55);
      this.button9.TabIndex = 39;
      this.button9.Text = "MSI Afterburner";
      this.button9.UseVisualStyleBackColor = false;
      this.button9.Click += new EventHandler(this.button9_Click);
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Revamped", 21.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(5, 366);
      this.label4.Name = "label4";
      this.label4.Size = new Size(391, 30);
      this.label4.TabIndex = 45;
      this.label4.Text = "RGB Controll Appl.";
      this.button11.BackColor = SystemColors.ActiveCaptionText;
      this.button11.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button11.ForeColor = SystemColors.ButtonHighlight;
      this.button11.Location = new Point(153, 399);
      this.button11.Name = "button11";
      this.button11.Size = new Size(145, 55);
      this.button11.TabIndex = 44;
      this.button11.Text = "Aura Sync Utility";
      this.button11.UseVisualStyleBackColor = false;
      this.button11.Click += new EventHandler(this.button11_Click);
      this.button12.BackColor = SystemColors.ActiveCaptionText;
      this.button12.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button12.ForeColor = SystemColors.ButtonHighlight;
      this.button12.Location = new Point(304, 399);
      this.button12.Name = "button12";
      this.button12.Size = new Size(145, 55);
      this.button12.TabIndex = 43;
      this.button12.Text = "Msi Dragon Center";
      this.button12.UseVisualStyleBackColor = false;
      this.button12.Click += new EventHandler(this.button12_Click);
      this.button13.BackColor = SystemColors.ActiveCaptionText;
      this.button13.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button13.ForeColor = SystemColors.ButtonHighlight;
      this.button13.Location = new Point(2, 399);
      this.button13.Name = "button13";
      this.button13.Size = new Size(145, 55);
      this.button13.TabIndex = 42;
      this.button13.Text = "Corsair iCUE";
      this.button13.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveBorder;
      this.ClientSize = new Size(472, 464);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.button11);
      this.Controls.Add((Control) this.button12);
      this.Controls.Add((Control) this.button13);
      this.Controls.Add((Control) this.button7);
      this.Controls.Add((Control) this.button9);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button6);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button2);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (LauncherTools);
      this.Text = "Computer Tools";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
