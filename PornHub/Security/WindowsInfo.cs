using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PornHub.Security
{
	// Token: 0x02000016 RID: 22
	internal class WindowsInfo
	{
		// Token: 0x060000BF RID: 191
		[DllImport("wtsapi32.dll")]
		private static extern IntPtr WTSOpenServer([MarshalAs(UnmanagedType.LPStr)] string pServerName);

		// Token: 0x060000C0 RID: 192
		[DllImport("wtsapi32.dll")]
		private static extern void WTSCloseServer(IntPtr hServer);

		// Token: 0x060000C1 RID: 193
		[DllImport("wtsapi32.dll")]
		private static extern int WTSEnumerateSessions(IntPtr hServer, [MarshalAs(UnmanagedType.U4)] int Reserved, [MarshalAs(UnmanagedType.U4)] int Version, ref IntPtr ppSessionInfo, [MarshalAs(UnmanagedType.U4)] ref int pCount);

		// Token: 0x060000C2 RID: 194
		[DllImport("wtsapi32.dll")]
		private static extern void WTSFreeMemory(IntPtr pMemory);

		// Token: 0x060000C3 RID: 195
		[DllImport("wtsapi32.dll")]
		private static extern bool WTSQuerySessionInformation(IntPtr hServer, int sessionId, WindowsInfo.WTS_INFO_CLASS wtsInfoClass, out IntPtr ppBuffer, out uint pBytesReturned);

		// Token: 0x060000C4 RID: 196 RVA: 0x00019640 File Offset: 0x00017840
		public static int LoggedInUserCount(string serverName)
		{
			IntPtr hServer = IntPtr.Zero;
			List<string> list = new List<string>();
			hServer = WindowsInfo.WTSOpenServer(serverName);
			int num = 0;
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr zero2 = IntPtr.Zero;
				IntPtr zero3 = IntPtr.Zero;
				int num2 = 0;
				int num3 = WindowsInfo.WTSEnumerateSessions(hServer, 0, 1, ref zero, ref num2);
				int offset = Marshal.SizeOf(typeof(WindowsInfo.WTS_SESSION_INFO));
				IntPtr intPtr = zero;
				uint num4 = 0U;
				bool flag = num3 != 0;
				if (flag)
				{
					for (int i = 0; i < num2; i++)
					{
						WindowsInfo.WTS_SESSION_INFO wts_SESSION_INFO = (WindowsInfo.WTS_SESSION_INFO)Marshal.PtrToStructure(intPtr, typeof(WindowsInfo.WTS_SESSION_INFO));
						intPtr += offset;
						WindowsInfo.WTSQuerySessionInformation(hServer, wts_SESSION_INFO.SessionID, WindowsInfo.WTS_INFO_CLASS.WTSUserName, out zero2, out num4);
						WindowsInfo.WTSQuerySessionInformation(hServer, wts_SESSION_INFO.SessionID, WindowsInfo.WTS_INFO_CLASS.WTSDomainName, out zero3, out num4);
						bool flag2 = Marshal.PtrToStringAnsi(zero2) != "";
						if (flag2)
						{
							num++;
						}
						WindowsInfo.WTSFreeMemory(zero2);
						WindowsInfo.WTSFreeMemory(zero3);
					}
					WindowsInfo.WTSFreeMemory(zero);
				}
			}
			finally
			{
				WindowsInfo.WTSCloseServer(hServer);
			}
			return num;
		}

		// Token: 0x02000040 RID: 64
		private struct WTS_SESSION_INFO
		{
			// Token: 0x04000535 RID: 1333
			public int SessionID;

			// Token: 0x04000536 RID: 1334
			[MarshalAs(UnmanagedType.LPStr)]
			public string pWinStationName;

			// Token: 0x04000537 RID: 1335
			public WindowsInfo.WTS_CONNECTSTATE_CLASS State;
		}

		// Token: 0x02000041 RID: 65
		public enum WTS_INFO_CLASS
		{
			// Token: 0x04000539 RID: 1337
			WTSInitialProgram,
			// Token: 0x0400053A RID: 1338
			WTSApplicationName,
			// Token: 0x0400053B RID: 1339
			WTSWorkingDirectory,
			// Token: 0x0400053C RID: 1340
			WTSOEMId,
			// Token: 0x0400053D RID: 1341
			WTSSessionId,
			// Token: 0x0400053E RID: 1342
			WTSUserName,
			// Token: 0x0400053F RID: 1343
			WTSWinStationName,
			// Token: 0x04000540 RID: 1344
			WTSDomainName,
			// Token: 0x04000541 RID: 1345
			WTSConnectState,
			// Token: 0x04000542 RID: 1346
			WTSClientBuildNumber,
			// Token: 0x04000543 RID: 1347
			WTSClientName,
			// Token: 0x04000544 RID: 1348
			WTSClientDirectory,
			// Token: 0x04000545 RID: 1349
			WTSClientProductId,
			// Token: 0x04000546 RID: 1350
			WTSClientHardwareId,
			// Token: 0x04000547 RID: 1351
			WTSClientAddress,
			// Token: 0x04000548 RID: 1352
			WTSClientDisplay,
			// Token: 0x04000549 RID: 1353
			WTSClientProtocolType
		}

		// Token: 0x02000042 RID: 66
		public enum WTS_CONNECTSTATE_CLASS
		{
			// Token: 0x0400054B RID: 1355
			WTSActive,
			// Token: 0x0400054C RID: 1356
			WTSConnected,
			// Token: 0x0400054D RID: 1357
			WTSConnectQuery,
			// Token: 0x0400054E RID: 1358
			WTSShadow,
			// Token: 0x0400054F RID: 1359
			WTSDisconnected,
			// Token: 0x04000550 RID: 1360
			WTSIdle,
			// Token: 0x04000551 RID: 1361
			WTSListen,
			// Token: 0x04000552 RID: 1362
			WTSReset,
			// Token: 0x04000553 RID: 1363
			WTSDown,
			// Token: 0x04000554 RID: 1364
			WTSInit
		}
	}
}
