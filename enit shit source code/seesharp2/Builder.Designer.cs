namespace seesharp2
{
	// Token: 0x02000004 RID: 4
	public partial class Builder : global::System.Windows.Forms.Form
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002674 File Offset: 0x00000874
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002694 File Offset: 0x00000894
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::seesharp2.Builder));
			this.metroCheckBox1 = new global::System.Windows.Forms.CheckBox();
			this.metroCheckBox2 = new global::System.Windows.Forms.CheckBox();
			this.metroCheckBox5 = new global::System.Windows.Forms.CheckBox();
			this.metroCheckBox6 = new global::System.Windows.Forms.CheckBox();
			this.metroCheckBox4 = new global::System.Windows.Forms.CheckBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.metroTextBox6 = new global::MetroFramework.Controls.MetroTextBox();
			this.metroTextBox7 = new global::MetroFramework.Controls.MetroTextBox();
			this.metroButton3 = new global::MetroFramework.Controls.MetroButton();
			this.metroTextBox5 = new global::MetroFramework.Controls.MetroTextBox();
			this.metroButton4 = new global::MetroFramework.Controls.MetroButton();
			this.openFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.label3 = new global::System.Windows.Forms.Label();
			this.folderBrowserDialog1 = new global::System.Windows.Forms.FolderBrowserDialog();
			base.SuspendLayout();
			this.metroCheckBox1.AutoSize = true;
			this.metroCheckBox1.ForeColor = global::System.Drawing.Color.White;
			this.metroCheckBox1.Location = new global::System.Drawing.Point(273, 12);
			this.metroCheckBox1.Name = "metroCheckBox1";
			this.metroCheckBox1.Size = new global::System.Drawing.Size(100, 17);
			this.metroCheckBox1.TabIndex = 0;
			this.metroCheckBox1.Text = "Trace Save.dat";
			this.metroCheckBox1.UseVisualStyleBackColor = true;
			this.metroCheckBox1.CheckedChanged += new global::System.EventHandler(this.metroCheckBox1_CheckedChanged);
			this.metroCheckBox2.AutoSize = true;
			this.metroCheckBox2.ForeColor = global::System.Drawing.Color.White;
			this.metroCheckBox2.Location = new global::System.Drawing.Point(273, 35);
			this.metroCheckBox2.Name = "metroCheckBox2";
			this.metroCheckBox2.Size = new global::System.Drawing.Size(84, 17);
			this.metroCheckBox2.TabIndex = 1;
			this.metroCheckBox2.Text = "Hide Stealer";
			this.metroCheckBox2.UseVisualStyleBackColor = true;
			this.metroCheckBox2.CheckedChanged += new global::System.EventHandler(this.metroCheckBox2_CheckedChanged);
			this.metroCheckBox5.AutoSize = true;
			this.metroCheckBox5.ForeColor = global::System.Drawing.Color.White;
			this.metroCheckBox5.Location = new global::System.Drawing.Point(273, 58);
			this.metroCheckBox5.Name = "metroCheckBox5";
			this.metroCheckBox5.Size = new global::System.Drawing.Size(108, 17);
			this.metroCheckBox5.TabIndex = 2;
			this.metroCheckBox5.Text = "Delete Growtopia";
			this.metroCheckBox5.UseVisualStyleBackColor = true;
			this.metroCheckBox5.CheckedChanged += new global::System.EventHandler(this.metroCheckBox5_CheckedChanged);
			this.metroCheckBox6.AutoSize = true;
			this.metroCheckBox6.ForeColor = global::System.Drawing.Color.White;
			this.metroCheckBox6.Location = new global::System.Drawing.Point(273, 81);
			this.metroCheckBox6.Name = "metroCheckBox6";
			this.metroCheckBox6.Size = new global::System.Drawing.Size(100, 17);
			this.metroCheckBox6.TabIndex = 4;
			this.metroCheckBox6.Text = "Run On Startup";
			this.metroCheckBox6.UseVisualStyleBackColor = true;
			this.metroCheckBox6.CheckedChanged += new global::System.EventHandler(this.metroCheckBox6_CheckedChanged);
			this.metroCheckBox4.AutoSize = true;
			this.metroCheckBox4.ForeColor = global::System.Drawing.Color.White;
			this.metroCheckBox4.Location = new global::System.Drawing.Point(273, 104);
			this.metroCheckBox4.Name = "metroCheckBox4";
			this.metroCheckBox4.Size = new global::System.Drawing.Size(121, 17);
			this.metroCheckBox4.TabIndex = 3;
			this.metroCheckBox4.Text = "Fake Error Message";
			this.metroCheckBox4.UseVisualStyleBackColor = true;
			this.metroCheckBox4.CheckedChanged += new global::System.EventHandler(this.metroCheckBox4_CheckedChanged);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(28, 12);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(123, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "Discord Webhook:";
			this.metroTextBox6.CustomButton.Image = null;
			this.metroTextBox6.CustomButton.Location = new global::System.Drawing.Point(132, 1);
			this.metroTextBox6.CustomButton.Name = "";
			this.metroTextBox6.CustomButton.Size = new global::System.Drawing.Size(21, 21);
			this.metroTextBox6.CustomButton.Style = 4;
			this.metroTextBox6.CustomButton.TabIndex = 1;
			this.metroTextBox6.CustomButton.Theme = 1;
			this.metroTextBox6.CustomButton.UseSelectable = true;
			this.metroTextBox6.CustomButton.Visible = false;
			this.metroTextBox6.Lines = new string[0];
			this.metroTextBox6.Location = new global::System.Drawing.Point(113, 104);
			this.metroTextBox6.MaxLength = 32767;
			this.metroTextBox6.Name = "metroTextBox6";
			this.metroTextBox6.PasswordChar = '\0';
			this.metroTextBox6.PromptText = "Fake error message";
			this.metroTextBox6.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.metroTextBox6.SelectedText = "";
			this.metroTextBox6.SelectionLength = 0;
			this.metroTextBox6.SelectionStart = 0;
			this.metroTextBox6.ShortcutsEnabled = true;
			this.metroTextBox6.Size = new global::System.Drawing.Size(154, 23);
			this.metroTextBox6.Style = 2;
			this.metroTextBox6.TabIndex = 9;
			this.metroTextBox6.Theme = 2;
			this.metroTextBox6.UseSelectable = true;
			this.metroTextBox6.UseStyleColors = true;
			this.metroTextBox6.WaterMark = "Fake error message";
			this.metroTextBox6.WaterMarkColor = global::System.Drawing.Color.White;
			this.metroTextBox6.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.metroTextBox6.Click += new global::System.EventHandler(this.metroTextBox6_Click);
			this.metroTextBox7.CustomButton.Image = null;
			this.metroTextBox7.CustomButton.Location = new global::System.Drawing.Point(233, 1);
			this.metroTextBox7.CustomButton.Name = "";
			this.metroTextBox7.CustomButton.Size = new global::System.Drawing.Size(21, 21);
			this.metroTextBox7.CustomButton.Style = 4;
			this.metroTextBox7.CustomButton.TabIndex = 1;
			this.metroTextBox7.CustomButton.Theme = 1;
			this.metroTextBox7.CustomButton.UseSelectable = true;
			this.metroTextBox7.CustomButton.Visible = false;
			this.metroTextBox7.Lines = new string[0];
			this.metroTextBox7.Location = new global::System.Drawing.Point(12, 75);
			this.metroTextBox7.MaxLength = 32767;
			this.metroTextBox7.Name = "metroTextBox7";
			this.metroTextBox7.PasswordChar = '\0';
			this.metroTextBox7.ReadOnly = true;
			this.metroTextBox7.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.metroTextBox7.SelectedText = "";
			this.metroTextBox7.SelectionLength = 0;
			this.metroTextBox7.SelectionStart = 0;
			this.metroTextBox7.ShortcutsEnabled = true;
			this.metroTextBox7.Size = new global::System.Drawing.Size(255, 23);
			this.metroTextBox7.Style = 2;
			this.metroTextBox7.TabIndex = 17;
			this.metroTextBox7.Theme = 2;
			this.metroTextBox7.UseSelectable = true;
			this.metroTextBox7.UseStyleColors = true;
			this.metroTextBox7.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.metroTextBox7.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.metroTextBox7.Click += new global::System.EventHandler(this.metroTextBox7_Click);
			this.metroButton3.FontSize = 1;
			this.metroButton3.Location = new global::System.Drawing.Point(274, 127);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.Size = new global::System.Drawing.Size(108, 46);
			this.metroButton3.Style = 2;
			this.metroButton3.TabIndex = 18;
			this.metroButton3.Text = "Build";
			this.metroButton3.Theme = 2;
			this.metroButton3.UseSelectable = true;
			this.metroButton3.UseStyleColors = true;
			this.metroButton3.Click += new global::System.EventHandler(this.metroButton3_Click);
			this.metroTextBox5.CustomButton.Image = null;
			this.metroTextBox5.CustomButton.Location = new global::System.Drawing.Point(233, 1);
			this.metroTextBox5.CustomButton.Name = "";
			this.metroTextBox5.CustomButton.Size = new global::System.Drawing.Size(21, 21);
			this.metroTextBox5.CustomButton.Style = 4;
			this.metroTextBox5.CustomButton.TabIndex = 1;
			this.metroTextBox5.CustomButton.Theme = 1;
			this.metroTextBox5.CustomButton.UseSelectable = true;
			this.metroTextBox5.CustomButton.Visible = false;
			this.metroTextBox5.Lines = new string[0];
			this.metroTextBox5.Location = new global::System.Drawing.Point(12, 29);
			this.metroTextBox5.MaxLength = 32767;
			this.metroTextBox5.Name = "metroTextBox5";
			this.metroTextBox5.PasswordChar = '\0';
			this.metroTextBox5.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.metroTextBox5.SelectedText = "";
			this.metroTextBox5.SelectionLength = 0;
			this.metroTextBox5.SelectionStart = 0;
			this.metroTextBox5.ShortcutsEnabled = true;
			this.metroTextBox5.Size = new global::System.Drawing.Size(255, 23);
			this.metroTextBox5.Style = 2;
			this.metroTextBox5.TabIndex = 19;
			this.metroTextBox5.Theme = 2;
			this.metroTextBox5.UseSelectable = true;
			this.metroTextBox5.UseStyleColors = true;
			this.metroTextBox5.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.metroTextBox5.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.metroTextBox5.Click += new global::System.EventHandler(this.metroTextBox5_Click);
			this.metroButton4.FontSize = 1;
			this.metroButton4.Location = new global::System.Drawing.Point(12, 104);
			this.metroButton4.Name = "metroButton4";
			this.metroButton4.Size = new global::System.Drawing.Size(95, 23);
			this.metroButton4.Style = 2;
			this.metroButton4.TabIndex = 21;
			this.metroButton4.Text = "Select icon";
			this.metroButton4.Theme = 2;
			this.metroButton4.UseSelectable = true;
			this.metroButton4.UseStyleColors = true;
			this.metroButton4.Click += new global::System.EventHandler(this.metroButton4_Click);
			this.openFileDialog1.FileName = "openFileDialog1";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(28, 59);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(86, 15);
			this.label3.TabIndex = 23;
			this.label3.Text = "Custom Icon";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(391, 179);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.metroButton4);
			base.Controls.Add(this.metroTextBox5);
			base.Controls.Add(this.metroButton3);
			base.Controls.Add(this.metroTextBox7);
			base.Controls.Add(this.metroTextBox6);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.metroCheckBox6);
			base.Controls.Add(this.metroCheckBox4);
			base.Controls.Add(this.metroCheckBox5);
			base.Controls.Add(this.metroCheckBox2);
			base.Controls.Add(this.metroCheckBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Builder";
			this.Text = "Builder";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000004 RID: 4
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.CheckBox metroCheckBox1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.CheckBox metroCheckBox2;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.CheckBox metroCheckBox5;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.CheckBox metroCheckBox6;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.CheckBox metroCheckBox4;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400000B RID: 11
		private global::MetroFramework.Controls.MetroTextBox metroTextBox6;

		// Token: 0x0400000C RID: 12
		private global::MetroFramework.Controls.MetroTextBox metroTextBox7;

		// Token: 0x0400000D RID: 13
		private global::MetroFramework.Controls.MetroButton metroButton3;

		// Token: 0x0400000E RID: 14
		private global::MetroFramework.Controls.MetroTextBox metroTextBox5;

		// Token: 0x0400000F RID: 15
		private global::MetroFramework.Controls.MetroButton metroButton4;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}
