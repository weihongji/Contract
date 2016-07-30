using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YLContract
{
	public partial class LoginForm : Form
	{
		public LoginForm() {
			InitializeComponent();
			SetForm();
		}

		private void SetForm() {
			this.Text = "登录系统";
			this.txtAccount.Text = GetLastAccount();

			if (this.txtAccount.Text.Length > 0) {
				this.txtPassword.Select();
			}
		}

		private void btnLogin_Click(object sender, EventArgs e) {
			var account = this.txtAccount.Text.Trim();
			var pwd = this.txtPassword.Text.Trim();
			if (account.Length == 0) {
				Message.ShowError(this, "请输入用户名");
				this.txtAccount.Focus();
				return;
			}
			if (pwd.Length == 0) {
				Message.ShowError(this, "请输入密码");
				this.txtPassword.Focus();
				return;
			}
			var user = SystemUser.GetByAccount(account);
			if (user == null) {
				Message.ShowError(this, String.Format("用户{0}不存在，请输入正确的用户名", user));
				this.txtAccount.SelectAll();
				this.txtAccount.Focus();
				return;
			}
			var pwdmd5 = DataUtility.GetMd5Hash(pwd);
			if (!user.Password.Equals(pwdmd5)) {
				Message.ShowError(this, String.Format("登录失败，请输入正确的用户名和密码", user));
				this.txtPassword.SelectAll();
				this.txtPassword.Focus();
				return;
			}

			// Login success
			WriteLastAccount(account);
			MainForm.CurrentUser = user;
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			this.Close();
		}

		private string GetLastAccount() {
			var account = IniFile.Read("Login", "account");
			return account;
		}

		private void WriteLastAccount(string account) {
			IniFile.Write("Login", "account", account);
		}
	}
}
