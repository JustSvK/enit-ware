using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace seesharp2
{
	// Token: 0x02000006 RID: 6
	public partial class Form1 : Form
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00004650 File Offset: 0x00002850
		public Form1()
		{
			this.InitializeComponent();
			this._timer = new Timer();
			this._timer.Interval = 50;
			this._timer.Tick += this._timer_Tick;
			this._timer.Enabled = true;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000046A4 File Offset: 0x000028A4
		private void _timer_Tick(object sender, EventArgs e)
		{
			if (base.Bounds.Contains(Cursor.Position))
			{
				if (base.Opacity < 1.0)
				{
					base.Opacity += 0.1;
					return;
				}
			}
			else if (base.Opacity > 0.95)
			{
				base.Opacity -= 0.1;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004715 File Offset: 0x00002915
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			new Builder().ShowDialog();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004722 File Offset: 0x00002922
		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			new Decrypter().ShowDialog();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000472F File Offset: 0x0000292F
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			new About().ShowDialog();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000473C File Offset: 0x0000293C
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000473E File Offset: 0x0000293E
		private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004740 File Offset: 0x00002940
		private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://discord.gg/Wv7h8Ef");
		}

		// Token: 0x04000023 RID: 35
		private const double OPACITY_MIN = 0.95;

		// Token: 0x04000024 RID: 36
		private const double OPACITY_MAX = 1.0;

		// Token: 0x04000025 RID: 37
		private const double OPACITY_STEP = 0.1;

		// Token: 0x04000026 RID: 38
		private const bool SMOOTH_SHOWING = true;

		// Token: 0x04000027 RID: 39
		private const int TIMER_INTERVAL = 50;

		// Token: 0x04000028 RID: 40
		private Timer _timer;
	}
}
