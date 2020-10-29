// Decompiled with JetBrains decompiler
// Type: DxLauncher.LauncherFortnite
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
  public class LauncherFortnite : Form
  {
    private IContainer components = (IContainer) null;
    private Label label2;
    private Label label1;
    private Button button5;
    private Button button2;
    private Label label3;
    private Button button6;
    private Button button1;
    private Label label4;
    private Button button3;

    public LauncherFortnite() => this.InitializeComponent();

    private void button2_Click(object sender, EventArgs e) => Process.Start("https://proswapper.xyz/downloads");

    private void button5_Click(object sender, EventArgs e) => Process.Start("https://dxnetwork.at/lele-swapper");

    private void button6_Click(object sender, EventArgs e) => Process.Start("https://direct-link.net/48489/proswapperlobby");

    private void button1_Click(object sender, EventArgs e) => Process.Start("https://bit.ly/3jyCBDp");

    private void button3_Click(object sender, EventArgs e) => Process.Start("https://docs.google.com/spreadsheets/d/1gVDgnzNyMCafIWa-dBO3mgNUHmHzgA9O5sWbfQy2Yfg");

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (LauncherFortnite));
      this.label2 = new Label();
      this.label1 = new Label();
      this.button5 = new Button();
      this.button2 = new Button();
      this.label3 = new Label();
      this.button6 = new Button();
      this.button1 = new Button();
      this.label4 = new Label();
      this.button3 = new Button();
      this.SuspendLayout();
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Revamped", 21.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(12, 79);
      this.label2.Name = "label2";
      this.label2.Size = new Size(405, 30);
      this.label2.TabIndex = 44;
      this.label2.Text = "Skin Changer Ingame";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("CF Glitch City", 27.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.DarkRed;
      this.label1.Location = new Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(410, 45);
      this.label1.TabIndex = 43;
      this.label1.Text = "FORTNITE TOOLS";
      this.label1.UseWaitCursor = true;
      this.button5.BackColor = SystemColors.ActiveCaptionText;
      this.button5.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button5.ForeColor = SystemColors.ButtonHighlight;
      this.button5.Location = new Point(168, 112);
      this.button5.Name = "button5";
      this.button5.Size = new Size(145, 55);
      this.button5.TabIndex = 42;
      this.button5.Text = "Lele Swapper";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.button2.BackColor = SystemColors.ActiveCaptionText;
      this.button2.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button2.ForeColor = SystemColors.ButtonHighlight;
      this.button2.Location = new Point(17, 112);
      this.button2.Name = "button2";
      this.button2.Size = new Size(145, 55);
      this.button2.TabIndex = 40;
      this.button2.Text = "Proswapper";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Revamped", 21.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(12, 183);
      this.label3.Name = "label3";
      this.label3.RightToLeft = RightToLeft.Yes;
      this.label3.Size = new Size(390, 30);
      this.label3.TabIndex = 45;
      this.label3.Text = "Skin Changer Lobby";
      this.button6.BackColor = SystemColors.ActiveCaptionText;
      this.button6.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button6.ForeColor = SystemColors.ButtonHighlight;
      this.button6.Location = new Point(17, 216);
      this.button6.Name = "button6";
      this.button6.Size = new Size(145, 55);
      this.button6.TabIndex = 46;
      this.button6.Text = "Proswapper Lobby";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.button1.BackColor = SystemColors.ActiveCaptionText;
      this.button1.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button1.ForeColor = SystemColors.ButtonHighlight;
      this.button1.Location = new Point(17, 316);
      this.button1.Name = "button1";
      this.button1.Size = new Size(145, 55);
      this.button1.TabIndex = 48;
      this.button1.Text = "Hxd";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Revamped", 21.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(12, 283);
      this.label4.Name = "label4";
      this.label4.RightToLeft = RightToLeft.Yes;
      this.label4.Size = new Size(390, 30);
      this.label4.TabIndex = 47;
      this.label4.Text = "Skin Changer Lobby";
      this.button3.BackColor = SystemColors.ActiveCaptionText;
      this.button3.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button3.ForeColor = SystemColors.ButtonHighlight;
      this.button3.Location = new Point(168, 316);
      this.button3.Name = "button3";
      this.button3.Size = new Size(145, 55);
      this.button3.TabIndex = 49;
      this.button3.Text = "HxD Codes";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveBorder;
      this.ClientSize = new Size(435, 380);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.button6);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.button2);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (LauncherFortnite);
      this.Text = nameof (LauncherFortnite);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
