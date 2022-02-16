using System;
using Microsoft.Win32.SafeHandles;

namespace PornHub.Memory.Logic.Interfaces
{
	// Token: 0x02000033 RID: 51
	public interface MIDriverIo : IDisposable
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000190 RID: 400
		MIDriver Driver { get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000191 RID: 401
		SafeFileHandle Handle { get; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000192 RID: 402
		// (set) Token: 0x06000193 RID: 403
		EventHandler Connected { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000194 RID: 404
		// (set) Token: 0x06000195 RID: 405
		EventHandler Disconnected { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000196 RID: 406
		// (set) Token: 0x06000197 RID: 407
		EventHandler Disposed { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000198 RID: 408
		bool IsConnected { get; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000199 RID: 409
		bool IsDisposed { get; }

		// Token: 0x0600019A RID: 410
		void Connect();

		// Token: 0x0600019B RID: 411
		void Disconnect();

		// Token: 0x0600019C RID: 412
		bool TryIoControl(uint IoCtl);

		// Token: 0x0600019D RID: 413
		bool TryIoControl<TInput>(uint IoCtl, TInput IoData);

		// Token: 0x0600019E RID: 414
		bool TryIoControl<TInput>(uint IoCtl, TInput IoData, int IoDataSize);

		// Token: 0x0600019F RID: 415
		bool TryIoControl<TInput, TOutput>(uint IoCtl, TInput IoData, out TOutput IoOutput);

		// Token: 0x060001A0 RID: 416
		bool TryIoControl<TInput, TOutput>(uint IoCtl, TInput IoData, int IoDataSize, out TOutput IoOutput, int IoOutputSize);
	}
}
