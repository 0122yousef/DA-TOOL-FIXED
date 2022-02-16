using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace PornHub.Properties
{
	// Token: 0x0200000E RID: 14
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000088 RID: 136 RVA: 0x000173C8 File Offset: 0x000155C8
		internal Resources()
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000173D4 File Offset: 0x000155D4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("PornHub.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0001741C File Offset: 0x0001561C
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00017433 File Offset: 0x00015633
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

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0001743C File Offset: 0x0001563C
		internal static Bitmap Default_GIIF
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Default_GIIF", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0001746C File Offset: 0x0001566C
		internal static byte[] Driver
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Driver", Resources.resourceCulture);
				return (byte[])@object;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0001749C File Offset: 0x0001569C
		internal static Bitmap glitchy_loading_indicator
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("glitchy-loading-indicator", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000174CC File Offset: 0x000156CC
		internal static Bitmap Hyper_GIF
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Hyper_GIF", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000174FC File Offset: 0x000156FC
		internal static Bitmap hyper_loading
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("hyper_loading", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0001752C File Offset: 0x0001572C
		internal static byte[] inject
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("inject", Resources.resourceCulture);
				return (byte[])@object;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0001755C File Offset: 0x0001575C
		internal static byte[] kdmapper
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("kdmapper", Resources.resourceCulture);
				return (byte[])@object;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0001758C File Offset: 0x0001578C
		internal static Bitmap UI2_0_1
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("UI2.0_1", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000175BC File Offset: 0x000157BC
		internal static Bitmap zqinithian2
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("zqinithian2", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000175EC File Offset: 0x000157EC
		internal static Bitmap zqinline
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("zqinline", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x0400029C RID: 668
		private static ResourceManager resourceMan;

		// Token: 0x0400029D RID: 669
		private static CultureInfo resourceCulture;
	}
}
