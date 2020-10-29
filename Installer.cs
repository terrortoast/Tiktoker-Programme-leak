// Decompiled with JetBrains decompiler
// Type: Privater_Server.Installer
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
  public class Installer : Form
  {
    private IContainer components = (IContainer) null;
    private Button button1;
    private Button button3;
    private Label label1;
    private Label label2;
    private Label label3;
    private Button button2;

    public Installer() => this.InitializeComponent();

    private void button1_Click(object sender, EventArgs e) => Process.Start(new ProcessStartInfo()
    {
      FileName = "C:\\DxFDev-DxNetwork\\node-benderinstaller.msi",
      UseShellExecute = true
    });

    private void Installer_Load(object sender, EventArgs e)
    {
    }

    private void button3_Click(object sender, EventArgs e) => Process.Start(new ProcessStartInfo()
    {
      FileName = "C:\\DxFDev-DxNetwork\\npm-installer.bat",
      UseShellExecute = true
    });

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void button2_Click(object sender, EventArgs e) => Process.Start(new ProcessStartInfo()
    {
      FileName = "C:\\DxFDev-DxNetwork\\python-benderinstaller.exe",
      UseShellExecute = true
    });

    private void label3_Click(object sender, EventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Installer));
      this.button1 = new Button();
      this.button3 = new Button();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.button2 = new Button();
      this.SuspendLayout();
      this.button1.BackColor = SystemColors.ActiveCaption;
      this.button1.Font = new Font("Microsoft Sans Serif", 12.25f);
      this.button1.Location = new Point(12, 42);
      this.button1.Name = "button1";
      this.button1.Size = new Size(179, 47);
      this.button1.TabIndex = 0;
      this.button1.Text = "NODE Installer";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button3.BackColor = SystemColors.ActiveCaption;
      this.button3.Font = new Font("Microsoft Sans Serif", 12.25f);
      this.button3.ForeColor = SystemColors.InactiveCaptionText;
      this.button3.Location = new Point(12, 122);
      this.button3.Name = "button3";
      this.button3.Size = new Size(179, 47);
      this.button3.TabIndex = 2;
      this.button3.Text = "NPM Installer";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(57, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(83, 29);
      this.label1.TabIndex = 3;
      this.label1.Text = "FIRST";
      this.label1.Click += new EventHandler(this.label1_Click);
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(54, 90);
      this.label2.Name = "label2";
      this.label2.Size = new Size(86, 29);
      this.label2.TabIndex = 4;
      this.label2.Text = "THIRD";
      this.label2.Click += new EventHandler(this.label2_Click);
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(236, 9);
      this.label3.Name = "label3";
      this.label3.Size = new Size(116, 29);
      this.label3.TabIndex = 6;
      this.label3.Text = "SECOND";
      this.label3.Click += new EventHandler(this.label3_Click);
      this.button2.BackColor = SystemColors.ActiveCaption;
      this.button2.Font = new Font("Microsoft Sans Serif", 12.25f);
      this.button2.Location = new Point(206, 41);
      this.button2.Name = "button2";
      this.button2.Size = new Size(179, 47);
      this.button2.TabIndex = 5;
      this.button2.Text = "Python Installer";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ControlDark;
      this.ClientSize = new Size(396, 181);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Installer);
      this.Text = nameof (Installer);
      this.Load += new EventHandler(this.Installer_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
