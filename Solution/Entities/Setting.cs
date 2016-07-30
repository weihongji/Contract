using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace YLContract
{
	public class Setting : EntityBase
	{
		public int UserMaxLock { get; set; }

		public Setting(DataRow row) {
			this.UserMaxLock = (int)row["UserMaxLock"];
		}
	}
}
