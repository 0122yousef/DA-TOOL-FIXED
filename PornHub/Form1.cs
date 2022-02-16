using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Newtonsoft.Json.Linq;
using PornHub.Branding;
using PornHub.Game;
using PornHub.Properties;
using PornHub.Security;
using ReaLTaiizor.Controls;

namespace PornHub
{
    // Token: 0x0200000A RID: 10
    public partial class Form1 : Form
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        public Form1()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
        private void Form_Header_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.lastLocation = e.Location;
        }

        // Token: 0x06000003 RID: 3 RVA: 0x0000207E File Offset: 0x0000027E
        private void Form_Header_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        // Token: 0x06000004 RID: 4 RVA: 0x00002088 File Offset: 0x00000288
        private void Form_Header_MouseMove(object sender, MouseEventArgs e)
        {
            bool flag = this.mouseDown;
            if (flag)
            {
                base.Location = new Point(base.Location.X - this.lastLocation.X + e.X, base.Location.Y - this.lastLocation.Y + e.Y);
                base.Update();
            }
        }

        // Token: 0x06000005 RID: 5 RVA: 0x000020F8 File Offset: 0x000002F8
        public void SetupZMGuns()
        {
            IEnumerable<ForeverComboBox> enumerable = this.FindAllChildrenByType<ForeverComboBox>();
            PlayerFunctions.GunNames = PlayerFunctions.GunNamesZM;
            PlayerFunctions.GunList = PlayerFunctions.GunListZM;
            foreach (ForeverComboBox foreverComboBox in enumerable)
            {
                bool flag = !foreverComboBox.Name.Contains("TP") && !foreverComboBox.Name.Contains("CMBOSTAT");
                if (flag)
                {
                    foreverComboBox.Items.Clear();
                    foreach (string item in PlayerFunctions.GunNames)
                    {
                        foreverComboBox.Items.Add(item);
                    }
                    bool flag2 = foreverComboBox.Name.Contains("CycleEnd");
                    if (flag2)
                    {
                        foreverComboBox.SelectedIndex = PlayerFunctions.GunNames.Length - 1;
                    }
                    else
                    {
                        foreverComboBox.SelectedIndex = 0;
                    }
                }
                else
                {
                    bool flag3 = foreverComboBox.Name.Contains("TP");
                    if (flag3)
                    {
                        foreverComboBox.Items.Clear();
                        foreach (string item2 in PlayerFunctions.TPS)
                        {
                            foreverComboBox.Items.Add(item2);
                        }
                    }
                    foreverComboBox.SelectedIndex = 0;
                }
            }
        }

        // Token: 0x06000006 RID: 6 RVA: 0x00002270 File Offset: 0x00000470
        public void zqinForce()
        {
            HyperMEM.MEM.WriteInt16(HyperMEM.MEM.GameBase + Offsets.ZSeshState, 8224, false);
        }

        // Token: 0x06000007 RID: 7 RVA: 0x00002294 File Offset: 0x00000494
        public void SetupMPGuns()
        {
            IEnumerable<ForeverComboBox> enumerable = this.FindAllChildrenByType<ForeverComboBox>();
            PlayerFunctions.GunNames = PlayerFunctions.GunNamesMP;
            PlayerFunctions.GunList = PlayerFunctions.GunListMP;
            foreach (ForeverComboBox foreverComboBox in enumerable)
            {
                bool flag = !foreverComboBox.Name.Contains("TP") && !foreverComboBox.Name.Contains("CMBOSTAT");
                if (flag)
                {
                    foreverComboBox.Items.Clear();
                    foreach (string item in PlayerFunctions.GunNames)
                    {
                        foreverComboBox.Items.Add(item);
                    }
                    bool flag2 = foreverComboBox.Name.Contains("CycleEnd");
                    if (flag2)
                    {
                        foreverComboBox.SelectedIndex = PlayerFunctions.GunNames.Length - 1;
                    }
                    else
                    {
                        foreverComboBox.SelectedIndex = 0;
                    }
                }
                else
                {
                    bool flag3 = foreverComboBox.Name.Contains("TP");
                    if (flag3)
                    {
                        foreverComboBox.Items.Clear();
                        foreach (string item2 in PlayerFunctions.TPS)
                        {
                            foreverComboBox.Items.Add(item2);
                        }
                    }
                    foreverComboBox.SelectedIndex = 0;
                }
            }
        }

        // Token: 0x06000008 RID: 8 RVA: 0x0000240C File Offset: 0x0000060C
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Control.CheckForIllegalCrossThreadCalls = false;
            Control.CheckForIllegalCrossThreadCalls = false;
            Control.CheckForIllegalCrossThreadCalls = false;
            Form1.ThisForm = this;
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    string text = webClient.DownloadString("https://hyperhaxz.com/Products/PornHub/WZM.json");
                    JToken jtoken = JToken.Parse(text);
                    JToken jtoken2 = JToken.Parse(jtoken.SelectToken("Weapons").ToString());
                    JToken[] array = jtoken2.Children<JToken>().ToArray<JToken>();
                    List<string> list = new List<string>();
                    List<int> list2 = new List<int>();
                    foreach (JToken jtoken3 in array)
                    {
                        list.Add(jtoken3.SelectToken("Name").ToString());
                        list2.Add(int.Parse(jtoken3.SelectToken("ID").ToString()));
                    }
                    PlayerFunctions.GunNamesZM = list.ToArray();
                    PlayerFunctions.GunListZM = list2.ToArray();
                    PlayerFunctions.GunNames = PlayerFunctions.GunNamesZM;
                    PlayerFunctions.GunList = PlayerFunctions.GunListZM;
                    this.SetupZMGuns();
                }
                catch
                {
                    MessageBox.Show("Failed To Parse ZM Guns");
                }
                try
                {
                }
                catch
                {
                    MessageBox.Show("Failed To Parse MP Guns");
                }
            }
            HyperMEM.MEM = new HyperMEM();
            bool flag = HyperMEM.MEM.LoadGame("BlackOpsColdWar");
            if (flag)
            {
                ulong num = HyperMEM.MEM.ReadInt64(HyperMEM.MEM.GameBase + 240791408UL);
                bool flag2 = num.ToString().Length == 18;

                IEnumerable<ForeverButton> enumerable = this.FindAllChildrenByType<ForeverButton>();
                IEnumerable<NightHeaderLabel> enumerable2 = this.FindAllChildrenByType<NightHeaderLabel>();
                IEnumerable<ForeverComboBox> enumerable3 = this.FindAllChildrenByType<ForeverComboBox>();
                IEnumerable<MetroSwitch> enumerable4 = this.FindAllChildrenByType<MetroSwitch>();
                this.ZUpdate();
                Threads @object = new Threads();
                new Thread(new ThreadStart(@object.Update_Thread))
                {
                    IsBackground = true
                }.Start();
            }
        }

        // Token: 0x06000009 RID: 9 RVA: 0x0000266C File Offset: 0x0000086C
        private void ZUpdate()
        {
            ulong num = HyperMEM.MEM.PatternScanGame(HyperMEM.MEM.GameBase + 1UL, HyperMEM.MEM.GameBase + HyperMEM.MEM.GameSize, new byte[]
            {
                76,
                141,
                5,
                0,
                0,
                0,
                0,
                65,
                0,
                140,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                65,
                0,
                140
            }, new string[]
            {
                "4C",
                "8D",
                "05",
                "?",
                "?",
                "?",
                "?",
                "41",
                "?",
                "8C",
                "?",
                "?",
                "?",
                "?",
                "?",
                "?",
                "?",
                "?",
                "?",
                "?",
                "?",
                "?",
                "?",
                "?",
                "?",
                "?",
                "41",
                "?",
                "8C"
            }, 1) + 3UL;
            bool flag = HyperMEM.MEM.IsValidAddr(num);
            if (flag)
            {
                int num2 = HyperMEM.MEM.ReadInt32(num);
                Offsets.ZPlayerBase = num + (ulong)((long)num2) + 4UL - HyperMEM.MEM.GameBase;
            }
            else
            {
                PornHub.Security.Functions.CloseMyself();
            }
            ulong num3 = HyperMEM.MEM.PatternScanGame(HyperMEM.MEM.GameBase + 1UL, HyperMEM.MEM.GameBase + HyperMEM.MEM.GameSize, new byte[]
            {
                243,
                15,
                17,
                128,
                232,
                13,
                0,
                0,
                243,
                15,
                16,
                69,
                168,
                243,
                15,
                17,
                128
            }, new string[]
            {
                "F3",
                "0F",
                "11",
                "80",
                "E8",
                "0D",
                "00",
                "00",
                "F3",
                "0F",
                "10",
                "45",
                "A8",
                "F3",
                "0F",
                "11",
                "80"
            }, 1);
            bool flag2 = HyperMEM.MEM.IsValidAddr(num3);
            if (flag2)
            {
                Offsets.ZNoClipFunc = num3 - HyperMEM.MEM.GameBase;
            }
            else
            {
                num3 = HyperMEM.MEM.PatternScanGame(HyperMEM.MEM.GameBase + 1UL, HyperMEM.MEM.GameBase + HyperMEM.MEM.GameSize, new byte[]
                {
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    243,
                    15,
                    16,
                    69,
                    168
                }, new string[]
                {
                    "90",
                    "90",
                    "90",
                    "90",
                    "90",
                    "90",
                    "90",
                    "90",
                    "F3",
                    "0F",
                    "10",
                    "45",
                    "A8"
                }, 1);
                bool flag3 = HyperMEM.MEM.IsValidAddr(num3);
                if (flag3)
                {
                    Offsets.ZNoClipFunc = num3 - HyperMEM.MEM.GameBase;
                }
                else
                {
                    PornHub.Security.Functions.CloseMyself();
                }
            }
            ulong num4 = HyperMEM.MEM.PatternScanGame(HyperMEM.MEM.GameBase + 1UL, HyperMEM.MEM.GameBase + HyperMEM.MEM.GameSize, new byte[]
            {
                72,
                139,
                13,
                0,
                0,
                0,
                0,
                232,
                0,
                0,
                0,
                0,
                128,
                62,
                0
            }, new string[]
            {
                "48",
                "8B",
                "0D",
                "?",
                "?",
                "?",
                "?",
                "E8",
                "?",
                "?",
                "?",
                "?",
                "",
                "80",
                "3E",
                "?"
            }, 1) + 3UL;
            bool flag4 = HyperMEM.MEM.IsValidAddr(num4);
            if (flag4)
            {
                int num5 = HyperMEM.MEM.ReadInt32(num4);
                ulong num6 = num4 + (ulong)((long)num5) + 4UL - HyperMEM.MEM.GameBase;
                Offsets.ZNoClipDir = num6 + 728UL;
            }
            else
            {
                PornHub.Security.Functions.CloseMyself();
            }
            ulong num7 = HyperMEM.MEM.PatternScanGame(HyperMEM.MEM.GameBase + 1UL, HyperMEM.MEM.GameBase + HyperMEM.MEM.GameSize, new byte[]
            {
                139,
                131,
                128,
                6,
                0,
                0,
                137,
                129
            }, new string[]
            {
                "8B",
                "83",
                "80",
                "06",
                "00",
                "00",
                "89",
                "81"
            }, 1);
            bool flag5 = HyperMEM.MEM.IsValidAddr(num7);
            if (flag5)
            {
                Offsets.ZTeleport = num7 - HyperMEM.MEM.GameBase;
            }
            else
            {
                num7 = HyperMEM.MEM.PatternScanGame(HyperMEM.MEM.GameBase + 1UL, HyperMEM.MEM.GameBase + HyperMEM.MEM.GameSize, new byte[]
                {
                    184,
                    0,
                    0,
                    0,
                    0,
                    137,
                    129,
                    212,
                    2,
                    0,
                    0
                }, new string[]
                {
                    "B8",
                    "?",
                    "?",
                    "?",
                    "?",
                    "89",
                    "81",
                    "D4",
                    "02",
                    "00",
                    "00"
                }, 1);
                bool flag6 = HyperMEM.MEM.IsValidAddr(num7);
                if (flag6)
                {
                    Offsets.ZTeleport = num7 - HyperMEM.MEM.GameBase;
                }
                else
                {
                    PornHub.Security.Functions.CloseMyself();
                }
            }
            ulong num8 = HyperMEM.MEM.PatternScanGame(HyperMEM.MEM.GameBase + 1UL, HyperMEM.MEM.GameBase + HyperMEM.MEM.GameSize, new byte[]
            {
                204,
                72,
                137,
                92,
                36,
                8,
                72,
                137,
                116,
                36,
                16,
                72,
                137,
                124,
                36,
                24,
                85,
                65,
                84,
                65,
                85,
                65,
                86,
                65,
                87,
                72,
                141,
                108,
                36,
                160
            }, new string[]
            {
                "CC",
                "48",
                "89",
                "5C",
                "24",
                "08",
                "48",
                "89",
                "74",
                "24",
                "10",
                "48",
                "89",
                "7C",
                "24",
                "18",
                "55",
                "41",
                "54",
                "41",
                "55",
                "41",
                "56",
                "41",
                "57",
                "48",
                "8D",
                "6C",
                "24",
                "A0"
            }, 1) + 1UL;
            bool flag7 = HyperMEM.MEM.IsValidAddr(num8);
            if (flag7)
            {
                Offsets.ZShoot = num8 - HyperMEM.MEM.GameBase;
            }
            else
            {
                num8 = HyperMEM.MEM.PatternScanGame(HyperMEM.MEM.GameBase + 1UL, HyperMEM.MEM.GameBase + HyperMEM.MEM.GameSize, new byte[]
                {
                    204,
                    233,
                    0,
                    0,
                    0,
                    0,
                    72,
                    137,
                    116,
                    36,
                    16,
                    72,
                    137,
                    124,
                    36,
                    24,
                    85,
                    65,
                    84,
                    65,
                    85,
                    65,
                    86,
                    65,
                    87,
                    72,
                    141,
                    108,
                    36,
                    160
                }, new string[]
                {
                    "CC",
                    "E9",
                    "?",
                    "?",
                    "?",
                    "?",
                    "48",
                    "89",
                    "74",
                    "24",
                    "10",
                    "48",
                    "89",
                    "7C",
                    "24",
                    "18",
                    "55",
                    "41",
                    "54",
                    "41",
                    "55",
                    "41",
                    "56",
                    "41",
                    "57",
                    "48",
                    "8D",
                    "6C",
                    "24",
                    "A0"
                }, 1) + 1UL;
                bool flag8 = HyperMEM.MEM.IsValidAddr(num8);
                if (flag8)
                {
                    Offsets.ZShoot = num8 - HyperMEM.MEM.GameBase;
                }
                else
                {
                    PornHub.Security.Functions.CloseMyself();
                }
            }
            ulong num9 = HyperMEM.MEM.PatternScanGame(HyperMEM.MEM.GameBase + 1UL, HyperMEM.MEM.GameBase + HyperMEM.MEM.GameSize, new byte[]
            {
                232,
                0,
                0,
                0,
                0,
                65,
                185,
                1,
                0,
                0,
                0,
                198,
                68,
                36,
                40,
                0,
                76,
                139,
                195,
                198,
                68,
                36,
                32,
                1,
                186,
                70,
                19,
                7,
                82,
                51,
                201
            }, new string[]
            {
                "E8",
                "?",
                "?",
                "?",
                "?",
                "41",
                "b9",
                "01",
                "00",
                "00",
                "00",
                "c6",
                "44",
                "24",
                "28",
                "00",
                "4c",
                "8b",
                "c3",
                "c6",
                "44",
                "24",
                "20",
                "01",
                "ba",
                "46",
                "13",
                "07",
                "52",
                "33",
                "c9"
            }, 1) + 53UL;
            bool flag9 = HyperMEM.MEM.IsValidAddr(num9);
            if (flag9)
            {
                Offsets.ZKill = num9 - HyperMEM.MEM.GameBase;
            }
            else
            {
                PornHub.Security.Functions.CloseMyself();
            }
            ulong num10 = HyperMEM.MEM.PatternScanGame(HyperMEM.MEM.GameBase + 1UL, HyperMEM.MEM.GameBase + HyperMEM.MEM.GameSize, new byte[]
            {
                139,
                5,
                0,
                0,
                0,
                0,
                193,
                224,
                28,
                193,
                248,
                28,
                195
            }, new string[]
            {
                "8b",
                "05",
                "?",
                "?",
                "?",
                "?",
                "c1",
                "e0",
                "1c",
                "c1",
                "f8",
                "1c",
                "c3"
            }, 1) + 2UL;
            bool flag10 = HyperMEM.MEM.IsValidAddr(num10);
            if (flag10)
            {
                int num11 = HyperMEM.MEM.ReadInt32(num10);
                Offsets.ZSeshState = num10 + (ulong)((long)num11) + 4UL - HyperMEM.MEM.GameBase;
            }
            else
            {
                PornHub.Security.Functions.CloseMyself();
            }
            ulong num12 = HyperMEM.MEM.PatternScanGame(HyperMEM.MEM.GameBase + 1UL, HyperMEM.MEM.GameBase + HyperMEM.MEM.GameSize, new byte[]
            {
                139,
                145,
                32,
                2,
                0,
                0,
                139,
                202,
                131,
                225
            }, new string[]
            {
                "8B",
                "91",
                "20",
                "02",
                "00",
                "00",
                "8B",
                "CA",
                "83",
                "E1"
            }, 1);
            bool flag11 = HyperMEM.MEM.IsValidAddr(num12);
            if (flag11)
            {
                Offsets.ZRound = num12 - HyperMEM.MEM.GameBase;
            }
            else
            {
                num12 = HyperMEM.MEM.PatternScanGame(HyperMEM.MEM.GameBase + 1UL, HyperMEM.MEM.GameBase + HyperMEM.MEM.GameSize, new byte[]
                {
                    139,
                    145,
                    33,
                    2,
                    0,
                    0
                }, new string[]
                {
                    "8B",
                    "91",
                    "21",
                    "02",
                    "00",
                    "00"
                }, 1);
                bool flag12 = HyperMEM.MEM.IsValidAddr(num12);
                if (flag12)
                {
                    Offsets.ZRound = num12 - HyperMEM.MEM.GameBase;
                }
                else
                {
                    PornHub.Security.Functions.CloseMyself();
                }
            }
        }

        // Token: 0x0600000A RID: 10 RVA: 0x00003371 File Offset: 0x00001571
        private void Btn_Server_Icon_MouseEnter(object sender, EventArgs e)
        {
            Form1.Server_Hovered = true;
        }

        // Token: 0x0600000B RID: 11 RVA: 0x0000337A File Offset: 0x0000157A
        private void Btn_Server_Icon_MouseLeave(object sender, EventArgs e)
        {
            Form1.Server_Hovered = false;
            Form1.Server_ClockWise = true;
            Form1.Server_Rotation = 0;
            this.Btn_Server_Icon.Rotation = (double)Form1.Server_Rotation;
        }

        // Token: 0x0600000C RID: 12 RVA: 0x000033A1 File Offset: 0x000015A1
        private void Btn_P1_Icon_MouseEnter(object sender, EventArgs e)
        {
            Form1.P1_Hovered = true;
        }

        // Token: 0x0600000D RID: 13 RVA: 0x000033AA File Offset: 0x000015AA
        private void Btn_P1_Icon_MouseLeave(object sender, EventArgs e)
        {
            Form1.P1_Hovered = false;
            Form1.P1_ClockWise = true;
            Form1.P1_Rotation = 0;
            this.Btn_P1_Icon.Rotation = (double)Form1.P1_Rotation;
        }

        // Token: 0x0600000E RID: 14 RVA: 0x000033D1 File Offset: 0x000015D1
        private void Btn_P2_Icon_MouseEnter(object sender, EventArgs e)
        {
            Form1.P2_Hovered = true;
        }

        // Token: 0x0600000F RID: 15 RVA: 0x000033DA File Offset: 0x000015DA
        private void Btn_P2_Icon_MouseLeave(object sender, EventArgs e)
        {
            Form1.P2_Hovered = false;
            Form1.P2_ClockWise = true;
            Form1.P2_Rotation = 0;
            this.Btn_P2_Icon.Rotation = (double)Form1.P2_Rotation;
        }

        // Token: 0x06000010 RID: 16 RVA: 0x00003401 File Offset: 0x00001601
        private void Btn_P3_Icon_MouseEnter(object sender, EventArgs e)
        {
            Form1.P3_Hovered = true;
        }

        // Token: 0x06000011 RID: 17 RVA: 0x0000340A File Offset: 0x0000160A
        private void Btn_P3_Icon_MouseLeave(object sender, EventArgs e)
        {
            Form1.P3_Hovered = false;
            Form1.P3_ClockWise = true;
            Form1.P3_Rotation = 0;
            this.Btn_P3_Icon.Rotation = (double)Form1.P3_Rotation;
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00003431 File Offset: 0x00001631
        private void Btn_P4_Icon_MouseEnter(object sender, EventArgs e)
        {
            Form1.P4_Hovered = true;
        }

        // Token: 0x06000013 RID: 19 RVA: 0x0000343A File Offset: 0x0000163A
        private void Btn_P4_Icon_MouseLeave(object sender, EventArgs e)
        {
            Form1.P4_Hovered = false;
            Form1.P4_ClockWise = true;
            Form1.P4_Rotation = 0;
            this.Btn_P4_Icon.Rotation = (double)Form1.P4_Rotation;
        }

        // Token: 0x06000014 RID: 20 RVA: 0x00003461 File Offset: 0x00001661
        private void Btn_Discord_Icon_MouseEnter(object sender, EventArgs e)
        {
            Form1.Discord_Hovered = true;
        }

        // Token: 0x06000015 RID: 21 RVA: 0x0000346A File Offset: 0x0000166A
        private void Btn_Discord_Icon_MouseLeave(object sender, EventArgs e)
        {
            Form1.Discord_Hovered = false;
            Form1.Discord_ClockWise = true;
            Form1.Discord_Rotation = 0;
            this.Btn_Discord_Icon.Rotation = (double)Form1.Discord_Rotation;
        }

        // Token: 0x06000016 RID: 22 RVA: 0x00003494 File Offset: 0x00001694
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.LBL_Gun.Text = "Current Gun ID: " + PlayerFunctions.GetPlayerGunID(0);
            bool flag = Form1.Server_Hovered || Form1.Server_Selected;
            if (flag)
            {
                bool server_ClockWise = Form1.Server_ClockWise;
                if (server_ClockWise)
                {
                    Form1.Server_Rotation++;
                    this.Btn_Server_Icon.Rotation = (double)Form1.Server_Rotation;
                    bool flag2 = Form1.Server_Rotation == Form1.Server_Rotation_Amount;
                    if (flag2)
                    {
                        Form1.Server_ClockWise = false;
                    }
                }
                else
                {
                    Form1.Server_Rotation--;
                    this.Btn_Server_Icon.Rotation = (double)Form1.Server_Rotation;
                    bool flag3 = Form1.Server_Rotation == -Form1.Server_Rotation_Amount;
                    if (flag3)
                    {
                        Form1.Server_ClockWise = true;
                    }
                }
            }
            bool flag4 = Form1.P1_Hovered || Form1.P1_Selected;
            if (flag4)
            {
                bool p1_ClockWise = Form1.P1_ClockWise;
                if (p1_ClockWise)
                {
                    Form1.P1_Rotation++;
                    this.Btn_P1_Icon.Rotation = (double)Form1.P1_Rotation;
                    bool flag5 = Form1.P1_Rotation == Form1.P1_Rotation_Amount;
                    if (flag5)
                    {
                        Form1.P1_ClockWise = false;
                    }
                }
                else
                {
                    Form1.P1_Rotation--;
                    this.Btn_P1_Icon.Rotation = (double)Form1.P1_Rotation;
                    bool flag6 = Form1.P1_Rotation == -Form1.P1_Rotation_Amount;
                    if (flag6)
                    {
                        Form1.P1_ClockWise = true;
                    }
                }
            }
            bool flag7 = Form1.P2_Hovered || Form1.P2_Selected;
            if (flag7)
            {
                bool p2_ClockWise = Form1.P2_ClockWise;
                if (p2_ClockWise)
                {
                    Form1.P2_Rotation++;
                    this.Btn_P2_Icon.Rotation = (double)Form1.P2_Rotation;
                    bool flag8 = Form1.P2_Rotation == Form1.P2_Rotation_Amount;
                    if (flag8)
                    {
                        Form1.P2_ClockWise = false;
                    }
                }
                else
                {
                    Form1.P2_Rotation--;
                    this.Btn_P2_Icon.Rotation = (double)Form1.P2_Rotation;
                    bool flag9 = Form1.P2_Rotation == -Form1.P2_Rotation_Amount;
                    if (flag9)
                    {
                        Form1.P2_ClockWise = true;
                    }
                }
            }
            bool flag10 = Form1.P3_Hovered || Form1.P3_Selected;
            if (flag10)
            {
                bool p3_ClockWise = Form1.P3_ClockWise;
                if (p3_ClockWise)
                {
                    Form1.P3_Rotation++;
                    this.Btn_P3_Icon.Rotation = (double)Form1.P3_Rotation;
                    bool flag11 = Form1.P3_Rotation == Form1.P3_Rotation_Amount;
                    if (flag11)
                    {
                        Form1.P3_ClockWise = false;
                    }
                }
                else
                {
                    Form1.P3_Rotation--;
                    this.Btn_P3_Icon.Rotation = (double)Form1.P3_Rotation;
                    bool flag12 = Form1.P3_Rotation == -Form1.P3_Rotation_Amount;
                    if (flag12)
                    {
                        Form1.P3_ClockWise = true;
                    }
                }
            }
            bool flag13 = Form1.P4_Hovered || Form1.P4_Selected;
            if (flag13)
            {
                bool p4_ClockWise = Form1.P4_ClockWise;
                if (p4_ClockWise)
                {
                    Form1.P4_Rotation++;
                    this.Btn_P4_Icon.Rotation = (double)Form1.P4_Rotation;
                    bool flag14 = Form1.P4_Rotation == Form1.P4_Rotation_Amount;
                    if (flag14)
                    {
                        Form1.P4_ClockWise = false;
                    }
                }
                else
                {
                    Form1.P4_Rotation--;
                    this.Btn_P4_Icon.Rotation = (double)Form1.P4_Rotation;
                    bool flag15 = Form1.P4_Rotation == -Form1.P4_Rotation_Amount;
                    if (flag15)
                    {
                        Form1.P4_ClockWise = true;
                    }
                }
            }
            bool discord_Hovered = Form1.Discord_Hovered;
            if (discord_Hovered)
            {
                bool discord_ClockWise = Form1.Discord_ClockWise;
                if (discord_ClockWise)
                {
                    Form1.Discord_Rotation++;
                    this.Btn_Discord_Icon.Rotation = (double)Form1.Discord_Rotation;
                    bool flag16 = Form1.Discord_Rotation == Form1.Discord_Rotation_Amount;
                    if (flag16)
                    {
                        Form1.Discord_ClockWise = false;
                    }
                }
                else
                {
                    Form1.Discord_Rotation--;
                    this.Btn_Discord_Icon.Rotation = (double)Form1.Discord_Rotation;
                    bool flag17 = Form1.Discord_Rotation == -Form1.Discord_Rotation_Amount;
                    if (flag17)
                    {
                        Form1.Discord_ClockWise = true;
                    }
                }
            }
        }

        // Token: 0x06000017 RID: 23 RVA: 0x00003854 File Offset: 0x00001A54
        public void HidePages()
        {
            this.Panel_Server.Visible = false;
            Form1.Server_Selected = false;
            Form1.Server_Rotation = 0;
            this.Btn_Server_Icon.Rotation = 0.0;
            this.Panel_P1.Visible = false;
            Form1.P1_Selected = false;
            Form1.P1_Rotation = 0;
            this.Btn_P1_Icon.Rotation = 0.0;
            this.Panel_P2.Visible = false;
            Form1.P2_Selected = false;
            Form1.P2_Rotation = 0;
            this.Btn_P2_Icon.Rotation = 0.0;
            this.Panel_P3.Visible = false;
            Form1.P3_Selected = false;
            Form1.P3_Rotation = 0;
            this.Btn_P3_Icon.Rotation = 0.0;
            this.Panel_P4.Visible = false;
            Form1.P4_Selected = false;
            Form1.P4_Rotation = 0;
            this.Btn_P4_Icon.Rotation = 0.0;
        }

        // Token: 0x06000018 RID: 24 RVA: 0x00003948 File Offset: 0x00001B48
        private void Btn_Server_Icon_MouseDown(object sender, MouseEventArgs e)
        {
            this.HidePages();
            this.Panel_Server.Visible = true;
            Form1.Server_Selected = true;
            this.LBL_PlayerName.Visible = false;
        }

        // Token: 0x06000019 RID: 25 RVA: 0x00003974 File Offset: 0x00001B74
        private void Btn_P1_Icon_MouseDown(object sender, MouseEventArgs e)
        {
            this.HidePages();
            this.Panel_P1.Visible = true;
            Form1.P1_Selected = true;
            this.LBL_PlayerName.Visible = true;
            this.LBL_PlayerName.Text = "Player: " + PlayerFunctions.GetPlayerName(0);
        }

        // Token: 0x0600001A RID: 26 RVA: 0x000039C8 File Offset: 0x00001BC8
        private void Btn_P2_Icon_MouseDown(object sender, MouseEventArgs e)
        {
            this.HidePages();
            this.Panel_P2.Visible = true;
            Form1.P2_Selected = true;
            this.LBL_PlayerName.Visible = true;
            this.LBL_PlayerName.Text = "Player: " + PlayerFunctions.GetPlayerName(1);
        }

        // Token: 0x0600001B RID: 27 RVA: 0x00003A1C File Offset: 0x00001C1C
        private void Btn_P3_Icon_MouseDown(object sender, MouseEventArgs e)
        {
            this.HidePages();
            this.Panel_P3.Visible = true;
            Form1.P3_Selected = true;
            this.LBL_PlayerName.Visible = true;
            this.LBL_PlayerName.Text = "Player: " + PlayerFunctions.GetPlayerName(2);
        }

        // Token: 0x0600001C RID: 28 RVA: 0x00003A70 File Offset: 0x00001C70
        private void Btn_P4_Icon_MouseDown(object sender, MouseEventArgs e)
        {
            this.HidePages();
            this.Panel_P4.Visible = true;
            Form1.P4_Selected = true;
            this.LBL_PlayerName.Visible = true;
            this.LBL_PlayerName.Text = "Player: " + PlayerFunctions.GetPlayerName(3);
        }

        // Token: 0x0600001D RID: 29 RVA: 0x00003AC1 File Offset: 0x00001CC1
        private void Btn_Gib_P1_Click(object sender, EventArgs e)
        {
            PlayerFunctions.GiveWeapon0(0, this.Box_Weapons_P1.SelectedIndex);
        }

        // Token: 0x0600001E RID: 30 RVA: 0x00003AD6 File Offset: 0x00001CD6
        private void Btn_Gib2_P1_Click(object sender, EventArgs e)
        {
            PlayerFunctions.GiveWeapon1(0, this.Box_Weapons_P1.SelectedIndex);
        }

        // Token: 0x0600001F RID: 31 RVA: 0x00003AEC File Offset: 0x00001CEC
        private void CB_TP_ZM_SwitchedChanged(object sender)
        {
            bool switched = this.CB_TP_ZM.Switched;
            if (switched)
            {
                HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZTeleport, new byte[]
                {
                    184,
                    0,
                    0,
                    128,
                    63,
                    137,
                    129,
                    212,
                    2,
                    0,
                    0,
                    184,
                    0,
                    0,
                    128,
                    63,
                    137,
                    129,
                    216,
                    2,
                    0,
                    0,
                    184,
                    0,
                    0,
                    128,
                    63,
                    137,
                    129,
                    220,
                    2,
                    0,
                    0,
                    199,
                    129,
                    144,
                    3,
                    0,
                    0,
                    1,
                    0,
                    0,
                    0,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144
                }, false);
                Threads.ZmLocation = PlayerFunctions.GetLocation(0);
                HyperMEM.MEM.WriteFloat(HyperMEM.MEM.GameBase + Offsets.ZTeleport + 1UL, Threads.ZmLocation.X, false);
                HyperMEM.MEM.WriteFloat(HyperMEM.MEM.GameBase + Offsets.ZTeleport + 12UL, Threads.ZmLocation.Y, false);
                HyperMEM.MEM.WriteFloat(HyperMEM.MEM.GameBase + Offsets.ZTeleport + 23UL, Threads.ZmLocation.Z, false);
            }
            else
            {
                HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZTeleport, new byte[]
                {
                    139,
                    131,
                    128,
                    6,
                    0,
                    0,
                    137,
                    129,
                    212,
                    2,
                    0,
                    0,
                    243,
                    15,
                    16,
                    131,
                    132,
                    6,
                    0,
                    0,
                    243,
                    15,
                    17,
                    129,
                    216,
                    2,
                    0,
                    0,
                    243,
                    15,
                    16,
                    139,
                    136,
                    6,
                    0,
                    0,
                    243,
                    15,
                    17,
                    137,
                    220,
                    2,
                    0,
                    0,
                    199,
                    131,
                    188,
                    6,
                    0,
                    0,
                    0,
                    0,
                    0,
                    0,
                    51,
                    201
                }, false);
            }
        }

        // Token: 0x06000020 RID: 32 RVA: 0x00003BF6 File Offset: 0x00001DF6
        private void Btn_TP_Set_Click(object sender, EventArgs e)
        {
            Threads.ZmLocation = PlayerFunctions.GetLocation(0);
        }

        // Token: 0x06000021 RID: 33 RVA: 0x00003C04 File Offset: 0x00001E04
        private void Btn_TP_P1_Click(object sender, EventArgs e)
        {
            PlayerFunctions.Teleport(0, PlayerFunctions.Teleports[this.Box_TP_P1.SelectedIndex]);
        }

        // Token: 0x06000022 RID: 34 RVA: 0x00003C24 File Offset: 0x00001E24
        private void Btn_KillAll_Click(object sender, EventArgs e)
        {
            Threads.RestoreTool();
            bool flag = HyperMEM.MEM.ReadInt16(HyperMEM.MEM.GameBase + Offsets.ZSeshState) == 33;
            if (flag)
            {
                HyperMEM.MEM.WriteInt16(HyperMEM.MEM.GameBase + Offsets.ZSeshState, 4129, false);
            }
            for (int i = 0; i < 18; i++)
            {
                PlayerFunctions.SetGodMode(i, false);
                PlayerFunctions.SendToJail(i);
            }
        }

        // Token: 0x06000023 RID: 35 RVA: 0x00003CA0 File Offset: 0x00001EA0
        private void CB_Cycle_P1_SwitchedChanged(object sender)
        {
            bool switched = this.CB_Cycle_P1.Switched;
            if (switched)
            {
                Form1.P1_CurrentCycle = this.Box_CycleStart_P1.SelectedIndex;
                Form1.P1_CurrentKills = PlayerFunctions.GetPlayerKills(0);
                PlayerFunctions.SetPlayerShots(0, 0);
                PlayerFunctions.GiveWeapon0(0, this.Box_CycleStart_P1.SelectedIndex);
                PlayerFunctions.GiveWeapon1(0, this.Box_CycleStart_P1.SelectedIndex);
                PlayerFunctions.GiveWeapon2(0, this.Box_CycleStart_P1.SelectedIndex);
                PlayerFunctions.GiveWeapon3(0, this.Box_CycleStart_P1.SelectedIndex);
                PlayerFunctions.GiveWeapon4(0, this.Box_CycleStart_P1.SelectedIndex);
                PlayerFunctions.GiveWeapon5(0, this.Box_CycleStart_P1.SelectedIndex);
                this.timer1.Start();
            }
            else
            {
                this.timer1.Stop();
            }
        }

        // Token: 0x06000024 RID: 36 RVA: 0x00003D70 File Offset: 0x00001F70
        private void CB_Cycle_P2_SwitchedChanged(object sender)
        {
            bool switched = this.CB_Cycle_P2.Switched;
            if (switched)
            {
                Form1.P2_CurrentCycle = this.Box_CycleStart_P2.SelectedIndex;
                Form1.P2_CurrentKills = PlayerFunctions.GetPlayerKills(1);
                PlayerFunctions.SetPlayerShots(1, 0);
                PlayerFunctions.GiveWeapon0(1, this.Box_CycleStart_P2.SelectedIndex);
                PlayerFunctions.GiveWeapon1(1, this.Box_CycleStart_P2.SelectedIndex);
                PlayerFunctions.GiveWeapon2(1, this.Box_CycleStart_P2.SelectedIndex);
                PlayerFunctions.GiveWeapon3(1, this.Box_CycleStart_P2.SelectedIndex);
                PlayerFunctions.GiveWeapon4(1, this.Box_CycleStart_P2.SelectedIndex);
                PlayerFunctions.GiveWeapon5(1, this.Box_CycleStart_P2.SelectedIndex);
                this.timer2.Start();
            }
            else
            {
                this.timer2.Stop();
            }
        }

        // Token: 0x06000025 RID: 37 RVA: 0x00003E40 File Offset: 0x00002040
        private void CB_Cycle_P3_SwitchedChanged(object sender)
        {
            bool switched = this.CB_Cycle_P3.Switched;
            if (switched)
            {
                Form1.P3_CurrentCycle = this.Box_CycleStart_P3.SelectedIndex;
                Form1.P3_CurrentKills = PlayerFunctions.GetPlayerKills(2);
                PlayerFunctions.SetPlayerShots(2, 0);
                PlayerFunctions.GiveWeapon0(2, this.Box_CycleStart_P3.SelectedIndex);
                PlayerFunctions.GiveWeapon1(2, this.Box_CycleStart_P3.SelectedIndex);
                PlayerFunctions.GiveWeapon2(2, this.Box_CycleStart_P3.SelectedIndex);
                PlayerFunctions.GiveWeapon3(2, this.Box_CycleStart_P3.SelectedIndex);
                PlayerFunctions.GiveWeapon4(2, this.Box_CycleStart_P3.SelectedIndex);
                PlayerFunctions.GiveWeapon5(2, this.Box_CycleStart_P3.SelectedIndex);
                this.timer3.Start();
            }
            else
            {
                this.timer3.Stop();
            }
        }

        // Token: 0x06000026 RID: 38 RVA: 0x00003F10 File Offset: 0x00002110


        // Token: 0x06000027 RID: 39 RVA: 0x00003FE0 File Offset: 0x000021E0
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int playerShots = PlayerFunctions.GetPlayerShots(0);
            int playerKills = PlayerFunctions.GetPlayerKills(0);
            int num = playerKills - Form1.P1_CurrentKills;
            bool flag = playerShots >= this.Bar_Shots.Value || num >= this.Bar_Kills.Value;
            if (flag)
            {
                Form1.P1_CurrentKills = PlayerFunctions.GetPlayerKills(0);
                PlayerFunctions.SetPlayerShots(0, 0);
                PlayerFunctions.GiveWeapon0(0, Form1.P1_CurrentCycle);
                PlayerFunctions.GiveWeapon1(0, Form1.P1_CurrentCycle);
                PlayerFunctions.GiveWeapon2(0, Form1.P1_CurrentCycle);
                PlayerFunctions.GiveWeapon3(0, Form1.P1_CurrentCycle);
                PlayerFunctions.GiveWeapon4(0, Form1.P1_CurrentCycle);
                PlayerFunctions.GiveWeapon5(0, Form1.P1_CurrentCycle);
                Form1.P1_CurrentCycle++;
                bool flag2 = Form1.P1_CurrentCycle >= this.Box_CycleEnd_P1.SelectedIndex + 1 || Form1.P1_CurrentCycle >= PlayerFunctions.GunList.Length;
                if (flag2)
                {
                    this.CB_Cycle_P1.Switched = false;
                    this.timer1.Stop();
                }
            }
        }

        // Token: 0x06000028 RID: 40 RVA: 0x000040E0 File Offset: 0x000022E0
        private void timer2_Tick(object sender, EventArgs e)
        {
            int playerShots = PlayerFunctions.GetPlayerShots(1);
            int playerKills = PlayerFunctions.GetPlayerKills(1);
            int num = playerKills - Form1.P2_CurrentKills;
            bool flag = playerShots >= this.Bar_Shots.Value || num >= this.Bar_Kills.Value;
            if (flag)
            {
                Form1.P2_CurrentKills = PlayerFunctions.GetPlayerKills(1);
                PlayerFunctions.SetPlayerShots(1, 0);
                PlayerFunctions.GiveWeapon0(1, Form1.P2_CurrentCycle);
                PlayerFunctions.GiveWeapon1(1, Form1.P2_CurrentCycle);
                PlayerFunctions.GiveWeapon2(1, Form1.P2_CurrentCycle);
                PlayerFunctions.GiveWeapon3(1, Form1.P2_CurrentCycle);
                PlayerFunctions.GiveWeapon4(1, Form1.P2_CurrentCycle);
                PlayerFunctions.GiveWeapon5(1, Form1.P2_CurrentCycle);
                Form1.P2_CurrentCycle++;
                bool flag2 = Form1.P2_CurrentCycle >= this.Box_CycleEnd_P2.SelectedIndex + 1 || Form1.P2_CurrentCycle >= PlayerFunctions.GunList.Length;
                if (flag2)
                {
                    this.CB_Cycle_P2.Switched = false;
                    this.timer2.Stop();
                }
            }
        }

        // Token: 0x06000029 RID: 41 RVA: 0x000041E0 File Offset: 0x000023E0
        private void timer3_Tick(object sender, EventArgs e)
        {
            int playerShots = PlayerFunctions.GetPlayerShots(2);
            int playerKills = PlayerFunctions.GetPlayerKills(2);
            int num = playerKills - Form1.P3_CurrentKills;
            bool flag = playerShots >= this.Bar_Shots.Value || num >= this.Bar_Kills.Value;
            if (flag)
            {
                Form1.P3_CurrentKills = PlayerFunctions.GetPlayerKills(2);
                PlayerFunctions.SetPlayerShots(2, 0);
                PlayerFunctions.GiveWeapon0(2, Form1.P3_CurrentCycle);
                PlayerFunctions.GiveWeapon1(2, Form1.P3_CurrentCycle);
                PlayerFunctions.GiveWeapon2(2, Form1.P3_CurrentCycle);
                PlayerFunctions.GiveWeapon3(2, Form1.P3_CurrentCycle);
                PlayerFunctions.GiveWeapon4(2, Form1.P3_CurrentCycle);
                PlayerFunctions.GiveWeapon5(2, Form1.P3_CurrentCycle);
                Form1.P3_CurrentCycle++;
                bool flag2 = Form1.P3_CurrentCycle >= this.Box_CycleEnd_P3.SelectedIndex + 1 || Form1.P3_CurrentCycle >= PlayerFunctions.GunList.Length;
                if (flag2)
                {
                    this.CB_Cycle_P3.Switched = false;
                    this.timer3.Stop();
                }
            }
        }

        // Token: 0x0600002A RID: 42 RVA: 0x000042E0 File Offset: 0x000024E0
        private void timer4_Tick(object sender, EventArgs e)
        {
            int playerShots = PlayerFunctions.GetPlayerShots(3);
            int playerKills = PlayerFunctions.GetPlayerKills(3);
            int num = playerKills - Form1.P4_CurrentKills;
            bool flag = playerShots >= this.Bar_Shots.Value || num >= this.Bar_Kills.Value;
            if (flag)
            {
                Form1.P4_CurrentKills = PlayerFunctions.GetPlayerKills(3);
                PlayerFunctions.SetPlayerShots(3, 0);
                PlayerFunctions.GiveWeapon0(3, Form1.P4_CurrentCycle);
                PlayerFunctions.GiveWeapon1(3, Form1.P4_CurrentCycle);
                PlayerFunctions.GiveWeapon2(3, Form1.P4_CurrentCycle);
                PlayerFunctions.GiveWeapon3(3, Form1.P4_CurrentCycle);
                PlayerFunctions.GiveWeapon4(3, Form1.P4_CurrentCycle);
                PlayerFunctions.GiveWeapon5(3, Form1.P4_CurrentCycle);
                Form1.P4_CurrentCycle++;

            }
        }

        // Token: 0x0600002B RID: 43 RVA: 0x000043E0 File Offset: 0x000025E0
        private void Bar_Kills_ValueChanged(object sender, EventArgs e)
        {
            this.LBL_Kills.Text = "Weapon Cycle: " + this.Bar_Kills.Value.ToString() + " Kills";
        }

        // Token: 0x0600002C RID: 44 RVA: 0x0000441C File Offset: 0x0000261C
        private void Bar_Shots_ValueChanged(object sender, EventArgs e)
        {
            this.LBL_Shots.Text = "Weapon Cycle: " + this.Bar_Shots.Value.ToString() + " Shots";
        }

        // Token: 0x0600002D RID: 45 RVA: 0x00004458 File Offset: 0x00002658
        private void Btn_P1_Icon_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Player 1 Comp = 0x" + Offsets.PlayerCompPtr.ToString("X"));
            Debug.WriteLine("Player 1 Ped = 0x" + Offsets.PlayerPedPtr.ToString("X"));
            Debug.WriteLine("Player 1 POS = " + PlayerFunctions.GetLocation(0).ToString());
            Debug.WriteLine("Player 1 points addr = 0x" + (Offsets.PlayerPedPtr + Offsets.PP_Health).ToString("X"));
        }

        // Token: 0x0600002E RID: 46 RVA: 0x000044F0 File Offset: 0x000026F0
        public static void ZBetterMagic()
        {
        }

        // Token: 0x0600002F RID: 47 RVA: 0x000044F4 File Offset: 0x000026F4
        public static void Magic()
        {
            bool inGame = Threads.InGame;
            if (inGame)
            {
                bool flag = Form1.CodeCave > 0UL;
                if (flag)
                {
                    HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZShoot, new byte[]
                    {
                        72,
                        137,
                        92,
                        36,
                        8
                    }, false);
                    HyperMEM.MEM.WriteBytes(Form1.CodeCave, new byte[75], false);
                }
                Form1.CodeCave = HyperMEM.MEM.FindCodeCave(HyperMEM.MEM.GameBase + Offsets.ZShoot, HyperMEM.MEM.GameBase + HyperMEM.MEM.GameSize, 1000UL) + 100UL;
                Debug.WriteLine(Form1.CodeCave.ToString("X"));
                bool flag2 = Form1.CodeCave > Offsets.ZShoot;
                if (flag2)
                {
                    ulong num = HyperMEM.MEM.GameBase + Offsets.ZShoot + 5UL - (Form1.CodeCave + 58UL) - 4UL;
                    HyperMEM.MEM.WriteBytes(Form1.CodeCave, new byte[]
                    {
                        76,
                        139,
                        84,
                        36,
                        48,
                        77,
                        133,
                        210,
                        116,
                        28,
                        72,
                        184,
                        18,
                        120,
                        146,
                        247,
                        72,
                        86,
                        165,
                        118,
                        73,
                        57,
                        2,
                        117,
                        13,
                        72,
                        184,
                        158,
                        16,
                        187,
                        183,
                        141,
                        61,
                        byte.MaxValue,
                        123,
                        73,
                        137,
                        2,
                        72,
                        199,
                        68,
                        36,
                        56,
                        196,
                        9,
                        0,
                        0,
                        76,
                        137,
                        84,
                        36,
                        48,
                        72,
                        137,
                        92,
                        36,
                        8,
                        233,
                        35,
                        235,
                        239,
                        5
                    }, false);
                    HyperMEM.MEM.WriteInt32(Form1.CodeCave + 58UL, (int)num, false);
                    HyperMEM mem = HyperMEM.MEM;
                    ulong address = HyperMEM.MEM.GameBase + Offsets.ZShoot;
                    byte[] array = new byte[5];
                    array[0] = 233;
                    mem.WriteBytes(address, array, false);
                    HyperMEM.MEM.WriteInt32(HyperMEM.MEM.GameBase + Offsets.ZShoot + 1UL, -(int)num - 58 - 4, false);
                }
            }
        }

        // Token: 0x06000030 RID: 48 RVA: 0x00004678 File Offset: 0x00002878
        private void Btn_Dark_Click(object sender, EventArgs e)
        {
            bool flag = this.Box_Weapons_P1.Items.Count == PlayerFunctions.GunNamesMP.Length;
            if (flag)
            {
                this.SetupZMGuns();
            }
            Form1.Magic();
        }

        // Token: 0x06000031 RID: 49 RVA: 0x000046B4 File Offset: 0x000028B4
        private void Btn_Kill_multi_Click(object sender, EventArgs e)
        {
            bool flag = this.Box_Weapons_P1.Items.Count == PlayerFunctions.GunNamesMP.Length;
            if (flag)
            {
                this.SetupZMGuns();
            }
            bool inGame = Threads.InGame;
            if (inGame)
            {
                bool flag2 = Form1.CodeCave2 > 0UL;
                if (flag2)
                {
                    HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZKill, new byte[]
                    {
                        72,
                        137,
                        92,
                        36,
                        8
                    }, false);
                    HyperMEM.MEM.WriteBytes(Form1.CodeCave2, new byte[75], false);
                }
                Form1.CodeCave2 = HyperMEM.MEM.FindCodeCave(HyperMEM.MEM.GameBase + Offsets.ZKill, HyperMEM.MEM.GameBase + HyperMEM.MEM.GameSize, 1000UL) + 100UL;
                bool flag3 = Form1.CodeCave2 > Offsets.ZKill;
                if (flag3)
                {
                    ulong num = HyperMEM.MEM.GameBase + Offsets.ZKill + 5UL - (Form1.CodeCave2 + 205UL) - 4UL;
                    HyperMEM.MEM.WriteBytes(Form1.CodeCave2, new byte[]
                    {
                        72,
                        137,
                        92,
                        36,
                        8,
                        72,
                        137,
                        108,
                        36,
                        16,
                        72,
                        137,
                        116,
                        36,
                        24,
                        87,
                        65,
                        84,
                        65,
                        85,
                        65,
                        86,
                        65,
                        87,
                        72,
                        131,
                        236,
                        96,
                        76,
                        139,
                        188,
                        36,
                        224,
                        0,
                        0,
                        0,
                        65,
                        139,
                        249,
                        68,
                        139,
                        164,
                        36,
                        216,
                        0,
                        0,
                        0,
                        73,
                        139,
                        240,
                        68,
                        139,
                        172,
                        36,
                        208,
                        0,
                        0,
                        0,
                        72,
                        139,
                        234,
                        76,
                        139,
                        241,
                        187,
                        50,
                        0,
                        0,
                        0,
                        102,
                        102,
                        102,
                        15,
                        31,
                        132,
                        0,
                        0,
                        0,
                        0,
                        0,
                        72,
                        139,
                        132,
                        36,
                        200,
                        0,
                        0,
                        0,
                        68,
                        139,
                        207,
                        76,
                        137,
                        124,
                        36,
                        80,
                        76,
                        139,
                        198,
                        68,
                        137,
                        100,
                        36,
                        72,
                        72,
                        139,
                        213,
                        68,
                        137,
                        108,
                        36,
                        64,
                        73,
                        139,
                        206,
                        72,
                        137,
                        68,
                        36,
                        56,
                        72,
                        139,
                        132,
                        36,
                        192,
                        0,
                        0,
                        0,
                        72,
                        137,
                        68,
                        36,
                        48,
                        72,
                        139,
                        132,
                        36,
                        184,
                        0,
                        0,
                        0,
                        72,
                        137,
                        68,
                        36,
                        40,
                        139,
                        132,
                        36,
                        176,
                        0,
                        0,
                        0,
                        137,
                        68,
                        36,
                        32,
                        232,
                        37,
                        0,
                        0,
                        0,
                        144,
                        72,
                        131,
                        235,
                        1,
                        117,
                        167,
                        76,
                        141,
                        92,
                        36,
                        96,
                        73,
                        139,
                        91,
                        48,
                        73,
                        139,
                        107,
                        56,
                        73,
                        139,
                        115,
                        64,
                        73,
                        139,
                        227,
                        65,
                        95,
                        65,
                        94,
                        65,
                        93,
                        65,
                        92,
                        95,
                        195,
                        72,
                        137,
                        92,
                        36,
                        8,
                        233,
                        128,
                        152,
                        195,
                        252
                    }, false);
                    HyperMEM.MEM.WriteInt32(Form1.CodeCave2 + 205UL, (int)num, false);
                    HyperMEM mem = HyperMEM.MEM;
                    ulong address = HyperMEM.MEM.GameBase + Offsets.ZKill;
                    byte[] array = new byte[5];
                    array[0] = 233;
                    mem.WriteBytes(address, array, false);
                    HyperMEM.MEM.WriteInt32(HyperMEM.MEM.GameBase + Offsets.ZKill + 1UL, -(int)num - 205 - 4, false);
                }
            }
        }

        // Token: 0x06000032 RID: 50 RVA: 0x00004858 File Offset: 0x00002A58

        // Token: 0x06000034 RID: 52 RVA: 0x00004882 File Offset: 0x00002A82
        private void Btn_Gib_P3_Click(object sender, EventArgs e)
        {
            PlayerFunctions.GiveWeapon0(2, this.Box_Weapons_P3.SelectedIndex);
        }

        // Token: 0x06000035 RID: 53 RVA: 0x00004897 File Offset: 0x00002A97
        private void Btn_Gib2_P3_Click(object sender, EventArgs e)
        {
            PlayerFunctions.GiveWeapon1(2, this.Box_Weapons_P3.SelectedIndex);
        }

        // Token: 0x06000036 RID: 54 RVA: 0x000048AC File Offset: 0x00002AAC
        private void Btn_Gib_P2_Click(object sender, EventArgs e)
        {
            PlayerFunctions.GiveWeapon0(1, this.Box_Weapons_P2.SelectedIndex);
        }

        // Token: 0x06000037 RID: 55 RVA: 0x000048C1 File Offset: 0x00002AC1
        private void Btn_Gib2_P2_Click(object sender, EventArgs e)
        {
            PlayerFunctions.GiveWeapon1(1, this.Box_Weapons_P2.SelectedIndex);
        }

        // Token: 0x06000038 RID: 56 RVA: 0x000048D6 File Offset: 0x00002AD6
        private void Dtn_Diamond_Click(object sender, EventArgs e)
        {
            HyperMEM.MEM.WriteInt16(HyperMEM.MEM.GameBase + Offsets.ZSeshState, 33, false);
            Form1.Magic();
            MessageBox.Show("Instant Diamond is Ready! \nBefore you end the game you MUST press... \nKill All Players & Reset Tool");
        }

        // Token: 0x06000039 RID: 57 RVA: 0x00004908 File Offset: 0x00002B08
        private void Panel_Server_Paint(object sender, PaintEventArgs e)
        {
        }

        // Token: 0x0600003A RID: 58 RVA: 0x0000490B File Offset: 0x00002B0B
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            PornHub.Security.Functions.CloseMyself();
        }

        // Token: 0x0600003B RID: 59 RVA: 0x00004914 File Offset: 0x00002B14
        private void LBL_Gun_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PlayerFunctions.GetPlayerGunID(0));
            MessageBox.Show("Gun ID Copied");
           
        }

        // Token: 0x0600003C RID: 60 RVA: 0x00004930 File Offset: 0x00002B30
        private void Btn_QuickDA_Click(object sender, EventArgs e)
        {
            Threads.RestoreTool();
            bool flag = this.Box_Weapons_P1.Items.Count == PlayerFunctions.GunNamesMP.Length;
            if (flag)
            {
                this.SetupZMGuns();
            }
            Form1.Magic();
            this.CB_TP_ZM.Switched = true;
            this.CB_God_P1.Switched = true;
            this.CB_God_P2.Switched = true;
            this.CB_God_P3.Switched = true;

            this.CB_Ammo_P1.Switched = true;
            this.CB_Ammo_P2.Switched = true;
            this.CB_Ammo_P3.Switched = true;
            this.CB_Crit_P1.Switched = true;
            this.CB_Crit_P2.Switched = true;
            this.CB_Crit_P3.Switched = true;
            this.CB_Rapid_P1.Switched = true;
            this.CB_Rapid_P2.Switched = true;
            this.CB_Rapid_P3.Switched = true;
            this.CB_Cycle_P1.Switched = true;
            this.CB_Cycle_P2.Switched = true;
            this.CB_Cycle_P3.Switched = true;
            this.CB_Shoot_P1.Switched = true;
            this.CB_Shoot_P2.Switched = true;
            this.CB_Shoot_P3.Switched = true;
            this.Bar_Kills.Value = 1;
            this.Bar_Shots.Value = 5;
        }

        // Token: 0x0600003D RID: 61 RVA: 0x00004ACF File Offset: 0x00002CCF
        private void Btn_TP_Bots_Click(object sender, EventArgs e)
        {
            Threads.BotLocation = PlayerFunctions.GetLocation(0);
        }

        // Token: 0x0600003E RID: 62 RVA: 0x00004ADD File Offset: 0x00002CDD
        private void CB_Bots_SwitchedChanged(object sender)
        {
            Threads.BotLocation = PlayerFunctions.GetLocation(0);
        }

        // Token: 0x0600003F RID: 63 RVA: 0x00004AEB File Offset: 0x00002CEB
        // Token: 0x06000040 RID: 64 RVA: 0x00004AFC File Offset: 0x00002CFC
        private void Btn_ForceZM_Click(object sender, EventArgs e)
        {
            bool flag = HyperMEM.MEM.ReadInt16(HyperMEM.MEM.GameBase + Offsets.ZSeshState) == 4129;
            if (flag)
            {
                this.zqinForce();
            }
        }

        // Token: 0x06000041 RID: 65 RVA: 0x00004B38 File Offset: 0x00002D38
        private void CB_RoundSkip_SwitchedChanged(object sender)
        {
            bool switched = this.CB_RoundSkip.Switched;
            if (switched)
            {
                HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZRound, new byte[]
                {
                    139,
                    145,
                    33,
                    2,
                    0,
                    0
                }, false);
            }
            else
            {
                HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZRound, new byte[]
                {
                    139,
                    145,
                    32,
                    2,
                    0,
                    0
                }, false);
            }
        }

        // Token: 0x06000042 RID: 66 RVA: 0x00004BB5 File Offset: 0x00002DB5
        private void Bar_Kills_Scroll(object sender, ScrollEventArgs e)
        {
        }

        // Token: 0x06000043 RID: 67 RVA: 0x00004BB8 File Offset: 0x00002DB8
        private void Btn_TP_P2_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x06000044 RID: 68 RVA: 0x00004BBB File Offset: 0x00002DBB
        private void DAHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-------------------------------------------------------\nDark Aether Tutorial\n-----\nStep 1: Launch Private Match Zombies\nStep2: Spawn in!\nStep3: Click (Set Quick DA Settings)\nStep4: Shoot in the air till melee weapons\nStep5: Melee zombies with melee weapons\nStep6: Weapon cycle ends on Raygun!! Congrats\nStep7: >>>>>>>>YOU MUST CLICK (SAFE END MATCH)<<<<<<<<\nStep8: Match will end by itself and you are done\n-------------------------------------------------------", "Dark Aether Tutorial");
        }

        // Token: 0x06000045 RID: 69 RVA: 0x00004BD0 File Offset: 0x00002DD0
        private void metroSwitch1_SwitchedChanged_1(object sender)
        {
            bool switched = this.CB_Noclip.Switched;
            if (switched)
            {
                HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZNoClipFunc, new byte[]
                {
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    243,
                    15,
                    16,
                    69,
                    168,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    243,
                    15,
                    16,
                    69,
                    172,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144
                }, false);
            }
            else
            {
                HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZNoClipFunc, new byte[]
                {
                    243,
                    15,
                    17,
                    128,
                    232,
                    13,
                    0,
                    0,
                    243,
                    15,
                    16,
                    69,
                    168,
                    243,
                    15,
                    17,
                    128,
                    240,
                    13,
                    0,
                    0,
                    243,
                    15,
                    16,
                    69,
                    172,
                    243,
                    15,
                    17,
                    136,
                    236,
                    13,
                    0,
                    0
                }, false);
            }
        }

        // Token: 0x06000046 RID: 70 RVA: 0x00004C50 File Offset: 0x00002E50
        private void CB_XP_SwitchedChanged(object sender)
        {
            Offsets.ZRoundSkip = 166585072UL;
            Offsets.ZRoundEntitiy = 288199464UL;
            byte[] array = new byte[]
            {
                72,
                139,
                196,
                72,
                137,
                104,
                32,
                72,
                137,
                72,
                8,
                86,
                65,
                84,
                65,
                85,
                65,
                86,
                65,
                87,
                72,
                131,
                236,
                96,
                68,
                139,
                164,
                36,
                216,
                0,
                0,
                0,
                69,
                139,
                241,
                68,
                139,
                172,
                36,
                208,
                0,
                0,
                0,
                73,
                139,
                240,
                72,
                139,
                172,
                36,
                200,
                0,
                0,
                0,
                76,
                139,
                250,
                77,
                133,
                192,
                15,
                132,
                7,
                1,
                0,
                0,
                102,
                65,
                131,
                184,
                130,
                2,
                0,
                0,
                1,
                15,
                133,
                248,
                0,
                0,
                0,
                72,
                139,
                21,
                150,
                1,
                0,
                0,
                72,
                137,
                88,
                16,
                72,
                99,
                154,
                144,
                0,
                0,
                0,
                59,
                90,
                16,
                15,
                141,
                213,
                0,
                0,
                0,
                72,
                137,
                120,
                24,
                72,
                105,
                251,
                232,
                5,
                0,
                0,
                102,
                15,
                31,
                132,
                0,
                0,
                0,
                0,
                0,
                76,
                139,
                66,
                8,
                102,
                66,
                131,
                188,
                7,
                130,
                2,
                0,
                0,
                15,
                15,
                133,
                147,
                0,
                0,
                0,
                66,
                131,
                188,
                7,
                144,
                3,
                0,
                0,
                0,
                15,
                142,
                132,
                0,
                0,
                0,
                66,
                131,
                188,
                7,
                148,
                3,
                0,
                0,
                0,
                126,
                121,
                66,
                246,
                132,
                7,
                59,
                3,
                0,
                0,
                1,
                116,
                110,
                139,
                69,
                8,
                69,
                139,
                206,
                242,
                15,
                16,
                69,
                0,
                73,
                139,
                215,
                137,
                68,
                36,
                88,
                68,
                137,
                100,
                36,
                72,
                68,
                137,
                108,
                36,
                64,
                72,
                99,
                195,
                72,
                105,
                200,
                232,
                5,
                0,
                0,
                242,
                15,
                17,
                68,
                36,
                80,
                72,
                141,
                68,
                36,
                80,
                72,
                137,
                68,
                36,
                56,
                73,
                3,
                200,
                72,
                139,
                132,
                36,
                192,
                0,
                0,
                0,
                76,
                139,
                198,
                72,
                137,
                68,
                36,
                48,
                72,
                139,
                132,
                36,
                184,
                0,
                0,
                0,
                72,
                137,
                68,
                36,
                40,
                139,
                132,
                36,
                176,
                0,
                0,
                0,
                137,
                68,
                36,
                32,
                232,
                166,
                0,
                0,
                0,
                144,
                72,
                139,
                21,
                199,
                0,
                0,
                0,
                byte.MaxValue,
                195,
                72,
                129,
                199,
                232,
                5,
                0,
                0,
                59,
                90,
                16,
                15,
                140,
                71,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                72,
                139,
                188,
                36,
                160,
                0,
                0,
                0,
                72,
                139,
                156,
                36,
                152,
                0,
                0,
                0,
                139,
                69,
                8,
                69,
                139,
                206,
                242,
                15,
                16,
                69,
                0,
                76,
                139,
                198,
                72,
                139,
                140,
                36,
                144,
                0,
                0,
                0,
                73,
                139,
                215,
                137,
                68,
                36,
                88,
                72,
                141,
                68,
                36,
                80,
                68,
                137,
                100,
                36,
                72,
                68,
                137,
                108,
                36,
                64,
                72,
                137,
                68,
                36,
                56,
                72,
                139,
                132,
                36,
                192,
                0,
                0,
                0,
                72,
                137,
                68,
                36,
                48,
                72,
                139,
                132,
                36,
                184,
                0,
                0,
                0,
                72,
                137,
                68,
                36,
                40,
                139,
                132,
                36,
                176,
                0,
                0,
                0,
                137,
                68,
                36,
                32,
                242,
                15,
                17,
                68,
                36,
                80,
                232,
                27,
                0,
                0,
                0,
                144,
                72,
                139,
                172,
                36,
                168,
                0,
                0,
                0,
                72,
                131,
                196,
                96,
                65,
                95,
                65,
                94,
                65,
                93,
                65,
                92,
                94,
                195,
                0,
                0,
                0,
                0,
                72,
                137,
                92,
                36,
                8,
                72,
                137,
                108,
                36,
                16,
                72,
                137,
                116,
                36,
                24,
                68,
                137,
                76,
                36,
                32,
                byte.MaxValue,
                37,
                4,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                4,
                227,
                27,
                250,
                246,
                127,
                0,
                0,
                0,
                0,
                0,
                40,
                147,
                91,
                1,
                247,
                127
            };
            byte[] buffer = new byte[]
            {
                72,
                137,
                92,
                36,
                8,
                72,
                137,
                108,
                36,
                16,
                72,
                137,
                116,
                36,
                24,
                68,
                137,
                76,
                36,
                32
            };
            bool switched = this.CB_AutoKill.Switched;
            if (switched)
            {
                bool inGame = Threads.InGame;
                if (inGame)
                {
                    bool flag = Form1.XP_CAVE > 0UL;
                    if (flag)
                    {
                        HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZRoundSkip, buffer, false);
                        HyperMEM.MEM.WriteBytes(Form1.XP_CAVE, new byte[568], false);
                    }
                    Form1.XP_CAVE = HyperMEM.MEM.FindCodeCave(HyperMEM.MEM.GameBase, HyperMEM.MEM.GameBase + HyperMEM.MEM.GameSize, 1000UL) + 100UL;
                    Debug.WriteLine(Form1.XP_CAVE.ToString("X"));
                    bool flag2 = HyperMEM.MEM.IsValidAddr(Form1.XP_CAVE);
                    if (flag2)
                    {
                        HyperMEM.MEM.WriteBytes(Form1.XP_CAVE, array, false);
                        HyperMEM.MEM.WriteInt64(Form1.XP_CAVE + (ulong)((long)array.Length) - 17UL, (long)(HyperMEM.MEM.GameBase + Offsets.ZRoundSkip + 20UL), false);
                        HyperMEM.MEM.WriteInt64(Form1.XP_CAVE + (ulong)((long)array.Length) - 6UL, (long)(HyperMEM.MEM.GameBase + Offsets.ZRoundEntitiy), false);
                        HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZRoundSkip, new byte[]
                        {
                            byte.MaxValue,
                            37,
                            1,
                            0,
                            0,
                            0,
                            144,
                            0,
                            1,
                            105,
                            240,
                            246,
                            127,
                            0,
                            0,
                            144,
                            144,
                            144,
                            144,
                            144
                        }, false);
                        HyperMEM.MEM.WriteInt64(HyperMEM.MEM.GameBase + Offsets.ZRoundSkip + 7UL, (long)Form1.XP_CAVE, false);
                    }
                }
            }
            else
            {
                bool flag3 = Form1.XP_CAVE > 0UL;
                if (flag3)
                {
                    HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZRoundSkip, buffer, false);
                    HyperMEM.MEM.WriteBytes(Form1.XP_CAVE, new byte[625], false);
                }
            }
        }

        // Token: 0x06000047 RID: 71 RVA: 0x00004E78 File Offset: 0x00003078
        private void XP_Timer_Tick(object sender, EventArgs e)
        {
            int num = HyperMEM.MEM.ReadInt32(HyperMEM.MEM.GameBase + 287881332UL);
            bool flag = Form1.Current_Round != num;
            if (flag)
            {
                Form1.Current_Round = HyperMEM.MEM.ReadInt32(HyperMEM.MEM.GameBase + 287881332UL);
                PlayerFunctions.SetPlayerKills(0, 0);
                PlayerFunctions.SetPlayerKills(1, 0);
                PlayerFunctions.SetPlayerKills(2, 0);
                PlayerFunctions.SetPlayerKills(3, 0);
            }
            int playerKills = PlayerFunctions.GetPlayerKills(0);
            int playerKills2 = PlayerFunctions.GetPlayerKills(1);
            int playerKills3 = PlayerFunctions.GetPlayerKills(2);
            int playerKills4 = PlayerFunctions.GetPlayerKills(3);
            if (playerKills <= 0)
            {
            }
            bool flag2 = (playerKills2 > 0 || PlayerFunctions.GetPlayerName(1) == "") && (playerKills3 > 0 || PlayerFunctions.GetPlayerName(2) == "") && (playerKills4 > 0 || PlayerFunctions.GetPlayerName(3) == "");
            if (flag2)
            {
                bool flag3 = !this.CB_AutoKill.Switched;
                if (flag3)
                {
                }
                bool flag4 = Form1.Cave_XP != 0UL && Form1.ISXP;
                if (flag4)
                {
                    Thread.Sleep(1000);
                    HyperMEM.MEM.WriteInt32(Form1.Cave_XP + 1UL, 0, false);
                    Form1.ISXP = false;
                }
                PlayerFunctions.GiveWeapon0(0, 0);
                PlayerFunctions.GiveWeapon1(0, 0);
                PlayerFunctions.GiveWeapon2(0, 0);
                PlayerFunctions.GiveWeapon3(0, 0);
                PlayerFunctions.GiveWeapon4(0, 0);
                PlayerFunctions.GiveWeapon5(0, 0);
                PlayerFunctions.SetAmmo(0, 256);
                PlayerFunctions.SetPlayerSpeed(0, 1f);
                PlayerFunctions.GiveWeapon0(1, 0);
                PlayerFunctions.GiveWeapon1(1, 0);
                PlayerFunctions.GiveWeapon2(1, 0);
                PlayerFunctions.GiveWeapon3(1, 0);
                PlayerFunctions.GiveWeapon4(1, 0);
                PlayerFunctions.GiveWeapon5(1, 0);
                PlayerFunctions.SetAmmo(1, 256);
                PlayerFunctions.SetPlayerSpeed(1, 1f);
                PlayerFunctions.GiveWeapon0(2, 0);
                PlayerFunctions.GiveWeapon1(2, 0);
                PlayerFunctions.GiveWeapon2(2, 0);
                PlayerFunctions.GiveWeapon3(2, 0);
                PlayerFunctions.GiveWeapon4(2, 0);
                PlayerFunctions.GiveWeapon5(2, 0);
                PlayerFunctions.SetAmmo(2, 256);
                PlayerFunctions.SetPlayerSpeed(2, 1f);
                PlayerFunctions.GiveWeapon0(3, 0);
                PlayerFunctions.GiveWeapon1(3, 0);
                PlayerFunctions.GiveWeapon2(3, 0);
                PlayerFunctions.GiveWeapon3(3, 0);
                PlayerFunctions.GiveWeapon4(3, 0);
                PlayerFunctions.GiveWeapon5(3, 0);
                PlayerFunctions.SetAmmo(3, 256);
                PlayerFunctions.SetPlayerSpeed(3, 1f);
            }
            else
            {
                bool switched = this.CB_AutoKill.Switched;
                if (switched)
                {
                }
                bool flag5 = Form1.Cave_XP > 0UL;
                if (flag5)
                {
                    HyperMEM.MEM.WriteInt32(Form1.Cave_XP + 1UL, 55000 + 500 * num, false);
                    Form1.ISXP = true;
                }
                bool flag6 = playerKills == 0;
                if (flag6)
                {
                    PlayerFunctions.SetPlayerSpeed(0, 1f);
                    PlayerFunctions.GiveWeapon0(0, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon1(0, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon2(0, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon3(0, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon4(0, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon5(0, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.SetAmmo(0, 1);
                }
                else
                {
                    PlayerFunctions.SetPlayerSpeed(0, 0f);
                    PlayerFunctions.RemoveAmmo(0);
                }
                bool flag7 = playerKills2 == 0;
                if (flag7)
                {
                    PlayerFunctions.SetPlayerSpeed(1, 1f);
                    PlayerFunctions.GiveWeapon0(1, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon1(1, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon2(1, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon3(1, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon4(1, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon5(1, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.SetAmmo(1, 1);
                }
                else
                {
                    PlayerFunctions.SetPlayerSpeed(1, 0f);
                    PlayerFunctions.RemoveAmmo(1);
                }
                bool flag8 = playerKills3 == 0;
                if (flag8)
                {
                    PlayerFunctions.SetPlayerSpeed(2, 1f);
                    PlayerFunctions.GiveWeapon0(2, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon1(2, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon2(2, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon2(2, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon3(2, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon4(2, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon5(2, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.SetAmmo(2, 1);
                }
                else
                {
                    PlayerFunctions.SetPlayerSpeed(2, 0f);
                    PlayerFunctions.RemoveAmmo(2);
                }
                bool flag9 = playerKills4 == 0;
                if (flag9)
                {
                    PlayerFunctions.SetPlayerSpeed(3, 1f);
                    PlayerFunctions.GiveWeapon0(3, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon1(3, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon2(3, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon3(3, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon4(3, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.GiveWeapon5(3, PlayerFunctions.GunList.Length - 2);
                    PlayerFunctions.SetAmmo(3, 1);
                }
                else
                {
                    PlayerFunctions.SetPlayerSpeed(3, 0f);
                    PlayerFunctions.RemoveAmmo(3);
                }
            }
        }

        // Token: 0x06000048 RID: 72 RVA: 0x000053A0 File Offset: 0x000035A0
        public static void PatchXP(bool Patch)
        {
            Offsets.ZXP = 119629968UL;
            byte[] buffer = new byte[]
            {
                186,
                80,
                195,
                0,
                0,
                65,
                184,
                2,
                0,
                0,
                0,
                144,
                64,
                85,
                86,
                87,
                65,
                84,
                233,
                15,
                166,
                195,
                6,
                144
            };
            byte[] buffer2 = new byte[24];
            byte[] buffer3 = new byte[]
            {
                233,
                219,
                89,
                60,
                249,
                144
            };
            byte[] buffer4 = new byte[]
            {
                64,
                85,
                86,
                87,
                65,
                84
            };
            if (Patch)
            {
                bool inGame = Threads.InGame;
                if (inGame)
                {
                    bool flag = Form1.Cave_XP > 0UL;
                    if (flag)
                    {
                        HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZXP, buffer4, false);
                        HyperMEM.MEM.WriteBytes(Form1.Cave_XP, buffer2, false);
                    }
                    Form1.Cave_XP = HyperMEM.MEM.FindCodeCave(HyperMEM.MEM.GameBase + Offsets.ZXP, HyperMEM.MEM.GameBase + HyperMEM.MEM.GameSize, 500UL) + 100UL;
                    Debug.WriteLine(Form1.Cave_XP.ToString("X"));
                    bool flag2 = Form1.Cave_XP > Offsets.ZXP;
                    if (flag2)
                    {
                        ulong num = HyperMEM.MEM.GameBase + Offsets.ZXP + 5UL - (Form1.Cave_XP + 19UL) - 4UL;
                        HyperMEM.MEM.WriteBytes(Form1.Cave_XP, buffer, false);
                        HyperMEM.MEM.WriteInt32(Form1.Cave_XP + 19UL, (int)num, false);
                        HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZXP, buffer3, false);
                        HyperMEM.MEM.WriteInt32(HyperMEM.MEM.GameBase + Offsets.ZXP + 1UL, -(int)num - 19 - 4, false);
                    }
                }
            }
            else
            {
                HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZXP, buffer4, false);
                bool flag3 = Form1.Cave_XP > 0UL;
                if (flag3)
                {
                    HyperMEM.MEM.WriteBytes(Form1.Cave_XP, buffer2, false);
                }
            }
        }

        // Token: 0x06000049 RID: 73 RVA: 0x00005594 File Offset: 0x00003794
        private void CB_XP_SwitchedChanged_1(object sender)
        {
            IEnumerable<MetroSwitch> enumerable = Form1.ThisForm.FindAllChildrenByType<MetroSwitch>();
            IEnumerable<ForeverButton> enumerable2 = Form1.ThisForm.FindAllChildrenByType<ForeverButton>();
            bool switched = this.CB_XP.Switched;
            if (switched)
            {
                Threads.RestoreTool();
                this.CB_TP_ZM.Switched = true;
                Threads.ZmLocation.Z = Threads.ZmLocation.Z + 200f;
                HyperMEM.MEM.WriteFloat(HyperMEM.MEM.GameBase + Offsets.ZTeleport + 23UL, Threads.ZmLocation.Z, false);
                Form1.PatchXP(true);
                Form1.Current_Round = HyperMEM.MEM.ReadInt32(HyperMEM.MEM.GameBase + 287881332UL);
                PlayerFunctions.SetPlayerKills(0, 0);
                PlayerFunctions.SetPlayerKills(1, 0);
                PlayerFunctions.SetPlayerKills(2, 0);
                PlayerFunctions.SetPlayerKills(3, 0);
                this.XP_Timer.Start();
            }
            else
            {
                this.XP_Timer.Stop();
                Form1.PatchXP(false);
            }
            this.CB_XP.Enabled = true;
            this.Btn_KillAll.Enabled = true;
        }

        // Token: 0x040001A3 RID: 419
        private bool mouseDown;

        // Token: 0x040001A4 RID: 420
        private Point lastLocation;

        // Token: 0x040001A5 RID: 421
        public static Form1 ThisForm;

        // Token: 0x040001A6 RID: 422
        public static int Server_Rotation = 0;

        // Token: 0x040001A7 RID: 423
        public static bool Server_ClockWise = true;

        // Token: 0x040001A8 RID: 424
        public static bool Server_Hovered = false;

        // Token: 0x040001A9 RID: 425
        public static bool Server_Selected = true;

        // Token: 0x040001AA RID: 426
        public static int Server_Rotation_Amount = 15;

        // Token: 0x040001AB RID: 427
        public static int P1_Rotation = 0;

        // Token: 0x040001AC RID: 428
        public static bool P1_ClockWise = true;

        // Token: 0x040001AD RID: 429
        public static bool P1_Hovered = false;

        // Token: 0x040001AE RID: 430
        public static bool P1_Selected = false;

        // Token: 0x040001AF RID: 431
        public static int P1_Rotation_Amount = 15;

        // Token: 0x040001B0 RID: 432
        public static int P2_Rotation = 0;

        // Token: 0x040001B1 RID: 433
        public static bool P2_ClockWise = true;

        // Token: 0x040001B2 RID: 434
        public static bool P2_Hovered = false;

        // Token: 0x040001B3 RID: 435
        public static bool P2_Selected = false;

        // Token: 0x040001B4 RID: 436
        public static int P2_Rotation_Amount = 15;

        // Token: 0x040001B5 RID: 437
        public static int P3_Rotation = 0;

        // Token: 0x040001B6 RID: 438
        public static bool P3_ClockWise = true;

        // Token: 0x040001B7 RID: 439
        public static bool P3_Hovered = false;

        // Token: 0x040001B8 RID: 440
        public static bool P3_Selected = false;

        // Token: 0x040001B9 RID: 441
        public static int P3_Rotation_Amount = 15;

        // Token: 0x040001BA RID: 442
        public static int P4_Rotation = 0;

        // Token: 0x040001BB RID: 443
        public static bool P4_ClockWise = true;

        // Token: 0x040001BC RID: 444
        public static bool P4_Hovered = false;

        // Token: 0x040001BD RID: 445
        public static bool P4_Selected = false;

        // Token: 0x040001BE RID: 446
        public static int P4_Rotation_Amount = 15;

        // Token: 0x040001BF RID: 447
        public static int Discord_Rotation = 0;

        // Token: 0x040001C0 RID: 448
        public static bool Discord_ClockWise = true;

        // Token: 0x040001C1 RID: 449
        public static bool Discord_Hovered = false;

        // Token: 0x040001C2 RID: 450
        public static int Discord_Rotation_Amount = 15;

        // Token: 0x040001C3 RID: 451
        public static int P1_CurrentCycle = 0;

        // Token: 0x040001C4 RID: 452
        public static int P1_CurrentKills = 0;

        // Token: 0x040001C5 RID: 453
        public static int P2_CurrentCycle = 0;

        // Token: 0x040001C6 RID: 454
        public static int P2_CurrentKills = 0;

        // Token: 0x040001C7 RID: 455
        public static int P3_CurrentCycle = 0;

        // Token: 0x040001C8 RID: 456
        public static int P3_CurrentKills = 0;

        // Token: 0x040001C9 RID: 457
        public static int P4_CurrentCycle = 0;

        // Token: 0x040001CA RID: 458
        public static int P4_CurrentKills = 0;

        // Token: 0x040001CB RID: 459
        public static ulong CodeCave = 0UL;

        // Token: 0x040001CC RID: 460
        public static ulong CodeCave2 = 0UL;

        // Token: 0x040001CD RID: 461
        public static ulong XP_CAVE = 0UL;

        // Token: 0x040001CE RID: 462
        public static int Current_Round = 1;

        // Token: 0x040001CF RID: 463
        public static bool ISXP = true;

        // Token: 0x040001D0 RID: 464
        public static ulong Cave_XP = 0UL;

        private void Btn_P2_Icon_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            {
                bool switched = this.CB_RoundSkip.Switched;
                if (switched)
                {
                    HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZRound, new byte[]
                    {
                    139,
                    145,
                    33,
                    2,
                    0,
                    0
                    }, false);
                }
                else
                {
                    HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZRound, new byte[]
                    {
                    139,
                    145,
                    32,
                    2,
                    0,
                    0
                    }, false);
                }
            }
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            {
                IEnumerable<MetroSwitch> enumerable = Form1.ThisForm.FindAllChildrenByType<MetroSwitch>();
                IEnumerable<ForeverButton> enumerable2 = Form1.ThisForm.FindAllChildrenByType<ForeverButton>();
                bool switched = this.CB_XP.Switched;
                if (switched)
                {
                    Threads.RestoreTool();
                    this.CB_TP_ZM.Switched = true;
                    Threads.ZmLocation.Z = Threads.ZmLocation.Z + 200f;
                    HyperMEM.MEM.WriteFloat(HyperMEM.MEM.GameBase + Offsets.ZTeleport + 23UL, Threads.ZmLocation.Z, false);
                    Form1.PatchXP(true);
                    Form1.Current_Round = HyperMEM.MEM.ReadInt32(HyperMEM.MEM.GameBase + 287881332UL);
                    PlayerFunctions.SetPlayerKills(0, 0);
                    PlayerFunctions.SetPlayerKills(1, 0);
                    PlayerFunctions.SetPlayerKills(2, 0);
                    PlayerFunctions.SetPlayerKills(3, 0);
                    this.XP_Timer.Start();
                }
                else
                {
                    this.XP_Timer.Stop();
                    Form1.PatchXP(false);
                }
                this.CB_XP.Enabled = true;
                this.Btn_KillAll.Enabled = true;
            }
        }

        private void guna2ToggleSwitch3_CheckedChanged(object sender, EventArgs e)
        {
            {
                Offsets.ZRoundSkip = 166585072UL;
                Offsets.ZRoundEntitiy = 288199464UL;
                byte[] array = new byte[]
                {
                72,
                139,
                196,
                72,
                137,
                104,
                32,
                72,
                137,
                72,
                8,
                86,
                65,
                84,
                65,
                85,
                65,
                86,
                65,
                87,
                72,
                131,
                236,
                96,
                68,
                139,
                164,
                36,
                216,
                0,
                0,
                0,
                69,
                139,
                241,
                68,
                139,
                172,
                36,
                208,
                0,
                0,
                0,
                73,
                139,
                240,
                72,
                139,
                172,
                36,
                200,
                0,
                0,
                0,
                76,
                139,
                250,
                77,
                133,
                192,
                15,
                132,
                7,
                1,
                0,
                0,
                102,
                65,
                131,
                184,
                130,
                2,
                0,
                0,
                1,
                15,
                133,
                248,
                0,
                0,
                0,
                72,
                139,
                21,
                150,
                1,
                0,
                0,
                72,
                137,
                88,
                16,
                72,
                99,
                154,
                144,
                0,
                0,
                0,
                59,
                90,
                16,
                15,
                141,
                213,
                0,
                0,
                0,
                72,
                137,
                120,
                24,
                72,
                105,
                251,
                232,
                5,
                0,
                0,
                102,
                15,
                31,
                132,
                0,
                0,
                0,
                0,
                0,
                76,
                139,
                66,
                8,
                102,
                66,
                131,
                188,
                7,
                130,
                2,
                0,
                0,
                15,
                15,
                133,
                147,
                0,
                0,
                0,
                66,
                131,
                188,
                7,
                144,
                3,
                0,
                0,
                0,
                15,
                142,
                132,
                0,
                0,
                0,
                66,
                131,
                188,
                7,
                148,
                3,
                0,
                0,
                0,
                126,
                121,
                66,
                246,
                132,
                7,
                59,
                3,
                0,
                0,
                1,
                116,
                110,
                139,
                69,
                8,
                69,
                139,
                206,
                242,
                15,
                16,
                69,
                0,
                73,
                139,
                215,
                137,
                68,
                36,
                88,
                68,
                137,
                100,
                36,
                72,
                68,
                137,
                108,
                36,
                64,
                72,
                99,
                195,
                72,
                105,
                200,
                232,
                5,
                0,
                0,
                242,
                15,
                17,
                68,
                36,
                80,
                72,
                141,
                68,
                36,
                80,
                72,
                137,
                68,
                36,
                56,
                73,
                3,
                200,
                72,
                139,
                132,
                36,
                192,
                0,
                0,
                0,
                76,
                139,
                198,
                72,
                137,
                68,
                36,
                48,
                72,
                139,
                132,
                36,
                184,
                0,
                0,
                0,
                72,
                137,
                68,
                36,
                40,
                139,
                132,
                36,
                176,
                0,
                0,
                0,
                137,
                68,
                36,
                32,
                232,
                166,
                0,
                0,
                0,
                144,
                72,
                139,
                21,
                199,
                0,
                0,
                0,
                byte.MaxValue,
                195,
                72,
                129,
                199,
                232,
                5,
                0,
                0,
                59,
                90,
                16,
                15,
                140,
                71,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                72,
                139,
                188,
                36,
                160,
                0,
                0,
                0,
                72,
                139,
                156,
                36,
                152,
                0,
                0,
                0,
                139,
                69,
                8,
                69,
                139,
                206,
                242,
                15,
                16,
                69,
                0,
                76,
                139,
                198,
                72,
                139,
                140,
                36,
                144,
                0,
                0,
                0,
                73,
                139,
                215,
                137,
                68,
                36,
                88,
                72,
                141,
                68,
                36,
                80,
                68,
                137,
                100,
                36,
                72,
                68,
                137,
                108,
                36,
                64,
                72,
                137,
                68,
                36,
                56,
                72,
                139,
                132,
                36,
                192,
                0,
                0,
                0,
                72,
                137,
                68,
                36,
                48,
                72,
                139,
                132,
                36,
                184,
                0,
                0,
                0,
                72,
                137,
                68,
                36,
                40,
                139,
                132,
                36,
                176,
                0,
                0,
                0,
                137,
                68,
                36,
                32,
                242,
                15,
                17,
                68,
                36,
                80,
                232,
                27,
                0,
                0,
                0,
                144,
                72,
                139,
                172,
                36,
                168,
                0,
                0,
                0,
                72,
                131,
                196,
                96,
                65,
                95,
                65,
                94,
                65,
                93,
                65,
                92,
                94,
                195,
                0,
                0,
                0,
                0,
                72,
                137,
                92,
                36,
                8,
                72,
                137,
                108,
                36,
                16,
                72,
                137,
                116,
                36,
                24,
                68,
                137,
                76,
                36,
                32,
                byte.MaxValue,
                37,
                4,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                4,
                227,
                27,
                250,
                246,
                127,
                0,
                0,
                0,
                0,
                0,
                40,
                147,
                91,
                1,
                247,
                127
                };
                byte[] buffer = new byte[]
                {
                72,
                137,
                92,
                36,
                8,
                72,
                137,
                108,
                36,
                16,
                72,
                137,
                116,
                36,
                24,
                68,
                137,
                76,
                36,
                32
                };
                bool switched = this.CB_AutoKill.Switched;
                if (switched)
                {
                    bool inGame = Threads.InGame;
                    if (inGame)
                    {
                        bool flag = Form1.XP_CAVE > 0UL;
                        if (flag)
                        {
                            HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZRoundSkip, buffer, false);
                            HyperMEM.MEM.WriteBytes(Form1.XP_CAVE, new byte[568], false);
                        }
                        Form1.XP_CAVE = HyperMEM.MEM.FindCodeCave(HyperMEM.MEM.GameBase, HyperMEM.MEM.GameBase + HyperMEM.MEM.GameSize, 1000UL) + 100UL;
                        Debug.WriteLine(Form1.XP_CAVE.ToString("X"));
                        bool flag2 = HyperMEM.MEM.IsValidAddr(Form1.XP_CAVE);
                        if (flag2)
                        {
                            HyperMEM.MEM.WriteBytes(Form1.XP_CAVE, array, false);
                            HyperMEM.MEM.WriteInt64(Form1.XP_CAVE + (ulong)((long)array.Length) - 17UL, (long)(HyperMEM.MEM.GameBase + Offsets.ZRoundSkip + 20UL), false);
                            HyperMEM.MEM.WriteInt64(Form1.XP_CAVE + (ulong)((long)array.Length) - 6UL, (long)(HyperMEM.MEM.GameBase + Offsets.ZRoundEntitiy), false);
                            HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZRoundSkip, new byte[]
                            {
                            byte.MaxValue,
                            37,
                            1,
                            0,
                            0,
                            0,
                            144,
                            0,
                            1,
                            105,
                            240,
                            246,
                            127,
                            0,
                            0,
                            144,
                            144,
                            144,
                            144,
                            144
                            }, false);
                            HyperMEM.MEM.WriteInt64(HyperMEM.MEM.GameBase + Offsets.ZRoundSkip + 7UL, (long)Form1.XP_CAVE, false);
                        }
                    }
                }
                else
                {
                    bool flag3 = Form1.XP_CAVE > 0UL;
                    if (flag3)
                    {
                        HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZRoundSkip, buffer, false);
                        HyperMEM.MEM.WriteBytes(Form1.XP_CAVE, new byte[625], false);
                    }
                }
            }
        }

        private void guna2ToggleSwitch7_CheckedChanged(object sender, EventArgs e)
        {
            {
                bool switched = this.CB_TP_ZM.Switched;
                if (switched)
                {
                    HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZTeleport, new byte[]
                    {
                    184,
                    0,
                    0,
                    128,
                    63,
                    137,
                    129,
                    212,
                    2,
                    0,
                    0,
                    184,
                    0,
                    0,
                    128,
                    63,
                    137,
                    129,
                    216,
                    2,
                    0,
                    0,
                    184,
                    0,
                    0,
                    128,
                    63,
                    137,
                    129,
                    220,
                    2,
                    0,
                    0,
                    199,
                    129,
                    144,
                    3,
                    0,
                    0,
                    1,
                    0,
                    0,
                    0,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144
                    }, false);
                    Threads.ZmLocation = PlayerFunctions.GetLocation(0);
                    HyperMEM.MEM.WriteFloat(HyperMEM.MEM.GameBase + Offsets.ZTeleport + 1UL, Threads.ZmLocation.X, false);
                    HyperMEM.MEM.WriteFloat(HyperMEM.MEM.GameBase + Offsets.ZTeleport + 12UL, Threads.ZmLocation.Y, false);
                    HyperMEM.MEM.WriteFloat(HyperMEM.MEM.GameBase + Offsets.ZTeleport + 23UL, Threads.ZmLocation.Z, false);
                }
                else
                {
                    HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZTeleport, new byte[]
                    {
                    139,
                    131,
                    128,
                    6,
                    0,
                    0,
                    137,
                    129,
                    212,
                    2,
                    0,
                    0,
                    243,
                    15,
                    16,
                    131,
                    132,
                    6,
                    0,
                    0,
                    243,
                    15,
                    17,
                    129,
                    216,
                    2,
                    0,
                    0,
                    243,
                    15,
                    16,
                    139,
                    136,
                    6,
                    0,
                    0,
                    243,
                    15,
                    17,
                    137,
                    220,
                    2,
                    0,
                    0,
                    199,
                    131,
                    188,
                    6,
                    0,
                    0,
                    0,
                    0,
                    0,
                    0,
                    51,
                    201
                    }, false);
                }
            }
        }

        private void guna2ToggleSwitch6_CheckedChanged(object sender, EventArgs e)
        {
            Threads.BotLocation = PlayerFunctions.GetLocation(0);
        }

        private void guna2ToggleSwitch5_CheckedChanged(object sender, EventArgs e)
        {
            bool switched = this.CB_Noclip.Switched;
            if (switched)
            {
                HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZNoClipFunc, new byte[]
                {
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    243,
                    15,
                    16,
                    69,
                    168,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    243,
                    15,
                    16,
                    69,
                    172,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144
                }, false);
            }
            else
            {
                HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZNoClipFunc, new byte[]
                {
                    243,
                    15,
                    17,
                    128,
                    232,
                    13,
                    0,
                    0,
                    243,
                    15,
                    16,
                    69,
                    168,
                    243,
                    15,
                    17,
                    128,
                    240,
                    13,
                    0,
                    0,
                    243,
                    15,
                    16,
                    69,
                    172,
                    243,
                    15,
                    17,
                    136,
                    236,
                    13,
                    0,
                    0
                }, false);
            }
        }

        private void ForceHostTabPage_Click(object sender, EventArgs e)
        {

        }

        private void CB_God_P4_SwitchedChanged(object sender)
        {

        }

        private void CB_Points_P4_SwitchedChanged(object sender)
        {

        }

        private void CB_Ammo_P4_SwitchedChanged(object sender)
        {

        }

        private void CB_Speed_P4_SwitchedChanged(object sender)
        {

        }

        private void guna2ToggleSwitch10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nightHeaderLabel61_Click(object sender, EventArgs e)
        {

        }

        private void XPTabPage_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch4_CheckedChanged(object sender, EventArgs e)
        {
            Threads.RestoreTool();
            bool flag = HyperMEM.MEM.ReadInt16(HyperMEM.MEM.GameBase + Offsets.ZSeshState) == 33;
            if (flag)
            {
                HyperMEM.MEM.WriteInt16(HyperMEM.MEM.GameBase + Offsets.ZSeshState, 4129, false);
            }
            for (int i = 0; i < 18; i++)
            {
                PlayerFunctions.SetGodMode(i, true);
                PlayerFunctions.SendToJail(i);
            }
        }

        private void foreverButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ESPAimbotTabPage_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Threads.RestoreTool();
            bool flag = this.Box_Weapons_P1.Items.Count == PlayerFunctions.GunNamesMP.Length;
            if (flag)
            {
                this.SetupZMGuns();
            }
            Form1.Magic();
            this.CB_TP_ZM.Switched = true;
            this.CB_God_P1.Switched = true;
            this.CB_God_P2.Switched = true;
            this.CB_God_P3.Switched = true;

            this.CB_Ammo_P1.Switched = true;
            this.CB_Ammo_P2.Switched = true;
            this.CB_Ammo_P3.Switched = true;
            this.CB_Crit_P1.Switched = true;
            this.CB_Crit_P2.Switched = true;
            this.CB_Crit_P3.Switched = true;
            this.CB_Rapid_P1.Switched = true;
            this.CB_Rapid_P2.Switched = true;
            this.CB_Rapid_P3.Switched = true;
            this.CB_Cycle_P1.Switched = true;
            this.CB_Cycle_P2.Switched = true;
            this.CB_Cycle_P3.Switched = true;
            this.CB_Shoot_P1.Switched = true;
            this.CB_Shoot_P2.Switched = true;
            this.CB_Shoot_P3.Switched = true;

            this.Bar_Kills.Value = 1;
            this.Bar_Shots.Value = 5;
        }

        private void guna2ToggleSwitch10_CheckedChanged_1(object sender, EventArgs e)
        {
            Threads.RestoreTool();
            bool flag = this.Box_Weapons_P1.Items.Count == PlayerFunctions.GunNamesMP.Length;
            if (flag)
            {
                this.SetupZMGuns();
            }
            Form1.Magic();
            this.CB_TP_ZM.Switched = true;
            this.CB_God_P1.Switched = true;
            this.CB_God_P2.Switched = true;
            this.CB_God_P3.Switched = true;


            this.CB_Ammo_P1.Switched = true;
            this.CB_Ammo_P2.Switched = true;
            this.CB_Ammo_P3.Switched = true;
            this.CB_Crit_P1.Switched = true;
            this.CB_Crit_P2.Switched = true;
            this.CB_Crit_P3.Switched = true;
            this.CB_Rapid_P1.Switched = true;
            this.CB_Rapid_P2.Switched = true;
            this.CB_Rapid_P3.Switched = true;
            this.CB_Cycle_P1.Switched = true;
            this.CB_Cycle_P2.Switched = true;
            this.CB_Cycle_P3.Switched = true;
            this.CB_Shoot_P2.Switched = true;
            this.CB_Shoot_P3.Switched = true;
            this.Bar_Kills.Value = 1;
            this.Bar_Shots.Value = 5;
        }

        private void CB_Jail_P4_SwitchedChanged(object sender)
        {

        }

        private void foreverComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch2_CheckedChanged_1(object sender, EventArgs e)
        {
            IEnumerable<MetroSwitch> enumerable = Form1.ThisForm.FindAllChildrenByType<MetroSwitch>();
            IEnumerable<ForeverButton> enumerable2 = Form1.ThisForm.FindAllChildrenByType<ForeverButton>();
            bool switched = this.CB_XP.Switched;
            if (switched)
            {
                Threads.RestoreTool();
                this.CB_TP_ZM.Switched = true;
                Threads.ZmLocation.Z = Threads.ZmLocation.Z + 200f;
                HyperMEM.MEM.WriteFloat(HyperMEM.MEM.GameBase + Offsets.ZTeleport + 23UL, Threads.ZmLocation.Z, false);
                Form1.PatchXP(true);
                Form1.Current_Round = HyperMEM.MEM.ReadInt32(HyperMEM.MEM.GameBase + 287881332UL);
                PlayerFunctions.SetPlayerKills(0, 0);
                PlayerFunctions.SetPlayerKills(1, 0);
                PlayerFunctions.SetPlayerKills(2, 0);
                PlayerFunctions.SetPlayerKills(3, 0);
                this.XP_Timer.Start();
            }
            else
            {
                this.XP_Timer.Stop();
                Form1.PatchXP(false);
            }
            this.CB_XP.Enabled = true;
            this.Btn_KillAll.Enabled = true;
        }

        private void guna2ToggleSwitch5_CheckedChanged_1(object sender, EventArgs e)
        {
            bool switched = this.CB_Noclip.Switched;
            if (switched)
            {
                HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZNoClipFunc, new byte[]
                {
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    243,
                    15,
                    16,
                    69,
                    168,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    243,
                    15,
                    16,
                    69,
                    172,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144,
                    144
                }, false);
            }
            else
            {
                HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZNoClipFunc, new byte[]
                {
                    243,
                    15,
                    17,
                    128,
                    232,
                    13,
                    0,
                    0,
                    243,
                    15,
                    16,
                    69,
                    168,
                    243,
                    15,
                    17,
                    128,
                    240,
                    13,
                    0,
                    0,
                    243,
                    15,
                    16,
                    69,
                    172,
                    243,
                    15,
                    17,
                    136,
                    236,
                    13,
                    0,
                    0
                }, false);
            }
        }

        private void guna2ToggleSwitch37_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SetPlayerSpeed(2, 2.5f);
        }

        private void guna2ToggleSwitch49_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SetPlayerSpeed(3, 2.5f);
        }

        private void guna2ToggleSwitch15_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SetPlayerSpeed(0, 2.5f);
        }

        private void guna2ToggleSwitch24_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SetPlayerSpeed(1, 2.5f);
        }

        private void guna2ToggleSwitch60_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SetGodMode(0, true);
        }

        private void guna2ToggleSwitch8_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SetGodMode(1, true);
            PlayerFunctions.SetGodMode(0, true);

        }

        private void guna2ToggleSwitch35_CheckedChanged(object sender, EventArgs e)
        {
            if (Form1.ThisForm.CB_God_P2.Switched)
            {
                PlayerFunctions.SetGodMode(1, true);
            }
            else
            {
                PlayerFunctions.SetGodMode(1, false);
            }
        }

        private void guna2ToggleSwitch48_CheckedChanged(object sender, EventArgs e)
        {
            if (Form1.ThisForm.CB_God_P3.Switched)
            {
                PlayerFunctions.SetGodMode(2, true);
            }
            else
            {
                PlayerFunctions.SetGodMode(2, false);
            }
        }

        private void guna2ToggleSwitch22_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SetPoints(0, 133700);
        }

        private void guna2ToggleSwitch14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch54_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SetPoints(3, 133700);
        }

        private void guna2ToggleSwitch55_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.UnlimitedAmmo(3);
        }

        private void guna2ToggleSwitch56_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SetCriticalKills(3);
        }

        private void guna2ToggleSwitch50_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SendToJail(3);
        }

        private void guna2ToggleSwitch14_CheckedChanged_1(object sender, EventArgs e)
        {
            PlayerFunctions.UnlimitedAmmo(0);
        }

        private void guna2ToggleSwitch13_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SetCriticalKills(0);
        }

        private void guna2ToggleSwitch16_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SendToJail(0);
        }

        private void guna2ToggleSwitch21_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SetZMPos(0);
        }





        private void FeaturesTabPage_Click(object sender, EventArgs e)
        {

        }

        private void foreverComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void foreverComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void foreverButton2_Click(object sender, EventArgs e)
        {


        }

        private void foreverButton4_Click(object sender, EventArgs e)
        {

        }

        private void foreverButton3_Click(object sender, EventArgs e)
        {

        }

        private void foreverComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void foreverComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch61_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SetPlayerSpeed(0, 2.5f);
            PlayerFunctions.SetPlayerSpeed(1, 2.5f);
            PlayerFunctions.SetPlayerSpeed(2, 2.5f);
            PlayerFunctions.SetPlayerSpeed(3, 2.5f);

        }

        private void guna2ToggleSwitch62_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SetRapidFire(0);
        }

        private void guna2ToggleSwitch9_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SetRapidFire(0);
        }

        private void guna2ToggleSwitch34_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SetRapidFire(1);
        }

        private void guna2ToggleSwitch47_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SetRapidFire(2);
        }

        private void guna2ToggleSwitch59_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SetRapidFire(3);
        }

        private void guna2ToggleSwitch19_CheckedChanged(object sender, EventArgs e)
        {
         
            
        }

        private void guna2ToggleSwitch17_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2ToggleSwitch62_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void bar_noclip_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Bar_Shots_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void guna2ToggleSwitch19_CheckedChanged_1(object sender, EventArgs e)
        {
            PlayerFunctions.SetPlayerSpeed(0, 45.6f);
            PlayerFunctions.SetGodMode(1, true);
            PlayerFunctions.SetGodMode(0, true);
          
        }

        private void guna2ToggleSwitch63_CheckedChanged(object sender, EventArgs e)
        {
            PlayerFunctions.SetPlayerSpeed(0, 85.6f);
        }
    }
}












