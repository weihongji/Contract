using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace YLContract
{
	public class FieldValue : EntityBase
	{
		public int Id { get; set; }
		public int SystemUserId { get; set; }
		public int FieldId { get; set; }
		public string Value { get; set; }
		public DateTime DateStamp { get; set; }

		public FieldValue() {
		}

		public FieldValue(DataRow row) {
			this.Id = (int)row["Id"];
			this.SystemUserId = (int)row["SystemUserId"];
			this.FieldId = (int)row["FieldId"];
			this.Value = (string)row["Value"];
			this.DateStamp = (DateTime)row["DateStamp"];
		}

		public static List<FieldValue> GetList(int userId, int contractId) {
			var list = new List<FieldValue>();
	
			var sql = new StringBuilder();
			sql.AppendLine("SELECT V.*");
			sql.AppendLine("FROM FieldValue V");
			sql.AppendLine("	INNER JOIN Field F ON F.Id = V.FieldId");
			sql.AppendLine("	INNER JOIN [Contract] C ON C.Id = F.ContractId");
			sql.AppendLine("WHERE V.SystemUserId = " + userId);
			sql.AppendLine("	AND F.Active = 1");
			sql.AppendLine("	AND C.Id = 1" + contractId);
			sql.AppendLine("ORDER BY F.Sort, F.Id");

			var table = dao.ExecuteDataTable(sql.ToString());
			foreach (DataRow row in table.Rows) {
				list.Add(new FieldValue(row));
			}

			return list;
		}

		public static FieldValue GetById(int Id) {
			var table = dao.ExecuteDataTable("SELECT * FROM FieldValue WHERE Id = " + Id);
			if (table.Rows.Count > 0) {
				return new FieldValue((DataRow)table.Rows[0]);
			}
			return null;
		}
	}
}
