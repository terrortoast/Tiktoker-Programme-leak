// Decompiled with JetBrains decompiler
// Type: DxLauncher.LauncherDiscordBots
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
  public class LauncherDiscordBots : Form
  {
    private IContainer components = (IContainer) null;
    private Label label2;
    private Label label1;
    private Button button5;
    private Button button4;
    private Button button2;
    private Button button1;
    private Button button3;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button9;
    private Button button10;
    private Button button12;

    public LauncherDiscordBots() => this.InitializeComponent();

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void button5_Click(object sender, EventArgs e) => Process.Start("https://bit.ly/invite-carl");

    private void button4_Click(object sender, EventArgs e) => Process.Start("https://bit.ly/invite-dyno");

    private void button2_Click(object sender, EventArgs e) => Process.Start("https://bit.ly/invite-mee6");

    private void LauncherDiscordBots_Load(object sender, EventArgs e)
    {
    }

    private void button6_Click(object sender, EventArgs e) => Process.Start("https://bit.ly/invite-meme");

    private void button1_Click(object sender, EventArgs e) => Process.Start("https://bit.ly/invite-giveawaybot");

    private void button3_Click(object sender, EventArgs e) => Process.Start("http://bit.ly/invite-rythom");

    private void button9_Click(object sender, EventArgs e) => Process.Start("https://discord.com/oauth2/authorize?client_id=432533456807919639&permissions=8&scope=bot");

    private void button7_Click(object sender, EventArgs e) => Process.Start("https://discord.com/oauth2/authorize?client_id=557628352828014614&scope=bot&permissions=805432400");

    private void button8_Click(object sender, EventArgs e) => Process.Start("https://t1p.de/FireRaider2-Invite");

    private void button12_Click(object sender, EventArgs e) => Process.Start("https://discord.com/oauth2/authorize?client_id=472911936951156740&scope=bot&permissions=288374865");

    private void button10_Click(object sender, EventArgs e) => Process.Start("https://discord.com/oauth2/authorize?client_id=468459655929266176&scope=bot&permissions=8");

    private void button11_Click(object sender, EventArgs e) => Process.Start("");

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (LauncherDiscordBots));
      this.label2 = new Label();
      this.label1 = new Label();
      this.button5 = new Button();
      this.button4 = new Button();
      this.button2 = new Button();
      this.button1 = new Button();
      this.button3 = new Button();
      this.button6 = new Button();
      this.button7 = new Button();
      this.button8 = new Button();
      this.button9 = new Button();
      this.button10 = new Button();
      this.button12 = new Button();
      this.SuspendLayout();
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Revamped", 21.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(15, 81);
      this.label2.Name = "label2";
      this.label2.Size = new Size(106, 30);
      this.label2.TabIndex = 39;
      this.label2.Text = "bots";
      this.label2.Click += new EventHandler(this.label2_Click);
      this.label1.AutoSize = true;
      this.label1.Font = new Font("CF Glitch City", 27.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.DarkRed;
      this.label1.Location = new Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(327, 45);
      this.label1.TabIndex = 38;
      this.label1.Text = "DISCORD BOT";
      this.label1.UseWaitCursor = true;
      this.label1.Click += new EventHandler(this.label1_Click);
      this.button5.BackColor = SystemColors.ActiveCaptionText;
      this.button5.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button5.ForeColor = SystemColors.ButtonHighlight;
      this.button5.Location = new Point(163, 114);
      this.button5.Name = "button5";
      this.button5.Size = new Size(145, 55);
      this.button5.TabIndex = 37;
      this.button5.Text = "Carl Bot";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.button4.BackColor = SystemColors.ActiveCaptionText;
      this.button4.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button4.ForeColor = SystemColors.ButtonHighlight;
      this.button4.Location = new Point(314, 114);
      this.button4.Name = "button4";
      this.button4.Size = new Size(145, 55);
      this.button4.TabIndex = 36;
      this.button4.Text = "Dyno Bot";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button2.BackColor = SystemColors.ActiveCaptionText;
      this.button2.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button2.ForeColor = SystemColors.ButtonHighlight;
      this.button2.Location = new Point(12, 114);
      this.button2.Name = "button2";
      this.button2.Size = new Size(145, 55);
      this.button2.TabIndex = 35;
      this.button2.Text = "MEE6 Bot";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button1.BackColor = SystemColors.ActiveCaptionText;
      this.button1.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button1.ForeColor = SystemColors.ButtonHighlight;
      this.button1.Location = new Point(163, 175);
      this.button1.Name = "button1";
      this.button1.Size = new Size(145, 55);
      this.button1.TabIndex = 42;
      this.button1.Text = "Giveaway bot";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button3.BackColor = SystemColors.ActiveCaptionText;
      this.button3.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button3.ForeColor = SystemColors.ButtonHighlight;
      this.button3.Location = new Point(314, 175);
      this.button3.Name = "button3";
      this.button3.Size = new Size(145, 55);
      this.button3.TabIndex = 41;
      this.button3.Text = "Rythm Bot";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button6.BackColor = SystemColors.ActiveCaptionText;
      this.button6.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button6.ForeColor = SystemColors.ButtonHighlight;
      this.button6.Location = new Point(12, 175);
      this.button6.Name = "button6";
      this.button6.Size = new Size(145, 55);
      this.button6.TabIndex = 40;
      this.button6.Text = "Dank Meme Bot";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.button7.BackColor = SystemColors.ActiveCaptionText;
      this.button7.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button7.ForeColor = SystemColors.ButtonHighlight;
      this.button7.Location = new Point(163, 236);
      this.button7.Name = "button7";
      this.button7.Size = new Size(145, 55);
      this.button7.TabIndex = 45;
      this.button7.Text = "Ticket Tool bot";
      this.button7.UseVisualStyleBackColor = false;
      this.button7.Click += new EventHandler(this.button7_Click);
      this.button8.BackColor = SystemColors.ActiveCaptionText;
      this.button8.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button8.ForeColor = SystemColors.ButtonHighlight;
      this.button8.Location = new Point(314, 236);
      this.button8.Name = "button8";
      this.button8.Size = new Size(145, 55);
      this.button8.TabIndex = 44;
      this.button8.Text = "Fire Raider Bot";
      this.button8.UseVisualStyleBackColor = false;
      this.button8.Click += new EventHandler(this.button8_Click);
      this.button9.BackColor = SystemColors.ActiveCaptionText;
      this.button9.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button9.ForeColor = SystemColors.ButtonHighlight;
      this.button9.Location = new Point(12, 236);
      this.button9.Name = "button9";
      this.button9.Size = new Size(145, 55);
      this.button9.TabIndex = 43;
      this.button9.Text = "Member bot";
      this.button9.UseVisualStyleBackColor = false;
      this.button9.Click += new EventHandler(this.button9_Click);
      this.button10.BackColor = SystemColors.ActiveCaptionText;
      this.button10.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button10.ForeColor = SystemColors.ButtonHighlight;
      this.button10.Location = new Point(163, 297);
      this.button10.Name = "button10";
      this.button10.Size = new Size(145, 55);
      this.button10.TabIndex = 48;
      this.button10.Text = "Yunite Bot";
      this.button10.UseVisualStyleBackColor = false;
      this.button10.Click += new EventHandler(this.button10_Click);
      this.button12.BackColor = SystemColors.ActiveCaptionText;
      this.button12.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button12.ForeColor = SystemColors.ButtonHighlight;
      this.button12.Location = new Point(12, 297);
      this.button12.Name = "button12";
      this.button12.Size = new Size(145, 55);
      this.button12.TabIndex = 46;
      this.button12.Text = "Voice Master Bot";
      this.button12.UseVisualStyleBackColor = false;
      this.button12.Click += new EventHandler(this.button12_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveBorder;
      this.ClientSize = new Size(473, 368);
      this.Controls.Add((Control) this.button10);
      this.Controls.Add((Control) this.button12);
      this.Controls.Add((Control) this.button7);
      this.Controls.Add((Control) this.button8);
      this.Controls.Add((Control) this.button9);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button6);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button2);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (LauncherDiscordBots);
      this.Text = "Discord Bots";
      this.Load += new EventHandler(this.LauncherDiscordBots_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
