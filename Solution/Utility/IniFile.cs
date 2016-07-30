using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace YLContract
{
	public class IniFile
	{
		[System.Runtime.InteropServices.DllImport("kernel32")]
		private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

		[System.Runtime.InteropServices.DllImport("kernel32")]
		private static extern int GetPrivateProfileString(string section, string key, string def, System.Text.StringBuilder retVal, int size, string filePath);

		private static string iniPath = System.Environment.CurrentDirectory + "\\YLContract.ini";

		public static void Write(string section, string key, string value) {
			WritePrivateProfileString(section, key, value, iniPath);
		}

		public static string Read(string section, string key) {
			System.Text.StringBuilder temp = new System.Text.StringBuilder(1024);
			GetPrivateProfileString(section, key, "", temp, 1024, iniPath);
			return temp.ToString();
		}
	}
}
