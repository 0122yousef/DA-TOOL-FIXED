using System;
using System.IO;
using Microsoft.Win32.SafeHandles;
using PornHub.Memory.Logic.Enums;
using PornHub.Memory.Logic.Interfaces;
using PornHub.Memory.Logic.Loaders;
using PornHub.Memory.Native;

namespace PornHub.Memory.Logic
{
	// Token: 0x0200002D RID: 45
	public class MDriver : MIDriver, IDisposable
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0001B08D File Offset: 0x0001928D
		public MIDriverIo IO { get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0001B095 File Offset: 0x00019295
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0001B09D File Offset: 0x0001929D
		internal MIDriverLoad Loader { get; private set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0001B0A6 File Offset: 0x000192A6
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0001B0AE File Offset: 0x000192AE
		public MDriverConfig Config { get; private set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0001B0B7 File Offset: 0x000192B7
		// (set) Token: 0x0600011C RID: 284 RVA: 0x0001B0BF File Offset: 0x000192BF
		public EventHandler Loaded { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0001B0C8 File Offset: 0x000192C8
		// (set) Token: 0x0600011E RID: 286 RVA: 0x0001B0D0 File Offset: 0x000192D0
		public EventHandler Unloaded { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0001B0D9 File Offset: 0x000192D9
		// (set) Token: 0x06000120 RID: 288 RVA: 0x0001B0E1 File Offset: 0x000192E1
		public EventHandler Disposed { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0001B0EA File Offset: 0x000192EA
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0001B0F2 File Offset: 0x000192F2
		public bool IsLoaded { get; private set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0001B0FB File Offset: 0x000192FB
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0001B103 File Offset: 0x00019303
		public bool IsDisposed { get; private set; }

		// Token: 0x06000125 RID: 293 RVA: 0x0001B10C File Offset: 0x0001930C
		protected MDriver()
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0001B118 File Offset: 0x00019318
		public MDriver(MDriverConfig Config, string LoaderPath = null)
		{
			this.Setup(Config, LoaderPath);
			switch (Config.IoMethod)
			{
			case MIoMethod.None:
				this.IO = null;
				break;
			case MIoMethod.IoControl:
				this.IO = new MDriverIo(this);
				break;
			case MIoMethod.SharedMemory:
				this.IO = new MDriverIoShared(this);
				break;
			default:
				throw new ArgumentException("Invalid IoMethod specified", "IoMethod");
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0001B18C File Offset: 0x0001938C
		public void Setup(MDriverConfig Config, string LoaderPath = null)
		{
			bool flag = Config == null;
			if (flag)
			{
				throw new ArgumentNullException("Config");
			}
			this.Config = Config;
			bool flag2 = string.IsNullOrEmpty(Config.ServiceName);
			if (flag2)
			{
				throw new Exception("Config->ServiceName is null or empty");
			}
			bool flag3 = Config.IoMethod == MIoMethod.IoControl;
			if (flag3)
			{
				bool flag4 = string.IsNullOrEmpty(Config.SymbolicLink);
				if (flag4)
				{
					throw new Exception("Config->SymbolicLink is null or empty");
				}
			}
			bool flag5 = !string.IsNullOrEmpty(LoaderPath);
			if (flag5)
			{
				this.SetLoaderPath(LoaderPath);
			}
			MDriverLoad loadMethod = this.Config.LoadMethod;
			MDriverLoad mdriverLoad = loadMethod;
			if (mdriverLoad != MDriverLoad.Normal)
			{
				throw new ArgumentException("Invalid LoadMethod specified", "LoadMethod");
			}
			this.Loader = new MServiceLoad();
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0001B24C File Offset: 0x0001944C
		public void SetLoaderPath(string Path)
		{
			bool flag = string.IsNullOrEmpty(Path);
			if (flag)
			{
				throw new ArgumentNullException("Path");
			}
			MDriverLoad loadMethod = this.Config.LoadMethod;
			MDriverLoad mdriverLoad = loadMethod;
			if (mdriverLoad != MDriverLoad.Normal)
			{
				throw new ArgumentException("Invalid LoadMethod specified", "LoadMethod");
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0001B298 File Offset: 0x00019498
		public bool Load()
		{
			bool flag = !this.Loader.CreateDriver(this);
			bool result;
			if (flag)
			{
				Log.Error(typeof(MDriver), "Failed to create the driver at Load().");
				result = false;
			}
			else
			{
				bool flag2 = !MDriver.CanConnectTo(this.Config.SymbolicLink, MIoMethod.IoControl);
				if (flag2)
				{
					bool flag3 = !this.Loader.LoadDriver();
					if (flag3)
					{
						Log.Error(typeof(MDriver), "Failed to load the driver at Load().");
						return false;
					}
				}
				else
				{
					Log.Warning(typeof(MDriver), "Warning, driver already exist at Load().");
				}
				this.IsLoaded = true;
				bool isConnected = this.IO.IsConnected;
				if (isConnected)
				{
					this.IO.Disconnect();
				}
				this.IO.Connect();
				bool flag4 = !this.IO.IsConnected;
				if (flag4)
				{
					Log.Error(typeof(MDriver), "Failed to open the symbolic file.");
				}
				bool flag5 = this.Loaded != null;
				if (flag5)
				{
					try
					{
						this.Loaded(this, EventArgs.Empty);
					}
					catch (Exception)
					{
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0001B3D8 File Offset: 0x000195D8
		public bool Unload()
		{
			bool isConnected = this.IO.IsConnected;
			if (isConnected)
			{
				this.IO.Disconnect();
			}
			bool flag = !this.Loader.StopDriver();
			bool result;
			if (flag)
			{
				Log.Error(typeof(MDriver), "Failed to unload the driver at Unload().");
				result = false;
			}
			else
			{
				bool flag2 = !this.Loader.DeleteDriver();
				if (flag2)
				{
					Log.Error(typeof(MDriver), "Failed to delete the driver at Unload().");
					result = false;
				}
				else
				{
					this.IsLoaded = false;
					bool flag3 = this.Unloaded != null;
					if (flag3)
					{
						try
						{
							this.Unloaded(this, EventArgs.Empty);
						}
						catch (Exception)
						{
						}
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0001B4A4 File Offset: 0x000196A4
		public void Dispose()
		{
			bool isDisposed = this.IsDisposed;
			if (!isDisposed)
			{
				this.IsDisposed = true;
				try
				{
					bool flag = !this.Unload();
					if (flag)
					{
						Log.Error(typeof(MDriver), "Failed to unload the driver at Dispose().");
					}
				}
				catch (Exception ex)
				{
					Log.Error(typeof(MDriver), ex.GetType().Name + ", " + ex.Message);
				}
				MIDriverIo io = this.IO;
				if (io != null)
				{
					io.Dispose();
				}
				bool flag2 = this.Disposed != null;
				if (flag2)
				{
					try
					{
						this.Disposed(this, EventArgs.Empty);
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0001B57C File Offset: 0x0001977C
		public static bool CanConnectTo(string SymbolicName, MIoMethod IoMethod = MIoMethod.IoControl)
		{
			bool result;
			if (IoMethod != MIoMethod.IoControl)
			{
				if (IoMethod != MIoMethod.SharedMemory)
				{
					throw new ArgumentException();
				}
				result = false;
			}
			else
			{
				SafeFileHandle safeFileHandle = WinApi.CreateFile(SymbolicName, FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, 0U, IntPtr.Zero);
				bool flag = safeFileHandle != null && !safeFileHandle.IsInvalid;
				bool flag2 = safeFileHandle != null;
				if (flag2)
				{
					safeFileHandle.Close();
				}
				result = flag;
			}
			return result;
		}
	}
}
