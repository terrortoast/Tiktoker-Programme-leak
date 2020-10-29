using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace acc_tool
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		private void button1_Click(object sender, EventArgs e)
		{
			string text = new WebClient
			{
				Proxy = null
			}.DownloadString("https://pastebin.com/raw/rg75rWG0");
			bool flag = text.Contains(this.password.Text);
			if (flag)
			{
				MessageBox.Show("The license Is right!");
				Form2 form = new Form2();
				form.Show();
				base.Hide();
			}
			else
			{
				MessageBox.Show("Please put a valid License.");
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020D3 File Offset: 0x000002D3
		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("license.txt");
		}
	}
}
