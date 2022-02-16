using System;

namespace PornHub.Memory.Native.Enums.Memory
{
	// Token: 0x02000027 RID: 39
	public enum MemoryPagePermissions : uint
	{
		// Token: 0x04000477 RID: 1143
		PAGE_EXECUTE = 16U,
		// Token: 0x04000478 RID: 1144
		PAGE_EXECUTE_READ = 32U,
		// Token: 0x04000479 RID: 1145
		PAGE_EXECUTE_READWRITE = 64U,
		// Token: 0x0400047A RID: 1146
		PAGE_EXECUTE_WRITECOPY = 128U,
		// Token: 0x0400047B RID: 1147
		PAGE_NOACCESS = 1U,
		// Token: 0x0400047C RID: 1148
		PAGE_READONLY,
		// Token: 0x0400047D RID: 1149
		PAGE_READWRITE = 4U,
		// Token: 0x0400047E RID: 1150
		PAGE_WRITECOPY = 8U,
		// Token: 0x0400047F RID: 1151
		PAGE_GUARD = 256U,
		// Token: 0x04000480 RID: 1152
		PAGE_NOCACHE = 512U,
		// Token: 0x04000481 RID: 1153
		PAGE_WRITECOMBINE = 1024U
	}
}
