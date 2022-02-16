using System;

namespace WeGotSkills.Driver.Loader.Enums
{
	// Token: 0x02000002 RID: 2
	[Flags]
	internal enum AccessMask : uint
	{
		// Token: 0x04000002 RID: 2
		Delete = 65536U,
		// Token: 0x04000003 RID: 3
		ReadControl = 131072U,
		// Token: 0x04000004 RID: 4
		WriteDac = 262144U,
		// Token: 0x04000005 RID: 5
		WriteOwner = 524288U,
		// Token: 0x04000006 RID: 6
		Synchronize = 1048576U,
		// Token: 0x04000007 RID: 7
		StandardRightsRequired = 983040U,
		// Token: 0x04000008 RID: 8
		StandardRightsRead = 131072U,
		// Token: 0x04000009 RID: 9
		StandardRightsWrite = 131072U,
		// Token: 0x0400000A RID: 10
		StandardRightsExecute = 131072U,
		// Token: 0x0400000B RID: 11
		StandardRightsAll = 2031616U,
		// Token: 0x0400000C RID: 12
		SpecificRightsAll = 65535U,
		// Token: 0x0400000D RID: 13
		AccessSystemSecurity = 16777216U,
		// Token: 0x0400000E RID: 14
		MaximumAllowed = 33554432U,
		// Token: 0x0400000F RID: 15
		GenericRead = 2147483648U,
		// Token: 0x04000010 RID: 16
		GenericWrite = 1073741824U,
		// Token: 0x04000011 RID: 17
		GenericExecute = 536870912U,
		// Token: 0x04000012 RID: 18
		GenericAll = 268435456U,
		// Token: 0x04000013 RID: 19
		DesktopReadobjects = 1U,
		// Token: 0x04000014 RID: 20
		DesktopCreatewindow = 2U,
		// Token: 0x04000015 RID: 21
		DesktopCreatemenu = 4U,
		// Token: 0x04000016 RID: 22
		DesktopHookcontrol = 8U,
		// Token: 0x04000017 RID: 23
		DesktopJournalrecord = 16U,
		// Token: 0x04000018 RID: 24
		DesktopJournalplayback = 32U,
		// Token: 0x04000019 RID: 25
		DesktopEnumerate = 64U,
		// Token: 0x0400001A RID: 26
		DesktopWriteobjects = 128U,
		// Token: 0x0400001B RID: 27
		DesktopSwitchdesktop = 256U,
		// Token: 0x0400001C RID: 28
		WinstaEnumdesktops = 1U,
		// Token: 0x0400001D RID: 29
		WinstaReadattributes = 2U,
		// Token: 0x0400001E RID: 30
		WinstaAccessclipboard = 4U,
		// Token: 0x0400001F RID: 31
		WinstaCreatedesktop = 8U,
		// Token: 0x04000020 RID: 32
		WinstaWriteattributes = 16U,
		// Token: 0x04000021 RID: 33
		WinstaAccessglobalatoms = 32U,
		// Token: 0x04000022 RID: 34
		WinstaExitwindows = 64U,
		// Token: 0x04000023 RID: 35
		WinstaEnumerate = 256U,
		// Token: 0x04000024 RID: 36
		WinstaReadscreen = 512U,
		// Token: 0x04000025 RID: 37
		WinstaAllAccess = 895U
	}
}
