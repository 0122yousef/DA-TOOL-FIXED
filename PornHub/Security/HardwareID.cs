using System;
using System.Collections.Generic;
using System.Globalization;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace PornHub.Security
{
	// Token: 0x02000012 RID: 18
	public class HardwareID
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00018150 File Offset: 0x00016350
		public static string identifier(string wmiClass, string wmiProperty)
		{
			string text = "";
			ManagementClass managementClass = new ManagementClass(wmiClass);
			ManagementObjectCollection instances = managementClass.GetInstances();
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				bool flag = text == "";
				if (flag)
				{
					try
					{
						text = managementObject[wmiProperty].ToString();
						break;
					}
					catch
					{
					}
				}
			}
			return text;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000181EC File Offset: 0x000163EC
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000181F4 File Offset: 0x000163F4
		public string LastID { get; private set; } = string.Empty;

		// Token: 0x060000A6 RID: 166 RVA: 0x00018214 File Offset: 0x00016414
		~HardwareID()
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00018240 File Offset: 0x00016440
		public string Generate()
		{
			string[] value = new string[]
			{
				this.GetProperties(HardwareID.WMI_CLASSES.CPU)
			};
			return this.LastID = this.GetHash(string.Join(string.Empty, value));
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00018284 File Offset: 0x00016484
		private string GetProperties(string[] wmiData)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string queryString = this.GenerateQuery(wmiData);
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", queryString))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
					{
						using (managementBaseObject)
						{
							for (int i = 1; i < wmiData.Length; i++)
							{
								stringBuilder.Append(managementBaseObject[wmiData[i]]);
							}
						}
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00018378 File Offset: 0x00016578
		private string GenerateQuery(string[] wmiData)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string str = string.Empty;
			stringBuilder.Append("SELECT ");
			for (int i = 0; i < wmiData.Length; i++)
			{
				bool flag = i == 0;
				if (flag)
				{
					str = wmiData[i];
				}
				else
				{
					stringBuilder.Append((i < wmiData.Length - 1) ? (wmiData[i] + ", ") : (wmiData[i] + " "));
				}
			}
			stringBuilder.Append("FROM " + str);
			return stringBuilder.ToString();
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0001840C File Offset: 0x0001660C
		private string GetHash(string data)
		{
			string hexString;
			using (SHA1CryptoServiceProvider sha1CryptoServiceProvider = new SHA1CryptoServiceProvider())
			{
				byte[] bt = sha1CryptoServiceProvider.ComputeHash(Encoding.Default.GetBytes(data));
				hexString = this.GetHexString(bt);
			}
			return hexString;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0001845C File Offset: 0x0001665C
		private string GetHexString(IList<byte> bt)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < bt.Count; i++)
			{
				byte b = bt[i];
				byte b2 = b;
				int num = (int)(b2 & 15);
				int num2 = b2 >> 4 & 15;
				bool flag = num2 > 9;
				if (flag)
				{
					stringBuilder.Append(((char)(num2 - 10 + 65)).ToString(CultureInfo.InvariantCulture));
				}
				else
				{
					stringBuilder.Append(num2.ToString(CultureInfo.InvariantCulture));
				}
				bool flag2 = num > 9;
				if (flag2)
				{
					stringBuilder.Append(((char)(num - 10 + 65)).ToString(CultureInfo.InvariantCulture));
				}
				else
				{
					stringBuilder.Append(num.ToString(CultureInfo.InvariantCulture));
				}
				bool flag3 = i + 1 != bt.Count && (i + 1) % 2 == 0;
				if (flag3)
				{
					stringBuilder.Append("-");
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0200003D RID: 61
		private static class WMI_CLASSES
		{
			// Token: 0x0400052B RID: 1323
			public static readonly string[] MOTHERBOARD = new string[]
			{
				"Win32_BaseBoard",
				"Name",
				"Manufacturer",
				"Version"
			};

			// Token: 0x0400052C RID: 1324
			public static readonly string[] GPU = new string[]
			{
				"Win32_VideoController",
				"Name",
				"DeviceID",
				"DriverVersion"
			};

			// Token: 0x0400052D RID: 1325
			public static readonly string[] CDROM = new string[]
			{
				"Win32_CDROMDrive",
				"Name",
				"Manufacturer",
				"DeviceID"
			};

			// Token: 0x0400052E RID: 1326
			public static readonly string[] CPU = new string[]
			{
				"Win32_Processor",
				"Name",
				"Manufacturer",
				"ProcessorId"
			};

			// Token: 0x0400052F RID: 1327
			public static readonly string[] HDD = new string[]
			{
				"Win32_DiskDrive",
				"Name",
				"Manufacturer",
				"Model"
			};

			// Token: 0x04000530 RID: 1328
			public static readonly string[] BIOS = new string[]
			{
				"Win32_BIOS",
				"Name",
				"Manufacturer",
				"Version"
			};
		}
	}
}
