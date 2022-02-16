using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PornHub.Security
{
	// Token: 0x02000010 RID: 16
	public class Crypto
	{
		// Token: 0x06000099 RID: 153 RVA: 0x00017654 File Offset: 0x00015854
		public static string EncryptStringAES(string plainText, string sharedSecret)
		{
			bool flag = string.IsNullOrEmpty(plainText);
			if (flag)
			{
				throw new ArgumentNullException("plainText");
			}
			bool flag2 = string.IsNullOrEmpty(sharedSecret);
			if (flag2)
			{
				throw new ArgumentNullException("sharedSecret");
			}
			string result = null;
			RijndaelManaged rijndaelManaged = null;
			try
			{
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(sharedSecret, Crypto._salt);
				rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					memoryStream.Write(BitConverter.GetBytes(rijndaelManaged.IV.Length), 0, 4);
					memoryStream.Write(rijndaelManaged.IV, 0, rijndaelManaged.IV.Length);
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
					{
						using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
						{
							streamWriter.Write(plainText);
						}
					}
					result = Convert.ToBase64String(memoryStream.ToArray());
				}
			}
			finally
			{
				bool flag3 = rijndaelManaged != null;
				if (flag3)
				{
					rijndaelManaged.Clear();
				}
			}
			return result;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000177B4 File Offset: 0x000159B4
		public static string DecryptStringAES(string cipherText, string sharedSecret)
		{
			bool flag = string.IsNullOrEmpty(cipherText);
			if (flag)
			{
				throw new ArgumentNullException("cipherText");
			}
			bool flag2 = string.IsNullOrEmpty(sharedSecret);
			if (flag2)
			{
				throw new ArgumentNullException("sharedSecret");
			}
			RijndaelManaged rijndaelManaged = null;
			string result = null;
			try
			{
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(sharedSecret, Crypto._salt);
				byte[] buffer = Convert.FromBase64String(cipherText);
				using (MemoryStream memoryStream = new MemoryStream(buffer))
				{
					rijndaelManaged = new RijndaelManaged();
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
					rijndaelManaged.IV = Crypto.ReadByteArray(memoryStream);
					ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
					{
						using (StreamReader streamReader = new StreamReader(cryptoStream))
						{
							result = streamReader.ReadToEnd();
						}
					}
				}
			}
			finally
			{
				bool flag3 = rijndaelManaged != null;
				if (flag3)
				{
					rijndaelManaged.Clear();
				}
			}
			return result;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000178F0 File Offset: 0x00015AF0
		private static byte[] ReadByteArray(Stream s)
		{
			byte[] array = new byte[4];
			bool flag = s.Read(array, 0, array.Length) != array.Length;
			if (flag)
			{
				throw new SystemException("Stream did not contain properly formatted byte array");
			}
			byte[] array2 = new byte[BitConverter.ToInt32(array, 0)];
			bool flag2 = s.Read(array2, 0, array2.Length) != array2.Length;
			if (flag2)
			{
				throw new SystemException("Did not read byte array properly");
			}
			return array2;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00017960 File Offset: 0x00015B60
		public static ulong GetNumber(string Hashed)
		{
			string s = Crypto.DecryptStringAES(Hashed, "zqingay");
			return ulong.Parse(s);
		}

		// Token: 0x0400029F RID: 671
		private static byte[] _salt = Encoding.ASCII.GetBytes("Add a app specific salt here");
	}
}
