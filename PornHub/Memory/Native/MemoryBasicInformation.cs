using System;
using PornHub.Memory.Native.Enums.Memory;

namespace PornHub.Memory.Native
{
	// Token: 0x02000019 RID: 25
	public struct MemoryBasicInformation
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00019A30 File Offset: 0x00017C30
		public ulong EndAddress
		{
			get
			{
				return this.BaseAddress + this.RegionSize;
			}
		}

		// Token: 0x040002B2 RID: 690
		public ulong BaseAddress;

		// Token: 0x040002B3 RID: 691
		public ulong AllocationBase;

		// Token: 0x040002B4 RID: 692
		public MemoryPagePermissions AllocationProtect;

		// Token: 0x040002B5 RID: 693
		public ulong RegionSize;

		// Token: 0x040002B6 RID: 694
		public MemoryPageState State;

		// Token: 0x040002B7 RID: 695
		public MemoryPagePermissions Protect;

		// Token: 0x040002B8 RID: 696
		public MemoryPageType Type;
	}
}
