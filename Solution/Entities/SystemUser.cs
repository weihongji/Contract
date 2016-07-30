using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace YLContract
{
	public class SystemUser : EntityBase
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public XEnum.UserRole Role { get; set; }
		public XEnum.UserStatus Status { get; set; }
		public int FailedCount { get; set; }
		public DateTime DateStamp { get; set; }

		public SystemUser() {
		}

		public SystemUser(DataRow row) {
			this.Id = (int)row["Id"];
			this.Name = (string)row["Name"];
			this.Account = (string)row["Account"];
			this.Password = (string)row["Password"];
			this.Role = (XEnum.UserRole)((short)row["Role"]);
			this.Status = (XEnum.UserStatus)((short)row["Status"]);
			this.FailedCount = (int)row["FailedCount"];
			this.DateStamp = (DateTime)row["DateStamp"];
		}

		public static List<SystemUser> GetList() {
			return GetList(XEnum.UserStatus.ALL);
		}

		public static List<SystemUser> GetList(XEnum.UserStatus status) {
			var list = new List<SystemUser>();
			var where = status == XEnum.UserStatus.ALL ? "" : "WHERE status = " + (short)status;
			var sql = "SELECT * FROM SystemUser " + where + " ORDER BY Name";
			var table = dao.ExecuteDataTable(sql);
			foreach (DataRow row in table.Rows) {
				list.Add(new SystemUser(row));
			}
			return list;
		}

		public static SystemUser GetById(int Id) {
			var table = dao.ExecuteDataTable("SELECT * FROM SystemUser WHERE Id = " + Id);
			if (table.Rows.Count > 0) {
				return new SystemUser((DataRow)table.Rows[0]);
			}
			return null;
		}

		public static SystemUser GetByAccount(string account) {
			var p = new SqlParameter("@account", SqlDbType.VarChar, 50) { Value = account};
			var table = dao.ExecuteDataTable("SELECT * FROM SystemUser WHERE Account = @account", new SqlParameter[] {p});
			if (table.Rows.Count > 0) {
				return new SystemUser((DataRow)table.Rows[0]);
			}
			return null;
		}

		//public static string LoginUser(string account, string password) {
		//	var parameters = new List<SqlParameter>();
		//	parameters.Add(new SqlParameter("@account", SqlDbType.VarChar, 50) { Value = account});
		//	parameters.Add(new SqlParameter("@password", SqlDbType.VarChar, 50) { Value = password });
		//	var result = new SqlParameter("@result", SqlDbType.VarChar, 100);
		//	result.Direction = ParameterDirection.Output;
		//	parameters.Add(result);
		//	dao.ExecuteNonQuery("spLoginUser", CommandType.StoredProcedure, parameters.ToArray());

		//	return result.Value.ToString();
		//}
	}
}
