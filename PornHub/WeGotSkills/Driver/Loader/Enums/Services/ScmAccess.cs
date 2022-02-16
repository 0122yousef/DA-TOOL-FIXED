using System;

namespace WeGotSkills.Driver.Loader.Enums.Services
{
	// Token: 0x02000005 RID: 5
	[Flags]
	internal enum ScmAccess : uint
	{
		// Token: 0x04000177 RID: 375
		StandardRightsRequired = 983040U,
		// Token: 0x04000178 RID: 376
		ScManagerConnect = 1U,
		// Token: 0x04000179 RID: 377
		ScManagerCreateService = 2U,
		// Token: 0x0400017A RID: 378
		ScManagerEnumerateService = 4U,
		// Token: 0x0400017B RID: 379
		ScManagerLock = 8U,
		// Token: 0x0400017C RID: 380
		ScManagerQueryLockStatus = 16U,
		// Token: 0x0400017D RID: 381
		ScManagerModifyBootConfig = 32U,
		// Token: 0x0400017E RID: 382
		ScManagerAllAccess = 983103U
	}
}
