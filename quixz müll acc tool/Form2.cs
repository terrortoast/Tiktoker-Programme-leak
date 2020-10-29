using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace acc_tool
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("netflixx.txt");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("NordVpn.txt");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Process.Start("fortnite.txt");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This tool Was made By quixZz! Thanks for using my Tool!");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Follow Me on TikTok! My Name: .quixZz");
		}

		private void button6_Click(object sender, EventArgs e)
		{
			MessageBox.Show("more account options will be added in the near future!");
		}
	}
}
