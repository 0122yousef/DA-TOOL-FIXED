using System;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.ServiceProcess;
using Microsoft.Win32;
using PornHub.Memory.Native;
using PornHub.Memory.Native.Enums.Services;

namespace PornHub.Memory.Utilities
{
	// Token: 0x02000018 RID: 24
	[ServiceControllerPermission(SecurityAction.Demand, PermissionAccess = ServiceControllerPermissionAccess.Control)]
	internal static class MService
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x000197D8 File Offset: 0x000179D8
		internal static IntPtr Create(string ServiceName, string DisplayName, ServiceAccess ServiceAccess, PornHub.Memory.Native.Enums.Services.ServiceType ServiceType, ServiceStart ServiceStart, ServiceError ServiceError, FileInfo File)
		{
			IntPtr intPtr = WinApi.OpenSCManager(null, null, 983103U);
			bool flag = intPtr == IntPtr.Zero;
			IntPtr result;
			if (flag)
			{
				result = IntPtr.Zero;
			}
			else
			{
				IntPtr intPtr2 = WinApi.CreateService(intPtr, ServiceName, DisplayName, (uint)ServiceAccess, (uint)ServiceType, (uint)ServiceStart, (uint)ServiceError, File.FullName, null, null, null, null, null);
				WinApi.CloseServiceHandle(intPtr);
				bool flag2 = intPtr2 == IntPtr.Zero;
				if (flag2)
				{
					result = IntPtr.Zero;
				}
				else
				{
					result = intPtr2;
				}
			}
			return result;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0001984C File Offset: 0x00017A4C
		internal static IntPtr Open(string ServiceName, ServiceAccess ServiceAccess)
		{
			IntPtr intPtr = WinApi.OpenSCManager(null, null, 983103U);
			bool flag = intPtr != IntPtr.Zero;
			IntPtr result;
			if (flag)
			{
				IntPtr intPtr2 = WinApi.OpenService(intPtr, ServiceName, (uint)ServiceAccess);
				bool flag2 = !MService.Close(intPtr);
				if (flag2)
				{
				}
				result = intPtr2;
			}
			else
			{
				result = IntPtr.Zero;
			}
			return result;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000198A0 File Offset: 0x00017AA0
		internal static IntPtr CreateOrOpen(string ServiceName, string DisplayName, ServiceAccess ServiceAccess, PornHub.Memory.Native.Enums.Services.ServiceType ServiceType, ServiceStart ServiceStart, ServiceError ServiceError, FileInfo File)
		{
			IntPtr intPtr = MService.Create(ServiceName, DisplayName, ServiceAccess, ServiceType, ServiceStart, ServiceError, File);
			bool flag = intPtr == IntPtr.Zero;
			IntPtr result;
			if (flag)
			{
				result = MService.Open(ServiceName, ServiceAccess);
			}
			else
			{
				result = intPtr;
			}
			return result;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000198E0 File Offset: 0x00017AE0
		internal static bool Exists(string ServiceName)
		{
			IntPtr intPtr = MService.Open(ServiceName, ServiceAccess.ServiceAllAccess);
			bool flag = intPtr != IntPtr.Zero;
			bool result;
			if (flag)
			{
				bool flag2 = !MService.Close(intPtr);
				if (flag2)
				{
				}
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00019924 File Offset: 0x00017B24
		internal static bool ExistsInRegistry(string ServiceName, Func<ServiceController, bool> Comparer = null)
		{
			bool flag = Comparer != null;
			if (flag)
			{
				ServiceController[] services = ServiceController.GetServices();
				bool flag2 = services.Any(Comparer);
				if (flag2)
				{
					return true;
				}
			}
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\", RegistryRights.EnumerateSubKeys))
			{
				string[] subKeyNames = registryKey.GetSubKeyNames();
				bool flag3 = subKeyNames.Any((string Name) => Name == ServiceName);
				if (flag3)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000199C4 File Offset: 0x00017BC4
		internal static bool Delete(IntPtr Handle)
		{
			bool flag = Handle == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("Handle is invalid at Delete(Handle).", "Handle");
			}
			bool flag2 = !WinApi.DeleteService(Handle);
			bool result;
			if (flag2)
			{
				result = false;
			}
			else
			{
				bool flag3 = !MService.Close(Handle);
				if (flag3)
				{
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00019A18 File Offset: 0x00017C18
		internal static bool Close(IntPtr Handle)
		{
			return WinApi.CloseServiceHandle(Handle);
		}
	}
}
