using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using PornHub.Properties;

namespace PornHub.Security
{
	// Token: 0x02000011 RID: 17
	internal class Functions
	{
		// Token: 0x0600009F RID: 159 RVA: 0x000179A4 File Offset: 0x00015BA4
		public static void CloseMyself()
		{
			Process.Start(new ProcessStartInfo
			{
				Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Scanner.Last_Location + "\"",
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			});
			Application.Exit();
			Environment.Exit(1);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00017A04 File Offset: 0x00015C04
		public static void TryLoadDriver()
		{
			try
			{
				HyperMEM hyperMEM = new HyperMEM();
				bool flag = hyperMEM.LoadGame("lsass");
				if (flag)
				{
					return;
				}
			}
			catch
			{
			}
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.RedirectStandardInput = true;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.Verb = "runas";
				process.Start();
				process.StandardInput.WriteLine("rd /s /q C:\\$Recycle.bin");
				process.StandardInput.Flush();
				process.StandardInput.Close();
				process.WaitForExit();
				string message = process.StandardOutput.ReadToEnd();
				Debug.WriteLine(message);
			}
			catch
			{
			}
			bool flag2 = !Directory.Exists("C:\\$Recycle.bin");
			if (flag2)
			{
				Directory.CreateDirectory("C:\\$Recycle.bin");
			}
			try
			{
				bool flag3 = File.Exists("C:\\$Recycle.Bin\\XDDriver.sys");
				if (flag3)
				{
					try
					{
						File.Delete("C:\\$Recycle.Bin\\XDDriver.sys");
						File.WriteAllBytes("C:\\$Recycle.Bin\\XDDriver.sys", Resources3.XDDriver);
					}
					catch
					{
						Debug.WriteLine("XDDriver Already exist, Skipped Loading.");
						return;
					}
				}
				else
				{
					File.WriteAllBytes("C:\\$Recycle.Bin\\XDDriver.sys", Resources3.XDDriver);
				}
				bool flag4 = File.Exists("C:\\$Recycle.Bin\\NN.exe");
				if (flag4)
				{
					try
					{
						File.Delete("C:\\$Recycle.Bin\\NN.exe");
						File.WriteAllBytes("C:\\$Recycle.Bin\\NN.exe", Resources3.NN);
					}
					catch
					{
						MessageBox.Show("Failed To Inject XDDriver");
						WebAuth.ReportMyself(true, "Failed To Inject XDDriver");
					}
				}
				else
				{
					File.WriteAllBytes("C:\\$Recycle.Bin\\NN.exe", Resources3.NN);
				}
				bool flag5 = File.Exists("C:\\$Recycle.Bin\\NN.exe") && File.Exists("C:\\$Recycle.Bin\\XDDriver.sys");
				if (flag5)
				{
					Process process2 = new Process();
					process2.StartInfo.FileName = "cmd.exe";
					process2.StartInfo.RedirectStandardInput = true;
					process2.StartInfo.RedirectStandardOutput = true;
					process2.StartInfo.CreateNoWindow = true;
					process2.StartInfo.UseShellExecute = false;
					process2.StartInfo.Verb = "runas";
					process2.Start();
					process2.StandardInput.WriteLine("cd C:\\$Recycle.Bin");
					process2.StandardInput.WriteLine("NN.exe /i");
					process2.StandardInput.WriteLine("NN.exe /l C:\\$Recycle.Bin\\XDDriver.sys");
					process2.StandardInput.WriteLine("NN.exe /u");
					process2.StandardInput.Flush();
					process2.StandardInput.Close();
					process2.WaitForExit();
					string text = process2.StandardOutput.ReadToEnd();
					Debug.WriteLine(text);
					bool flag6 = !text.Contains("XDDriver.sys loaded.");
					if (flag6)
					{
						MessageBox.Show("XDDriver Failed To Load At Injection Phase.");
						WebAuth.ReportMyself(false, "XDDriver Failed To Load At Injection Phase");
					}
					File.Delete("C:\\$Recycle.Bin\\NN.exe");
				}
				else
				{
					MessageBox.Show("XDDriver/Loader Missing!");
					WebAuth.ReportMyself(false, "XDDriver/Loader Missing");
				}
			}
			catch (Exception ex)
			{
				bool flag7 = ex.ToString().Contains("C:\\$Recycle.Bin\\XDDriver.sys");
				if (flag7)
				{
					try
					{
						bool flag8 = !Directory.Exists(Path.GetTempPath() + "\\Hyper Loader");
						if (flag8)
						{
							Directory.CreateDirectory(Path.GetTempPath() + "\\Hyper Loader");
						}
						bool flag9 = File.Exists(Path.GetTempPath() + "\\Hyper Loader\\XDDriver.sys");
						if (flag9)
						{
							try
							{
								File.Delete(Path.GetTempPath() + "\\Hyper Loader\\XDDriver.sys");
								File.WriteAllBytes(Path.GetTempPath() + "\\Hyper Loader\\XDDriver.sys", Resources3.XDDriver);
							}
							catch
							{
								Debug.WriteLine("XDDriver Already exist, Skipped Loading.");
								return;
							}
						}
						else
						{
							File.WriteAllBytes(Path.GetTempPath() + "\\Hyper Loader\\XDDriver.sys", Resources3.XDDriver);
						}
						bool flag10 = File.Exists(Path.GetTempPath() + "\\Hyper Loader\\NN.exe");
						if (flag10)
						{
							try
							{
								File.Delete(Path.GetTempPath() + "\\Hyper Loader\\NN.exe");
								File.WriteAllBytes(Path.GetTempPath() + "\\Hyper Loader\\NN.exe", Resources3.NN);
							}
							catch
							{
								MessageBox.Show("Failed To Inject XDDriver");
								WebAuth.ReportMyself(false, "Failed To Inject XDDriver");
							}
						}
						else
						{
							File.WriteAllBytes(Path.GetTempPath() + "\\Hyper Loader\\NN.exe", Resources3.NN);
						}
						bool flag11 = File.Exists(Path.GetTempPath() + "\\Hyper Loader\\NN.exe") && File.Exists(Path.GetTempPath() + "\\Hyper Loader\\XDDriver.sys");
						if (flag11)
						{
							Process process3 = new Process();
							process3.StartInfo.FileName = "cmd.exe";
							process3.StartInfo.RedirectStandardInput = true;
							process3.StartInfo.RedirectStandardOutput = true;
							process3.StartInfo.CreateNoWindow = true;
							process3.StartInfo.UseShellExecute = false;
							process3.StartInfo.Verb = "runas";
							process3.Start();
							process3.StandardInput.WriteLine("cd " + Path.GetTempPath() + "\\Hyper Loader");
							process3.StandardInput.WriteLine("NN.exe /i");
							process3.StandardInput.WriteLine("NN.exe /l " + Path.GetTempPath() + "\\Hyper Loader\\XDDriver.sys");
							process3.StandardInput.WriteLine("NN.exe /u");
							process3.StandardInput.Flush();
							process3.StandardInput.Close();
							process3.WaitForExit();
							string text2 = process3.StandardOutput.ReadToEnd();
							Debug.WriteLine(text2);
							bool flag12 = !text2.Contains("XDDriver.sys loaded.");
							if (flag12)
							{
								MessageBox.Show("XDDriver Failed To Load At Injection Phase.");
								WebAuth.ReportMyself(false, "XDDriver Failed To Load At Injection Phase");
							}
							File.Delete(Path.GetTempPath() + "\\Hyper Loader\\NN.exe");
							Scanner.UseTempFolder = true;
						}
						else
						{
							MessageBox.Show("XDDriver/Loader Missing!");
							WebAuth.ReportMyself(false, "XDDriver/Loader Missing");
						}
					}
					catch (Exception ex2)
					{
						MessageBox.Show("Major XDDriver error!\n" + ex2.ToString());
						WebAuth.ReportMyself(false, "XDDriver failed to load at line 210");
					}
				}
				else
				{
					MessageBox.Show("XDDriver error!\n" + ex.ToString());
					WebAuth.ReportMyself(true, "XDDriver failed to load at line 217");
				}
			}
		}
	}
}
