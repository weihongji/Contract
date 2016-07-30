using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace YLContract
{
	public class Group : EntityBase
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public Group() {
		}

		public Group(DataRow row) {
			this.Id = (int)row["Id"];
			this.Name = (string)row["Name"];
		}

		public static List<Group> GetList() {
			var list = new List<Group>();
			var sql = "SELECT * FROM [Group] ORDER BY Id";
			var table = dao.ExecuteDataTable(sql);
			foreach (DataRow row in table.Rows) {
				list.Add(new Group(row));
			}
			return list;
		}

		public static Group GetById(int Id) {
			var table = dao.ExecuteDataTable("SELECT * FROM [Group] WHERE Id = " + Id);
			if (table.Rows.Count > 0) {
				return new Group((DataRow)table.Rows[0]);
			}
			return null;
		}
	}
}
