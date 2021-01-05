namespace seesharp2
{
	// Token: 0x02000006 RID: 6
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000032 RID: 50 RVA: 0x0000474D File Offset: 0x0000294D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000476C File Offset: 0x0000296C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::seesharp2.Form1));
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new global::System.Windows.Forms.LinkLabel();
			this.linkLabel3 = new global::System.Windows.Forms.LinkLabel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.linkLabel5 = new global::System.Windows.Forms.LinkLabel();
			base.SuspendLayout();
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.LinkColor = global::System.Drawing.Color.White;
			this.linkLabel1.Location = new global::System.Drawing.Point(128, 328);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(47, 13);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "[ About ]";
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.LinkColor = global::System.Drawing.Color.White;
			this.linkLabel2.Location = new global::System.Drawing.Point(5, 328);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new global::System.Drawing.Size(51, 13);
			this.linkLabel2.TabIndex = 1;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "[ Builder ]";
			this.linkLabel2.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.LinkColor = global::System.Drawing.Color.White;
			this.linkLabel3.Location = new global::System.Drawing.Point(62, 328);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new global::System.Drawing.Size(60, 13);
			this.linkLabel3.TabIndex = 2;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "[ Decoder ]";
			this.linkLabel3.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(-3, 309);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(1477, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = componentResourceManager.GetString("label1.Text");
			this.linkLabel5.AutoSize = true;
			this.linkLabel5.LinkColor = global::System.Drawing.Color.White;
			this.linkLabel5.Location = new global::System.Drawing.Point(181, 328);
			this.linkLabel5.Name = "linkLabel5";
			this.linkLabel5.Size = new global::System.Drawing.Size(55, 13);
			this.linkLabel5.TabIndex = 5;
			this.linkLabel5.TabStop = true;
			this.linkLabel5.Text = "[ Discord ]";
			this.linkLabel5.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(800, 350);
			base.Controls.Add(this.linkLabel5);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.linkLabel3);
			base.Controls.Add(this.linkLabel2);
			base.Controls.Add(this.linkLabel1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			this.Text = "enit-ware";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000029 RID: 41
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.LinkLabel linkLabel2;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.LinkLabel linkLabel3;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.LinkLabel linkLabel5;
	}
}
