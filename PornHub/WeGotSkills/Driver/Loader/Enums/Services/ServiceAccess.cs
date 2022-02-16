using System;

namespace WeGotSkills.Driver.Loader.Enums.Services
{
	// Token: 0x02000006 RID: 6
	[Flags]
	public enum ServiceAccess : uint
	{
		// Token: 0x04000180 RID: 384
		ServiceQueryConfig = 1U,
		// Token: 0x04000181 RID: 385
		ServiceChangeConfig = 2U,
		// Token: 0x04000182 RID: 386
		ServiceQueryStatus = 4U,
		// Token: 0x04000183 RID: 387
		ServiceEnumerateDependents = 8U,
		// Token: 0x04000184 RID: 388
		ServiceStart = 16U,
		// Token: 0x04000185 RID: 389
		ServiceStop = 32U,
		// Token: 0x04000186 RID: 390
		ServicePauseContinue = 64U,
		// Token: 0x04000187 RID: 391
		ServiceInterrogate = 128U,
		// Token: 0x04000188 RID: 392
		ServiceUserDefinedControl = 256U,
		// Token: 0x04000189 RID: 393
		ServiceAllAccess = 983551U,
		// Token: 0x0400018A RID: 394
		GenericRead = 131213U,
		// Token: 0x0400018B RID: 395
		GenericWrite = 131074U,
		// Token: 0x0400018C RID: 396
		GenericExecute = 131440U,
		// Token: 0x0400018D RID: 397
		AccessSystemSecurity = 16777216U,
		// Token: 0x0400018E RID: 398
		Delete = 65536U,
		// Token: 0x0400018F RID: 399
		ReadControl = 131072U,
		// Token: 0x04000190 RID: 400
		WriteDac = 262144U,
		// Token: 0x04000191 RID: 401
		WriteOwner = 524288U
	}
}
