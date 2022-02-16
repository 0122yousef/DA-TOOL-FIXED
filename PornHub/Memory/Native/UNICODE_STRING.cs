using System;
using System.Runtime.InteropServices;

namespace PornHub.Memory.Native
{
	// Token: 0x0200001B RID: 27
	public struct UNICODE_STRING : IDisposable
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x00019B7D File Offset: 0x00017D7D
		public UNICODE_STRING(string s)
		{
			this.Length = (ushort)(s.Length * 2);
			this.MaximumLength = (ushort)(this.Length + 2);
			this.buffer = Marshal.StringToHGlobalUni(s);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00019BAA File Offset: 0x00017DAA
		public void Dispose()
		{
			Marshal.FreeHGlobal(this.buffer);
			this.buffer = IntPtr.Zero;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00019BC4 File Offset: 0x00017DC4
		public override string ToString()
		{
			return Marshal.PtrToStringUni(this.buffer);
		}

		// Token: 0x040002BF RID: 703
		public ushort Length;

		// Token: 0x040002C0 RID: 704
		public ushort MaximumLength;

		// Token: 0x040002C1 RID: 705
		private IntPtr buffer;
	}
}
