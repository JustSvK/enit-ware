using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace seesharp2.Properties
{
	// Token: 0x02000008 RID: 8
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00004C26 File Offset: 0x00002E26
		internal Resources()
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00004C2E File Offset: 0x00002E2E
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("seesharp2.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00004C5A File Offset: 0x00002E5A
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00004C61 File Offset: 0x00002E61
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00004C69 File Offset: 0x00002E69
		internal static string Code
		{
			get
			{
				return Resources.ResourceManager.GetString("Code", Resources.resourceCulture);
			}
		}

		// Token: 0x0400002F RID: 47
		private static ResourceManager resourceMan;

		// Token: 0x04000030 RID: 48
		private static CultureInfo resourceCulture;
	}
}
