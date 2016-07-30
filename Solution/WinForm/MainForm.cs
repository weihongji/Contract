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
	public partial class MainForm : Form
	{
		public static SystemUser CurrentUser { get; set; }

		public MainForm() {
			InitializeComponent();
			SetForm();
		}

		private void SetForm() {
			this.Text = "合同录入系统";
		}

		private void MainForm_Load(object sender, EventArgs e) {
			if (LoginUser()) {
				InitSystem();
			}
			else {
				this.Close();
				return;
			}
		}

		private void menuSystem_CloseAll_Click(object sender, EventArgs e) {
			CloseAllChildren();
		}

		private void menuSystem_Users_Click(object sender, EventArgs e) {

		}

		private void menuSystem_Logout_Click(object sender, EventArgs e) {
			CleanSystem();
			this.Hide();
			if (LoginUser()) {
				InitSystem();
				this.Show();
			}
			else {
				this.Close();
				return;
			}
		}

		private void menuSystem_Exit_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void CloseAllChildren() {
			foreach (var child in this.MdiChildren) {
				child.Close();
			}
		}

		private bool LoginUser() {
			var success = new LoginForm().ShowDialog() == System.Windows.Forms.DialogResult.OK;
			return success;
		}

		private void InitSystem() {
			// Initialize UI
			this.toolStripStatusUser.Text = "当前用户：" + (CurrentUser == null ? "未登录" : CurrentUser.Name);

			if (CurrentUser != null) {
				foreach (ToolStripMenuItem item in this.menuStrip1.Items) {
					item.Visible = true;
				}

				if (CurrentUser.Role == XEnum.UserRole.Admin) {
					this.menuSystem_Users.Visible = true;
				}
				else {
					this.menuSystem_Users.Visible = false;
				}
			}
		}

		private void CleanSystem() {
			CloseAllChildren();
			foreach (ToolStripMenuItem item in this.menuStrip1.Items) {
				if (item.Name.Equals("menuSystem")) {
					continue;
				}
				item.Visible = false;
			}
		}

		private void menuGroup_Item_Click(object sender, EventArgs e) {
			if (!(sender is ToolStripMenuItem)) {
				Message.ShowError(this, "Un-expected sender.");
				return;
			}

			var menuName = ((ToolStripMenuItem)sender).Name;
			var contractId = GetContractId(menuName);
			if (contractId == 0) {
				Message.ShowError(this, string.Format("Incorrect contrat menu name '{0}' which does not follow naming convention.", menuName));
				return;
			}
			ShowContractForm(contractId);
		}

		private int GetContractId(string menuName) {
			int id = 0;
			var token = "menuContract";
			int index = menuName.IndexOf(token); // menuContract01
			if (index >= 0) {
				if (!int.TryParse(menuName.Substring(index + token.Length), out id)) {
					id = 0;
				}
			}
			return id;
		}

		private void ShowContractForm(int id) {
			var name = "ContractForm_" + id;

			// If already exists, activate it.
			foreach (var child in this.MdiChildren) {
				if (child.Name.Equals(name)) {
					child.Visible = true;
					child.Activate();
					return;
				}
			}

			// Not exist, so create & show it.
			Form form;
			form = new FormPic();

			if (this.MdiChildren.Length == 0) { // Open first form in maximized window
				form.WindowState = FormWindowState.Maximized;
			}
			form.MdiParent = this;
			form.Name = name;
			form.Text = "合同 " + id;
			form.Show();
		}
	}
}
