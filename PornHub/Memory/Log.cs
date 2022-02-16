using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PornHub.Memory
{
	// Token: 0x02000017 RID: 23
	internal static class Log
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x00019779 File Offset: 0x00017979
		[Conditional("DEBUG")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Info(Type Type, string Message)
		{
			Debug.WriteLine("[ INFO  ] " + Type.Name + " : " + Message);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00019798 File Offset: 0x00017998
		[Conditional("DEBUG")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Warning(Type Type, string Message)
		{
			Debug.WriteLine("[WARNING] " + Type.Name + " : " + Message);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000197B7 File Offset: 0x000179B7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Error(Type Type, string Message)
		{
			Trace.WriteLine("[ ERROR ] " + Type.Name + " : " + Message);
		}
	}
}
