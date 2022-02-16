using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using PornHub.Properties;
using PornHub.Security;

namespace PornHub
{
    // Token: 0x0200000B RID: 11
    public partial class LoadingPage : Form
    {
        // Token: 0x0600004D RID: 77 RVA: 0x00016039 File Offset: 0x00014239
        public LoadingPage()
        {
            this.InitializeComponent();
        }

        // Token: 0x0600004E RID: 78 RVA: 0x00016051 File Offset: 0x00014251
        // Token: 0x0600004F RID: 79 RVA: 0x00016060 File Offset: 0x00014260
        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] processesByName = Process.GetProcessesByName("BlackOpsColdWar");
            bool flag = processesByName.Length != 0;
            if (flag)
            {
                int num = 0;
                bool flag2 = processesByName[0].StartTime.AddSeconds((double)num) < DateTime.Now;
                if (flag2)
                {
                    Form3 form = new Form3();
                    form.Show();
                    base.Close();
                }
            }
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            Process[] processesByName = Process.GetProcessesByName("Vanguard.exe");
            bool flag = processesByName.Length != 0;
            if (flag)
            {
                int num = 0;
                bool flag2 = processesByName[0].StartTime.AddSeconds((double)num) < DateTime.Now;
                if (flag2)
                {
                    Form3 form = new Form3();
                    form.Show();
                    base.Close();
                }
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            Process[] processesByName = Process.GetProcessesByName("Modernwarefare.exe");
            bool flag = processesByName.Length != 0;
            if (flag)
            {
                int num = 0;
                bool flag2 = processesByName[0].StartTime.AddSeconds((double)num) < DateTime.Now;
                if (flag2)
                {
                    Form3 form = new Form3();
                    form.Show();
                    base.Close();
                }
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Process[] processesByName = Process.GetProcessesByName("Vanguard.exe");
            bool flag = processesByName.Length != 0;
            if (flag)
            {
                int num = 0;
                bool flag2 = processesByName[0].StartTime.AddSeconds((double)num) < DateTime.Now;
                if (flag2)
                {
                    Form3 form = new Form3();
                    form.Show();
                    base.Close();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Process[] processesByName = Process.GetProcessesByName("Modernwarefare.exe");
            bool flag = processesByName.Length != 0;
            if (flag)
            {
                int num = 0;
                bool flag2 = processesByName[0].StartTime.AddSeconds((double)num) < DateTime.Now;
                if (flag2)
                {
                    Form3 form = new Form3();
                    form.Show();
                    base.Close();
                }
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}





