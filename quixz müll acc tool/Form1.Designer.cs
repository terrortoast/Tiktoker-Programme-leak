namespace acc_tool
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000020E4 File Offset: 0x000002E4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000211C File Offset: 0x0000031C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::acc_tool.Form1));
			this.label1 = new global::System.Windows.Forms.Label();
			this.password = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.Desktop;
			this.label1.Location = new global::System.Drawing.Point(25, 58);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(58, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "License:";
			this.password.BackColor = global::System.Drawing.SystemColors.MenuText;
			this.password.ForeColor = global::System.Drawing.SystemColors.Desktop;
			this.password.Location = new global::System.Drawing.Point(89, 58);
			this.password.Name = "password";
			this.password.Size = new global::System.Drawing.Size(100, 20);
			this.password.TabIndex = 1;
			this.button1.BackColor = global::System.Drawing.SystemColors.ControlText;
			this.button1.ForeColor = global::System.Drawing.SystemColors.Desktop;
			this.button1.Location = new global::System.Drawing.Point(99, 93);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 35);
			this.button1.TabIndex = 2;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.BackColor = global::System.Drawing.SystemColors.ControlText;
			this.button2.ForeColor = global::System.Drawing.SystemColors.Desktop;
			this.button2.Location = new global::System.Drawing.Point(243, 169);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "License";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			base.ClientSize = new global::System.Drawing.Size(330, 204);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.password);
			base.Controls.Add(this.label1);
			this.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			base.Name = "Form1";
			this.Text = "Login";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.TextBox password;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Button button2;
	}
}
