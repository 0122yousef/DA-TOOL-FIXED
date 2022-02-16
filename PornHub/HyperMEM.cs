using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using PornHub.Memory.Logic;
using PornHub.Memory.Logic.Enums;
using PornHub.Memory.MEME.Structures;

namespace PornHub
{
	// Token: 0x0200000C RID: 12
	public class HyperMEM
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0001629D File Offset: 0x0001449D
		// (set) Token: 0x06000053 RID: 83 RVA: 0x000162A5 File Offset: 0x000144A5
		internal MDriver Driver { get; private set; }

		// Token: 0x06000054 RID: 84 RVA: 0x000162B0 File Offset: 0x000144B0
		private void SetDriver(MDriver Driver)
		{
			bool flag = Driver == null;
			if (flag)
			{
				throw new ArgumentNullException("Driver", "Driver is null");
			}
			this.Driver = Driver;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000162DF File Offset: 0x000144DF
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000162E7 File Offset: 0x000144E7
		public ulong GameBase { get; private set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000162F0 File Offset: 0x000144F0
		// (set) Token: 0x06000058 RID: 88 RVA: 0x000162F8 File Offset: 0x000144F8
		public ulong GameSize { get; private set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00016301 File Offset: 0x00014501
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00016309 File Offset: 0x00014509
		public ulong LastProcessId { get; private set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00016312 File Offset: 0x00014512
		// (set) Token: 0x0600005C RID: 92 RVA: 0x0001631A File Offset: 0x0001451A
		public string LastProcessName { get; private set; }

		// Token: 0x0600005D RID: 93 RVA: 0x00016324 File Offset: 0x00014524
		private bool SetGame(string GameName)
		{
			bool flag = GameName == "";
			if (flag)
			{
				throw new ArgumentNullException("", "Game is null");
			}
			Process[] processesByName = Process.GetProcessesByName(GameName);
			bool flag2 = processesByName.Length != 0;
			bool result;
			if (flag2)
			{
				this.LastProcessId = (ulong)((long)processesByName[0].Id);
				this.LastProcessName = GameName;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00016384 File Offset: 0x00014584
		public bool LoadGame(string GameName)
		{
			FileInfo driverFile = new FileInfo("C:\\Windows\\System32\\drivers\\wmiacpi.sys");
			MDriver mdriver = new MDriver(new MDriverConfig
			{
				ServiceName = HyperMEM.SRVName,
				SymbolicLink = "\\\\.\\\\" + HyperMEM.SRVName,
				DriverFile = driverFile,
				LoadMethod = MDriverLoad.Normal
			}, null);
			bool flag = !mdriver.Load();
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = MDriver.CanConnectTo(mdriver.Config.SymbolicLink, mdriver.Config.IoMethod);
				if (flag2)
				{
					Debug.WriteLine("[*] The driver symbolic file is already created.");
					Debug.WriteLine("[*] Please make sure you are not loading the driver twice!");
				}
				try
				{
					bool isConnected = mdriver.IO.IsConnected;
					if (!isConnected)
					{
						Debug.WriteLine("[⭐] Failed to connect with the driver.");
						return false;
					}
					Debug.WriteLine("[⭐] Driver has been loaded.");
					Debug.WriteLine("[⭐] Driver has been Connected.");
					Debug.WriteLine("[⭐] Driver->IsLoaded     : " + mdriver.IsLoaded.ToString());
					Debug.WriteLine("[⭐] Driver->IsConnected  : " + mdriver.IO.IsConnected.ToString());
					Debug.WriteLine("[⭐] Driver->IsDisposed   : " + mdriver.IsDisposed.ToString());
					this.SetDriver(mdriver);
					bool flag3 = this.SetGame(GameName);
					if (flag3)
					{
						Debug.WriteLine("[⭐] Game->Game Name  : " + GameName);
						Debug.WriteLine("[⭐] Game->ProcID  : " + this.LastProcessId.ToString());
						this.GameBase = this.GetGameBase();
						this.GameSize = this.GetGameSize();
						Debug.WriteLine("[⭐] Game->Base Address  : " + this.GameBase.ToString("X"));
						Debug.WriteLine("[⭐] Game->End Address  : " + (this.GameBase + this.GameSize).ToString("X"));
						return true;
					}
					Debug.WriteLine("[⭐] Game Is Not Running!");
					return false;
				}
				catch (Exception ex)
				{
					Debug.WriteLine("[*] " + ex.Message + ".");
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000165D4 File Offset: 0x000147D4
		public bool IsValidAddr(ulong Address)
		{
			return Address != 0UL && Address > 1048576UL && Address < 36028797018963967UL;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00016604 File Offset: 0x00014804
		private byte[] Read(ulong Address, int Size)
		{
			bool flag = !this.Driver.IO.IsConnected;
			if (flag)
			{
				throw new Exception("[⭐] Driver Is Not Connected.");
			}
			bool flag2 = !this.IsValidAddr(Address);
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
					throw new InsufficientMemoryException("Couldn't allocate memory for the buffer, at Read(ulong Address, Int32 Size).");
				}
				ioData.ProcessId = this.LastProcessId;
				ioData.Size = Size;
				ioData.Response = (ulong)intPtr.ToInt64();
				ioData.Address = Address;
				bool flag4 = this.Driver.IO.TryIoControl<KernelReadRequest>(HyperMEM.ReadCtlCode, ioData, (int)ioDataSize);
				if (flag4)
				{
					array2 = (byte[])gchandle.Target;
					gchandle.Free();
					result = array2;
				}
				else
				{
					gchandle.Free();
					byte[] array3 = new byte[Size];
					result = array3;
				}
			}
			return result;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00016718 File Offset: 0x00014918
		public byte[] ReadBytes(ulong Address, int Length = 4)
		{
			return this.Read(Address, Length);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00016734 File Offset: 0x00014934
		public byte ReadByte(ulong Address)
		{
			byte[] array = this.Read(Address, 1);
			return array[0];
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00016754 File Offset: 0x00014954
		public bool ReadBool(ulong Address)
		{
			byte[] array = this.Read(Address, 1);
			return array[0] > 0;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00016778 File Offset: 0x00014978
		public short ReadInt16(ulong Address)
		{
			byte[] value = this.ReadBytes(Address, 2);
			return BitConverter.ToInt16(value, 0);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0001679C File Offset: 0x0001499C
		public int ReadInt32(ulong Address)
		{
			byte[] value = this.ReadBytes(Address, 4);
			return BitConverter.ToInt32(value, 0);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000167C0 File Offset: 0x000149C0
		public ulong ReadInt64(ulong Address)
		{
			byte[] value = this.ReadBytes(Address, 8);
			return (ulong)BitConverter.ToInt64(value, 0);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000167E4 File Offset: 0x000149E4
		public float ReadFloat(ulong Address)
		{
			byte[] value = this.ReadBytes(Address, 4);
			return BitConverter.ToSingle(value, 0);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00016808 File Offset: 0x00014A08
		public HyperMEM.Vectors.Vec2.Vector2 ReadVec2(ulong Address)
		{
			byte[] array = this.ReadBytes(Address, 8);
			float[] array2 = new float[array.Length / 4];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
			return new HyperMEM.Vectors.Vec2.Vector2(array2[0], array2[1]);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00016848 File Offset: 0x00014A48
		public HyperMEM.Vectors.Vec3.Vector3 ReadVec3(ulong Address)
		{
			byte[] array = this.ReadBytes(Address, 12);
			float[] array2 = new float[array.Length / 4];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
			return new HyperMEM.Vectors.Vec3.Vector3(array2[0], array2[1], array2[2]);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0001688C File Offset: 0x00014A8C
		public HyperMEM.Vectors.Vec4.Vector4 ReadVec4(ulong Address)
		{
			byte[] array = this.ReadBytes(Address, 16);
			float[] array2 = new float[array.Length / 4];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
			return new HyperMEM.Vectors.Vec4.Vector4(array2[0], array2[1], array2[2], array2[3]);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000168D4 File Offset: 0x00014AD4
		public double ReadDouble(ulong Address)
		{
			byte[] value = this.ReadBytes(Address, 8);
			return BitConverter.ToDouble(value, 0);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000168F8 File Offset: 0x00014AF8
		public ulong GetPointer(params ulong[] args)
		{
			ulong num = 0UL;
			for (int i = 0; i <= args.Length - 1; i++)
			{
				bool flag = i != args.Length - 1;
				if (flag)
				{
					num = this.ReadInt64(num + args[i]);
				}
				else
				{
					num += args[i];
				}
			}
			return num;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00016950 File Offset: 0x00014B50
		public string ReadAsciiString(ulong Address, int length)
		{
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] array = this.ReadBytes(Address, length);
			for (int i = 0; i < length; i++)
			{
				bool flag = array[i] == 0;
				if (flag)
				{
					byte[] array2 = new byte[i];
					Array.Copy(array, array2, array2.Length);
					return asciiencoding.GetString(array2);
				}
			}
			return asciiencoding.GetString(array);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000169BC File Offset: 0x00014BBC
		public string ReadAsciiString2(ulong Address, int length)
		{
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] array = this.ReadBytes(Address, length);
			for (int i = 0; i < length; i++)
			{
				bool flag = array[i] == 0 || array[i] == 10;
				if (flag)
				{
					byte[] array2 = new byte[i];
					Array.Copy(array, array2, array2.Length);
					return asciiencoding.GetString(array2);
				}
			}
			return asciiencoding.GetString(array);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00016A30 File Offset: 0x00014C30
		public string ReadUniCodeString(ulong Address, int length)
		{
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			byte[] bytes = this.ReadBytes(Address, length * 2);
			return unicodeEncoding.GetString(bytes);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00016A5C File Offset: 0x00014C5C
		public HyperMEM.Vectors.View.Matrix ReadViewMatrix(ulong Address)
		{
			byte[] array = this.ReadBytes(Address, 64);
			float[] array2 = new float[array.Length / 4];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
			return new HyperMEM.Vectors.View.Matrix(array2[0], array2[1], array2[2], array2[3], array2[4], array2[5], array2[6], array2[7], array2[8], array2[9], array2[10], array2[11], array2[12], array2[13], array2[14], array2[15]);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00016ACC File Offset: 0x00014CCC
		private void Write(ulong Address, byte[] Value, bool ProtectionBypass = false)
		{
			bool flag = !this.Driver.IO.IsConnected;
			if (flag)
			{
				throw new Exception("[⭐] Driver Is Not Connected.");
			}
			bool flag2 = !this.IsValidAddr(Address);
			if (!flag2)
			{
				int size = Value.Length;
				bool flag3 = false;
				KernelWriteRequest ioData = default(KernelWriteRequest);
				uint ioDataSize = (uint)Marshal.SizeOf<KernelWriteRequest>();
				GCHandle gchandle = GCHandle.Alloc(Value, GCHandleType.Pinned);
				bool flag4 = !gchandle.IsAllocated;
				if (flag4)
				{
					throw new InsufficientMemoryException("Couldn't allocate memory for the buffer, at Write(ulong Address, byte[] Value, bool ProtectionBypass = false).");
				}
				ioData.ProcessId = this.LastProcessId;
				ioData.Size = size;
				ioData.Value = (ulong)gchandle.AddrOfPinnedObject().ToInt64();
				ioData.Address = Address;
				if (!ProtectionBypass)
				{
					flag3 = this.Driver.IO.TryIoControl<KernelWriteRequest>(HyperMEM.WriteCtlCode, ioData, (int)ioDataSize);
				}
				gchandle.Free();
				bool flag5 = !flag3;
				if (flag5)
				{
				}
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00016BBB File Offset: 0x00014DBB
		public void WriteBytes(ulong Address, byte[] buffer, bool ProtectionBypass = false)
		{
			this.Write(Address, buffer, ProtectionBypass);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00016BC8 File Offset: 0x00014DC8
		public void WriteByte(ulong Address, byte Value, bool ProtectionBypass = false)
		{
			byte[] bytes = BitConverter.GetBytes((short)Value);
			this.WriteBytes(Address, bytes, ProtectionBypass);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00016BE8 File Offset: 0x00014DE8
		public void WriteBool(ulong Address, bool Value, bool ProtectionBypass = false)
		{
			byte[] bytes = BitConverter.GetBytes(Value);
			this.WriteBytes(Address, bytes, ProtectionBypass);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00016C08 File Offset: 0x00014E08
		public void WriteInt16(ulong Address, short Value, bool ProtectionBypass = false)
		{
			byte[] bytes = BitConverter.GetBytes(Value);
			this.WriteBytes(Address, bytes, ProtectionBypass);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00016C28 File Offset: 0x00014E28
		public void WriteInt32(ulong Address, int Value, bool ProtectionBypass = false)
		{
			byte[] bytes = BitConverter.GetBytes(Value);
			this.WriteBytes(Address, bytes, ProtectionBypass);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00016C48 File Offset: 0x00014E48
		public void WriteInt64(ulong Address, long Value, bool ProtectionBypass = false)
		{
			byte[] bytes = BitConverter.GetBytes(Value);
			this.WriteBytes(Address, bytes, ProtectionBypass);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00016C68 File Offset: 0x00014E68
		public void WriteFloat(ulong Address, float Value, bool ProtectionBypass = false)
		{
			byte[] bytes = BitConverter.GetBytes(Value);
			this.WriteBytes(Address, bytes, ProtectionBypass);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00016C88 File Offset: 0x00014E88
		public void WriteVec2(ulong Address, HyperMEM.Vectors.Vec2.Vector2 Value, bool ProtectionBypass = false)
		{
			byte[] array = new byte[HyperMEM.Vectors.Vec2.Vector2.SizeInBytes];
			Buffer.BlockCopy(BitConverter.GetBytes(Value.X), 0, array, 0, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(Value.Y), 0, array, 4, 4);
			this.WriteBytes(Address, array, ProtectionBypass);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00016CD8 File Offset: 0x00014ED8
		public void WriteVec3(ulong Address, HyperMEM.Vectors.Vec3.Vector3 Value, bool ProtectionBypass = false)
		{
			byte[] array = new byte[HyperMEM.Vectors.Vec3.Vector3.SizeInBytes];
			Buffer.BlockCopy(BitConverter.GetBytes(Value.X), 0, array, 0, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(Value.Y), 0, array, 4, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(Value.Z), 0, array, 8, 4);
			this.WriteBytes(Address, array, ProtectionBypass);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00016D3C File Offset: 0x00014F3C
		public void WriteVec4(ulong Address, HyperMEM.Vectors.Vec4.Vector4 Value, bool ProtectionBypass = false)
		{
			byte[] array = new byte[HyperMEM.Vectors.Vec2.Vector2.SizeInBytes];
			Buffer.BlockCopy(BitConverter.GetBytes(Value.X), 0, array, 0, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(Value.Y), 0, array, 4, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(Value.Z), 0, array, 8, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(Value.W), 0, array, 12, 4);
			this.WriteBytes(Address, array, ProtectionBypass);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00016DB4 File Offset: 0x00014FB4
		public void WriteDouble(ulong Address, double Value, bool ProtectionBypass = false)
		{
			byte[] bytes = BitConverter.GetBytes(Value);
			this.WriteBytes(Address, bytes, ProtectionBypass);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00016DD4 File Offset: 0x00014FD4
		public void WriteAsciiString(ulong Address, string value, bool ProtectionBypass = false)
		{
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			this.WriteByte(Address + (ulong)((long)asciiencoding.GetBytes(value).Length), 0, ProtectionBypass);
			this.WriteBytes(Address, asciiencoding.GetBytes(value), ProtectionBypass);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00016E10 File Offset: 0x00015010
		public void WriteUniCodeString(ulong Address, string value, bool ProtectionBypass = false)
		{
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			this.WriteBytes(Address, unicodeEncoding.GetBytes(value), ProtectionBypass);
			this.WriteByte(Address + (ulong)((long)(value.Length * 2)), 0, ProtectionBypass);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00016E48 File Offset: 0x00015048
		public void ASM_Return_Bool(ulong Address, bool Value, bool ProtectionBypass = false)
		{
			byte[] value;
			if (Value)
			{
				value = new byte[]
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
				};
			}
			else
			{
				value = new byte[]
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
				};
			}
			this.Write(Address, value, ProtectionBypass);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00016E94 File Offset: 0x00015094
		public ulong GetAlloc()
		{
			bool flag = !this.Driver.IO.IsConnected;
			if (flag)
			{
				throw new Exception("[⭐] Driver Is Not Connected.");
			}
			KernelReadRequest ioData = default(KernelReadRequest);
			uint ioDataSize = (uint)Marshal.SizeOf<KernelReadRequest>();
			byte[] value = new byte[8];
			GCHandle gchandle = GCHandle.Alloc(value, GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			ioData.ProcessId = this.LastProcessId;
			ioData.Response = (ulong)intPtr.ToInt64();
			ioData.Size = 8;
			bool flag2 = this.Driver.IO.TryIoControl<KernelReadRequest>(HyperMEM.GetAllocRegion, ioData, (int)ioDataSize);
			ulong result;
			if (flag2)
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

		// Token: 0x06000081 RID: 129 RVA: 0x00016F50 File Offset: 0x00015150
		public ulong GetGameBase()
		{
			bool flag = !this.Driver.IO.IsConnected;
			if (flag)
			{
				throw new Exception("[⭐] Driver Is Not Connected.");
			}
			KernelReadRequest ioData = default(KernelReadRequest);
			uint ioDataSize = (uint)Marshal.SizeOf<KernelReadRequest>();
			byte[] value = new byte[8];
			GCHandle gchandle = GCHandle.Alloc(value, GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			ioData.ProcessId = this.LastProcessId;
			ioData.Response = (ulong)intPtr.ToInt64();
			ioData.Size = 8;
			bool flag2 = this.Driver.IO.TryIoControl<KernelReadRequest>(HyperMEM.GetBaseCtlCode, ioData, (int)ioDataSize);
			ulong result;
			if (flag2)
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

		// Token: 0x06000082 RID: 130 RVA: 0x0001700C File Offset: 0x0001520C
		public ulong GetGameSize()
		{
			bool flag = !this.Driver.IO.IsConnected;
			if (flag)
			{
				throw new Exception("[⭐] Driver Is Not Connected.");
			}
			KernelReadRequest ioData = default(KernelReadRequest);
			uint ioDataSize = (uint)Marshal.SizeOf<KernelReadRequest>();
			byte[] value = new byte[8];
			GCHandle gchandle = GCHandle.Alloc(value, GCHandleType.Pinned);
			IntPtr intPtr = gchandle.AddrOfPinnedObject();
			ioData.ProcessId = this.LastProcessId;
			ioData.Response = (ulong)intPtr.ToInt64();
			ioData.Size = 8;
			bool flag2 = this.Driver.IO.TryIoControl<KernelReadRequest>(HyperMEM.GetSizeCtlCode, ioData, (int)ioDataSize);
			ulong result;
			if (flag2)
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

		// Token: 0x06000083 RID: 131 RVA: 0x000170C8 File Offset: 0x000152C8
		public ulong FindCodeCave(ulong Start_Range, ulong End_Range, ulong Cave_Size)
		{
			for (ulong num = Start_Range; num < End_Range; num += 2000UL)
			{
				byte[] array = this.Read(num, 2000);
				for (int i = 0; i < array.Length; i++)
				{
					ulong num2 = 0UL;
					bool flag = array[i] == 0;
					if (flag)
					{
						while (i <= array.Length - 1 && array[i] == 0)
						{
							num2 += 1UL;
							i++;
							bool flag2 = num2 >= Cave_Size;
							if (flag2)
							{
								return num + (ulong)((long)i - (long)num2);
							}
						}
					}
				}
			}
			return 0UL;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0001716C File Offset: 0x0001536C
		public ulong PatternScanGame(ulong StartAddress, ulong EndAddress, byte[] Bytes, string[] Pattern, int scan_alignment)
		{
			byte[] array = new byte[EndAddress - StartAddress];
			ulong num = EndAddress - StartAddress;
			bool flag = this.GameBuffer == null;
			if (flag)
			{
				bool flag2 = num >= 3899391UL;
				if (flag2)
				{
					ulong num2 = 0UL;
					while (num2 < num)
					{
						bool flag3 = num - num2 > 3899391UL;
						if (flag3)
						{
							byte[] array2 = this.Read(StartAddress + num2, 3899391);
							array2.CopyTo(array, (int)num2);
							num2 += 3899391UL;
						}
						else
						{
							ulong num3 = num - num2;
							byte[] array3 = this.Read(StartAddress + num2, (int)num3);
							array3.CopyTo(array, (int)num3);
							num2 += 3899391UL;
						}
					}
				}
				else
				{
					array = this.Read(StartAddress, (int)(EndAddress - StartAddress));
				}
				this.GameBuffer = array;
			}
			else
			{
				array = this.GameBuffer;
			}
			for (int i = 0; i < array.Length; i += scan_alignment)
			{
				int num4 = 0;
				for (int j = i; j < Bytes.Length + i; j++)
				{
					bool flag4 = array[j] == Bytes[num4] || Pattern[num4] == "?";
					if (!flag4)
					{
						break;
					}
					num4++;
					bool flag5 = num4 == Bytes.Length;
					if (flag5)
					{
						return StartAddress + (ulong)((long)i);
					}
				}
			}
			return 0UL;
		}

		// Token: 0x0400028E RID: 654
		public static HyperMEM MEM;

		// Token: 0x0400028F RID: 655
		public static uint ReadCtlCode = 2237444U;

		// Token: 0x04000290 RID: 656
		public static uint WriteCtlCode = 2237448U;

		// Token: 0x04000291 RID: 657
		public static uint GetBaseCtlCode = 2237452U;

		// Token: 0x04000292 RID: 658
		public static uint GetSizeCtlCode = 2237456U;

		// Token: 0x04000293 RID: 659
		public static uint WriteCtlCode_Protection = 2237460U;

		// Token: 0x04000294 RID: 660
		public static uint GetAllocRegion = 2237464U;

		// Token: 0x04000295 RID: 661
		public static string SRVName = "PornHubDriver";

		// Token: 0x0400029B RID: 667
		public byte[] GameBuffer;

		// Token: 0x0200003C RID: 60
		public class Vectors
		{
			// Token: 0x0200005E RID: 94
			public class Vec2
			{
				// Token: 0x02000065 RID: 101
				[StructLayout(LayoutKind.Sequential, Pack = 4)]
				public struct Vector2
				{
					// Token: 0x06000243 RID: 579 RVA: 0x0001F4C2 File Offset: 0x0001D6C2
					public Vector2(float value)
					{
						this.X = value;
						this.Y = value;
					}

					// Token: 0x06000244 RID: 580 RVA: 0x0001F4D3 File Offset: 0x0001D6D3
					public Vector2(float x, float y)
					{
						this.X = x;
						this.Y = y;
					}

					// Token: 0x17000069 RID: 105
					// (get) Token: 0x06000245 RID: 581 RVA: 0x0001F4E4 File Offset: 0x0001D6E4
					public bool IsZero
					{
						get
						{
							return this.X == 0f && this.Y == 0f;
						}
					}

					// Token: 0x06000246 RID: 582 RVA: 0x0001F514 File Offset: 0x0001D714
					public float Length()
					{
						return (float)Math.Sqrt((double)(this.X * this.X + this.Y * this.Y));
					}

					// Token: 0x06000247 RID: 583 RVA: 0x0001F548 File Offset: 0x0001D748
					public float LengthSquared()
					{
						return this.X * this.X + this.Y * this.Y;
					}

					// Token: 0x06000248 RID: 584 RVA: 0x0001F578 File Offset: 0x0001D778
					public void Normalize()
					{
						float num = this.Length();
						bool flag = num != 0f;
						if (flag)
						{
							float num2 = 1f / num;
							this.X *= num2;
							this.Y *= num2;
						}
					}

					// Token: 0x06000249 RID: 585 RVA: 0x0001F5C4 File Offset: 0x0001D7C4
					public float[] ToArray()
					{
						return new float[]
						{
							this.X,
							this.Y
						};
					}

					// Token: 0x0600024A RID: 586 RVA: 0x0001F5F0 File Offset: 0x0001D7F0
					public static HyperMEM.Vectors.Vec2.Vector2 Add(HyperMEM.Vectors.Vec2.Vector2 left, HyperMEM.Vectors.Vec2.Vector2 right)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(left.X + right.X, left.Y + right.Y);
					}

					// Token: 0x0600024B RID: 587 RVA: 0x0001F624 File Offset: 0x0001D824
					public static HyperMEM.Vectors.Vec2.Vector2 Subtract(HyperMEM.Vectors.Vec2.Vector2 left, HyperMEM.Vectors.Vec2.Vector2 right)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(left.X - right.X, left.Y - right.Y);
					}

					// Token: 0x0600024C RID: 588 RVA: 0x0001F658 File Offset: 0x0001D858
					public static HyperMEM.Vectors.Vec2.Vector2 Multiply(HyperMEM.Vectors.Vec2.Vector2 value, float scale)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(value.X * scale, value.Y * scale);
					}

					// Token: 0x0600024D RID: 589 RVA: 0x0001F680 File Offset: 0x0001D880
					public static HyperMEM.Vectors.Vec2.Vector2 Multiply(HyperMEM.Vectors.Vec2.Vector2 left, HyperMEM.Vectors.Vec2.Vector2 right)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(left.X * right.X, left.Y * right.Y);
					}

					// Token: 0x0600024E RID: 590 RVA: 0x0001F6B4 File Offset: 0x0001D8B4
					public static HyperMEM.Vectors.Vec2.Vector2 Divide(HyperMEM.Vectors.Vec2.Vector2 value, float scale)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(value.X / scale, value.Y / scale);
					}

					// Token: 0x0600024F RID: 591 RVA: 0x0001F6DC File Offset: 0x0001D8DC
					public static HyperMEM.Vectors.Vec2.Vector2 Divide(HyperMEM.Vectors.Vec2.Vector2 left, HyperMEM.Vectors.Vec2.Vector2 right)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(left.X / right.X, left.Y / right.Y);
					}

					// Token: 0x06000250 RID: 592 RVA: 0x0001F710 File Offset: 0x0001D910
					public static HyperMEM.Vectors.Vec2.Vector2 Negate(HyperMEM.Vectors.Vec2.Vector2 value)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(-value.X, -value.Y);
					}

					// Token: 0x06000251 RID: 593 RVA: 0x0001F738 File Offset: 0x0001D938
					public static HyperMEM.Vectors.Vec2.Vector2 Abs(HyperMEM.Vectors.Vec2.Vector2 value)
					{
						return new HyperMEM.Vectors.Vec2.Vector2((value.X > 0f) ? value.X : (-value.X), (value.Y > 0f) ? value.Y : (-value.Y));
					}

					// Token: 0x06000252 RID: 594 RVA: 0x0001F788 File Offset: 0x0001D988
					public static HyperMEM.Vectors.Vec2.Vector2 Clamp(HyperMEM.Vectors.Vec2.Vector2 value, HyperMEM.Vectors.Vec2.Vector2 min, HyperMEM.Vectors.Vec2.Vector2 max)
					{
						float num = value.X;
						num = ((num > max.X) ? max.X : num);
						num = ((num < min.X) ? min.X : num);
						float num2 = value.Y;
						num2 = ((num2 > max.Y) ? max.Y : num2);
						num2 = ((num2 < min.Y) ? min.Y : num2);
						return new HyperMEM.Vectors.Vec2.Vector2(num, num2);
					}

					// Token: 0x06000253 RID: 595 RVA: 0x0001F7FC File Offset: 0x0001D9FC
					public static float Distance(HyperMEM.Vectors.Vec2.Vector2 value1, HyperMEM.Vectors.Vec2.Vector2 value2)
					{
						float num = value1.X - value2.X;
						float num2 = value1.Y - value2.Y;
						return (float)Math.Sqrt((double)(num * num + num2 * num2));
					}

					// Token: 0x06000254 RID: 596 RVA: 0x0001F838 File Offset: 0x0001DA38
					public static float Dot(HyperMEM.Vectors.Vec2.Vector2 left, HyperMEM.Vectors.Vec2.Vector2 right)
					{
						return left.X * right.X + left.Y * right.Y;
					}

					// Token: 0x06000255 RID: 597 RVA: 0x0001F868 File Offset: 0x0001DA68
					public static HyperMEM.Vectors.Vec2.Vector2 operator +(HyperMEM.Vectors.Vec2.Vector2 left, HyperMEM.Vectors.Vec2.Vector2 right)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(left.X + right.X, left.Y + right.Y);
					}

					// Token: 0x06000256 RID: 598 RVA: 0x0001F89C File Offset: 0x0001DA9C
					public static HyperMEM.Vectors.Vec2.Vector2 operator *(HyperMEM.Vectors.Vec2.Vector2 left, HyperMEM.Vectors.Vec2.Vector2 right)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(left.X * right.X, left.Y * right.Y);
					}

					// Token: 0x06000257 RID: 599 RVA: 0x0001F8D0 File Offset: 0x0001DAD0
					public static HyperMEM.Vectors.Vec2.Vector2 operator +(HyperMEM.Vectors.Vec2.Vector2 value)
					{
						return value;
					}

					// Token: 0x06000258 RID: 600 RVA: 0x0001F8E4 File Offset: 0x0001DAE4
					public static HyperMEM.Vectors.Vec2.Vector2 operator -(HyperMEM.Vectors.Vec2.Vector2 left, HyperMEM.Vectors.Vec2.Vector2 right)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(left.X - right.X, left.Y - right.Y);
					}

					// Token: 0x06000259 RID: 601 RVA: 0x0001F918 File Offset: 0x0001DB18
					public static HyperMEM.Vectors.Vec2.Vector2 operator -(HyperMEM.Vectors.Vec2.Vector2 value)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(-value.X, -value.Y);
					}

					// Token: 0x0600025A RID: 602 RVA: 0x0001F940 File Offset: 0x0001DB40
					public static HyperMEM.Vectors.Vec2.Vector2 operator *(float scale, HyperMEM.Vectors.Vec2.Vector2 value)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(value.X * scale, value.Y * scale);
					}

					// Token: 0x0600025B RID: 603 RVA: 0x0001F968 File Offset: 0x0001DB68
					public static HyperMEM.Vectors.Vec2.Vector2 operator *(HyperMEM.Vectors.Vec2.Vector2 value, float scale)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(value.X * scale, value.Y * scale);
					}

					// Token: 0x0600025C RID: 604 RVA: 0x0001F990 File Offset: 0x0001DB90
					public static HyperMEM.Vectors.Vec2.Vector2 operator /(HyperMEM.Vectors.Vec2.Vector2 value, float scale)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(value.X / scale, value.Y / scale);
					}

					// Token: 0x0600025D RID: 605 RVA: 0x0001F9B8 File Offset: 0x0001DBB8
					public static HyperMEM.Vectors.Vec2.Vector2 operator /(float scale, HyperMEM.Vectors.Vec2.Vector2 value)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(scale / value.X, scale / value.Y);
					}

					// Token: 0x0600025E RID: 606 RVA: 0x0001F9E0 File Offset: 0x0001DBE0
					public static HyperMEM.Vectors.Vec2.Vector2 operator /(HyperMEM.Vectors.Vec2.Vector2 value, HyperMEM.Vectors.Vec2.Vector2 scale)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(value.X / scale.X, value.Y / scale.Y);
					}

					// Token: 0x0600025F RID: 607 RVA: 0x0001FA14 File Offset: 0x0001DC14
					public static HyperMEM.Vectors.Vec2.Vector2 operator +(HyperMEM.Vectors.Vec2.Vector2 value, float scalar)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(value.X + scalar, value.Y + scalar);
					}

					// Token: 0x06000260 RID: 608 RVA: 0x0001FA3C File Offset: 0x0001DC3C
					public static HyperMEM.Vectors.Vec2.Vector2 operator +(float scalar, HyperMEM.Vectors.Vec2.Vector2 value)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(scalar + value.X, scalar + value.Y);
					}

					// Token: 0x06000261 RID: 609 RVA: 0x0001FA64 File Offset: 0x0001DC64
					public static HyperMEM.Vectors.Vec2.Vector2 operator -(HyperMEM.Vectors.Vec2.Vector2 value, float scalar)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(value.X - scalar, value.Y - scalar);
					}

					// Token: 0x06000262 RID: 610 RVA: 0x0001FA8C File Offset: 0x0001DC8C
					public static HyperMEM.Vectors.Vec2.Vector2 operator -(float scalar, HyperMEM.Vectors.Vec2.Vector2 value)
					{
						return new HyperMEM.Vectors.Vec2.Vector2(scalar - value.X, scalar - value.Y);
					}

					// Token: 0x06000263 RID: 611 RVA: 0x0001FAB4 File Offset: 0x0001DCB4
					public static bool operator ==(HyperMEM.Vectors.Vec2.Vector2 v1, HyperMEM.Vectors.Vec2.Vector2 v2)
					{
						return v1.X == v2.X && v1.Y == v2.Y;
					}

					// Token: 0x06000264 RID: 612 RVA: 0x0001FAE8 File Offset: 0x0001DCE8
					public static bool operator !=(HyperMEM.Vectors.Vec2.Vector2 v1, HyperMEM.Vectors.Vec2.Vector2 v2)
					{
						return v1.X != v2.X || v1.Y != v2.Y;
					}

					// Token: 0x06000265 RID: 613 RVA: 0x0001FB1C File Offset: 0x0001DD1C
					public override string ToString()
					{
						return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1}", this.X, this.Y);
					}

					// Token: 0x04000580 RID: 1408
					public float X;

					// Token: 0x04000581 RID: 1409
					public float Y;

					// Token: 0x04000582 RID: 1410
					public static readonly int SizeInBytes = Marshal.SizeOf<HyperMEM.Vectors.Vec2.Vector2>();

					// Token: 0x04000583 RID: 1411
					public static readonly HyperMEM.Vectors.Vec2.Vector2 Zero = new HyperMEM.Vectors.Vec2.Vector2(0f);

					// Token: 0x04000584 RID: 1412
					public static readonly HyperMEM.Vectors.Vec2.Vector2 UnitX = new HyperMEM.Vectors.Vec2.Vector2(1f, 0f);

					// Token: 0x04000585 RID: 1413
					public static readonly HyperMEM.Vectors.Vec2.Vector2 UnitY = new HyperMEM.Vectors.Vec2.Vector2(0f, 1f);

					// Token: 0x04000586 RID: 1414
					public static readonly HyperMEM.Vectors.Vec2.Vector2 One = new HyperMEM.Vectors.Vec2.Vector2(1f, 1f);
				}
			}

			// Token: 0x0200005F RID: 95
			public class Vec3
			{
				// Token: 0x02000066 RID: 102
				[StructLayout(LayoutKind.Sequential, Pack = 4)]
				public struct Vector3
				{
					// Token: 0x06000267 RID: 615 RVA: 0x0001FBB6 File Offset: 0x0001DDB6
					public Vector3(float value)
					{
						this.X = value;
						this.Y = value;
						this.Z = value;
					}

					// Token: 0x06000268 RID: 616 RVA: 0x0001FBCE File Offset: 0x0001DDCE
					public Vector3(float x, float y, float z)
					{
						this.X = x;
						this.Y = y;
						this.Z = z;
					}

					// Token: 0x1700006A RID: 106
					// (get) Token: 0x06000269 RID: 617 RVA: 0x0001FBE8 File Offset: 0x0001DDE8
					public bool IsZero
					{
						get
						{
							return this.X == 0f && this.Y == 0f && this.Z == 0f;
						}
					}

					// Token: 0x0600026A RID: 618 RVA: 0x0001FC24 File Offset: 0x0001DE24
					public float Length()
					{
						return (float)Math.Sqrt((double)(this.X * this.X + this.Y * this.Y + this.Z * this.Z));
					}

					// Token: 0x0600026B RID: 619 RVA: 0x0001FC68 File Offset: 0x0001DE68
					public float LengthSquared()
					{
						return this.X * this.X + this.Y * this.Y + this.Z * this.Z;
					}

					// Token: 0x0600026C RID: 620 RVA: 0x0001FCA4 File Offset: 0x0001DEA4
					public void Normalize()
					{
						float num = this.Length();
						bool flag = num != 0f;
						if (flag)
						{
							float num2 = 1f / num;
							this.X *= num2;
							this.Y *= num2;
							this.Z *= num2;
						}
					}

					// Token: 0x0600026D RID: 621 RVA: 0x0001FCFC File Offset: 0x0001DEFC
					public float[] ToArray()
					{
						return new float[]
						{
							this.X,
							this.Y,
							this.Z
						};
					}

					// Token: 0x0600026E RID: 622 RVA: 0x0001FD30 File Offset: 0x0001DF30
					public static HyperMEM.Vectors.Vec3.Vector3 Add(HyperMEM.Vectors.Vec3.Vector3 left, HyperMEM.Vectors.Vec3.Vector3 right)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
					}

					// Token: 0x0600026F RID: 623 RVA: 0x0001FD70 File Offset: 0x0001DF70
					public static HyperMEM.Vectors.Vec3.Vector3 Subtract(HyperMEM.Vectors.Vec3.Vector3 left, HyperMEM.Vectors.Vec3.Vector3 right)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
					}

					// Token: 0x06000270 RID: 624 RVA: 0x0001FDB0 File Offset: 0x0001DFB0
					public static HyperMEM.Vectors.Vec3.Vector3 Multiply(HyperMEM.Vectors.Vec3.Vector3 value, float scale)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(value.X * scale, value.Y * scale, value.Z * scale);
					}

					// Token: 0x06000271 RID: 625 RVA: 0x0001FDE0 File Offset: 0x0001DFE0
					public static HyperMEM.Vectors.Vec3.Vector3 Multiply(HyperMEM.Vectors.Vec3.Vector3 left, HyperMEM.Vectors.Vec3.Vector3 right)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
					}

					// Token: 0x06000272 RID: 626 RVA: 0x0001FE20 File Offset: 0x0001E020
					public static HyperMEM.Vectors.Vec3.Vector3 Divide(HyperMEM.Vectors.Vec3.Vector3 value, float scale)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(value.X / scale, value.Y / scale, value.Z / scale);
					}

					// Token: 0x06000273 RID: 627 RVA: 0x0001FE50 File Offset: 0x0001E050
					public static HyperMEM.Vectors.Vec3.Vector3 Divide(HyperMEM.Vectors.Vec3.Vector3 left, HyperMEM.Vectors.Vec3.Vector3 right)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
					}

					// Token: 0x06000274 RID: 628 RVA: 0x0001FE90 File Offset: 0x0001E090
					public static HyperMEM.Vectors.Vec3.Vector3 Negate(HyperMEM.Vectors.Vec3.Vector3 value)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(-value.X, -value.Y, -value.Z);
					}

					// Token: 0x06000275 RID: 629 RVA: 0x0001FEBC File Offset: 0x0001E0BC
					public static HyperMEM.Vectors.Vec3.Vector3 Abs(HyperMEM.Vectors.Vec3.Vector3 value)
					{
						return new HyperMEM.Vectors.Vec3.Vector3((value.X > 0f) ? value.X : (-value.X), (value.Y > 0f) ? value.Y : (-value.Y), (value.Z > 0f) ? value.Z : (-value.Z));
					}

					// Token: 0x06000276 RID: 630 RVA: 0x0001FF28 File Offset: 0x0001E128
					public static HyperMEM.Vectors.Vec3.Vector3 Clamp(HyperMEM.Vectors.Vec3.Vector3 value, HyperMEM.Vectors.Vec3.Vector3 min, HyperMEM.Vectors.Vec3.Vector3 max)
					{
						float num = value.X;
						num = ((num > max.X) ? max.X : num);
						num = ((num < min.X) ? min.X : num);
						float num2 = value.Y;
						num2 = ((num2 > max.Y) ? max.Y : num2);
						num2 = ((num2 < min.Y) ? min.Y : num2);
						float num3 = value.Z;
						num3 = ((num3 > max.Z) ? max.Z : num3);
						num3 = ((num3 < min.Z) ? min.Z : num3);
						return new HyperMEM.Vectors.Vec3.Vector3(num, num2, num3);
					}

					// Token: 0x06000277 RID: 631 RVA: 0x0001FFCC File Offset: 0x0001E1CC
					public static float Distance(HyperMEM.Vectors.Vec3.Vector3 value1, HyperMEM.Vectors.Vec3.Vector3 value2)
					{
						float num = value1.X - value2.X;
						float num2 = value1.Y - value2.Y;
						float num3 = value1.Z - value2.Z;
						return (float)Math.Sqrt((double)(num * num + num2 * num2 + num3 * num3));
					}

					// Token: 0x06000278 RID: 632 RVA: 0x0002001C File Offset: 0x0001E21C
					public static float Dot(HyperMEM.Vectors.Vec3.Vector3 left, HyperMEM.Vectors.Vec3.Vector3 right)
					{
						return left.X * right.X + left.Y * right.Y + left.Z * right.Z;
					}

					// Token: 0x06000279 RID: 633 RVA: 0x00020058 File Offset: 0x0001E258
					public static HyperMEM.Vectors.Vec3.Vector3 operator +(HyperMEM.Vectors.Vec3.Vector3 left, HyperMEM.Vectors.Vec3.Vector3 right)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
					}

					// Token: 0x0600027A RID: 634 RVA: 0x00020098 File Offset: 0x0001E298
					public static HyperMEM.Vectors.Vec3.Vector3 operator *(HyperMEM.Vectors.Vec3.Vector3 left, HyperMEM.Vectors.Vec3.Vector3 right)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
					}

					// Token: 0x0600027B RID: 635 RVA: 0x000200D8 File Offset: 0x0001E2D8
					public static HyperMEM.Vectors.Vec3.Vector3 operator +(HyperMEM.Vectors.Vec3.Vector3 value)
					{
						return value;
					}

					// Token: 0x0600027C RID: 636 RVA: 0x000200EC File Offset: 0x0001E2EC
					public static HyperMEM.Vectors.Vec3.Vector3 operator -(HyperMEM.Vectors.Vec3.Vector3 left, HyperMEM.Vectors.Vec3.Vector3 right)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
					}

					// Token: 0x0600027D RID: 637 RVA: 0x0002012C File Offset: 0x0001E32C
					public static HyperMEM.Vectors.Vec3.Vector3 operator -(HyperMEM.Vectors.Vec3.Vector3 value)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(-value.X, -value.Y, -value.Z);
					}

					// Token: 0x0600027E RID: 638 RVA: 0x00020158 File Offset: 0x0001E358
					public static HyperMEM.Vectors.Vec3.Vector3 operator *(float scale, HyperMEM.Vectors.Vec3.Vector3 value)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(value.X * scale, value.Y * scale, value.Z * scale);
					}

					// Token: 0x0600027F RID: 639 RVA: 0x00020188 File Offset: 0x0001E388
					public static HyperMEM.Vectors.Vec3.Vector3 operator *(HyperMEM.Vectors.Vec3.Vector3 value, float scale)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(value.X * scale, value.Y * scale, value.Z * scale);
					}

					// Token: 0x06000280 RID: 640 RVA: 0x000201B8 File Offset: 0x0001E3B8
					public static HyperMEM.Vectors.Vec3.Vector3 operator /(HyperMEM.Vectors.Vec3.Vector3 value, float scale)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(value.X / scale, value.Y / scale, value.Z / scale);
					}

					// Token: 0x06000281 RID: 641 RVA: 0x000201E8 File Offset: 0x0001E3E8
					public static HyperMEM.Vectors.Vec3.Vector3 operator /(float scale, HyperMEM.Vectors.Vec3.Vector3 value)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(scale / value.X, scale / value.Y, scale / value.Z);
					}

					// Token: 0x06000282 RID: 642 RVA: 0x00020218 File Offset: 0x0001E418
					public static HyperMEM.Vectors.Vec3.Vector3 operator /(HyperMEM.Vectors.Vec3.Vector3 value, HyperMEM.Vectors.Vec3.Vector3 scale)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(value.X / scale.X, value.Y / scale.Y, value.Z / scale.Z);
					}

					// Token: 0x06000283 RID: 643 RVA: 0x00020258 File Offset: 0x0001E458
					public static HyperMEM.Vectors.Vec3.Vector3 operator +(HyperMEM.Vectors.Vec3.Vector3 value, float scalar)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(value.X + scalar, value.Y + scalar, value.Z + scalar);
					}

					// Token: 0x06000284 RID: 644 RVA: 0x00020288 File Offset: 0x0001E488
					public static HyperMEM.Vectors.Vec3.Vector3 operator +(float scalar, HyperMEM.Vectors.Vec3.Vector3 value)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(scalar + value.X, scalar + value.Y, scalar + value.Z);
					}

					// Token: 0x06000285 RID: 645 RVA: 0x000202B8 File Offset: 0x0001E4B8
					public static HyperMEM.Vectors.Vec3.Vector3 operator -(HyperMEM.Vectors.Vec3.Vector3 value, float scalar)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(value.X - scalar, value.Y - scalar, value.Z - scalar);
					}

					// Token: 0x06000286 RID: 646 RVA: 0x000202E8 File Offset: 0x0001E4E8
					public static HyperMEM.Vectors.Vec3.Vector3 operator -(float scalar, HyperMEM.Vectors.Vec3.Vector3 value)
					{
						return new HyperMEM.Vectors.Vec3.Vector3(scalar - value.X, scalar - value.Y, scalar - value.Z);
					}

					// Token: 0x06000287 RID: 647 RVA: 0x00020318 File Offset: 0x0001E518
					public static bool operator ==(HyperMEM.Vectors.Vec3.Vector3 v1, HyperMEM.Vectors.Vec3.Vector3 v2)
					{
						return v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z;
					}

					// Token: 0x06000288 RID: 648 RVA: 0x00020358 File Offset: 0x0001E558
					public static bool operator !=(HyperMEM.Vectors.Vec3.Vector3 v1, HyperMEM.Vectors.Vec3.Vector3 v2)
					{
						return v1.X != v2.X || v1.Y != v2.Y || v1.Z != v2.Z;
					}

					// Token: 0x06000289 RID: 649 RVA: 0x0002039C File Offset: 0x0001E59C
					public override string ToString()
					{
						return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1} Z:{2}", this.X, this.Y, this.Z);
					}

					// Token: 0x04000587 RID: 1415
					public float X;

					// Token: 0x04000588 RID: 1416
					public float Y;

					// Token: 0x04000589 RID: 1417
					public float Z;

					// Token: 0x0400058A RID: 1418
					public static readonly int SizeInBytes = Marshal.SizeOf<HyperMEM.Vectors.Vec3.Vector3>();

					// Token: 0x0400058B RID: 1419
					public static readonly HyperMEM.Vectors.Vec3.Vector3 Zero = new HyperMEM.Vectors.Vec3.Vector3(0f);

					// Token: 0x0400058C RID: 1420
					public static readonly HyperMEM.Vectors.Vec3.Vector3 UnitX = new HyperMEM.Vectors.Vec3.Vector3(1f, 0f, 0f);

					// Token: 0x0400058D RID: 1421
					public static readonly HyperMEM.Vectors.Vec3.Vector3 UnitY = new HyperMEM.Vectors.Vec3.Vector3(0f, 1f, 0f);

					// Token: 0x0400058E RID: 1422
					public static readonly HyperMEM.Vectors.Vec3.Vector3 UnitZ = new HyperMEM.Vectors.Vec3.Vector3(0f, 0f, 1f);

					// Token: 0x0400058F RID: 1423
					public static readonly HyperMEM.Vectors.Vec3.Vector3 One = new HyperMEM.Vectors.Vec3.Vector3(1f, 1f, 1f);

					// Token: 0x04000590 RID: 1424
					public static readonly HyperMEM.Vectors.Vec3.Vector3 Up = new HyperMEM.Vectors.Vec3.Vector3(0f, 1f, 0f);

					// Token: 0x04000591 RID: 1425
					public static readonly HyperMEM.Vectors.Vec3.Vector3 Down = new HyperMEM.Vectors.Vec3.Vector3(0f, -1f, 0f);

					// Token: 0x04000592 RID: 1426
					public static readonly HyperMEM.Vectors.Vec3.Vector3 Left = new HyperMEM.Vectors.Vec3.Vector3(-1f, 0f, 0f);

					// Token: 0x04000593 RID: 1427
					public static readonly HyperMEM.Vectors.Vec3.Vector3 Right = new HyperMEM.Vectors.Vec3.Vector3(1f, 0f, 0f);

					// Token: 0x04000594 RID: 1428
					public static readonly HyperMEM.Vectors.Vec3.Vector3 ForwardRH = new HyperMEM.Vectors.Vec3.Vector3(0f, 0f, -1f);

					// Token: 0x04000595 RID: 1429
					public static readonly HyperMEM.Vectors.Vec3.Vector3 ForwardLH = new HyperMEM.Vectors.Vec3.Vector3(0f, 0f, 1f);

					// Token: 0x04000596 RID: 1430
					public static readonly HyperMEM.Vectors.Vec3.Vector3 BackwardRH = new HyperMEM.Vectors.Vec3.Vector3(0f, 0f, 1f);

					// Token: 0x04000597 RID: 1431
					public static readonly HyperMEM.Vectors.Vec3.Vector3 BackwardLH = new HyperMEM.Vectors.Vec3.Vector3(0f, 0f, -1f);
				}
			}

			// Token: 0x02000060 RID: 96
			public class Vec4
			{
				// Token: 0x02000067 RID: 103
				[StructLayout(LayoutKind.Sequential, Pack = 4)]
				public struct Vector4
				{
					// Token: 0x0600028B RID: 651 RVA: 0x00020532 File Offset: 0x0001E732
					public Vector4(float value)
					{
						this.X = value;
						this.Y = value;
						this.Z = value;
						this.W = value;
					}

					// Token: 0x0600028C RID: 652 RVA: 0x00020551 File Offset: 0x0001E751
					public Vector4(float x, float y, float z, float w)
					{
						this.X = x;
						this.Y = y;
						this.Z = z;
						this.W = w;
					}

					// Token: 0x1700006B RID: 107
					// (get) Token: 0x0600028D RID: 653 RVA: 0x00020574 File Offset: 0x0001E774
					public bool IsZero
					{
						get
						{
							return this.X == 0f && this.Y == 0f && this.Z == 0f && this.W == 0f;
						}
					}

					// Token: 0x0600028E RID: 654 RVA: 0x000205C0 File Offset: 0x0001E7C0
					public float Length()
					{
						return (float)Math.Sqrt((double)(this.X * this.X + this.Y * this.Y + this.Z * this.Z + this.W * this.W));
					}

					// Token: 0x0600028F RID: 655 RVA: 0x00020610 File Offset: 0x0001E810
					public float LengthSquared()
					{
						return this.X * this.X + this.Y * this.Y + this.Z * this.Z + this.W * this.W;
					}

					// Token: 0x06000290 RID: 656 RVA: 0x0002065C File Offset: 0x0001E85C
					public void Normalize()
					{
						float num = this.Length();
						bool flag = num != 0f;
						if (flag)
						{
							float num2 = 1f / num;
							this.X *= num2;
							this.Y *= num2;
							this.Z *= num2;
							this.W *= num2;
						}
					}

					// Token: 0x06000291 RID: 657 RVA: 0x000206C4 File Offset: 0x0001E8C4
					public float[] ToArray()
					{
						return new float[]
						{
							this.X,
							this.Y,
							this.Z,
							this.W
						};
					}

					// Token: 0x06000292 RID: 658 RVA: 0x00020700 File Offset: 0x0001E900
					public static HyperMEM.Vectors.Vec4.Vector4 Add(HyperMEM.Vectors.Vec4.Vector4 left, HyperMEM.Vectors.Vec4.Vector4 right)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
					}

					// Token: 0x06000293 RID: 659 RVA: 0x0002074C File Offset: 0x0001E94C
					public static HyperMEM.Vectors.Vec4.Vector4 Subtract(HyperMEM.Vectors.Vec4.Vector4 left, HyperMEM.Vectors.Vec4.Vector4 right)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
					}

					// Token: 0x06000294 RID: 660 RVA: 0x00020798 File Offset: 0x0001E998
					public static HyperMEM.Vectors.Vec4.Vector4 Multiply(HyperMEM.Vectors.Vec4.Vector4 value, float scale)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(value.X * scale, value.Y * scale, value.Z * scale, value.W * scale);
					}

					// Token: 0x06000295 RID: 661 RVA: 0x000207D0 File Offset: 0x0001E9D0
					public static HyperMEM.Vectors.Vec4.Vector4 Multiply(HyperMEM.Vectors.Vec4.Vector4 left, HyperMEM.Vectors.Vec4.Vector4 right)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);
					}

					// Token: 0x06000296 RID: 662 RVA: 0x0002081C File Offset: 0x0001EA1C
					public static HyperMEM.Vectors.Vec4.Vector4 Divide(HyperMEM.Vectors.Vec4.Vector4 value, float scale)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(value.X / scale, value.Y / scale, value.Z / scale, value.W / scale);
					}

					// Token: 0x06000297 RID: 663 RVA: 0x00020854 File Offset: 0x0001EA54
					public static HyperMEM.Vectors.Vec4.Vector4 Divide(HyperMEM.Vectors.Vec4.Vector4 left, HyperMEM.Vectors.Vec4.Vector4 right)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(left.X / right.X, left.Y / right.Y, left.Z / right.Z, left.W / right.W);
					}

					// Token: 0x06000298 RID: 664 RVA: 0x000208A0 File Offset: 0x0001EAA0
					public static HyperMEM.Vectors.Vec4.Vector4 Negate(HyperMEM.Vectors.Vec4.Vector4 value)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(-value.X, -value.Y, -value.Z, -value.W);
					}

					// Token: 0x06000299 RID: 665 RVA: 0x000208D4 File Offset: 0x0001EAD4
					public static HyperMEM.Vectors.Vec4.Vector4 Abs(HyperMEM.Vectors.Vec4.Vector4 value)
					{
						return new HyperMEM.Vectors.Vec4.Vector4((value.X > 0f) ? value.X : (-value.X), (value.Y > 0f) ? value.Y : (-value.Y), (value.Z > 0f) ? value.Z : (-value.Z), (value.W > 0f) ? value.W : (-value.W));
					}

					// Token: 0x0600029A RID: 666 RVA: 0x0002095C File Offset: 0x0001EB5C
					public static HyperMEM.Vectors.Vec4.Vector4 Clamp(HyperMEM.Vectors.Vec4.Vector4 value, HyperMEM.Vectors.Vec4.Vector4 min, HyperMEM.Vectors.Vec4.Vector4 max)
					{
						float num = value.X;
						num = ((num > max.X) ? max.X : num);
						num = ((num < min.X) ? min.X : num);
						float num2 = value.Y;
						num2 = ((num2 > max.Y) ? max.Y : num2);
						num2 = ((num2 < min.Y) ? min.Y : num2);
						float num3 = value.Z;
						num3 = ((num3 > max.Z) ? max.Z : num3);
						num3 = ((num3 < min.Z) ? min.Z : num3);
						float num4 = value.W;
						num4 = ((num4 > max.W) ? max.W : num4);
						num4 = ((num4 < min.W) ? min.W : num4);
						return new HyperMEM.Vectors.Vec4.Vector4(num, num2, num3, num4);
					}

					// Token: 0x0600029B RID: 667 RVA: 0x00020A30 File Offset: 0x0001EC30
					public static float Distance(HyperMEM.Vectors.Vec4.Vector4 value1, HyperMEM.Vectors.Vec4.Vector4 value2)
					{
						float num = value1.X - value2.X;
						float num2 = value1.Y - value2.Y;
						float num3 = value1.Z - value2.Z;
						float num4 = value1.W - value2.W;
						return (float)Math.Sqrt((double)(num * num + num2 * num2 + num3 * num3 + num4 * num4));
					}

					// Token: 0x0600029C RID: 668 RVA: 0x00020A94 File Offset: 0x0001EC94
					public static float Dot(HyperMEM.Vectors.Vec4.Vector4 left, HyperMEM.Vectors.Vec4.Vector4 right)
					{
						return left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;
					}

					// Token: 0x0600029D RID: 669 RVA: 0x00020AE0 File Offset: 0x0001ECE0
					public static HyperMEM.Vectors.Vec4.Vector4 operator +(HyperMEM.Vectors.Vec4.Vector4 left, HyperMEM.Vectors.Vec4.Vector4 right)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
					}

					// Token: 0x0600029E RID: 670 RVA: 0x00020B2C File Offset: 0x0001ED2C
					public static HyperMEM.Vectors.Vec4.Vector4 operator *(HyperMEM.Vectors.Vec4.Vector4 left, HyperMEM.Vectors.Vec4.Vector4 right)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(left.X * right.X, left.Y * right.Y, left.Z * right.Z, left.W * right.W);
					}

					// Token: 0x0600029F RID: 671 RVA: 0x00020B78 File Offset: 0x0001ED78
					public static HyperMEM.Vectors.Vec4.Vector4 operator +(HyperMEM.Vectors.Vec4.Vector4 value)
					{
						return value;
					}

					// Token: 0x060002A0 RID: 672 RVA: 0x00020B8C File Offset: 0x0001ED8C
					public static HyperMEM.Vectors.Vec4.Vector4 operator -(HyperMEM.Vectors.Vec4.Vector4 left, HyperMEM.Vectors.Vec4.Vector4 right)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
					}

					// Token: 0x060002A1 RID: 673 RVA: 0x00020BD8 File Offset: 0x0001EDD8
					public static HyperMEM.Vectors.Vec4.Vector4 operator -(HyperMEM.Vectors.Vec4.Vector4 value)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(-value.X, -value.Y, -value.Z, -value.W);
					}

					// Token: 0x060002A2 RID: 674 RVA: 0x00020C0C File Offset: 0x0001EE0C
					public static HyperMEM.Vectors.Vec4.Vector4 operator *(float scale, HyperMEM.Vectors.Vec4.Vector4 value)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(value.X * scale, value.Y * scale, value.Z * scale, value.W * scale);
					}

					// Token: 0x060002A3 RID: 675 RVA: 0x00020C44 File Offset: 0x0001EE44
					public static HyperMEM.Vectors.Vec4.Vector4 operator *(HyperMEM.Vectors.Vec4.Vector4 value, float scale)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(value.X * scale, value.Y * scale, value.Z * scale, value.W * scale);
					}

					// Token: 0x060002A4 RID: 676 RVA: 0x00020C7C File Offset: 0x0001EE7C
					public static HyperMEM.Vectors.Vec4.Vector4 operator /(HyperMEM.Vectors.Vec4.Vector4 value, float scale)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(value.X / scale, value.Y / scale, value.Z / scale, value.W / scale);
					}

					// Token: 0x060002A5 RID: 677 RVA: 0x00020CB4 File Offset: 0x0001EEB4
					public static HyperMEM.Vectors.Vec4.Vector4 operator /(float scale, HyperMEM.Vectors.Vec4.Vector4 value)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(scale / value.X, scale / value.Y, scale / value.Z, scale / value.W);
					}

					// Token: 0x060002A6 RID: 678 RVA: 0x00020CEC File Offset: 0x0001EEEC
					public static HyperMEM.Vectors.Vec4.Vector4 operator /(HyperMEM.Vectors.Vec4.Vector4 value, HyperMEM.Vectors.Vec4.Vector4 scale)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(value.X / scale.X, value.Y / scale.Y, value.Z / scale.Z, value.W / scale.W);
					}

					// Token: 0x060002A7 RID: 679 RVA: 0x00020D38 File Offset: 0x0001EF38
					public static HyperMEM.Vectors.Vec4.Vector4 operator +(HyperMEM.Vectors.Vec4.Vector4 value, float scalar)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(value.X + scalar, value.Y + scalar, value.Z + scalar, value.W + scalar);
					}

					// Token: 0x060002A8 RID: 680 RVA: 0x00020D70 File Offset: 0x0001EF70
					public static HyperMEM.Vectors.Vec4.Vector4 operator +(float scalar, HyperMEM.Vectors.Vec4.Vector4 value)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(scalar + value.X, scalar + value.Y, scalar + value.Z, scalar + value.W);
					}

					// Token: 0x060002A9 RID: 681 RVA: 0x00020DA8 File Offset: 0x0001EFA8
					public static HyperMEM.Vectors.Vec4.Vector4 operator -(HyperMEM.Vectors.Vec4.Vector4 value, float scalar)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(value.X - scalar, value.Y - scalar, value.Z - scalar, value.W - scalar);
					}

					// Token: 0x060002AA RID: 682 RVA: 0x00020DE0 File Offset: 0x0001EFE0
					public static HyperMEM.Vectors.Vec4.Vector4 operator -(float scalar, HyperMEM.Vectors.Vec4.Vector4 value)
					{
						return new HyperMEM.Vectors.Vec4.Vector4(scalar - value.X, scalar - value.Y, scalar - value.Z, scalar - value.W);
					}

					// Token: 0x060002AB RID: 683 RVA: 0x00020E18 File Offset: 0x0001F018
					public static bool operator ==(HyperMEM.Vectors.Vec4.Vector4 v1, HyperMEM.Vectors.Vec4.Vector4 v2)
					{
						return v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z && v1.W == v2.W;
					}

					// Token: 0x060002AC RID: 684 RVA: 0x00020E68 File Offset: 0x0001F068
					public static bool operator !=(HyperMEM.Vectors.Vec4.Vector4 v1, HyperMEM.Vectors.Vec4.Vector4 v2)
					{
						return v1.X != v2.X || v1.Y != v2.Y || v1.Z != v2.Z || v1.W != v2.W;
					}

					// Token: 0x060002AD RID: 685 RVA: 0x00020EB8 File Offset: 0x0001F0B8
					public override string ToString()
					{
						return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1} Z:{2} W:{3}", new object[]
						{
							this.X,
							this.Y,
							this.Z,
							this.W
						});
					}

					// Token: 0x04000598 RID: 1432
					public float X;

					// Token: 0x04000599 RID: 1433
					public float Y;

					// Token: 0x0400059A RID: 1434
					public float Z;

					// Token: 0x0400059B RID: 1435
					public float W;

					// Token: 0x0400059C RID: 1436
					public static readonly int SizeInBytes = Marshal.SizeOf<HyperMEM.Vectors.Vec4.Vector4>();

					// Token: 0x0400059D RID: 1437
					public static readonly HyperMEM.Vectors.Vec4.Vector4 Zero = default(HyperMEM.Vectors.Vec4.Vector4);

					// Token: 0x0400059E RID: 1438
					public static readonly HyperMEM.Vectors.Vec4.Vector4 UnitX = new HyperMEM.Vectors.Vec4.Vector4(1f, 0f, 0f, 0f);

					// Token: 0x0400059F RID: 1439
					public static readonly HyperMEM.Vectors.Vec4.Vector4 UnitY = new HyperMEM.Vectors.Vec4.Vector4(0f, 1f, 0f, 0f);

					// Token: 0x040005A0 RID: 1440
					public static readonly HyperMEM.Vectors.Vec4.Vector4 UnitZ = new HyperMEM.Vectors.Vec4.Vector4(0f, 0f, 1f, 0f);

					// Token: 0x040005A1 RID: 1441
					public static readonly HyperMEM.Vectors.Vec4.Vector4 UnitW = new HyperMEM.Vectors.Vec4.Vector4(0f, 0f, 0f, 1f);

					// Token: 0x040005A2 RID: 1442
					public static readonly HyperMEM.Vectors.Vec4.Vector4 One = new HyperMEM.Vectors.Vec4.Vector4(1f, 1f, 1f, 1f);
				}
			}

			// Token: 0x02000061 RID: 97
			public class View
			{
				// Token: 0x02000068 RID: 104
				[StructLayout(LayoutKind.Sequential, Pack = 4)]
				public struct Matrix
				{
					// Token: 0x060002AF RID: 687 RVA: 0x00020FD0 File Offset: 0x0001F1D0
					public Matrix(float value)
					{
						this.M11 = value;
						this.M12 = value;
						this.M13 = value;
						this.M14 = value;
						this.M21 = value;
						this.M22 = value;
						this.M23 = value;
						this.M24 = value;
						this.M31 = value;
						this.M32 = value;
						this.M33 = value;
						this.M34 = value;
						this.M41 = value;
						this.M42 = value;
						this.M43 = value;
						this.M44 = value;
					}

					// Token: 0x060002B0 RID: 688 RVA: 0x00021050 File Offset: 0x0001F250
					public Matrix(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
					{
						this.M11 = m11;
						this.M12 = m12;
						this.M13 = m13;
						this.M14 = m14;
						this.M21 = m21;
						this.M22 = m22;
						this.M23 = m23;
						this.M24 = m24;
						this.M31 = m31;
						this.M32 = m32;
						this.M33 = m33;
						this.M34 = m34;
						this.M41 = m41;
						this.M42 = m42;
						this.M43 = m43;
						this.M44 = m44;
					}

					// Token: 0x060002B1 RID: 689 RVA: 0x000210DC File Offset: 0x0001F2DC
					public static HyperMEM.Vectors.View.Matrix Transpose(HyperMEM.Vectors.View.Matrix value)
					{
						return new HyperMEM.Vectors.View.Matrix
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

					// Token: 0x060002B2 RID: 690 RVA: 0x000211CC File Offset: 0x0001F3CC
					public override string ToString()
					{
						return string.Format(CultureInfo.CurrentCulture, "M11:{0} M12:{1} M13:{2} M14:{3} M21:{4} M22:{5} M23:{6} M24:{7} M31:{8} M32:{9} M33:{10} M34:{11} M41:{12} M42:{13} M43:{14} M44:{15}", new object[]
						{
							this.M11,
							this.M12,
							this.M13,
							this.M14,
							this.M21,
							this.M22,
							this.M23,
							this.M24,
							this.M31,
							this.M32,
							this.M33,
							this.M34,
							this.M41,
							this.M42,
							this.M43,
							this.M44
						});
					}

					// Token: 0x040005A3 RID: 1443
					public float M11;

					// Token: 0x040005A4 RID: 1444
					public float M12;

					// Token: 0x040005A5 RID: 1445
					public float M13;

					// Token: 0x040005A6 RID: 1446
					public float M14;

					// Token: 0x040005A7 RID: 1447
					public float M21;

					// Token: 0x040005A8 RID: 1448
					public float M22;

					// Token: 0x040005A9 RID: 1449
					public float M23;

					// Token: 0x040005AA RID: 1450
					public float M24;

					// Token: 0x040005AB RID: 1451
					public float M31;

					// Token: 0x040005AC RID: 1452
					public float M32;

					// Token: 0x040005AD RID: 1453
					public float M33;

					// Token: 0x040005AE RID: 1454
					public float M34;

					// Token: 0x040005AF RID: 1455
					public float M41;

					// Token: 0x040005B0 RID: 1456
					public float M42;

					// Token: 0x040005B1 RID: 1457
					public float M43;

					// Token: 0x040005B2 RID: 1458
					public float M44;
				}
			}
		}
	}
}
