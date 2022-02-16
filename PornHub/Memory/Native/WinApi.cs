using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace PornHub.Memory.Native
{
	// Token: 0x0200001C RID: 28
	internal static class WinApi
	{
		// Token: 0x060000D8 RID: 216
		[DllImport("ntdll.dll", SetLastError = true)]
		internal static extern uint NtCreateSection(ref IntPtr SectionHandle, uint DesiredAccess, IntPtr ObjectAttributes, ref ulong MaximumSize, uint SectionPageProtection, uint AllocationAttributes, IntPtr FileHandle);

		// Token: 0x060000D9 RID: 217
		[DllImport("ntdll.dll", SetLastError = true)]
		internal static extern uint NtOpenSection(ref IntPtr SectionHandle, uint DesiredAccess, IntPtr ObjectAttributes);

		// Token: 0x060000DA RID: 218
		[DllImport("ntdll.dll", SetLastError = true)]
		internal static extern uint NtMapViewOfSection(IntPtr SectionHandle, IntPtr ProcessHandle, ref IntPtr BaseAddress, UIntPtr ZeroBits, UIntPtr CommitSize, out ulong SectionOffset, out uint ViewSize, uint InheritDisposition, uint AllocationType, uint Win32Protect);

		// Token: 0x060000DB RID: 219
		[DllImport("ntdll.dll", SetLastError = true)]
		internal static extern uint NtCreateEvent(ref IntPtr EventHandle, uint DesiredAccess, IntPtr ObjectAttributes, uint EventType, bool InitialState);

		// Token: 0x060000DC RID: 220
		[DllImport("ntdll.dll", SetLastError = true)]
		internal static extern uint NtOpenEvent(ref IntPtr EventHandle, uint DesiredAccess, IntPtr ObjectAttributes);

		// Token: 0x060000DD RID: 221
		[DllImport("ntdll.dll", SetLastError = true)]
		internal static extern uint NtClose(IntPtr Handle);

		// Token: 0x060000DE RID: 222
		[DllImport("kernel32.dll")]
		internal static extern void CopyMemory(IntPtr Destination, IntPtr Source, uint Length);

		// Token: 0x060000DF RID: 223
		[DllImport("kernel32.dll")]
		internal static extern IntPtr LoadLibrary(string dllToLoad);

		// Token: 0x060000E0 RID: 224
		[DllImport("kernel32.dll")]
		internal static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

		// Token: 0x060000E1 RID: 225
		[DllImport("kernel32.dll")]
		internal static extern bool FreeLibrary(IntPtr hModule);

		// Token: 0x060000E2 RID: 226
		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, EntryPoint = "OpenSCManagerW", ExactSpelling = true, SetLastError = true)]
		internal static extern IntPtr OpenSCManager(string MachineName, string DatabaseName, uint DesiredAccess);

		// Token: 0x060000E3 RID: 227
		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern IntPtr CreateService(IntPtr ServiceManager, string ServiceName, string DisplayName, uint DesiredAccess, uint ServiceType, uint StartType, uint ErrorControl, string BinaryPathName, string LoadOrderGroup, string TagId, string Dependencies, string ServiceStartName, string Password);

		// Token: 0x060000E4 RID: 228
		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern IntPtr OpenService(IntPtr ServiceManager, string ServiceName, uint DesiredAccess);

		// Token: 0x060000E5 RID: 229
		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool DeleteService(IntPtr Service);

		// Token: 0x060000E6 RID: 230
		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CloseServiceHandle(IntPtr Handle);

		// Token: 0x060000E7 RID: 231
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CloseHandle(IntPtr Handle);

		// Token: 0x060000E8 RID: 232
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern SafeFileHandle CreateFile(string FileName, [MarshalAs(UnmanagedType.U4)] FileAccess FileAccess, [MarshalAs(UnmanagedType.U4)] FileShare FileShare, IntPtr SecurityAttributes, [MarshalAs(UnmanagedType.U4)] FileMode CreationDisposition, [MarshalAs(UnmanagedType.U4)] uint FlagsAndAttributes, IntPtr Template);

		// Token: 0x060000E9 RID: 233 RVA: 0x00019BE4 File Offset: 0x00017DE4
		internal static uint CtlCode(uint DeviceType, uint Function, uint Method, uint Access)
		{
			return DeviceType << 16 | Access << 14 | Function << 2 | Method;
		}
	}
}
