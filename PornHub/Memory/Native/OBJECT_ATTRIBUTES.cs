using System;
using System.Runtime.InteropServices;

namespace PornHub.Memory.Native
{
	// Token: 0x0200001A RID: 26
	public struct OBJECT_ATTRIBUTES : IDisposable
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x00019A50 File Offset: 0x00017C50
		public OBJECT_ATTRIBUTES(string name, uint attrs)
		{
			this.Length = 0;
			this.RootDirectory = IntPtr.Zero;
			this.objectName = IntPtr.Zero;
			this.Attributes = attrs;
			this.SecurityDescriptor = IntPtr.Zero;
			this.SecurityQualityOfService = IntPtr.Zero;
			this.Length = Marshal.SizeOf<OBJECT_ATTRIBUTES>(this);
			this.ObjectName = new UNICODE_STRING(name);
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00019AB8 File Offset: 0x00017CB8
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00019AE4 File Offset: 0x00017CE4
		public UNICODE_STRING ObjectName
		{
			get
			{
				return (UNICODE_STRING)Marshal.PtrToStructure(this.objectName, typeof(UNICODE_STRING));
			}
			set
			{
				bool flag = this.objectName != IntPtr.Zero;
				bool flag2 = !flag;
				if (flag2)
				{
					this.objectName = Marshal.AllocHGlobal(Marshal.SizeOf<UNICODE_STRING>(value));
				}
				Marshal.StructureToPtr<UNICODE_STRING>(value, this.objectName, flag);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00019B2C File Offset: 0x00017D2C
		public void Dispose()
		{
			bool flag = this.objectName != IntPtr.Zero;
			if (flag)
			{
				Marshal.DestroyStructure(this.objectName, typeof(UNICODE_STRING));
				Marshal.FreeHGlobal(this.objectName);
				this.objectName = IntPtr.Zero;
			}
		}

		// Token: 0x040002B9 RID: 697
		public int Length;

		// Token: 0x040002BA RID: 698
		public IntPtr RootDirectory;

		// Token: 0x040002BB RID: 699
		private IntPtr objectName;

		// Token: 0x040002BC RID: 700
		public uint Attributes;

		// Token: 0x040002BD RID: 701
		public IntPtr SecurityDescriptor;

		// Token: 0x040002BE RID: 702
		public IntPtr SecurityQualityOfService;
	}
}
