using System;

namespace PornHub.Memory.Native.Enums.Services
{
	// Token: 0x02000023 RID: 35
	[Flags]
	internal enum ServiceAccess : uint
	{
		// Token: 0x04000452 RID: 1106
		ServiceQueryConfig = 1U,
		// Token: 0x04000453 RID: 1107
		ServiceChangeConfig = 2U,
		// Token: 0x04000454 RID: 1108
		ServiceQueryStatus = 4U,
		// Token: 0x04000455 RID: 1109
		ServiceEnumerateDependents = 8U,
		// Token: 0x04000456 RID: 1110
		ServiceStart = 16U,
		// Token: 0x04000457 RID: 1111
		ServiceStop = 32U,
		// Token: 0x04000458 RID: 1112
		ServicePauseContinue = 64U,
		// Token: 0x04000459 RID: 1113
		ServiceInterrogate = 128U,
		// Token: 0x0400045A RID: 1114
		ServiceUserDefinedControl = 256U,
		// Token: 0x0400045B RID: 1115
		ServiceAllAccess = 983551U,
		// Token: 0x0400045C RID: 1116
		QueryStartStopDelete = 983095U,
		// Token: 0x0400045D RID: 1117
		GenericRead = 131213U,
		// Token: 0x0400045E RID: 1118
		GenericWrite = 131074U,
		// Token: 0x0400045F RID: 1119
		GenericExecute = 131440U,
		// Token: 0x04000460 RID: 1120
		AccessSystemSecurity = 16777216U,
		// Token: 0x04000461 RID: 1121
		Delete = 65536U,
		// Token: 0x04000462 RID: 1122
		ReadControl = 131072U,
		// Token: 0x04000463 RID: 1123
		WriteDac = 262144U,
		// Token: 0x04000464 RID: 1124
		WriteOwner = 524288U
	}
}
