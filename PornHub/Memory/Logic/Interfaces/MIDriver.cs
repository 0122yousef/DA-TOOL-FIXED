using System;

namespace PornHub.Memory.Logic.Interfaces
{
	// Token: 0x02000032 RID: 50
	public interface MIDriver : IDisposable
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000184 RID: 388
		MIDriverIo IO { get; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000185 RID: 389
		MDriverConfig Config { get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000186 RID: 390
		// (set) Token: 0x06000187 RID: 391
		EventHandler Loaded { get; set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000188 RID: 392
		// (set) Token: 0x06000189 RID: 393
		EventHandler Unloaded { get; set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600018A RID: 394
		// (set) Token: 0x0600018B RID: 395
		EventHandler Disposed { get; set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600018C RID: 396
		bool IsLoaded { get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600018D RID: 397
		bool IsDisposed { get; }

		// Token: 0x0600018E RID: 398
		bool Load();

		// Token: 0x0600018F RID: 399
		bool Unload();
	}
}
