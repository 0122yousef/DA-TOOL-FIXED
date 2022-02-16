using System;

namespace PornHub.Memory.Logic.Interfaces
{
	// Token: 0x02000034 RID: 52
	internal interface MIDriverLoad
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001A1 RID: 417
		bool IsCreated { get; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001A2 RID: 418
		bool IsLoaded { get; }

		// Token: 0x060001A3 RID: 419
		bool CreateDriver(MDriver Driver);

		// Token: 0x060001A4 RID: 420
		bool LoadDriver();

		// Token: 0x060001A5 RID: 421
		bool StopDriver();

		// Token: 0x060001A6 RID: 422
		bool DeleteDriver();
	}
}
