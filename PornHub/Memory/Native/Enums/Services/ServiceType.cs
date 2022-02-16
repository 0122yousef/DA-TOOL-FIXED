using System;

namespace PornHub.Memory.Native.Enums.Services
{
	// Token: 0x02000026 RID: 38
	[Flags]
	internal enum ServiceType : uint
	{
		// Token: 0x04000471 RID: 1137
		ServiceKernelDriver = 1U,
		// Token: 0x04000472 RID: 1138
		ServiceFileSystemDriver = 2U,
		// Token: 0x04000473 RID: 1139
		ServiceWin32OwnProcess = 16U,
		// Token: 0x04000474 RID: 1140
		ServiceWin32ShareProcess = 32U,
		// Token: 0x04000475 RID: 1141
		ServiceInteractiveProcess = 256U
	}
}
