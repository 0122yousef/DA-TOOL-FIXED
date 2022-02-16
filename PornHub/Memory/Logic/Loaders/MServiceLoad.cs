using System;
using System.ComponentModel;
using System.Security.Permissions;
using System.ServiceProcess;
using PornHub.Memory.Logic.Interfaces;
using PornHub.Memory.Native.Enums.Services;
using PornHub.Memory.Utilities;

namespace PornHub.Memory.Logic.Loaders
{
	// Token: 0x02000031 RID: 49
	[ServiceControllerPermission(SecurityAction.Demand, PermissionAccess = ServiceControllerPermissionAccess.Control)]
	internal sealed class MServiceLoad : MIDriverLoad
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0001C200 File Offset: 0x0001A400
		// (set) Token: 0x06000176 RID: 374 RVA: 0x0001C208 File Offset: 0x0001A408
		public bool IsCreated { get; private set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0001C211 File Offset: 0x0001A411
		// (set) Token: 0x06000178 RID: 376 RVA: 0x0001C219 File Offset: 0x0001A419
		public bool IsLoaded { get; private set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0001C222 File Offset: 0x0001A422
		// (set) Token: 0x0600017A RID: 378 RVA: 0x0001C22A File Offset: 0x0001A42A
		public MDriver Driver { get; private set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0001C233 File Offset: 0x0001A433
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0001C23B File Offset: 0x0001A43B
		public IntPtr ServiceHandle { get; private set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0001C244 File Offset: 0x0001A444
		// (set) Token: 0x0600017E RID: 382 RVA: 0x0001C24C File Offset: 0x0001A44C
		public ServiceController Service { get; private set; }

		// Token: 0x0600017F RID: 383 RVA: 0x0001C258 File Offset: 0x0001A458
		public bool CreateDriver(MDriver Driver)
		{
			MDriverConfig config = Driver.Config;
			bool isCreated = this.IsCreated;
			if (isCreated)
			{
				throw new Exception("Service is already created");
			}
			bool flag = config == null;
			if (flag)
			{
				throw new ArgumentNullException("Config");
			}
			this.Driver = Driver;
			bool flag2 = Driver == null;
			if (flag2)
			{
				throw new ArgumentNullException("Driver", "Driver is null");
			}
			this.ServiceHandle = MService.CreateOrOpen(config.ServiceName, config.ServiceName, ServiceAccess.ServiceAllAccess, PornHub.Memory.Native.Enums.Services.ServiceType.ServiceKernelDriver, ServiceStart.ServiceDemandStart, ServiceError.ServiceErrorNormal, config.DriverFile);
			bool flag3 = this.ServiceHandle == IntPtr.Zero;
			bool result;
			if (flag3)
			{
				result = false;
			}
			else
			{
				this.Service = new ServiceController(config.ServiceName);
				this.IsCreated = true;
				result = true;
			}
			return result;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0001C31C File Offset: 0x0001A51C
		public bool LoadDriver()
		{
			bool flag = !this.IsCreated;
			if (flag)
			{
				throw new Exception("Service is not created.");
			}
			bool isLoaded = this.IsLoaded;
			bool result;
			if (isLoaded)
			{
				result = true;
			}
			else
			{
				bool flag2 = this.Service.Status != ServiceControllerStatus.Running;
				if (flag2)
				{
					try
					{
						this.Service.Start();
					}
					catch (InvalidOperationException ex)
					{
						Log.Error(typeof(MServiceLoad), ex.GetType().Name + ", " + ex.Message);
						return false;
					}
					catch (Win32Exception ex2)
					{
						bool flag3 = ex2.Message.Contains("signature");
						if (flag3)
						{
							Log.Error(typeof(MServiceLoad), "The driver is not signed, unable to load it using the service manager.");
						}
						else
						{
							Log.Error(typeof(MServiceLoad), ex2.GetType().Name + ", " + ex2.Message);
						}
						return false;
					}
					catch (Exception ex3)
					{
						Log.Error(typeof(MServiceLoad), ex3.GetType().Name + ", " + ex3.Message);
						return false;
					}
					try
					{
						this.Service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10.0));
					}
					catch (System.TimeoutException)
					{
						Log.Error(typeof(MServiceLoad), "Failed to start the service in 10 seconds.");
					}
					catch (Exception ex4)
					{
						Log.Error(typeof(MServiceLoad), ex4.GetType().Name + ", " + ex4.Message);
						return false;
					}
				}
				this.IsLoaded = true;
				result = true;
			}
			return result;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0001C514 File Offset: 0x0001A714
		public bool StopDriver()
		{
			bool flag = !this.IsCreated;
			if (flag)
			{
				throw new Exception("Service is not created.");
			}
			bool flag2 = !this.IsLoaded;
			bool result;
			if (flag2)
			{
				result = true;
			}
			else
			{
				bool canStop = this.Service.CanStop;
				if (canStop)
				{
					try
					{
						this.Service.Stop();
					}
					catch (Exception ex)
					{
						Log.Error(typeof(MServiceLoad), ex.GetType().Name + ", " + ex.Message);
						return false;
					}
					this.IsLoaded = false;
					try
					{
						this.Service.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10.0));
					}
					catch (System.TimeoutException)
					{
						Log.Error(typeof(MServiceLoad), "Failed to stop the service in 10 seconds.");
					}
					catch (Exception ex2)
					{
						Log.Error(typeof(MServiceLoad), ex2.GetType().Name + ", " + ex2.Message);
						return false;
					}
					this.IsLoaded = false;
					result = true;
				}
				else
				{
					Log.Error(typeof(MServiceLoad), "Driver not stopped !");
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0001C674 File Offset: 0x0001A874
		public bool DeleteDriver()
		{
			bool flag = !this.IsCreated;
			if (flag)
			{
				throw new Exception("Service is not created.");
			}
			bool isLoaded = this.IsLoaded;
			if (isLoaded)
			{
				bool flag2 = !this.StopDriver();
				if (flag2)
				{
					return false;
				}
			}
			bool flag3 = this.Service != null;
			if (flag3)
			{
				this.Service.Dispose();
			}
			bool flag4 = this.ServiceHandle != IntPtr.Zero;
			if (flag4)
			{
				bool flag5 = !MService.Delete(this.ServiceHandle);
				if (flag5)
				{
					Log.Error(typeof(MServiceLoad), "Unable to delete the service using the native api.");
				}
				this.ServiceHandle = IntPtr.Zero;
			}
			this.IsCreated = false;
			return true;
		}
	}
}
