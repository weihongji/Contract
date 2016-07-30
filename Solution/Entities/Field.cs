using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace YLContract
{
	public class Field : EntityBase
	{
		public int Id { get; set; }
		public int ContractId { get; set; }
		public string Name { get; set; }
		public string Token { get; set; }
		public XEnum.FieldType FieldType { get; set; }
		public string Description { get; set; }
		public bool Required { get; set; }
		public int X { get; set; }
		public int Y { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public string Sort { get; set; }
		public bool Active { get; set; }
		public DateTime DateStamp { get; set; }

		public Field() {
		}

		public Field(DataRow row) {
			this.Id = (int)row["Id"];
			this.ContractId = (int)row["ContractId"];
			this.Name = (string)row["Name"];
			this.Token = (string)row["Token"];
			this.FieldType = (XEnum.FieldType)((short)row["FieldType"]);
			this.Description = row["Description"] == DBNull.Value ? "" : (string)row["Description"];
			this.Required = (bool)row["Required"];
			this.X = (int)row["X"];
			this.Y = (int)row["Y"];
			this.Width = (int)row["Width"];
			this.Height = (int)row["Height"];
			this.Sort = (string)row["Sort"];
			this.Active = (bool)row["Active"];
			this.DateStamp = (DateTime)row["DateStamp"];
		}

		public static List<Field> GetList() {
			return GetList(true);
		}

		public static List<Field> GetList(bool activeOnly) {
			var list = new List<Field>();
			var where = activeOnly ? "WHERE Active = 1" : "";
			var sql = "SELECT * FROM Field " + where + " ORDER BY Sort, Id";
			var table = dao.ExecuteDataTable(sql);
			foreach (DataRow row in table.Rows) {
				list.Add(new Field(row));
			}
			return list;
		}

		public static Field GetById(int Id) {
			var table = dao.ExecuteDataTable("SELECT * FROM Field WHERE Id = " + Id);
			if (table.Rows.Count > 0) {
				return new Field((DataRow)table.Rows[0]);
			}
			return null;
		}
	}
}
