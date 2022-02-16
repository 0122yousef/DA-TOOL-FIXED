using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace PornHub.Security
{
	// Token: 0x02000013 RID: 19
	public class Scanner
	{
		// Token: 0x060000AC RID: 172 RVA: 0x0001855C File Offset: 0x0001675C
		public void Scan()
		{
			for (;;)
			{
				bool flag = WindowsInfo.LoggedInUserCount(Environment.MachineName) > 1;
				if (flag)
				{
					break;
				}
				Process[] processes = Process.GetProcesses();
				foreach (Process process in processes)
				{
					bool flag2 = this.BadProcs.Contains(process.ProcessName.ToLower()) || this.BadTitle.Contains(process.MainWindowTitle.ToLower());
					if (flag2)
					{
						WebAuth.BanMyself("BlackListed Software Found: " + process.ProcessName);
						break;
					}
				}
				Thread.Sleep(250);
			}
			WebAuth.ReportMyself(true, "Multiple users logged in");
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00018618 File Offset: 0x00016818
		public void DeepScan()
		{
			for (;;)
			{
				bool flag = this.BadDLL.Count > 0;
				if (flag)
				{
					Process[] processes = Process.GetProcesses();
					foreach (Process process in processes)
					{
						try
						{
							ProcessModuleCollection modules = process.Modules;
							try
							{
								foreach (object obj in modules)
								{
									bool flag2 = this.BadDLL.Contains(obj.ToString());
									if (flag2)
									{
										WebAuth.BanMyself("BlackListed Software DLL Found: " + process.ProcessName + " DLL: " + obj.ToString());
									}
								}
							}
							catch
							{
							}
						}
						catch
						{
						}
					}
				}
				Thread.Sleep(1000);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00018734 File Offset: 0x00016934
		public void MoveMe()
		{
			string text = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", string.Empty).Replace("/", "\\");
			for (;;)
			{
				string text2 = "C:\\$Recycle.Bin\\" + Scanner.RandomString(12);
				bool useTempFolder = Scanner.UseTempFolder;
				if (useTempFolder)
				{
					text2 = Path.GetTempPath() + "\\Hyper Loader\\" + Scanner.RandomString(12);
				}
				try
				{
					File.Move(text, text2);
					text = text2;
					Scanner.Last_Location = text;
				}
				catch
				{
				}
				Thread.Sleep(1);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000187D8 File Offset: 0x000169D8
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			select s[Scanner.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x040002A1 RID: 673
		private List<string> BadProcs = new List<string>
		{
			"ollydbg",
			"ida",
			"ida64",
			"idag",
			"idag64",
			"idaw",
			"idaw64",
			"idaq",
			"idaq64",
			"idau",
			"idau64",
			"scylla",
			"scylla_x64",
			"scylla_x86",
			"protection_id",
			"x64dbg",
			"x32dbg",
			"windbg",
			"reshacker",
			"importrec",
			"immunitydebugger",
			"megadumper",
			"cheatengine-x86_64",
			"cheatengine-i386",
			"cheat engine",
			"processhacker",
			"dump",
			"dumper",
			"dnspy",
			"dnspy-x86",
			"scylla_x64",
			"scylla_x86",
			"Cosmos",
			"httpdebuggerui",
			"httpdebugger",
			"hxd",
			"fiddler",
			"wireshark",
			"petools",
			"resourcehacker"
		};

		// Token: 0x040002A2 RID: 674
		private List<string> BadTitle = new List<string>
		{
			"ollydbg",
			"ida",
			"disassembly",
			"scylla",
			"debug",
			"[cpu",
			"immunity",
			"windbg",
			"x32dbg",
			"x64dbg",
			"import reconstructor",
			"megadumper",
			"megadumper 1.0 by codecracker / snd",
			"cheat engine",
			"process hacker",
			"dump",
			"dumper",
			"dnspy",
			"scylla",
			"Cosmos",
			"http debugger",
			"httpdebugger",
			"debugger",
			"hxd",
			"fiddler",
			"wireshark",
			"pe tools",
			"resource hacker"
		};

		// Token: 0x040002A3 RID: 675
		private List<string> BadDLL = new List<string>();

		// Token: 0x040002A4 RID: 676
		public static Thread MoverThread;

		// Token: 0x040002A5 RID: 677
		public static bool UseTempFolder = false;

		// Token: 0x040002A6 RID: 678
		public static string Last_Location = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", string.Empty).Replace("/", "\\");

		// Token: 0x040002A7 RID: 679
		private static Random random = new Random();
	}
}
