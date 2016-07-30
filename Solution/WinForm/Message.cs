using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YLContract
{
	public class Message
	{
		public static void ShowInfo(Form form, string msg) {
			MessageBox.Show(msg, form.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static void ShowError(Form form, string msg) {
			if (string.IsNullOrEmpty(msg)) {
				return;
			}
			if (msg.IndexOf("Exception") >= 0) {
				msg = "发生错误";
			}
			ShowErrorDialog(msg, form.Text);
		}

		public static void ShowErrorDialog(string msg, string title) {
			MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
