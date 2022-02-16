using System;

namespace WeGotSkills.Driver.Loader.Enums.Services
{
	// Token: 0x02000009 RID: 9
	[Flags]
	public enum ServiceType : uint
	{
		// Token: 0x0400019E RID: 414
		ServiceKernelDriver = 1U,
		// Token: 0x0400019F RID: 415
		ServiceFileSystemDriver = 2U,
		// Token: 0x040001A0 RID: 416
		ServiceWin32OwnProcess = 16U,
		// Token: 0x040001A1 RID: 417
		ServiceWin32ShareProcess = 32U,
		// Token: 0x040001A2 RID: 418
		ServiceInteractiveProcess = 256U
	}
}
