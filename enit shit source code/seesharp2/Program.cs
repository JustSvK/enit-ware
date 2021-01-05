using System;
using System.Configuration;
using System.Windows.Forms;

namespace seesharp2
{
	// Token: 0x02000007 RID: 7
	internal static class Program
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00004B8B File Offset: 0x00002D8B
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004BA4 File Offset: 0x00002DA4
		public static bool setSetting(string Key, string Value)
		{
			Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			bool flag = false;
			string[] allKeys = configuration.AppSettings.Settings.AllKeys;
			for (int i = 0; i < allKeys.Length; i++)
			{
				if (allKeys[i] == Key)
				{
					flag = true;
					configuration.AppSettings.Settings[Key].Value = Value;
					break;
				}
			}
			if (!flag)
			{
				configuration.AppSettings.Settings.Add(Key, Value);
			}
			configuration.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("appSettings");
			return true;
		}
	}
}
