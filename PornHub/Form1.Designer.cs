namespace PornHub
{
	// Token: 0x0200000A RID: 10
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600004A RID: 74 RVA: 0x000056A8 File Offset: 0x000038A8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000056E0 File Offset: 0x000038E0
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.Panel_LeftSide = new System.Windows.Forms.Panel();
            this.Btn_Discord_Icon = new FontAwesome.Sharp.IconPictureBox();
            this.Btn_P4_Icon = new FontAwesome.Sharp.IconPictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn_P3_Icon = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn_P2_Icon = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_P1_Icon = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Server_Icon = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Server_BG = new System.Windows.Forms.Panel();
            this.Animations = new System.Windows.Forms.Timer(this.components);
            this.Panel_Server = new System.Windows.Forms.Panel();
            this.CB_XP = new ReaLTaiizor.Controls.MetroSwitch();
            this.CB_AutoKill = new ReaLTaiizor.Controls.MetroSwitch();
            this.CB_Noclip = new ReaLTaiizor.Controls.MetroSwitch();
            this.DAHelp = new System.Windows.Forms.Label();
            this.CB_RoundSkip = new ReaLTaiizor.Controls.MetroSwitch();
            this.CB_Bots = new ReaLTaiizor.Controls.MetroSwitch();
            this.CB_TP_ZM = new ReaLTaiizor.Controls.MetroSwitch();
            this.Form_Header = new System.Windows.Forms.Panel();
            this.nightHeaderLabel63 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.LBL_Gun = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.Btn_Close = new ReaLTaiizor.Controls.ForeverButton();
            this.LBL_PlayerName = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.Panel_P1 = new System.Windows.Forms.Panel();
            this.Panel_P2 = new System.Windows.Forms.Panel();
            this.Panel_P3 = new System.Windows.Forms.Panel();
            this.Panel_P4 = new System.Windows.Forms.Panel();
            this.nightHeaderLabel3 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel4 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel5 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel8 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel9 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel10 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel11 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel12 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel13 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel14 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel15 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel16 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.XP_Timer = new System.Windows.Forms.Timer(this.components);
            this.foreverButton1 = new ReaLTaiizor.Controls.ForeverButton();
            this.FeaturesTabPage = new System.Windows.Forms.TabPage();
            this.guna2ToggleSwitch62 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.nightHeaderLabel68 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel69 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel70 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel71 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel72 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel73 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2ToggleSwitch15 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch16 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch17 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch21 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch22 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.nightHeaderLabel6 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel7 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel64 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel65 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel66 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel67 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2ToggleSwitch14 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch13 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch12 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch10 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch9 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch8 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Btn_Gib2_P1 = new ReaLTaiizor.Controls.ForeverButton();
            this.Btn_TP_P1 = new ReaLTaiizor.Controls.ForeverButton();
            this.Btn_Gib_P1 = new ReaLTaiizor.Controls.ForeverButton();
            this.Box_CycleEnd_P1 = new ReaLTaiizor.Controls.ForeverComboBox();
            this.Box_Weapons_P1 = new ReaLTaiizor.Controls.ForeverComboBox();
            this.Box_TP_P1 = new ReaLTaiizor.Controls.ForeverComboBox();
            this.Box_CycleStart_P1 = new ReaLTaiizor.Controls.ForeverComboBox();
            this.nightHeaderLabel37 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel1 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel38 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2Panel13 = new Guna.UI2.WinForms.Guna2Panel();
            this.nightHeaderLabel48 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel2 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.CB_zqinissofuckingsexy_P1 = new ReaLTaiizor.Controls.MetroSwitch();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.CB_Shoot_P1 = new ReaLTaiizor.Controls.MetroSwitch();
            this.guna2Panel25 = new Guna.UI2.WinForms.Guna2Panel();
            this.CB_Rainbow_P1 = new ReaLTaiizor.Controls.MetroSwitch();
            this.guna2Panel26 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel24 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel23 = new Guna.UI2.WinForms.Guna2Panel();
            this.label37 = new System.Windows.Forms.Label();
            this.nightHeaderLabel40 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2ToggleSwitch36 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.nightHeaderLabel42 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.label31 = new System.Windows.Forms.Label();
            this.nightHeaderLabel44 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel39 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel46 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2ToggleSwitch11 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch18 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.nightHeaderLabel41 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.label20 = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch20 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.nightHeaderLabel43 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.label18 = new System.Windows.Forms.Label();
            this.CB_Croshair_P1 = new ReaLTaiizor.Controls.MetroSwitch();
            this.nightHeaderLabel45 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.CB_Cycle_P1 = new ReaLTaiizor.Controls.MetroSwitch();
            this.nightHeaderLabel47 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2ToggleSwitch23 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.CB_Jail_P1 = new ReaLTaiizor.Controls.MetroSwitch();
            this.CB_God_P1 = new ReaLTaiizor.Controls.MetroSwitch();
            this.CB_Ammo_P1 = new ReaLTaiizor.Controls.MetroSwitch();
            this.CB_Crit_P1 = new ReaLTaiizor.Controls.MetroSwitch();
            this.CB_Speed_P1 = new ReaLTaiizor.Controls.MetroSwitch();
            this.CB_Rapid_P1 = new ReaLTaiizor.Controls.MetroSwitch();
            this.CB_Points_P1 = new ReaLTaiizor.Controls.MetroSwitch();
            this.nightHeaderLabel59 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.bar_noclip = new ReaLTaiizor.Controls.PoisonTrackBar();
            this.guna2ToggleSwitch5 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.nightHeaderLabel62 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2ToggleSwitch2 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch4 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.nightHeaderLabel76 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.nightHeaderLabel60 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.Btn_TP_Set = new ReaLTaiizor.Controls.ForeverButton();
            this.Btn_Dark = new ReaLTaiizor.Controls.ForeverButton();
            this.guna2ToggleSwitch3 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Btn_Kill_multi = new ReaLTaiizor.Controls.ForeverButton();
            this.nightHeaderLabel61 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.LBL_Shots = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.Btn_KillAll = new ReaLTaiizor.Controls.ForeverButton();
            this.guna2ToggleSwitch7 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.LBL_Kills = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.Btn_QuickDA = new ReaLTaiizor.Controls.ForeverButton();
            this.nightHeaderLabel57 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.Bar_Shots = new ReaLTaiizor.Controls.PoisonTrackBar();
            this.Bar_Kills = new ReaLTaiizor.Controls.PoisonTrackBar();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.LOADER = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Btn_Gib2_P2 = new ReaLTaiizor.Controls.ForeverButton();
            this.Btn_TP_P2 = new ReaLTaiizor.Controls.ForeverButton();
            this.Box_Weapons_P2 = new ReaLTaiizor.Controls.ForeverComboBox();
            this.Box_TP_P2 = new ReaLTaiizor.Controls.ForeverComboBox();
            this.Box_CycleEnd_P2 = new ReaLTaiizor.Controls.ForeverComboBox();
            this.Box_CycleStart_P2 = new ReaLTaiizor.Controls.ForeverComboBox();
            this.Btn_TP_Bots = new ReaLTaiizor.Controls.ForeverButton();
            this.Btn_Gib_P2 = new ReaLTaiizor.Controls.ForeverButton();
            this.nightHeaderLabel34 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.Dtn_Diamond = new ReaLTaiizor.Controls.ForeverButton();
            this.nightHeaderLabel31 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel35 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel78 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2Panel29 = new Guna.UI2.WinForms.Guna2Panel();
            this.nightHeaderLabel33 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel58 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel32 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.CB_zqinissofuckingsexy_P2 = new ReaLTaiizor.Controls.MetroSwitch();
            this.guna2ToggleSwitch6 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2Panel30 = new Guna.UI2.WinForms.Guna2Panel();
            this.CB_Shoot_P2 = new ReaLTaiizor.Controls.MetroSwitch();
            this.guna2Panel31 = new Guna.UI2.WinForms.Guna2Panel();
            this.CB_Rainbow_P2 = new ReaLTaiizor.Controls.MetroSwitch();
            this.guna2Panel32 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel33 = new Guna.UI2.WinForms.Guna2Panel();
            this.CB_God_P2 = new ReaLTaiizor.Controls.MetroSwitch();
            this.CB_Ammo_P2 = new ReaLTaiizor.Controls.MetroSwitch();
            this.CB_Crit_P2 = new ReaLTaiizor.Controls.MetroSwitch();
            this.nightHeaderLabel49 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.CB_Rapid_P2 = new ReaLTaiizor.Controls.MetroSwitch();
            this.nightHeaderLabel51 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.CB_Cycle_P2 = new ReaLTaiizor.Controls.MetroSwitch();
            this.nightHeaderLabel53 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel36 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel55 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.CB_Points_P2 = new ReaLTaiizor.Controls.MetroSwitch();
            this.CB_Speed_P2 = new ReaLTaiizor.Controls.MetroSwitch();
            this.nightHeaderLabel50 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.CB_Jail_P2 = new ReaLTaiizor.Controls.MetroSwitch();
            this.CB_Croshair_P2 = new ReaLTaiizor.Controls.MetroSwitch();
            this.nightHeaderLabel52 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel56 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel54 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.UnlocksTabPage = new System.Windows.Forms.TabPage();
            this.guna2ToggleSwitch63 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch19 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.nightHeaderLabel112 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2ToggleSwitch61 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Box_Weapons_P3 = new ReaLTaiizor.Controls.ForeverComboBox();
            this.Box_TP_P3 = new ReaLTaiizor.Controls.ForeverComboBox();
            this.Box_CycleEnd_P3 = new ReaLTaiizor.Controls.ForeverComboBox();
            this.Box_CycleStart_P3 = new ReaLTaiizor.Controls.ForeverComboBox();
            this.Btn_Gib2_P3 = new ReaLTaiizor.Controls.ForeverButton();
            this.Btn_TP_P3 = new ReaLTaiizor.Controls.ForeverButton();
            this.Btn_Gib_P3 = new ReaLTaiizor.Controls.ForeverButton();
            this.nightHeaderLabel20 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel17 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel21 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2Panel20 = new Guna.UI2.WinForms.Guna2Panel();
            this.nightHeaderLabel19 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel18 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.CB_zqinissofuckingsexy_P3 = new ReaLTaiizor.Controls.MetroSwitch();
            this.guna2Panel21 = new Guna.UI2.WinForms.Guna2Panel();
            this.CB_Shoot_P3 = new ReaLTaiizor.Controls.MetroSwitch();
            this.guna2Panel22 = new Guna.UI2.WinForms.Guna2Panel();
            this.CB_Rainbow_P3 = new ReaLTaiizor.Controls.MetroSwitch();
            this.guna2Panel27 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel28 = new Guna.UI2.WinForms.Guna2Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.CWCamoSwapComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.nightHeaderLabel23 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.CB_God_P3 = new ReaLTaiizor.Controls.MetroSwitch();
            this.nightHeaderLabel25 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.CB_Ammo_P3 = new ReaLTaiizor.Controls.MetroSwitch();
            this.nightHeaderLabel27 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel22 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel29 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.CB_Crit_P3 = new ReaLTaiizor.Controls.MetroSwitch();
            this.CB_Rapid_P3 = new ReaLTaiizor.Controls.MetroSwitch();
            this.nightHeaderLabel24 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.CB_Cycle_P3 = new ReaLTaiizor.Controls.MetroSwitch();
            this.CB_Points_P3 = new ReaLTaiizor.Controls.MetroSwitch();
            this.nightHeaderLabel26 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.CB_Speed_P3 = new ReaLTaiizor.Controls.MetroSwitch();
            this.CB_Croshair_P3 = new ReaLTaiizor.Controls.MetroSwitch();
            this.nightHeaderLabel28 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.CB_Jail_P3 = new ReaLTaiizor.Controls.MetroSwitch();
            this.nightHeaderLabel30 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nightHeaderLabel74 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel75 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel77 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel79 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel80 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel81 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2ToggleSwitch24 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch25 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch26 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch27 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch28 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch29 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.nightHeaderLabel82 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel83 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel84 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel85 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel86 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel87 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2ToggleSwitch30 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch31 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch32 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch33 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch34 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch35 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nightHeaderLabel88 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel89 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel90 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel91 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel92 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel93 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2ToggleSwitch37 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch38 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch39 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch40 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch41 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch42 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.nightHeaderLabel94 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel95 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel96 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel97 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel98 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel99 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2ToggleSwitch43 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch44 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch45 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch46 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch47 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch48 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel10 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.guna2Panel17 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel18 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel15 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel16 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel14 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel12 = new Guna.UI2.WinForms.Guna2Panel();
            this.nightHeaderLabel100 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel101 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel102 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel103 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel104 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel105 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2ToggleSwitch49 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch50 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch51 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch52 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch53 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch54 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.nightHeaderLabel106 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel107 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel108 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel109 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel110 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.nightHeaderLabel111 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.guna2ToggleSwitch55 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch56 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch57 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch58 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch59 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch60 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.poisonTrackBar1 = new ReaLTaiizor.Controls.PoisonTrackBar();
            this.Panel_LeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Discord_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_P4_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_P3_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_P2_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_P1_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Server_Icon)).BeginInit();
            this.Form_Header.SuspendLayout();
            this.Panel_P4.SuspendLayout();
            this.FeaturesTabPage.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.guna2Panel32.SuspendLayout();
            this.UnlocksTabPage.SuspendLayout();
            this.guna2Panel27.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            this.guna2Panel10.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.guna2Panel17.SuspendLayout();
            this.guna2Panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_LeftSide
            // 
            this.Panel_LeftSide.BackColor = System.Drawing.Color.Transparent;
            this.Panel_LeftSide.Controls.Add(this.Btn_Discord_Icon);
            this.Panel_LeftSide.Controls.Add(this.Btn_P4_Icon);
            this.Panel_LeftSide.Controls.Add(this.panel5);
            this.Panel_LeftSide.Controls.Add(this.Btn_P3_Icon);
            this.Panel_LeftSide.Controls.Add(this.panel4);
            this.Panel_LeftSide.Controls.Add(this.Btn_P2_Icon);
            this.Panel_LeftSide.Controls.Add(this.panel3);
            this.Panel_LeftSide.Controls.Add(this.Btn_P1_Icon);
            this.Panel_LeftSide.Controls.Add(this.panel2);
            this.Panel_LeftSide.Controls.Add(this.Btn_Server_Icon);
            this.Panel_LeftSide.Controls.Add(this.panel1);
            this.Panel_LeftSide.Controls.Add(this.Btn_Server_BG);
            this.Panel_LeftSide.Location = new System.Drawing.Point(286, 714);
            this.Panel_LeftSide.Name = "Panel_LeftSide";
            this.Panel_LeftSide.Size = new System.Drawing.Size(100, 500);
            this.Panel_LeftSide.TabIndex = 2;
            // 
            // Btn_Discord_Icon
            // 
            this.Btn_Discord_Icon.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Discord_Icon.ForeColor = System.Drawing.Color.Red;
            this.Btn_Discord_Icon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_Discord_Icon.IconColor = System.Drawing.Color.Red;
            this.Btn_Discord_Icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Discord_Icon.IconSize = 60;
            this.Btn_Discord_Icon.Location = new System.Drawing.Point(20, 428);
            this.Btn_Discord_Icon.Name = "Btn_Discord_Icon";
            this.Btn_Discord_Icon.Size = new System.Drawing.Size(60, 60);
            this.Btn_Discord_Icon.TabIndex = 8;
            this.Btn_Discord_Icon.TabStop = false;
            this.Btn_Discord_Icon.UseGdi = true;
            this.Btn_Discord_Icon.UseIconCache = true;
            this.Btn_Discord_Icon.MouseEnter += new System.EventHandler(this.Btn_Discord_Icon_MouseEnter);
            this.Btn_Discord_Icon.MouseLeave += new System.EventHandler(this.Btn_Discord_Icon_MouseLeave);
            // 
            // Btn_P4_Icon
            // 
            this.Btn_P4_Icon.BackColor = System.Drawing.Color.Transparent;
            this.Btn_P4_Icon.ForeColor = System.Drawing.Color.Red;
            this.Btn_P4_Icon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_P4_Icon.IconColor = System.Drawing.Color.Red;
            this.Btn_P4_Icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_P4_Icon.IconSize = 60;
            this.Btn_P4_Icon.Location = new System.Drawing.Point(20, 345);
            this.Btn_P4_Icon.Name = "Btn_P4_Icon";
            this.Btn_P4_Icon.Size = new System.Drawing.Size(60, 60);
            this.Btn_P4_Icon.TabIndex = 8;
            this.Btn_P4_Icon.TabStop = false;
            this.Btn_P4_Icon.UseGdi = true;
            this.Btn_P4_Icon.UseIconCache = true;
            this.Btn_P4_Icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_P4_Icon_MouseDown);
            this.Btn_P4_Icon.MouseEnter += new System.EventHandler(this.Btn_P4_Icon_MouseEnter);
            this.Btn_P4_Icon.MouseLeave += new System.EventHandler(this.Btn_P4_Icon_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 421);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(96, 75);
            this.panel5.TabIndex = 9;
            // 
            // Btn_P3_Icon
            // 
            this.Btn_P3_Icon.BackColor = System.Drawing.Color.Transparent;
            this.Btn_P3_Icon.ForeColor = System.Drawing.Color.Red;
            this.Btn_P3_Icon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_P3_Icon.IconColor = System.Drawing.Color.Red;
            this.Btn_P3_Icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_P3_Icon.IconSize = 60;
            this.Btn_P3_Icon.Location = new System.Drawing.Point(20, 262);
            this.Btn_P3_Icon.Name = "Btn_P3_Icon";
            this.Btn_P3_Icon.Size = new System.Drawing.Size(60, 60);
            this.Btn_P3_Icon.TabIndex = 8;
            this.Btn_P3_Icon.TabStop = false;
            this.Btn_P3_Icon.UseGdi = true;
            this.Btn_P3_Icon.UseIconCache = true;
            this.Btn_P3_Icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_P3_Icon_MouseDown);
            this.Btn_P3_Icon.MouseEnter += new System.EventHandler(this.Btn_P3_Icon_MouseEnter);
            this.Btn_P3_Icon.MouseLeave += new System.EventHandler(this.Btn_P3_Icon_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 338);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(96, 75);
            this.panel4.TabIndex = 9;
            // 
            // Btn_P2_Icon
            // 
            this.Btn_P2_Icon.BackColor = System.Drawing.Color.Transparent;
            this.Btn_P2_Icon.ForeColor = System.Drawing.Color.Red;
            this.Btn_P2_Icon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_P2_Icon.IconColor = System.Drawing.Color.Red;
            this.Btn_P2_Icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_P2_Icon.IconSize = 60;
            this.Btn_P2_Icon.Location = new System.Drawing.Point(20, 179);
            this.Btn_P2_Icon.Name = "Btn_P2_Icon";
            this.Btn_P2_Icon.Size = new System.Drawing.Size(60, 60);
            this.Btn_P2_Icon.TabIndex = 8;
            this.Btn_P2_Icon.TabStop = false;
            this.Btn_P2_Icon.UseGdi = true;
            this.Btn_P2_Icon.UseIconCache = true;
            this.Btn_P2_Icon.Click += new System.EventHandler(this.Btn_P2_Icon_Click);
            this.Btn_P2_Icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_P2_Icon_MouseDown);
            this.Btn_P2_Icon.MouseEnter += new System.EventHandler(this.Btn_P2_Icon_MouseEnter);
            this.Btn_P2_Icon.MouseLeave += new System.EventHandler(this.Btn_P2_Icon_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(96, 75);
            this.panel3.TabIndex = 9;
            // 
            // Btn_P1_Icon
            // 
            this.Btn_P1_Icon.BackColor = System.Drawing.Color.Transparent;
            this.Btn_P1_Icon.ForeColor = System.Drawing.Color.Red;
            this.Btn_P1_Icon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_P1_Icon.IconColor = System.Drawing.Color.Red;
            this.Btn_P1_Icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_P1_Icon.IconSize = 60;
            this.Btn_P1_Icon.Location = new System.Drawing.Point(20, 96);
            this.Btn_P1_Icon.Name = "Btn_P1_Icon";
            this.Btn_P1_Icon.Size = new System.Drawing.Size(60, 60);
            this.Btn_P1_Icon.TabIndex = 6;
            this.Btn_P1_Icon.TabStop = false;
            this.Btn_P1_Icon.UseGdi = true;
            this.Btn_P1_Icon.UseIconCache = true;
            this.Btn_P1_Icon.Click += new System.EventHandler(this.Btn_P1_Icon_Click);
            this.Btn_P1_Icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_P1_Icon_MouseDown);
            this.Btn_P1_Icon.MouseEnter += new System.EventHandler(this.Btn_P1_Icon_MouseEnter);
            this.Btn_P1_Icon.MouseLeave += new System.EventHandler(this.Btn_P1_Icon_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 75);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Btn_Server_Icon
            // 
            this.Btn_Server_Icon.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Server_Icon.ForeColor = System.Drawing.Color.Red;
            this.Btn_Server_Icon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_Server_Icon.IconColor = System.Drawing.Color.Red;
            this.Btn_Server_Icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Server_Icon.IconSize = 60;
            this.Btn_Server_Icon.Location = new System.Drawing.Point(20, 13);
            this.Btn_Server_Icon.Name = "Btn_Server_Icon";
            this.Btn_Server_Icon.Size = new System.Drawing.Size(60, 60);
            this.Btn_Server_Icon.TabIndex = 3;
            this.Btn_Server_Icon.TabStop = false;
            this.Btn_Server_Icon.UseGdi = true;
            this.Btn_Server_Icon.UseIconCache = true;
            this.Btn_Server_Icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Server_Icon_MouseDown);
            this.Btn_Server_Icon.MouseEnter += new System.EventHandler(this.Btn_Server_Icon_MouseEnter);
            this.Btn_Server_Icon.MouseLeave += new System.EventHandler(this.Btn_Server_Icon_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 75);
            this.panel1.TabIndex = 7;
            // 
            // Btn_Server_BG
            // 
            this.Btn_Server_BG.Location = new System.Drawing.Point(0, 6);
            this.Btn_Server_BG.Name = "Btn_Server_BG";
            this.Btn_Server_BG.Size = new System.Drawing.Size(96, 75);
            this.Btn_Server_BG.TabIndex = 5;
            // 
            // Animations
            // 
            this.Animations.Enabled = true;
            this.Animations.Interval = 25;
            this.Animations.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Panel_Server
            // 
            this.Panel_Server.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Server.Location = new System.Drawing.Point(402, 714);
            this.Panel_Server.Name = "Panel_Server";
            this.Panel_Server.Size = new System.Drawing.Size(10, 517);
            this.Panel_Server.TabIndex = 3;
            this.Panel_Server.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Server_Paint);
            // 
            // CB_XP
            // 
            this.CB_XP.BackColor = System.Drawing.Color.Transparent;
            this.CB_XP.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_XP.BorderColor = System.Drawing.Color.White;
            this.CB_XP.CheckColor = System.Drawing.Color.Red;
            this.CB_XP.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_XP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_XP.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_XP.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_XP.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_XP.IsDerivedStyle = false;
            this.CB_XP.Location = new System.Drawing.Point(1549, 501);
            this.CB_XP.Margin = new System.Windows.Forms.Padding(9);
            this.CB_XP.Name = "CB_XP";
            this.CB_XP.Size = new System.Drawing.Size(58, 22);
            this.CB_XP.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_XP.StyleManager = null;
            this.CB_XP.Switched = false;
            this.CB_XP.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_XP.TabIndex = 276;
            this.CB_XP.Text = "metroSwitch1";
            this.CB_XP.ThemeAuthor = "Taiizor";
            this.CB_XP.ThemeName = "MetroLight";
            this.CB_XP.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.CB_XP.SwitchedChanged += new ReaLTaiizor.Controls.MetroSwitch.SwitchedChangedEventHandler(this.CB_XP_SwitchedChanged_1);
            // 
            // CB_AutoKill
            // 
            this.CB_AutoKill.BackColor = System.Drawing.Color.Transparent;
            this.CB_AutoKill.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_AutoKill.BorderColor = System.Drawing.Color.White;
            this.CB_AutoKill.CheckColor = System.Drawing.Color.Red;
            this.CB_AutoKill.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_AutoKill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_AutoKill.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_AutoKill.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_AutoKill.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_AutoKill.IsDerivedStyle = false;
            this.CB_AutoKill.Location = new System.Drawing.Point(1535, 421);
            this.CB_AutoKill.Margin = new System.Windows.Forms.Padding(9);
            this.CB_AutoKill.Name = "CB_AutoKill";
            this.CB_AutoKill.Size = new System.Drawing.Size(58, 22);
            this.CB_AutoKill.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_AutoKill.StyleManager = null;
            this.CB_AutoKill.Switched = false;
            this.CB_AutoKill.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_AutoKill.TabIndex = 275;
            this.CB_AutoKill.Text = "metroSwitch1";
            this.CB_AutoKill.ThemeAuthor = "Taiizor";
            this.CB_AutoKill.ThemeName = "MetroLight";
            this.CB_AutoKill.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.CB_AutoKill.SwitchedChanged += new ReaLTaiizor.Controls.MetroSwitch.SwitchedChangedEventHandler(this.CB_XP_SwitchedChanged);
            // 
            // CB_Noclip
            // 
            this.CB_Noclip.BackColor = System.Drawing.Color.Transparent;
            this.CB_Noclip.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Noclip.BorderColor = System.Drawing.Color.White;
            this.CB_Noclip.CheckColor = System.Drawing.Color.Red;
            this.CB_Noclip.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Noclip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Noclip.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Noclip.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Noclip.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Noclip.IsDerivedStyle = false;
            this.CB_Noclip.Location = new System.Drawing.Point(1530, 345);
            this.CB_Noclip.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Noclip.Name = "CB_Noclip";
            this.CB_Noclip.Size = new System.Drawing.Size(58, 22);
            this.CB_Noclip.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Noclip.StyleManager = null;
            this.CB_Noclip.Switched = false;
            this.CB_Noclip.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Noclip.TabIndex = 272;
            this.CB_Noclip.Text = "CB_Noclip";
            this.CB_Noclip.ThemeAuthor = "Taiizor";
            this.CB_Noclip.ThemeName = "MetroLight";
            this.CB_Noclip.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.CB_Noclip.SwitchedChanged += new ReaLTaiizor.Controls.MetroSwitch.SwitchedChangedEventHandler(this.metroSwitch1_SwitchedChanged_1);
            // 
            // DAHelp
            // 
            this.DAHelp.AutoSize = true;
            this.DAHelp.BackColor = System.Drawing.Color.Transparent;
            this.DAHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DAHelp.ForeColor = System.Drawing.Color.White;
            this.DAHelp.Location = new System.Drawing.Point(386, 41);
            this.DAHelp.Name = "DAHelp";
            this.DAHelp.Size = new System.Drawing.Size(122, 13);
            this.DAHelp.TabIndex = 221;
            this.DAHelp.Text = "Dark Aether Tutorial";
            this.DAHelp.Click += new System.EventHandler(this.DAHelp_Click);
            // 
            // CB_RoundSkip
            // 
            this.CB_RoundSkip.BackColor = System.Drawing.Color.Transparent;
            this.CB_RoundSkip.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_RoundSkip.BorderColor = System.Drawing.Color.White;
            this.CB_RoundSkip.CheckColor = System.Drawing.Color.Red;
            this.CB_RoundSkip.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_RoundSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_RoundSkip.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_RoundSkip.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_RoundSkip.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_RoundSkip.IsDerivedStyle = false;
            this.CB_RoundSkip.Location = new System.Drawing.Point(1537, 80);
            this.CB_RoundSkip.Margin = new System.Windows.Forms.Padding(9);
            this.CB_RoundSkip.Name = "CB_RoundSkip";
            this.CB_RoundSkip.Size = new System.Drawing.Size(58, 22);
            this.CB_RoundSkip.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_RoundSkip.StyleManager = null;
            this.CB_RoundSkip.Switched = false;
            this.CB_RoundSkip.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_RoundSkip.TabIndex = 270;
            this.CB_RoundSkip.Text = "metroSwitch1";
            this.CB_RoundSkip.ThemeAuthor = "Taiizor";
            this.CB_RoundSkip.ThemeName = "MetroLight";
            this.CB_RoundSkip.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.CB_RoundSkip.SwitchedChanged += new ReaLTaiizor.Controls.MetroSwitch.SwitchedChangedEventHandler(this.CB_RoundSkip_SwitchedChanged);
            // 
            // CB_Bots
            // 
            this.CB_Bots.BackColor = System.Drawing.Color.Transparent;
            this.CB_Bots.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Bots.BorderColor = System.Drawing.Color.White;
            this.CB_Bots.CheckColor = System.Drawing.Color.Red;
            this.CB_Bots.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Bots.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Bots.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Bots.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Bots.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Bots.IsDerivedStyle = false;
            this.CB_Bots.Location = new System.Drawing.Point(1535, 82);
            this.CB_Bots.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Bots.Name = "CB_Bots";
            this.CB_Bots.Size = new System.Drawing.Size(58, 22);
            this.CB_Bots.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Bots.StyleManager = null;
            this.CB_Bots.Switched = false;
            this.CB_Bots.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Bots.TabIndex = 257;
            this.CB_Bots.Text = "metroSwitch1";
            this.CB_Bots.ThemeAuthor = "Taiizor";
            this.CB_Bots.ThemeName = "MetroLight";
            this.CB_Bots.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.CB_Bots.SwitchedChanged += new ReaLTaiizor.Controls.MetroSwitch.SwitchedChangedEventHandler(this.CB_Bots_SwitchedChanged);
            // 
            // CB_TP_ZM
            // 
            this.CB_TP_ZM.BackColor = System.Drawing.Color.Transparent;
            this.CB_TP_ZM.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_TP_ZM.BorderColor = System.Drawing.Color.White;
            this.CB_TP_ZM.CheckColor = System.Drawing.Color.Red;
            this.CB_TP_ZM.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_TP_ZM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_TP_ZM.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_TP_ZM.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_TP_ZM.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_TP_ZM.IsDerivedStyle = false;
            this.CB_TP_ZM.Location = new System.Drawing.Point(1538, 213);
            this.CB_TP_ZM.Margin = new System.Windows.Forms.Padding(9);
            this.CB_TP_ZM.Name = "CB_TP_ZM";
            this.CB_TP_ZM.Size = new System.Drawing.Size(58, 22);
            this.CB_TP_ZM.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_TP_ZM.StyleManager = null;
            this.CB_TP_ZM.Switched = false;
            this.CB_TP_ZM.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_TP_ZM.TabIndex = 246;
            this.CB_TP_ZM.Text = "metroSwitch1";
            this.CB_TP_ZM.ThemeAuthor = "Taiizor";
            this.CB_TP_ZM.ThemeName = "MetroLight";
            this.CB_TP_ZM.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.CB_TP_ZM.SwitchedChanged += new ReaLTaiizor.Controls.MetroSwitch.SwitchedChangedEventHandler(this.CB_TP_ZM_SwitchedChanged);
            // 
            // Form_Header
            // 
            this.Form_Header.BackColor = System.Drawing.Color.Red;
            this.Form_Header.Controls.Add(this.nightHeaderLabel63);
            this.Form_Header.Controls.Add(this.LBL_Gun);
            this.Form_Header.Controls.Add(this.Btn_Close);
            this.Form_Header.Controls.Add(this.LBL_PlayerName);
            this.Form_Header.Controls.Add(this.DAHelp);
            this.Form_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form_Header.Location = new System.Drawing.Point(0, 0);
            this.Form_Header.Name = "Form_Header";
            this.Form_Header.Size = new System.Drawing.Size(511, 64);
            this.Form_Header.TabIndex = 171;
            this.Form_Header.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Header_Paint);
            this.Form_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Header_MouseDown);
            this.Form_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Header_MouseMove);
            this.Form_Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Header_MouseUp);
            // 
            // nightHeaderLabel63
            // 
            this.nightHeaderLabel63.AutoSize = true;
            this.nightHeaderLabel63.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel63.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel63.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel63.Location = new System.Drawing.Point(153, 18);
            this.nightHeaderLabel63.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel63.Name = "nightHeaderLabel63";
            this.nightHeaderLabel63.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel63.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel63.Size = new System.Drawing.Size(191, 24);
            this.nightHeaderLabel63.TabIndex = 246;
            this.nightHeaderLabel63.Text = "NXT-G3N - SOFTWARE";
            this.nightHeaderLabel63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel63.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel63.UseCompatibleTextRendering = true;
            // 
            // LBL_Gun
            // 
            this.LBL_Gun.AutoSize = true;
            this.LBL_Gun.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Gun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Gun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.LBL_Gun.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.LBL_Gun.Location = new System.Drawing.Point(0, 0);
            this.LBL_Gun.Margin = new System.Windows.Forms.Padding(9);
            this.LBL_Gun.Name = "LBL_Gun";
            this.LBL_Gun.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.LBL_Gun.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.LBL_Gun.Size = new System.Drawing.Size(135, 24);
            this.LBL_Gun.TabIndex = 212;
            this.LBL_Gun.Text = "Current Gun ID: 0";
            this.LBL_Gun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Gun.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.LBL_Gun.UseCompatibleTextRendering = true;
            this.LBL_Gun.Click += new System.EventHandler(this.LBL_Gun_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.BaseColor = System.Drawing.Color.Transparent;
            this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(376, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Rounded = false;
            this.Btn_Close.Size = new System.Drawing.Size(126, 30);
            this.Btn_Close.TabIndex = 166;
            this.Btn_Close.Text = "✖";
            this.Btn_Close.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // LBL_PlayerName
            // 
            this.LBL_PlayerName.AutoSize = true;
            this.LBL_PlayerName.BackColor = System.Drawing.Color.Transparent;
            this.LBL_PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.LBL_PlayerName.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.LBL_PlayerName.Location = new System.Drawing.Point(0, 34);
            this.LBL_PlayerName.Margin = new System.Windows.Forms.Padding(9);
            this.LBL_PlayerName.Name = "LBL_PlayerName";
            this.LBL_PlayerName.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.LBL_PlayerName.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.LBL_PlayerName.Size = new System.Drawing.Size(106, 24);
            this.LBL_PlayerName.TabIndex = 211;
            this.LBL_PlayerName.Text = "Player Name:";
            this.LBL_PlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_PlayerName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.LBL_PlayerName.UseCompatibleTextRendering = true;
            this.LBL_PlayerName.Visible = false;
            // 
            // Panel_P1
            // 
            this.Panel_P1.BackColor = System.Drawing.Color.Transparent;
            this.Panel_P1.Location = new System.Drawing.Point(402, 1204);
            this.Panel_P1.Name = "Panel_P1";
            this.Panel_P1.Size = new System.Drawing.Size(114, 10);
            this.Panel_P1.TabIndex = 173;
            // 
            // Panel_P2
            // 
            this.Panel_P2.BackColor = System.Drawing.Color.Transparent;
            this.Panel_P2.Location = new System.Drawing.Point(402, 714);
            this.Panel_P2.Name = "Panel_P2";
            this.Panel_P2.Size = new System.Drawing.Size(24, 500);
            this.Panel_P2.TabIndex = 174;
            // 
            // Panel_P3
            // 
            this.Panel_P3.BackColor = System.Drawing.Color.Transparent;
            this.Panel_P3.Location = new System.Drawing.Point(402, 714);
            this.Panel_P3.Name = "Panel_P3";
            this.Panel_P3.Size = new System.Drawing.Size(10, 500);
            this.Panel_P3.TabIndex = 175;
            // 
            // Panel_P4
            // 
            this.Panel_P4.BackColor = System.Drawing.Color.Transparent;
            this.Panel_P4.Controls.Add(this.nightHeaderLabel3);
            this.Panel_P4.Controls.Add(this.nightHeaderLabel4);
            this.Panel_P4.Controls.Add(this.nightHeaderLabel5);
            this.Panel_P4.Controls.Add(this.nightHeaderLabel8);
            this.Panel_P4.Controls.Add(this.nightHeaderLabel9);
            this.Panel_P4.Controls.Add(this.nightHeaderLabel10);
            this.Panel_P4.Controls.Add(this.nightHeaderLabel11);
            this.Panel_P4.Controls.Add(this.nightHeaderLabel12);
            this.Panel_P4.Controls.Add(this.nightHeaderLabel13);
            this.Panel_P4.Controls.Add(this.nightHeaderLabel14);
            this.Panel_P4.Controls.Add(this.nightHeaderLabel15);
            this.Panel_P4.Controls.Add(this.nightHeaderLabel16);
            this.Panel_P4.Location = new System.Drawing.Point(402, 714);
            this.Panel_P4.Name = "Panel_P4";
            this.Panel_P4.Size = new System.Drawing.Size(24, 500);
            this.Panel_P4.TabIndex = 176;
            // 
            // nightHeaderLabel3
            // 
            this.nightHeaderLabel3.AutoSize = true;
            this.nightHeaderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel3.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel3.Location = new System.Drawing.Point(288, 212);
            this.nightHeaderLabel3.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel3.Name = "nightHeaderLabel3";
            this.nightHeaderLabel3.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel3.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel3.Size = new System.Drawing.Size(40, 24);
            this.nightHeaderLabel3.TabIndex = 275;
            this.nightHeaderLabel3.Text = "TBD";
            this.nightHeaderLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel3.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel4
            // 
            this.nightHeaderLabel4.AutoSize = true;
            this.nightHeaderLabel4.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel4.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel4.Location = new System.Drawing.Point(80, 211);
            this.nightHeaderLabel4.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel4.Name = "nightHeaderLabel4";
            this.nightHeaderLabel4.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel4.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel4.Size = new System.Drawing.Size(90, 24);
            this.nightHeaderLabel4.TabIndex = 272;
            this.nightHeaderLabel4.Text = "Auto Shoot";
            this.nightHeaderLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel4.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel5
            // 
            this.nightHeaderLabel5.AutoSize = true;
            this.nightHeaderLabel5.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel5.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel5.Location = new System.Drawing.Point(288, 172);
            this.nightHeaderLabel5.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel5.Name = "nightHeaderLabel5";
            this.nightHeaderLabel5.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel5.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel5.Size = new System.Drawing.Size(109, 24);
            this.nightHeaderLabel5.TabIndex = 271;
            this.nightHeaderLabel5.Text = "Rainbow Gun";
            this.nightHeaderLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel5.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel8
            // 
            this.nightHeaderLabel8.AutoSize = true;
            this.nightHeaderLabel8.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel8.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel8.Location = new System.Drawing.Point(80, 171);
            this.nightHeaderLabel8.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel8.Name = "nightHeaderLabel8";
            this.nightHeaderLabel8.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel8.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel8.Size = new System.Drawing.Size(117, 24);
            this.nightHeaderLabel8.TabIndex = 259;
            this.nightHeaderLabel8.Text = "Weapon Cycle";
            this.nightHeaderLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel8.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel9
            // 
            this.nightHeaderLabel9.AutoSize = true;
            this.nightHeaderLabel9.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel9.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel9.Location = new System.Drawing.Point(288, 131);
            this.nightHeaderLabel9.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel9.Name = "nightHeaderLabel9";
            this.nightHeaderLabel9.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel9.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel9.Size = new System.Drawing.Size(133, 24);
            this.nightHeaderLabel9.TabIndex = 257;
            this.nightHeaderLabel9.Text = "ZM To Crosshair";
            this.nightHeaderLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel9.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel9.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel10
            // 
            this.nightHeaderLabel10.AutoSize = true;
            this.nightHeaderLabel10.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel10.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel10.Location = new System.Drawing.Point(80, 131);
            this.nightHeaderLabel10.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel10.Name = "nightHeaderLabel10";
            this.nightHeaderLabel10.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel10.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel10.Size = new System.Drawing.Size(85, 24);
            this.nightHeaderLabel10.TabIndex = 255;
            this.nightHeaderLabel10.Text = "Rapid Fire";
            this.nightHeaderLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel10.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel10.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel11
            // 
            this.nightHeaderLabel11.AutoSize = true;
            this.nightHeaderLabel11.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel11.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel11.Location = new System.Drawing.Point(288, 91);
            this.nightHeaderLabel11.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel11.Name = "nightHeaderLabel11";
            this.nightHeaderLabel11.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel11.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel11.Size = new System.Drawing.Size(101, 24);
            this.nightHeaderLabel11.TabIndex = 253;
            this.nightHeaderLabel11.Text = "Send To Jail";
            this.nightHeaderLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel11.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel11.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel12
            // 
            this.nightHeaderLabel12.AutoSize = true;
            this.nightHeaderLabel12.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel12.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel12.Location = new System.Drawing.Point(80, 91);
            this.nightHeaderLabel12.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel12.Name = "nightHeaderLabel12";
            this.nightHeaderLabel12.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel12.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel12.Size = new System.Drawing.Size(116, 24);
            this.nightHeaderLabel12.TabIndex = 251;
            this.nightHeaderLabel12.Text = "100% Criticals";
            this.nightHeaderLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel12.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel12.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel13
            // 
            this.nightHeaderLabel13.AutoSize = true;
            this.nightHeaderLabel13.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel13.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel13.Location = new System.Drawing.Point(288, 51);
            this.nightHeaderLabel13.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel13.Name = "nightHeaderLabel13";
            this.nightHeaderLabel13.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel13.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel13.Size = new System.Drawing.Size(98, 24);
            this.nightHeaderLabel13.TabIndex = 249;
            this.nightHeaderLabel13.Text = "Speed Hack";
            this.nightHeaderLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel13.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel13.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel14
            // 
            this.nightHeaderLabel14.AutoSize = true;
            this.nightHeaderLabel14.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel14.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel14.Location = new System.Drawing.Point(80, 51);
            this.nightHeaderLabel14.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel14.Name = "nightHeaderLabel14";
            this.nightHeaderLabel14.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel14.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel14.Size = new System.Drawing.Size(131, 24);
            this.nightHeaderLabel14.TabIndex = 247;
            this.nightHeaderLabel14.Text = "Unlimited Ammo";
            this.nightHeaderLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel14.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel14.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel15
            // 
            this.nightHeaderLabel15.AutoSize = true;
            this.nightHeaderLabel15.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel15.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel15.Location = new System.Drawing.Point(288, 11);
            this.nightHeaderLabel15.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel15.Name = "nightHeaderLabel15";
            this.nightHeaderLabel15.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel15.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel15.Size = new System.Drawing.Size(130, 24);
            this.nightHeaderLabel15.TabIndex = 245;
            this.nightHeaderLabel15.Text = "Unlimited Points";
            this.nightHeaderLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel15.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel15.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel16
            // 
            this.nightHeaderLabel16.AutoSize = true;
            this.nightHeaderLabel16.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel16.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel16.Location = new System.Drawing.Point(80, 11);
            this.nightHeaderLabel16.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel16.Name = "nightHeaderLabel16";
            this.nightHeaderLabel16.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel16.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel16.Size = new System.Drawing.Size(85, 24);
            this.nightHeaderLabel16.TabIndex = 243;
            this.nightHeaderLabel16.Text = "God Mode";
            this.nightHeaderLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel16.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel16.UseCompatibleTextRendering = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 10;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // XP_Timer
            // 
            this.XP_Timer.Interval = 1;
            this.XP_Timer.Tick += new System.EventHandler(this.XP_Timer_Tick);
            // 
            // foreverButton1
            // 
            this.foreverButton1.BackColor = System.Drawing.Color.Red;
            this.foreverButton1.BaseColor = System.Drawing.Color.Transparent;
            this.foreverButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverButton1.ForeColor = System.Drawing.Color.Black;
            this.foreverButton1.Location = new System.Drawing.Point(-38, 74);
            this.foreverButton1.Margin = new System.Windows.Forms.Padding(9);
            this.foreverButton1.Name = "foreverButton1";
            this.foreverButton1.Rounded = false;
            this.foreverButton1.Size = new System.Drawing.Size(456, 365);
            this.foreverButton1.TabIndex = 281;
            this.foreverButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.foreverButton1.Click += new System.EventHandler(this.foreverButton1_Click);
            // 
            // FeaturesTabPage
            // 
            this.FeaturesTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.FeaturesTabPage.Controls.Add(this.guna2ToggleSwitch62);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel68);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel69);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel70);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel71);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel72);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel73);
            this.FeaturesTabPage.Controls.Add(this.guna2ToggleSwitch15);
            this.FeaturesTabPage.Controls.Add(this.guna2ToggleSwitch16);
            this.FeaturesTabPage.Controls.Add(this.guna2ToggleSwitch17);
            this.FeaturesTabPage.Controls.Add(this.guna2ToggleSwitch21);
            this.FeaturesTabPage.Controls.Add(this.guna2ToggleSwitch22);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel6);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel7);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel64);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel65);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel66);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel67);
            this.FeaturesTabPage.Controls.Add(this.guna2ToggleSwitch14);
            this.FeaturesTabPage.Controls.Add(this.guna2ToggleSwitch13);
            this.FeaturesTabPage.Controls.Add(this.guna2ToggleSwitch12);
            this.FeaturesTabPage.Controls.Add(this.guna2ToggleSwitch10);
            this.FeaturesTabPage.Controls.Add(this.guna2ToggleSwitch9);
            this.FeaturesTabPage.Controls.Add(this.guna2ToggleSwitch8);
            this.FeaturesTabPage.Controls.Add(this.Btn_Gib2_P1);
            this.FeaturesTabPage.Controls.Add(this.Btn_TP_P1);
            this.FeaturesTabPage.Controls.Add(this.Btn_Gib_P1);
            this.FeaturesTabPage.Controls.Add(this.Box_CycleEnd_P1);
            this.FeaturesTabPage.Controls.Add(this.Box_Weapons_P1);
            this.FeaturesTabPage.Controls.Add(this.Box_TP_P1);
            this.FeaturesTabPage.Controls.Add(this.Box_CycleStart_P1);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel37);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel1);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel38);
            this.FeaturesTabPage.Controls.Add(this.guna2Panel13);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel48);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel2);
            this.FeaturesTabPage.Controls.Add(this.CB_zqinissofuckingsexy_P1);
            this.FeaturesTabPage.Controls.Add(this.guna2Panel1);
            this.FeaturesTabPage.Controls.Add(this.CB_Shoot_P1);
            this.FeaturesTabPage.Controls.Add(this.guna2Panel25);
            this.FeaturesTabPage.Controls.Add(this.CB_Rainbow_P1);
            this.FeaturesTabPage.Controls.Add(this.guna2Panel26);
            this.FeaturesTabPage.Controls.Add(this.guna2Panel24);
            this.FeaturesTabPage.Controls.Add(this.guna2Panel23);
            this.FeaturesTabPage.Controls.Add(this.label37);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel40);
            this.FeaturesTabPage.Controls.Add(this.guna2ToggleSwitch36);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel42);
            this.FeaturesTabPage.Controls.Add(this.label31);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel44);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel39);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel46);
            this.FeaturesTabPage.Controls.Add(this.guna2ToggleSwitch11);
            this.FeaturesTabPage.Controls.Add(this.guna2ToggleSwitch18);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel41);
            this.FeaturesTabPage.Controls.Add(this.label20);
            this.FeaturesTabPage.Controls.Add(this.guna2ToggleSwitch20);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel43);
            this.FeaturesTabPage.Controls.Add(this.label18);
            this.FeaturesTabPage.Controls.Add(this.CB_Croshair_P1);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel45);
            this.FeaturesTabPage.Controls.Add(this.label12);
            this.FeaturesTabPage.Controls.Add(this.CB_Cycle_P1);
            this.FeaturesTabPage.Controls.Add(this.nightHeaderLabel47);
            this.FeaturesTabPage.Controls.Add(this.guna2ToggleSwitch23);
            this.FeaturesTabPage.Controls.Add(this.CB_Jail_P1);
            this.FeaturesTabPage.Controls.Add(this.CB_God_P1);
            this.FeaturesTabPage.Controls.Add(this.CB_Ammo_P1);
            this.FeaturesTabPage.Controls.Add(this.CB_Crit_P1);
            this.FeaturesTabPage.Controls.Add(this.CB_Speed_P1);
            this.FeaturesTabPage.Controls.Add(this.CB_Rapid_P1);
            this.FeaturesTabPage.Controls.Add(this.CB_Points_P1);
            this.FeaturesTabPage.Location = new System.Drawing.Point(4, 44);
            this.FeaturesTabPage.Name = "FeaturesTabPage";
            this.FeaturesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FeaturesTabPage.Size = new System.Drawing.Size(507, 532);
            this.FeaturesTabPage.TabIndex = 1;
            this.FeaturesTabPage.Text = "P1";
            this.FeaturesTabPage.Click += new System.EventHandler(this.FeaturesTabPage_Click);
            // 
            // guna2ToggleSwitch62
            // 
            this.guna2ToggleSwitch62.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch62.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch62.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch62.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch62.CheckedState.Parent = this.guna2ToggleSwitch62;
            this.guna2ToggleSwitch62.Location = new System.Drawing.Point(452, 187);
            this.guna2ToggleSwitch62.Name = "guna2ToggleSwitch62";
            this.guna2ToggleSwitch62.ShadowDecoration.Parent = this.guna2ToggleSwitch62;
            this.guna2ToggleSwitch62.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch62.TabIndex = 308;
            this.guna2ToggleSwitch62.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch62.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch62.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch62.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch62.UncheckedState.Parent = this.guna2ToggleSwitch62;
            this.guna2ToggleSwitch62.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch62_CheckedChanged_1);
            // 
            // nightHeaderLabel68
            // 
            this.nightHeaderLabel68.AutoSize = true;
            this.nightHeaderLabel68.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel68.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel68.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel68.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel68.Location = new System.Drawing.Point(400, 227);
            this.nightHeaderLabel68.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel68.Name = "nightHeaderLabel68";
            this.nightHeaderLabel68.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel68.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel68.Size = new System.Drawing.Size(40, 24);
            this.nightHeaderLabel68.TabIndex = 307;
            this.nightHeaderLabel68.Text = "TBD";
            this.nightHeaderLabel68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel68.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel68.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel69
            // 
            this.nightHeaderLabel69.AutoSize = true;
            this.nightHeaderLabel69.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel69.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel69.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel69.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel69.Location = new System.Drawing.Point(331, 187);
            this.nightHeaderLabel69.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel69.Name = "nightHeaderLabel69";
            this.nightHeaderLabel69.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel69.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel69.Size = new System.Drawing.Size(109, 24);
            this.nightHeaderLabel69.TabIndex = 306;
            this.nightHeaderLabel69.Text = "Rainbow Gun";
            this.nightHeaderLabel69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel69.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel69.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel70
            // 
            this.nightHeaderLabel70.AutoSize = true;
            this.nightHeaderLabel70.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel70.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel70.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel70.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel70.Location = new System.Drawing.Point(310, 147);
            this.nightHeaderLabel70.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel70.Name = "nightHeaderLabel70";
            this.nightHeaderLabel70.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel70.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel70.Size = new System.Drawing.Size(133, 24);
            this.nightHeaderLabel70.TabIndex = 305;
            this.nightHeaderLabel70.Text = "ZM To Crosshair";
            this.nightHeaderLabel70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel70.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel70.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel71
            // 
            this.nightHeaderLabel71.AutoSize = true;
            this.nightHeaderLabel71.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel71.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel71.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel71.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel71.Location = new System.Drawing.Point(342, 107);
            this.nightHeaderLabel71.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel71.Name = "nightHeaderLabel71";
            this.nightHeaderLabel71.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel71.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel71.Size = new System.Drawing.Size(101, 24);
            this.nightHeaderLabel71.TabIndex = 304;
            this.nightHeaderLabel71.Text = "Send To Jail";
            this.nightHeaderLabel71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel71.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel71.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel72
            // 
            this.nightHeaderLabel72.AutoSize = true;
            this.nightHeaderLabel72.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel72.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel72.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel72.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel72.Location = new System.Drawing.Point(342, 67);
            this.nightHeaderLabel72.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel72.Name = "nightHeaderLabel72";
            this.nightHeaderLabel72.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel72.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel72.Size = new System.Drawing.Size(98, 24);
            this.nightHeaderLabel72.TabIndex = 303;
            this.nightHeaderLabel72.Text = "Speed Hack";
            this.nightHeaderLabel72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel72.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel72.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel73
            // 
            this.nightHeaderLabel73.AutoSize = true;
            this.nightHeaderLabel73.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel73.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel73.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel73.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel73.Location = new System.Drawing.Point(310, 27);
            this.nightHeaderLabel73.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel73.Name = "nightHeaderLabel73";
            this.nightHeaderLabel73.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel73.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel73.Size = new System.Drawing.Size(130, 24);
            this.nightHeaderLabel73.TabIndex = 302;
            this.nightHeaderLabel73.Text = "Unlimited Points";
            this.nightHeaderLabel73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel73.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel73.UseCompatibleTextRendering = true;
            // 
            // guna2ToggleSwitch15
            // 
            this.guna2ToggleSwitch15.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch15.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch15.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch15.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch15.CheckedState.Parent = this.guna2ToggleSwitch15;
            this.guna2ToggleSwitch15.Location = new System.Drawing.Point(452, 67);
            this.guna2ToggleSwitch15.Name = "guna2ToggleSwitch15";
            this.guna2ToggleSwitch15.ShadowDecoration.Parent = this.guna2ToggleSwitch15;
            this.guna2ToggleSwitch15.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch15.TabIndex = 301;
            this.guna2ToggleSwitch15.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch15.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch15.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch15.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch15.UncheckedState.Parent = this.guna2ToggleSwitch15;
            this.guna2ToggleSwitch15.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch15_CheckedChanged);
            // 
            // guna2ToggleSwitch16
            // 
            this.guna2ToggleSwitch16.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch16.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch16.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch16.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch16.CheckedState.Parent = this.guna2ToggleSwitch16;
            this.guna2ToggleSwitch16.Location = new System.Drawing.Point(452, 107);
            this.guna2ToggleSwitch16.Name = "guna2ToggleSwitch16";
            this.guna2ToggleSwitch16.ShadowDecoration.Parent = this.guna2ToggleSwitch16;
            this.guna2ToggleSwitch16.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch16.TabIndex = 300;
            this.guna2ToggleSwitch16.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch16.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch16.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch16.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch16.UncheckedState.Parent = this.guna2ToggleSwitch16;
            this.guna2ToggleSwitch16.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch16_CheckedChanged);
            // 
            // guna2ToggleSwitch17
            // 
            this.guna2ToggleSwitch17.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch17.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch17.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch17.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch17.CheckedState.Parent = this.guna2ToggleSwitch17;
            this.guna2ToggleSwitch17.Location = new System.Drawing.Point(452, 227);
            this.guna2ToggleSwitch17.Name = "guna2ToggleSwitch17";
            this.guna2ToggleSwitch17.ShadowDecoration.Parent = this.guna2ToggleSwitch17;
            this.guna2ToggleSwitch17.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch17.TabIndex = 299;
            this.guna2ToggleSwitch17.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch17.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch17.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch17.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch17.UncheckedState.Parent = this.guna2ToggleSwitch17;
            this.guna2ToggleSwitch17.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch17_CheckedChanged);
            // 
            // guna2ToggleSwitch21
            // 
            this.guna2ToggleSwitch21.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch21.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch21.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch21.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch21.CheckedState.Parent = this.guna2ToggleSwitch21;
            this.guna2ToggleSwitch21.Location = new System.Drawing.Point(452, 146);
            this.guna2ToggleSwitch21.Name = "guna2ToggleSwitch21";
            this.guna2ToggleSwitch21.ShadowDecoration.Parent = this.guna2ToggleSwitch21;
            this.guna2ToggleSwitch21.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch21.TabIndex = 297;
            this.guna2ToggleSwitch21.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch21.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch21.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch21.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch21.UncheckedState.Parent = this.guna2ToggleSwitch21;
            this.guna2ToggleSwitch21.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch21_CheckedChanged);
            // 
            // guna2ToggleSwitch22
            // 
            this.guna2ToggleSwitch22.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch22.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch22.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch22.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch22.CheckedState.Parent = this.guna2ToggleSwitch22;
            this.guna2ToggleSwitch22.Location = new System.Drawing.Point(452, 27);
            this.guna2ToggleSwitch22.Name = "guna2ToggleSwitch22";
            this.guna2ToggleSwitch22.ShadowDecoration.Parent = this.guna2ToggleSwitch22;
            this.guna2ToggleSwitch22.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch22.TabIndex = 296;
            this.guna2ToggleSwitch22.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch22.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch22.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch22.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch22.UncheckedState.Parent = this.guna2ToggleSwitch22;
            this.guna2ToggleSwitch22.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch22_CheckedChanged);
            // 
            // nightHeaderLabel6
            // 
            this.nightHeaderLabel6.AutoSize = true;
            this.nightHeaderLabel6.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel6.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel6.Location = new System.Drawing.Point(80, 227);
            this.nightHeaderLabel6.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel6.Name = "nightHeaderLabel6";
            this.nightHeaderLabel6.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel6.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel6.Size = new System.Drawing.Size(90, 24);
            this.nightHeaderLabel6.TabIndex = 295;
            this.nightHeaderLabel6.Text = "Auto Shoot";
            this.nightHeaderLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel6.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel7
            // 
            this.nightHeaderLabel7.AutoSize = true;
            this.nightHeaderLabel7.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel7.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel7.Location = new System.Drawing.Point(80, 187);
            this.nightHeaderLabel7.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel7.Name = "nightHeaderLabel7";
            this.nightHeaderLabel7.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel7.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel7.Size = new System.Drawing.Size(117, 24);
            this.nightHeaderLabel7.TabIndex = 294;
            this.nightHeaderLabel7.Text = "Weapon Cycle";
            this.nightHeaderLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel7.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel64
            // 
            this.nightHeaderLabel64.AutoSize = true;
            this.nightHeaderLabel64.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel64.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel64.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel64.Location = new System.Drawing.Point(80, 147);
            this.nightHeaderLabel64.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel64.Name = "nightHeaderLabel64";
            this.nightHeaderLabel64.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel64.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel64.Size = new System.Drawing.Size(85, 24);
            this.nightHeaderLabel64.TabIndex = 293;
            this.nightHeaderLabel64.Text = "Rapid Fire";
            this.nightHeaderLabel64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel64.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel64.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel65
            // 
            this.nightHeaderLabel65.AutoSize = true;
            this.nightHeaderLabel65.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel65.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel65.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel65.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel65.Location = new System.Drawing.Point(80, 107);
            this.nightHeaderLabel65.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel65.Name = "nightHeaderLabel65";
            this.nightHeaderLabel65.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel65.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel65.Size = new System.Drawing.Size(116, 24);
            this.nightHeaderLabel65.TabIndex = 292;
            this.nightHeaderLabel65.Text = "100% Criticals";
            this.nightHeaderLabel65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel65.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel65.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel66
            // 
            this.nightHeaderLabel66.AutoSize = true;
            this.nightHeaderLabel66.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel66.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel66.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel66.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel66.Location = new System.Drawing.Point(80, 67);
            this.nightHeaderLabel66.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel66.Name = "nightHeaderLabel66";
            this.nightHeaderLabel66.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel66.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel66.Size = new System.Drawing.Size(131, 24);
            this.nightHeaderLabel66.TabIndex = 291;
            this.nightHeaderLabel66.Text = "Unlimited Ammo";
            this.nightHeaderLabel66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel66.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel66.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel67
            // 
            this.nightHeaderLabel67.AutoSize = true;
            this.nightHeaderLabel67.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel67.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel67.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel67.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel67.Location = new System.Drawing.Point(80, 27);
            this.nightHeaderLabel67.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel67.Name = "nightHeaderLabel67";
            this.nightHeaderLabel67.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel67.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel67.Size = new System.Drawing.Size(85, 24);
            this.nightHeaderLabel67.TabIndex = 290;
            this.nightHeaderLabel67.Text = "God Mode";
            this.nightHeaderLabel67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel67.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel67.UseCompatibleTextRendering = true;
            // 
            // guna2ToggleSwitch14
            // 
            this.guna2ToggleSwitch14.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch14.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch14.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch14.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch14.CheckedState.Parent = this.guna2ToggleSwitch14;
            this.guna2ToggleSwitch14.Location = new System.Drawing.Point(32, 67);
            this.guna2ToggleSwitch14.Name = "guna2ToggleSwitch14";
            this.guna2ToggleSwitch14.ShadowDecoration.Parent = this.guna2ToggleSwitch14;
            this.guna2ToggleSwitch14.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch14.TabIndex = 289;
            this.guna2ToggleSwitch14.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch14.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch14.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch14.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch14.UncheckedState.Parent = this.guna2ToggleSwitch14;
            this.guna2ToggleSwitch14.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch14_CheckedChanged_1);
            // 
            // guna2ToggleSwitch13
            // 
            this.guna2ToggleSwitch13.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch13.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch13.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch13.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch13.CheckedState.Parent = this.guna2ToggleSwitch13;
            this.guna2ToggleSwitch13.Location = new System.Drawing.Point(32, 107);
            this.guna2ToggleSwitch13.Name = "guna2ToggleSwitch13";
            this.guna2ToggleSwitch13.ShadowDecoration.Parent = this.guna2ToggleSwitch13;
            this.guna2ToggleSwitch13.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch13.TabIndex = 288;
            this.guna2ToggleSwitch13.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch13.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch13.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch13.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch13.UncheckedState.Parent = this.guna2ToggleSwitch13;
            this.guna2ToggleSwitch13.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch13_CheckedChanged);
            // 
            // guna2ToggleSwitch12
            // 
            this.guna2ToggleSwitch12.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch12.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch12.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch12.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch12.CheckedState.Parent = this.guna2ToggleSwitch12;
            this.guna2ToggleSwitch12.Location = new System.Drawing.Point(32, 227);
            this.guna2ToggleSwitch12.Name = "guna2ToggleSwitch12";
            this.guna2ToggleSwitch12.ShadowDecoration.Parent = this.guna2ToggleSwitch12;
            this.guna2ToggleSwitch12.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch12.TabIndex = 287;
            this.guna2ToggleSwitch12.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch12.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch12.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch12.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch12.UncheckedState.Parent = this.guna2ToggleSwitch12;
            // 
            // guna2ToggleSwitch10
            // 
            this.guna2ToggleSwitch10.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch10.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch10.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch10.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch10.CheckedState.Parent = this.guna2ToggleSwitch10;
            this.guna2ToggleSwitch10.Location = new System.Drawing.Point(32, 187);
            this.guna2ToggleSwitch10.Name = "guna2ToggleSwitch10";
            this.guna2ToggleSwitch10.ShadowDecoration.Parent = this.guna2ToggleSwitch10;
            this.guna2ToggleSwitch10.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch10.TabIndex = 286;
            this.guna2ToggleSwitch10.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch10.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch10.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch10.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch10.UncheckedState.Parent = this.guna2ToggleSwitch10;
            // 
            // guna2ToggleSwitch9
            // 
            this.guna2ToggleSwitch9.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch9.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch9.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch9.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch9.CheckedState.Parent = this.guna2ToggleSwitch9;
            this.guna2ToggleSwitch9.Location = new System.Drawing.Point(32, 146);
            this.guna2ToggleSwitch9.Name = "guna2ToggleSwitch9";
            this.guna2ToggleSwitch9.ShadowDecoration.Parent = this.guna2ToggleSwitch9;
            this.guna2ToggleSwitch9.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch9.TabIndex = 285;
            this.guna2ToggleSwitch9.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch9.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch9.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch9.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch9.UncheckedState.Parent = this.guna2ToggleSwitch9;
            this.guna2ToggleSwitch9.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch9_CheckedChanged);
            // 
            // guna2ToggleSwitch8
            // 
            this.guna2ToggleSwitch8.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch8.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch8.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch8.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch8.CheckedState.Parent = this.guna2ToggleSwitch8;
            this.guna2ToggleSwitch8.Location = new System.Drawing.Point(32, 27);
            this.guna2ToggleSwitch8.Name = "guna2ToggleSwitch8";
            this.guna2ToggleSwitch8.ShadowDecoration.Parent = this.guna2ToggleSwitch8;
            this.guna2ToggleSwitch8.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch8.TabIndex = 284;
            this.guna2ToggleSwitch8.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch8.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch8.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch8.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch8.UncheckedState.Parent = this.guna2ToggleSwitch8;
            this.guna2ToggleSwitch8.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch8_CheckedChanged);
            // 
            // Btn_Gib2_P1
            // 
            this.Btn_Gib2_P1.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Gib2_P1.BaseColor = System.Drawing.Color.Transparent;
            this.Btn_Gib2_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Gib2_P1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Gib2_P1.Location = new System.Drawing.Point(592, -69);
            this.Btn_Gib2_P1.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Gib2_P1.Name = "Btn_Gib2_P1";
            this.Btn_Gib2_P1.Rounded = false;
            this.Btn_Gib2_P1.Size = new System.Drawing.Size(192, 25);
            this.Btn_Gib2_P1.TabIndex = 231;
            this.Btn_Gib2_P1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Btn_Gib2_P1.Click += new System.EventHandler(this.Btn_Gib2_P1_Click);
            // 
            // Btn_TP_P1
            // 
            this.Btn_TP_P1.BackColor = System.Drawing.Color.Transparent;
            this.Btn_TP_P1.BaseColor = System.Drawing.Color.Transparent;
            this.Btn_TP_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_TP_P1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TP_P1.Location = new System.Drawing.Point(320, -132);
            this.Btn_TP_P1.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_TP_P1.Name = "Btn_TP_P1";
            this.Btn_TP_P1.Rounded = false;
            this.Btn_TP_P1.Size = new System.Drawing.Size(464, 25);
            this.Btn_TP_P1.TabIndex = 232;
            this.Btn_TP_P1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Btn_TP_P1.Click += new System.EventHandler(this.Btn_TP_P1_Click);
            // 
            // Btn_Gib_P1
            // 
            this.Btn_Gib_P1.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Gib_P1.BaseColor = System.Drawing.Color.Transparent;
            this.Btn_Gib_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Gib_P1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Gib_P1.Location = new System.Drawing.Point(330, -69);
            this.Btn_Gib_P1.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Gib_P1.Name = "Btn_Gib_P1";
            this.Btn_Gib_P1.Rounded = false;
            this.Btn_Gib_P1.Size = new System.Drawing.Size(200, 25);
            this.Btn_Gib_P1.TabIndex = 230;
            this.Btn_Gib_P1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Btn_Gib_P1.Click += new System.EventHandler(this.Btn_Gib_P1_Click);
            // 
            // Box_CycleEnd_P1
            // 
            this.Box_CycleEnd_P1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.Box_CycleEnd_P1.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Box_CycleEnd_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_CycleEnd_P1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Box_CycleEnd_P1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_CycleEnd_P1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_CycleEnd_P1.ForeColor = System.Drawing.Color.White;
            this.Box_CycleEnd_P1.FormattingEnabled = true;
            this.Box_CycleEnd_P1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(49)))), ((int)(((byte)(222)))));
            this.Box_CycleEnd_P1.HoverFontColor = System.Drawing.Color.White;
            this.Box_CycleEnd_P1.ItemHeight = 20;
            this.Box_CycleEnd_P1.Location = new System.Drawing.Point(594, -164);
            this.Box_CycleEnd_P1.Margin = new System.Windows.Forms.Padding(9);
            this.Box_CycleEnd_P1.Name = "Box_CycleEnd_P1";
            this.Box_CycleEnd_P1.Size = new System.Drawing.Size(190, 26);
            this.Box_CycleEnd_P1.TabIndex = 234;
            // 
            // Box_Weapons_P1
            // 
            this.Box_Weapons_P1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.Box_Weapons_P1.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Box_Weapons_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_Weapons_P1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Box_Weapons_P1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Weapons_P1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Weapons_P1.ForeColor = System.Drawing.Color.White;
            this.Box_Weapons_P1.FormattingEnabled = true;
            this.Box_Weapons_P1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(49)))), ((int)(((byte)(222)))));
            this.Box_Weapons_P1.HoverFontColor = System.Drawing.Color.White;
            this.Box_Weapons_P1.ItemHeight = 20;
            this.Box_Weapons_P1.Location = new System.Drawing.Point(330, -38);
            this.Box_Weapons_P1.Margin = new System.Windows.Forms.Padding(9);
            this.Box_Weapons_P1.Name = "Box_Weapons_P1";
            this.Box_Weapons_P1.Size = new System.Drawing.Size(454, 26);
            this.Box_Weapons_P1.TabIndex = 228;
            // 
            // Box_TP_P1
            // 
            this.Box_TP_P1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.Box_TP_P1.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Box_TP_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_TP_P1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Box_TP_P1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_TP_P1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_TP_P1.ForeColor = System.Drawing.Color.White;
            this.Box_TP_P1.FormattingEnabled = true;
            this.Box_TP_P1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(49)))), ((int)(((byte)(222)))));
            this.Box_TP_P1.HoverFontColor = System.Drawing.Color.White;
            this.Box_TP_P1.ItemHeight = 20;
            this.Box_TP_P1.Items.AddRange(new object[] {
            "Spawn",
            "Nacht",
            "Pond",
            "Power"});
            this.Box_TP_P1.Location = new System.Drawing.Point(330, -100);
            this.Box_TP_P1.Margin = new System.Windows.Forms.Padding(9);
            this.Box_TP_P1.Name = "Box_TP_P1";
            this.Box_TP_P1.Size = new System.Drawing.Size(454, 26);
            this.Box_TP_P1.TabIndex = 229;
            // 
            // Box_CycleStart_P1
            // 
            this.Box_CycleStart_P1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.Box_CycleStart_P1.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Box_CycleStart_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_CycleStart_P1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Box_CycleStart_P1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_CycleStart_P1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_CycleStart_P1.ForeColor = System.Drawing.Color.White;
            this.Box_CycleStart_P1.FormattingEnabled = true;
            this.Box_CycleStart_P1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(49)))), ((int)(((byte)(222)))));
            this.Box_CycleStart_P1.HoverFontColor = System.Drawing.Color.White;
            this.Box_CycleStart_P1.ItemHeight = 20;
            this.Box_CycleStart_P1.Location = new System.Drawing.Point(330, -164);
            this.Box_CycleStart_P1.Margin = new System.Windows.Forms.Padding(9);
            this.Box_CycleStart_P1.Name = "Box_CycleStart_P1";
            this.Box_CycleStart_P1.Size = new System.Drawing.Size(180, 26);
            this.Box_CycleStart_P1.TabIndex = 233;
            // 
            // nightHeaderLabel37
            // 
            this.nightHeaderLabel37.AutoSize = true;
            this.nightHeaderLabel37.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel37.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel37.Location = new System.Drawing.Point(701, -194);
            this.nightHeaderLabel37.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel37.Name = "nightHeaderLabel37";
            this.nightHeaderLabel37.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel37.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel37.Size = new System.Drawing.Size(0, 23);
            this.nightHeaderLabel37.TabIndex = 236;
            this.nightHeaderLabel37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel37.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel37.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel1
            // 
            this.nightHeaderLabel1.AutoSize = true;
            this.nightHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel1.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel1.Location = new System.Drawing.Point(680, -224);
            this.nightHeaderLabel1.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel1.Name = "nightHeaderLabel1";
            this.nightHeaderLabel1.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel1.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel1.Size = new System.Drawing.Size(0, 23);
            this.nightHeaderLabel1.TabIndex = 242;
            this.nightHeaderLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel1.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel38
            // 
            this.nightHeaderLabel38.AutoSize = true;
            this.nightHeaderLabel38.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel38.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel38.Location = new System.Drawing.Point(330, -194);
            this.nightHeaderLabel38.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel38.Name = "nightHeaderLabel38";
            this.nightHeaderLabel38.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel38.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel38.Size = new System.Drawing.Size(0, 23);
            this.nightHeaderLabel38.TabIndex = 235;
            this.nightHeaderLabel38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel38.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel38.UseCompatibleTextRendering = true;
            // 
            // guna2Panel13
            // 
            this.guna2Panel13.BackColor = System.Drawing.Color.Red;
            this.guna2Panel13.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel13.BorderThickness = 2;
            this.guna2Panel13.Location = new System.Drawing.Point(498, -1);
            this.guna2Panel13.Name = "guna2Panel13";
            this.guna2Panel13.ShadowDecoration.Parent = this.guna2Panel13;
            this.guna2Panel13.Size = new System.Drawing.Size(10, 531);
            this.guna2Panel13.TabIndex = 215;
            // 
            // nightHeaderLabel48
            // 
            this.nightHeaderLabel48.AutoSize = true;
            this.nightHeaderLabel48.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel48.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel48.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel48.Location = new System.Drawing.Point(611, -266);
            this.nightHeaderLabel48.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel48.Name = "nightHeaderLabel48";
            this.nightHeaderLabel48.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel48.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel48.Size = new System.Drawing.Size(0, 23);
            this.nightHeaderLabel48.TabIndex = 238;
            this.nightHeaderLabel48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel48.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel48.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel2
            // 
            this.nightHeaderLabel2.AutoSize = true;
            this.nightHeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel2.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel2.Location = new System.Drawing.Point(406, -224);
            this.nightHeaderLabel2.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel2.Name = "nightHeaderLabel2";
            this.nightHeaderLabel2.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel2.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel2.Size = new System.Drawing.Size(0, 23);
            this.nightHeaderLabel2.TabIndex = 239;
            this.nightHeaderLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel2.UseCompatibleTextRendering = true;
            // 
            // CB_zqinissofuckingsexy_P1
            // 
            this.CB_zqinissofuckingsexy_P1.BackColor = System.Drawing.Color.Transparent;
            this.CB_zqinissofuckingsexy_P1.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_zqinissofuckingsexy_P1.BorderColor = System.Drawing.Color.White;
            this.CB_zqinissofuckingsexy_P1.CheckColor = System.Drawing.Color.Red;
            this.CB_zqinissofuckingsexy_P1.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_zqinissofuckingsexy_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_zqinissofuckingsexy_P1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_zqinissofuckingsexy_P1.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_zqinissofuckingsexy_P1.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_zqinissofuckingsexy_P1.IsDerivedStyle = false;
            this.CB_zqinissofuckingsexy_P1.Location = new System.Drawing.Point(726, -224);
            this.CB_zqinissofuckingsexy_P1.Margin = new System.Windows.Forms.Padding(9);
            this.CB_zqinissofuckingsexy_P1.Name = "CB_zqinissofuckingsexy_P1";
            this.CB_zqinissofuckingsexy_P1.Size = new System.Drawing.Size(58, 22);
            this.CB_zqinissofuckingsexy_P1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_zqinissofuckingsexy_P1.StyleManager = null;
            this.CB_zqinissofuckingsexy_P1.Switched = false;
            this.CB_zqinissofuckingsexy_P1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_zqinissofuckingsexy_P1.TabIndex = 241;
            this.CB_zqinissofuckingsexy_P1.ThemeAuthor = "Taiizor";
            this.CB_zqinissofuckingsexy_P1.ThemeName = "MetroLight";
            this.CB_zqinissofuckingsexy_P1.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Red;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Location = new System.Drawing.Point(515, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(11, 284);
            this.guna2Panel1.TabIndex = 238;
            // 
            // CB_Shoot_P1
            // 
            this.CB_Shoot_P1.BackColor = System.Drawing.Color.Transparent;
            this.CB_Shoot_P1.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Shoot_P1.BorderColor = System.Drawing.Color.White;
            this.CB_Shoot_P1.CheckColor = System.Drawing.Color.Red;
            this.CB_Shoot_P1.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Shoot_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Shoot_P1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Shoot_P1.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Shoot_P1.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Shoot_P1.IsDerivedStyle = false;
            this.CB_Shoot_P1.Location = new System.Drawing.Point(330, -224);
            this.CB_Shoot_P1.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Shoot_P1.Name = "CB_Shoot_P1";
            this.CB_Shoot_P1.Size = new System.Drawing.Size(58, 22);
            this.CB_Shoot_P1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Shoot_P1.StyleManager = null;
            this.CB_Shoot_P1.Switched = false;
            this.CB_Shoot_P1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Shoot_P1.TabIndex = 240;
            this.CB_Shoot_P1.ThemeAuthor = "Taiizor";
            this.CB_Shoot_P1.ThemeName = "MetroLight";
            this.CB_Shoot_P1.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // guna2Panel25
            // 
            this.guna2Panel25.BackColor = System.Drawing.Color.Red;
            this.guna2Panel25.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel25.BorderThickness = 2;
            this.guna2Panel25.Location = new System.Drawing.Point(-3, 520);
            this.guna2Panel25.Name = "guna2Panel25";
            this.guna2Panel25.ShadowDecoration.Parent = this.guna2Panel25;
            this.guna2Panel25.Size = new System.Drawing.Size(760, 10);
            this.guna2Panel25.TabIndex = 221;
            // 
            // CB_Rainbow_P1
            // 
            this.CB_Rainbow_P1.BackColor = System.Drawing.Color.Transparent;
            this.CB_Rainbow_P1.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Rainbow_P1.BorderColor = System.Drawing.Color.White;
            this.CB_Rainbow_P1.CheckColor = System.Drawing.Color.Red;
            this.CB_Rainbow_P1.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Rainbow_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Rainbow_P1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Rainbow_P1.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Rainbow_P1.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Rainbow_P1.IsDerivedStyle = false;
            this.CB_Rainbow_P1.Location = new System.Drawing.Point(726, -264);
            this.CB_Rainbow_P1.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Rainbow_P1.Name = "CB_Rainbow_P1";
            this.CB_Rainbow_P1.Size = new System.Drawing.Size(58, 22);
            this.CB_Rainbow_P1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Rainbow_P1.StyleManager = null;
            this.CB_Rainbow_P1.Switched = false;
            this.CB_Rainbow_P1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Rainbow_P1.TabIndex = 237;
            this.CB_Rainbow_P1.ThemeAuthor = "Taiizor";
            this.CB_Rainbow_P1.ThemeName = "MetroLight";
            this.CB_Rainbow_P1.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // guna2Panel26
            // 
            this.guna2Panel26.BackColor = System.Drawing.Color.Red;
            this.guna2Panel26.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel26.BorderThickness = 2;
            this.guna2Panel26.Location = new System.Drawing.Point(0, -1);
            this.guna2Panel26.Name = "guna2Panel26";
            this.guna2Panel26.ShadowDecoration.Parent = this.guna2Panel26;
            this.guna2Panel26.Size = new System.Drawing.Size(760, 10);
            this.guna2Panel26.TabIndex = 221;
            // 
            // guna2Panel24
            // 
            this.guna2Panel24.BackColor = System.Drawing.Color.Red;
            this.guna2Panel24.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel24.BorderThickness = 2;
            this.guna2Panel24.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel24.Name = "guna2Panel24";
            this.guna2Panel24.ShadowDecoration.Parent = this.guna2Panel24;
            this.guna2Panel24.Size = new System.Drawing.Size(10, 531);
            this.guna2Panel24.TabIndex = 214;
            // 
            // guna2Panel23
            // 
            this.guna2Panel23.BackColor = System.Drawing.Color.Red;
            this.guna2Panel23.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel23.BorderThickness = 2;
            this.guna2Panel23.Location = new System.Drawing.Point(732, 0);
            this.guna2Panel23.Name = "guna2Panel23";
            this.guna2Panel23.ShadowDecoration.Parent = this.guna2Panel23;
            this.guna2Panel23.Size = new System.Drawing.Size(10, 284);
            this.guna2Panel23.TabIndex = 214;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.Red;
            this.label37.Location = new System.Drawing.Point(537, 111);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(0, 15);
            this.label37.TabIndex = 237;
            // 
            // nightHeaderLabel40
            // 
            this.nightHeaderLabel40.AutoSize = true;
            this.nightHeaderLabel40.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel40.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel40.Location = new System.Drawing.Point(587, -304);
            this.nightHeaderLabel40.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel40.Name = "nightHeaderLabel40";
            this.nightHeaderLabel40.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel40.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel40.Size = new System.Drawing.Size(0, 23);
            this.nightHeaderLabel40.TabIndex = 224;
            this.nightHeaderLabel40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel40.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel40.UseCompatibleTextRendering = true;
            // 
            // guna2ToggleSwitch36
            // 
            this.guna2ToggleSwitch36.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch36.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch36.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch36.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch36.CheckedState.Parent = this.guna2ToggleSwitch36;
            this.guna2ToggleSwitch36.Location = new System.Drawing.Point(570, 146);
            this.guna2ToggleSwitch36.Name = "guna2ToggleSwitch36";
            this.guna2ToggleSwitch36.ShadowDecoration.Parent = this.guna2ToggleSwitch36;
            this.guna2ToggleSwitch36.Size = new System.Drawing.Size(17, 17);
            this.guna2ToggleSwitch36.TabIndex = 236;
            this.guna2ToggleSwitch36.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch36.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch36.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch36.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch36.UncheckedState.Parent = this.guna2ToggleSwitch36;
            // 
            // nightHeaderLabel42
            // 
            this.nightHeaderLabel42.AutoSize = true;
            this.nightHeaderLabel42.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel42.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel42.Location = new System.Drawing.Point(616, -344);
            this.nightHeaderLabel42.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel42.Name = "nightHeaderLabel42";
            this.nightHeaderLabel42.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel42.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel42.Size = new System.Drawing.Size(0, 23);
            this.nightHeaderLabel42.TabIndex = 220;
            this.nightHeaderLabel42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel42.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel42.UseCompatibleTextRendering = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Red;
            this.label31.Location = new System.Drawing.Point(555, 198);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(0, 15);
            this.label31.TabIndex = 214;
            // 
            // nightHeaderLabel44
            // 
            this.nightHeaderLabel44.AutoSize = true;
            this.nightHeaderLabel44.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel44.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel44.Location = new System.Drawing.Point(616, -384);
            this.nightHeaderLabel44.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel44.Name = "nightHeaderLabel44";
            this.nightHeaderLabel44.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel44.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel44.Size = new System.Drawing.Size(0, 23);
            this.nightHeaderLabel44.TabIndex = 216;
            this.nightHeaderLabel44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel44.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel44.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel39
            // 
            this.nightHeaderLabel39.AutoSize = true;
            this.nightHeaderLabel39.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel39.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel39.Location = new System.Drawing.Point(406, -264);
            this.nightHeaderLabel39.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel39.Name = "nightHeaderLabel39";
            this.nightHeaderLabel39.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel39.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel39.Size = new System.Drawing.Size(0, 23);
            this.nightHeaderLabel39.TabIndex = 226;
            this.nightHeaderLabel39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel39.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel39.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel46
            // 
            this.nightHeaderLabel46.AutoSize = true;
            this.nightHeaderLabel46.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel46.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel46.Location = new System.Drawing.Point(587, -424);
            this.nightHeaderLabel46.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel46.Name = "nightHeaderLabel46";
            this.nightHeaderLabel46.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel46.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel46.Size = new System.Drawing.Size(0, 23);
            this.nightHeaderLabel46.TabIndex = 212;
            this.nightHeaderLabel46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel46.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel46.UseCompatibleTextRendering = true;
            // 
            // guna2ToggleSwitch11
            // 
            this.guna2ToggleSwitch11.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch11.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch11.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch11.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch11.CheckedState.Parent = this.guna2ToggleSwitch11;
            this.guna2ToggleSwitch11.Location = new System.Drawing.Point(579, 224);
            this.guna2ToggleSwitch11.Name = "guna2ToggleSwitch11";
            this.guna2ToggleSwitch11.ShadowDecoration.Parent = this.guna2ToggleSwitch11;
            this.guna2ToggleSwitch11.Size = new System.Drawing.Size(17, 17);
            this.guna2ToggleSwitch11.TabIndex = 213;
            this.guna2ToggleSwitch11.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch11.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch11.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch11.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch11.UncheckedState.Parent = this.guna2ToggleSwitch11;
            // 
            // guna2ToggleSwitch18
            // 
            this.guna2ToggleSwitch18.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch18.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch18.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch18.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch18.CheckedState.Parent = this.guna2ToggleSwitch18;
            this.guna2ToggleSwitch18.Location = new System.Drawing.Point(662, 224);
            this.guna2ToggleSwitch18.Name = "guna2ToggleSwitch18";
            this.guna2ToggleSwitch18.ShadowDecoration.Parent = this.guna2ToggleSwitch18;
            this.guna2ToggleSwitch18.Size = new System.Drawing.Size(17, 17);
            this.guna2ToggleSwitch18.TabIndex = 212;
            this.guna2ToggleSwitch18.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch18.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch18.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch18.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch18.UncheckedState.Parent = this.guna2ToggleSwitch18;
            // 
            // nightHeaderLabel41
            // 
            this.nightHeaderLabel41.AutoSize = true;
            this.nightHeaderLabel41.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel41.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel41.Location = new System.Drawing.Point(406, -304);
            this.nightHeaderLabel41.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel41.Name = "nightHeaderLabel41";
            this.nightHeaderLabel41.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel41.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel41.Size = new System.Drawing.Size(0, 23);
            this.nightHeaderLabel41.TabIndex = 222;
            this.nightHeaderLabel41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel41.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel41.UseCompatibleTextRendering = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(632, 198);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 15);
            this.label20.TabIndex = 211;
            // 
            // guna2ToggleSwitch20
            // 
            this.guna2ToggleSwitch20.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch20.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch20.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch20.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch20.CheckedState.Parent = this.guna2ToggleSwitch20;
            this.guna2ToggleSwitch20.Location = new System.Drawing.Point(657, 146);
            this.guna2ToggleSwitch20.Name = "guna2ToggleSwitch20";
            this.guna2ToggleSwitch20.ShadowDecoration.Parent = this.guna2ToggleSwitch20;
            this.guna2ToggleSwitch20.Size = new System.Drawing.Size(17, 17);
            this.guna2ToggleSwitch20.TabIndex = 208;
            this.guna2ToggleSwitch20.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch20.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch20.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch20.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch20.UncheckedState.Parent = this.guna2ToggleSwitch20;
            // 
            // nightHeaderLabel43
            // 
            this.nightHeaderLabel43.AutoSize = true;
            this.nightHeaderLabel43.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel43.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel43.Location = new System.Drawing.Point(406, -344);
            this.nightHeaderLabel43.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel43.Name = "nightHeaderLabel43";
            this.nightHeaderLabel43.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel43.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel43.Size = new System.Drawing.Size(0, 23);
            this.nightHeaderLabel43.TabIndex = 218;
            this.nightHeaderLabel43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel43.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel43.UseCompatibleTextRendering = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(615, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 15);
            this.label18.TabIndex = 207;
            // 
            // CB_Croshair_P1
            // 
            this.CB_Croshair_P1.BackColor = System.Drawing.Color.Transparent;
            this.CB_Croshair_P1.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Croshair_P1.BorderColor = System.Drawing.Color.White;
            this.CB_Croshair_P1.CheckColor = System.Drawing.Color.Red;
            this.CB_Croshair_P1.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Croshair_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Croshair_P1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Croshair_P1.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Croshair_P1.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Croshair_P1.IsDerivedStyle = false;
            this.CB_Croshair_P1.Location = new System.Drawing.Point(726, -304);
            this.CB_Croshair_P1.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Croshair_P1.Name = "CB_Croshair_P1";
            this.CB_Croshair_P1.Size = new System.Drawing.Size(58, 22);
            this.CB_Croshair_P1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Croshair_P1.StyleManager = null;
            this.CB_Croshair_P1.Switched = false;
            this.CB_Croshair_P1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Croshair_P1.TabIndex = 225;
            this.CB_Croshair_P1.ThemeAuthor = "Taiizor";
            this.CB_Croshair_P1.ThemeName = "MetroLight";
            this.CB_Croshair_P1.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // nightHeaderLabel45
            // 
            this.nightHeaderLabel45.AutoSize = true;
            this.nightHeaderLabel45.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel45.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel45.Location = new System.Drawing.Point(406, -384);
            this.nightHeaderLabel45.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel45.Name = "nightHeaderLabel45";
            this.nightHeaderLabel45.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel45.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel45.Size = new System.Drawing.Size(0, 23);
            this.nightHeaderLabel45.TabIndex = 214;
            this.nightHeaderLabel45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel45.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel45.UseCompatibleTextRendering = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(658, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 15);
            this.label12.TabIndex = 194;
            // 
            // CB_Cycle_P1
            // 
            this.CB_Cycle_P1.BackColor = System.Drawing.Color.Transparent;
            this.CB_Cycle_P1.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Cycle_P1.BorderColor = System.Drawing.Color.White;
            this.CB_Cycle_P1.CheckColor = System.Drawing.Color.Red;
            this.CB_Cycle_P1.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Cycle_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Cycle_P1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Cycle_P1.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Cycle_P1.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Cycle_P1.IsDerivedStyle = false;
            this.CB_Cycle_P1.Location = new System.Drawing.Point(330, -264);
            this.CB_Cycle_P1.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Cycle_P1.Name = "CB_Cycle_P1";
            this.CB_Cycle_P1.Size = new System.Drawing.Size(58, 22);
            this.CB_Cycle_P1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Cycle_P1.StyleManager = null;
            this.CB_Cycle_P1.Switched = false;
            this.CB_Cycle_P1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Cycle_P1.TabIndex = 227;
            this.CB_Cycle_P1.ThemeAuthor = "Taiizor";
            this.CB_Cycle_P1.ThemeName = "MetroLight";
            this.CB_Cycle_P1.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.CB_Cycle_P1.SwitchedChanged += new ReaLTaiizor.Controls.MetroSwitch.SwitchedChangedEventHandler(this.CB_Cycle_P1_SwitchedChanged);
            // 
            // nightHeaderLabel47
            // 
            this.nightHeaderLabel47.AutoSize = true;
            this.nightHeaderLabel47.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel47.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel47.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel47.Location = new System.Drawing.Point(406, -424);
            this.nightHeaderLabel47.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel47.Name = "nightHeaderLabel47";
            this.nightHeaderLabel47.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel47.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel47.Size = new System.Drawing.Size(0, 23);
            this.nightHeaderLabel47.TabIndex = 210;
            this.nightHeaderLabel47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel47.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel47.UseCompatibleTextRendering = true;
            // 
            // guna2ToggleSwitch23
            // 
            this.guna2ToggleSwitch23.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch23.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch23.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch23.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch23.CheckedState.Parent = this.guna2ToggleSwitch23;
            this.guna2ToggleSwitch23.Location = new System.Drawing.Point(635, 57);
            this.guna2ToggleSwitch23.Name = "guna2ToggleSwitch23";
            this.guna2ToggleSwitch23.ShadowDecoration.Parent = this.guna2ToggleSwitch23;
            this.guna2ToggleSwitch23.Size = new System.Drawing.Size(17, 17);
            this.guna2ToggleSwitch23.TabIndex = 197;
            this.guna2ToggleSwitch23.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch23.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch23.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch23.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch23.UncheckedState.Parent = this.guna2ToggleSwitch23;
            // 
            // CB_Jail_P1
            // 
            this.CB_Jail_P1.BackColor = System.Drawing.Color.Transparent;
            this.CB_Jail_P1.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Jail_P1.BorderColor = System.Drawing.Color.White;
            this.CB_Jail_P1.CheckColor = System.Drawing.Color.Red;
            this.CB_Jail_P1.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Jail_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Jail_P1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Jail_P1.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Jail_P1.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Jail_P1.IsDerivedStyle = false;
            this.CB_Jail_P1.Location = new System.Drawing.Point(726, -344);
            this.CB_Jail_P1.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Jail_P1.Name = "CB_Jail_P1";
            this.CB_Jail_P1.Size = new System.Drawing.Size(58, 22);
            this.CB_Jail_P1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Jail_P1.StyleManager = null;
            this.CB_Jail_P1.Switched = false;
            this.CB_Jail_P1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Jail_P1.TabIndex = 221;
            this.CB_Jail_P1.ThemeAuthor = "Taiizor";
            this.CB_Jail_P1.ThemeName = "MetroLight";
            this.CB_Jail_P1.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // CB_God_P1
            // 
            this.CB_God_P1.BackColor = System.Drawing.Color.Transparent;
            this.CB_God_P1.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_God_P1.BorderColor = System.Drawing.Color.White;
            this.CB_God_P1.CheckColor = System.Drawing.Color.Red;
            this.CB_God_P1.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_God_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_God_P1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_God_P1.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_God_P1.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_God_P1.IsDerivedStyle = false;
            this.CB_God_P1.Location = new System.Drawing.Point(330, -424);
            this.CB_God_P1.Margin = new System.Windows.Forms.Padding(9);
            this.CB_God_P1.Name = "CB_God_P1";
            this.CB_God_P1.Size = new System.Drawing.Size(58, 22);
            this.CB_God_P1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_God_P1.StyleManager = null;
            this.CB_God_P1.Switched = false;
            this.CB_God_P1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_God_P1.TabIndex = 211;
            this.CB_God_P1.ThemeAuthor = "Taiizor";
            this.CB_God_P1.ThemeName = "MetroLight";
            this.CB_God_P1.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // CB_Ammo_P1
            // 
            this.CB_Ammo_P1.BackColor = System.Drawing.Color.Transparent;
            this.CB_Ammo_P1.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Ammo_P1.BorderColor = System.Drawing.Color.White;
            this.CB_Ammo_P1.CheckColor = System.Drawing.Color.Red;
            this.CB_Ammo_P1.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Ammo_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Ammo_P1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Ammo_P1.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Ammo_P1.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Ammo_P1.IsDerivedStyle = false;
            this.CB_Ammo_P1.Location = new System.Drawing.Point(330, -384);
            this.CB_Ammo_P1.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Ammo_P1.Name = "CB_Ammo_P1";
            this.CB_Ammo_P1.Size = new System.Drawing.Size(58, 22);
            this.CB_Ammo_P1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Ammo_P1.StyleManager = null;
            this.CB_Ammo_P1.Switched = false;
            this.CB_Ammo_P1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Ammo_P1.TabIndex = 215;
            this.CB_Ammo_P1.ThemeAuthor = "Taiizor";
            this.CB_Ammo_P1.ThemeName = "MetroLight";
            this.CB_Ammo_P1.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // CB_Crit_P1
            // 
            this.CB_Crit_P1.BackColor = System.Drawing.Color.Transparent;
            this.CB_Crit_P1.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Crit_P1.BorderColor = System.Drawing.Color.White;
            this.CB_Crit_P1.CheckColor = System.Drawing.Color.Red;
            this.CB_Crit_P1.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Crit_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Crit_P1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Crit_P1.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Crit_P1.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Crit_P1.IsDerivedStyle = false;
            this.CB_Crit_P1.Location = new System.Drawing.Point(330, -344);
            this.CB_Crit_P1.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Crit_P1.Name = "CB_Crit_P1";
            this.CB_Crit_P1.Size = new System.Drawing.Size(58, 22);
            this.CB_Crit_P1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Crit_P1.StyleManager = null;
            this.CB_Crit_P1.Switched = false;
            this.CB_Crit_P1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Crit_P1.TabIndex = 219;
            this.CB_Crit_P1.ThemeAuthor = "Taiizor";
            this.CB_Crit_P1.ThemeName = "MetroLight";
            this.CB_Crit_P1.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // CB_Speed_P1
            // 
            this.CB_Speed_P1.BackColor = System.Drawing.Color.Transparent;
            this.CB_Speed_P1.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Speed_P1.BorderColor = System.Drawing.Color.White;
            this.CB_Speed_P1.CheckColor = System.Drawing.Color.Red;
            this.CB_Speed_P1.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Speed_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Speed_P1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Speed_P1.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Speed_P1.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Speed_P1.IsDerivedStyle = false;
            this.CB_Speed_P1.Location = new System.Drawing.Point(726, -384);
            this.CB_Speed_P1.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Speed_P1.Name = "CB_Speed_P1";
            this.CB_Speed_P1.Size = new System.Drawing.Size(58, 22);
            this.CB_Speed_P1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Speed_P1.StyleManager = null;
            this.CB_Speed_P1.Switched = false;
            this.CB_Speed_P1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Speed_P1.TabIndex = 217;
            this.CB_Speed_P1.ThemeAuthor = "Taiizor";
            this.CB_Speed_P1.ThemeName = "MetroLight";
            this.CB_Speed_P1.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // CB_Rapid_P1
            // 
            this.CB_Rapid_P1.BackColor = System.Drawing.Color.Transparent;
            this.CB_Rapid_P1.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Rapid_P1.BorderColor = System.Drawing.Color.White;
            this.CB_Rapid_P1.CheckColor = System.Drawing.Color.Red;
            this.CB_Rapid_P1.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Rapid_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Rapid_P1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Rapid_P1.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Rapid_P1.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Rapid_P1.IsDerivedStyle = false;
            this.CB_Rapid_P1.Location = new System.Drawing.Point(330, -304);
            this.CB_Rapid_P1.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Rapid_P1.Name = "CB_Rapid_P1";
            this.CB_Rapid_P1.Size = new System.Drawing.Size(58, 22);
            this.CB_Rapid_P1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Rapid_P1.StyleManager = null;
            this.CB_Rapid_P1.Switched = false;
            this.CB_Rapid_P1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Rapid_P1.TabIndex = 223;
            this.CB_Rapid_P1.ThemeAuthor = "Taiizor";
            this.CB_Rapid_P1.ThemeName = "MetroLight";
            this.CB_Rapid_P1.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // CB_Points_P1
            // 
            this.CB_Points_P1.BackColor = System.Drawing.Color.Transparent;
            this.CB_Points_P1.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Points_P1.BorderColor = System.Drawing.Color.White;
            this.CB_Points_P1.CheckColor = System.Drawing.Color.Red;
            this.CB_Points_P1.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Points_P1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Points_P1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Points_P1.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Points_P1.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Points_P1.IsDerivedStyle = false;
            this.CB_Points_P1.Location = new System.Drawing.Point(726, -424);
            this.CB_Points_P1.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Points_P1.Name = "CB_Points_P1";
            this.CB_Points_P1.Size = new System.Drawing.Size(58, 22);
            this.CB_Points_P1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Points_P1.StyleManager = null;
            this.CB_Points_P1.Switched = false;
            this.CB_Points_P1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Points_P1.TabIndex = 213;
            this.CB_Points_P1.ThemeAuthor = "Taiizor";
            this.CB_Points_P1.ThemeName = "MetroLight";
            this.CB_Points_P1.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // nightHeaderLabel59
            // 
            this.nightHeaderLabel59.AutoSize = true;
            this.nightHeaderLabel59.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel59.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel59.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel59.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel59.Location = new System.Drawing.Point(60, 491);
            this.nightHeaderLabel59.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel59.Name = "nightHeaderLabel59";
            this.nightHeaderLabel59.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel59.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel59.Size = new System.Drawing.Size(54, 24);
            this.nightHeaderLabel59.TabIndex = 293;
            this.nightHeaderLabel59.Text = "Noclip";
            this.nightHeaderLabel59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel59.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel59.UseCompatibleTextRendering = true;
            // 
            // bar_noclip
            // 
            this.bar_noclip.BackColor = System.Drawing.Color.Transparent;
            this.bar_noclip.Location = new System.Drawing.Point(128, 491);
            this.bar_noclip.Margin = new System.Windows.Forms.Padding(9);
            this.bar_noclip.Maximum = 75;
            this.bar_noclip.Minimum = 1;
            this.bar_noclip.MouseWheelBarPartitions = 5;
            this.bar_noclip.Name = "bar_noclip";
            this.bar_noclip.Size = new System.Drawing.Size(354, 23);
            this.bar_noclip.TabIndex = 292;
            this.bar_noclip.UseCustomBackColor = true;
            this.bar_noclip.Value = 1;
            this.bar_noclip.Scroll += new System.Windows.Forms.ScrollEventHandler(this.bar_noclip_Scroll);
            // 
            // guna2ToggleSwitch5
            // 
            this.guna2ToggleSwitch5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch5.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch5.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch5.CheckedState.Parent = this.guna2ToggleSwitch5;
            this.guna2ToggleSwitch5.Location = new System.Drawing.Point(24, 491);
            this.guna2ToggleSwitch5.Name = "guna2ToggleSwitch5";
            this.guna2ToggleSwitch5.ShadowDecoration.Parent = this.guna2ToggleSwitch5;
            this.guna2ToggleSwitch5.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch5.TabIndex = 291;
            this.guna2ToggleSwitch5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch5.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch5.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch5.UncheckedState.Parent = this.guna2ToggleSwitch5;
            this.guna2ToggleSwitch5.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch5_CheckedChanged_1);
            // 
            // nightHeaderLabel62
            // 
            this.nightHeaderLabel62.AutoSize = true;
            this.nightHeaderLabel62.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel62.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel62.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel62.Location = new System.Drawing.Point(368, 309);
            this.nightHeaderLabel62.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel62.Name = "nightHeaderLabel62";
            this.nightHeaderLabel62.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel62.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel62.Size = new System.Drawing.Size(76, 24);
            this.nightHeaderLabel62.TabIndex = 290;
            this.nightHeaderLabel62.Text = "XP Cycle";
            this.nightHeaderLabel62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel62.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel62.UseCompatibleTextRendering = true;
            // 
            // guna2ToggleSwitch2
            // 
            this.guna2ToggleSwitch2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch2.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.CheckedState.Parent = this.guna2ToggleSwitch2;
            this.guna2ToggleSwitch2.Location = new System.Drawing.Point(456, 309);
            this.guna2ToggleSwitch2.Name = "guna2ToggleSwitch2";
            this.guna2ToggleSwitch2.ShadowDecoration.Parent = this.guna2ToggleSwitch2;
            this.guna2ToggleSwitch2.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch2.TabIndex = 289;
            this.guna2ToggleSwitch2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch2.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.UncheckedState.Parent = this.guna2ToggleSwitch2;
            this.guna2ToggleSwitch2.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch2_CheckedChanged_1);
            // 
            // guna2ToggleSwitch4
            // 
            this.guna2ToggleSwitch4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch4.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch4.CheckedState.Parent = this.guna2ToggleSwitch4;
            this.guna2ToggleSwitch4.Location = new System.Drawing.Point(458, 53);
            this.guna2ToggleSwitch4.Name = "guna2ToggleSwitch4";
            this.guna2ToggleSwitch4.ShadowDecoration.Parent = this.guna2ToggleSwitch4;
            this.guna2ToggleSwitch4.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch4.TabIndex = 286;
            this.guna2ToggleSwitch4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch4.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch4.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch4.UncheckedState.Parent = this.guna2ToggleSwitch4;
            this.guna2ToggleSwitch4.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch4_CheckedChanged);
            // 
            // nightHeaderLabel76
            // 
            this.nightHeaderLabel76.AutoSize = true;
            this.nightHeaderLabel76.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel76.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel76.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel76.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel76.Location = new System.Drawing.Point(348, 53);
            this.nightHeaderLabel76.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel76.Name = "nightHeaderLabel76";
            this.nightHeaderLabel76.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel76.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel76.Size = new System.Drawing.Size(101, 24);
            this.nightHeaderLabel76.TabIndex = 285;
            this.nightHeaderLabel76.Text = "Send To Jail";
            this.nightHeaderLabel76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel76.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel76.UseCompatibleTextRendering = true;
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(18, 59);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.ShadowDecoration.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch1.TabIndex = 278;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // nightHeaderLabel60
            // 
            this.nightHeaderLabel60.AutoSize = true;
            this.nightHeaderLabel60.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel60.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel60.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel60.Location = new System.Drawing.Point(64, 59);
            this.nightHeaderLabel60.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel60.Name = "nightHeaderLabel60";
            this.nightHeaderLabel60.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel60.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel60.Size = new System.Drawing.Size(94, 24);
            this.nightHeaderLabel60.TabIndex = 269;
            this.nightHeaderLabel60.Text = "Round Skip";
            this.nightHeaderLabel60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel60.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel60.UseCompatibleTextRendering = true;
            // 
            // Btn_TP_Set
            // 
            this.Btn_TP_Set.BackColor = System.Drawing.Color.Transparent;
            this.Btn_TP_Set.BaseColor = System.Drawing.Color.Transparent;
            this.Btn_TP_Set.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_TP_Set.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TP_Set.ForeColor = System.Drawing.Color.Black;
            this.Btn_TP_Set.Location = new System.Drawing.Point(22, 390);
            this.Btn_TP_Set.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_TP_Set.Name = "Btn_TP_Set";
            this.Btn_TP_Set.Rounded = false;
            this.Btn_TP_Set.Size = new System.Drawing.Size(460, 47);
            this.Btn_TP_Set.TabIndex = 247;
            this.Btn_TP_Set.Text = "Set Location";
            this.Btn_TP_Set.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Btn_TP_Set.Click += new System.EventHandler(this.Btn_TP_Set_Click);
            // 
            // Btn_Dark
            // 
            this.Btn_Dark.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Dark.BaseColor = System.Drawing.Color.Transparent;
            this.Btn_Dark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Dark.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Dark.ForeColor = System.Drawing.Color.Black;
            this.Btn_Dark.Location = new System.Drawing.Point(21, 212);
            this.Btn_Dark.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Dark.Name = "Btn_Dark";
            this.Btn_Dark.Rounded = false;
            this.Btn_Dark.Size = new System.Drawing.Size(198, 25);
            this.Btn_Dark.TabIndex = 252;
            this.Btn_Dark.Text = " Instant Dark Aether";
            this.Btn_Dark.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Btn_Dark.Click += new System.EventHandler(this.Btn_Dark_Click);
            // 
            // guna2ToggleSwitch3
            // 
            this.guna2ToggleSwitch3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch3.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch3.CheckedState.Parent = this.guna2ToggleSwitch3;
            this.guna2ToggleSwitch3.Location = new System.Drawing.Point(22, 309);
            this.guna2ToggleSwitch3.Name = "guna2ToggleSwitch3";
            this.guna2ToggleSwitch3.ShadowDecoration.Parent = this.guna2ToggleSwitch3;
            this.guna2ToggleSwitch3.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch3.TabIndex = 280;
            this.guna2ToggleSwitch3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch3.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch3.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch3.UncheckedState.Parent = this.guna2ToggleSwitch3;
            this.guna2ToggleSwitch3.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch3_CheckedChanged);
            // 
            // Btn_Kill_multi
            // 
            this.Btn_Kill_multi.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Kill_multi.BaseColor = System.Drawing.Color.Transparent;
            this.Btn_Kill_multi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Kill_multi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Kill_multi.ForeColor = System.Drawing.Color.Black;
            this.Btn_Kill_multi.Location = new System.Drawing.Point(24, 258);
            this.Btn_Kill_multi.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Kill_multi.Name = "Btn_Kill_multi";
            this.Btn_Kill_multi.Rounded = false;
            this.Btn_Kill_multi.Size = new System.Drawing.Size(456, 33);
            this.Btn_Kill_multi.TabIndex = 253;
            this.Btn_Kill_multi.Text = "LVL 1000 ";
            this.Btn_Kill_multi.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Btn_Kill_multi.Click += new System.EventHandler(this.Btn_Kill_multi_Click);
            // 
            // nightHeaderLabel61
            // 
            this.nightHeaderLabel61.AutoSize = true;
            this.nightHeaderLabel61.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel61.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel61.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel61.Location = new System.Drawing.Point(64, 309);
            this.nightHeaderLabel61.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel61.Name = "nightHeaderLabel61";
            this.nightHeaderLabel61.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel61.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel61.Size = new System.Drawing.Size(92, 24);
            this.nightHeaderLabel61.TabIndex = 274;
            this.nightHeaderLabel61.Text = "1 Shot Kill  ";
            this.nightHeaderLabel61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel61.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel61.UseCompatibleTextRendering = true;
            this.nightHeaderLabel61.Click += new System.EventHandler(this.nightHeaderLabel61_Click);
            // 
            // LBL_Shots
            // 
            this.LBL_Shots.AutoSize = true;
            this.LBL_Shots.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Shots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Shots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.LBL_Shots.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.LBL_Shots.Location = new System.Drawing.Point(161, 91);
            this.LBL_Shots.Margin = new System.Windows.Forms.Padding(9);
            this.LBL_Shots.Name = "LBL_Shots";
            this.LBL_Shots.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.LBL_Shots.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.LBL_Shots.Size = new System.Drawing.Size(183, 24);
            this.LBL_Shots.TabIndex = 251;
            this.LBL_Shots.Text = "Weapon Cycle: 5 Shots";
            this.LBL_Shots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Shots.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.LBL_Shots.UseCompatibleTextRendering = true;
            // 
            // Btn_KillAll
            // 
            this.Btn_KillAll.BackColor = System.Drawing.Color.Transparent;
            this.Btn_KillAll.BaseColor = System.Drawing.Color.Transparent;
            this.Btn_KillAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_KillAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_KillAll.ForeColor = System.Drawing.Color.Black;
            this.Btn_KillAll.Location = new System.Drawing.Point(24, 22);
            this.Btn_KillAll.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_KillAll.Name = "Btn_KillAll";
            this.Btn_KillAll.Rounded = false;
            this.Btn_KillAll.Size = new System.Drawing.Size(456, 19);
            this.Btn_KillAll.TabIndex = 172;
            this.Btn_KillAll.Text = "END MATCH";
            this.Btn_KillAll.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Btn_KillAll.Click += new System.EventHandler(this.Btn_KillAll_Click);
            // 
            // guna2ToggleSwitch7
            // 
            this.guna2ToggleSwitch7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch7.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch7.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch7.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch7.CheckedState.Parent = this.guna2ToggleSwitch7;
            this.guna2ToggleSwitch7.Location = new System.Drawing.Point(165, 348);
            this.guna2ToggleSwitch7.Name = "guna2ToggleSwitch7";
            this.guna2ToggleSwitch7.ShadowDecoration.Parent = this.guna2ToggleSwitch7;
            this.guna2ToggleSwitch7.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch7.TabIndex = 284;
            this.guna2ToggleSwitch7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch7.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch7.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch7.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch7.UncheckedState.Parent = this.guna2ToggleSwitch7;
            this.guna2ToggleSwitch7.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch7_CheckedChanged);
            // 
            // LBL_Kills
            // 
            this.LBL_Kills.AutoSize = true;
            this.LBL_Kills.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Kills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Kills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.LBL_Kills.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.LBL_Kills.Location = new System.Drawing.Point(172, 153);
            this.LBL_Kills.Margin = new System.Windows.Forms.Padding(9);
            this.LBL_Kills.Name = "LBL_Kills";
            this.LBL_Kills.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.LBL_Kills.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.LBL_Kills.Size = new System.Drawing.Size(172, 24);
            this.LBL_Kills.TabIndex = 249;
            this.LBL_Kills.Text = "Weapon Cycle: 5 Kills";
            this.LBL_Kills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Kills.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.LBL_Kills.UseCompatibleTextRendering = true;
            // 
            // Btn_QuickDA
            // 
            this.Btn_QuickDA.BackColor = System.Drawing.Color.Transparent;
            this.Btn_QuickDA.BaseColor = System.Drawing.Color.Transparent;
            this.Btn_QuickDA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_QuickDA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_QuickDA.ForeColor = System.Drawing.Color.Black;
            this.Btn_QuickDA.Location = new System.Drawing.Point(285, 212);
            this.Btn_QuickDA.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_QuickDA.Name = "Btn_QuickDA";
            this.Btn_QuickDA.Rounded = false;
            this.Btn_QuickDA.Size = new System.Drawing.Size(195, 25);
            this.Btn_QuickDA.TabIndex = 255;
            this.Btn_QuickDA.Text = "TURN ON  EVERYTHING";
            this.Btn_QuickDA.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Btn_QuickDA.Click += new System.EventHandler(this.Btn_QuickDA_Click);
            // 
            // nightHeaderLabel57
            // 
            this.nightHeaderLabel57.AutoSize = true;
            this.nightHeaderLabel57.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel57.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel57.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel57.Location = new System.Drawing.Point(201, 348);
            this.nightHeaderLabel57.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel57.Name = "nightHeaderLabel57";
            this.nightHeaderLabel57.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel57.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel57.Size = new System.Drawing.Size(139, 24);
            this.nightHeaderLabel57.TabIndex = 245;
            this.nightHeaderLabel57.Text = "Teleport Zombies";
            this.nightHeaderLabel57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel57.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel57.UseCompatibleTextRendering = true;
            // 
            // Bar_Shots
            // 
            this.Bar_Shots.BackColor = System.Drawing.Color.Transparent;
            this.Bar_Shots.LargeChange = 50;
            this.Bar_Shots.Location = new System.Drawing.Point(21, 121);
            this.Bar_Shots.Margin = new System.Windows.Forms.Padding(9);
            this.Bar_Shots.Maximum = 5000;
            this.Bar_Shots.Minimum = 1;
            this.Bar_Shots.MouseWheelBarPartitions = 5;
            this.Bar_Shots.Name = "Bar_Shots";
            this.Bar_Shots.Size = new System.Drawing.Size(459, 23);
            this.Bar_Shots.TabIndex = 250;
            this.Bar_Shots.UseCustomBackColor = true;
            this.Bar_Shots.Value = 5;
            this.Bar_Shots.ValueChanged += new System.EventHandler(this.Bar_Shots_ValueChanged);
            this.Bar_Shots.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar_Shots_Scroll);
            // 
            // Bar_Kills
            // 
            this.Bar_Kills.BackColor = System.Drawing.Color.Transparent;
            this.Bar_Kills.LargeChange = 50;
            this.Bar_Kills.Location = new System.Drawing.Point(22, 175);
            this.Bar_Kills.Margin = new System.Windows.Forms.Padding(9);
            this.Bar_Kills.Maximum = 50;
            this.Bar_Kills.Minimum = 1;
            this.Bar_Kills.MouseWheelBarPartitions = 5;
            this.Bar_Kills.Name = "Bar_Kills";
            this.Bar_Kills.Size = new System.Drawing.Size(458, 23);
            this.Bar_Kills.TabIndex = 248;
            this.Bar_Kills.UseCustomBackColor = true;
            this.Bar_Kills.Value = 5;
            this.Bar_Kills.ValueChanged += new System.EventHandler(this.Bar_Kills_ValueChanged);
            this.Bar_Kills.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar_Kills_Scroll);
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClassesTabPage.Controls.Add(this.guna2Button1);
            this.ClassesTabPage.Controls.Add(this.LOADER);
            this.ClassesTabPage.Controls.Add(this.Btn_Gib2_P2);
            this.ClassesTabPage.Controls.Add(this.Btn_TP_P2);
            this.ClassesTabPage.Controls.Add(this.Box_Weapons_P2);
            this.ClassesTabPage.Controls.Add(this.Box_TP_P2);
            this.ClassesTabPage.Controls.Add(this.Box_CycleEnd_P2);
            this.ClassesTabPage.Controls.Add(this.Box_CycleStart_P2);
            this.ClassesTabPage.Controls.Add(this.Btn_TP_Bots);
            this.ClassesTabPage.Controls.Add(this.Btn_Gib_P2);
            this.ClassesTabPage.Controls.Add(this.nightHeaderLabel34);
            this.ClassesTabPage.Controls.Add(this.Dtn_Diamond);
            this.ClassesTabPage.Controls.Add(this.nightHeaderLabel31);
            this.ClassesTabPage.Controls.Add(this.nightHeaderLabel35);
            this.ClassesTabPage.Controls.Add(this.nightHeaderLabel78);
            this.ClassesTabPage.Controls.Add(this.guna2Panel29);
            this.ClassesTabPage.Controls.Add(this.nightHeaderLabel33);
            this.ClassesTabPage.Controls.Add(this.nightHeaderLabel58);
            this.ClassesTabPage.Controls.Add(this.nightHeaderLabel32);
            this.ClassesTabPage.Controls.Add(this.CB_zqinissofuckingsexy_P2);
            this.ClassesTabPage.Controls.Add(this.guna2ToggleSwitch6);
            this.ClassesTabPage.Controls.Add(this.guna2Panel30);
            this.ClassesTabPage.Controls.Add(this.CB_Shoot_P2);
            this.ClassesTabPage.Controls.Add(this.guna2Panel31);
            this.ClassesTabPage.Controls.Add(this.CB_Rainbow_P2);
            this.ClassesTabPage.Controls.Add(this.guna2Panel32);
            this.ClassesTabPage.Controls.Add(this.CB_God_P2);
            this.ClassesTabPage.Controls.Add(this.CB_Ammo_P2);
            this.ClassesTabPage.Controls.Add(this.CB_Crit_P2);
            this.ClassesTabPage.Controls.Add(this.nightHeaderLabel49);
            this.ClassesTabPage.Controls.Add(this.CB_Rapid_P2);
            this.ClassesTabPage.Controls.Add(this.nightHeaderLabel51);
            this.ClassesTabPage.Controls.Add(this.CB_Cycle_P2);
            this.ClassesTabPage.Controls.Add(this.nightHeaderLabel53);
            this.ClassesTabPage.Controls.Add(this.nightHeaderLabel36);
            this.ClassesTabPage.Controls.Add(this.nightHeaderLabel55);
            this.ClassesTabPage.Controls.Add(this.CB_Points_P2);
            this.ClassesTabPage.Controls.Add(this.CB_Speed_P2);
            this.ClassesTabPage.Controls.Add(this.nightHeaderLabel50);
            this.ClassesTabPage.Controls.Add(this.CB_Jail_P2);
            this.ClassesTabPage.Controls.Add(this.CB_Croshair_P2);
            this.ClassesTabPage.Controls.Add(this.nightHeaderLabel52);
            this.ClassesTabPage.Controls.Add(this.nightHeaderLabel56);
            this.ClassesTabPage.Controls.Add(this.nightHeaderLabel54);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 44);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(507, 532);
            this.ClassesTabPage.TabIndex = 0;
            this.ClassesTabPage.Text = "MP";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(13, 468);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(477, 36);
            this.guna2Button1.TabIndex = 294;
            this.guna2Button1.Text = "Apply";
            // 
            // LOADER
            // 
            this.LOADER.BackColor = System.Drawing.Color.Transparent;
            this.LOADER.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.LOADER.BorderThickness = 2;
            this.LOADER.DisabledState.Parent = this.LOADER;
            this.LOADER.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LOADER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LOADER.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.LOADER.FocusedColor = System.Drawing.Color.Transparent;
            this.LOADER.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.LOADER.FocusedState.Parent = this.LOADER;
            this.LOADER.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOADER.ForeColor = System.Drawing.Color.White;
            this.LOADER.HoverState.Parent = this.LOADER;
            this.LOADER.ItemHeight = 30;
            this.LOADER.Items.AddRange(new object[] {
            "AIMBOT",
            "RAPID FIRE ",
            "ANTI RECOIL ",
            "TRIGGER BOT ",
            "360 SPIN BOT",
            ""});
            this.LOADER.ItemsAppearance.Parent = this.LOADER;
            this.LOADER.Location = new System.Drawing.Point(13, 416);
            this.LOADER.Name = "LOADER";
            this.LOADER.ShadowDecoration.Parent = this.LOADER;
            this.LOADER.Size = new System.Drawing.Size(477, 36);
            this.LOADER.TabIndex = 293;
            // 
            // Btn_Gib2_P2
            // 
            this.Btn_Gib2_P2.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Gib2_P2.BaseColor = System.Drawing.Color.Transparent;
            this.Btn_Gib2_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Gib2_P2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Gib2_P2.Location = new System.Drawing.Point(742, 377);
            this.Btn_Gib2_P2.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Gib2_P2.Name = "Btn_Gib2_P2";
            this.Btn_Gib2_P2.Rounded = false;
            this.Btn_Gib2_P2.Size = new System.Drawing.Size(227, 25);
            this.Btn_Gib2_P2.TabIndex = 264;
            this.Btn_Gib2_P2.Text = "Give Weapon 2 ↓";
            this.Btn_Gib2_P2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Btn_Gib2_P2.Click += new System.EventHandler(this.Btn_Gib2_P2_Click);
            // 
            // Btn_TP_P2
            // 
            this.Btn_TP_P2.BackColor = System.Drawing.Color.Transparent;
            this.Btn_TP_P2.BaseColor = System.Drawing.Color.Transparent;
            this.Btn_TP_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_TP_P2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TP_P2.Location = new System.Drawing.Point(504, 310);
            this.Btn_TP_P2.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_TP_P2.Name = "Btn_TP_P2";
            this.Btn_TP_P2.Rounded = false;
            this.Btn_TP_P2.Size = new System.Drawing.Size(465, 25);
            this.Btn_TP_P2.TabIndex = 265;
            this.Btn_TP_P2.Text = "Teleport To Location ↓";
            this.Btn_TP_P2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Btn_TP_P2.Click += new System.EventHandler(this.Btn_TP_P2_Click);
            // 
            // Box_Weapons_P2
            // 
            this.Box_Weapons_P2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.Box_Weapons_P2.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Box_Weapons_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_Weapons_P2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Box_Weapons_P2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Weapons_P2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Weapons_P2.ForeColor = System.Drawing.Color.White;
            this.Box_Weapons_P2.FormattingEnabled = true;
            this.Box_Weapons_P2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(49)))), ((int)(((byte)(222)))));
            this.Box_Weapons_P2.HoverFontColor = System.Drawing.Color.White;
            this.Box_Weapons_P2.ItemHeight = 20;
            this.Box_Weapons_P2.Location = new System.Drawing.Point(508, 409);
            this.Box_Weapons_P2.Margin = new System.Windows.Forms.Padding(9);
            this.Box_Weapons_P2.Name = "Box_Weapons_P2";
            this.Box_Weapons_P2.Size = new System.Drawing.Size(461, 26);
            this.Box_Weapons_P2.TabIndex = 261;
            // 
            // Box_TP_P2
            // 
            this.Box_TP_P2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.Box_TP_P2.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Box_TP_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_TP_P2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Box_TP_P2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_TP_P2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_TP_P2.ForeColor = System.Drawing.Color.White;
            this.Box_TP_P2.FormattingEnabled = true;
            this.Box_TP_P2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(49)))), ((int)(((byte)(222)))));
            this.Box_TP_P2.HoverFontColor = System.Drawing.Color.White;
            this.Box_TP_P2.ItemHeight = 20;
            this.Box_TP_P2.Items.AddRange(new object[] {
            "Spawn",
            "Nacht",
            "Pond",
            "Power"});
            this.Box_TP_P2.Location = new System.Drawing.Point(504, 342);
            this.Box_TP_P2.Margin = new System.Windows.Forms.Padding(9);
            this.Box_TP_P2.Name = "Box_TP_P2";
            this.Box_TP_P2.Size = new System.Drawing.Size(465, 26);
            this.Box_TP_P2.TabIndex = 262;
            // 
            // Box_CycleEnd_P2
            // 
            this.Box_CycleEnd_P2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.Box_CycleEnd_P2.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Box_CycleEnd_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_CycleEnd_P2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Box_CycleEnd_P2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_CycleEnd_P2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_CycleEnd_P2.ForeColor = System.Drawing.Color.White;
            this.Box_CycleEnd_P2.FormattingEnabled = true;
            this.Box_CycleEnd_P2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(49)))), ((int)(((byte)(222)))));
            this.Box_CycleEnd_P2.HoverFontColor = System.Drawing.Color.White;
            this.Box_CycleEnd_P2.ItemHeight = 20;
            this.Box_CycleEnd_P2.Location = new System.Drawing.Point(756, 275);
            this.Box_CycleEnd_P2.Margin = new System.Windows.Forms.Padding(9);
            this.Box_CycleEnd_P2.Name = "Box_CycleEnd_P2";
            this.Box_CycleEnd_P2.Size = new System.Drawing.Size(213, 26);
            this.Box_CycleEnd_P2.TabIndex = 267;
            // 
            // Box_CycleStart_P2
            // 
            this.Box_CycleStart_P2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.Box_CycleStart_P2.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Box_CycleStart_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_CycleStart_P2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Box_CycleStart_P2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_CycleStart_P2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_CycleStart_P2.ForeColor = System.Drawing.Color.White;
            this.Box_CycleStart_P2.FormattingEnabled = true;
            this.Box_CycleStart_P2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(49)))), ((int)(((byte)(222)))));
            this.Box_CycleStart_P2.HoverFontColor = System.Drawing.Color.White;
            this.Box_CycleStart_P2.ItemHeight = 20;
            this.Box_CycleStart_P2.Location = new System.Drawing.Point(508, 275);
            this.Box_CycleStart_P2.Margin = new System.Windows.Forms.Padding(9);
            this.Box_CycleStart_P2.Name = "Box_CycleStart_P2";
            this.Box_CycleStart_P2.Size = new System.Drawing.Size(214, 26);
            this.Box_CycleStart_P2.TabIndex = 266;
            // 
            // Btn_TP_Bots
            // 
            this.Btn_TP_Bots.BackColor = System.Drawing.Color.Transparent;
            this.Btn_TP_Bots.BaseColor = System.Drawing.Color.Transparent;
            this.Btn_TP_Bots.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_TP_Bots.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TP_Bots.ForeColor = System.Drawing.Color.Black;
            this.Btn_TP_Bots.Location = new System.Drawing.Point(213, 117);
            this.Btn_TP_Bots.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_TP_Bots.Name = "Btn_TP_Bots";
            this.Btn_TP_Bots.Rounded = false;
            this.Btn_TP_Bots.Size = new System.Drawing.Size(260, 25);
            this.Btn_TP_Bots.TabIndex = 258;
            this.Btn_TP_Bots.Text = "Set Location";
            this.Btn_TP_Bots.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Btn_TP_Bots.Click += new System.EventHandler(this.Btn_TP_Bots_Click);
            // 
            // Btn_Gib_P2
            // 
            this.Btn_Gib_P2.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Gib_P2.BaseColor = System.Drawing.Color.Transparent;
            this.Btn_Gib_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Gib_P2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Gib_P2.Location = new System.Drawing.Point(504, 377);
            this.Btn_Gib_P2.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Gib_P2.Name = "Btn_Gib_P2";
            this.Btn_Gib_P2.Rounded = false;
            this.Btn_Gib_P2.Size = new System.Drawing.Size(224, 25);
            this.Btn_Gib_P2.TabIndex = 263;
            this.Btn_Gib_P2.Text = "Give Weapon 1 ↓";
            this.Btn_Gib_P2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Btn_Gib_P2.Click += new System.EventHandler(this.Btn_Gib_P2_Click);
            // 
            // nightHeaderLabel34
            // 
            this.nightHeaderLabel34.AutoSize = true;
            this.nightHeaderLabel34.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel34.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel34.Location = new System.Drawing.Point(886, 244);
            this.nightHeaderLabel34.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel34.Name = "nightHeaderLabel34";
            this.nightHeaderLabel34.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel34.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel34.Size = new System.Drawing.Size(83, 24);
            this.nightHeaderLabel34.TabIndex = 269;
            this.nightHeaderLabel34.Text = "Cycle End";
            this.nightHeaderLabel34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel34.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel34.UseCompatibleTextRendering = true;
            // 
            // Dtn_Diamond
            // 
            this.Dtn_Diamond.BackColor = System.Drawing.Color.Transparent;
            this.Dtn_Diamond.BaseColor = System.Drawing.Color.Transparent;
            this.Dtn_Diamond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dtn_Diamond.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtn_Diamond.ForeColor = System.Drawing.Color.Black;
            this.Dtn_Diamond.Location = new System.Drawing.Point(19, 21);
            this.Dtn_Diamond.Margin = new System.Windows.Forms.Padding(9);
            this.Dtn_Diamond.Name = "Dtn_Diamond";
            this.Dtn_Diamond.Rounded = false;
            this.Dtn_Diamond.Size = new System.Drawing.Size(465, 65);
            this.Dtn_Diamond.TabIndex = 254;
            this.Dtn_Diamond.Text = "MP Instant Diamond";
            this.Dtn_Diamond.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Dtn_Diamond.Click += new System.EventHandler(this.Dtn_Diamond_Click);
            // 
            // nightHeaderLabel31
            // 
            this.nightHeaderLabel31.AutoSize = true;
            this.nightHeaderLabel31.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel31.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel31.Location = new System.Drawing.Point(856, 206);
            this.nightHeaderLabel31.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel31.Name = "nightHeaderLabel31";
            this.nightHeaderLabel31.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel31.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel31.Size = new System.Drawing.Size(40, 24);
            this.nightHeaderLabel31.TabIndex = 275;
            this.nightHeaderLabel31.Text = "TBD";
            this.nightHeaderLabel31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel31.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel31.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel35
            // 
            this.nightHeaderLabel35.AutoSize = true;
            this.nightHeaderLabel35.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel35.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel35.Location = new System.Drawing.Point(504, 244);
            this.nightHeaderLabel35.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel35.Name = "nightHeaderLabel35";
            this.nightHeaderLabel35.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel35.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel35.Size = new System.Drawing.Size(90, 24);
            this.nightHeaderLabel35.TabIndex = 268;
            this.nightHeaderLabel35.Text = "Cycle Start";
            this.nightHeaderLabel35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel35.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel35.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel78
            // 
            this.nightHeaderLabel78.AutoSize = true;
            this.nightHeaderLabel78.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel78.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel78.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel78.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel78.Location = new System.Drawing.Point(34, 371);
            this.nightHeaderLabel78.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel78.Name = "nightHeaderLabel78";
            this.nightHeaderLabel78.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel78.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel78.Size = new System.Drawing.Size(423, 20);
            this.nightHeaderLabel78.TabIndex = 288;
            this.nightHeaderLabel78.Text = "AIMBOT - RAPID FIRE - ANTI RECOIL - TRIGGER BOT - 360 SPIN";
            this.nightHeaderLabel78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel78.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel78.UseCompatibleTextRendering = true;
            // 
            // guna2Panel29
            // 
            this.guna2Panel29.BackColor = System.Drawing.Color.Red;
            this.guna2Panel29.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel29.BorderThickness = 2;
            this.guna2Panel29.Location = new System.Drawing.Point(497, -2);
            this.guna2Panel29.Name = "guna2Panel29";
            this.guna2Panel29.ShadowDecoration.Parent = this.guna2Panel29;
            this.guna2Panel29.Size = new System.Drawing.Size(10, 528);
            this.guna2Panel29.TabIndex = 226;
            // 
            // nightHeaderLabel33
            // 
            this.nightHeaderLabel33.AutoSize = true;
            this.nightHeaderLabel33.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel33.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel33.Location = new System.Drawing.Point(787, 171);
            this.nightHeaderLabel33.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel33.Name = "nightHeaderLabel33";
            this.nightHeaderLabel33.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel33.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel33.Size = new System.Drawing.Size(109, 24);
            this.nightHeaderLabel33.TabIndex = 271;
            this.nightHeaderLabel33.Text = "Rainbow Gun";
            this.nightHeaderLabel33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel33.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel33.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel58
            // 
            this.nightHeaderLabel58.AutoSize = true;
            this.nightHeaderLabel58.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel58.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel58.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel58.Location = new System.Drawing.Point(87, 118);
            this.nightHeaderLabel58.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel58.Name = "nightHeaderLabel58";
            this.nightHeaderLabel58.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel58.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel58.Size = new System.Drawing.Size(108, 24);
            this.nightHeaderLabel58.TabIndex = 256;
            this.nightHeaderLabel58.Text = "Teleport Bots";
            this.nightHeaderLabel58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel58.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel58.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel32
            // 
            this.nightHeaderLabel32.AutoSize = true;
            this.nightHeaderLabel32.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel32.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel32.Location = new System.Drawing.Point(570, 211);
            this.nightHeaderLabel32.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel32.Name = "nightHeaderLabel32";
            this.nightHeaderLabel32.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel32.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel32.Size = new System.Drawing.Size(90, 24);
            this.nightHeaderLabel32.TabIndex = 272;
            this.nightHeaderLabel32.Text = "Auto Shoot";
            this.nightHeaderLabel32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel32.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel32.UseCompatibleTextRendering = true;
            // 
            // CB_zqinissofuckingsexy_P2
            // 
            this.CB_zqinissofuckingsexy_P2.BackColor = System.Drawing.Color.Transparent;
            this.CB_zqinissofuckingsexy_P2.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_zqinissofuckingsexy_P2.BorderColor = System.Drawing.Color.White;
            this.CB_zqinissofuckingsexy_P2.CheckColor = System.Drawing.Color.Red;
            this.CB_zqinissofuckingsexy_P2.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_zqinissofuckingsexy_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_zqinissofuckingsexy_P2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_zqinissofuckingsexy_P2.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_zqinissofuckingsexy_P2.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_zqinissofuckingsexy_P2.IsDerivedStyle = false;
            this.CB_zqinissofuckingsexy_P2.Location = new System.Drawing.Point(911, 211);
            this.CB_zqinissofuckingsexy_P2.Margin = new System.Windows.Forms.Padding(9);
            this.CB_zqinissofuckingsexy_P2.Name = "CB_zqinissofuckingsexy_P2";
            this.CB_zqinissofuckingsexy_P2.Size = new System.Drawing.Size(58, 22);
            this.CB_zqinissofuckingsexy_P2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_zqinissofuckingsexy_P2.StyleManager = null;
            this.CB_zqinissofuckingsexy_P2.Switched = false;
            this.CB_zqinissofuckingsexy_P2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_zqinissofuckingsexy_P2.TabIndex = 274;
            this.CB_zqinissofuckingsexy_P2.Text = "metroSwitch7";
            this.CB_zqinissofuckingsexy_P2.ThemeAuthor = "Taiizor";
            this.CB_zqinissofuckingsexy_P2.ThemeName = "MetroLight";
            this.CB_zqinissofuckingsexy_P2.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // guna2ToggleSwitch6
            // 
            this.guna2ToggleSwitch6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch6.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch6.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch6.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch6.CheckedState.Parent = this.guna2ToggleSwitch6;
            this.guna2ToggleSwitch6.Location = new System.Drawing.Point(45, 118);
            this.guna2ToggleSwitch6.Name = "guna2ToggleSwitch6";
            this.guna2ToggleSwitch6.ShadowDecoration.Parent = this.guna2ToggleSwitch6;
            this.guna2ToggleSwitch6.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch6.TabIndex = 283;
            this.guna2ToggleSwitch6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch6.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch6.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch6.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch6.UncheckedState.Parent = this.guna2ToggleSwitch6;
            this.guna2ToggleSwitch6.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch6_CheckedChanged);
            // 
            // guna2Panel30
            // 
            this.guna2Panel30.BackColor = System.Drawing.Color.Red;
            this.guna2Panel30.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel30.BorderThickness = 2;
            this.guna2Panel30.Location = new System.Drawing.Point(-3, 521);
            this.guna2Panel30.Name = "guna2Panel30";
            this.guna2Panel30.ShadowDecoration.Parent = this.guna2Panel30;
            this.guna2Panel30.Size = new System.Drawing.Size(760, 10);
            this.guna2Panel30.TabIndex = 225;
            // 
            // CB_Shoot_P2
            // 
            this.CB_Shoot_P2.BackColor = System.Drawing.Color.Transparent;
            this.CB_Shoot_P2.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Shoot_P2.BorderColor = System.Drawing.Color.White;
            this.CB_Shoot_P2.CheckColor = System.Drawing.Color.Red;
            this.CB_Shoot_P2.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Shoot_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Shoot_P2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Shoot_P2.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Shoot_P2.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Shoot_P2.IsDerivedStyle = false;
            this.CB_Shoot_P2.Location = new System.Drawing.Point(504, 211);
            this.CB_Shoot_P2.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Shoot_P2.Name = "CB_Shoot_P2";
            this.CB_Shoot_P2.Size = new System.Drawing.Size(58, 22);
            this.CB_Shoot_P2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Shoot_P2.StyleManager = null;
            this.CB_Shoot_P2.Switched = false;
            this.CB_Shoot_P2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Shoot_P2.TabIndex = 273;
            this.CB_Shoot_P2.Text = "metroSwitch10";
            this.CB_Shoot_P2.ThemeAuthor = "Taiizor";
            this.CB_Shoot_P2.ThemeName = "MetroLight";
            this.CB_Shoot_P2.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // guna2Panel31
            // 
            this.guna2Panel31.BackColor = System.Drawing.Color.Red;
            this.guna2Panel31.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel31.BorderThickness = 2;
            this.guna2Panel31.Location = new System.Drawing.Point(-10, -1);
            this.guna2Panel31.Name = "guna2Panel31";
            this.guna2Panel31.ShadowDecoration.Parent = this.guna2Panel31;
            this.guna2Panel31.Size = new System.Drawing.Size(760, 10);
            this.guna2Panel31.TabIndex = 224;
            // 
            // CB_Rainbow_P2
            // 
            this.CB_Rainbow_P2.BackColor = System.Drawing.Color.Transparent;
            this.CB_Rainbow_P2.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Rainbow_P2.BorderColor = System.Drawing.Color.White;
            this.CB_Rainbow_P2.CheckColor = System.Drawing.Color.Red;
            this.CB_Rainbow_P2.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Rainbow_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Rainbow_P2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Rainbow_P2.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Rainbow_P2.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Rainbow_P2.IsDerivedStyle = false;
            this.CB_Rainbow_P2.Location = new System.Drawing.Point(911, 171);
            this.CB_Rainbow_P2.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Rainbow_P2.Name = "CB_Rainbow_P2";
            this.CB_Rainbow_P2.Size = new System.Drawing.Size(58, 22);
            this.CB_Rainbow_P2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Rainbow_P2.StyleManager = null;
            this.CB_Rainbow_P2.Switched = false;
            this.CB_Rainbow_P2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Rainbow_P2.TabIndex = 270;
            this.CB_Rainbow_P2.Text = "metroSwitch7";
            this.CB_Rainbow_P2.ThemeAuthor = "Taiizor";
            this.CB_Rainbow_P2.ThemeName = "MetroLight";
            this.CB_Rainbow_P2.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // guna2Panel32
            // 
            this.guna2Panel32.BackColor = System.Drawing.Color.Red;
            this.guna2Panel32.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel32.BorderThickness = 2;
            this.guna2Panel32.Controls.Add(this.guna2Panel33);
            this.guna2Panel32.Location = new System.Drawing.Point(-4, 0);
            this.guna2Panel32.Name = "guna2Panel32";
            this.guna2Panel32.ShadowDecoration.Parent = this.guna2Panel32;
            this.guna2Panel32.Size = new System.Drawing.Size(11, 528);
            this.guna2Panel32.TabIndex = 223;
            // 
            // guna2Panel33
            // 
            this.guna2Panel33.BackColor = System.Drawing.Color.Red;
            this.guna2Panel33.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel33.BorderThickness = 2;
            this.guna2Panel33.Location = new System.Drawing.Point(-3, 0);
            this.guna2Panel33.Name = "guna2Panel33";
            this.guna2Panel33.ShadowDecoration.Parent = this.guna2Panel33;
            this.guna2Panel33.Size = new System.Drawing.Size(10, 284);
            this.guna2Panel33.TabIndex = 213;
            // 
            // CB_God_P2
            // 
            this.CB_God_P2.BackColor = System.Drawing.Color.Transparent;
            this.CB_God_P2.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_God_P2.BorderColor = System.Drawing.Color.White;
            this.CB_God_P2.CheckColor = System.Drawing.Color.Red;
            this.CB_God_P2.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_God_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_God_P2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_God_P2.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_God_P2.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_God_P2.IsDerivedStyle = false;
            this.CB_God_P2.Location = new System.Drawing.Point(504, 11);
            this.CB_God_P2.Margin = new System.Windows.Forms.Padding(9);
            this.CB_God_P2.Name = "CB_God_P2";
            this.CB_God_P2.Size = new System.Drawing.Size(58, 22);
            this.CB_God_P2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_God_P2.StyleManager = null;
            this.CB_God_P2.Switched = false;
            this.CB_God_P2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_God_P2.TabIndex = 244;
            this.CB_God_P2.Text = "metroSwitch1";
            this.CB_God_P2.ThemeAuthor = "Taiizor";
            this.CB_God_P2.ThemeName = "MetroLight";
            this.CB_God_P2.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // CB_Ammo_P2
            // 
            this.CB_Ammo_P2.BackColor = System.Drawing.Color.Transparent;
            this.CB_Ammo_P2.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Ammo_P2.BorderColor = System.Drawing.Color.White;
            this.CB_Ammo_P2.CheckColor = System.Drawing.Color.Red;
            this.CB_Ammo_P2.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Ammo_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Ammo_P2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Ammo_P2.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Ammo_P2.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Ammo_P2.IsDerivedStyle = false;
            this.CB_Ammo_P2.Location = new System.Drawing.Point(504, 51);
            this.CB_Ammo_P2.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Ammo_P2.Name = "CB_Ammo_P2";
            this.CB_Ammo_P2.Size = new System.Drawing.Size(58, 22);
            this.CB_Ammo_P2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Ammo_P2.StyleManager = null;
            this.CB_Ammo_P2.Switched = false;
            this.CB_Ammo_P2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Ammo_P2.TabIndex = 248;
            this.CB_Ammo_P2.Text = "metroSwitch4";
            this.CB_Ammo_P2.ThemeAuthor = "Taiizor";
            this.CB_Ammo_P2.ThemeName = "MetroLight";
            this.CB_Ammo_P2.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // CB_Crit_P2
            // 
            this.CB_Crit_P2.BackColor = System.Drawing.Color.Transparent;
            this.CB_Crit_P2.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Crit_P2.BorderColor = System.Drawing.Color.White;
            this.CB_Crit_P2.CheckColor = System.Drawing.Color.Red;
            this.CB_Crit_P2.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Crit_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Crit_P2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Crit_P2.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Crit_P2.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Crit_P2.IsDerivedStyle = false;
            this.CB_Crit_P2.Location = new System.Drawing.Point(504, 91);
            this.CB_Crit_P2.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Crit_P2.Name = "CB_Crit_P2";
            this.CB_Crit_P2.Size = new System.Drawing.Size(58, 22);
            this.CB_Crit_P2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Crit_P2.StyleManager = null;
            this.CB_Crit_P2.Switched = false;
            this.CB_Crit_P2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Crit_P2.TabIndex = 252;
            this.CB_Crit_P2.Text = "metroSwitch6";
            this.CB_Crit_P2.ThemeAuthor = "Taiizor";
            this.CB_Crit_P2.ThemeName = "MetroLight";
            this.CB_Crit_P2.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // nightHeaderLabel49
            // 
            this.nightHeaderLabel49.AutoSize = true;
            this.nightHeaderLabel49.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel49.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel49.Location = new System.Drawing.Point(763, 131);
            this.nightHeaderLabel49.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel49.Name = "nightHeaderLabel49";
            this.nightHeaderLabel49.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel49.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel49.Size = new System.Drawing.Size(133, 24);
            this.nightHeaderLabel49.TabIndex = 257;
            this.nightHeaderLabel49.Text = "ZM To Crosshair";
            this.nightHeaderLabel49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel49.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel49.UseCompatibleTextRendering = true;
            // 
            // CB_Rapid_P2
            // 
            this.CB_Rapid_P2.BackColor = System.Drawing.Color.Transparent;
            this.CB_Rapid_P2.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Rapid_P2.BorderColor = System.Drawing.Color.White;
            this.CB_Rapid_P2.CheckColor = System.Drawing.Color.Red;
            this.CB_Rapid_P2.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Rapid_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Rapid_P2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Rapid_P2.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Rapid_P2.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Rapid_P2.IsDerivedStyle = false;
            this.CB_Rapid_P2.Location = new System.Drawing.Point(504, 131);
            this.CB_Rapid_P2.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Rapid_P2.Name = "CB_Rapid_P2";
            this.CB_Rapid_P2.Size = new System.Drawing.Size(58, 22);
            this.CB_Rapid_P2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Rapid_P2.StyleManager = null;
            this.CB_Rapid_P2.Switched = false;
            this.CB_Rapid_P2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Rapid_P2.TabIndex = 256;
            this.CB_Rapid_P2.Text = "metroSwitch8";
            this.CB_Rapid_P2.ThemeAuthor = "Taiizor";
            this.CB_Rapid_P2.ThemeName = "MetroLight";
            this.CB_Rapid_P2.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // nightHeaderLabel51
            // 
            this.nightHeaderLabel51.AutoSize = true;
            this.nightHeaderLabel51.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel51.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel51.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel51.Location = new System.Drawing.Point(795, 89);
            this.nightHeaderLabel51.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel51.Name = "nightHeaderLabel51";
            this.nightHeaderLabel51.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel51.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel51.Size = new System.Drawing.Size(101, 24);
            this.nightHeaderLabel51.TabIndex = 253;
            this.nightHeaderLabel51.Text = "Send To Jail";
            this.nightHeaderLabel51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel51.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel51.UseCompatibleTextRendering = true;
            // 
            // CB_Cycle_P2
            // 
            this.CB_Cycle_P2.BackColor = System.Drawing.Color.Transparent;
            this.CB_Cycle_P2.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Cycle_P2.BorderColor = System.Drawing.Color.White;
            this.CB_Cycle_P2.CheckColor = System.Drawing.Color.Red;
            this.CB_Cycle_P2.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Cycle_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Cycle_P2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Cycle_P2.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Cycle_P2.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Cycle_P2.IsDerivedStyle = false;
            this.CB_Cycle_P2.Location = new System.Drawing.Point(504, 171);
            this.CB_Cycle_P2.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Cycle_P2.Name = "CB_Cycle_P2";
            this.CB_Cycle_P2.Size = new System.Drawing.Size(58, 22);
            this.CB_Cycle_P2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Cycle_P2.StyleManager = null;
            this.CB_Cycle_P2.Switched = false;
            this.CB_Cycle_P2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Cycle_P2.TabIndex = 260;
            this.CB_Cycle_P2.Text = "metroSwitch10";
            this.CB_Cycle_P2.ThemeAuthor = "Taiizor";
            this.CB_Cycle_P2.ThemeName = "MetroLight";
            this.CB_Cycle_P2.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.CB_Cycle_P2.SwitchedChanged += new ReaLTaiizor.Controls.MetroSwitch.SwitchedChangedEventHandler(this.CB_Cycle_P2_SwitchedChanged);
            // 
            // nightHeaderLabel53
            // 
            this.nightHeaderLabel53.AutoSize = true;
            this.nightHeaderLabel53.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel53.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel53.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel53.Location = new System.Drawing.Point(795, 49);
            this.nightHeaderLabel53.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel53.Name = "nightHeaderLabel53";
            this.nightHeaderLabel53.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel53.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel53.Size = new System.Drawing.Size(98, 24);
            this.nightHeaderLabel53.TabIndex = 249;
            this.nightHeaderLabel53.Text = "Speed Hack";
            this.nightHeaderLabel53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel53.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel53.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel36
            // 
            this.nightHeaderLabel36.AutoSize = true;
            this.nightHeaderLabel36.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel36.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel36.Location = new System.Drawing.Point(570, 171);
            this.nightHeaderLabel36.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel36.Name = "nightHeaderLabel36";
            this.nightHeaderLabel36.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel36.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel36.Size = new System.Drawing.Size(117, 24);
            this.nightHeaderLabel36.TabIndex = 259;
            this.nightHeaderLabel36.Text = "Weapon Cycle";
            this.nightHeaderLabel36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel36.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel36.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel55
            // 
            this.nightHeaderLabel55.AutoSize = true;
            this.nightHeaderLabel55.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel55.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel55.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel55.Location = new System.Drawing.Point(763, 11);
            this.nightHeaderLabel55.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel55.Name = "nightHeaderLabel55";
            this.nightHeaderLabel55.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel55.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel55.Size = new System.Drawing.Size(130, 24);
            this.nightHeaderLabel55.TabIndex = 245;
            this.nightHeaderLabel55.Text = "Unlimited Points";
            this.nightHeaderLabel55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel55.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel55.UseCompatibleTextRendering = true;
            // 
            // CB_Points_P2
            // 
            this.CB_Points_P2.BackColor = System.Drawing.Color.Transparent;
            this.CB_Points_P2.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Points_P2.BorderColor = System.Drawing.Color.White;
            this.CB_Points_P2.CheckColor = System.Drawing.Color.Red;
            this.CB_Points_P2.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Points_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Points_P2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Points_P2.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Points_P2.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Points_P2.IsDerivedStyle = false;
            this.CB_Points_P2.Location = new System.Drawing.Point(911, 11);
            this.CB_Points_P2.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Points_P2.Name = "CB_Points_P2";
            this.CB_Points_P2.Size = new System.Drawing.Size(58, 22);
            this.CB_Points_P2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Points_P2.StyleManager = null;
            this.CB_Points_P2.Switched = false;
            this.CB_Points_P2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Points_P2.TabIndex = 246;
            this.CB_Points_P2.Text = "metroSwitch2";
            this.CB_Points_P2.ThemeAuthor = "Taiizor";
            this.CB_Points_P2.ThemeName = "MetroLight";
            this.CB_Points_P2.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // CB_Speed_P2
            // 
            this.CB_Speed_P2.BackColor = System.Drawing.Color.Transparent;
            this.CB_Speed_P2.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Speed_P2.BorderColor = System.Drawing.Color.White;
            this.CB_Speed_P2.CheckColor = System.Drawing.Color.Red;
            this.CB_Speed_P2.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Speed_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Speed_P2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Speed_P2.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Speed_P2.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Speed_P2.IsDerivedStyle = false;
            this.CB_Speed_P2.Location = new System.Drawing.Point(911, 51);
            this.CB_Speed_P2.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Speed_P2.Name = "CB_Speed_P2";
            this.CB_Speed_P2.Size = new System.Drawing.Size(58, 22);
            this.CB_Speed_P2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Speed_P2.StyleManager = null;
            this.CB_Speed_P2.Switched = false;
            this.CB_Speed_P2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Speed_P2.TabIndex = 250;
            this.CB_Speed_P2.Text = "metroSwitch3";
            this.CB_Speed_P2.ThemeAuthor = "Taiizor";
            this.CB_Speed_P2.ThemeName = "MetroLight";
            this.CB_Speed_P2.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // nightHeaderLabel50
            // 
            this.nightHeaderLabel50.AutoSize = true;
            this.nightHeaderLabel50.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel50.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel50.Location = new System.Drawing.Point(570, 131);
            this.nightHeaderLabel50.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel50.Name = "nightHeaderLabel50";
            this.nightHeaderLabel50.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel50.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel50.Size = new System.Drawing.Size(85, 24);
            this.nightHeaderLabel50.TabIndex = 255;
            this.nightHeaderLabel50.Text = "Rapid Fire";
            this.nightHeaderLabel50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel50.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel50.UseCompatibleTextRendering = true;
            // 
            // CB_Jail_P2
            // 
            this.CB_Jail_P2.BackColor = System.Drawing.Color.Transparent;
            this.CB_Jail_P2.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Jail_P2.BorderColor = System.Drawing.Color.White;
            this.CB_Jail_P2.CheckColor = System.Drawing.Color.Red;
            this.CB_Jail_P2.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Jail_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Jail_P2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Jail_P2.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Jail_P2.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Jail_P2.IsDerivedStyle = false;
            this.CB_Jail_P2.Location = new System.Drawing.Point(911, 91);
            this.CB_Jail_P2.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Jail_P2.Name = "CB_Jail_P2";
            this.CB_Jail_P2.Size = new System.Drawing.Size(58, 22);
            this.CB_Jail_P2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Jail_P2.StyleManager = null;
            this.CB_Jail_P2.Switched = false;
            this.CB_Jail_P2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Jail_P2.TabIndex = 254;
            this.CB_Jail_P2.Text = "metroSwitch5";
            this.CB_Jail_P2.ThemeAuthor = "Taiizor";
            this.CB_Jail_P2.ThemeName = "MetroLight";
            this.CB_Jail_P2.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // CB_Croshair_P2
            // 
            this.CB_Croshair_P2.BackColor = System.Drawing.Color.Transparent;
            this.CB_Croshair_P2.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Croshair_P2.BorderColor = System.Drawing.Color.White;
            this.CB_Croshair_P2.CheckColor = System.Drawing.Color.Red;
            this.CB_Croshair_P2.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Croshair_P2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Croshair_P2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Croshair_P2.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Croshair_P2.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Croshair_P2.IsDerivedStyle = false;
            this.CB_Croshair_P2.Location = new System.Drawing.Point(911, 131);
            this.CB_Croshair_P2.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Croshair_P2.Name = "CB_Croshair_P2";
            this.CB_Croshair_P2.Size = new System.Drawing.Size(58, 22);
            this.CB_Croshair_P2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Croshair_P2.StyleManager = null;
            this.CB_Croshair_P2.Switched = false;
            this.CB_Croshair_P2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Croshair_P2.TabIndex = 258;
            this.CB_Croshair_P2.Text = "metroSwitch7";
            this.CB_Croshair_P2.ThemeAuthor = "Taiizor";
            this.CB_Croshair_P2.ThemeName = "MetroLight";
            this.CB_Croshair_P2.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // nightHeaderLabel52
            // 
            this.nightHeaderLabel52.AutoSize = true;
            this.nightHeaderLabel52.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel52.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel52.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel52.Location = new System.Drawing.Point(570, 91);
            this.nightHeaderLabel52.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel52.Name = "nightHeaderLabel52";
            this.nightHeaderLabel52.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel52.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel52.Size = new System.Drawing.Size(116, 24);
            this.nightHeaderLabel52.TabIndex = 251;
            this.nightHeaderLabel52.Text = "100% Criticals";
            this.nightHeaderLabel52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel52.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel52.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel56
            // 
            this.nightHeaderLabel56.AutoSize = true;
            this.nightHeaderLabel56.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel56.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel56.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel56.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel56.Location = new System.Drawing.Point(570, 11);
            this.nightHeaderLabel56.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel56.Name = "nightHeaderLabel56";
            this.nightHeaderLabel56.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel56.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel56.Size = new System.Drawing.Size(85, 24);
            this.nightHeaderLabel56.TabIndex = 243;
            this.nightHeaderLabel56.Text = "God Mode";
            this.nightHeaderLabel56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel56.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel56.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel54
            // 
            this.nightHeaderLabel54.AutoSize = true;
            this.nightHeaderLabel54.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel54.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel54.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel54.Location = new System.Drawing.Point(570, 51);
            this.nightHeaderLabel54.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel54.Name = "nightHeaderLabel54";
            this.nightHeaderLabel54.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel54.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel54.Size = new System.Drawing.Size(131, 24);
            this.nightHeaderLabel54.TabIndex = 247;
            this.nightHeaderLabel54.Text = "Unlimited Ammo";
            this.nightHeaderLabel54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel54.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel54.UseCompatibleTextRendering = true;
            // 
            // UnlocksTabPage
            // 
            this.UnlocksTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.UnlocksTabPage.Controls.Add(this.poisonTrackBar1);
            this.UnlocksTabPage.Controls.Add(this.guna2ToggleSwitch63);
            this.UnlocksTabPage.Controls.Add(this.guna2ToggleSwitch19);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel112);
            this.UnlocksTabPage.Controls.Add(this.guna2ToggleSwitch61);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel59);
            this.UnlocksTabPage.Controls.Add(this.Box_Weapons_P3);
            this.UnlocksTabPage.Controls.Add(this.Box_TP_P3);
            this.UnlocksTabPage.Controls.Add(this.bar_noclip);
            this.UnlocksTabPage.Controls.Add(this.Box_CycleEnd_P3);
            this.UnlocksTabPage.Controls.Add(this.Box_CycleStart_P3);
            this.UnlocksTabPage.Controls.Add(this.guna2ToggleSwitch5);
            this.UnlocksTabPage.Controls.Add(this.Btn_Gib2_P3);
            this.UnlocksTabPage.Controls.Add(this.Btn_TP_P3);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel62);
            this.UnlocksTabPage.Controls.Add(this.Btn_Gib_P3);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel20);
            this.UnlocksTabPage.Controls.Add(this.guna2ToggleSwitch2);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel17);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel21);
            this.UnlocksTabPage.Controls.Add(this.guna2Panel20);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel19);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel18);
            this.UnlocksTabPage.Controls.Add(this.CB_zqinissofuckingsexy_P3);
            this.UnlocksTabPage.Controls.Add(this.guna2Panel21);
            this.UnlocksTabPage.Controls.Add(this.CB_Shoot_P3);
            this.UnlocksTabPage.Controls.Add(this.guna2Panel22);
            this.UnlocksTabPage.Controls.Add(this.CB_Rainbow_P3);
            this.UnlocksTabPage.Controls.Add(this.guna2Panel27);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel61);
            this.UnlocksTabPage.Controls.Add(this.groupBox6);
            this.UnlocksTabPage.Controls.Add(this.guna2ToggleSwitch4);
            this.UnlocksTabPage.Controls.Add(this.guna2Button4);
            this.UnlocksTabPage.Controls.Add(this.Bar_Kills);
            this.UnlocksTabPage.Controls.Add(this.guna2Button5);
            this.UnlocksTabPage.Controls.Add(this.Bar_Shots);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel23);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel57);
            this.UnlocksTabPage.Controls.Add(this.CB_God_P3);
            this.UnlocksTabPage.Controls.Add(this.Btn_QuickDA);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel25);
            this.UnlocksTabPage.Controls.Add(this.LBL_Kills);
            this.UnlocksTabPage.Controls.Add(this.CB_Ammo_P3);
            this.UnlocksTabPage.Controls.Add(this.guna2ToggleSwitch7);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel27);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel76);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel22);
            this.UnlocksTabPage.Controls.Add(this.Btn_KillAll);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel29);
            this.UnlocksTabPage.Controls.Add(this.LBL_Shots);
            this.UnlocksTabPage.Controls.Add(this.CB_Crit_P3);
            this.UnlocksTabPage.Controls.Add(this.Btn_Kill_multi);
            this.UnlocksTabPage.Controls.Add(this.CB_Rapid_P3);
            this.UnlocksTabPage.Controls.Add(this.guna2ToggleSwitch1);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel24);
            this.UnlocksTabPage.Controls.Add(this.guna2ToggleSwitch3);
            this.UnlocksTabPage.Controls.Add(this.CB_Cycle_P3);
            this.UnlocksTabPage.Controls.Add(this.Btn_Dark);
            this.UnlocksTabPage.Controls.Add(this.CB_Points_P3);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel60);
            this.UnlocksTabPage.Controls.Add(this.Btn_TP_Set);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel26);
            this.UnlocksTabPage.Controls.Add(this.CB_Speed_P3);
            this.UnlocksTabPage.Controls.Add(this.CB_Croshair_P3);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel28);
            this.UnlocksTabPage.Controls.Add(this.CB_Jail_P3);
            this.UnlocksTabPage.Controls.Add(this.nightHeaderLabel30);
            this.UnlocksTabPage.Location = new System.Drawing.Point(4, 44);
            this.UnlocksTabPage.Name = "UnlocksTabPage";
            this.UnlocksTabPage.Size = new System.Drawing.Size(507, 532);
            this.UnlocksTabPage.TabIndex = 3;
            this.UnlocksTabPage.Text = "ZOMBIES";
            // 
            // guna2ToggleSwitch63
            // 
            this.guna2ToggleSwitch63.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch63.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch63.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch63.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch63.CheckedState.Parent = this.guna2ToggleSwitch63;
            this.guna2ToggleSwitch63.Location = new System.Drawing.Point(572, 449);
            this.guna2ToggleSwitch63.Name = "guna2ToggleSwitch63";
            this.guna2ToggleSwitch63.ShadowDecoration.Parent = this.guna2ToggleSwitch63;
            this.guna2ToggleSwitch63.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch63.TabIndex = 306;
            this.guna2ToggleSwitch63.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch63.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch63.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch63.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch63.UncheckedState.Parent = this.guna2ToggleSwitch63;
            this.guna2ToggleSwitch63.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch63_CheckedChanged);
            // 
            // guna2ToggleSwitch19
            // 
            this.guna2ToggleSwitch19.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch19.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch19.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch19.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch19.CheckedState.Parent = this.guna2ToggleSwitch19;
            this.guna2ToggleSwitch19.Location = new System.Drawing.Point(542, 449);
            this.guna2ToggleSwitch19.Name = "guna2ToggleSwitch19";
            this.guna2ToggleSwitch19.ShadowDecoration.Parent = this.guna2ToggleSwitch19;
            this.guna2ToggleSwitch19.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch19.TabIndex = 304;
            this.guna2ToggleSwitch19.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch19.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch19.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch19.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch19.UncheckedState.Parent = this.guna2ToggleSwitch19;
            this.guna2ToggleSwitch19.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch19_CheckedChanged_1);
            // 
            // nightHeaderLabel112
            // 
            this.nightHeaderLabel112.AutoSize = true;
            this.nightHeaderLabel112.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel112.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel112.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel112.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel112.Location = new System.Drawing.Point(63, 449);
            this.nightHeaderLabel112.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel112.Name = "nightHeaderLabel112";
            this.nightHeaderLabel112.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel112.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel112.Size = new System.Drawing.Size(91, 24);
            this.nightHeaderLabel112.TabIndex = 303;
            this.nightHeaderLabel112.Text = "Run Speed";
            this.nightHeaderLabel112.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel112.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel112.UseCompatibleTextRendering = true;
            // 
            // guna2ToggleSwitch61
            // 
            this.guna2ToggleSwitch61.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch61.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch61.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch61.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch61.CheckedState.Parent = this.guna2ToggleSwitch61;
            this.guna2ToggleSwitch61.Location = new System.Drawing.Point(24, 449);
            this.guna2ToggleSwitch61.Name = "guna2ToggleSwitch61";
            this.guna2ToggleSwitch61.ShadowDecoration.Parent = this.guna2ToggleSwitch61;
            this.guna2ToggleSwitch61.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch61.TabIndex = 302;
            this.guna2ToggleSwitch61.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch61.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch61.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch61.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch61.UncheckedState.Parent = this.guna2ToggleSwitch61;
            this.guna2ToggleSwitch61.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch61_CheckedChanged);
            // 
            // Box_Weapons_P3
            // 
            this.Box_Weapons_P3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.Box_Weapons_P3.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Box_Weapons_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_Weapons_P3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Box_Weapons_P3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Weapons_P3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Weapons_P3.ForeColor = System.Drawing.Color.White;
            this.Box_Weapons_P3.FormattingEnabled = true;
            this.Box_Weapons_P3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(49)))), ((int)(((byte)(222)))));
            this.Box_Weapons_P3.HoverFontColor = System.Drawing.Color.White;
            this.Box_Weapons_P3.ItemHeight = 20;
            this.Box_Weapons_P3.Location = new System.Drawing.Point(517, 413);
            this.Box_Weapons_P3.Margin = new System.Windows.Forms.Padding(9);
            this.Box_Weapons_P3.Name = "Box_Weapons_P3";
            this.Box_Weapons_P3.Size = new System.Drawing.Size(460, 26);
            this.Box_Weapons_P3.TabIndex = 261;
            // 
            // Box_TP_P3
            // 
            this.Box_TP_P3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.Box_TP_P3.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Box_TP_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_TP_P3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Box_TP_P3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_TP_P3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_TP_P3.ForeColor = System.Drawing.Color.White;
            this.Box_TP_P3.FormattingEnabled = true;
            this.Box_TP_P3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(49)))), ((int)(((byte)(222)))));
            this.Box_TP_P3.HoverFontColor = System.Drawing.Color.White;
            this.Box_TP_P3.ItemHeight = 20;
            this.Box_TP_P3.Items.AddRange(new object[] {
            "Spawn",
            "Nacht",
            "Pond",
            "Power"});
            this.Box_TP_P3.Location = new System.Drawing.Point(517, 348);
            this.Box_TP_P3.Margin = new System.Windows.Forms.Padding(9);
            this.Box_TP_P3.Name = "Box_TP_P3";
            this.Box_TP_P3.Size = new System.Drawing.Size(460, 26);
            this.Box_TP_P3.TabIndex = 262;
            // 
            // Box_CycleEnd_P3
            // 
            this.Box_CycleEnd_P3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.Box_CycleEnd_P3.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Box_CycleEnd_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_CycleEnd_P3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Box_CycleEnd_P3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_CycleEnd_P3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_CycleEnd_P3.ForeColor = System.Drawing.Color.White;
            this.Box_CycleEnd_P3.FormattingEnabled = true;
            this.Box_CycleEnd_P3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(49)))), ((int)(((byte)(222)))));
            this.Box_CycleEnd_P3.HoverFontColor = System.Drawing.Color.White;
            this.Box_CycleEnd_P3.ItemHeight = 20;
            this.Box_CycleEnd_P3.Location = new System.Drawing.Point(754, 286);
            this.Box_CycleEnd_P3.Margin = new System.Windows.Forms.Padding(9);
            this.Box_CycleEnd_P3.Name = "Box_CycleEnd_P3";
            this.Box_CycleEnd_P3.Size = new System.Drawing.Size(223, 26);
            this.Box_CycleEnd_P3.TabIndex = 267;
            // 
            // Box_CycleStart_P3
            // 
            this.Box_CycleStart_P3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.Box_CycleStart_P3.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Box_CycleStart_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_CycleStart_P3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Box_CycleStart_P3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_CycleStart_P3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_CycleStart_P3.ForeColor = System.Drawing.Color.White;
            this.Box_CycleStart_P3.FormattingEnabled = true;
            this.Box_CycleStart_P3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(49)))), ((int)(((byte)(222)))));
            this.Box_CycleStart_P3.HoverFontColor = System.Drawing.Color.White;
            this.Box_CycleStart_P3.ItemHeight = 20;
            this.Box_CycleStart_P3.Location = new System.Drawing.Point(517, 286);
            this.Box_CycleStart_P3.Margin = new System.Windows.Forms.Padding(9);
            this.Box_CycleStart_P3.Name = "Box_CycleStart_P3";
            this.Box_CycleStart_P3.Size = new System.Drawing.Size(228, 26);
            this.Box_CycleStart_P3.TabIndex = 266;
            // 
            // Btn_Gib2_P3
            // 
            this.Btn_Gib2_P3.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Gib2_P3.BaseColor = System.Drawing.Color.Transparent;
            this.Btn_Gib2_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Gib2_P3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Gib2_P3.Location = new System.Drawing.Point(795, 379);
            this.Btn_Gib2_P3.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Gib2_P3.Name = "Btn_Gib2_P3";
            this.Btn_Gib2_P3.Rounded = false;
            this.Btn_Gib2_P3.Size = new System.Drawing.Size(192, 25);
            this.Btn_Gib2_P3.TabIndex = 264;
            this.Btn_Gib2_P3.Text = "Give Weapon 2 ↓";
            this.Btn_Gib2_P3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Btn_Gib2_P3.Click += new System.EventHandler(this.Btn_Gib2_P3_Click);
            // 
            // Btn_TP_P3
            // 
            this.Btn_TP_P3.BackColor = System.Drawing.Color.Transparent;
            this.Btn_TP_P3.BaseColor = System.Drawing.Color.Transparent;
            this.Btn_TP_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_TP_P3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TP_P3.Location = new System.Drawing.Point(546, 319);
            this.Btn_TP_P3.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_TP_P3.Name = "Btn_TP_P3";
            this.Btn_TP_P3.Rounded = false;
            this.Btn_TP_P3.Size = new System.Drawing.Size(406, 25);
            this.Btn_TP_P3.TabIndex = 265;
            this.Btn_TP_P3.Text = "Teleport To Location ↓";
            this.Btn_TP_P3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // Btn_Gib_P3
            // 
            this.Btn_Gib_P3.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Gib_P3.BaseColor = System.Drawing.Color.Transparent;
            this.Btn_Gib_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Gib_P3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Gib_P3.Location = new System.Drawing.Point(517, 382);
            this.Btn_Gib_P3.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Gib_P3.Name = "Btn_Gib_P3";
            this.Btn_Gib_P3.Rounded = false;
            this.Btn_Gib_P3.Size = new System.Drawing.Size(200, 25);
            this.Btn_Gib_P3.TabIndex = 263;
            this.Btn_Gib_P3.Text = "Give Weapon 1 ↓";
            this.Btn_Gib_P3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Btn_Gib_P3.Click += new System.EventHandler(this.Btn_Gib_P3_Click);
            // 
            // nightHeaderLabel20
            // 
            this.nightHeaderLabel20.AutoSize = true;
            this.nightHeaderLabel20.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel20.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel20.Location = new System.Drawing.Point(894, 252);
            this.nightHeaderLabel20.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel20.Name = "nightHeaderLabel20";
            this.nightHeaderLabel20.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel20.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel20.Size = new System.Drawing.Size(83, 24);
            this.nightHeaderLabel20.TabIndex = 269;
            this.nightHeaderLabel20.Text = "Cycle End";
            this.nightHeaderLabel20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel20.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel20.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel17
            // 
            this.nightHeaderLabel17.AutoSize = true;
            this.nightHeaderLabel17.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel17.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel17.Location = new System.Drawing.Point(861, 221);
            this.nightHeaderLabel17.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel17.Name = "nightHeaderLabel17";
            this.nightHeaderLabel17.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel17.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel17.Size = new System.Drawing.Size(40, 24);
            this.nightHeaderLabel17.TabIndex = 275;
            this.nightHeaderLabel17.Text = "TBD";
            this.nightHeaderLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel17.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel17.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel21
            // 
            this.nightHeaderLabel21.AutoSize = true;
            this.nightHeaderLabel21.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel21.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel21.Location = new System.Drawing.Point(517, 255);
            this.nightHeaderLabel21.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel21.Name = "nightHeaderLabel21";
            this.nightHeaderLabel21.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel21.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel21.Size = new System.Drawing.Size(90, 24);
            this.nightHeaderLabel21.TabIndex = 268;
            this.nightHeaderLabel21.Text = "Cycle Start";
            this.nightHeaderLabel21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel21.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel21.UseCompatibleTextRendering = true;
            // 
            // guna2Panel20
            // 
            this.guna2Panel20.BackColor = System.Drawing.Color.Red;
            this.guna2Panel20.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel20.BorderThickness = 2;
            this.guna2Panel20.Location = new System.Drawing.Point(499, -5);
            this.guna2Panel20.Name = "guna2Panel20";
            this.guna2Panel20.ShadowDecoration.Parent = this.guna2Panel20;
            this.guna2Panel20.Size = new System.Drawing.Size(10, 534);
            this.guna2Panel20.TabIndex = 226;
            // 
            // nightHeaderLabel19
            // 
            this.nightHeaderLabel19.AutoSize = true;
            this.nightHeaderLabel19.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel19.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel19.Location = new System.Drawing.Point(795, 189);
            this.nightHeaderLabel19.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel19.Name = "nightHeaderLabel19";
            this.nightHeaderLabel19.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel19.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel19.Size = new System.Drawing.Size(109, 24);
            this.nightHeaderLabel19.TabIndex = 271;
            this.nightHeaderLabel19.Text = "Rainbow Gun";
            this.nightHeaderLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel19.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel19.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel18
            // 
            this.nightHeaderLabel18.AutoSize = true;
            this.nightHeaderLabel18.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel18.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel18.Location = new System.Drawing.Point(593, 221);
            this.nightHeaderLabel18.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel18.Name = "nightHeaderLabel18";
            this.nightHeaderLabel18.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel18.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel18.Size = new System.Drawing.Size(90, 24);
            this.nightHeaderLabel18.TabIndex = 272;
            this.nightHeaderLabel18.Text = "Auto Shoot";
            this.nightHeaderLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel18.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel18.UseCompatibleTextRendering = true;
            // 
            // CB_zqinissofuckingsexy_P3
            // 
            this.CB_zqinissofuckingsexy_P3.BackColor = System.Drawing.Color.Transparent;
            this.CB_zqinissofuckingsexy_P3.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_zqinissofuckingsexy_P3.BorderColor = System.Drawing.Color.White;
            this.CB_zqinissofuckingsexy_P3.CheckColor = System.Drawing.Color.Red;
            this.CB_zqinissofuckingsexy_P3.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_zqinissofuckingsexy_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_zqinissofuckingsexy_P3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_zqinissofuckingsexy_P3.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_zqinissofuckingsexy_P3.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_zqinissofuckingsexy_P3.IsDerivedStyle = false;
            this.CB_zqinissofuckingsexy_P3.Location = new System.Drawing.Point(919, 221);
            this.CB_zqinissofuckingsexy_P3.Margin = new System.Windows.Forms.Padding(9);
            this.CB_zqinissofuckingsexy_P3.Name = "CB_zqinissofuckingsexy_P3";
            this.CB_zqinissofuckingsexy_P3.Size = new System.Drawing.Size(58, 22);
            this.CB_zqinissofuckingsexy_P3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_zqinissofuckingsexy_P3.StyleManager = null;
            this.CB_zqinissofuckingsexy_P3.Switched = false;
            this.CB_zqinissofuckingsexy_P3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_zqinissofuckingsexy_P3.TabIndex = 274;
            this.CB_zqinissofuckingsexy_P3.Text = "metroSwitch7";
            this.CB_zqinissofuckingsexy_P3.ThemeAuthor = "Taiizor";
            this.CB_zqinissofuckingsexy_P3.ThemeName = "MetroLight";
            this.CB_zqinissofuckingsexy_P3.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // guna2Panel21
            // 
            this.guna2Panel21.BackColor = System.Drawing.Color.Red;
            this.guna2Panel21.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel21.BorderThickness = 2;
            this.guna2Panel21.Location = new System.Drawing.Point(0, 521);
            this.guna2Panel21.Name = "guna2Panel21";
            this.guna2Panel21.ShadowDecoration.Parent = this.guna2Panel21;
            this.guna2Panel21.Size = new System.Drawing.Size(760, 10);
            this.guna2Panel21.TabIndex = 225;
            // 
            // CB_Shoot_P3
            // 
            this.CB_Shoot_P3.BackColor = System.Drawing.Color.Transparent;
            this.CB_Shoot_P3.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Shoot_P3.BorderColor = System.Drawing.Color.White;
            this.CB_Shoot_P3.CheckColor = System.Drawing.Color.Red;
            this.CB_Shoot_P3.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Shoot_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Shoot_P3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Shoot_P3.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Shoot_P3.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Shoot_P3.IsDerivedStyle = false;
            this.CB_Shoot_P3.Location = new System.Drawing.Point(517, 221);
            this.CB_Shoot_P3.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Shoot_P3.Name = "CB_Shoot_P3";
            this.CB_Shoot_P3.Size = new System.Drawing.Size(58, 22);
            this.CB_Shoot_P3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Shoot_P3.StyleManager = null;
            this.CB_Shoot_P3.Switched = false;
            this.CB_Shoot_P3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Shoot_P3.TabIndex = 273;
            this.CB_Shoot_P3.Text = "metroSwitch10";
            this.CB_Shoot_P3.ThemeAuthor = "Taiizor";
            this.CB_Shoot_P3.ThemeName = "MetroLight";
            this.CB_Shoot_P3.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // guna2Panel22
            // 
            this.guna2Panel22.BackColor = System.Drawing.Color.Red;
            this.guna2Panel22.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel22.BorderThickness = 2;
            this.guna2Panel22.Location = new System.Drawing.Point(-9, -1);
            this.guna2Panel22.Name = "guna2Panel22";
            this.guna2Panel22.ShadowDecoration.Parent = this.guna2Panel22;
            this.guna2Panel22.Size = new System.Drawing.Size(760, 10);
            this.guna2Panel22.TabIndex = 224;
            // 
            // CB_Rainbow_P3
            // 
            this.CB_Rainbow_P3.BackColor = System.Drawing.Color.Transparent;
            this.CB_Rainbow_P3.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Rainbow_P3.BorderColor = System.Drawing.Color.White;
            this.CB_Rainbow_P3.CheckColor = System.Drawing.Color.Red;
            this.CB_Rainbow_P3.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Rainbow_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Rainbow_P3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Rainbow_P3.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Rainbow_P3.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Rainbow_P3.IsDerivedStyle = false;
            this.CB_Rainbow_P3.Location = new System.Drawing.Point(919, 181);
            this.CB_Rainbow_P3.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Rainbow_P3.Name = "CB_Rainbow_P3";
            this.CB_Rainbow_P3.Size = new System.Drawing.Size(58, 22);
            this.CB_Rainbow_P3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Rainbow_P3.StyleManager = null;
            this.CB_Rainbow_P3.Switched = false;
            this.CB_Rainbow_P3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Rainbow_P3.TabIndex = 270;
            this.CB_Rainbow_P3.Text = "metroSwitch7";
            this.CB_Rainbow_P3.ThemeAuthor = "Taiizor";
            this.CB_Rainbow_P3.ThemeName = "MetroLight";
            this.CB_Rainbow_P3.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // guna2Panel27
            // 
            this.guna2Panel27.BackColor = System.Drawing.Color.Red;
            this.guna2Panel27.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel27.BorderThickness = 2;
            this.guna2Panel27.Controls.Add(this.guna2Panel28);
            this.guna2Panel27.Location = new System.Drawing.Point(-3, 8);
            this.guna2Panel27.Name = "guna2Panel27";
            this.guna2Panel27.ShadowDecoration.Parent = this.guna2Panel27;
            this.guna2Panel27.Size = new System.Drawing.Size(11, 523);
            this.guna2Panel27.TabIndex = 223;
            // 
            // guna2Panel28
            // 
            this.guna2Panel28.BackColor = System.Drawing.Color.Red;
            this.guna2Panel28.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel28.BorderThickness = 2;
            this.guna2Panel28.Location = new System.Drawing.Point(-20, 0);
            this.guna2Panel28.Name = "guna2Panel28";
            this.guna2Panel28.ShadowDecoration.Parent = this.guna2Panel28;
            this.guna2Panel28.Size = new System.Drawing.Size(10, 284);
            this.guna2Panel28.TabIndex = 213;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.guna2Button2);
            this.groupBox6.Controls.Add(this.guna2Button3);
            this.groupBox6.Controls.Add(this.CWCamoSwapComboBox);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Red;
            this.groupBox6.Location = new System.Drawing.Point(515, 110);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(220, 158);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "CW Camo Swap";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.Red;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(6, 113);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(202, 34);
            this.guna2Button2.TabIndex = 7;
            this.guna2Button2.Text = "Reset";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.Red;
            this.guna2Button3.BorderThickness = 2;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.DisabledState.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(6, 66);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(202, 34);
            this.guna2Button3.TabIndex = 7;
            this.guna2Button3.Text = "Apply";
            // 
            // CWCamoSwapComboBox
            // 
            this.CWCamoSwapComboBox.BackColor = System.Drawing.Color.Transparent;
            this.CWCamoSwapComboBox.BorderColor = System.Drawing.Color.Red;
            this.CWCamoSwapComboBox.BorderThickness = 2;
            this.CWCamoSwapComboBox.DisabledState.Parent = this.CWCamoSwapComboBox;
            this.CWCamoSwapComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CWCamoSwapComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CWCamoSwapComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CWCamoSwapComboBox.FocusedColor = System.Drawing.Color.Red;
            this.CWCamoSwapComboBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.CWCamoSwapComboBox.FocusedState.Parent = this.CWCamoSwapComboBox;
            this.CWCamoSwapComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CWCamoSwapComboBox.ForeColor = System.Drawing.Color.White;
            this.CWCamoSwapComboBox.HoverState.Parent = this.CWCamoSwapComboBox;
            this.CWCamoSwapComboBox.ItemHeight = 30;
            this.CWCamoSwapComboBox.Items.AddRange(new object[] {
            "Gold (MW)",
            "Platinum (MW)",
            "Damascus (MW)",
            "Obsidian (MW)",
            "Gold (CW)",
            "Diamond (CW)",
            "Dark Matter (CW)",
            "Golden Viper (ZM)",
            "Plague Diamond (ZM)",
            "Dark Aether (ZM)",
            "Cherry Blossom",
            "ActivCamo",
            "Banded",
            "Atlanta FaZe",
            "Chicago Huntsmen",
            "Dallas Empire",
            "Florida Mutineers",
            "Los Angeles Guerrillas",
            "London Royal Ravens",
            "Minnesota RÃ˜KKR",
            "New York Subliners",
            "OpTic Gaming Los Angeles",
            "Paris Legion",
            "Seattle Surge",
            "Toronto Ultra"});
            this.CWCamoSwapComboBox.ItemsAppearance.Parent = this.CWCamoSwapComboBox;
            this.CWCamoSwapComboBox.Location = new System.Drawing.Point(5, 20);
            this.CWCamoSwapComboBox.Name = "CWCamoSwapComboBox";
            this.CWCamoSwapComboBox.ShadowDecoration.Parent = this.CWCamoSwapComboBox;
            this.CWCamoSwapComboBox.Size = new System.Drawing.Size(202, 36);
            this.CWCamoSwapComboBox.TabIndex = 0;
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderColor = System.Drawing.Color.Red;
            this.guna2Button4.BorderThickness = 2;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.DisabledState.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(771, 43);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(228, 36);
            this.guna2Button4.TabIndex = 4;
            this.guna2Button4.Text = "Unlock CDL Camos";
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderColor = System.Drawing.Color.Red;
            this.guna2Button5.BorderThickness = 2;
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.DisabledState.Parent = this.guna2Button5;
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.Location = new System.Drawing.Point(771, 1);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(228, 36);
            this.guna2Button5.TabIndex = 3;
            this.guna2Button5.Text = "Unlock Guns + Attachments";
            // 
            // nightHeaderLabel23
            // 
            this.nightHeaderLabel23.AutoSize = true;
            this.nightHeaderLabel23.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel23.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel23.Location = new System.Drawing.Point(771, 141);
            this.nightHeaderLabel23.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel23.Name = "nightHeaderLabel23";
            this.nightHeaderLabel23.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel23.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel23.Size = new System.Drawing.Size(133, 24);
            this.nightHeaderLabel23.TabIndex = 257;
            this.nightHeaderLabel23.Text = "ZM To Crosshair";
            this.nightHeaderLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel23.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel23.UseCompatibleTextRendering = true;
            // 
            // CB_God_P3
            // 
            this.CB_God_P3.BackColor = System.Drawing.Color.Transparent;
            this.CB_God_P3.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_God_P3.BorderColor = System.Drawing.Color.White;
            this.CB_God_P3.CheckColor = System.Drawing.Color.Red;
            this.CB_God_P3.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_God_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_God_P3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_God_P3.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_God_P3.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_God_P3.IsDerivedStyle = false;
            this.CB_God_P3.Location = new System.Drawing.Point(517, 21);
            this.CB_God_P3.Margin = new System.Windows.Forms.Padding(9);
            this.CB_God_P3.Name = "CB_God_P3";
            this.CB_God_P3.Size = new System.Drawing.Size(58, 22);
            this.CB_God_P3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_God_P3.StyleManager = null;
            this.CB_God_P3.Switched = false;
            this.CB_God_P3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_God_P3.TabIndex = 244;
            this.CB_God_P3.Text = "metroSwitch1";
            this.CB_God_P3.ThemeAuthor = "Taiizor";
            this.CB_God_P3.ThemeName = "MetroLight";
            this.CB_God_P3.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // nightHeaderLabel25
            // 
            this.nightHeaderLabel25.AutoSize = true;
            this.nightHeaderLabel25.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel25.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel25.Location = new System.Drawing.Point(803, 101);
            this.nightHeaderLabel25.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel25.Name = "nightHeaderLabel25";
            this.nightHeaderLabel25.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel25.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel25.Size = new System.Drawing.Size(101, 24);
            this.nightHeaderLabel25.TabIndex = 253;
            this.nightHeaderLabel25.Text = "Send To Jail";
            this.nightHeaderLabel25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel25.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel25.UseCompatibleTextRendering = true;
            // 
            // CB_Ammo_P3
            // 
            this.CB_Ammo_P3.BackColor = System.Drawing.Color.Transparent;
            this.CB_Ammo_P3.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Ammo_P3.BorderColor = System.Drawing.Color.White;
            this.CB_Ammo_P3.CheckColor = System.Drawing.Color.Red;
            this.CB_Ammo_P3.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Ammo_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Ammo_P3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Ammo_P3.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Ammo_P3.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Ammo_P3.IsDerivedStyle = false;
            this.CB_Ammo_P3.Location = new System.Drawing.Point(517, 61);
            this.CB_Ammo_P3.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Ammo_P3.Name = "CB_Ammo_P3";
            this.CB_Ammo_P3.Size = new System.Drawing.Size(58, 22);
            this.CB_Ammo_P3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Ammo_P3.StyleManager = null;
            this.CB_Ammo_P3.Switched = false;
            this.CB_Ammo_P3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Ammo_P3.TabIndex = 248;
            this.CB_Ammo_P3.Text = "metroSwitch4";
            this.CB_Ammo_P3.ThemeAuthor = "Taiizor";
            this.CB_Ammo_P3.ThemeName = "MetroLight";
            this.CB_Ammo_P3.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // nightHeaderLabel27
            // 
            this.nightHeaderLabel27.AutoSize = true;
            this.nightHeaderLabel27.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel27.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel27.Location = new System.Drawing.Point(803, 61);
            this.nightHeaderLabel27.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel27.Name = "nightHeaderLabel27";
            this.nightHeaderLabel27.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel27.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel27.Size = new System.Drawing.Size(98, 24);
            this.nightHeaderLabel27.TabIndex = 249;
            this.nightHeaderLabel27.Text = "Speed Hack";
            this.nightHeaderLabel27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel27.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel27.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel22
            // 
            this.nightHeaderLabel22.AutoSize = true;
            this.nightHeaderLabel22.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel22.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel22.Location = new System.Drawing.Point(593, 181);
            this.nightHeaderLabel22.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel22.Name = "nightHeaderLabel22";
            this.nightHeaderLabel22.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel22.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel22.Size = new System.Drawing.Size(117, 24);
            this.nightHeaderLabel22.TabIndex = 259;
            this.nightHeaderLabel22.Text = "Weapon Cycle";
            this.nightHeaderLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel22.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel22.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel29
            // 
            this.nightHeaderLabel29.AutoSize = true;
            this.nightHeaderLabel29.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel29.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel29.Location = new System.Drawing.Point(774, 21);
            this.nightHeaderLabel29.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel29.Name = "nightHeaderLabel29";
            this.nightHeaderLabel29.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel29.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel29.Size = new System.Drawing.Size(130, 24);
            this.nightHeaderLabel29.TabIndex = 245;
            this.nightHeaderLabel29.Text = "Unlimited Points";
            this.nightHeaderLabel29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel29.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel29.UseCompatibleTextRendering = true;
            // 
            // CB_Crit_P3
            // 
            this.CB_Crit_P3.BackColor = System.Drawing.Color.Transparent;
            this.CB_Crit_P3.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Crit_P3.BorderColor = System.Drawing.Color.White;
            this.CB_Crit_P3.CheckColor = System.Drawing.Color.Red;
            this.CB_Crit_P3.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Crit_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Crit_P3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Crit_P3.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Crit_P3.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Crit_P3.IsDerivedStyle = false;
            this.CB_Crit_P3.Location = new System.Drawing.Point(517, 101);
            this.CB_Crit_P3.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Crit_P3.Name = "CB_Crit_P3";
            this.CB_Crit_P3.Size = new System.Drawing.Size(58, 22);
            this.CB_Crit_P3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Crit_P3.StyleManager = null;
            this.CB_Crit_P3.Switched = false;
            this.CB_Crit_P3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Crit_P3.TabIndex = 252;
            this.CB_Crit_P3.Text = "metroSwitch6";
            this.CB_Crit_P3.ThemeAuthor = "Taiizor";
            this.CB_Crit_P3.ThemeName = "MetroLight";
            this.CB_Crit_P3.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // CB_Rapid_P3
            // 
            this.CB_Rapid_P3.BackColor = System.Drawing.Color.Transparent;
            this.CB_Rapid_P3.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Rapid_P3.BorderColor = System.Drawing.Color.White;
            this.CB_Rapid_P3.CheckColor = System.Drawing.Color.Red;
            this.CB_Rapid_P3.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Rapid_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Rapid_P3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Rapid_P3.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Rapid_P3.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Rapid_P3.IsDerivedStyle = false;
            this.CB_Rapid_P3.Location = new System.Drawing.Point(517, 141);
            this.CB_Rapid_P3.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Rapid_P3.Name = "CB_Rapid_P3";
            this.CB_Rapid_P3.Size = new System.Drawing.Size(58, 22);
            this.CB_Rapid_P3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Rapid_P3.StyleManager = null;
            this.CB_Rapid_P3.Switched = false;
            this.CB_Rapid_P3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Rapid_P3.TabIndex = 256;
            this.CB_Rapid_P3.Text = "metroSwitch8";
            this.CB_Rapid_P3.ThemeAuthor = "Taiizor";
            this.CB_Rapid_P3.ThemeName = "MetroLight";
            this.CB_Rapid_P3.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // nightHeaderLabel24
            // 
            this.nightHeaderLabel24.AutoSize = true;
            this.nightHeaderLabel24.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel24.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel24.Location = new System.Drawing.Point(593, 141);
            this.nightHeaderLabel24.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel24.Name = "nightHeaderLabel24";
            this.nightHeaderLabel24.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel24.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel24.Size = new System.Drawing.Size(85, 24);
            this.nightHeaderLabel24.TabIndex = 255;
            this.nightHeaderLabel24.Text = "Rapid Fire";
            this.nightHeaderLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel24.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel24.UseCompatibleTextRendering = true;
            // 
            // CB_Cycle_P3
            // 
            this.CB_Cycle_P3.BackColor = System.Drawing.Color.Transparent;
            this.CB_Cycle_P3.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Cycle_P3.BorderColor = System.Drawing.Color.White;
            this.CB_Cycle_P3.CheckColor = System.Drawing.Color.Red;
            this.CB_Cycle_P3.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Cycle_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Cycle_P3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Cycle_P3.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Cycle_P3.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Cycle_P3.IsDerivedStyle = false;
            this.CB_Cycle_P3.Location = new System.Drawing.Point(517, 181);
            this.CB_Cycle_P3.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Cycle_P3.Name = "CB_Cycle_P3";
            this.CB_Cycle_P3.Size = new System.Drawing.Size(58, 22);
            this.CB_Cycle_P3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Cycle_P3.StyleManager = null;
            this.CB_Cycle_P3.Switched = false;
            this.CB_Cycle_P3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Cycle_P3.TabIndex = 260;
            this.CB_Cycle_P3.Text = "metroSwitch10";
            this.CB_Cycle_P3.ThemeAuthor = "Taiizor";
            this.CB_Cycle_P3.ThemeName = "MetroLight";
            this.CB_Cycle_P3.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.CB_Cycle_P3.SwitchedChanged += new ReaLTaiizor.Controls.MetroSwitch.SwitchedChangedEventHandler(this.CB_Cycle_P3_SwitchedChanged);
            // 
            // CB_Points_P3
            // 
            this.CB_Points_P3.BackColor = System.Drawing.Color.Transparent;
            this.CB_Points_P3.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Points_P3.BorderColor = System.Drawing.Color.White;
            this.CB_Points_P3.CheckColor = System.Drawing.Color.Red;
            this.CB_Points_P3.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Points_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Points_P3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Points_P3.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Points_P3.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Points_P3.IsDerivedStyle = false;
            this.CB_Points_P3.Location = new System.Drawing.Point(919, 21);
            this.CB_Points_P3.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Points_P3.Name = "CB_Points_P3";
            this.CB_Points_P3.Size = new System.Drawing.Size(58, 22);
            this.CB_Points_P3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Points_P3.StyleManager = null;
            this.CB_Points_P3.Switched = false;
            this.CB_Points_P3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Points_P3.TabIndex = 246;
            this.CB_Points_P3.Text = "metroSwitch2";
            this.CB_Points_P3.ThemeAuthor = "Taiizor";
            this.CB_Points_P3.ThemeName = "MetroLight";
            this.CB_Points_P3.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // nightHeaderLabel26
            // 
            this.nightHeaderLabel26.AutoSize = true;
            this.nightHeaderLabel26.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel26.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel26.Location = new System.Drawing.Point(593, 101);
            this.nightHeaderLabel26.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel26.Name = "nightHeaderLabel26";
            this.nightHeaderLabel26.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel26.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel26.Size = new System.Drawing.Size(116, 24);
            this.nightHeaderLabel26.TabIndex = 251;
            this.nightHeaderLabel26.Text = "100% Criticals";
            this.nightHeaderLabel26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel26.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel26.UseCompatibleTextRendering = true;
            // 
            // CB_Speed_P3
            // 
            this.CB_Speed_P3.BackColor = System.Drawing.Color.Transparent;
            this.CB_Speed_P3.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Speed_P3.BorderColor = System.Drawing.Color.White;
            this.CB_Speed_P3.CheckColor = System.Drawing.Color.Red;
            this.CB_Speed_P3.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Speed_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Speed_P3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Speed_P3.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Speed_P3.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Speed_P3.IsDerivedStyle = false;
            this.CB_Speed_P3.Location = new System.Drawing.Point(919, 61);
            this.CB_Speed_P3.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Speed_P3.Name = "CB_Speed_P3";
            this.CB_Speed_P3.Size = new System.Drawing.Size(58, 22);
            this.CB_Speed_P3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Speed_P3.StyleManager = null;
            this.CB_Speed_P3.Switched = false;
            this.CB_Speed_P3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Speed_P3.TabIndex = 250;
            this.CB_Speed_P3.Text = "metroSwitch3";
            this.CB_Speed_P3.ThemeAuthor = "Taiizor";
            this.CB_Speed_P3.ThemeName = "MetroLight";
            this.CB_Speed_P3.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // CB_Croshair_P3
            // 
            this.CB_Croshair_P3.BackColor = System.Drawing.Color.Transparent;
            this.CB_Croshair_P3.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Croshair_P3.BorderColor = System.Drawing.Color.White;
            this.CB_Croshair_P3.CheckColor = System.Drawing.Color.Red;
            this.CB_Croshair_P3.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Croshair_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Croshair_P3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Croshair_P3.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Croshair_P3.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Croshair_P3.IsDerivedStyle = false;
            this.CB_Croshair_P3.Location = new System.Drawing.Point(919, 141);
            this.CB_Croshair_P3.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Croshair_P3.Name = "CB_Croshair_P3";
            this.CB_Croshair_P3.Size = new System.Drawing.Size(58, 22);
            this.CB_Croshair_P3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Croshair_P3.StyleManager = null;
            this.CB_Croshair_P3.Switched = false;
            this.CB_Croshair_P3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Croshair_P3.TabIndex = 258;
            this.CB_Croshair_P3.Text = "metroSwitch7";
            this.CB_Croshair_P3.ThemeAuthor = "Taiizor";
            this.CB_Croshair_P3.ThemeName = "MetroLight";
            this.CB_Croshair_P3.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // nightHeaderLabel28
            // 
            this.nightHeaderLabel28.AutoSize = true;
            this.nightHeaderLabel28.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel28.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel28.Location = new System.Drawing.Point(593, 61);
            this.nightHeaderLabel28.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel28.Name = "nightHeaderLabel28";
            this.nightHeaderLabel28.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel28.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel28.Size = new System.Drawing.Size(131, 24);
            this.nightHeaderLabel28.TabIndex = 247;
            this.nightHeaderLabel28.Text = "Unlimited Ammo";
            this.nightHeaderLabel28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel28.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel28.UseCompatibleTextRendering = true;
            // 
            // CB_Jail_P3
            // 
            this.CB_Jail_P3.BackColor = System.Drawing.Color.Transparent;
            this.CB_Jail_P3.BackgroundColor = System.Drawing.Color.Empty;
            this.CB_Jail_P3.BorderColor = System.Drawing.Color.White;
            this.CB_Jail_P3.CheckColor = System.Drawing.Color.Red;
            this.CB_Jail_P3.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.CB_Jail_P3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Jail_P3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Jail_P3.DisabledCheckColor = System.Drawing.Color.Maroon;
            this.CB_Jail_P3.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CB_Jail_P3.IsDerivedStyle = false;
            this.CB_Jail_P3.Location = new System.Drawing.Point(919, 101);
            this.CB_Jail_P3.Margin = new System.Windows.Forms.Padding(9);
            this.CB_Jail_P3.Name = "CB_Jail_P3";
            this.CB_Jail_P3.Size = new System.Drawing.Size(58, 22);
            this.CB_Jail_P3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.CB_Jail_P3.StyleManager = null;
            this.CB_Jail_P3.Switched = false;
            this.CB_Jail_P3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.CB_Jail_P3.TabIndex = 254;
            this.CB_Jail_P3.Text = "metroSwitch5";
            this.CB_Jail_P3.ThemeAuthor = "Taiizor";
            this.CB_Jail_P3.ThemeName = "MetroLight";
            this.CB_Jail_P3.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // nightHeaderLabel30
            // 
            this.nightHeaderLabel30.AutoSize = true;
            this.nightHeaderLabel30.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel30.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel30.Location = new System.Drawing.Point(593, 21);
            this.nightHeaderLabel30.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel30.Name = "nightHeaderLabel30";
            this.nightHeaderLabel30.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel30.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel30.Size = new System.Drawing.Size(85, 24);
            this.nightHeaderLabel30.TabIndex = 243;
            this.nightHeaderLabel30.Text = "God Mode";
            this.nightHeaderLabel30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel30.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel30.UseCompatibleTextRendering = true;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.UnlocksTabPage);
            this.guna2TabControl1.Controls.Add(this.ClassesTabPage);
            this.guna2TabControl1.Controls.Add(this.FeaturesTabPage);
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Controls.Add(this.tabPage3);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(83, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 70);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(515, 580);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.Red;
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(83, 40);
            this.guna2TabControl1.TabIndex = 277;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tabPage1.Controls.Add(this.nightHeaderLabel74);
            this.tabPage1.Controls.Add(this.nightHeaderLabel75);
            this.tabPage1.Controls.Add(this.nightHeaderLabel77);
            this.tabPage1.Controls.Add(this.nightHeaderLabel79);
            this.tabPage1.Controls.Add(this.nightHeaderLabel80);
            this.tabPage1.Controls.Add(this.nightHeaderLabel81);
            this.tabPage1.Controls.Add(this.guna2ToggleSwitch24);
            this.tabPage1.Controls.Add(this.guna2ToggleSwitch25);
            this.tabPage1.Controls.Add(this.guna2ToggleSwitch26);
            this.tabPage1.Controls.Add(this.guna2ToggleSwitch27);
            this.tabPage1.Controls.Add(this.guna2ToggleSwitch28);
            this.tabPage1.Controls.Add(this.guna2ToggleSwitch29);
            this.tabPage1.Controls.Add(this.nightHeaderLabel82);
            this.tabPage1.Controls.Add(this.nightHeaderLabel83);
            this.tabPage1.Controls.Add(this.nightHeaderLabel84);
            this.tabPage1.Controls.Add(this.nightHeaderLabel85);
            this.tabPage1.Controls.Add(this.nightHeaderLabel86);
            this.tabPage1.Controls.Add(this.nightHeaderLabel87);
            this.tabPage1.Controls.Add(this.guna2ToggleSwitch30);
            this.tabPage1.Controls.Add(this.guna2ToggleSwitch31);
            this.tabPage1.Controls.Add(this.guna2ToggleSwitch32);
            this.tabPage1.Controls.Add(this.guna2ToggleSwitch33);
            this.tabPage1.Controls.Add(this.guna2ToggleSwitch34);
            this.tabPage1.Controls.Add(this.guna2ToggleSwitch35);
            this.tabPage1.Controls.Add(this.guna2Panel5);
            this.tabPage1.Controls.Add(this.guna2Panel4);
            this.tabPage1.Controls.Add(this.guna2Panel3);
            this.tabPage1.Controls.Add(this.guna2Panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(507, 532);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "P2";
            // 
            // nightHeaderLabel74
            // 
            this.nightHeaderLabel74.AutoSize = true;
            this.nightHeaderLabel74.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel74.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel74.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel74.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel74.Location = new System.Drawing.Point(400, 224);
            this.nightHeaderLabel74.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel74.Name = "nightHeaderLabel74";
            this.nightHeaderLabel74.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel74.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel74.Size = new System.Drawing.Size(40, 24);
            this.nightHeaderLabel74.TabIndex = 331;
            this.nightHeaderLabel74.Text = "TBD";
            this.nightHeaderLabel74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel74.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel74.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel75
            // 
            this.nightHeaderLabel75.AutoSize = true;
            this.nightHeaderLabel75.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel75.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel75.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel75.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel75.Location = new System.Drawing.Point(331, 184);
            this.nightHeaderLabel75.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel75.Name = "nightHeaderLabel75";
            this.nightHeaderLabel75.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel75.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel75.Size = new System.Drawing.Size(109, 24);
            this.nightHeaderLabel75.TabIndex = 330;
            this.nightHeaderLabel75.Text = "Rainbow Gun";
            this.nightHeaderLabel75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel75.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel75.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel77
            // 
            this.nightHeaderLabel77.AutoSize = true;
            this.nightHeaderLabel77.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel77.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel77.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel77.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel77.Location = new System.Drawing.Point(310, 144);
            this.nightHeaderLabel77.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel77.Name = "nightHeaderLabel77";
            this.nightHeaderLabel77.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel77.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel77.Size = new System.Drawing.Size(133, 24);
            this.nightHeaderLabel77.TabIndex = 329;
            this.nightHeaderLabel77.Text = "ZM To Crosshair";
            this.nightHeaderLabel77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel77.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel77.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel79
            // 
            this.nightHeaderLabel79.AutoSize = true;
            this.nightHeaderLabel79.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel79.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel79.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel79.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel79.Location = new System.Drawing.Point(342, 104);
            this.nightHeaderLabel79.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel79.Name = "nightHeaderLabel79";
            this.nightHeaderLabel79.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel79.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel79.Size = new System.Drawing.Size(101, 24);
            this.nightHeaderLabel79.TabIndex = 328;
            this.nightHeaderLabel79.Text = "Send To Jail";
            this.nightHeaderLabel79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel79.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel79.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel80
            // 
            this.nightHeaderLabel80.AutoSize = true;
            this.nightHeaderLabel80.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel80.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel80.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel80.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel80.Location = new System.Drawing.Point(342, 64);
            this.nightHeaderLabel80.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel80.Name = "nightHeaderLabel80";
            this.nightHeaderLabel80.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel80.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel80.Size = new System.Drawing.Size(98, 24);
            this.nightHeaderLabel80.TabIndex = 327;
            this.nightHeaderLabel80.Text = "Speed Hack";
            this.nightHeaderLabel80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel80.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel80.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel81
            // 
            this.nightHeaderLabel81.AutoSize = true;
            this.nightHeaderLabel81.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel81.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel81.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel81.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel81.Location = new System.Drawing.Point(310, 24);
            this.nightHeaderLabel81.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel81.Name = "nightHeaderLabel81";
            this.nightHeaderLabel81.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel81.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel81.Size = new System.Drawing.Size(130, 24);
            this.nightHeaderLabel81.TabIndex = 326;
            this.nightHeaderLabel81.Text = "Unlimited Points";
            this.nightHeaderLabel81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel81.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel81.UseCompatibleTextRendering = true;
            // 
            // guna2ToggleSwitch24
            // 
            this.guna2ToggleSwitch24.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch24.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch24.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch24.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch24.CheckedState.Parent = this.guna2ToggleSwitch24;
            this.guna2ToggleSwitch24.Location = new System.Drawing.Point(452, 64);
            this.guna2ToggleSwitch24.Name = "guna2ToggleSwitch24";
            this.guna2ToggleSwitch24.ShadowDecoration.Parent = this.guna2ToggleSwitch24;
            this.guna2ToggleSwitch24.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch24.TabIndex = 325;
            this.guna2ToggleSwitch24.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch24.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch24.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch24.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch24.UncheckedState.Parent = this.guna2ToggleSwitch24;
            this.guna2ToggleSwitch24.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch24_CheckedChanged);
            // 
            // guna2ToggleSwitch25
            // 
            this.guna2ToggleSwitch25.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch25.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch25.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch25.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch25.CheckedState.Parent = this.guna2ToggleSwitch25;
            this.guna2ToggleSwitch25.Location = new System.Drawing.Point(452, 104);
            this.guna2ToggleSwitch25.Name = "guna2ToggleSwitch25";
            this.guna2ToggleSwitch25.ShadowDecoration.Parent = this.guna2ToggleSwitch25;
            this.guna2ToggleSwitch25.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch25.TabIndex = 324;
            this.guna2ToggleSwitch25.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch25.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch25.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch25.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch25.UncheckedState.Parent = this.guna2ToggleSwitch25;
            // 
            // guna2ToggleSwitch26
            // 
            this.guna2ToggleSwitch26.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch26.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch26.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch26.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch26.CheckedState.Parent = this.guna2ToggleSwitch26;
            this.guna2ToggleSwitch26.Location = new System.Drawing.Point(452, 224);
            this.guna2ToggleSwitch26.Name = "guna2ToggleSwitch26";
            this.guna2ToggleSwitch26.ShadowDecoration.Parent = this.guna2ToggleSwitch26;
            this.guna2ToggleSwitch26.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch26.TabIndex = 323;
            this.guna2ToggleSwitch26.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch26.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch26.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch26.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch26.UncheckedState.Parent = this.guna2ToggleSwitch26;
            // 
            // guna2ToggleSwitch27
            // 
            this.guna2ToggleSwitch27.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch27.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch27.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch27.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch27.CheckedState.Parent = this.guna2ToggleSwitch27;
            this.guna2ToggleSwitch27.Location = new System.Drawing.Point(452, 184);
            this.guna2ToggleSwitch27.Name = "guna2ToggleSwitch27";
            this.guna2ToggleSwitch27.ShadowDecoration.Parent = this.guna2ToggleSwitch27;
            this.guna2ToggleSwitch27.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch27.TabIndex = 322;
            this.guna2ToggleSwitch27.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch27.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch27.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch27.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch27.UncheckedState.Parent = this.guna2ToggleSwitch27;
            // 
            // guna2ToggleSwitch28
            // 
            this.guna2ToggleSwitch28.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch28.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch28.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch28.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch28.CheckedState.Parent = this.guna2ToggleSwitch28;
            this.guna2ToggleSwitch28.Location = new System.Drawing.Point(452, 143);
            this.guna2ToggleSwitch28.Name = "guna2ToggleSwitch28";
            this.guna2ToggleSwitch28.ShadowDecoration.Parent = this.guna2ToggleSwitch28;
            this.guna2ToggleSwitch28.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch28.TabIndex = 321;
            this.guna2ToggleSwitch28.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch28.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch28.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch28.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch28.UncheckedState.Parent = this.guna2ToggleSwitch28;
            // 
            // guna2ToggleSwitch29
            // 
            this.guna2ToggleSwitch29.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch29.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch29.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch29.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch29.CheckedState.Parent = this.guna2ToggleSwitch29;
            this.guna2ToggleSwitch29.Location = new System.Drawing.Point(452, 24);
            this.guna2ToggleSwitch29.Name = "guna2ToggleSwitch29";
            this.guna2ToggleSwitch29.ShadowDecoration.Parent = this.guna2ToggleSwitch29;
            this.guna2ToggleSwitch29.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch29.TabIndex = 320;
            this.guna2ToggleSwitch29.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch29.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch29.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch29.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch29.UncheckedState.Parent = this.guna2ToggleSwitch29;
            // 
            // nightHeaderLabel82
            // 
            this.nightHeaderLabel82.AutoSize = true;
            this.nightHeaderLabel82.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel82.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel82.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel82.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel82.Location = new System.Drawing.Point(78, 224);
            this.nightHeaderLabel82.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel82.Name = "nightHeaderLabel82";
            this.nightHeaderLabel82.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel82.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel82.Size = new System.Drawing.Size(90, 24);
            this.nightHeaderLabel82.TabIndex = 319;
            this.nightHeaderLabel82.Text = "Auto Shoot";
            this.nightHeaderLabel82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel82.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel82.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel83
            // 
            this.nightHeaderLabel83.AutoSize = true;
            this.nightHeaderLabel83.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel83.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel83.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel83.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel83.Location = new System.Drawing.Point(78, 184);
            this.nightHeaderLabel83.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel83.Name = "nightHeaderLabel83";
            this.nightHeaderLabel83.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel83.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel83.Size = new System.Drawing.Size(117, 24);
            this.nightHeaderLabel83.TabIndex = 318;
            this.nightHeaderLabel83.Text = "Weapon Cycle";
            this.nightHeaderLabel83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel83.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel83.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel84
            // 
            this.nightHeaderLabel84.AutoSize = true;
            this.nightHeaderLabel84.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel84.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel84.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel84.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel84.Location = new System.Drawing.Point(78, 144);
            this.nightHeaderLabel84.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel84.Name = "nightHeaderLabel84";
            this.nightHeaderLabel84.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel84.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel84.Size = new System.Drawing.Size(85, 24);
            this.nightHeaderLabel84.TabIndex = 317;
            this.nightHeaderLabel84.Text = "Rapid Fire";
            this.nightHeaderLabel84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel84.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel84.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel85
            // 
            this.nightHeaderLabel85.AutoSize = true;
            this.nightHeaderLabel85.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel85.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel85.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel85.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel85.Location = new System.Drawing.Point(78, 104);
            this.nightHeaderLabel85.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel85.Name = "nightHeaderLabel85";
            this.nightHeaderLabel85.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel85.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel85.Size = new System.Drawing.Size(116, 24);
            this.nightHeaderLabel85.TabIndex = 316;
            this.nightHeaderLabel85.Text = "100% Criticals";
            this.nightHeaderLabel85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel85.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel85.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel86
            // 
            this.nightHeaderLabel86.AutoSize = true;
            this.nightHeaderLabel86.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel86.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel86.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel86.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel86.Location = new System.Drawing.Point(78, 64);
            this.nightHeaderLabel86.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel86.Name = "nightHeaderLabel86";
            this.nightHeaderLabel86.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel86.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel86.Size = new System.Drawing.Size(131, 24);
            this.nightHeaderLabel86.TabIndex = 315;
            this.nightHeaderLabel86.Text = "Unlimited Ammo";
            this.nightHeaderLabel86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel86.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel86.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel87
            // 
            this.nightHeaderLabel87.AutoSize = true;
            this.nightHeaderLabel87.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel87.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel87.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel87.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel87.Location = new System.Drawing.Point(78, 24);
            this.nightHeaderLabel87.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel87.Name = "nightHeaderLabel87";
            this.nightHeaderLabel87.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel87.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel87.Size = new System.Drawing.Size(85, 24);
            this.nightHeaderLabel87.TabIndex = 314;
            this.nightHeaderLabel87.Text = "God Mode";
            this.nightHeaderLabel87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel87.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel87.UseCompatibleTextRendering = true;
            // 
            // guna2ToggleSwitch30
            // 
            this.guna2ToggleSwitch30.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch30.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch30.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch30.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch30.CheckedState.Parent = this.guna2ToggleSwitch30;
            this.guna2ToggleSwitch30.Location = new System.Drawing.Point(30, 64);
            this.guna2ToggleSwitch30.Name = "guna2ToggleSwitch30";
            this.guna2ToggleSwitch30.ShadowDecoration.Parent = this.guna2ToggleSwitch30;
            this.guna2ToggleSwitch30.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch30.TabIndex = 313;
            this.guna2ToggleSwitch30.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch30.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch30.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch30.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch30.UncheckedState.Parent = this.guna2ToggleSwitch30;
            // 
            // guna2ToggleSwitch31
            // 
            this.guna2ToggleSwitch31.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch31.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch31.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch31.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch31.CheckedState.Parent = this.guna2ToggleSwitch31;
            this.guna2ToggleSwitch31.Location = new System.Drawing.Point(30, 104);
            this.guna2ToggleSwitch31.Name = "guna2ToggleSwitch31";
            this.guna2ToggleSwitch31.ShadowDecoration.Parent = this.guna2ToggleSwitch31;
            this.guna2ToggleSwitch31.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch31.TabIndex = 312;
            this.guna2ToggleSwitch31.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch31.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch31.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch31.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch31.UncheckedState.Parent = this.guna2ToggleSwitch31;
            // 
            // guna2ToggleSwitch32
            // 
            this.guna2ToggleSwitch32.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch32.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch32.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch32.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch32.CheckedState.Parent = this.guna2ToggleSwitch32;
            this.guna2ToggleSwitch32.Location = new System.Drawing.Point(30, 224);
            this.guna2ToggleSwitch32.Name = "guna2ToggleSwitch32";
            this.guna2ToggleSwitch32.ShadowDecoration.Parent = this.guna2ToggleSwitch32;
            this.guna2ToggleSwitch32.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch32.TabIndex = 311;
            this.guna2ToggleSwitch32.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch32.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch32.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch32.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch32.UncheckedState.Parent = this.guna2ToggleSwitch32;
            // 
            // guna2ToggleSwitch33
            // 
            this.guna2ToggleSwitch33.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch33.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch33.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch33.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch33.CheckedState.Parent = this.guna2ToggleSwitch33;
            this.guna2ToggleSwitch33.Location = new System.Drawing.Point(30, 184);
            this.guna2ToggleSwitch33.Name = "guna2ToggleSwitch33";
            this.guna2ToggleSwitch33.ShadowDecoration.Parent = this.guna2ToggleSwitch33;
            this.guna2ToggleSwitch33.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch33.TabIndex = 310;
            this.guna2ToggleSwitch33.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch33.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch33.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch33.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch33.UncheckedState.Parent = this.guna2ToggleSwitch33;
            // 
            // guna2ToggleSwitch34
            // 
            this.guna2ToggleSwitch34.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch34.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch34.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch34.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch34.CheckedState.Parent = this.guna2ToggleSwitch34;
            this.guna2ToggleSwitch34.Location = new System.Drawing.Point(30, 143);
            this.guna2ToggleSwitch34.Name = "guna2ToggleSwitch34";
            this.guna2ToggleSwitch34.ShadowDecoration.Parent = this.guna2ToggleSwitch34;
            this.guna2ToggleSwitch34.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch34.TabIndex = 309;
            this.guna2ToggleSwitch34.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch34.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch34.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch34.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch34.UncheckedState.Parent = this.guna2ToggleSwitch34;
            this.guna2ToggleSwitch34.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch34_CheckedChanged);
            // 
            // guna2ToggleSwitch35
            // 
            this.guna2ToggleSwitch35.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch35.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch35.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch35.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch35.CheckedState.Parent = this.guna2ToggleSwitch35;
            this.guna2ToggleSwitch35.Location = new System.Drawing.Point(30, 24);
            this.guna2ToggleSwitch35.Name = "guna2ToggleSwitch35";
            this.guna2ToggleSwitch35.ShadowDecoration.Parent = this.guna2ToggleSwitch35;
            this.guna2ToggleSwitch35.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch35.TabIndex = 308;
            this.guna2ToggleSwitch35.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch35.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch35.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch35.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch35.UncheckedState.Parent = this.guna2ToggleSwitch35;
            this.guna2ToggleSwitch35.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch35_CheckedChanged);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Red;
            this.guna2Panel5.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel5.BorderThickness = 2;
            this.guna2Panel5.Location = new System.Drawing.Point(-3, 523);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(543, 10);
            this.guna2Panel5.TabIndex = 292;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Red;
            this.guna2Panel4.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Location = new System.Drawing.Point(-2, 1);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(10, 531);
            this.guna2Panel4.TabIndex = 291;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Red;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Location = new System.Drawing.Point(497, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(10, 531);
            this.guna2Panel3.TabIndex = 290;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Red;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(543, 10);
            this.guna2Panel2.TabIndex = 289;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tabPage2.Controls.Add(this.nightHeaderLabel88);
            this.tabPage2.Controls.Add(this.nightHeaderLabel89);
            this.tabPage2.Controls.Add(this.nightHeaderLabel90);
            this.tabPage2.Controls.Add(this.nightHeaderLabel91);
            this.tabPage2.Controls.Add(this.nightHeaderLabel92);
            this.tabPage2.Controls.Add(this.nightHeaderLabel93);
            this.tabPage2.Controls.Add(this.guna2ToggleSwitch37);
            this.tabPage2.Controls.Add(this.guna2ToggleSwitch38);
            this.tabPage2.Controls.Add(this.guna2ToggleSwitch39);
            this.tabPage2.Controls.Add(this.guna2ToggleSwitch40);
            this.tabPage2.Controls.Add(this.guna2ToggleSwitch41);
            this.tabPage2.Controls.Add(this.guna2ToggleSwitch42);
            this.tabPage2.Controls.Add(this.nightHeaderLabel94);
            this.tabPage2.Controls.Add(this.nightHeaderLabel95);
            this.tabPage2.Controls.Add(this.nightHeaderLabel96);
            this.tabPage2.Controls.Add(this.nightHeaderLabel97);
            this.tabPage2.Controls.Add(this.nightHeaderLabel98);
            this.tabPage2.Controls.Add(this.nightHeaderLabel99);
            this.tabPage2.Controls.Add(this.guna2ToggleSwitch43);
            this.tabPage2.Controls.Add(this.guna2ToggleSwitch44);
            this.tabPage2.Controls.Add(this.guna2ToggleSwitch45);
            this.tabPage2.Controls.Add(this.guna2ToggleSwitch46);
            this.tabPage2.Controls.Add(this.guna2ToggleSwitch47);
            this.tabPage2.Controls.Add(this.guna2ToggleSwitch48);
            this.tabPage2.Controls.Add(this.guna2Panel8);
            this.tabPage2.Controls.Add(this.guna2Panel10);
            this.tabPage2.Controls.Add(this.guna2Panel7);
            this.tabPage2.Controls.Add(this.guna2Panel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(507, 532);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "P3";
            // 
            // nightHeaderLabel88
            // 
            this.nightHeaderLabel88.AutoSize = true;
            this.nightHeaderLabel88.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel88.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel88.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel88.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel88.Location = new System.Drawing.Point(403, 224);
            this.nightHeaderLabel88.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel88.Name = "nightHeaderLabel88";
            this.nightHeaderLabel88.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel88.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel88.Size = new System.Drawing.Size(40, 24);
            this.nightHeaderLabel88.TabIndex = 331;
            this.nightHeaderLabel88.Text = "TBD";
            this.nightHeaderLabel88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel88.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel88.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel89
            // 
            this.nightHeaderLabel89.AutoSize = true;
            this.nightHeaderLabel89.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel89.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel89.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel89.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel89.Location = new System.Drawing.Point(334, 184);
            this.nightHeaderLabel89.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel89.Name = "nightHeaderLabel89";
            this.nightHeaderLabel89.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel89.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel89.Size = new System.Drawing.Size(109, 24);
            this.nightHeaderLabel89.TabIndex = 330;
            this.nightHeaderLabel89.Text = "Rainbow Gun";
            this.nightHeaderLabel89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel89.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel89.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel90
            // 
            this.nightHeaderLabel90.AutoSize = true;
            this.nightHeaderLabel90.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel90.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel90.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel90.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel90.Location = new System.Drawing.Point(313, 144);
            this.nightHeaderLabel90.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel90.Name = "nightHeaderLabel90";
            this.nightHeaderLabel90.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel90.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel90.Size = new System.Drawing.Size(133, 24);
            this.nightHeaderLabel90.TabIndex = 329;
            this.nightHeaderLabel90.Text = "ZM To Crosshair";
            this.nightHeaderLabel90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel90.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel90.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel91
            // 
            this.nightHeaderLabel91.AutoSize = true;
            this.nightHeaderLabel91.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel91.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel91.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel91.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel91.Location = new System.Drawing.Point(345, 104);
            this.nightHeaderLabel91.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel91.Name = "nightHeaderLabel91";
            this.nightHeaderLabel91.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel91.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel91.Size = new System.Drawing.Size(101, 24);
            this.nightHeaderLabel91.TabIndex = 328;
            this.nightHeaderLabel91.Text = "Send To Jail";
            this.nightHeaderLabel91.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel91.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel91.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel92
            // 
            this.nightHeaderLabel92.AutoSize = true;
            this.nightHeaderLabel92.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel92.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel92.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel92.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel92.Location = new System.Drawing.Point(345, 64);
            this.nightHeaderLabel92.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel92.Name = "nightHeaderLabel92";
            this.nightHeaderLabel92.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel92.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel92.Size = new System.Drawing.Size(98, 24);
            this.nightHeaderLabel92.TabIndex = 327;
            this.nightHeaderLabel92.Text = "Speed Hack";
            this.nightHeaderLabel92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel92.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel92.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel93
            // 
            this.nightHeaderLabel93.AutoSize = true;
            this.nightHeaderLabel93.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel93.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel93.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel93.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel93.Location = new System.Drawing.Point(313, 24);
            this.nightHeaderLabel93.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel93.Name = "nightHeaderLabel93";
            this.nightHeaderLabel93.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel93.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel93.Size = new System.Drawing.Size(130, 24);
            this.nightHeaderLabel93.TabIndex = 326;
            this.nightHeaderLabel93.Text = "Unlimited Points";
            this.nightHeaderLabel93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel93.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel93.UseCompatibleTextRendering = true;
            // 
            // guna2ToggleSwitch37
            // 
            this.guna2ToggleSwitch37.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch37.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch37.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch37.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch37.CheckedState.Parent = this.guna2ToggleSwitch37;
            this.guna2ToggleSwitch37.Location = new System.Drawing.Point(455, 64);
            this.guna2ToggleSwitch37.Name = "guna2ToggleSwitch37";
            this.guna2ToggleSwitch37.ShadowDecoration.Parent = this.guna2ToggleSwitch37;
            this.guna2ToggleSwitch37.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch37.TabIndex = 325;
            this.guna2ToggleSwitch37.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch37.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch37.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch37.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch37.UncheckedState.Parent = this.guna2ToggleSwitch37;
            this.guna2ToggleSwitch37.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch37_CheckedChanged);
            // 
            // guna2ToggleSwitch38
            // 
            this.guna2ToggleSwitch38.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch38.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch38.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch38.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch38.CheckedState.Parent = this.guna2ToggleSwitch38;
            this.guna2ToggleSwitch38.Location = new System.Drawing.Point(455, 104);
            this.guna2ToggleSwitch38.Name = "guna2ToggleSwitch38";
            this.guna2ToggleSwitch38.ShadowDecoration.Parent = this.guna2ToggleSwitch38;
            this.guna2ToggleSwitch38.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch38.TabIndex = 324;
            this.guna2ToggleSwitch38.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch38.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch38.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch38.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch38.UncheckedState.Parent = this.guna2ToggleSwitch38;
            // 
            // guna2ToggleSwitch39
            // 
            this.guna2ToggleSwitch39.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch39.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch39.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch39.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch39.CheckedState.Parent = this.guna2ToggleSwitch39;
            this.guna2ToggleSwitch39.Location = new System.Drawing.Point(455, 224);
            this.guna2ToggleSwitch39.Name = "guna2ToggleSwitch39";
            this.guna2ToggleSwitch39.ShadowDecoration.Parent = this.guna2ToggleSwitch39;
            this.guna2ToggleSwitch39.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch39.TabIndex = 323;
            this.guna2ToggleSwitch39.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch39.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch39.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch39.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch39.UncheckedState.Parent = this.guna2ToggleSwitch39;
            // 
            // guna2ToggleSwitch40
            // 
            this.guna2ToggleSwitch40.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch40.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch40.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch40.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch40.CheckedState.Parent = this.guna2ToggleSwitch40;
            this.guna2ToggleSwitch40.Location = new System.Drawing.Point(455, 184);
            this.guna2ToggleSwitch40.Name = "guna2ToggleSwitch40";
            this.guna2ToggleSwitch40.ShadowDecoration.Parent = this.guna2ToggleSwitch40;
            this.guna2ToggleSwitch40.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch40.TabIndex = 322;
            this.guna2ToggleSwitch40.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch40.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch40.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch40.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch40.UncheckedState.Parent = this.guna2ToggleSwitch40;
            // 
            // guna2ToggleSwitch41
            // 
            this.guna2ToggleSwitch41.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch41.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch41.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch41.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch41.CheckedState.Parent = this.guna2ToggleSwitch41;
            this.guna2ToggleSwitch41.Location = new System.Drawing.Point(455, 143);
            this.guna2ToggleSwitch41.Name = "guna2ToggleSwitch41";
            this.guna2ToggleSwitch41.ShadowDecoration.Parent = this.guna2ToggleSwitch41;
            this.guna2ToggleSwitch41.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch41.TabIndex = 321;
            this.guna2ToggleSwitch41.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch41.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch41.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch41.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch41.UncheckedState.Parent = this.guna2ToggleSwitch41;
            // 
            // guna2ToggleSwitch42
            // 
            this.guna2ToggleSwitch42.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch42.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch42.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch42.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch42.CheckedState.Parent = this.guna2ToggleSwitch42;
            this.guna2ToggleSwitch42.Location = new System.Drawing.Point(455, 24);
            this.guna2ToggleSwitch42.Name = "guna2ToggleSwitch42";
            this.guna2ToggleSwitch42.ShadowDecoration.Parent = this.guna2ToggleSwitch42;
            this.guna2ToggleSwitch42.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch42.TabIndex = 320;
            this.guna2ToggleSwitch42.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch42.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch42.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch42.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch42.UncheckedState.Parent = this.guna2ToggleSwitch42;
            // 
            // nightHeaderLabel94
            // 
            this.nightHeaderLabel94.AutoSize = true;
            this.nightHeaderLabel94.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel94.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel94.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel94.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel94.Location = new System.Drawing.Point(81, 224);
            this.nightHeaderLabel94.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel94.Name = "nightHeaderLabel94";
            this.nightHeaderLabel94.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel94.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel94.Size = new System.Drawing.Size(90, 24);
            this.nightHeaderLabel94.TabIndex = 319;
            this.nightHeaderLabel94.Text = "Auto Shoot";
            this.nightHeaderLabel94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel94.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel94.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel95
            // 
            this.nightHeaderLabel95.AutoSize = true;
            this.nightHeaderLabel95.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel95.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel95.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel95.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel95.Location = new System.Drawing.Point(81, 184);
            this.nightHeaderLabel95.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel95.Name = "nightHeaderLabel95";
            this.nightHeaderLabel95.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel95.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel95.Size = new System.Drawing.Size(117, 24);
            this.nightHeaderLabel95.TabIndex = 318;
            this.nightHeaderLabel95.Text = "Weapon Cycle";
            this.nightHeaderLabel95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel95.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel95.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel96
            // 
            this.nightHeaderLabel96.AutoSize = true;
            this.nightHeaderLabel96.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel96.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel96.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel96.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel96.Location = new System.Drawing.Point(81, 144);
            this.nightHeaderLabel96.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel96.Name = "nightHeaderLabel96";
            this.nightHeaderLabel96.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel96.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel96.Size = new System.Drawing.Size(85, 24);
            this.nightHeaderLabel96.TabIndex = 317;
            this.nightHeaderLabel96.Text = "Rapid Fire";
            this.nightHeaderLabel96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel96.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel96.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel97
            // 
            this.nightHeaderLabel97.AutoSize = true;
            this.nightHeaderLabel97.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel97.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel97.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel97.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel97.Location = new System.Drawing.Point(81, 104);
            this.nightHeaderLabel97.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel97.Name = "nightHeaderLabel97";
            this.nightHeaderLabel97.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel97.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel97.Size = new System.Drawing.Size(116, 24);
            this.nightHeaderLabel97.TabIndex = 316;
            this.nightHeaderLabel97.Text = "100% Criticals";
            this.nightHeaderLabel97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel97.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel97.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel98
            // 
            this.nightHeaderLabel98.AutoSize = true;
            this.nightHeaderLabel98.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel98.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel98.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel98.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel98.Location = new System.Drawing.Point(81, 64);
            this.nightHeaderLabel98.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel98.Name = "nightHeaderLabel98";
            this.nightHeaderLabel98.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel98.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel98.Size = new System.Drawing.Size(131, 24);
            this.nightHeaderLabel98.TabIndex = 315;
            this.nightHeaderLabel98.Text = "Unlimited Ammo";
            this.nightHeaderLabel98.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel98.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel98.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel99
            // 
            this.nightHeaderLabel99.AutoSize = true;
            this.nightHeaderLabel99.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel99.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel99.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel99.Location = new System.Drawing.Point(81, 24);
            this.nightHeaderLabel99.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel99.Name = "nightHeaderLabel99";
            this.nightHeaderLabel99.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel99.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel99.Size = new System.Drawing.Size(85, 24);
            this.nightHeaderLabel99.TabIndex = 314;
            this.nightHeaderLabel99.Text = "God Mode";
            this.nightHeaderLabel99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel99.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel99.UseCompatibleTextRendering = true;
            // 
            // guna2ToggleSwitch43
            // 
            this.guna2ToggleSwitch43.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch43.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch43.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch43.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch43.CheckedState.Parent = this.guna2ToggleSwitch43;
            this.guna2ToggleSwitch43.Location = new System.Drawing.Point(33, 64);
            this.guna2ToggleSwitch43.Name = "guna2ToggleSwitch43";
            this.guna2ToggleSwitch43.ShadowDecoration.Parent = this.guna2ToggleSwitch43;
            this.guna2ToggleSwitch43.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch43.TabIndex = 313;
            this.guna2ToggleSwitch43.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch43.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch43.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch43.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch43.UncheckedState.Parent = this.guna2ToggleSwitch43;
            // 
            // guna2ToggleSwitch44
            // 
            this.guna2ToggleSwitch44.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch44.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch44.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch44.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch44.CheckedState.Parent = this.guna2ToggleSwitch44;
            this.guna2ToggleSwitch44.Location = new System.Drawing.Point(33, 104);
            this.guna2ToggleSwitch44.Name = "guna2ToggleSwitch44";
            this.guna2ToggleSwitch44.ShadowDecoration.Parent = this.guna2ToggleSwitch44;
            this.guna2ToggleSwitch44.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch44.TabIndex = 312;
            this.guna2ToggleSwitch44.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch44.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch44.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch44.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch44.UncheckedState.Parent = this.guna2ToggleSwitch44;
            // 
            // guna2ToggleSwitch45
            // 
            this.guna2ToggleSwitch45.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch45.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch45.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch45.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch45.CheckedState.Parent = this.guna2ToggleSwitch45;
            this.guna2ToggleSwitch45.Location = new System.Drawing.Point(33, 224);
            this.guna2ToggleSwitch45.Name = "guna2ToggleSwitch45";
            this.guna2ToggleSwitch45.ShadowDecoration.Parent = this.guna2ToggleSwitch45;
            this.guna2ToggleSwitch45.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch45.TabIndex = 311;
            this.guna2ToggleSwitch45.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch45.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch45.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch45.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch45.UncheckedState.Parent = this.guna2ToggleSwitch45;
            // 
            // guna2ToggleSwitch46
            // 
            this.guna2ToggleSwitch46.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch46.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch46.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch46.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch46.CheckedState.Parent = this.guna2ToggleSwitch46;
            this.guna2ToggleSwitch46.Location = new System.Drawing.Point(33, 184);
            this.guna2ToggleSwitch46.Name = "guna2ToggleSwitch46";
            this.guna2ToggleSwitch46.ShadowDecoration.Parent = this.guna2ToggleSwitch46;
            this.guna2ToggleSwitch46.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch46.TabIndex = 310;
            this.guna2ToggleSwitch46.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch46.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch46.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch46.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch46.UncheckedState.Parent = this.guna2ToggleSwitch46;
            // 
            // guna2ToggleSwitch47
            // 
            this.guna2ToggleSwitch47.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch47.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch47.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch47.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch47.CheckedState.Parent = this.guna2ToggleSwitch47;
            this.guna2ToggleSwitch47.Location = new System.Drawing.Point(33, 143);
            this.guna2ToggleSwitch47.Name = "guna2ToggleSwitch47";
            this.guna2ToggleSwitch47.ShadowDecoration.Parent = this.guna2ToggleSwitch47;
            this.guna2ToggleSwitch47.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch47.TabIndex = 309;
            this.guna2ToggleSwitch47.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch47.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch47.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch47.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch47.UncheckedState.Parent = this.guna2ToggleSwitch47;
            this.guna2ToggleSwitch47.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch47_CheckedChanged);
            // 
            // guna2ToggleSwitch48
            // 
            this.guna2ToggleSwitch48.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch48.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch48.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch48.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch48.CheckedState.Parent = this.guna2ToggleSwitch48;
            this.guna2ToggleSwitch48.Location = new System.Drawing.Point(33, 24);
            this.guna2ToggleSwitch48.Name = "guna2ToggleSwitch48";
            this.guna2ToggleSwitch48.ShadowDecoration.Parent = this.guna2ToggleSwitch48;
            this.guna2ToggleSwitch48.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch48.TabIndex = 308;
            this.guna2ToggleSwitch48.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch48.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch48.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch48.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch48.UncheckedState.Parent = this.guna2ToggleSwitch48;
            this.guna2ToggleSwitch48.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch48_CheckedChanged);
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.Red;
            this.guna2Panel8.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel8.BorderThickness = 2;
            this.guna2Panel8.Controls.Add(this.guna2Panel9);
            this.guna2Panel8.Location = new System.Drawing.Point(-2, -2);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.ShadowDecoration.Parent = this.guna2Panel8;
            this.guna2Panel8.Size = new System.Drawing.Size(11, 523);
            this.guna2Panel8.TabIndex = 227;
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BackColor = System.Drawing.Color.Red;
            this.guna2Panel9.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel9.BorderThickness = 2;
            this.guna2Panel9.Location = new System.Drawing.Point(-20, 0);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.ShadowDecoration.Parent = this.guna2Panel9;
            this.guna2Panel9.Size = new System.Drawing.Size(10, 284);
            this.guna2Panel9.TabIndex = 213;
            // 
            // guna2Panel10
            // 
            this.guna2Panel10.BackColor = System.Drawing.Color.Red;
            this.guna2Panel10.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel10.BorderThickness = 2;
            this.guna2Panel10.Controls.Add(this.guna2Panel11);
            this.guna2Panel10.Location = new System.Drawing.Point(498, -2);
            this.guna2Panel10.Name = "guna2Panel10";
            this.guna2Panel10.ShadowDecoration.Parent = this.guna2Panel10;
            this.guna2Panel10.Size = new System.Drawing.Size(11, 523);
            this.guna2Panel10.TabIndex = 224;
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.BackColor = System.Drawing.Color.Red;
            this.guna2Panel11.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel11.BorderThickness = 2;
            this.guna2Panel11.Location = new System.Drawing.Point(-20, 0);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.ShadowDecoration.Parent = this.guna2Panel11;
            this.guna2Panel11.Size = new System.Drawing.Size(10, 284);
            this.guna2Panel11.TabIndex = 213;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.Red;
            this.guna2Panel7.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel7.BorderThickness = 2;
            this.guna2Panel7.Location = new System.Drawing.Point(0, 522);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.ShadowDecoration.Parent = this.guna2Panel7;
            this.guna2Panel7.Size = new System.Drawing.Size(760, 10);
            this.guna2Panel7.TabIndex = 226;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Red;
            this.guna2Panel6.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel6.BorderThickness = 2;
            this.guna2Panel6.Location = new System.Drawing.Point(3, -1);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.ShadowDecoration.Parent = this.guna2Panel6;
            this.guna2Panel6.Size = new System.Drawing.Size(760, 10);
            this.guna2Panel6.TabIndex = 225;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tabPage3.Controls.Add(this.guna2Panel17);
            this.tabPage3.Controls.Add(this.guna2Panel15);
            this.tabPage3.Controls.Add(this.guna2Panel14);
            this.tabPage3.Controls.Add(this.guna2Panel12);
            this.tabPage3.Controls.Add(this.nightHeaderLabel100);
            this.tabPage3.Controls.Add(this.nightHeaderLabel101);
            this.tabPage3.Controls.Add(this.nightHeaderLabel102);
            this.tabPage3.Controls.Add(this.nightHeaderLabel103);
            this.tabPage3.Controls.Add(this.nightHeaderLabel104);
            this.tabPage3.Controls.Add(this.nightHeaderLabel105);
            this.tabPage3.Controls.Add(this.guna2ToggleSwitch49);
            this.tabPage3.Controls.Add(this.guna2ToggleSwitch50);
            this.tabPage3.Controls.Add(this.guna2ToggleSwitch51);
            this.tabPage3.Controls.Add(this.guna2ToggleSwitch52);
            this.tabPage3.Controls.Add(this.guna2ToggleSwitch53);
            this.tabPage3.Controls.Add(this.guna2ToggleSwitch54);
            this.tabPage3.Controls.Add(this.nightHeaderLabel106);
            this.tabPage3.Controls.Add(this.nightHeaderLabel107);
            this.tabPage3.Controls.Add(this.nightHeaderLabel108);
            this.tabPage3.Controls.Add(this.nightHeaderLabel109);
            this.tabPage3.Controls.Add(this.nightHeaderLabel110);
            this.tabPage3.Controls.Add(this.nightHeaderLabel111);
            this.tabPage3.Controls.Add(this.guna2ToggleSwitch55);
            this.tabPage3.Controls.Add(this.guna2ToggleSwitch56);
            this.tabPage3.Controls.Add(this.guna2ToggleSwitch57);
            this.tabPage3.Controls.Add(this.guna2ToggleSwitch58);
            this.tabPage3.Controls.Add(this.guna2ToggleSwitch59);
            this.tabPage3.Controls.Add(this.guna2ToggleSwitch60);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(507, 532);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "P4";
            // 
            // guna2Panel17
            // 
            this.guna2Panel17.BackColor = System.Drawing.Color.Red;
            this.guna2Panel17.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel17.BorderThickness = 2;
            this.guna2Panel17.Controls.Add(this.guna2Panel18);
            this.guna2Panel17.Location = new System.Drawing.Point(497, 0);
            this.guna2Panel17.Name = "guna2Panel17";
            this.guna2Panel17.ShadowDecoration.Parent = this.guna2Panel17;
            this.guna2Panel17.Size = new System.Drawing.Size(11, 533);
            this.guna2Panel17.TabIndex = 335;
            // 
            // guna2Panel18
            // 
            this.guna2Panel18.BackColor = System.Drawing.Color.Red;
            this.guna2Panel18.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel18.BorderThickness = 2;
            this.guna2Panel18.Location = new System.Drawing.Point(-20, 0);
            this.guna2Panel18.Name = "guna2Panel18";
            this.guna2Panel18.ShadowDecoration.Parent = this.guna2Panel18;
            this.guna2Panel18.Size = new System.Drawing.Size(10, 284);
            this.guna2Panel18.TabIndex = 213;
            // 
            // guna2Panel15
            // 
            this.guna2Panel15.BackColor = System.Drawing.Color.Red;
            this.guna2Panel15.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel15.BorderThickness = 2;
            this.guna2Panel15.Controls.Add(this.guna2Panel16);
            this.guna2Panel15.Location = new System.Drawing.Point(0, -1);
            this.guna2Panel15.Name = "guna2Panel15";
            this.guna2Panel15.ShadowDecoration.Parent = this.guna2Panel15;
            this.guna2Panel15.Size = new System.Drawing.Size(11, 533);
            this.guna2Panel15.TabIndex = 334;
            // 
            // guna2Panel16
            // 
            this.guna2Panel16.BackColor = System.Drawing.Color.Red;
            this.guna2Panel16.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel16.BorderThickness = 2;
            this.guna2Panel16.Location = new System.Drawing.Point(-20, 0);
            this.guna2Panel16.Name = "guna2Panel16";
            this.guna2Panel16.ShadowDecoration.Parent = this.guna2Panel16;
            this.guna2Panel16.Size = new System.Drawing.Size(10, 284);
            this.guna2Panel16.TabIndex = 213;
            // 
            // guna2Panel14
            // 
            this.guna2Panel14.BackColor = System.Drawing.Color.Red;
            this.guna2Panel14.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel14.BorderThickness = 2;
            this.guna2Panel14.Location = new System.Drawing.Point(1, 0);
            this.guna2Panel14.Name = "guna2Panel14";
            this.guna2Panel14.ShadowDecoration.Parent = this.guna2Panel14;
            this.guna2Panel14.Size = new System.Drawing.Size(563, 10);
            this.guna2Panel14.TabIndex = 333;
            // 
            // guna2Panel12
            // 
            this.guna2Panel12.BackColor = System.Drawing.Color.Red;
            this.guna2Panel12.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel12.BorderThickness = 2;
            this.guna2Panel12.Location = new System.Drawing.Point(-5, 523);
            this.guna2Panel12.Name = "guna2Panel12";
            this.guna2Panel12.ShadowDecoration.Parent = this.guna2Panel12;
            this.guna2Panel12.Size = new System.Drawing.Size(760, 10);
            this.guna2Panel12.TabIndex = 332;
            // 
            // nightHeaderLabel100
            // 
            this.nightHeaderLabel100.AutoSize = true;
            this.nightHeaderLabel100.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel100.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel100.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel100.Location = new System.Drawing.Point(403, 222);
            this.nightHeaderLabel100.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel100.Name = "nightHeaderLabel100";
            this.nightHeaderLabel100.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel100.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel100.Size = new System.Drawing.Size(40, 24);
            this.nightHeaderLabel100.TabIndex = 331;
            this.nightHeaderLabel100.Text = "TBD";
            this.nightHeaderLabel100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel100.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel100.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel101
            // 
            this.nightHeaderLabel101.AutoSize = true;
            this.nightHeaderLabel101.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel101.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel101.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel101.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel101.Location = new System.Drawing.Point(334, 182);
            this.nightHeaderLabel101.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel101.Name = "nightHeaderLabel101";
            this.nightHeaderLabel101.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel101.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel101.Size = new System.Drawing.Size(109, 24);
            this.nightHeaderLabel101.TabIndex = 330;
            this.nightHeaderLabel101.Text = "Rainbow Gun";
            this.nightHeaderLabel101.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel101.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel101.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel102
            // 
            this.nightHeaderLabel102.AutoSize = true;
            this.nightHeaderLabel102.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel102.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel102.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel102.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel102.Location = new System.Drawing.Point(313, 142);
            this.nightHeaderLabel102.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel102.Name = "nightHeaderLabel102";
            this.nightHeaderLabel102.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel102.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel102.Size = new System.Drawing.Size(133, 24);
            this.nightHeaderLabel102.TabIndex = 329;
            this.nightHeaderLabel102.Text = "ZM To Crosshair";
            this.nightHeaderLabel102.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel102.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel102.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel103
            // 
            this.nightHeaderLabel103.AutoSize = true;
            this.nightHeaderLabel103.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel103.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel103.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel103.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel103.Location = new System.Drawing.Point(345, 102);
            this.nightHeaderLabel103.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel103.Name = "nightHeaderLabel103";
            this.nightHeaderLabel103.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel103.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel103.Size = new System.Drawing.Size(101, 24);
            this.nightHeaderLabel103.TabIndex = 328;
            this.nightHeaderLabel103.Text = "Send To Jail";
            this.nightHeaderLabel103.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel103.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel103.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel104
            // 
            this.nightHeaderLabel104.AutoSize = true;
            this.nightHeaderLabel104.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel104.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel104.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel104.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel104.Location = new System.Drawing.Point(345, 62);
            this.nightHeaderLabel104.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel104.Name = "nightHeaderLabel104";
            this.nightHeaderLabel104.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel104.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel104.Size = new System.Drawing.Size(98, 24);
            this.nightHeaderLabel104.TabIndex = 327;
            this.nightHeaderLabel104.Text = "Speed Hack";
            this.nightHeaderLabel104.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel104.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel104.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel105
            // 
            this.nightHeaderLabel105.AutoSize = true;
            this.nightHeaderLabel105.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel105.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel105.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel105.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel105.Location = new System.Drawing.Point(313, 22);
            this.nightHeaderLabel105.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel105.Name = "nightHeaderLabel105";
            this.nightHeaderLabel105.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel105.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel105.Size = new System.Drawing.Size(130, 24);
            this.nightHeaderLabel105.TabIndex = 326;
            this.nightHeaderLabel105.Text = "Unlimited Points";
            this.nightHeaderLabel105.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel105.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel105.UseCompatibleTextRendering = true;
            // 
            // guna2ToggleSwitch49
            // 
            this.guna2ToggleSwitch49.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch49.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch49.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch49.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch49.CheckedState.Parent = this.guna2ToggleSwitch49;
            this.guna2ToggleSwitch49.Location = new System.Drawing.Point(455, 62);
            this.guna2ToggleSwitch49.Name = "guna2ToggleSwitch49";
            this.guna2ToggleSwitch49.ShadowDecoration.Parent = this.guna2ToggleSwitch49;
            this.guna2ToggleSwitch49.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch49.TabIndex = 325;
            this.guna2ToggleSwitch49.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch49.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch49.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch49.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch49.UncheckedState.Parent = this.guna2ToggleSwitch49;
            this.guna2ToggleSwitch49.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch49_CheckedChanged);
            // 
            // guna2ToggleSwitch50
            // 
            this.guna2ToggleSwitch50.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch50.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch50.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch50.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch50.CheckedState.Parent = this.guna2ToggleSwitch50;
            this.guna2ToggleSwitch50.Location = new System.Drawing.Point(455, 102);
            this.guna2ToggleSwitch50.Name = "guna2ToggleSwitch50";
            this.guna2ToggleSwitch50.ShadowDecoration.Parent = this.guna2ToggleSwitch50;
            this.guna2ToggleSwitch50.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch50.TabIndex = 324;
            this.guna2ToggleSwitch50.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch50.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch50.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch50.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch50.UncheckedState.Parent = this.guna2ToggleSwitch50;
            this.guna2ToggleSwitch50.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch50_CheckedChanged);
            // 
            // guna2ToggleSwitch51
            // 
            this.guna2ToggleSwitch51.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch51.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch51.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch51.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch51.CheckedState.Parent = this.guna2ToggleSwitch51;
            this.guna2ToggleSwitch51.Location = new System.Drawing.Point(455, 222);
            this.guna2ToggleSwitch51.Name = "guna2ToggleSwitch51";
            this.guna2ToggleSwitch51.ShadowDecoration.Parent = this.guna2ToggleSwitch51;
            this.guna2ToggleSwitch51.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch51.TabIndex = 323;
            this.guna2ToggleSwitch51.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch51.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch51.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch51.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch51.UncheckedState.Parent = this.guna2ToggleSwitch51;
            // 
            // guna2ToggleSwitch52
            // 
            this.guna2ToggleSwitch52.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch52.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch52.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch52.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch52.CheckedState.Parent = this.guna2ToggleSwitch52;
            this.guna2ToggleSwitch52.Location = new System.Drawing.Point(455, 182);
            this.guna2ToggleSwitch52.Name = "guna2ToggleSwitch52";
            this.guna2ToggleSwitch52.ShadowDecoration.Parent = this.guna2ToggleSwitch52;
            this.guna2ToggleSwitch52.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch52.TabIndex = 322;
            this.guna2ToggleSwitch52.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch52.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch52.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch52.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch52.UncheckedState.Parent = this.guna2ToggleSwitch52;
            // 
            // guna2ToggleSwitch53
            // 
            this.guna2ToggleSwitch53.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch53.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch53.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch53.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch53.CheckedState.Parent = this.guna2ToggleSwitch53;
            this.guna2ToggleSwitch53.Location = new System.Drawing.Point(455, 141);
            this.guna2ToggleSwitch53.Name = "guna2ToggleSwitch53";
            this.guna2ToggleSwitch53.ShadowDecoration.Parent = this.guna2ToggleSwitch53;
            this.guna2ToggleSwitch53.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch53.TabIndex = 321;
            this.guna2ToggleSwitch53.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch53.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch53.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch53.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch53.UncheckedState.Parent = this.guna2ToggleSwitch53;
            // 
            // guna2ToggleSwitch54
            // 
            this.guna2ToggleSwitch54.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch54.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch54.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch54.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch54.CheckedState.Parent = this.guna2ToggleSwitch54;
            this.guna2ToggleSwitch54.Location = new System.Drawing.Point(455, 22);
            this.guna2ToggleSwitch54.Name = "guna2ToggleSwitch54";
            this.guna2ToggleSwitch54.ShadowDecoration.Parent = this.guna2ToggleSwitch54;
            this.guna2ToggleSwitch54.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch54.TabIndex = 320;
            this.guna2ToggleSwitch54.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch54.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch54.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch54.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch54.UncheckedState.Parent = this.guna2ToggleSwitch54;
            this.guna2ToggleSwitch54.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch54_CheckedChanged);
            // 
            // nightHeaderLabel106
            // 
            this.nightHeaderLabel106.AutoSize = true;
            this.nightHeaderLabel106.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel106.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel106.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel106.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel106.Location = new System.Drawing.Point(81, 222);
            this.nightHeaderLabel106.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel106.Name = "nightHeaderLabel106";
            this.nightHeaderLabel106.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel106.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel106.Size = new System.Drawing.Size(90, 24);
            this.nightHeaderLabel106.TabIndex = 319;
            this.nightHeaderLabel106.Text = "Auto Shoot";
            this.nightHeaderLabel106.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel106.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel106.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel107
            // 
            this.nightHeaderLabel107.AutoSize = true;
            this.nightHeaderLabel107.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel107.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel107.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel107.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel107.Location = new System.Drawing.Point(81, 182);
            this.nightHeaderLabel107.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel107.Name = "nightHeaderLabel107";
            this.nightHeaderLabel107.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel107.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel107.Size = new System.Drawing.Size(117, 24);
            this.nightHeaderLabel107.TabIndex = 318;
            this.nightHeaderLabel107.Text = "Weapon Cycle";
            this.nightHeaderLabel107.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel107.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel107.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel108
            // 
            this.nightHeaderLabel108.AutoSize = true;
            this.nightHeaderLabel108.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel108.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel108.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel108.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel108.Location = new System.Drawing.Point(81, 142);
            this.nightHeaderLabel108.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel108.Name = "nightHeaderLabel108";
            this.nightHeaderLabel108.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel108.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel108.Size = new System.Drawing.Size(85, 24);
            this.nightHeaderLabel108.TabIndex = 317;
            this.nightHeaderLabel108.Text = "Rapid Fire";
            this.nightHeaderLabel108.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel108.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel108.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel109
            // 
            this.nightHeaderLabel109.AutoSize = true;
            this.nightHeaderLabel109.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel109.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel109.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel109.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel109.Location = new System.Drawing.Point(81, 102);
            this.nightHeaderLabel109.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel109.Name = "nightHeaderLabel109";
            this.nightHeaderLabel109.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel109.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel109.Size = new System.Drawing.Size(116, 24);
            this.nightHeaderLabel109.TabIndex = 316;
            this.nightHeaderLabel109.Text = "100% Criticals";
            this.nightHeaderLabel109.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel109.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel109.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel110
            // 
            this.nightHeaderLabel110.AutoSize = true;
            this.nightHeaderLabel110.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel110.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel110.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel110.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel110.Location = new System.Drawing.Point(81, 62);
            this.nightHeaderLabel110.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel110.Name = "nightHeaderLabel110";
            this.nightHeaderLabel110.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel110.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel110.Size = new System.Drawing.Size(131, 24);
            this.nightHeaderLabel110.TabIndex = 315;
            this.nightHeaderLabel110.Text = "Unlimited Ammo";
            this.nightHeaderLabel110.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel110.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel110.UseCompatibleTextRendering = true;
            // 
            // nightHeaderLabel111
            // 
            this.nightHeaderLabel111.AutoSize = true;
            this.nightHeaderLabel111.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel111.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel111.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel111.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel111.Location = new System.Drawing.Point(81, 22);
            this.nightHeaderLabel111.Margin = new System.Windows.Forms.Padding(9);
            this.nightHeaderLabel111.Name = "nightHeaderLabel111";
            this.nightHeaderLabel111.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel111.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel111.Size = new System.Drawing.Size(85, 24);
            this.nightHeaderLabel111.TabIndex = 314;
            this.nightHeaderLabel111.Text = "God Mode";
            this.nightHeaderLabel111.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel111.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel111.UseCompatibleTextRendering = true;
            // 
            // guna2ToggleSwitch55
            // 
            this.guna2ToggleSwitch55.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch55.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch55.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch55.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch55.CheckedState.Parent = this.guna2ToggleSwitch55;
            this.guna2ToggleSwitch55.Location = new System.Drawing.Point(33, 62);
            this.guna2ToggleSwitch55.Name = "guna2ToggleSwitch55";
            this.guna2ToggleSwitch55.ShadowDecoration.Parent = this.guna2ToggleSwitch55;
            this.guna2ToggleSwitch55.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch55.TabIndex = 313;
            this.guna2ToggleSwitch55.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch55.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch55.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch55.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch55.UncheckedState.Parent = this.guna2ToggleSwitch55;
            this.guna2ToggleSwitch55.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch55_CheckedChanged);
            // 
            // guna2ToggleSwitch56
            // 
            this.guna2ToggleSwitch56.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch56.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch56.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch56.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch56.CheckedState.Parent = this.guna2ToggleSwitch56;
            this.guna2ToggleSwitch56.Location = new System.Drawing.Point(33, 102);
            this.guna2ToggleSwitch56.Name = "guna2ToggleSwitch56";
            this.guna2ToggleSwitch56.ShadowDecoration.Parent = this.guna2ToggleSwitch56;
            this.guna2ToggleSwitch56.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch56.TabIndex = 312;
            this.guna2ToggleSwitch56.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch56.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch56.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch56.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch56.UncheckedState.Parent = this.guna2ToggleSwitch56;
            this.guna2ToggleSwitch56.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch56_CheckedChanged);
            // 
            // guna2ToggleSwitch57
            // 
            this.guna2ToggleSwitch57.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch57.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch57.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch57.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch57.CheckedState.Parent = this.guna2ToggleSwitch57;
            this.guna2ToggleSwitch57.Location = new System.Drawing.Point(33, 222);
            this.guna2ToggleSwitch57.Name = "guna2ToggleSwitch57";
            this.guna2ToggleSwitch57.ShadowDecoration.Parent = this.guna2ToggleSwitch57;
            this.guna2ToggleSwitch57.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch57.TabIndex = 311;
            this.guna2ToggleSwitch57.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch57.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch57.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch57.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch57.UncheckedState.Parent = this.guna2ToggleSwitch57;
            // 
            // guna2ToggleSwitch58
            // 
            this.guna2ToggleSwitch58.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch58.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch58.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch58.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch58.CheckedState.Parent = this.guna2ToggleSwitch58;
            this.guna2ToggleSwitch58.Location = new System.Drawing.Point(33, 182);
            this.guna2ToggleSwitch58.Name = "guna2ToggleSwitch58";
            this.guna2ToggleSwitch58.ShadowDecoration.Parent = this.guna2ToggleSwitch58;
            this.guna2ToggleSwitch58.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch58.TabIndex = 310;
            this.guna2ToggleSwitch58.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch58.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch58.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch58.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch58.UncheckedState.Parent = this.guna2ToggleSwitch58;
            // 
            // guna2ToggleSwitch59
            // 
            this.guna2ToggleSwitch59.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch59.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch59.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch59.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch59.CheckedState.Parent = this.guna2ToggleSwitch59;
            this.guna2ToggleSwitch59.Location = new System.Drawing.Point(33, 141);
            this.guna2ToggleSwitch59.Name = "guna2ToggleSwitch59";
            this.guna2ToggleSwitch59.ShadowDecoration.Parent = this.guna2ToggleSwitch59;
            this.guna2ToggleSwitch59.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch59.TabIndex = 309;
            this.guna2ToggleSwitch59.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch59.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch59.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch59.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch59.UncheckedState.Parent = this.guna2ToggleSwitch59;
            this.guna2ToggleSwitch59.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch59_CheckedChanged);
            // 
            // guna2ToggleSwitch60
            // 
            this.guna2ToggleSwitch60.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch60.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch60.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch60.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch60.CheckedState.Parent = this.guna2ToggleSwitch60;
            this.guna2ToggleSwitch60.Location = new System.Drawing.Point(33, 22);
            this.guna2ToggleSwitch60.Name = "guna2ToggleSwitch60";
            this.guna2ToggleSwitch60.ShadowDecoration.Parent = this.guna2ToggleSwitch60;
            this.guna2ToggleSwitch60.Size = new System.Drawing.Size(24, 24);
            this.guna2ToggleSwitch60.TabIndex = 308;
            this.guna2ToggleSwitch60.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch60.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch60.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch60.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch60.UncheckedState.Parent = this.guna2ToggleSwitch60;
            this.guna2ToggleSwitch60.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch60_CheckedChanged);
            // 
            // poisonTrackBar1
            // 
            this.poisonTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.poisonTrackBar1.Location = new System.Drawing.Point(166, 451);
            this.poisonTrackBar1.Margin = new System.Windows.Forms.Padding(9);
            this.poisonTrackBar1.Maximum = 75;
            this.poisonTrackBar1.Minimum = 1;
            this.poisonTrackBar1.MouseWheelBarPartitions = 5;
            this.poisonTrackBar1.Name = "poisonTrackBar1";
            this.poisonTrackBar1.Size = new System.Drawing.Size(316, 23);
            this.poisonTrackBar1.TabIndex = 307;
            this.poisonTrackBar1.UseCustomBackColor = true;
            this.poisonTrackBar1.Value = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(511, 646);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.CB_AutoKill);
            this.Controls.Add(this.Form_Header);
            this.Controls.Add(this.CB_XP);
            this.Controls.Add(this.Panel_LeftSide);
            this.Controls.Add(this.Panel_Server);
            this.Controls.Add(this.CB_Noclip);
            this.Controls.Add(this.Panel_P4);
            this.Controls.Add(this.Panel_P3);
            this.Controls.Add(this.Panel_P2);
            this.Controls.Add(this.CB_Bots);
            this.Controls.Add(this.Panel_P1);
            this.Controls.Add(this.CB_RoundSkip);
            this.Controls.Add(this.CB_TP_ZM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gui.exe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_LeftSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Discord_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_P4_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_P3_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_P2_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_P1_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Server_Icon)).EndInit();
            this.Form_Header.ResumeLayout(false);
            this.Form_Header.PerformLayout();
            this.Panel_P4.ResumeLayout(false);
            this.Panel_P4.PerformLayout();
            this.FeaturesTabPage.ResumeLayout(false);
            this.FeaturesTabPage.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.ClassesTabPage.PerformLayout();
            this.guna2Panel32.ResumeLayout(false);
            this.UnlocksTabPage.ResumeLayout(false);
            this.UnlocksTabPage.PerformLayout();
            this.guna2Panel27.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel10.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.guna2Panel17.ResumeLayout(false);
            this.guna2Panel15.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		// Token: 0x040001D1 RID: 465
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040001D2 RID: 466
		public global::System.Windows.Forms.Panel Panel_LeftSide;

		// Token: 0x040001D3 RID: 467
		public global::System.Windows.Forms.Timer Animations;

		// Token: 0x040001D4 RID: 468
		public global::FontAwesome.Sharp.IconPictureBox Btn_Server_Icon;

		// Token: 0x040001D5 RID: 469
		public global::FontAwesome.Sharp.IconPictureBox Btn_Discord_Icon;

		// Token: 0x040001D6 RID: 470
		public global::FontAwesome.Sharp.IconPictureBox Btn_P4_Icon;

		// Token: 0x040001D7 RID: 471
		public global::System.Windows.Forms.Panel panel5;

		// Token: 0x040001D8 RID: 472
		public global::FontAwesome.Sharp.IconPictureBox Btn_P3_Icon;

		// Token: 0x040001D9 RID: 473
		public global::System.Windows.Forms.Panel panel4;

		// Token: 0x040001DA RID: 474
		public global::FontAwesome.Sharp.IconPictureBox Btn_P2_Icon;

		// Token: 0x040001DB RID: 475
		public global::System.Windows.Forms.Panel panel3;

		// Token: 0x040001DC RID: 476
		public global::FontAwesome.Sharp.IconPictureBox Btn_P1_Icon;

		// Token: 0x040001DD RID: 477
		public global::System.Windows.Forms.Panel panel2;

		// Token: 0x040001DE RID: 478
		public global::System.Windows.Forms.Panel panel1;

		// Token: 0x040001DF RID: 479
		public global::System.Windows.Forms.Panel Btn_Server_BG;

		// Token: 0x040001E0 RID: 480
		public global::System.Windows.Forms.Panel Panel_Server;

		// Token: 0x040001E2 RID: 482
		public global::System.Windows.Forms.Panel Form_Header;

		// Token: 0x040001E3 RID: 483
		public global::ReaLTaiizor.Controls.ForeverButton Btn_Close;

		// Token: 0x040001E4 RID: 484
		public global::System.Windows.Forms.Panel Panel_P1;

		// Token: 0x040001E5 RID: 485
		public global::System.Windows.Forms.Panel Panel_P2;

		// Token: 0x040001E6 RID: 486
		public global::System.Windows.Forms.Panel Panel_P3;

		// Token: 0x040001E7 RID: 487
		public global::System.Windows.Forms.Panel Panel_P4;

		// Token: 0x040001E8 RID: 488
		public global::ReaLTaiizor.Controls.NightHeaderLabel LBL_PlayerName;

		// Token: 0x0400024C RID: 588
		public global::ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel3;

		// Token: 0x0400024F RID: 591
		public global::ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel4;

		// Token: 0x04000250 RID: 592
		public global::ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel5;

		// Token: 0x0400025C RID: 604
		public global::ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel8;

		// Token: 0x0400025E RID: 606
		public global::ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel9;

		// Token: 0x04000260 RID: 608
		public global::ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel10;

		// Token: 0x04000262 RID: 610
		public global::ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel11;

		// Token: 0x04000264 RID: 612
		public global::ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel12;

		// Token: 0x04000266 RID: 614
		public global::ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel13;

		// Token: 0x04000268 RID: 616
		public global::ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel14;

		// Token: 0x0400026A RID: 618
		public global::ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel15;

		// Token: 0x0400026C RID: 620
		public global::ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel16;

		// Token: 0x0400026D RID: 621
		public global::ReaLTaiizor.Controls.MetroSwitch CB_TP_ZM;

		// Token: 0x04000274 RID: 628
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000275 RID: 629
		public global::System.Windows.Forms.Timer timer2;

		// Token: 0x04000276 RID: 630
		public global::System.Windows.Forms.Timer timer3;

		// Token: 0x04000277 RID: 631
		public global::System.Windows.Forms.Timer timer4;

		// Token: 0x0400027B RID: 635
		public global::ReaLTaiizor.Controls.NightHeaderLabel LBL_Gun;

		// Token: 0x0400027E RID: 638
		public global::ReaLTaiizor.Controls.MetroSwitch CB_Bots;

		// Token: 0x04000280 RID: 640
		public global::ReaLTaiizor.Controls.MetroSwitch CB_RoundSkip;

		// Token: 0x04000282 RID: 642
		private global::System.Windows.Forms.Label DAHelp;

		// Token: 0x04000283 RID: 643
		public global::ReaLTaiizor.Controls.MetroSwitch CB_Noclip;

		// Token: 0x04000286 RID: 646
		public global::ReaLTaiizor.Controls.MetroSwitch CB_AutoKill;

		// Token: 0x04000288 RID: 648
		public global::System.Windows.Forms.Timer XP_Timer;

		// Token: 0x04000289 RID: 649
		public global::ReaLTaiizor.Controls.MetroSwitch CB_XP;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel63;
        public ReaLTaiizor.Controls.ForeverButton foreverButton1;
        private System.Windows.Forms.TabPage FeaturesTabPage;
        public ReaLTaiizor.Controls.ForeverButton Btn_Gib2_P1;
        public ReaLTaiizor.Controls.ForeverButton Btn_TP_P1;
        public ReaLTaiizor.Controls.ForeverButton Btn_Gib_P1;
        public ReaLTaiizor.Controls.ForeverComboBox Box_CycleEnd_P1;
        public ReaLTaiizor.Controls.ForeverComboBox Box_Weapons_P1;
        public ReaLTaiizor.Controls.ForeverComboBox Box_TP_P1;
        public ReaLTaiizor.Controls.ForeverComboBox Box_CycleStart_P1;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel37;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel1;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel38;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel13;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel48;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel2;
        public ReaLTaiizor.Controls.MetroSwitch CB_zqinissofuckingsexy_P1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public ReaLTaiizor.Controls.MetroSwitch CB_Shoot_P1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel25;
        public ReaLTaiizor.Controls.MetroSwitch CB_Rainbow_P1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel26;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel24;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel23;
        private System.Windows.Forms.Label label37;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel40;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch36;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel42;
        private System.Windows.Forms.Label label31;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel44;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel39;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel46;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch11;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch18;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel41;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch20;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel43;
        private System.Windows.Forms.Label label18;
        public ReaLTaiizor.Controls.MetroSwitch CB_Croshair_P1;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel45;
        private System.Windows.Forms.Label label12;
        public ReaLTaiizor.Controls.MetroSwitch CB_Cycle_P1;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel47;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch23;
        public ReaLTaiizor.Controls.MetroSwitch CB_Jail_P1;
        public ReaLTaiizor.Controls.MetroSwitch CB_God_P1;
        public ReaLTaiizor.Controls.MetroSwitch CB_Ammo_P1;
        public ReaLTaiizor.Controls.MetroSwitch CB_Crit_P1;
        public ReaLTaiizor.Controls.MetroSwitch CB_Speed_P1;
        public ReaLTaiizor.Controls.MetroSwitch CB_Rapid_P1;
        public ReaLTaiizor.Controls.MetroSwitch CB_Points_P1;
        private System.Windows.Forms.TabPage ClassesTabPage;
        public ReaLTaiizor.Controls.ForeverButton Btn_Gib2_P2;
        public ReaLTaiizor.Controls.ForeverButton Btn_TP_P2;
        public ReaLTaiizor.Controls.ForeverComboBox Box_Weapons_P2;
        public ReaLTaiizor.Controls.ForeverComboBox Box_TP_P2;
        public ReaLTaiizor.Controls.ForeverComboBox Box_CycleEnd_P2;
        public ReaLTaiizor.Controls.ForeverComboBox Box_CycleStart_P2;
        public ReaLTaiizor.Controls.ForeverButton Btn_Gib_P2;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel34;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch4;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel31;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel35;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel29;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel76;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel33;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel32;
        public ReaLTaiizor.Controls.MetroSwitch CB_zqinissofuckingsexy_P2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel30;
        public ReaLTaiizor.Controls.MetroSwitch CB_Shoot_P2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel31;
        public ReaLTaiizor.Controls.MetroSwitch CB_Rainbow_P2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel32;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel33;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel58;
        public ReaLTaiizor.Controls.MetroSwitch CB_God_P2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch6;
        public ReaLTaiizor.Controls.MetroSwitch CB_Ammo_P2;
        public ReaLTaiizor.Controls.NightHeaderLabel LBL_Kills;
        public ReaLTaiizor.Controls.MetroSwitch CB_Crit_P2;
        public ReaLTaiizor.Controls.PoisonTrackBar Bar_Shots;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel49;
        public ReaLTaiizor.Controls.MetroSwitch CB_Rapid_P2;
        public ReaLTaiizor.Controls.PoisonTrackBar Bar_Kills;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel51;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel57;
        public ReaLTaiizor.Controls.MetroSwitch CB_Cycle_P2;
        public ReaLTaiizor.Controls.ForeverButton Btn_QuickDA;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel53;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch7;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel36;
        public ReaLTaiizor.Controls.ForeverButton Btn_KillAll;
        public ReaLTaiizor.Controls.NightHeaderLabel LBL_Shots;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel55;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel61;
        public ReaLTaiizor.Controls.MetroSwitch CB_Points_P2;
        public ReaLTaiizor.Controls.MetroSwitch CB_Speed_P2;
        public ReaLTaiizor.Controls.ForeverButton Btn_Kill_multi;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel50;
        public ReaLTaiizor.Controls.MetroSwitch CB_Jail_P2;
        public ReaLTaiizor.Controls.ForeverButton Dtn_Diamond;
        public ReaLTaiizor.Controls.MetroSwitch CB_Croshair_P2;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel52;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch3;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel56;
        public ReaLTaiizor.Controls.ForeverButton Btn_Dark;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel54;
        public ReaLTaiizor.Controls.ForeverButton Btn_TP_Set;
        public ReaLTaiizor.Controls.ForeverButton Btn_TP_Bots;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel60;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private System.Windows.Forms.TabPage UnlocksTabPage;
        public ReaLTaiizor.Controls.ForeverComboBox Box_Weapons_P3;
        public ReaLTaiizor.Controls.ForeverComboBox Box_TP_P3;
        public ReaLTaiizor.Controls.ForeverComboBox Box_CycleEnd_P3;
        public ReaLTaiizor.Controls.ForeverComboBox Box_CycleStart_P3;
        public ReaLTaiizor.Controls.ForeverButton Btn_Gib2_P3;
        public ReaLTaiizor.Controls.ForeverButton Btn_TP_P3;
        public ReaLTaiizor.Controls.ForeverButton Btn_Gib_P3;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel20;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel17;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel21;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel20;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel19;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel18;
        public ReaLTaiizor.Controls.MetroSwitch CB_zqinissofuckingsexy_P3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel21;
        public ReaLTaiizor.Controls.MetroSwitch CB_Shoot_P3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel22;
        public ReaLTaiizor.Controls.MetroSwitch CB_Rainbow_P3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel27;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel28;
        private System.Windows.Forms.GroupBox groupBox6;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2ComboBox CWCamoSwapComboBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel23;
        public ReaLTaiizor.Controls.MetroSwitch CB_God_P3;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel25;
        public ReaLTaiizor.Controls.MetroSwitch CB_Ammo_P3;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel27;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel22;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel29;
        public ReaLTaiizor.Controls.MetroSwitch CB_Crit_P3;
        public ReaLTaiizor.Controls.MetroSwitch CB_Rapid_P3;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel24;
        public ReaLTaiizor.Controls.MetroSwitch CB_Cycle_P3;
        public ReaLTaiizor.Controls.MetroSwitch CB_Points_P3;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel26;
        public ReaLTaiizor.Controls.MetroSwitch CB_Speed_P3;
        public ReaLTaiizor.Controls.MetroSwitch CB_Croshair_P3;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel28;
        public ReaLTaiizor.Controls.MetroSwitch CB_Jail_P3;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel30;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel59;
        public ReaLTaiizor.Controls.PoisonTrackBar bar_noclip;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch5;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel62;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel78;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox LOADER;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel68;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel69;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel70;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel71;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel72;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel73;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch15;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch16;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch17;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch21;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch22;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel6;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel7;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel64;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel65;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel66;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel67;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch14;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch13;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch12;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch10;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch9;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch8;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel74;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel75;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel77;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel79;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel80;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel81;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch24;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch25;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch26;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch27;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch28;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch29;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel82;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel83;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel84;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel85;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel86;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel87;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch30;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch31;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch32;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch33;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch34;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch35;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel88;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel89;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel90;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel91;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel92;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel93;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch37;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch38;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch39;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch40;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch41;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch42;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel94;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel95;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel96;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel97;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel98;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel99;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch43;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch44;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch45;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch46;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch47;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch48;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel10;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel17;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel18;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel15;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel16;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel14;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel12;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel100;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel101;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel102;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel103;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel104;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel105;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch49;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch50;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch51;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch52;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch53;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch54;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel106;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel107;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel108;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel109;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel110;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel111;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch55;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch56;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch57;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch58;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch59;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch60;
        public ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel112;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch61;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch62;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch19;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch63;
        public ReaLTaiizor.Controls.PoisonTrackBar poisonTrackBar1;
    }
}
