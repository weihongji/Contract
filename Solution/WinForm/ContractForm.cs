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
	public partial class ContractForm : Form
	{
		public ContractForm() {
			InitializeComponent();
			SetForm();
		}

		private void SetForm() {
			this.Text = "合同录入系统";
		}
	}
}
