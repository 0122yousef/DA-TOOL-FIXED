using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32.SafeHandles;
using PornHub.Memory.Logic.Interfaces;
using PornHub.Memory.Native;
using PornHub.Memory.Native.Enums;

namespace PornHub.Memory.Logic
{
	// Token: 0x02000030 RID: 48
	public class MDriverIoShared : MIDriverIo, IDisposable
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0001B9C0 File Offset: 0x00019BC0
		public MIDriver Driver { get; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0001B9C8 File Offset: 0x00019BC8
		// (set) Token: 0x06000155 RID: 341 RVA: 0x0001B9D0 File Offset: 0x00019BD0
		public SafeFileHandle Handle { get; private set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0001B9D9 File Offset: 0x00019BD9
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0001B9E1 File Offset: 0x00019BE1
		public IntPtr MapAddress { get; private set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0001B9EA File Offset: 0x00019BEA
		// (set) Token: 0x06000159 RID: 345 RVA: 0x0001B9F2 File Offset: 0x00019BF2
		public AutoResetEvent FirstEvent { get; private set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0001B9FB File Offset: 0x00019BFB
		// (set) Token: 0x0600015B RID: 347 RVA: 0x0001BA03 File Offset: 0x00019C03
		public AutoResetEvent SecondEvent { get; private set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0001BA0C File Offset: 0x00019C0C
		// (set) Token: 0x0600015D RID: 349 RVA: 0x0001BA14 File Offset: 0x00019C14
		public EventHandler Connected { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0001BA1D File Offset: 0x00019C1D
		// (set) Token: 0x0600015F RID: 351 RVA: 0x0001BA25 File Offset: 0x00019C25
		public EventHandler Disconnected { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0001BA2E File Offset: 0x00019C2E
		// (set) Token: 0x06000161 RID: 353 RVA: 0x0001BA36 File Offset: 0x00019C36
		public EventHandler Disposed { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0001BA3F File Offset: 0x00019C3F
		// (set) Token: 0x06000163 RID: 355 RVA: 0x0001BA47 File Offset: 0x00019C47
		public object Lock { get; private set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0001BA50 File Offset: 0x00019C50
		public bool IsConnected
		{
			get
			{
				bool flag = this.FirstEvent != null;
				if (flag)
				{
					bool flag2 = !this.FirstEvent.SafeWaitHandle.IsInvalid && !this.FirstEvent.SafeWaitHandle.IsClosed;
					if (flag2)
					{
						return true;
					}
				}
				bool flag3 = this.SecondEvent != null;
				if (flag3)
				{
					bool flag4 = !this.SecondEvent.SafeWaitHandle.IsInvalid && !this.SecondEvent.SafeWaitHandle.IsClosed;
					if (flag4)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0001BAE5 File Offset: 0x00019CE5
		// (set) Token: 0x06000166 RID: 358 RVA: 0x0001BAED File Offset: 0x00019CED
		public bool IsDisposed { get; private set; }

		// Token: 0x06000167 RID: 359 RVA: 0x0001BAF6 File Offset: 0x00019CF6
		protected MDriverIoShared()
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0001BB00 File Offset: 0x00019D00
		public MDriverIoShared(MIDriver Driver)
		{
			this.Lock = new object();
			this.Driver = Driver;
			bool flag = this.Driver.Config.SharedMemory.ProcessAddr > 0UL;
			if (!flag)
			{
				this.MapAddress = Marshal.AllocHGlobal(4096);
				bool flag2 = this.MapAddress == IntPtr.Zero;
				if (flag2)
				{
					throw new InsufficientMemoryException();
				}
				this.Driver.Config.SharedMemory.ProcessAddr = (ulong)this.MapAddress.ToInt64();
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0001BB98 File Offset: 0x00019D98
		public void Connect()
		{
			bool isConnected = this.IsConnected;
			if (!isConnected)
			{
				IntPtr intPtr = (IntPtr)0;
				IntPtr intPtr2 = (IntPtr)0;
				OBJECT_ATTRIBUTES object_ATTRIBUTES = new OBJECT_ATTRIBUTES(this.Driver.Config.SharedMemory.FirstEventName, 0U);
				OBJECT_ATTRIBUTES object_ATTRIBUTES2 = new OBJECT_ATTRIBUTES(this.Driver.Config.SharedMemory.SecondEventName, 0U);
				GCHandle gchandle = GCHandle.Alloc(object_ATTRIBUTES, GCHandleType.Pinned);
				GCHandle gchandle2 = GCHandle.Alloc(object_ATTRIBUTES2, GCHandleType.Pinned);
				NtStatus ntStatus = (NtStatus)MDriverIoShared.NtOpenEvent(ref intPtr, 2031619U, gchandle.AddrOfPinnedObject());
				bool flag = ntStatus > NtStatus.Success;
				if (flag)
				{
					gchandle.Free();
					gchandle2.Free();
					bool flag2 = intPtr != IntPtr.Zero;
					if (flag2)
					{
						MDriverIoShared.NtClose(intPtr);
					}
					bool flag3 = intPtr2 != IntPtr.Zero;
					if (flag3)
					{
						MDriverIoShared.NtClose(intPtr2);
					}
					Log.Error(typeof(MDriverIoShared), "Failed to open the first event object. [" + ntStatus.ToString() + "]");
				}
				else
				{
					ntStatus = (NtStatus)MDriverIoShared.NtOpenEvent(ref intPtr2, 2031619U, gchandle2.AddrOfPinnedObject());
					bool flag4 = ntStatus > NtStatus.Success;
					if (flag4)
					{
						gchandle.Free();
						gchandle2.Free();
						bool flag5 = intPtr != IntPtr.Zero;
						if (flag5)
						{
							MDriverIoShared.NtClose(intPtr);
						}
						bool flag6 = intPtr2 != IntPtr.Zero;
						if (flag6)
						{
							MDriverIoShared.NtClose(intPtr2);
						}
						Log.Error(typeof(MDriverIoShared), "Failed to open the second event object. [" + ntStatus.ToString() + "]");
					}
					else
					{
						gchandle.Free();
						gchandle2.Free();
						this.FirstEvent = new AutoResetEvent(false);
						this.FirstEvent.Close();
						this.FirstEvent.SafeWaitHandle = new SafeWaitHandle(intPtr, false);
						this.SecondEvent = new AutoResetEvent(false);
						this.SecondEvent.Close();
						this.SecondEvent.SafeWaitHandle = new SafeWaitHandle(intPtr2, false);
						bool flag7 = this.IsConnected && this.Connected != null;
						if (flag7)
						{
							try
							{
								this.Connected(this, EventArgs.Empty);
							}
							catch (Exception)
							{
							}
						}
					}
				}
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0001BDFC File Offset: 0x00019FFC
		public bool TryIoControl(uint IoCtl)
		{
			object @lock = this.Lock;
			bool result;
			lock (@lock)
			{
				Marshal.WriteInt32(this.MapAddress, (int)IoCtl);
				bool flag2 = !this.FirstEvent.Set();
				if (flag2)
				{
				}
				result = this.SecondEvent.WaitOne();
				this.SecondEvent.Reset();
			}
			return result;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0001BE7C File Offset: 0x0001A07C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryIoControl<TInput>(uint IoCtl, TInput IoData)
		{
			return this.TryIoControl<TInput>(IoCtl, IoData, Marshal.SizeOf<TInput>());
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0001BE9C File Offset: 0x0001A09C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryIoControl<TInput>(uint IoCtl, TInput IoData, int IoDataSize)
		{
			object @lock = this.Lock;
			bool result;
			lock (@lock)
			{
				IntPtr mapAddress = this.MapAddress;
				IntPtr destination = IntPtr.Add(mapAddress, 4);
				Marshal.WriteInt32(mapAddress, (int)IoCtl);
				bool flag2 = IoData != null;
				if (flag2)
				{
					IntPtr intPtr = Marshal.AllocHGlobal(IoDataSize);
					Marshal.StructureToPtr<TInput>(IoData, intPtr, true);
					MDriverIoShared.CopyMemory(destination, intPtr, (uint)IoDataSize);
					bool flag3 = !this.FirstEvent.Set();
					if (flag3)
					{
					}
					Marshal.FreeHGlobal(intPtr);
				}
				result = this.SecondEvent.WaitOne();
				this.SecondEvent.Reset();
			}
			return result;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0001BF64 File Offset: 0x0001A164
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryIoControl<TInput, TOutput>(uint IoCtl, TInput IoData, out TOutput IoOutput)
		{
			int ioDataSize = Marshal.SizeOf<TInput>();
			int ioOutputSize = Marshal.SizeOf<TOutput>();
			return this.TryIoControl<TInput, TOutput>(IoCtl, IoData, ioDataSize, out IoOutput, ioOutputSize);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0001BF90 File Offset: 0x0001A190
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryIoControl<TInput, TOutput>(uint IoCtl, TInput IoData, int IoDataSize, out TOutput IoOutput, int IoOutputSize)
		{
			object @lock = this.Lock;
			bool result;
			lock (@lock)
			{
				IntPtr mapAddress = this.MapAddress;
				IntPtr intPtr = IntPtr.Add(mapAddress, 4);
				Marshal.WriteInt32(mapAddress, (int)IoCtl);
				bool flag2 = IoData != null;
				if (flag2)
				{
					IntPtr intPtr2 = Marshal.AllocHGlobal(IoDataSize);
					Marshal.StructureToPtr<TInput>(IoData, intPtr2, true);
					MDriverIoShared.CopyMemory(intPtr, intPtr2, (uint)IoDataSize);
					bool flag3 = !this.FirstEvent.Set();
					if (flag3)
					{
					}
					Marshal.FreeHGlobal(intPtr2);
				}
				result = this.SecondEvent.WaitOne();
				IoOutput = Marshal.PtrToStructure<TOutput>(intPtr);
				this.SecondEvent.Reset();
			}
			return result;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0001C068 File Offset: 0x0001A268
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryIoControl<TInput, TOutput>(uint IoCtl, TInput IoData, int IoDataSize, out TOutput IoOutput, int IoOutputSize, ref int IoDataReceived)
		{
			return this.TryIoControl<TInput, TOutput>(IoCtl, IoData, IoDataSize, out IoOutput, IoOutputSize);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0001C088 File Offset: 0x0001A288
		public void Disconnect()
		{
			bool isConnected = this.IsConnected;
			if (isConnected)
			{
				SafeFileHandle handle = this.Handle;
				if (handle != null)
				{
					handle.Close();
				}
				AutoResetEvent firstEvent = this.FirstEvent;
				if (firstEvent != null)
				{
					firstEvent.Close();
				}
				AutoResetEvent secondEvent = this.SecondEvent;
				if (secondEvent != null)
				{
					secondEvent.Close();
				}
				bool flag = this.Disconnected != null;
				if (flag)
				{
					try
					{
						this.Disconnected(this, EventArgs.Empty);
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0001C114 File Offset: 0x0001A314
		public void Dispose()
		{
			bool isDisposed = this.IsDisposed;
			if (!isDisposed)
			{
				this.IsDisposed = true;
				this.Disconnect();
				SafeFileHandle handle = this.Handle;
				if (handle != null)
				{
					handle.Dispose();
				}
				AutoResetEvent firstEvent = this.FirstEvent;
				if (firstEvent != null)
				{
					firstEvent.Dispose();
				}
				AutoResetEvent secondEvent = this.SecondEvent;
				if (secondEvent != null)
				{
					secondEvent.Dispose();
				}
				this.Handle = null;
				this.FirstEvent = null;
				this.SecondEvent = null;
				bool flag = this.MapAddress != IntPtr.Zero;
				if (flag)
				{
					try
					{
						Marshal.FreeHGlobal(this.MapAddress);
					}
					catch (Exception)
					{
					}
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

		// Token: 0x06000172 RID: 370
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtOpenEvent(ref IntPtr EventHandle, uint DesiredAccess, IntPtr ObjectAttributes);

		// Token: 0x06000173 RID: 371
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern uint NtClose(IntPtr Handle);

		// Token: 0x06000174 RID: 372
		[DllImport("kernel32.dll")]
		private static extern void CopyMemory(IntPtr Destination, IntPtr Source, uint Length);
	}
}
