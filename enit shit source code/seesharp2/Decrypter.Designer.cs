namespace seesharp2
{
	// Token: 0x02000005 RID: 5
	public partial class Decrypter : global::System.Windows.Forms.Form
	{
		// Token: 0x06000028 RID: 40 RVA: 0x000037BA File Offset: 0x000019BA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000037DC File Offset: 0x000019DC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::seesharp2.Decrypter));
			this.metroButton2 = new global::MetroFramework.Controls.MetroButton();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.metroButton1 = new global::MetroFramework.Controls.MetroButton();
			this.metroTextBox4 = new global::MetroFramework.Controls.MetroTextBox();
			this.metroTextBox3 = new global::MetroFramework.Controls.MetroTextBox();
			this.metroTextBox2 = new global::MetroFramework.Controls.MetroTextBox();
			this.metroTextBox1 = new global::MetroFramework.Controls.MetroTextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.openFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			base.SuspendLayout();
			this.metroButton2.Location = new global::System.Drawing.Point(178, 72);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new global::System.Drawing.Size(90, 23);
			this.metroButton2.Style = 2;
			this.metroButton2.TabIndex = 24;
			this.metroButton2.Text = "Refresh";
			this.metroButton2.Theme = 2;
			this.metroButton2.UseSelectable = true;
			this.metroButton2.UseStyleColors = true;
			this.metroButton2.Click += new global::System.EventHandler(this.metroButton2_Click);
			this.listBox1.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.listBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox1.ForeColor = global::System.Drawing.Color.White;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(8, 101);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(260, 132);
			this.listBox1.TabIndex = 11;
			this.listBox1.SelectedIndexChanged += new global::System.EventHandler(this.listBox1_SelectedIndexChanged_1);
			this.metroButton1.Location = new global::System.Drawing.Point(178, 12);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new global::System.Drawing.Size(90, 23);
			this.metroButton1.Style = 2;
			this.metroButton1.TabIndex = 22;
			this.metroButton1.Text = "Select folder";
			this.metroButton1.Theme = 2;
			this.metroButton1.UseSelectable = true;
			this.metroButton1.UseStyleColors = true;
			this.metroButton1.Click += new global::System.EventHandler(this.metroButton1_Click);
			this.metroTextBox4.CustomButton.Image = null;
			this.metroTextBox4.CustomButton.Location = new global::System.Drawing.Point(243, 1);
			this.metroTextBox4.CustomButton.Name = "";
			this.metroTextBox4.CustomButton.Size = new global::System.Drawing.Size(21, 21);
			this.metroTextBox4.CustomButton.Style = 4;
			this.metroTextBox4.CustomButton.TabIndex = 1;
			this.metroTextBox4.CustomButton.Theme = 1;
			this.metroTextBox4.CustomButton.UseSelectable = true;
			this.metroTextBox4.CustomButton.Visible = false;
			this.metroTextBox4.Lines = new string[0];
			this.metroTextBox4.Location = new global::System.Drawing.Point(3, 41);
			this.metroTextBox4.MaxLength = 32767;
			this.metroTextBox4.Name = "metroTextBox4";
			this.metroTextBox4.PasswordChar = '\0';
			this.metroTextBox4.ReadOnly = true;
			this.metroTextBox4.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.metroTextBox4.SelectedText = "";
			this.metroTextBox4.SelectionLength = 0;
			this.metroTextBox4.SelectionStart = 0;
			this.metroTextBox4.ShortcutsEnabled = true;
			this.metroTextBox4.Size = new global::System.Drawing.Size(265, 23);
			this.metroTextBox4.Style = 2;
			this.metroTextBox4.TabIndex = 14;
			this.metroTextBox4.Theme = 2;
			this.metroTextBox4.UseSelectable = true;
			this.metroTextBox4.UseStyleColors = true;
			this.metroTextBox4.WaterMarkColor = global::System.Drawing.Color.White;
			this.metroTextBox4.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.metroTextBox4.Click += new global::System.EventHandler(this.metroTextBox4_Click);
			this.metroTextBox3.BackColor = global::System.Drawing.SystemColors.ControlDark;
			this.metroTextBox3.CustomButton.Image = null;
			this.metroTextBox3.CustomButton.Location = new global::System.Drawing.Point(83, 1);
			this.metroTextBox3.CustomButton.Name = "";
			this.metroTextBox3.CustomButton.Size = new global::System.Drawing.Size(107, 107);
			this.metroTextBox3.CustomButton.Style = 4;
			this.metroTextBox3.CustomButton.TabIndex = 1;
			this.metroTextBox3.CustomButton.Theme = 1;
			this.metroTextBox3.CustomButton.UseSelectable = true;
			this.metroTextBox3.CustomButton.Visible = false;
			this.metroTextBox3.Lines = new string[0];
			this.metroTextBox3.Location = new global::System.Drawing.Point(277, 124);
			this.metroTextBox3.MaxLength = 32767;
			this.metroTextBox3.Multiline = true;
			this.metroTextBox3.Name = "metroTextBox3";
			this.metroTextBox3.PasswordChar = '\0';
			this.metroTextBox3.ReadOnly = true;
			this.metroTextBox3.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.metroTextBox3.SelectedText = "";
			this.metroTextBox3.SelectionLength = 0;
			this.metroTextBox3.SelectionStart = 0;
			this.metroTextBox3.ShortcutsEnabled = true;
			this.metroTextBox3.Size = new global::System.Drawing.Size(191, 109);
			this.metroTextBox3.Style = 2;
			this.metroTextBox3.TabIndex = 20;
			this.metroTextBox3.Theme = 2;
			this.metroTextBox3.UseSelectable = true;
			this.metroTextBox3.UseStyleColors = true;
			this.metroTextBox3.WaterMarkColor = global::System.Drawing.Color.White;
			this.metroTextBox3.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.metroTextBox3.Click += new global::System.EventHandler(this.metroTextBox3_Click);
			this.metroTextBox2.CustomButton.Image = null;
			this.metroTextBox2.CustomButton.Location = new global::System.Drawing.Point(169, 1);
			this.metroTextBox2.CustomButton.Name = "";
			this.metroTextBox2.CustomButton.Size = new global::System.Drawing.Size(21, 21);
			this.metroTextBox2.CustomButton.Style = 4;
			this.metroTextBox2.CustomButton.TabIndex = 1;
			this.metroTextBox2.CustomButton.Theme = 1;
			this.metroTextBox2.CustomButton.UseSelectable = true;
			this.metroTextBox2.CustomButton.Visible = false;
			this.metroTextBox2.Lines = new string[0];
			this.metroTextBox2.Location = new global::System.Drawing.Point(277, 79);
			this.metroTextBox2.MaxLength = 32767;
			this.metroTextBox2.Name = "metroTextBox2";
			this.metroTextBox2.PasswordChar = '\0';
			this.metroTextBox2.ReadOnly = true;
			this.metroTextBox2.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.metroTextBox2.SelectedText = "";
			this.metroTextBox2.SelectionLength = 0;
			this.metroTextBox2.SelectionStart = 0;
			this.metroTextBox2.ShortcutsEnabled = true;
			this.metroTextBox2.Size = new global::System.Drawing.Size(191, 23);
			this.metroTextBox2.Style = 2;
			this.metroTextBox2.TabIndex = 18;
			this.metroTextBox2.Theme = 2;
			this.metroTextBox2.UseSelectable = true;
			this.metroTextBox2.UseStyleColors = true;
			this.metroTextBox2.WaterMarkColor = global::System.Drawing.Color.White;
			this.metroTextBox2.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.metroTextBox2.Click += new global::System.EventHandler(this.metroTextBox2_Click);
			this.metroTextBox1.CustomButton.Image = null;
			this.metroTextBox1.CustomButton.Location = new global::System.Drawing.Point(169, 1);
			this.metroTextBox1.CustomButton.Name = "";
			this.metroTextBox1.CustomButton.Size = new global::System.Drawing.Size(21, 21);
			this.metroTextBox1.CustomButton.Style = 4;
			this.metroTextBox1.CustomButton.TabIndex = 1;
			this.metroTextBox1.CustomButton.Theme = 1;
			this.metroTextBox1.CustomButton.UseSelectable = true;
			this.metroTextBox1.CustomButton.Visible = false;
			this.metroTextBox1.ForeColor = global::System.Drawing.SystemColors.ScrollBar;
			this.metroTextBox1.Lines = new string[0];
			this.metroTextBox1.Location = new global::System.Drawing.Point(277, 34);
			this.metroTextBox1.MaxLength = 32767;
			this.metroTextBox1.Name = "metroTextBox1";
			this.metroTextBox1.PasswordChar = '\0';
			this.metroTextBox1.ReadOnly = true;
			this.metroTextBox1.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.metroTextBox1.SelectedText = "";
			this.metroTextBox1.SelectionLength = 0;
			this.metroTextBox1.SelectionStart = 0;
			this.metroTextBox1.ShortcutsEnabled = true;
			this.metroTextBox1.Size = new global::System.Drawing.Size(191, 23);
			this.metroTextBox1.Style = 2;
			this.metroTextBox1.TabIndex = 15;
			this.metroTextBox1.Theme = 2;
			this.metroTextBox1.UseSelectable = true;
			this.metroTextBox1.UseStyleColors = true;
			this.metroTextBox1.WaterMarkColor = global::System.Drawing.Color.White;
			this.metroTextBox1.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.metroTextBox1.Click += new global::System.EventHandler(this.metroTextBox1_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(274, 12);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(55, 16);
			this.label1.TabIndex = 26;
			this.label1.Text = "GrowID:";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(274, 60);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(75, 16);
			this.label2.TabIndex = 27;
			this.label2.Text = "Last World:";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(274, 105);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(71, 16);
			this.label3.TabIndex = 28;
			this.label3.Text = "Password:";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(5, 82);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(85, 16);
			this.label4.TabIndex = 29;
			this.label4.Text = "Save.dat List";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(5, 12);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(167, 16);
			this.label5.TabIndex = 30;
			this.label5.Text = "Select your save.dat folder";
			this.openFileDialog1.FileName = "openFileDialog1";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(476, 245);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.metroButton2);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.metroButton1);
			base.Controls.Add(this.metroTextBox4);
			base.Controls.Add(this.metroTextBox3);
			base.Controls.Add(this.metroTextBox2);
			base.Controls.Add(this.metroTextBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Decrypter";
			this.Text = "Decoder";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000015 RID: 21
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000016 RID: 22
		private global::MetroFramework.Controls.MetroButton metroButton2;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000018 RID: 24
		private global::MetroFramework.Controls.MetroButton metroButton1;

		// Token: 0x04000019 RID: 25
		private global::MetroFramework.Controls.MetroTextBox metroTextBox4;

		// Token: 0x0400001A RID: 26
		private global::MetroFramework.Controls.MetroTextBox metroTextBox3;

		// Token: 0x0400001B RID: 27
		private global::MetroFramework.Controls.MetroTextBox metroTextBox2;

		// Token: 0x0400001C RID: 28
		private global::MetroFramework.Controls.MetroTextBox metroTextBox1;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}
