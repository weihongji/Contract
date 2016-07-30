using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace YLContract
{
	public class DataUtility
	{
		public static string GetValue(DbDataReader reader, int column) {
			object val = reader[column];
			var s = string.Empty;
			if (val != DBNull.Value) {
				s = val.ToString().Trim();
			}
			return s;
		}

		public static string GetSqlValue(DbDataReader reader, int column, string dateTimePattern = "") {
			object val = reader[column];
			var s = string.Empty;
			if (val == DBNull.Value) {
				s = "NULL";
			}
			else {
				if (val is DateTime) {
					if (string.IsNullOrEmpty(dateTimePattern)) {
						dateTimePattern = "yyyy/MM/dd";
					}
					if (((DateTime)val).Year == 1900) {
						s = "NULL";
					}
					else {
						s = "'" + ((DateTime)val).ToString(dateTimePattern) + "'";
					}
				}
				else if (val is double) {
					s = Math.Round((double)val, 4).ToString();
				}
				else {
					s = "'" + val.ToString().Trim().Replace("'", "''") + "'";
				}
			}
			return s;
		}

		#region "MD5"
		// MD5 functions are copied from https://msdn.microsoft.com/en-us/library/system.security.cryptography.md5(v=vs.110).aspx

		public static string GetMd5Hash(string input) {
			MD5 md5Hash = MD5.Create();
			string hash = GetMd5Hash(md5Hash, input);
			return hash;
		}

		static string GetMd5Hash(MD5 md5Hash, string input) {
			byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
			StringBuilder sBuilder = new StringBuilder();
			for (int i = 0; i < data.Length; i++) {
				sBuilder.Append(data[i].ToString("x2"));
			}
			return sBuilder.ToString();
		}

		static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash) {
			string hashOfInput = GetMd5Hash(md5Hash, input);
			StringComparer comparer = StringComparer.OrdinalIgnoreCase;
			return 0 == comparer.Compare(hashOfInput, hash);
		}
		#endregion
	}
}
