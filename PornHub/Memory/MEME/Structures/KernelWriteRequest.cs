using System;

namespace PornHub.Memory.MEME.Structures
{
	// Token: 0x0200002C RID: 44
	internal struct KernelWriteRequest
	{
		// Token: 0x0400049A RID: 1178
		internal ulong ProcessId;

		// Token: 0x0400049B RID: 1179
		internal ulong Address;

		// Token: 0x0400049C RID: 1180
		internal ulong Value;

		// Token: 0x0400049D RID: 1181
		internal int Size;

		// Token: 0x0400049E RID: 1182
		internal ulong data;
	}
}
