using System;
using System.Collections.Generic;
using System.Threading;
using PornHub.Branding;
using ReaLTaiizor.Controls;

namespace PornHub.Game
{
	// Token: 0x02000038 RID: 56
	internal class Threads
	{
		// Token: 0x060001C3 RID: 451 RVA: 0x0001D0C4 File Offset: 0x0001B2C4
		internal void UpdatePointers()
		{
			Offsets.PlayerCompPtr = HyperMEM.MEM.ReadInt64(HyperMEM.MEM.GameBase + Offsets.ZPlayerBase);
			Offsets.PlayerPedPtr = HyperMEM.MEM.ReadInt64(HyperMEM.MEM.GameBase + Offsets.ZPlayerBase + 8UL);
			Offsets.ZMGlobalBase = HyperMEM.MEM.ReadInt64(HyperMEM.MEM.GameBase + Offsets.ZPlayerBase) + 96UL;
			Offsets.ZMBotBase = HyperMEM.MEM.ReadInt64(HyperMEM.MEM.GameBase + Offsets.ZPlayerBase) + 104UL;
			Offsets.ZMBotListBase = HyperMEM.MEM.ReadInt64(Offsets.ZMBotBase + Offsets.ZM_Bot_List_Offset);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0001D174 File Offset: 0x0001B374
		public void Rapid_Thread()
		{
			for (;;)
			{
				bool switched = Form1.ThisForm.CB_Bots.Switched;
				if (switched)
				{
					for (int i = 4; i < 18; i++)
					{
						PlayerFunctions.Teleport(i, Threads.BotLocation);
					}
				}
				bool switched2 = Form1.ThisForm.CB_Rapid_P1.Switched;
				if (switched2)
				{
					PlayerFunctions.SetRapidFire(0);
				}
				bool switched3 = Form1.ThisForm.CB_Rapid_P2.Switched;
				if (switched3)
				{
					PlayerFunctions.SetRapidFire(1);
				}
				bool switched4 = Form1.ThisForm.CB_Rapid_P3.Switched;
				if (switched4)
				{
					PlayerFunctions.SetRapidFire(2);
				}
				Thread.Sleep(5);
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0001D244 File Offset: 0x0001B444
		public void Cycle_Thread()
		{
			for (;;)
			{
				string text = HyperMEM.MEM.ReadInt32(HyperMEM.MEM.GameBase + Offsets.ZSeshState).ToString("X");
				bool flag = text.EndsWith("21");
				if (flag)
				{
					bool flag2 = PlayerFunctions.GunList[0] != PlayerFunctions.GunListMP[0];
					if (flag2)
					{
						Form1.ThisForm.SetupMPGuns();
						Form1.ThisForm.Btn_Dark.Enabled = false;
						Form1.ThisForm.Dtn_Diamond.Enabled = true;
					}
				}
				else
				{
					bool flag3 = text.EndsWith("20");
					if (flag3)
					{
						bool flag4 = PlayerFunctions.GunList[0] != PlayerFunctions.GunListZM[0];
						if (flag4)
						{
							Form1.ThisForm.SetupZMGuns();
							Form1.ThisForm.Btn_Dark.Enabled = true;
							Form1.ThisForm.Dtn_Diamond.Enabled = false;
						}
					}
				}
				Thread.Sleep(1000);
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0001D348 File Offset: 0x0001B548
		public void Noclip_Thread()
		{
			for (;;)
			{
				bool switched = Form1.ThisForm.CB_Noclip.Switched;
				if (switched)
				{
					byte b = HyperMEM.MEM.ReadByte(HyperMEM.MEM.GameBase + Offsets.ZNoClipDir);
					bool flag = b == 1;
					if (flag)
					{
						
					}
					bool flag2 = b == 2;
					if (flag2)
					{
						HyperMEM.Vectors.Vec2.Vector2 playerAngles = PlayerFunctions.GetPlayerAngles(0);
						playerAngles.X = -playerAngles.X;
				
					}
					bool flag3 = b == 3;
					if (flag3)
					{
						HyperMEM.Vectors.Vec2.Vector2 playerAngles2 = PlayerFunctions.GetPlayerAngles(0);
						playerAngles2.X = 0f;
						
					}
					bool flag4 = b == 4;
					if (flag4)
					{
						HyperMEM.Vectors.Vec2.Vector2 playerAngles3 = PlayerFunctions.GetPlayerAngles(0);
						playerAngles3.X = 0f;

					}
				}
				Thread.Sleep(1);
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0001D4B0 File Offset: 0x0001B6B0
		public static void RestoreTool()
		{
			IEnumerable<MetroSwitch> enumerable = Form1.ThisForm.FindAllChildrenByType<MetroSwitch>();
			IEnumerable<PoisonTrackBar> enumerable2 = Form1.ThisForm.FindAllChildrenByType<PoisonTrackBar>();
			foreach (MetroSwitch metroSwitch in enumerable)
			{
				metroSwitch.Switched = false;
			}
			foreach (PoisonTrackBar poisonTrackBar in enumerable2)
			{
				poisonTrackBar.Value = poisonTrackBar.MouseWheelBarPartitions;
			}
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
			HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZShoot, new byte[]
			{
				72,
				137,
				92,
				36,
				8
			}, false);
			bool flag = Form1.CodeCave > 0UL;
			if (flag)
			{
				HyperMEM.MEM.WriteBytes(Form1.CodeCave, new byte[75], false);
				Form1.CodeCave = 0UL;
			}
			HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZKill, new byte[]
			{
				72,
				137,
				92,
				36,
				8
			}, false);
			bool flag2 = Form1.CodeCave2 > 0UL;
			if (flag2)
			{
				HyperMEM.MEM.WriteBytes(Form1.CodeCave2, new byte[209], false);
				Form1.CodeCave2 = 0UL;
			}
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
			HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZRound, new byte[]
			{
				139,
				145,
				32,
				2,
				0,
				0
			}, false);
			byte[] buffer = new byte[]
			{
				64,
				85,
				86,
				87,
				65,
				84
			};
			HyperMEM.MEM.WriteBytes(HyperMEM.MEM.GameBase + Offsets.ZXP, buffer, false);
			bool flag3 = Form1.Cave_XP > 0UL;
			if (flag3)
			{
				byte[] buffer2 = new byte[24];
				HyperMEM.MEM.WriteBytes(Form1.Cave_XP, buffer2, false);
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0001D704 File Offset: 0x0001B904
		public void Update_Thread()
		{
			this.UpdatePointers();
			Threads @object = new Threads();
			new Thread(new ThreadStart(@object.Rapid_Thread))
			{
				IsBackground = true
			}.Start();
			new Thread(new ThreadStart(@object.Noclip_Thread))
			{
				IsBackground = true
			}.Start();
			new Thread(new ThreadStart(@object.Cycle_Thread))
			{
				IsBackground = true
			}.Start();
			for (;;)
			{
				this.UpdatePointers();
				Threads.InGame = (PlayerFunctions.GetPlayerName(0) != "UnnamedPlayer" && PlayerFunctions.GetPlayerName(0) != "");
				bool flag = !Threads.InGame;
				if (flag)
				{
					Threads.RestoreTool();
					Thread.Sleep(1000);
				}
				bool switched = Form1.ThisForm.CB_TP_ZM.Switched;
				if (switched)
				{
					HyperMEM.MEM.WriteFloat(HyperMEM.MEM.GameBase + Offsets.ZTeleport + 1UL, Threads.ZmLocation.X, false);
					HyperMEM.MEM.WriteFloat(HyperMEM.MEM.GameBase + Offsets.ZTeleport + 12UL, Threads.ZmLocation.Y, false);
					HyperMEM.MEM.WriteFloat(HyperMEM.MEM.GameBase + Offsets.ZTeleport + 23UL, Threads.ZmLocation.Z, false);
				}
				bool switched2 = Form1.ThisForm.CB_God_P1.Switched;
				if (switched2)
				{
					PlayerFunctions.SetGodMode(0, true);
				}
				else
				{
					PlayerFunctions.SetGodMode(0, false);
				}
				bool switched3 = Form1.ThisForm.CB_Points_P1.Switched;
				if (switched3)
				{
					PlayerFunctions.SetPoints(0, 133700);
				}
				bool switched4 = Form1.ThisForm.CB_Ammo_P1.Switched;
				if (switched4)
				{
					PlayerFunctions.UnlimitedAmmo(0);
				}
				bool switched5 = Form1.ThisForm.CB_Speed_P1.Switched;
				if (switched5)
				{
					PlayerFunctions.SetPlayerSpeed(0, 2.5f);
				}
				bool switched6 = Form1.ThisForm.CB_Crit_P1.Switched;
				if (switched6)
				{
					PlayerFunctions.SetCriticalKills(0);
				}
				bool switched7 = Form1.ThisForm.CB_Jail_P1.Switched;
				if (switched7)
				{
					PlayerFunctions.SendToJail(0);
				}
				bool switched8 = Form1.ThisForm.CB_Croshair_P1.Switched;
				if (switched8)
				{
					PlayerFunctions.SetZMPos(0);
				}
				bool switched9 = Form1.ThisForm.CB_God_P2.Switched;
				if (switched9)
				{
					PlayerFunctions.SetGodMode(1, true);
				}
				else
				{
					PlayerFunctions.SetGodMode(1, false);
				}
				bool switched10 = Form1.ThisForm.CB_Points_P2.Switched;
				if (switched10)
				{
					PlayerFunctions.SetPoints(1, 133700);
				}
				bool switched11 = Form1.ThisForm.CB_Ammo_P2.Switched;
				if (switched11)
				{
					PlayerFunctions.UnlimitedAmmo(1);
				}
				bool switched12 = Form1.ThisForm.CB_Speed_P2.Switched;
				if (switched12)
				{
					PlayerFunctions.SetPlayerSpeed(1, 2.5f);
				}
				bool switched13 = Form1.ThisForm.CB_Crit_P2.Switched;
				if (switched13)
				{
					PlayerFunctions.SetCriticalKills(1);
				}
				bool switched14 = Form1.ThisForm.CB_Jail_P2.Switched;
				if (switched14)
				{
					PlayerFunctions.SendToJail(1);
				}
				bool switched15 = Form1.ThisForm.CB_Croshair_P2.Switched;
				if (switched15)
				{
					PlayerFunctions.SetZMPos(1);
				}
				bool switched16 = Form1.ThisForm.CB_God_P3.Switched;
				if (switched16)
				{
					PlayerFunctions.SetGodMode(2, true);
				}
				else
				{
					PlayerFunctions.SetGodMode(2, false);
				}
				bool switched17 = Form1.ThisForm.CB_Points_P3.Switched;
				if (switched17)
				{
					PlayerFunctions.SetPoints(2, 133700);
				}
				bool switched18 = Form1.ThisForm.CB_Ammo_P3.Switched;
				if (switched18)
				{
					PlayerFunctions.UnlimitedAmmo(2);
				}
				bool switched19 = Form1.ThisForm.CB_Speed_P3.Switched;
				if (switched19)
				{
					PlayerFunctions.SetPlayerSpeed(2, 2.5f);
				}
				bool switched20 = Form1.ThisForm.CB_Crit_P3.Switched;
				if (switched20)
				{
					PlayerFunctions.SetCriticalKills(2);
				}
				bool switched21 = Form1.ThisForm.CB_Jail_P3.Switched;
				if (switched21)
				{
					PlayerFunctions.SendToJail(2);
				}
				bool switched22 = Form1.ThisForm.CB_Croshair_P3.Switched;
				if (switched22)
				{
					PlayerFunctions.SetZMPos(2);
				}
		
		


				int num = 1;
				bool flag2 = num == 1;
				if (flag2)
				{
				}
				Thread.Sleep(50);
			}
		}

		// Token: 0x040004D1 RID: 1233
		public static HyperMEM.Vectors.Vec3.Vector3 ZmLocation = default(HyperMEM.Vectors.Vec3.Vector3);

		// Token: 0x040004D2 RID: 1234
		public static HyperMEM.Vectors.Vec3.Vector3 BotLocation = default(HyperMEM.Vectors.Vec3.Vector3);

		// Token: 0x040004D3 RID: 1235
		public static HyperMEM.Vectors.Vec3.Vector3 DogLocation = default(HyperMEM.Vectors.Vec3.Vector3);

		// Token: 0x040004D4 RID: 1236
		public static bool InGame = false;

		// Token: 0x040004D5 RID: 1237
		public static ulong GameTime = 0UL;
	}
}
