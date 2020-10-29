// Decompiled with JetBrains decompiler
// Type: Privater_Server.Help
// Assembly: Privater Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 632FF662-1919-48CF-90E3-0E83342C95F7
// Assembly location: C:\DxFDev-DxNetwork\Privater Server.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Privater_Server
{
  public class Help : Form
  {
    private IContainer components = (IContainer) null;
    private Label label2;
    private Label label1;
    private Button button3;
    private Button button1;

    public Help() => this.InitializeComponent();

    private void button1_Click(object sender, EventArgs e)
    {
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void button3_Click(object sender, EventArgs e) => Process.Start("https://dxnetwork.at/youtube-privaterserver");

    private void button1_Click_1(object sender, EventArgs e) => Process.Start("https://discord-invite.de/dxnetwork");

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Help));
      this.label2 = new Label();
      this.label1 = new Label();
      this.button3 = new Button();
      this.button1 = new Button();
      this.SuspendLayout();
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 15f);
      this.label2.Location = new Point(186, 9);
      this.label2.Name = "label2";
      this.label2.Size = new Size(144, 25);
      this.label2.TabIndex = 8;
      this.label2.Text = "youtube tutorial";
      this.label2.Click += new EventHandler(this.label2_Click);
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 15f);
      this.label1.Location = new Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(150, 25);
      this.label1.TabIndex = 7;
      this.label1.Text = "Help on Discord";
      this.label1.Click += new EventHandler(this.label1_Click);
      this.button3.BackColor = SystemColors.ActiveCaption;
      this.button3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button3.ForeColor = SystemColors.InactiveCaptionText;
      this.button3.Location = new Point(185, 37);
      this.button3.Name = "button3";
      this.button3.Size = new Size(145, 44);
      this.button3.TabIndex = 6;
      this.button3.Text = "YouTube";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button1.BackColor = SystemColors.ActiveCaption;
      this.button1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button1.Location = new Point(17, 37);
      this.button1.Name = "button1";
      this.button1.Size = new Size(145, 44);
      this.button1.TabIndex = 5;
      this.button1.Text = "Discord";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click_1);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ButtonShadow;
      this.ClientSize = new Size(338, 92);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Help);
      this.Text = nameof (Help);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
