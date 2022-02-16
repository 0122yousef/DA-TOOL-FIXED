using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Newtonsoft.Json.Linq;
using PornHub.Branding;
using PornHub.Properties;
using ReaLTaiizor.Controls;

namespace PornHub.Security
{
	// Token: 0x02000014 RID: 20
	internal class WebAuth
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x00018BC8 File Offset: 0x00016DC8
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			select s[WebAuth.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00018C14 File Offset: 0x00016E14
		public static string Base64Encode(string plainText)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(plainText);
			return Convert.ToBase64String(bytes);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00018C38 File Offset: 0x00016E38
		public static string Base64Decode(string base64EncodedData)
		{
			byte[] bytes = Convert.FromBase64String(base64EncodedData);
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00018C5C File Offset: 0x00016E5C
		public static void Login(string username, string password)
		{
			using (WebClient webClient = new WebClient())
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				HardwareID hardwareID = new HardwareID();
				nameValueCollection["user"] = username;
				nameValueCollection["pass"] = WebAuth.Base64Encode(password);
				nameValueCollection["hwid"] = WebAuth.Base64Encode(hardwareID.Generate());
				nameValueCollection["key"] = "ferghyiuyt4fght6j78i7u6yh5gfghjkytr";
				nameValueCollection["toollogin"] = "yes";
				nameValueCollection["tool"] = "ColdWar";
				try
				{
					byte[] bytes = webClient.UploadValues("https://hyperhaxz.com/api.php", nameValueCollection);
					string @string = Encoding.UTF8.GetString(bytes);
					bool flag = @string.Contains("success");
					if (flag)
					{
						JToken jtoken = JToken.Parse(@string);
						JToken[] array = Extensions.Children<JToken>(jtoken.Values<JToken>()).ToArray<JToken>();
						UserInfo.username = jtoken.SelectToken("username").ToString();
						UserInfo.password = password;
						UserInfo.uid = jtoken.SelectToken("uid").ToString();
						JToken jtoken2 = JToken.Parse(jtoken.SelectToken("Subs").ToString());
						JToken[] array2 = Extensions.Children<JToken>(jtoken2.Values<JToken>()).ToArray<JToken>();
						UserInfo.invitedBy = jtoken2.SelectToken("Seller").ToString();
						return;
					}
				}
				catch
				{
				}
			}
			WebAuth.ReportMyself(true, "Failed to login at line 77 in Webauth.cs");
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00018E00 File Offset: 0x00017000
		public static void ApplyBranding(Form MainForm)
		{
			string invitedBy = UserInfo.invitedBy;
			bool flag = WebAuth.SkipBranding.Contains(invitedBy);
			if (!flag)
			{
				using (WebClient webClient = new WebClient())
				{
					try
					{
						byte[] bytes = webClient.DownloadData("https://hyperhaxz.com/Branding/ColdWar/" + invitedBy + "_BG.jpg");
						byte[] bytes2 = webClient.DownloadData("https://hyperhaxz.com/Branding/ColdWar/" + invitedBy + "_BTN.png");
						string text = webClient.DownloadString("https://hyperhaxz.com/Branding/ColdWar/" + invitedBy + "_COLOR");
						string discordLink = webClient.DownloadString("https://hyperhaxz.com/Branding/ColdWar/" + invitedBy + "_DISCORD");
						UserInfo.DiscordLink = discordLink;
						Directory.CreateDirectory(Path.GetTempPath() + "Hyper Loader\\");
						string text2 = Path.GetTempPath() + "Hyper Loader\\" + invitedBy + "_BG.jpg";
						bool flag2 = !File.Exists(text2);
						if (flag2)
						{
							File.WriteAllBytes(text2, bytes);
						}
						else
						{
							bool flag3 = File.GetLastWriteTime(text2).AddDays(1.0) < DateTime.Now;
							if (flag3)
							{
								File.Delete(text2);
								File.WriteAllBytes(text2, bytes);
							}
						}
						MainForm.BackgroundImage = Image.FromFile(text2);
						string text3 = Path.GetTempPath() + "Hyper Loader\\" + invitedBy + "_BTN.png";
						bool flag4 = !File.Exists(text3);
						if (flag4)
						{
							File.WriteAllBytes(text3, bytes2);
						}
						else
						{
							bool flag5 = File.GetLastWriteTime(text3).AddDays(1.0) < DateTime.Now;
							if (flag5)
							{
								File.Delete(text3);
								File.WriteAllBytes(text3, bytes2);
							}
						}
						ColorConverter colorConverter = new ColorConverter();
						Color color = (Color)colorConverter.ConvertFromString(text);
						IEnumerable<MetroSwitch> enumerable = MainForm.FindAllChildrenByType<MetroSwitch>();
						IEnumerable<ForeverButton> enumerable2 = MainForm.FindAllChildrenByType<ForeverButton>();
						IEnumerable<NightHeaderLabel> enumerable3 = MainForm.FindAllChildrenByType<NightHeaderLabel>();
						IEnumerable<IconPictureBox> enumerable4 = MainForm.FindAllChildrenByType<IconPictureBox>();
						foreach (MetroSwitch metroSwitch in enumerable)
						{
							metroSwitch.CheckColor = color;
						}
						foreach (ForeverButton foreverButton in enumerable2)
						{
							foreverButton.TextColor = color;
							foreverButton.BackgroundImage = Image.FromFile(text3);
						}
						foreach (NightHeaderLabel nightHeaderLabel in enumerable3)
						{
							nightHeaderLabel.ForeColor = color;
						}
						foreach (IconPictureBox iconPictureBox in enumerable4)
						{
							iconPictureBox.ForeColor = color;
						}
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00019178 File Offset: 0x00017378
		public static void ApplyLoadingBranding(PictureBox MainForm)
		{
			string invitedBy = UserInfo.invitedBy;
			bool flag = WebAuth.SkipBranding.Contains(invitedBy);
			if (!flag)
			{
				using (WebClient webClient = new WebClient())
				{
					try
					{
						byte[] bytes = webClient.DownloadData("https://hyperhaxz.com/Branding/ColdWar/" + invitedBy + "_GIF.gif");
						bool flag2 = !Directory.Exists(Path.GetTempPath() + "Hyper Loader\\");
						if (flag2)
						{
							Directory.CreateDirectory(Path.GetTempPath() + "Hyper Loader\\");
						}
						string text = Path.GetTempPath() + "Hyper Loader\\" + invitedBy + "_GIF.gif";
						bool flag3 = !File.Exists(text);
						if (flag3)
						{
							File.WriteAllBytes(text, bytes);
						}
						else
						{
							bool flag4 = File.GetLastWriteTime(text).AddDays(1.0) < DateTime.Now;
							if (flag4)
							{
								File.Delete(text);
								File.WriteAllBytes(text, bytes);
							}
						}
						MainForm.Image = Image.FromFile(text);
					}
					catch
					{
						MainForm.Image = Resources.Default_GIIF;
					}
				}
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000192B4 File Offset: 0x000174B4
		public static void BanMyself(string Reason)
		{
			using (WebClient webClient = new WebClient())
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				HardwareID hardwareID = new HardwareID();
				nameValueCollection["user"] = UserInfo.username;
				nameValueCollection["pass"] = WebAuth.Base64Encode(UserInfo.password);
				nameValueCollection["hwid"] = WebAuth.Base64Encode(hardwareID.Generate());
				nameValueCollection["key"] = "ferghyiuyt4fght6j78i7u6yh5gfghjkytr";
				nameValueCollection["beanz"] = "yes";
				nameValueCollection["tool"] = "ColdWar";
				nameValueCollection["reason"] = Reason;
				try
				{
					byte[] bytes = webClient.UploadValues("https://hyperhaxz.com/api.php", nameValueCollection);
					string @string = Encoding.UTF8.GetString(bytes);
				}
				catch
				{
				}
				Functions.CloseMyself();
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000193A8 File Offset: 0x000175A8
		public static void ReportMyself(bool Close, string Reason)
		{
			using (WebClient webClient = new WebClient())
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				HardwareID hardwareID = new HardwareID();
				nameValueCollection["user"] = UserInfo.username;
				nameValueCollection["pass"] = WebAuth.Base64Encode(UserInfo.password);
				nameValueCollection["hwid"] = WebAuth.Base64Encode(hardwareID.Generate());
				nameValueCollection["key"] = "ferghyiuyt4fght6j78i7u6yh5gfghjkytr";
				nameValueCollection["tool"] = "ColdWar";
				nameValueCollection["report"] = Reason;
				try
				{
					byte[] bytes = webClient.UploadValues("https://hyperhaxz.com/api.php", nameValueCollection);
					string @string = Encoding.UTF8.GetString(bytes);
				}
				catch
				{
				}
				if (Close)
				{
					Functions.CloseMyself();
				}
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00019494 File Offset: 0x00017694
		public static void ReportID(string ID)
		{
			using (WebClient webClient = new WebClient())
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				HardwareID hardwareID = new HardwareID();
				nameValueCollection["user"] = UserInfo.username;
				nameValueCollection["pass"] = WebAuth.Base64Encode(UserInfo.password);
				nameValueCollection["hwid"] = WebAuth.Base64Encode(hardwareID.Generate());
				nameValueCollection["key"] = "ferghyiuyt4fght6j78i7u6yh5gfghjkytr";
				nameValueCollection["tool"] = "ColdWar";
				nameValueCollection["DiscordID"] = ID;
				try
				{
					byte[] bytes = webClient.UploadValues("https://hyperhaxz.com/api.php", nameValueCollection);
					string @string = Encoding.UTF8.GetString(bytes);
				}
				catch
				{
				}
			}
		}

		// Token: 0x040002A8 RID: 680
		private static string UserName = "";

		// Token: 0x040002A9 RID: 681
		private static string Password = "";

		// Token: 0x040002AA RID: 682
		private static Random random = new Random();

		// Token: 0x040002AB RID: 683
		public static List<string> SkipBranding = new List<string>
		{
			"",
			"Hyper",
			"Hyper Store",
			"zqiN",
			"Lap",
			"CharlieDelta"
		};
	}
}
