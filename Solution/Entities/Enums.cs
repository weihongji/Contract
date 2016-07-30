using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YLContract
{
	public class XEnum
	{
		public enum UserStatus
		{
			ALL = -1,
			Inactivated = 0,
			Active = 1,
			Locked = 2
		}

		public enum UserRole
		{
			Staff = 1,
			Admin = 2
		}

		public enum FieldType
		{
			Textbox = 1,
			Checkbox = 2
		}
	}
}
