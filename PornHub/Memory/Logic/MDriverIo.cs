using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using PornHub.Memory.Logic.Interfaces;
using PornHub.Memory.Native;

namespace PornHub.Memory.Logic
{
	// Token: 0x0200002F RID: 47
	public class MDriverIo : MIDriverIo, IDisposable
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0001B66C File Offset: 0x0001986C
		public MIDriver Driver { get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0001B674 File Offset: 0x00019874
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0001B67C File Offset: 0x0001987C
		public SafeFileHandle Handle { get; private set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0001B685 File Offset: 0x00019885
		// (set) Token: 0x0600013E RID: 318 RVA: 0x0001B68D File Offset: 0x0001988D
		public EventHandler Connected { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0001B696 File Offset: 0x00019896
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0001B69E File Offset: 0x0001989E
		public EventHandler Disconnected { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0001B6A7 File Offset: 0x000198A7
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0001B6AF File Offset: 0x000198AF
		public EventHandler Disposed { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0001B6B8 File Offset: 0x000198B8
		public bool IsConnected
		{
			get
			{
				bool flag = this.Handle == null;
				return !flag && !this.Handle.IsInvalid && !this.Handle.IsClosed;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0001B6FA File Offset: 0x000198FA
		// (set) Token: 0x06000145 RID: 325 RVA: 0x0001B702 File Offset: 0x00019902
		public bool IsDisposed { get; private set; }

		// Token: 0x06000146 RID: 326 RVA: 0x0001B70B File Offset: 0x0001990B
		protected MDriverIo()
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0001B715 File Offset: 0x00019915
		public MDriverIo(MIDriver Driver)
		{
			this.Driver = Driver;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0001B728 File Offset: 0x00019928
		public void Connect()
		{
			bool isConnected = this.IsConnected;
			if (isConnected)
			{
				this.Disconnect();
			}
			this.Handle = WinApi.CreateFile(this.Driver.Config.SymbolicLink, FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, 0U, IntPtr.Zero);
			bool flag = this.IsConnected && this.Connected != null;
			if (flag)
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

		// Token: 0x06000149 RID: 329 RVA: 0x0001B7B8 File Offset: 0x000199B8
		public bool TryIoControl(uint IoCtl)
		{
			return MDriverIo.DeviceIoControl(this.Handle, IoCtl, null, 0, null, 0);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0001B7DC File Offset: 0x000199DC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryIoControl<TInput>(uint IoCtl, TInput IoData)
		{
			return this.TryIoControl<TInput>(IoCtl, IoData, Marshal.SizeOf<TInput>());
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0001B7FC File Offset: 0x000199FC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryIoControl<TInput>(uint IoCtl, TInput IoData, int IoDataSize)
		{
			return MDriverIo.DeviceIoControl(this.Handle, IoCtl, IoData, IoDataSize, null, 0);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0001B824 File Offset: 0x00019A24
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryIoControl<TInput, TOutput>(uint IoCtl, TInput IoData, out TOutput IoOutput)
		{
			return this.TryIoControl<TInput, TOutput>(IoCtl, IoData, Marshal.SizeOf<TInput>(), out IoOutput, Marshal.SizeOf<TOutput>());
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0001B84C File Offset: 0x00019A4C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryIoControl<TInput, TOutput>(uint IoCtl, TInput IoData, int IoDataSize, out TOutput IoOutput, int IoOutputSize)
		{
			IoOutput = default(TOutput);
			return MDriverIo.DeviceIoControl(this.Handle, IoCtl, IoData, IoDataSize, IoOutput, IoOutputSize);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0001B888 File Offset: 0x00019A88
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryIoControl<TInput, TOutput>(uint IoCtl, TInput IoData, int IoDataSize, out TOutput IoOutput, int IoOutputSize, ref int IoDataReceived)
		{
			IoOutput = default(TOutput);
			return MDriverIo.DeviceIoControl(this.Handle, IoCtl, IoData, IoDataSize, IoOutput, IoOutputSize, ref IoDataReceived, IntPtr.Zero);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0001B8CC File Offset: 0x00019ACC
		public void Disconnect()
		{
			bool isConnected = this.IsConnected;
			if (isConnected)
			{
				this.Handle.Close();
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
			this.Handle = null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0001B934 File Offset: 0x00019B34
		public void Dispose()
		{
			bool isDisposed = this.IsDisposed;
			if (!isDisposed)
			{
				this.IsDisposed = true;
				this.Disconnect();
				bool flag = this.Disposed != null;
				if (flag)
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

		// Token: 0x06000151 RID: 337 RVA: 0x0001B998 File Offset: 0x00019B98
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool DeviceIoControl(SafeFileHandle HDevice, uint IoControlCode, object InBuffer, int NInBufferSize, object OutBuffer, int NOutBufferSize)
		{
			int num = 0;
			return MDriverIo.DeviceIoControl(HDevice, IoControlCode, InBuffer, NInBufferSize, OutBuffer, NOutBufferSize, ref num, IntPtr.Zero);
		}

		// Token: 0x06000152 RID: 338
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool DeviceIoControl(SafeFileHandle HDevice, uint IoControlCode, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object InBuffer, int NInBufferSize, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object OutBuffer, int NOutBufferSize, ref int PBytesReturned, IntPtr Overlapped);
	}
}
