namespace YLContract
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSystem_Pdf = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSystem_Word = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSystem_CloseAll = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSystem_Logout = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSystem_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuGroup1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuContract01 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuContract02 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuGroup2 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuContract03 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuGroup3 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuContract04 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuGroup4 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuContract05 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusUser = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuSystem_Users = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.statusBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem,
            this.menuGroup1,
            this.menuGroup2,
            this.menuGroup3,
            this.menuGroup4,
            this.menuWindow});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.MdiWindowListItem = this.menuWindow;
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "File";
			// 
			// menuSystem
			// 
			this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem_Pdf,
            this.menuSystem_Word,
            this.menuSystem_CloseAll,
            this.menuSystem_Users,
            this.menuSystem_Logout,
            this.menuSystem_Exit});
			this.menuSystem.Name = "menuSystem";
			this.menuSystem.Size = new System.Drawing.Size(61, 21);
			this.menuSystem.Text = "&System";
			// 
			// menuSystem_Pdf
			// 
			this.menuSystem_Pdf.Name = "menuSystem_Pdf";
			this.menuSystem_Pdf.Size = new System.Drawing.Size(158, 22);
			this.menuSystem_Pdf.Text = "Save As &Pdf";
			// 
			// menuSystem_Word
			// 
			this.menuSystem_Word.Name = "menuSystem_Word";
			this.menuSystem_Word.Size = new System.Drawing.Size(158, 22);
			this.menuSystem_Word.Text = "Save As &Word";
			this.menuSystem_Word.Visible = false;
			// 
			// menuSystem_CloseAll
			// 
			this.menuSystem_CloseAll.Name = "menuSystem_CloseAll";
			this.menuSystem_CloseAll.Size = new System.Drawing.Size(158, 22);
			this.menuSystem_CloseAll.Text = "&Close All";
			this.menuSystem_CloseAll.Click += new System.EventHandler(this.menuSystem_CloseAll_Click);
			// 
			// menuSystem_Logout
			// 
			this.menuSystem_Logout.Name = "menuSystem_Logout";
			this.menuSystem_Logout.Size = new System.Drawing.Size(158, 22);
			this.menuSystem_Logout.Text = "&Logout";
			this.menuSystem_Logout.Click += new System.EventHandler(this.menuSystem_Logout_Click);
			// 
			// menuSystem_Exit
			// 
			this.menuSystem_Exit.Name = "menuSystem_Exit";
			this.menuSystem_Exit.Size = new System.Drawing.Size(158, 22);
			this.menuSystem_Exit.Text = "E&xit";
			this.menuSystem_Exit.Click += new System.EventHandler(this.menuSystem_Exit_Click);
			// 
			// menuGroup1
			// 
			this.menuGroup1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuContract01,
            this.menuContract02});
			this.menuGroup1.Name = "menuGroup1";
			this.menuGroup1.Size = new System.Drawing.Size(68, 21);
			this.menuGroup1.Text = "Group &1";
			// 
			// menuContract01
			// 
			this.menuContract01.Name = "menuContract01";
			this.menuContract01.Size = new System.Drawing.Size(136, 22);
			this.menuContract01.Text = "Contract 1";
			this.menuContract01.Click += new System.EventHandler(this.menuGroup_Item_Click);
			// 
			// menuContract02
			// 
			this.menuContract02.Name = "menuContract02";
			this.menuContract02.Size = new System.Drawing.Size(136, 22);
			this.menuContract02.Text = "Contract 2";
			this.menuContract02.Click += new System.EventHandler(this.menuGroup_Item_Click);
			// 
			// menuGroup2
			// 
			this.menuGroup2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuContract03});
			this.menuGroup2.Name = "menuGroup2";
			this.menuGroup2.Size = new System.Drawing.Size(68, 21);
			this.menuGroup2.Text = "Group &2";
			// 
			// menuContract03
			// 
			this.menuContract03.Name = "menuContract03";
			this.menuContract03.Size = new System.Drawing.Size(136, 22);
			this.menuContract03.Text = "Contract 1";
			this.menuContract03.Click += new System.EventHandler(this.menuGroup_Item_Click);
			// 
			// menuGroup3
			// 
			this.menuGroup3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuContract04});
			this.menuGroup3.Name = "menuGroup3";
			this.menuGroup3.Size = new System.Drawing.Size(68, 21);
			this.menuGroup3.Text = "Group &3";
			// 
			// menuContract04
			// 
			this.menuContract04.Name = "menuContract04";
			this.menuContract04.Size = new System.Drawing.Size(136, 22);
			this.menuContract04.Text = "Contract 1";
			this.menuContract04.Click += new System.EventHandler(this.menuGroup_Item_Click);
			// 
			// menuGroup4
			// 
			this.menuGroup4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuContract05});
			this.menuGroup4.Name = "menuGroup4";
			this.menuGroup4.Size = new System.Drawing.Size(68, 21);
			this.menuGroup4.Text = "Group &4";
			// 
			// menuContract05
			// 
			this.menuContract05.Name = "menuContract05";
			this.menuContract05.Size = new System.Drawing.Size(136, 22);
			this.menuContract05.Text = "Contract 1";
			this.menuContract05.Click += new System.EventHandler(this.menuGroup_Item_Click);
			// 
			// menuWindow
			// 
			this.menuWindow.Name = "menuWindow";
			this.menuWindow.Size = new System.Drawing.Size(67, 21);
			this.menuWindow.Text = "&Window";
			// 
			// statusBar
			// 
			this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusUser});
			this.statusBar.Location = new System.Drawing.Point(0, 708);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(1008, 22);
			this.statusBar.TabIndex = 3;
			this.statusBar.Text = "statusStrip1";
			// 
			// toolStripStatusUser
			// 
			this.toolStripStatusUser.Name = "toolStripStatusUser";
			this.toolStripStatusUser.Size = new System.Drawing.Size(82, 17);
			this.toolStripStatusUser.Text = "Current User";
			// 
			// menuSystem_Users
			// 
			this.menuSystem_Users.Name = "menuSystem_Users";
			this.menuSystem_Users.Size = new System.Drawing.Size(158, 22);
			this.menuSystem_Users.Text = "&Users";
			this.menuSystem_Users.Click += new System.EventHandler(this.menuSystem_Users_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 730);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main Form";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuSystem;
		private System.Windows.Forms.ToolStripMenuItem menuGroup1;
		private System.Windows.Forms.ToolStripMenuItem menuGroup2;
		private System.Windows.Forms.ToolStripMenuItem menuGroup3;
		private System.Windows.Forms.ToolStripMenuItem menuGroup4;
		private System.Windows.Forms.ToolStripMenuItem menuWindow;
		private System.Windows.Forms.ToolStripMenuItem menuSystem_Exit;
		private System.Windows.Forms.ToolStripMenuItem menuContract01;
		private System.Windows.Forms.ToolStripMenuItem menuContract02;
		private System.Windows.Forms.ToolStripMenuItem menuContract03;
		private System.Windows.Forms.ToolStripMenuItem menuContract04;
		private System.Windows.Forms.ToolStripMenuItem menuContract05;
		private System.Windows.Forms.ToolStripMenuItem menuSystem_CloseAll;
		private System.Windows.Forms.ToolStripMenuItem menuSystem_Pdf;
		private System.Windows.Forms.ToolStripMenuItem menuSystem_Word;
		private System.Windows.Forms.ToolStripMenuItem menuSystem_Logout;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusUser;
		private System.Windows.Forms.ToolStripMenuItem menuSystem_Users;
	}
}

