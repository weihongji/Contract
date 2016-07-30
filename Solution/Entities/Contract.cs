using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace YLContract
{
	public class Contract : EntityBase
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int GroupId { get; set; }
		public string Sort { get; set; }
		public bool Active { get; set; }
		public DateTime DateStamp { get; set; }

		private List<Field> _fields;

		public Contract() {
		}

		public Contract(DataRow row) {
			this.Id = (int)row["Id"];
			this.Name = (string)row["Name"];
			this.GroupId = (int)row["GroupId"];
			this.Sort = (string)row["Sort"];
			this.Active = (bool)row["Active"];
			this.DateStamp = (DateTime)row["DateStamp"];
		}

		public List<Field> Fields {
			get {
				if (_fields == null) {
					_fields = GetFields();
				}
				return _fields;
			}
		}

		public static List<Contract> GetList() {
			return GetList(0);
		}

		public static List<Contract> GetList(int groupId) {
			var list = new List<Contract>();
			var sql = "SELECT * FROM Contract";
			if (groupId > 0) {
				sql += " WHERE GroupId = " + groupId;
			}
			sql += " ORDER BY Sort, Id";
			var table = dao.ExecuteDataTable(sql);
			foreach (DataRow row in table.Rows) {
				list.Add(new Contract(row));
			}
			return list;
		}

		public static Contract GetById(int Id) {
			var table = dao.ExecuteDataTable("SELECT * FROM Contract WHERE Id = " + Id);
			if (table.Rows.Count > 0) {
				return new Contract((DataRow)table.Rows[0]);
			}
			return null;
		}

		private List<Field> GetFields() {
			var list = new List<Field>();
			var table = dao.ExecuteDataTable("SELECT * FROM ImportItem WHERE ImportId = " + this.Id);
			foreach (DataRow row in table.Rows) {
				list.Add(new Field(row));
			}
			return list;
		}
	}
}
