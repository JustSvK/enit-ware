using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace seesharp2
{
	// Token: 0x02000005 RID: 5
	public partial class Decrypter : Form
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000033C2 File Offset: 0x000015C2
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000033CA File Offset: 0x000015CA
		private List<string> alldata { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000033D3 File Offset: 0x000015D3
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000033DB File Offset: 0x000015DB
		private string IcoFilePath { get; set; }

		// Token: 0x0600001E RID: 30 RVA: 0x000033E4 File Offset: 0x000015E4
		public Decrypter()
		{
			this.InitializeComponent();
			this.metroTextBox4.Text = ConfigurationManager.AppSettings["savefolderpath"];
			string text = this.metroTextBox4.Text;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003418 File Offset: 0x00001618
		private void metroButton1_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.ShowNewFolderButton = true;
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				string selectedPath = folderBrowserDialog.SelectedPath;
				this.metroTextBox4.Clear();
				this.metroTextBox4.AppendText(selectedPath);
				Program.setSetting("savefolderpath", this.metroTextBox4.Text);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003470 File Offset: 0x00001670
		private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			this.metroTextBox1.Clear();
			this.metroTextBox2.Clear();
			this.metroTextBox3.Clear();
			try
			{
				string curGrowID = this.listBox1.SelectedItem.ToString();
				this.metroTextBox1.Text = curGrowID;
				string[] array = this.alldata.FirstOrDefault((string alldata) => alldata.Contains(curGrowID)).Split(new string[]
				{
					"[This-Is-A-Split]"
				}, StringSplitOptions.RemoveEmptyEntries);
				this.metroTextBox2.Text = array[1];
				foreach (string text in array[2].Split(new string[]
				{
					"[#---Zephyr---#]"
				}, StringSplitOptions.RemoveEmptyEntries))
				{
					if (text != "")
					{
						this.metroTextBox3.AppendText(text);
						this.metroTextBox3.AppendText(Environment.NewLine);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003570 File Offset: 0x00001770
		private void metroButton2_Click(object sender, EventArgs e)
		{
			this.alldata = this.DecodeDats();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003580 File Offset: 0x00001780
		public List<string> DecodeDats()
		{
			List<string> result;
			try
			{
				List<string> list = new List<string>();
				this.listBox1.Items.Clear();
				string[] files = Directory.GetFiles(ConfigurationManager.AppSettings["savefolderpath"], "*.dat");
				Regex regex = new Regex("[^\\w0-9]");
				foreach (string path in files)
				{
					string text = null;
					File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
					{
						using (StreamReader streamReader = new StreamReader(fileStream, Encoding.Default))
						{
							text = streamReader.ReadToEnd();
						}
					}
					string text2 = text.Replace("\0", " ");
					string text3 = regex.Replace(text2.Substring(text2.IndexOf("tankid_name") + "tankid_name".Length).Split(new char[]
					{
						' '
					})[3], string.Empty);
					this.listBox1.Items.Add(text3);
					string text4 = regex.Replace(text2.Substring(text2.IndexOf("lastworld") + "lastworld".Length).Split(new char[]
					{
						' '
					})[3], string.Empty);
					if (text4 == "fullscreen")
					{
						text4 = null;
					}
					string[] array2 = new Decrypter.PasswordDec().Func(Encoding.Default.GetBytes(text));
					string text5 = "";
					foreach (string str in array2)
					{
						text5 = text5 + str + "[#---Zephyr---#]";
					}
					string item = string.Concat(new string[]
					{
						text3,
						"[This-Is-A-Split]",
						text4,
						"[This-Is-A-Split]",
						text5
					});
					list.Add(item);
				}
				result = list;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000037B0 File Offset: 0x000019B0
		private void metroTextBox4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000037B2 File Offset: 0x000019B2
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000037B4 File Offset: 0x000019B4
		private void metroTextBox3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000037B6 File Offset: 0x000019B6
		private void metroTextBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000037B8 File Offset: 0x000019B8
		private void metroTextBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0200000A RID: 10
		public class PasswordDec
		{
			// Token: 0x0600003E RID: 62 RVA: 0x00004CA4 File Offset: 0x00002EA4
			public List<string> PPW(byte[] contents)
			{
				List<string> result;
				try
				{
					string text = "";
					foreach (byte b in contents)
					{
						string text2 = b.ToString("X2");
						if (text2 == "00")
						{
							text += "<>";
						}
						else
						{
							text += text2;
						}
					}
					if (text.Contains("74616E6B69645F70617373776F7264"))
					{
						string text3 = "74616E6B69645F70617373776F7264";
						int num = text.IndexOf(text3);
						int num2 = text.LastIndexOf(text3);
						string text4;
						if (false)
						{
							text4 = string.Empty;
						}
						num += text3.Length;
						int num3 = text.IndexOf("<><><>", num);
						if (false)
						{
							text4 = string.Empty;
						}
						if (((Encoding.UTF8.GetString(this.StringToByteArray(text.Substring(num, num3 - num).Trim())).ToCharArray()[0] == '_') ? 1 : 0) == 0)
						{
							text4 = text.Substring(num, num3 - num).Trim();
						}
						else
						{
							num2 += text3.Length;
							num3 = text.IndexOf("<><><>", num2);
							text4 = text.Substring(num2, num3 - num2).Trim();
						}
						string text5 = "74616E6B69645F70617373776F7264" + text4 + "<><><>";
						int num4 = text.IndexOf(text5);
						string text6;
						if (false)
						{
							text6 = string.Empty;
						}
						num4 += text5.Length;
						int num5 = text.IndexOf("<><><>", num4);
						if (false)
						{
							text6 = string.Empty;
						}
						text6 = text.Substring(num4, num5 - num4).Trim();
						int num6 = (int)this.StringToByteArray(text4)[0];
						text6 = text6.Substring(0, num6 * 2);
						byte[] array = this.StringToByteArray(text6.Replace("<>", "00"));
						List<byte> list = new List<byte>();
						List<byte> list2 = new List<byte>();
						byte b2 = 48 - array[0];
						foreach (byte b3 in array)
						{
							list.Add(b2 + b3);
						}
						for (int k = 0; k < list.Count; k++)
						{
							list2.Add((byte)((int)(list[k] - 1) - k));
						}
						List<string> list3 = new List<string>();
						for (int l = 0; l <= 255; l++)
						{
							string text7 = "";
							foreach (byte b4 in list2)
							{
								if (this.ValidateChar((char)((byte)((int)b4 + l))))
								{
									text7 += ((char)((byte)((int)b4 + l))).ToString();
								}
							}
							if (text7.Length == num6)
							{
								list3.Add(text7);
							}
						}
						result = list3;
					}
					else
					{
						result = null;
					}
				}
				catch
				{
					result = null;
				}
				return result;
			}

			// Token: 0x0600003F RID: 63 RVA: 0x00004FAC File Offset: 0x000031AC
			public byte[] StringToByteArray(string str)
			{
				Dictionary<string, byte> dictionary = new Dictionary<string, byte>();
				for (int i = 0; i <= 255; i++)
				{
					dictionary.Add(i.ToString("X2"), (byte)i);
				}
				List<byte> list = new List<byte>();
				for (int j = 0; j < str.Length; j += 2)
				{
					list.Add(dictionary[str.Substring(j, 2)]);
				}
				return list.ToArray();
			}

			// Token: 0x06000040 RID: 64 RVA: 0x00005014 File Offset: 0x00003214
			private bool ValidateChar(char cdzdshr)
			{
				return (cdzdshr >= '0' && cdzdshr <= '9') || (cdzdshr >= 'A' && cdzdshr <= 'Z') || (cdzdshr >= 'a' && cdzdshr <= 'z') || (cdzdshr >= '+' && cdzdshr <= '.') || (cdzdshr >= '!' && cdzdshr <= ')') || (cdzdshr >= '*' && cdzdshr <= '/') || (cdzdshr >= ':' && cdzdshr <= '@') || (cdzdshr >= '[' && cdzdshr <= '`') || (cdzdshr >= '{' && cdzdshr <= '~');
			}

			// Token: 0x06000041 RID: 65 RVA: 0x00005080 File Offset: 0x00003280
			public string[] Func(byte[] lel)
			{
				return this.PPW(lel).ToArray();
			}
		}
	}
}
