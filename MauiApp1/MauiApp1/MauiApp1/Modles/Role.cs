// Role Class just contains/initiates all the attributes
// Attributes are here based on what is in the DbSet or what attributes the table is connected with this class: Role
// Role table has 4 Attributes:
//roleId, roleName, description, departmentID


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Modles
{
	internal class Role
	{
		public int RoleID { get; set; } // Not Nullable
		public string? RoleName { get; set; } // Not Nullable
		public string? Description { get; set; } // Not Nullable
		public int? DepartmentID { get; set; } // Not Nullable
	}
}
