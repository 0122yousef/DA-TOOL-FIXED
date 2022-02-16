using System;

namespace PornHub.Game
{
    // Token: 0x02000037 RID: 55
    internal class PlayerFunctions
    {
        // Token: 0x060001A7 RID: 423 RVA: 0x0001C73C File Offset: 0x0001A93C
        public static string GetPlayerName(int ID)
        {
            return HyperMEM.MEM.ReadAsciiString(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_Name), 15);
        }

        // Token: 0x060001A8 RID: 424 RVA: 0x0001C770 File Offset: 0x0001A970
        public static string GetPlayerGunID(int ID)
        {
            return HyperMEM.MEM.ReadInt16(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_CurrentUsedWeaponID)).ToString();
        }

        // Token: 0x060001A9 RID: 425 RVA: 0x0001C7A8 File Offset: 0x0001A9A8
        public static int GetPlayerShots(int ID)
        {
            return HyperMEM.MEM.ReadInt32(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_NumShots));
        }

        // Token: 0x060001AA RID: 426 RVA: 0x0001C7D8 File Offset: 0x0001A9D8
        public static void SetPlayerShots(int ID, int Shots)
        {
            HyperMEM.MEM.WriteInt32(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_NumShots), Shots, false);
        }

        // Token: 0x060001AB RID: 427 RVA: 0x0001C7FC File Offset: 0x0001A9FC
        public static int GetPlayerKills(int ID)
        {
            return HyperMEM.MEM.ReadInt32(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_NumKills));
        }

        // Token: 0x060001AC RID: 428 RVA: 0x0001C82C File Offset: 0x0001AA2C
        public static void SetPlayerKills(int ID, int kills)
        {
            HyperMEM.MEM.WriteInt32(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_NumKills), kills, false);
        }

        // Token: 0x060001AD RID: 429 RVA: 0x0001C850 File Offset: 0x0001AA50
        public static void SetGodMode(int ID, bool GOD)
        {
            if (GOD)
            {
                HyperMEM.MEM.WriteByte(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_GodMode), 160, false);
            }
            else
            {
                HyperMEM.MEM.WriteByte(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_GodMode), 32, false);
            }
        }

        // Token: 0x060001AE RID: 430 RVA: 0x0001C8B0 File Offset: 0x0001AAB0
        public static void SetPoints(int ID, int Points)
        {
            HyperMEM.MEM.WriteInt32(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_Points), Points, false);
        }

        // Token: 0x060001AF RID: 431 RVA: 0x0001C8D4 File Offset: 0x0001AAD4
        public static void SetRapidFire(int ID)
        {
            HyperMEM.MEM.WriteInt32(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_RapidFire1), 0, false);
            HyperMEM.MEM.WriteInt32(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_RapidFire2), 0, false);
        }

        // Token: 0x060001B0 RID: 432 RVA: 0x0001C924 File Offset: 0x0001AB24
        public static void UnlimitedAmmo(int ID)
        {
            for (ulong num = 0UL; num < 5UL; num += 1UL)
            {
                HyperMEM.MEM.WriteInt32(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_Ammo + 4UL * num, 256, false);
            }
        }

        // Token: 0x060001B1 RID: 433 RVA: 0x0001C974 File Offset: 0x0001AB74
        public static void SetAmmo(int ID, int ammount)
        {
            for (ulong num = 0UL; num < 2UL; num += 1UL)
            {
                HyperMEM.MEM.WriteInt32(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_Ammo + 4UL * num, ammount, false);
            }
        }

        // Token: 0x060001B2 RID: 434 RVA: 0x0001C9C0 File Offset: 0x0001ABC0
        public static void RemoveAmmo(int ID)
        {
            for (ulong num = 0UL; num < 5UL; num += 1UL)
            {
                HyperMEM.MEM.WriteInt32(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_Ammo + 4UL * num, 0, false);
            }
        }

        // Token: 0x060001B3 RID: 435 RVA: 0x0001CA09 File Offset: 0x0001AC09
        public static void SetPlayerSpeed(int ID, float Speed)
        {
            HyperMEM.MEM.WriteFloat(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_RunSpeed), Speed, false);
        }

        // Token: 0x060001B4 RID: 436 RVA: 0x0001CA30 File Offset: 0x0001AC30
        public static void SetCriticalKills(int ID)
        {
            HyperMEM.MEM.WriteInt32(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + 4300UL), -1, false);
            HyperMEM.MEM.WriteInt32(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + 4304UL), -1, false);
            HyperMEM.MEM.WriteInt32(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + 4324UL), -1, false);
            HyperMEM.MEM.WriteInt32(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + 4328UL), -1, false);
            HyperMEM.MEM.WriteInt32(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + 4292UL), -1, false);
            HyperMEM.MEM.WriteInt32(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + 4296UL), -1, false);
            HyperMEM.MEM.WriteInt32(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + 4308UL), -1, false);
            HyperMEM.MEM.WriteInt32(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + 4312UL), -1, false);
        }

        // Token: 0x060001B5 RID: 437 RVA: 0x0001CB4E File Offset: 0x0001AD4E
        public static void SendToJail(int ID)
        {
            HyperMEM.MEM.WriteVec3(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_Vec3, new HyperMEM.Vectors.Vec3.Vector3(860f, 5515f, -1795f), false);
        }

        // Token: 0x060001B6 RID: 438 RVA: 0x0001CB85 File Offset: 0x0001AD85
        public static void Teleport(int ID, HyperMEM.Vectors.Vec3.Vector3 Location)
        {
            HyperMEM.MEM.WriteVec3(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_Vec3, Location, false);
        }

        // Token: 0x060001B7 RID: 439 RVA: 0x0001CBAC File Offset: 0x0001ADAC
        public static HyperMEM.Vectors.Vec3.Vector3 GetLocation(int ID)
        {
            return HyperMEM.MEM.ReadVec3(Offsets.PlayerCompPtr + Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_Vec3);
        }

        // Token: 0x060001B8 RID: 440 RVA: 0x0001CBDC File Offset: 0x0001ADDC
        public static HyperMEM.Vectors.Vec2.Vector2 GetPlayerAngles(int ID)
        {
            return HyperMEM.MEM.ReadVec2(Offsets.PlayerPedPtr + Offsets.PP_ArraySize_Offset * (ulong)((long)ID) + Offsets.PP_Heading_XY);
        }

        // Token: 0x060001B9 RID: 441 RVA: 0x0001CC0C File Offset: 0x0001AE0C
        public static void SetZMPos(int ID)
        {
            HyperMEM.Vectors.Vec3.Vector3 vector = HyperMEM.MEM.ReadVec3(Offsets.PlayerPedPtr + Offsets.PP_ArraySize_Offset * (ulong)((long)ID) + Offsets.PP_Coords);
            HyperMEM.Vectors.Vec2.Vector2 vector2 = HyperMEM.MEM.ReadVec2(Offsets.PlayerPedPtr + Offsets.PP_ArraySize_Offset * (ulong)((long)ID) + Offsets.PP_Heading_XY);
            double num = 0.017453292519943295 * (double)vector2.X;
            float num2 = 150f * (float)Math.Cos(num);
            float num3 = 150f * (float)Math.Sin(num);
            Threads.ZmLocation = new HyperMEM.Vectors.Vec3.Vector3(vector.X += num2, vector.Y += num3, vector.Z);
        }

        // Token: 0x060001BA RID: 442 RVA: 0x0001CCBC File Offset: 0x0001AEBC
        public static void Move2Angle(int ID, HyperMEM.Vectors.Vec2.Vector2 Angle, float Distance)
        {
            HyperMEM.Vectors.Vec3.Vector3 vector = HyperMEM.MEM.ReadVec3(Offsets.PlayerPedPtr + Offsets.PP_ArraySize_Offset * (ulong)((long)ID) + Offsets.PP_Coords);
            double num = 0.017453292519943295 * (double)Angle.Y;
            float num2 = Distance * (float)Math.Cos(num);
            float num3 = Distance * (float)Math.Sin(num);

        }

        // Token: 0x060001BB RID: 443 RVA: 0x0001CD80 File Offset: 0x0001AF80
        public static void GiveWeapon0(int ID, int GunIndex)
        {
            HyperMEM mem = HyperMEM.MEM;
            ulong playerCompPtr = Offsets.PlayerCompPtr;
            ulong num = Offsets.PC_ArraySize_Offset * (ulong)((long)ID);
            ulong pc_SetWeaponID = Offsets.PC_SetWeaponID0;
            ulong pc_GunStruct = Offsets.PC_GunStruct;
            mem.WriteInt64(playerCompPtr + (num + (pc_SetWeaponID + 0UL)), (long)PlayerFunctions.GunList[GunIndex], false);
            HyperMEM.MEM.WriteByte(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_Camo0), 69, false);
        }

        // Token: 0x060001BC RID: 444 RVA: 0x0001CDE4 File Offset: 0x0001AFE4
        public static void GiveWeapon1(int ID, int GunIndex)
        {
            HyperMEM.MEM.WriteInt64(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + (Offsets.PC_SetWeaponID0 + Offsets.PC_GunStruct)), (long)PlayerFunctions.GunList[GunIndex], false);
            HyperMEM.MEM.WriteByte(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_Camo1), 118, false);
        }

        // Token: 0x060001BD RID: 445 RVA: 0x0001CE44 File Offset: 0x0001B044
        public static void GiveWeapon2(int ID, int GunIndex)
        {
            HyperMEM.MEM.WriteInt64(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + (Offsets.PC_SetWeaponID0 + Offsets.PC_GunStruct * 2UL)), (long)PlayerFunctions.GunList[GunIndex], false);
            HyperMEM.MEM.WriteByte(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + Offsets.PC_Camo2), 118, false);
        }

        // Token: 0x060001BE RID: 446 RVA: 0x0001CEA5 File Offset: 0x0001B0A5
        public static void GiveWeapon3(int ID, int GunIndex)
        {
            HyperMEM.MEM.WriteInt64(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + (Offsets.PC_SetWeaponID0 + Offsets.PC_GunStruct * 3UL)), (long)PlayerFunctions.GunList[GunIndex], false);
        }

        // Token: 0x060001BF RID: 447 RVA: 0x0001CED9 File Offset: 0x0001B0D9
        public static void GiveWeapon4(int ID, int GunIndex)
        {
            HyperMEM.MEM.WriteInt64(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + (Offsets.PC_SetWeaponID0 + Offsets.PC_GunStruct * 4UL)), (long)PlayerFunctions.GunList[GunIndex], false);
        }

        // Token: 0x060001C0 RID: 448 RVA: 0x0001CF0D File Offset: 0x0001B10D
        public static void GiveWeapon5(int ID, int GunIndex)
        {
            HyperMEM.MEM.WriteInt64(Offsets.PlayerCompPtr + (Offsets.PC_ArraySize_Offset * (ulong)((long)ID) + (Offsets.PC_SetWeaponID0 + Offsets.PC_GunStruct * 5UL)), (long)PlayerFunctions.GunList[GunIndex], false);
        }

        // Token: 0x040004C8 RID: 1224
        public static HyperMEM.Vectors.Vec3.Vector3[] Teleports = new HyperMEM.Vectors.Vec3.Vector3[]
        {
            new HyperMEM.Vectors.Vec3.Vector3(742.0477f, -413.0537f, -33.49968f),
            new HyperMEM.Vectors.Vec3.Vector3(32.41827f, 434.6326f, 1.125f),
            new HyperMEM.Vectors.Vec3.Vector3(-1054.955f, 322.5447f, -47.84928f),
            new HyperMEM.Vectors.Vec3.Vector3(1004.036f, -680.9578f, -255.875f),
            new HyperMEM.Vectors.Vec3.Vector3(-1348.923f, 1804.032f, -85.33665f),
            new HyperMEM.Vectors.Vec3.Vector3(-1805.112f, 269.1054f, -382.875f),
            new HyperMEM.Vectors.Vec3.Vector3(525.3798f, -78.01015f, -543.875f)
        };

        // Token: 0x040004C9 RID: 1225
        public static string[] TPS = new string[]
        {
            "Spawn",
            "Nacht",
            "Pond",
            "Power",
            "Facility",
            "Hanger",
            "PAP Machine"
        };

        // Token: 0x040004CA RID: 1226
        public static int[] Camos = new int[]
        {
            66,
            67,
            68,
            69
        };

        // Token: 0x040004CB RID: 1227
        public static string[] GunNames = new string[]
        {
            ""
        };

        // Token: 0x040004CC RID: 1228
        public static int[] GunList = new int[1];

        // Token: 0x040004CD RID: 1229
        public static string[] GunNamesZM = new string[0];

        // Token: 0x040004CE RID: 1230
        public static int[] GunListZM = new int[0];

        // Token: 0x040004CF RID: 1231
        public static string[] GunNamesMP = new string[0];

        // Token: 0x040004D0 RID: 1232
        public static int[] GunListMP = new int[0];
      

    }
}



