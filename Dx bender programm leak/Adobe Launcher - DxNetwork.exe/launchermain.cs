﻿
// Type: DxLauncher.launchermain
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
public class launchermain : Form
{
private IContainer components = (IContainer) null;
private PictureBox pictureBox1;
private Label label2;
private Button button1;
private Label label1;
private Button button9;
private Button button8;
private Button button7;
private Button button6;
private Button button5;
private Button button4;
private Button button3;
private Button button2;
private Button button10;

public launchermain() => this.InitializeComponent();

private void label2_Click(object sender, EventArgs e)
{
}

private void label2_Click_1(object sender, EventArgs e)
{
}

private void button1_Click(object sender, EventArgs e) => new LauncherCredits().Show();

private void button2_Click(object sender, EventArgs e) => new LauncherCrackedStuff().Show();

private void button5_Click(object sender, EventArgs e) => new LauncherTools().Show();

private void label1_Click(object sender, EventArgs e) => Process.Start("https://www.youtube.com/channel/UC-vL0eSahJshwvT9iIrC9FA?");

private void button3_Click(object sender, EventArgs e) => new LauncherFortnite().Show();

private void button9_Click(object sender, EventArgs e) => new LauncherMustHave().Show();

private void button4_Click(object sender, EventArgs e) => new LauncherDiscordBots().Show();

private void button6_Click(object sender, EventArgs e) => Process.Start("https://dxnetwork.at/discord-bot");

private void button7_Click(object sender, EventArgs e) => new LauncherDownload().Show();

private void button10_Click(object sender, EventArgs e) => Process.Start("https://mega.nz/file/GfhQnY5L#r9xbykOYQkPT-RdEx4Ghpi2I6f3drD2xcPBEd8h8Ucw");

private void button5_Click_1(object sender, EventArgs e) => Process.Start("https://mega.nz/file/CNhnCLiD#Artp0Otbn5bZ65nf1FLsw-y-rmJFWxbUXE7ZnhIa36A");

private void button4_Click_1(object sender, EventArgs e) => Process.Start("https://mega.nz/file/tEBgEAJJ#D0MP4D4_tBttH8kOkDczeJn0CDqMQoQkbDSLJbdfXN0");

private void button3_Click_1(object sender, EventArgs e) => Process.Start("https://mega.nz/file/ZJZmxapI#rNiYXMUwlz0plVR0mSHZmUAcJLyIFoiSZfk364l6NO0");

private void button2_Click_1(object sender, EventArgs e) => Process.Start("https://mega.nz/file/OAUjVARQ#xicUCvfsARqeyQNXa8BGYJ910jiLHhwrtQYa3Q7FWcA");

private void button8_Click(object sender, EventArgs e) => Process.Start("https://mega.nz/file/GlonVCTA#eoLM166UdHf6V1gSqjCu6Fjy4PlRIKbQqSiT5phq0Cs");

private void button6_Click_1(object sender, EventArgs e) => Process.Start("https://mega.nz/file/D44hDL6S#gvEOKo9kOtJQC0IW8-Apy6gntRpro1Vficxx6U3Saqs");

private void button7_Click_1(object sender, EventArgs e) => Process.Start("https://mega.nz/file/voBARYaC#QBaz4nOMQhstn4GFUo5b3TknEKUjZahu7Fl2U0DqUZw");

private void button9_Click_1(object sender, EventArgs e) => Process.Start("https://mega.nz/file/jLw0XQzR#IouOFhWLieOTT-Z4H2N5llX1fyQ29_ImYaXbb7_IFFk");

protected override void Dispose(bool disposing)
{
if (disposing && this.components != null)
this.components.Dispose();
base.Dispose(disposing);
}

private void InitializeComponent()
{
ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (launchermain));
this.pictureBox1 = new PictureBox();
this.label2 = new Label();
this.button1 = new Button();
this.label1 = new Label();
this.button9 = new Button();
this.button8 = new Button();
this.button7 = new Button();
this.button6 = new Button();
this.button5 = new Button();
this.button4 = new Button();
this.button3 = new Button();
this.button2 = new Button();
this.button10 = new Button();
((ISupportInitialize) this.pictureBox1).BeginInit();
this.SuspendLayout();
this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
this.pictureBox1.Location = new Point(1, -16);
this.pictureBox1.Name = "pictureBox1";
this.pictureBox1.Size = new Size(113, 120);
this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
this.pictureBox1.TabIndex = 0;
this.pictureBox1.TabStop = false;
this.label2.AutoSize = true;
this.label2.Font = new Font("CF Glitch City", 27.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
this.label2.Location = new Point(120, 27);
this.label2.Name = "label2";
this.label2.Size = new Size(434, 45);
this.label2.TabIndex = 2;
this.label2.Text = "Dx Launcher Crack";
this.label2.Click += new EventHandler(this.label2_Click_1);
this.button1.BackColor = SystemColors.ActiveCaptionText;
this.button1.Font = new Font("Plateia", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
this.button1.ForeColor = Color.Red;
this.button1.Location = new Point(1, 268);
this.button1.Name = "button1";
this.button1.Size = new Size(87, 32);
this.button1.TabIndex = 3;
this.button1.Text = "Credits";
this.button1.UseVisualStyleBackColor = false;
this.button1.Click += new EventHandler(this.button1_Click);
this.label1.AutoSize = true;
this.label1.Font = new Font("Microsoft Sans Serif", 11.25f);
this.label1.Location = new Point(441, 282);
this.label1.Name = "label1";
this.label1.Size = new Size(153, 18);
this.label1.TabIndex = 16;
this.label1.Text = "©scammingfortnitekids on tiktok";
this.label1.Click += new EventHandler(this.label1_Click);
this.button9.BackColor = SystemColors.ActiveCaptionText;
this.button9.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
this.button9.ForeColor = SystemColors.ButtonHighlight;
this.button9.Location = new Point(1, 207);
this.button9.Name = "button9";
this.button9.Size = new Size(145, 55);
this.button9.TabIndex = 25;
this.button9.Text = "Illustrator 2020";
this.button9.UseVisualStyleBackColor = false;
this.button9.Click += new EventHandler(this.button9_Click_1);
this.button8.BackColor = SystemColors.ActiveCaptionText;
this.button8.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
this.button8.ForeColor = SystemColors.ButtonHighlight;
this.button8.Location = new Point(152, 146);
this.button8.Name = "button8";
this.button8.Size = new Size(145, 55);
this.button8.TabIndex = 24;
this.button8.Text = "Encoder 2020";
this.button8.UseVisualStyleBackColor = false;
this.button8.Click += new EventHandler(this.button8_Click);
this.button7.BackColor = SystemColors.ActiveCaptionText;
this.button7.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
this.button7.ForeColor = SystemColors.ButtonHighlight;
this.button7.Location = new Point(455, 146);
this.button7.Name = "button7";
this.button7.Size = new Size(145, 55);
this.button7.TabIndex = 23;
this.button7.Text = "Dreamwaver 2020";
this.button7.UseVisualStyleBackColor = false;
this.button7.Click += new EventHandler(this.button7_Click_1);
this.button6.BackColor = SystemColors.ActiveCaptionText;
this.button6.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
this.button6.ForeColor = SystemColors.ButtonHighlight;
this.button6.Location = new Point(303, 146);
this.button6.Name = "button6";
this.button6.Size = new Size(145, 55);
this.button6.TabIndex = 22;
this.button6.Text = "InDesign 2020";
this.button6.UseVisualStyleBackColor = false;
this.button6.Click += new EventHandler(this.button6_Click_1);
this.button5.BackColor = SystemColors.ActiveCaptionText;
this.button5.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
this.button5.ForeColor = SystemColors.ButtonHighlight;
this.button5.Location = new Point(152, 85);
this.button5.Name = "button5";
this.button5.Size = new Size(145, 55);
this.button5.TabIndex = 21;
this.button5.Text = "Premiere Pro 2020";
this.button5.UseVisualStyleBackColor = false;
this.button5.Click += new EventHandler(this.button5_Click_1);
this.button4.BackColor = SystemColors.ActiveCaptionText;
this.button4.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
this.button4.ForeColor = SystemColors.ButtonHighlight;
this.button4.Location = new Point(303, 85);
this.button4.Name = "button4";
this.button4.Size = new Size(145, 55);
this.button4.TabIndex = 20;
this.button4.Text = "After Effects 2020";
this.button4.UseVisualStyleBackColor = false;
this.button4.Click += new EventHandler(this.button4_Click_1);
this.button3.BackColor = SystemColors.ActiveCaptionText;
this.button3.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
this.button3.ForeColor = SystemColors.ButtonHighlight;
this.button3.Location = new Point(454, 85);
this.button3.Name = "button3";
this.button3.Size = new Size(145, 55);
this.button3.TabIndex = 19;
this.button3.Text = "Audition 2020";
this.button3.UseVisualStyleBackColor = false;
this.button3.Click += new EventHandler(this.button3_Click_1);
this.button2.BackColor = SystemColors.ActiveCaptionText;
this.button2.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
this.button2.ForeColor = SystemColors.ButtonHighlight;
this.button2.Location = new Point(1, 146);
this.button2.Name = "button2";
this.button2.Size = new Size(145, 55);
this.button2.TabIndex = 18;
this.button2.Text = "Lightroom Classic 2020";
this.button2.UseVisualStyleBackColor = false;
this.button2.Click += new EventHandler(this.button2_Click_1);
this.button10.BackColor = SystemColors.ActiveCaptionText;
this.button10.Font = new Font("#44 Font", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
this.button10.ForeColor = SystemColors.ButtonHighlight;
this.button10.Location = new Point(1, 85);
this.button10.Name = "button10";
this.button10.Size = new Size(145, 55);
this.button10.TabIndex = 17;
this.button10.Text = "Photoshop 2020";
this.button10.UseVisualStyleBackColor = false;
this.button10.Click += new EventHandler(this.button10_Click);
this.AutoScaleDimensions = new SizeF(6f, 13f);
this.AutoScaleMode = AutoScaleMode.Font;
this.BackColor = SystemColors.ActiveCaption;
this.ClientSize = new Size(604, 305);
this.Controls.Add((Control) this.button9);
this.Controls.Add((Control) this.button8);
this.Controls.Add((Control) this.button7);
this.Controls.Add((Control) this.button6);
this.Controls.Add((Control) this.button5);
this.Controls.Add((Control) this.button4);
this.Controls.Add((Control) this.button3);
this.Controls.Add((Control) this.button2);
this.Controls.Add((Control) this.button10);
this.Controls.Add((Control) this.label1);
this.Controls.Add((Control) this.button1);
this.Controls.Add((Control) this.label2);
this.Controls.Add((Control) this.pictureBox1);
this.FormBorderStyle = FormBorderStyle.FixedSingle;
this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
this.Name = nameof (launchermain);
this.StartPosition = FormStartPosition.CenterScreen;
this.Text = "Dx Launcher Crack";
((ISupportInitialize) this.pictureBox1).EndInit();
this.ResumeLayout(false);
this.PerformLayout();
}
}
}
