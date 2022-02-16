using System;

namespace PornHub.Memory.Native.Enums.Services
{
	// Token: 0x02000022 RID: 34
	[Flags]
	internal enum ScmAccess : uint
	{
		// Token: 0x04000449 RID: 1097
		StandardRightsRequired = 983040U,
		// Token: 0x0400044A RID: 1098
		ScManagerConnect = 1U,
		// Token: 0x0400044B RID: 1099
		ScManagerCreateService = 2U,
		// Token: 0x0400044C RID: 1100
		ScManagerEnumerateService = 4U,
		// Token: 0x0400044D RID: 1101
		ScManagerLock = 8U,
		// Token: 0x0400044E RID: 1102
		ScManagerQueryLockStatus = 16U,
		// Token: 0x0400044F RID: 1103
		ScManagerModifyBootConfig = 32U,
		// Token: 0x04000450 RID: 1104
		ScManagerAllAccess = 983103U
	}
}
