using System;
using System.IO;
using PornHub.Memory.Logic.Enums;

namespace PornHub.Memory.Logic
{
	// Token: 0x0200002E RID: 46
	public class MDriverConfig
	{
		// Token: 0x0600012D RID: 301 RVA: 0x0001B5E9 File Offset: 0x000197E9
		public MDriverConfig()
		{
			this.SharedMemory = new MDriverConfig.MDriverConfigSharedMemory();
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600012E RID: 302 RVA: 0x0001B606 File Offset: 0x00019806
		// (set) Token: 0x0600012F RID: 303 RVA: 0x0001B60E File Offset: 0x0001980E
		public string ServiceName { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0001B617 File Offset: 0x00019817
		// (set) Token: 0x06000131 RID: 305 RVA: 0x0001B61F File Offset: 0x0001981F
		public FileInfo DriverFile { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0001B628 File Offset: 0x00019828
		// (set) Token: 0x06000133 RID: 307 RVA: 0x0001B630 File Offset: 0x00019830
		public string SymbolicLink { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0001B639 File Offset: 0x00019839
		// (set) Token: 0x06000135 RID: 309 RVA: 0x0001B641 File Offset: 0x00019841
		public MDriverLoad LoadMethod { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0001B64A File Offset: 0x0001984A
		// (set) Token: 0x06000137 RID: 311 RVA: 0x0001B652 File Offset: 0x00019852
		public MIoMethod IoMethod { get; set; } = MIoMethod.IoControl;

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0001B65B File Offset: 0x0001985B
		// (set) Token: 0x06000139 RID: 313 RVA: 0x0001B663 File Offset: 0x00019863
		public MDriverConfig.MDriverConfigSharedMemory SharedMemory { get; set; }

		// Token: 0x0200004A RID: 74
		public class MDriverConfigSharedMemory
		{
			// Token: 0x1700004E RID: 78
			// (get) Token: 0x060001E0 RID: 480 RVA: 0x0001E360 File Offset: 0x0001C560
			// (set) Token: 0x060001E1 RID: 481 RVA: 0x0001E368 File Offset: 0x0001C568
			public int ProcessId { get; set; }

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060001E2 RID: 482 RVA: 0x0001E371 File Offset: 0x0001C571
			// (set) Token: 0x060001E3 RID: 483 RVA: 0x0001E379 File Offset: 0x0001C579
			public ulong ProcessAddr { get; set; }

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x060001E4 RID: 484 RVA: 0x0001E382 File Offset: 0x0001C582
			// (set) Token: 0x060001E5 RID: 485 RVA: 0x0001E38A File Offset: 0x0001C58A
			public string FirstEventName { get; set; }

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x060001E6 RID: 486 RVA: 0x0001E393 File Offset: 0x0001C593
			// (set) Token: 0x060001E7 RID: 487 RVA: 0x0001E39B File Offset: 0x0001C59B
			public string SecondEventName { get; set; }
		}
	}
}
