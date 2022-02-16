using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;
using PornHub.Memory.Logic;
using PornHub.Memory.Logic.Enums;
using PornHub.Memory.MEME.Structures;

namespace PornHub.Memory.MEME
{
	// Token: 0x0200002A RID: 42
	public class Requests
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00019C05 File Offset: 0x00017E05
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00019C0D File Offset: 0x00017E0D
		internal MDriver Driver { get; private set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00019C16 File Offset: 0x00017E16
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00019C1E File Offset: 0x00017E1E
		public ulong LastProcessId { get; private set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00019C27 File Offset: 0x00017E27
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00019C2F File Offset: 0x00017E2F
		public string LastProcessName { get; private set; }

		// Token: 0x060000F0 RID: 240 RVA: 0x00019C38 File Offset: 0x00017E38
		public Requests(string Game, Requests.IOCodes Codes)
		{
			this.WriteCtlCode_Protection = Codes.WriteCtlCode_Protection;
			this.WriteCtlCode = Codes.WriteCtlCode;
			this.ReadCtlCode = Codes.ReadCtlCode;
			this.GetBaseCtlCode = Codes.GetBaseCtlCode;
			this.GetUPBaseCtlCode = Codes.GetUPBaseCtlCode;
			this.GetGABaseCtlCode = Codes.GetGABaseCtlCode;
			this.SRVName = Codes.SRVName;
			this.LoadMemory(Game);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00019D08 File Offset: 0x00017F08
		private void SetDriver(MDriver Driver)
		{
			bool flag = Driver == null;
			if (flag)
			{
				throw new ArgumentNullException("Driver", "Driver is null");
			}
			this.Driver = Driver;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00019D37 File Offset: 0x00017F37
		private void SetProcId(ulong ProcId)
		{
			this.LastProcessId = ProcId;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00019D42 File Offset: 0x00017F42
		private void SetProcName(string game)
		{
			this.LastProcessName = game;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00019D50 File Offset: 0x00017F50
		public static bool IsValidPtr(ulong Address)
		{
			return Address != 0UL && Address > 1048576UL && Address < 36028797018963967UL;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00019D80 File Offset: 0x00017F80
		private byte[] Read(ulong Address, int Size)
		{
			bool flag = !this.Driver.IO.IsConnected;
			if (flag)
			{
				throw new Exception("Driver is disconnected.");
			}
			bool flag2 = !Requests.IsValidPtr(Address);
			byte[] result;
			if (flag2)
			{
				byte[] array = new byte[Size];
				result = array;
			}
			else
			{
				KernelReadRequest ioData = default(KernelReadRequest);
				uint ioDataSize = (uint)Marshal.SizeOf<KernelReadRequest>();
				byte[] array2 = new byte[Size];
				GCHandle gchandle = GCHandle.Alloc(array2, GCHandleType.Pinned);
				IntPtr intPtr = gchandle.AddrOfPinnedObject();
				bool flag3 = !gchandle.IsAllocated;
				if (flag3)
				{
					throw new InsufficientMemoryException("Couldn't allocate memory for the buffer, at Read(ProcessId, Address, Size).");
				}
				ioData.ProcessId = this.LastProcessId;
				ioData.Size = Size;
				ioData.Response = (ulong)intPtr.ToInt64();
				ioData.Address = Address;
				bool flag4 = this.Driver.IO.TryIoControl<KernelReadRequest>(this.ReadCtlCode, ioData, (int)ioDataSize);
				bool flag5 = flag4;
				if (flag5)
				{
					array2 = (byte[])gchandle.Target;
				}
				gchandle.Free();
				bool flag6 = !flag4;
				if (flag6)
				{
					array2 = null;
				}
				result = array2;
			}
			return result;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00019E90 File Offset: 0x00018090
		private void Write(ulong Address, byte[] Value, bool ProtectionBypass = false)
		{
			bool flag = !this.Driver.IO.IsConnected;
			if (flag)
			{
				throw new Exception("Driver is disconnected.");
			}
			bool flag2 = !Requests.IsValidPtr(Address);
			if (!flag2)
			{
				int size = Value.Length;
				KernelWriteRequest ioData = default(KernelWriteRequest);
				uint ioDataSize = (uint)Marshal.SizeOf<KernelWriteRequest>();
				GCHandle gchandle = GCHandle.Alloc(Value, GCHandleType.Pinned);
				bool flag3 = !gchandle.IsAllocated;
				if (flag3)
				{
					throw new InsufficientMemoryException("Couldn't allocate memory for the buffer, at Write<T>(Address, Value, UseBaseAddress).");
				}
				ioData.ProcessId = this.LastProcessId;
				ioData.Size = size;
				ioData.Value = (ulong)gchandle.AddrOfPinnedObject().ToInt64();
				ioData.Address = Address;
				bool flag4;
				if (ProtectionBypass)
				{
					flag4 = this.Driver.IO.TryIoControl<KernelWriteRequest>(this.WriteCtlCode_Protection, ioData, (int)ioDataSize);
				}
				else
				{
					flag4 = this.Driver.IO.TryIoControl<KernelWriteRequest>(this.WriteCtlCode, ioData, (int)ioDataSize);
				}
				gchandle.Free();
				bool flag5 = !flag4;
				if (flag5)
				{
					throw new Exception("Failed to write the given structure to the specified Address, at Write<T>(Address, Value, UseBaseAddress).");
				}
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00019FA4 File Offset: 0x000181A4
		public ulong GetGameBase()
		{
			bool flag = !this.Driver.IO.IsConnected;
			if (flag)
			{
				throw new Exception("Driver is disconnected.");
			}
			Process[] processesByName = Process.GetProcessesByName(this.LastProcessName);
			bool flag2 = processesByName.Length == 0;
			if (flag2)
			{
				throw new Exception("Game Crashed or Closed?!");
			}
			KernelReadRequest ioData = default(KernelReadRequest);
			uint ioDataSize = (uint)Marshal.SizeOf<KernelReadRequest>();
			byte[] value = new byte[8];
			GCHandle gchandle = GCHandle.Alloc(value, GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			ioData.ProcessId = this.LastProcessId;
			ioData.Response = (ulong)intPtr.ToInt64();
			ioData.Size = 8;
			bool flag3 = this.Driver.IO.TryIoControl<KernelReadRequest>(this.GetBaseCtlCode, ioData, (int)ioDataSize);
			bool flag4 = flag3;
			ulong result;
			if (flag4)
			{
				value = (byte[])gchandle.Target;
				result = (ulong)BitConverter.ToInt64(value, 0);
			}
			else
			{
				result = 0UL;
			}
			return result;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0001A08C File Offset: 0x0001828C
		public ulong GetModuleBase(Requests.ModuleName modulename)
		{
			Process[] processesByName = Process.GetProcessesByName(this.LastProcessName);
			bool flag = processesByName.Length == 0;
			if (flag)
			{
				throw new Exception("Game Crashed or Closed?!");
			}
			bool flag2 = !this.Driver.IO.IsConnected;
			if (flag2)
			{
				throw new Exception("Driver is disconnected.");
			}
			bool flag3 = false;
			KernelReadRequest ioData = default(KernelReadRequest);
			uint ioDataSize = (uint)Marshal.SizeOf<KernelReadRequest>();
			byte[] value = new byte[8];
			GCHandle gchandle = GCHandle.Alloc(value, GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			ioData.ProcessId = this.LastProcessId;
			ioData.Response = (ulong)intPtr.ToInt64();
			ioData.Size = 8;
			bool flag4 = modulename == Requests.ModuleName.UnityPlayer;
			if (flag4)
			{
				flag3 = this.Driver.IO.TryIoControl<KernelReadRequest>(this.GetUPBaseCtlCode, ioData, (int)ioDataSize);
			}
			else
			{
				bool flag5 = modulename == Requests.ModuleName.GameAssembly;
				if (flag5)
				{
					flag3 = this.Driver.IO.TryIoControl<KernelReadRequest>(this.GetGABaseCtlCode, ioData, (int)ioDataSize);
				}
			}
			bool flag6 = flag3;
			ulong result;
			if (flag6)
			{
				value = (byte[])gchandle.Target;
				result = (ulong)BitConverter.ToInt64(value, 0);
			}
			else
			{
				result = 0UL;
			}
			return result;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0001A1A7 File Offset: 0x000183A7
		public void Unload()
		{
			this.Driver.IO.Driver.Unload();
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0001A1C0 File Offset: 0x000183C0
		private void LoadMemory(string Game)
		{
			Debug.WriteLine("[*] Loading...");
			FileInfo driverFile = new FileInfo("C:\\Windows\\System32\\drivers\\wmiacpi.sys");
			Debug.WriteLine("[*] SystemFile Found.");
			MDriver mdriver = new MDriver(new MDriverConfig
			{
				ServiceName = this.SRVName,
				SymbolicLink = "\\\\.\\\\" + this.SRVName,
				DriverFile = driverFile,
				LoadMethod = MDriverLoad.Normal
			}, null);
			bool flag = MDriver.CanConnectTo(mdriver.Config.SymbolicLink, mdriver.Config.IoMethod);
			if (flag)
			{
				Debug.WriteLine("[*] The driver symbolic file is already created.");
				Debug.WriteLine("[*] Please make sure you are not loading the driver twice!");
			}
			try
			{
				bool flag2 = mdriver.Load();
				if (flag2)
				{
					Debug.WriteLine("[*] Driver has been loaded.");
					string str = "[*] Driver->Handle       : 0x";
					SafeFileHandle handle = mdriver.IO.Handle;
					Debug.WriteLine(str + ((handle != null) ? handle.DangerousGetHandle().ToString("X").PadLeft(8, '0') : null));
					Debug.WriteLine("[*] Driver->IsLoaded     : " + mdriver.IsLoaded.ToString());
					Debug.WriteLine("[*] Driver->IsConnected  : " + mdriver.IO.IsConnected.ToString());
					Debug.WriteLine("[*] Driver->IsDisposed   : " + mdriver.IsDisposed.ToString());
					bool isConnected = mdriver.IO.IsConnected;
					if (isConnected)
					{
						this.SetDriver(mdriver);
						Requests.ViewMatrix.MEMAPI = this;
						this.SetProcId((ulong)((long)Process.GetProcessesByName(Game)[0].Id));
						Debug.WriteLine("ProcID : " + this.LastProcessId.ToString());
						this.SetProcName(Game);
						this.GameBase = this.GetGameBase();
						Debug.WriteLine("Game Address : 0x" + this.GameBase.ToString("X"));
						bool flag3 = this.GameBase > 100UL && this.LastProcessId > 0UL;
						if (flag3)
						{
							this.IsAttached = true;
							Debug.WriteLine("[*] Game->IsAttached   : " + this.IsAttached.ToString());
						}
					}
					else
					{
						Debug.WriteLine("[*] Failed to initialize the IO communication.");
					}
				}
				else
				{
					Debug.WriteLine("[*] Failed to load the driver.");
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine("[*] " + ex.Message + ".");
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0001A450 File Offset: 0x00018650
		public byte[] ReadBytes(ulong Address, int Length = 4)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			byte[] result;
			if (flag)
			{
				byte[] array = new byte[Length];
				array = this.Read(Address, Length);
				result = array;
			}
			else
			{
				byte[] array2 = new byte[Length];
				result = array2;
			}
			return result;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0001A498 File Offset: 0x00018698
		public byte Readbyte(ulong Address)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			byte result;
			if (flag)
			{
				byte[] array = new byte[1];
				array = this.ReadBytes(Address, 1);
				bool flag2 = array != null;
				if (flag2)
				{
					result = array[0];
				}
				else
				{
					result = 0;
				}
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0001A4E8 File Offset: 0x000186E8
		public short ReadInt16(ulong Address)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			short result;
			if (flag)
			{
				byte[] array = new byte[2];
				array = this.ReadBytes(Address, 2);
				bool flag2 = array != null;
				if (flag2)
				{
					result = BitConverter.ToInt16(array, 0);
				}
				else
				{
					result = 0;
				}
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0001A53C File Offset: 0x0001873C
		public int ReadInt32(ulong Address)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			int result;
			if (flag)
			{
				byte[] array = new byte[4];
				array = this.ReadBytes(Address, 4);
				bool flag2 = array != null;
				if (flag2)
				{
					result = BitConverter.ToInt32(array, 0);
				}
				else
				{
					result = 0;
				}
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0001A590 File Offset: 0x00018790
		public ulong ReadInt64(ulong Address)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			ulong result;
			if (flag)
			{
				byte[] array = new byte[8];
				array = this.ReadBytes(Address, 8);
				bool flag2 = array != null;
				if (flag2)
				{
					result = (ulong)BitConverter.ToInt64(array, 0);
				}
				else
				{
					result = 0UL;
				}
			}
			else
			{
				result = 0UL;
			}
			return result;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0001A5E4 File Offset: 0x000187E4
		public float ReadFloat(ulong Address)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			float result;
			if (flag)
			{
				byte[] array = new byte[4];
				array = this.ReadBytes(Address, 4);
				bool flag2 = array != null;
				if (flag2)
				{
					result = BitConverter.ToSingle(array, 0);
				}
				else
				{
					result = 0f;
				}
			}
			else
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0001A640 File Offset: 0x00018840
		public double ReadDouble(ulong Address)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			double result;
			if (flag)
			{
				byte[] array = new byte[8];
				array = this.ReadBytes(Address, 8);
				bool flag2 = array != null;
				if (flag2)
				{
					result = BitConverter.ToDouble(array, 0);
				}
				else
				{
					result = 0.0;
				}
			}
			else
			{
				result = 0.0;
			}
			return result;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0001A6A4 File Offset: 0x000188A4
		public ulong GetPointer(params ulong[] args)
		{
			bool flag = Requests.IsValidPtr(args[0]) && this.IsAttached;
			ulong result;
			if (flag)
			{
				ulong num = 0UL;
				bool flag2 = args.Length <= 1;
				if (flag2)
				{
					result = 0UL;
				}
				else
				{
					for (int i = 0; i <= args.Count<ulong>() - 1; i++)
					{
						bool flag3 = i == 0;
						if (flag3)
						{
							num = this.ReadInt64(args[i]);
						}
						else
						{
							bool flag4 = i != args.Count<ulong>() - 1;
							if (flag4)
							{
								bool flag5 = num == 0UL;
								if (flag5)
								{
									return 0UL;
								}
								num = this.ReadInt64(num + args[i]);
							}
							else
							{
								num += args[i];
							}
						}
					}
					bool flag6 = Requests.IsValidPtr(num);
					if (flag6)
					{
						result = num;
					}
					else
					{
						result = 0UL;
					}
				}
			}
			else
			{
				result = 0UL;
			}
			return result;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0001A784 File Offset: 0x00018984
		public string ReadString(ulong Address, int Length = 124, bool Unicode = false)
		{
			if (Unicode)
			{
				Length *= 2;
			}
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			string result;
			if (flag)
			{
				bool flag2 = Length > 0;
				if (flag2)
				{
					byte[] array = new byte[Length];
					array = this.ReadBytes(Address, Length);
					bool flag3 = array != null;
					if (flag3)
					{
						bool flag4 = !Unicode;
						if (flag4)
						{
							ASCIIEncoding asciiencoding = new ASCIIEncoding();
							for (int i = 0; i <= array.Length - 1; i++)
							{
								bool flag5 = array[i] == 0;
								if (flag5)
								{
									Array.Resize<byte>(ref array, i);
									return asciiencoding.GetString(array);
								}
							}
							result = asciiencoding.GetString(array);
						}
						else
						{
							UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
							result = unicodeEncoding.GetString(array);
						}
					}
					else
					{
						result = "";
					}
				}
				else
				{
					result = "";
				}
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0001A874 File Offset: 0x00018A74
		public Requests.Vector2.Vector2f ReadVector2f(ulong Address)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			Requests.Vector2.Vector2f result;
			if (flag)
			{
				byte[] array = this.ReadBytes(Address, 8);
				float[] array2 = new float[array.Length / 4];
				Buffer.BlockCopy(array, 0, array2, 0, array.Length);
				result = new Requests.Vector2.Vector2f(array2[0], array2[1]);
			}
			else
			{
				result = new Requests.Vector2.Vector2f(0f);
			}
			return result;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0001A8D8 File Offset: 0x00018AD8
		public void WriteVector2f(ulong Address, Requests.Vector2.Vector2f value)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			if (flag)
			{
				float[] array = new float[]
				{
					value.x,
					value.y
				};
				byte[] array2 = new byte[array.Length * 4];
				Buffer.BlockCopy(array, 0, array2, 0, array2.Length);
				this.WriteBytes(Address, array2, false);
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0001A938 File Offset: 0x00018B38
		public Requests.Vector3.Vector3f ReadVector3f(ulong Address)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			Requests.Vector3.Vector3f result;
			if (flag)
			{
				byte[] array = this.ReadBytes(Address, 12);
				float[] array2 = new float[array.Length / 4];
				Buffer.BlockCopy(array, 0, array2, 0, array.Length);
				result = new Requests.Vector3.Vector3f(array2[0], array2[1], array2[2]);
			}
			else
			{
				result = new Requests.Vector3.Vector3f(0f);
			}
			return result;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0001A9A0 File Offset: 0x00018BA0
		public void WriteVector3f(ulong Address, Requests.Vector3.Vector3f value)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			if (flag)
			{
				float[] array = new float[]
				{
					value.x,
					value.y,
					value.z
				};
				byte[] array2 = new byte[array.Length * 4];
				Buffer.BlockCopy(array, 0, array2, 0, array2.Length);
				this.WriteBytes(Address, array2, false);
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0001AA0C File Offset: 0x00018C0C
		public Requests.Vector4.Vector4f ReadVector4f(ulong Address)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			Requests.Vector4.Vector4f result;
			if (flag)
			{
				byte[] array = this.ReadBytes(Address, 16);
				float[] array2 = new float[array.Length / 4];
				Buffer.BlockCopy(array, 0, array2, 0, array.Length);
				result = new Requests.Vector4.Vector4f(array2[0], array2[1], array2[2], array2[3]);
			}
			else
			{
				result = new Requests.Vector4.Vector4f(0f);
			}
			return result;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0001AA78 File Offset: 0x00018C78
		public void WriteVector4f(ulong Address, Requests.Vector4.Vector4f value)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			if (flag)
			{
				float[] array = new float[]
				{
					value.x,
					value.y,
					value.z,
					value.w
				};
				byte[] array2 = new byte[array.Length * 4];
				Buffer.BlockCopy(array, 0, array2, 0, array2.Length);
				this.WriteBytes(Address, array2, false);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0001AAEA File Offset: 0x00018CEA
		public void WriteBytes(ulong Address, byte[] buffer, bool ProtectionBypass = false)
		{
			this.Write(Address, buffer, ProtectionBypass);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0001AAF8 File Offset: 0x00018CF8
		public void WriteByte(ulong Address, byte Value, bool ProtectionBypass = false)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			if (flag)
			{
				byte[] buffer = new byte[1];
				buffer = BitConverter.GetBytes((short)Value);
				this.WriteBytes(Address, buffer, ProtectionBypass);
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0001AB38 File Offset: 0x00018D38
		public void WriteInt16(ulong Address, short Value, bool ProtectionBypass = false)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			if (flag)
			{
				byte[] buffer = new byte[2];
				buffer = BitConverter.GetBytes(Value);
				this.WriteBytes(Address, buffer, ProtectionBypass);
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0001AB78 File Offset: 0x00018D78
		public void WriteInt32(ulong Address, int Value, bool ProtectionBypass = false)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			if (flag)
			{
				byte[] buffer = new byte[4];
				buffer = BitConverter.GetBytes(Value);
				this.WriteBytes(Address, buffer, ProtectionBypass);
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0001ABB8 File Offset: 0x00018DB8
		public void WriteInt64(ulong Address, long Value, bool ProtectionBypass = false)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			if (flag)
			{
				byte[] buffer = new byte[8];
				buffer = BitConverter.GetBytes(Value);
				this.WriteBytes(Address, buffer, ProtectionBypass);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0001ABF8 File Offset: 0x00018DF8
		public void WriteFloat(ulong Address, float Value, bool ProtectionBypass = false)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			if (flag)
			{
				byte[] buffer = new byte[4];
				buffer = BitConverter.GetBytes(Value);
				this.WriteBytes(Address, buffer, ProtectionBypass);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0001AC38 File Offset: 0x00018E38
		public void WriteDouble(ulong Address, double Value, bool ProtectionBypass = false)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			if (flag)
			{
				byte[] buffer = new byte[4];
				buffer = BitConverter.GetBytes(Value);
				this.WriteBytes(Address, buffer, ProtectionBypass);
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0001AC78 File Offset: 0x00018E78
		public void WriteString(ulong Address, string text, bool Unicode = false, bool ProtectionBypass = false)
		{
			bool flag = Requests.IsValidPtr(Address) && this.IsAttached;
			if (flag)
			{
				if (Unicode)
				{
					UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
					this.WriteBytes(Address, unicodeEncoding.GetBytes(text), ProtectionBypass);
					this.WriteByte(Address + (ulong)((long)(text.Length * 2)), 0, ProtectionBypass);
				}
				else
				{
					ASCIIEncoding asciiencoding = new ASCIIEncoding();
					this.WriteBytes(Address, asciiencoding.GetBytes(text), ProtectionBypass);
					this.WriteByte(Address + (ulong)((long)text.Length), 0, ProtectionBypass);
				}
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0001ACFE File Offset: 0x00018EFE
		public void OP_True(ulong address, bool ProtectionBypass = false)
		{
			this.WriteBytes(address, new byte[]
			{
				85,
				72,
				139,
				236,
				184,
				1,
				0,
				0,
				0,
				93,
				195
			}, ProtectionBypass);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0001AD1C File Offset: 0x00018F1C
		public void OP_False(ulong address, bool ProtectionBypass = false)
		{
			this.WriteBytes(address, new byte[]
			{
				85,
				72,
				139,
				236,
				184,
				0,
				0,
				0,
				0,
				93,
				195
			}, ProtectionBypass);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0001AD3C File Offset: 0x00018F3C
		public bool MemoryCompare(byte[] Data, int DataOffset, byte[] Pattern, string WildCards)
		{
			for (int i = 0; i <= Pattern.Length - 1; i++)
			{
				bool flag = WildCards[i].ToString() == "x" && Data[DataOffset] != Pattern[i];
				if (flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0001ADA0 File Offset: 0x00018FA0
		public ulong PatternScan(ulong StartAddress, long Size, byte[] Pattern, string WildCards, int ScanAlignment = 1)
		{
			bool flag = WildCards.Length != Pattern.Length;
			ulong result;
			if (flag)
			{
				Debug.WriteLine("Mask is wrong size!");
				result = 0UL;
			}
			else
			{
				bool flag2 = Requests.IsValidPtr(StartAddress) && this.IsAttached;
				if (flag2)
				{
					int num = 8;
					bool flag3 = Size > (long)(int.MaxValue / num);
					if (flag3)
					{
						int num2 = (int)(Size / (long)(int.MaxValue / num));
						ulong num3 = (ulong)((long)(int.MaxValue / num) + 1L);
						Debug.WriteLine("Total Blocks : " + num2.ToString());
						Debug.WriteLine("Size Of Each Block : " + num3.ToString());
						for (int i = 0; i <= num2; i++)
						{
							Debug.WriteLine("Starting Block: " + i.ToString());
							Debug.WriteLine("Start Address Of Block : " + (StartAddress + num3 * (ulong)((long)i)).ToString("X"));
							byte[] array = new byte[num3 + (ulong)((long)Pattern.Length)];
							Debug.WriteLine("buffer size: " + array.Length.ToString());
							array = this.ReadBytes(StartAddress + num3 * (ulong)((long)i), (int)(num3 + (ulong)((long)Pattern.Length)));
							Debug.WriteLine("Finished Reading Buffer!");
							bool flag4 = array != null;
							if (!flag4)
							{
								return 0UL;
							}
							for (int j = 0; j <= (int)num3; j++)
							{
								for (int k = 0; k <= Pattern.Length - 1; k++)
								{
									bool flag5 = WildCards[k].ToString() == "x" && array[j + k] != Pattern[k];
									if (flag5)
									{
										break;
									}
									bool flag6 = k == Pattern.Length - 1;
									if (flag6)
									{
										return StartAddress + num3 * (ulong)((long)i) + (ulong)((long)j);
									}
								}
								j += ScanAlignment - 1;
							}
						}
						result = 0UL;
					}
					else
					{
						byte[] array2 = new byte[Size];
						array2 = this.ReadBytes(StartAddress, (int)Size);
						bool flag7 = array2 != null;
						if (flag7)
						{
							int num4 = 0;
							while ((long)num4 <= Size)
							{
								for (int l = 0; l <= Pattern.Length - 1; l++)
								{
									bool flag8 = WildCards[l].ToString() == "x" && array2[num4 + l] != Pattern[l];
									if (flag8)
									{
										break;
									}
									bool flag9 = l == Pattern.Length - 1;
									if (flag9)
									{
										return StartAddress + (ulong)((long)num4);
									}
								}
								num4++;
							}
							result = 0UL;
						}
						else
						{
							result = 0UL;
						}
					}
				}
				else
				{
					result = 0UL;
				}
			}
			return result;
		}

		// Token: 0x0400048D RID: 1165
		private uint WriteCtlCode_Protection = 2247680U;

		// Token: 0x0400048E RID: 1166
		private uint WriteCtlCode = 2247684U;

		// Token: 0x0400048F RID: 1167
		private uint ReadCtlCode = 2247688U;

		// Token: 0x04000490 RID: 1168
		private uint GetBaseCtlCode = 2247692U;

		// Token: 0x04000491 RID: 1169
		private uint GetUPBaseCtlCode = 2247696U;

		// Token: 0x04000492 RID: 1170
		private uint GetGABaseCtlCode = 2247700U;

		// Token: 0x04000493 RID: 1171
		private string SRVName = "DriverSRVName";

		// Token: 0x04000494 RID: 1172
		public ulong GameBase = 0UL;

		// Token: 0x04000495 RID: 1173
		public bool IsAttached = false;

		// Token: 0x02000044 RID: 68
		public class IOCodes
		{
			// Token: 0x04000556 RID: 1366
			public uint WriteCtlCode_Protection = 2247680U;

			// Token: 0x04000557 RID: 1367
			public uint WriteCtlCode = 2247684U;

			// Token: 0x04000558 RID: 1368
			public uint ReadCtlCode = 2247688U;

			// Token: 0x04000559 RID: 1369
			public uint GetBaseCtlCode = 2247692U;

			// Token: 0x0400055A RID: 1370
			public uint GetUPBaseCtlCode = 2247696U;

			// Token: 0x0400055B RID: 1371
			public uint GetGABaseCtlCode = 2247700U;

			// Token: 0x0400055C RID: 1372
			public string SRVName = "DriverSRVName";
		}

		// Token: 0x02000045 RID: 69
		public enum ModuleName
		{
			// Token: 0x0400055E RID: 1374
			UnityPlayer,
			// Token: 0x0400055F RID: 1375
			GameAssembly
		}

		// Token: 0x02000046 RID: 70
		public class Vector2
		{
			// Token: 0x02000062 RID: 98
			public struct Vector2f
			{
				// Token: 0x17000052 RID: 82
				// (get) Token: 0x060001F0 RID: 496 RVA: 0x0001E3F0 File Offset: 0x0001C5F0
				// (set) Token: 0x060001F1 RID: 497 RVA: 0x0001E408 File Offset: 0x0001C608
				public float X
				{
					get
					{
						return this.x;
					}
					set
					{
						this.x = value;
					}
				}

				// Token: 0x17000053 RID: 83
				// (get) Token: 0x060001F2 RID: 498 RVA: 0x0001E414 File Offset: 0x0001C614
				// (set) Token: 0x060001F3 RID: 499 RVA: 0x0001E42C File Offset: 0x0001C62C
				public float Y
				{
					get
					{
						return this.y;
					}
					set
					{
						this.y = value;
					}
				}

				// Token: 0x17000054 RID: 84
				// (get) Token: 0x060001F4 RID: 500 RVA: 0x0001E438 File Offset: 0x0001C638
				public static Requests.Vector2.Vector2f One
				{
					get
					{
						return new Requests.Vector2.Vector2f(1f);
					}
				}

				// Token: 0x17000055 RID: 85
				// (get) Token: 0x060001F5 RID: 501 RVA: 0x0001E454 File Offset: 0x0001C654
				public static Requests.Vector2.Vector2f Zero
				{
					get
					{
						return new Requests.Vector2.Vector2f(0f);
					}
				}

				// Token: 0x17000056 RID: 86
				// (get) Token: 0x060001F6 RID: 502 RVA: 0x0001E470 File Offset: 0x0001C670
				public static Requests.Vector2.Vector2f MinusOne
				{
					get
					{
						return new Requests.Vector2.Vector2f(-1f);
					}
				}

				// Token: 0x17000057 RID: 87
				[IndexerName("Component")]
				public unsafe float this[int index]
				{
					get
					{
						bool flag = (index | 3) != 3;
						if (flag)
						{
							throw new ArgumentOutOfRangeException("index");
						}
						fixed (float* ptr = &this.x)
						{
							float* ptr2 = ptr;
							return ptr2[index];
						}
					}
					set
					{
						bool flag = (index | 3) != 3;
						if (flag)
						{
							throw new ArgumentOutOfRangeException("index");
						}
						fixed (float* ptr = &this.x)
						{
							float* ptr2 = ptr;
							ptr2[index] = value;
						}
					}
				}

				// Token: 0x060001F9 RID: 505 RVA: 0x0001E505 File Offset: 0x0001C705
				public Vector2f(float x, float y)
				{
					this.x = x;
					this.y = y;
				}

				// Token: 0x060001FA RID: 506 RVA: 0x0001E516 File Offset: 0x0001C716
				public Vector2f(float f)
				{
					this.x = f;
					this.y = f;
				}

				// Token: 0x060001FB RID: 507 RVA: 0x0001E528 File Offset: 0x0001C728
				public static float Dot(Requests.Vector2.Vector2f left, Requests.Vector2.Vector2f right)
				{
					return left.x * right.x + left.y * right.y;
				}

				// Token: 0x060001FC RID: 508 RVA: 0x0001E558 File Offset: 0x0001C758
				public static float Distance(Requests.Vector2.Vector2f value1, Requests.Vector2.Vector2f value2)
				{
					float num = value1.x - value2.x;
					float num2 = value1.y - value2.y;
					return (float)Math.Sqrt((double)(num * num + num2 * num2));
				}

				// Token: 0x060001FD RID: 509 RVA: 0x0001E594 File Offset: 0x0001C794
				public unsafe static Requests.Vector2.Vector2f operator &(Requests.Vector2.Vector2f v1, Requests.Vector2.Vector2f v2)
				{
					Requests.Vector2.Vector2f result = default(Requests.Vector2.Vector2f);
					int* ptr = (int*)(&v1);
					int* ptr2 = (int*)(&v2);
					int* ptr3 = (int*)(&result);
					*(ptr3++) = (*(ptr++) & *(ptr2++));
					*(ptr3++) = (*(ptr++) & *(ptr2++));
					*(ptr3++) = (*(ptr++) & *(ptr2++));
					*ptr3 = (*ptr & *ptr2);
					return result;
				}

				// Token: 0x060001FE RID: 510 RVA: 0x0001E600 File Offset: 0x0001C800
				public unsafe static Requests.Vector2.Vector2f operator |(Requests.Vector2.Vector2f v1, Requests.Vector2.Vector2f v2)
				{
					Requests.Vector2.Vector2f result = default(Requests.Vector2.Vector2f);
					int* ptr = (int*)(&v1);
					int* ptr2 = (int*)(&v2);
					int* ptr3 = (int*)(&result);
					*(ptr3++) = (*(ptr++) | *(ptr2++));
					*(ptr3++) = (*(ptr++) | *(ptr2++));
					*(ptr3++) = (*(ptr++) | *(ptr2++));
					*ptr3 = (*ptr | *ptr2);
					return result;
				}

				// Token: 0x060001FF RID: 511 RVA: 0x0001E66C File Offset: 0x0001C86C
				public unsafe static Requests.Vector2.Vector2f operator ^(Requests.Vector2.Vector2f v1, Requests.Vector2.Vector2f v2)
				{
					Requests.Vector2.Vector2f result = default(Requests.Vector2.Vector2f);
					int* ptr = (int*)(&v1);
					int* ptr2 = (int*)(&v2);
					int* ptr3 = (int*)(&result);
					*(ptr3++) = (*(ptr++) ^ *(ptr2++));
					*(ptr3++) = (*(ptr++) ^ *(ptr2++));
					*(ptr3++) = (*(ptr++) ^ *(ptr2++));
					*ptr3 = (*ptr ^ *ptr2);
					return result;
				}

				// Token: 0x06000200 RID: 512 RVA: 0x0001E6D8 File Offset: 0x0001C8D8
				public static Requests.Vector2.Vector2f operator +(Requests.Vector2.Vector2f v1, Requests.Vector2.Vector2f v2)
				{
					return new Requests.Vector2.Vector2f(v1.x + v2.x, v1.y + v2.y);
				}

				// Token: 0x06000201 RID: 513 RVA: 0x0001E70C File Offset: 0x0001C90C
				public static Requests.Vector2.Vector2f operator -(Requests.Vector2.Vector2f v1, Requests.Vector2.Vector2f v2)
				{
					return new Requests.Vector2.Vector2f(v1.x - v2.x, v1.y - v2.y);
				}

				// Token: 0x06000202 RID: 514 RVA: 0x0001E740 File Offset: 0x0001C940
				public static Requests.Vector2.Vector2f operator *(Requests.Vector2.Vector2f v1, Requests.Vector2.Vector2f v2)
				{
					return new Requests.Vector2.Vector2f(v1.x * v2.x, v1.y * v2.y);
				}

				// Token: 0x06000203 RID: 515 RVA: 0x0001E774 File Offset: 0x0001C974
				public static Requests.Vector2.Vector2f operator *(float scalar, Requests.Vector2.Vector2f v)
				{
					return new Requests.Vector2.Vector2f(scalar * v.x, scalar * v.y);
				}

				// Token: 0x06000204 RID: 516 RVA: 0x0001E79C File Offset: 0x0001C99C
				public static Requests.Vector2.Vector2f operator *(Requests.Vector2.Vector2f v, float scalar)
				{
					return new Requests.Vector2.Vector2f(scalar * v.x, scalar * v.y);
				}

				// Token: 0x06000205 RID: 517 RVA: 0x0001E7C4 File Offset: 0x0001C9C4
				public static Requests.Vector2.Vector2f operator /(Requests.Vector2.Vector2f v1, Requests.Vector2.Vector2f v2)
				{
					return new Requests.Vector2.Vector2f(v1.x / v2.x, v1.y / v2.y);
				}

				// Token: 0x06000206 RID: 518 RVA: 0x0001E7F8 File Offset: 0x0001C9F8
				public static bool operator ==(Requests.Vector2.Vector2f v1, Requests.Vector2.Vector2f v2)
				{
					return v1.x == v2.x && v1.y == v2.y;
				}

				// Token: 0x06000207 RID: 519 RVA: 0x0001E82C File Offset: 0x0001CA2C
				public static bool operator !=(Requests.Vector2.Vector2f v1, Requests.Vector2.Vector2f v2)
				{
					return v1.x != v2.x || v1.y != v2.y;
				}

				// Token: 0x06000208 RID: 520 RVA: 0x0001E860 File Offset: 0x0001CA60
				public override string ToString()
				{
					return string.Concat(new string[]
					{
						"<",
						this.x.ToString(),
						", ",
						this.y.ToString(),
						">"
					});
				}

				// Token: 0x04000577 RID: 1399
				internal float x;

				// Token: 0x04000578 RID: 1400
				internal float y;
			}
		}

		// Token: 0x02000047 RID: 71
		public class Vector3
		{
			// Token: 0x02000063 RID: 99
			public struct Vector3f
			{
				// Token: 0x17000058 RID: 88
				// (get) Token: 0x06000209 RID: 521 RVA: 0x0001E8B4 File Offset: 0x0001CAB4
				// (set) Token: 0x0600020A RID: 522 RVA: 0x0001E8CC File Offset: 0x0001CACC
				public float X
				{
					get
					{
						return this.x;
					}
					set
					{
						this.x = value;
					}
				}

				// Token: 0x17000059 RID: 89
				// (get) Token: 0x0600020B RID: 523 RVA: 0x0001E8D8 File Offset: 0x0001CAD8
				// (set) Token: 0x0600020C RID: 524 RVA: 0x0001E8F0 File Offset: 0x0001CAF0
				public float Y
				{
					get
					{
						return this.y;
					}
					set
					{
						this.y = value;
					}
				}

				// Token: 0x1700005A RID: 90
				// (get) Token: 0x0600020D RID: 525 RVA: 0x0001E8FC File Offset: 0x0001CAFC
				// (set) Token: 0x0600020E RID: 526 RVA: 0x0001E914 File Offset: 0x0001CB14
				public float Z
				{
					get
					{
						return this.z;
					}
					set
					{
						this.z = value;
					}
				}

				// Token: 0x1700005B RID: 91
				// (get) Token: 0x0600020F RID: 527 RVA: 0x0001E920 File Offset: 0x0001CB20
				public static Requests.Vector3.Vector3f One
				{
					get
					{
						return new Requests.Vector3.Vector3f(1f);
					}
				}

				// Token: 0x1700005C RID: 92
				// (get) Token: 0x06000210 RID: 528 RVA: 0x0001E93C File Offset: 0x0001CB3C
				public static Requests.Vector3.Vector3f Zero
				{
					get
					{
						return new Requests.Vector3.Vector3f(0f);
					}
				}

				// Token: 0x1700005D RID: 93
				// (get) Token: 0x06000211 RID: 529 RVA: 0x0001E958 File Offset: 0x0001CB58
				public static Requests.Vector3.Vector3f MinusOne
				{
					get
					{
						return new Requests.Vector3.Vector3f(-1f);
					}
				}

				// Token: 0x1700005E RID: 94
				[IndexerName("Component")]
				public unsafe float this[int index]
				{
					get
					{
						bool flag = (index | 3) != 3;
						if (flag)
						{
							throw new ArgumentOutOfRangeException("index");
						}
						fixed (float* ptr = &this.x)
						{
							float* ptr2 = ptr;
							return ptr2[index];
						}
					}
					set
					{
						bool flag = (index | 3) != 3;
						if (flag)
						{
							throw new ArgumentOutOfRangeException("index");
						}
						fixed (float* ptr = &this.x)
						{
							float* ptr2 = ptr;
							ptr2[index] = value;
						}
					}
				}

				// Token: 0x06000214 RID: 532 RVA: 0x0001E9ED File Offset: 0x0001CBED
				public Vector3f(float x, float y, float z)
				{
					this.x = x;
					this.y = y;
					this.z = z;
				}

				// Token: 0x06000215 RID: 533 RVA: 0x0001EA05 File Offset: 0x0001CC05
				public Vector3f(float f)
				{
					this.x = f;
					this.y = f;
					this.z = f;
				}

				// Token: 0x06000216 RID: 534 RVA: 0x0001EA20 File Offset: 0x0001CC20
				public static float Dot(Requests.Vector3.Vector3f left, Requests.Vector3.Vector3f right)
				{
					return left.x * right.x + left.y * right.y + left.z * right.z;
				}

				// Token: 0x06000217 RID: 535 RVA: 0x0001EA5C File Offset: 0x0001CC5C
				public static float Distance(Requests.Vector3.Vector3f value1, Requests.Vector3.Vector3f value2)
				{
					float num = value1.x - value2.x;
					float num2 = value1.y - value2.y;
					float num3 = value1.z - value2.z;
					return (float)Math.Sqrt((double)(num * num + num2 * num2 + num3 * num3));
				}

				// Token: 0x06000218 RID: 536 RVA: 0x0001EAAC File Offset: 0x0001CCAC
				public unsafe static Requests.Vector3.Vector3f operator &(Requests.Vector3.Vector3f v1, Requests.Vector3.Vector3f v2)
				{
					Requests.Vector3.Vector3f result = default(Requests.Vector3.Vector3f);
					int* ptr = (int*)(&v1);
					int* ptr2 = (int*)(&v2);
					int* ptr3 = (int*)(&result);
					*(ptr3++) = (*(ptr++) & *(ptr2++));
					*(ptr3++) = (*(ptr++) & *(ptr2++));
					*(ptr3++) = (*(ptr++) & *(ptr2++));
					*ptr3 = (*ptr & *ptr2);
					return result;
				}

				// Token: 0x06000219 RID: 537 RVA: 0x0001EB18 File Offset: 0x0001CD18
				public unsafe static Requests.Vector3.Vector3f operator |(Requests.Vector3.Vector3f v1, Requests.Vector3.Vector3f v2)
				{
					Requests.Vector3.Vector3f result = default(Requests.Vector3.Vector3f);
					int* ptr = (int*)(&v1);
					int* ptr2 = (int*)(&v2);
					int* ptr3 = (int*)(&result);
					*(ptr3++) = (*(ptr++) | *(ptr2++));
					*(ptr3++) = (*(ptr++) | *(ptr2++));
					*(ptr3++) = (*(ptr++) | *(ptr2++));
					*ptr3 = (*ptr | *ptr2);
					return result;
				}

				// Token: 0x0600021A RID: 538 RVA: 0x0001EB84 File Offset: 0x0001CD84
				public unsafe static Requests.Vector3.Vector3f operator ^(Requests.Vector3.Vector3f v1, Requests.Vector3.Vector3f v2)
				{
					Requests.Vector3.Vector3f result = default(Requests.Vector3.Vector3f);
					int* ptr = (int*)(&v1);
					int* ptr2 = (int*)(&v2);
					int* ptr3 = (int*)(&result);
					*(ptr3++) = (*(ptr++) ^ *(ptr2++));
					*(ptr3++) = (*(ptr++) ^ *(ptr2++));
					*(ptr3++) = (*(ptr++) ^ *(ptr2++));
					*ptr3 = (*ptr ^ *ptr2);
					return result;
				}

				// Token: 0x0600021B RID: 539 RVA: 0x0001EBF0 File Offset: 0x0001CDF0
				public static Requests.Vector3.Vector3f operator +(Requests.Vector3.Vector3f v1, Requests.Vector3.Vector3f v2)
				{
					return new Requests.Vector3.Vector3f(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
				}

				// Token: 0x0600021C RID: 540 RVA: 0x0001EC30 File Offset: 0x0001CE30
				public static Requests.Vector3.Vector3f operator -(Requests.Vector3.Vector3f v1, Requests.Vector3.Vector3f v2)
				{
					return new Requests.Vector3.Vector3f(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
				}

				// Token: 0x0600021D RID: 541 RVA: 0x0001EC70 File Offset: 0x0001CE70
				public static Requests.Vector3.Vector3f operator *(Requests.Vector3.Vector3f v1, Requests.Vector3.Vector3f v2)
				{
					return new Requests.Vector3.Vector3f(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z);
				}

				// Token: 0x0600021E RID: 542 RVA: 0x0001ECB0 File Offset: 0x0001CEB0
				public static Requests.Vector3.Vector3f operator *(float scalar, Requests.Vector3.Vector3f v)
				{
					return new Requests.Vector3.Vector3f(scalar * v.x, scalar * v.y, scalar * v.z);
				}

				// Token: 0x0600021F RID: 543 RVA: 0x0001ECE0 File Offset: 0x0001CEE0
				public static Requests.Vector3.Vector3f operator *(Requests.Vector3.Vector3f v, float scalar)
				{
					return new Requests.Vector3.Vector3f(scalar * v.x, scalar * v.y, scalar * v.z);
				}

				// Token: 0x06000220 RID: 544 RVA: 0x0001ED10 File Offset: 0x0001CF10
				public static Requests.Vector3.Vector3f operator /(Requests.Vector3.Vector3f v1, Requests.Vector3.Vector3f v2)
				{
					return new Requests.Vector3.Vector3f(v1.x / v2.x, v1.y / v2.y, v1.z / v2.z);
				}

				// Token: 0x06000221 RID: 545 RVA: 0x0001ED50 File Offset: 0x0001CF50
				public static bool operator ==(Requests.Vector3.Vector3f v1, Requests.Vector3.Vector3f v2)
				{
					return v1.x == v2.x && v1.y == v2.y && v1.z == v2.z;
				}

				// Token: 0x06000222 RID: 546 RVA: 0x0001ED90 File Offset: 0x0001CF90
				public static bool operator !=(Requests.Vector3.Vector3f v1, Requests.Vector3.Vector3f v2)
				{
					return v1.x != v2.x || v1.y != v2.y || v1.z != v2.z;
				}

				// Token: 0x06000223 RID: 547 RVA: 0x0001EDD4 File Offset: 0x0001CFD4
				public override string ToString()
				{
					return string.Concat(new string[]
					{
						"<",
						this.x.ToString(),
						", ",
						this.y.ToString(),
						", ",
						this.z.ToString(),
						">"
					});
				}

				// Token: 0x04000579 RID: 1401
				internal float x;

				// Token: 0x0400057A RID: 1402
				internal float y;

				// Token: 0x0400057B RID: 1403
				internal float z;
			}
		}

		// Token: 0x02000048 RID: 72
		public class Vector4
		{
			// Token: 0x02000064 RID: 100
			public struct Vector4f
			{
				// Token: 0x1700005F RID: 95
				// (get) Token: 0x06000224 RID: 548 RVA: 0x0001EE3C File Offset: 0x0001D03C
				// (set) Token: 0x06000225 RID: 549 RVA: 0x0001EE54 File Offset: 0x0001D054
				public float X
				{
					get
					{
						return this.x;
					}
					set
					{
						this.x = value;
					}
				}

				// Token: 0x17000060 RID: 96
				// (get) Token: 0x06000226 RID: 550 RVA: 0x0001EE60 File Offset: 0x0001D060
				// (set) Token: 0x06000227 RID: 551 RVA: 0x0001EE78 File Offset: 0x0001D078
				public float Y
				{
					get
					{
						return this.y;
					}
					set
					{
						this.y = value;
					}
				}

				// Token: 0x17000061 RID: 97
				// (get) Token: 0x06000228 RID: 552 RVA: 0x0001EE84 File Offset: 0x0001D084
				// (set) Token: 0x06000229 RID: 553 RVA: 0x0001EE9C File Offset: 0x0001D09C
				public float Z
				{
					get
					{
						return this.z;
					}
					set
					{
						this.z = value;
					}
				}

				// Token: 0x17000062 RID: 98
				// (get) Token: 0x0600022A RID: 554 RVA: 0x0001EEA8 File Offset: 0x0001D0A8
				// (set) Token: 0x0600022B RID: 555 RVA: 0x0001EEC0 File Offset: 0x0001D0C0
				public float W
				{
					get
					{
						return this.w;
					}
					set
					{
						this.w = value;
					}
				}

				// Token: 0x17000063 RID: 99
				// (get) Token: 0x0600022C RID: 556 RVA: 0x0001EECC File Offset: 0x0001D0CC
				public static Requests.Vector4.Vector4f Pi
				{
					get
					{
						return new Requests.Vector4.Vector4f(3.1415927f);
					}
				}

				// Token: 0x17000064 RID: 100
				// (get) Token: 0x0600022D RID: 557 RVA: 0x0001EEE8 File Offset: 0x0001D0E8
				public static Requests.Vector4.Vector4f E
				{
					get
					{
						return new Requests.Vector4.Vector4f(2.7182817f);
					}
				}

				// Token: 0x17000065 RID: 101
				// (get) Token: 0x0600022E RID: 558 RVA: 0x0001EF04 File Offset: 0x0001D104
				public static Requests.Vector4.Vector4f One
				{
					get
					{
						return new Requests.Vector4.Vector4f(1f);
					}
				}

				// Token: 0x17000066 RID: 102
				// (get) Token: 0x0600022F RID: 559 RVA: 0x0001EF20 File Offset: 0x0001D120
				public static Requests.Vector4.Vector4f Zero
				{
					get
					{
						return new Requests.Vector4.Vector4f(0f);
					}
				}

				// Token: 0x17000067 RID: 103
				// (get) Token: 0x06000230 RID: 560 RVA: 0x0001EF3C File Offset: 0x0001D13C
				public static Requests.Vector4.Vector4f MinusOne
				{
					get
					{
						return new Requests.Vector4.Vector4f(-1f);
					}
				}

				// Token: 0x17000068 RID: 104
				[IndexerName("Component")]
				public unsafe float this[int index]
				{
					get
					{
						bool flag = (index | 3) != 3;
						if (flag)
						{
							throw new ArgumentOutOfRangeException("index");
						}
						fixed (float* ptr = &this.x)
						{
							float* ptr2 = ptr;
							return ptr2[index];
						}
					}
					set
					{
						bool flag = (index | 3) != 3;
						if (flag)
						{
							throw new ArgumentOutOfRangeException("index");
						}
						fixed (float* ptr = &this.x)
						{
							float* ptr2 = ptr;
							ptr2[index] = value;
						}
					}
				}

				// Token: 0x06000233 RID: 563 RVA: 0x0001EFD1 File Offset: 0x0001D1D1
				public Vector4f(float x, float y, float z, float w)
				{
					this.x = x;
					this.y = y;
					this.z = z;
					this.w = w;
				}

				// Token: 0x06000234 RID: 564 RVA: 0x0001EFF1 File Offset: 0x0001D1F1
				public Vector4f(float f)
				{
					this.x = f;
					this.y = f;
					this.z = f;
					this.w = f;
				}

				// Token: 0x06000235 RID: 565 RVA: 0x0001F010 File Offset: 0x0001D210
				public static float Dot(Requests.Vector4.Vector4f left, Requests.Vector4.Vector4f right)
				{
					return left.x * right.x + left.y * right.y + left.z * right.z + left.w * right.w;
				}

				// Token: 0x06000236 RID: 566 RVA: 0x0001F05C File Offset: 0x0001D25C
				public static float Distance(Requests.Vector4.Vector4f value1, Requests.Vector4.Vector4f value2)
				{
					float num = value1.x - value2.x;
					float num2 = value1.y - value2.y;
					float num3 = value1.z - value2.z;
					float num4 = value1.w - value2.w;
					return (float)Math.Sqrt((double)(num * num + num2 * num2 + num3 * num3 + num4 * num4));
				}

				// Token: 0x06000237 RID: 567 RVA: 0x0001F0C0 File Offset: 0x0001D2C0
				public unsafe static Requests.Vector4.Vector4f operator &(Requests.Vector4.Vector4f v1, Requests.Vector4.Vector4f v2)
				{
					Requests.Vector4.Vector4f result = default(Requests.Vector4.Vector4f);
					int* ptr = (int*)(&v1);
					int* ptr2 = (int*)(&v2);
					int* ptr3 = (int*)(&result);
					*(ptr3++) = (*(ptr++) & *(ptr2++));
					*(ptr3++) = (*(ptr++) & *(ptr2++));
					*(ptr3++) = (*(ptr++) & *(ptr2++));
					*ptr3 = (*ptr & *ptr2);
					return result;
				}

				// Token: 0x06000238 RID: 568 RVA: 0x0001F12C File Offset: 0x0001D32C
				public unsafe static Requests.Vector4.Vector4f operator |(Requests.Vector4.Vector4f v1, Requests.Vector4.Vector4f v2)
				{
					Requests.Vector4.Vector4f result = default(Requests.Vector4.Vector4f);
					int* ptr = (int*)(&v1);
					int* ptr2 = (int*)(&v2);
					int* ptr3 = (int*)(&result);
					*(ptr3++) = (*(ptr++) | *(ptr2++));
					*(ptr3++) = (*(ptr++) | *(ptr2++));
					*(ptr3++) = (*(ptr++) | *(ptr2++));
					*ptr3 = (*ptr | *ptr2);
					return result;
				}

				// Token: 0x06000239 RID: 569 RVA: 0x0001F198 File Offset: 0x0001D398
				public unsafe static Requests.Vector4.Vector4f operator ^(Requests.Vector4.Vector4f v1, Requests.Vector4.Vector4f v2)
				{
					Requests.Vector4.Vector4f result = default(Requests.Vector4.Vector4f);
					int* ptr = (int*)(&v1);
					int* ptr2 = (int*)(&v2);
					int* ptr3 = (int*)(&result);
					*(ptr3++) = (*(ptr++) ^ *(ptr2++));
					*(ptr3++) = (*(ptr++) ^ *(ptr2++));
					*(ptr3++) = (*(ptr++) ^ *(ptr2++));
					*ptr3 = (*ptr ^ *ptr2);
					return result;
				}

				// Token: 0x0600023A RID: 570 RVA: 0x0001F204 File Offset: 0x0001D404
				public static Requests.Vector4.Vector4f operator +(Requests.Vector4.Vector4f v1, Requests.Vector4.Vector4f v2)
				{
					return new Requests.Vector4.Vector4f(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z, v1.w + v2.w);
				}

				// Token: 0x0600023B RID: 571 RVA: 0x0001F250 File Offset: 0x0001D450
				public static Requests.Vector4.Vector4f operator -(Requests.Vector4.Vector4f v1, Requests.Vector4.Vector4f v2)
				{
					return new Requests.Vector4.Vector4f(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z, v1.w - v2.w);
				}

				// Token: 0x0600023C RID: 572 RVA: 0x0001F29C File Offset: 0x0001D49C
				public static Requests.Vector4.Vector4f operator *(Requests.Vector4.Vector4f v1, Requests.Vector4.Vector4f v2)
				{
					return new Requests.Vector4.Vector4f(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z, v1.w * v2.w);
				}

				// Token: 0x0600023D RID: 573 RVA: 0x0001F2E8 File Offset: 0x0001D4E8
				public static Requests.Vector4.Vector4f operator *(float scalar, Requests.Vector4.Vector4f v)
				{
					return new Requests.Vector4.Vector4f(scalar * v.x, scalar * v.y, scalar * v.z, scalar * v.w);
				}

				// Token: 0x0600023E RID: 574 RVA: 0x0001F320 File Offset: 0x0001D520
				public static Requests.Vector4.Vector4f operator *(Requests.Vector4.Vector4f v, float scalar)
				{
					return new Requests.Vector4.Vector4f(scalar * v.x, scalar * v.y, scalar * v.z, scalar * v.w);
				}

				// Token: 0x0600023F RID: 575 RVA: 0x0001F358 File Offset: 0x0001D558
				public static Requests.Vector4.Vector4f operator /(Requests.Vector4.Vector4f v1, Requests.Vector4.Vector4f v2)
				{
					return new Requests.Vector4.Vector4f(v1.x / v2.x, v1.y / v2.y, v1.z / v2.z, v1.w / v2.w);
				}

				// Token: 0x06000240 RID: 576 RVA: 0x0001F3A4 File Offset: 0x0001D5A4
				public static bool operator ==(Requests.Vector4.Vector4f v1, Requests.Vector4.Vector4f v2)
				{
					return v1.x == v2.x && v1.y == v2.y && v1.z == v2.z && v1.w == v2.w;
				}

				// Token: 0x06000241 RID: 577 RVA: 0x0001F3F4 File Offset: 0x0001D5F4
				public static bool operator !=(Requests.Vector4.Vector4f v1, Requests.Vector4.Vector4f v2)
				{
					return v1.x != v2.x || v1.y != v2.y || v1.z != v2.z || v1.w != v2.w;
				}

				// Token: 0x06000242 RID: 578 RVA: 0x0001F444 File Offset: 0x0001D644
				public override string ToString()
				{
					return string.Concat(new string[]
					{
						"<",
						this.x.ToString(),
						", ",
						this.y.ToString(),
						", ",
						this.z.ToString(),
						", ",
						this.w.ToString(),
						">"
					});
				}

				// Token: 0x0400057C RID: 1404
				internal float x;

				// Token: 0x0400057D RID: 1405
				internal float y;

				// Token: 0x0400057E RID: 1406
				internal float z;

				// Token: 0x0400057F RID: 1407
				internal float w;
			}
		}

		// Token: 0x02000049 RID: 73
		public class ViewMatrix
		{
			// Token: 0x060001DC RID: 476 RVA: 0x0001E0BC File Offset: 0x0001C2BC
			public ViewMatrix(float M11, float M12, float M13, float M14, float M21, float M22, float M23, float M24, float M31, float M32, float M33, float M34, float M41, float M42, float M43, float M44)
			{
				this.M11 = M11;
				this.M12 = M12;
				this.M13 = M13;
				this.M14 = M14;
				this.M21 = M21;
				this.M22 = M22;
				this.M23 = M23;
				this.M24 = M24;
				this.M31 = M31;
				this.M32 = M32;
				this.M33 = M33;
				this.M34 = M34;
				this.M41 = M41;
				this.M42 = M42;
				this.M43 = M43;
				this.M44 = M44;
			}

			// Token: 0x060001DD RID: 477 RVA: 0x0001E150 File Offset: 0x0001C350
			public ViewMatrix(float f)
			{
				this.M11 = f;
				this.M12 = f;
				this.M13 = f;
				this.M14 = f;
				this.M21 = f;
				this.M22 = f;
				this.M23 = f;
				this.M24 = f;
				this.M31 = f;
				this.M32 = f;
				this.M33 = f;
				this.M34 = f;
				this.M41 = f;
				this.M42 = f;
				this.M43 = f;
				this.M44 = f;
			}

			// Token: 0x060001DE RID: 478 RVA: 0x0001E1D8 File Offset: 0x0001C3D8
			public static Requests.ViewMatrix ReadViewMatrix(ulong Address)
			{
				bool flag = Requests.IsValidPtr(Address) && Requests.ViewMatrix.MEMAPI.IsAttached;
				Requests.ViewMatrix result;
				if (flag)
				{
					byte[] array = Requests.ViewMatrix.MEMAPI.ReadBytes(Address, 64);
					float[] array2 = new float[array.Length / 4];
					Buffer.BlockCopy(array, 0, array2, 0, array.Length);
					result = new Requests.ViewMatrix(array2[0], array2[1], array2[2], array2[3], array2[4], array2[5], array2[6], array2[7], array2[8], array2[9], array2[10], array2[11], array2[12], array2[13], array2[14], array2[15]);
				}
				else
				{
					result = new Requests.ViewMatrix(0f);
				}
				return result;
			}

			// Token: 0x060001DF RID: 479 RVA: 0x0001E274 File Offset: 0x0001C474
			public static void Transpose(ref Requests.ViewMatrix value, out Requests.ViewMatrix result)
			{
				result = new Requests.ViewMatrix(0f)
				{
					M11 = value.M11,
					M12 = value.M21,
					M13 = value.M31,
					M14 = value.M41,
					M21 = value.M12,
					M22 = value.M22,
					M23 = value.M32,
					M24 = value.M42,
					M31 = value.M13,
					M32 = value.M23,
					M33 = value.M33,
					M34 = value.M43,
					M41 = value.M14,
					M42 = value.M24,
					M43 = value.M34,
					M44 = value.M44
				};
			}

			// Token: 0x04000560 RID: 1376
			internal static Requests MEMAPI;

			// Token: 0x04000561 RID: 1377
			public float M11;

			// Token: 0x04000562 RID: 1378
			public float M12;

			// Token: 0x04000563 RID: 1379
			public float M13;

			// Token: 0x04000564 RID: 1380
			public float M14;

			// Token: 0x04000565 RID: 1381
			public float M21;

			// Token: 0x04000566 RID: 1382
			public float M22;

			// Token: 0x04000567 RID: 1383
			public float M23;

			// Token: 0x04000568 RID: 1384
			public float M24;

			// Token: 0x04000569 RID: 1385
			public float M31;

			// Token: 0x0400056A RID: 1386
			public float M32;

			// Token: 0x0400056B RID: 1387
			public float M33;

			// Token: 0x0400056C RID: 1388
			public float M34;

			// Token: 0x0400056D RID: 1389
			public float M41;

			// Token: 0x0400056E RID: 1390
			public float M42;

			// Token: 0x0400056F RID: 1391
			public float M43;

			// Token: 0x04000570 RID: 1392
			public float M44;
		}
	}
}
