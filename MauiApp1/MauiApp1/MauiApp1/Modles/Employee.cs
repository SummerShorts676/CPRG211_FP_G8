// Employee Class just contains/initiates all the attributes
// Attributes are here based on what is in the DbSet or what attributes the table is connected with this class: Employee
// Employee table has 3 Attributes:
// employeeID; firstName; lastName; email; phone; address; hired; roleID; salary


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Modles
{
	internal class Employee
	{
		public int EmployeeID { get; set; } // Not Nullable
		public string? FirstName { get; set; } // Not Nullable
		public string? LastName { get; set; } // Not Nullable
		public string? Email { get; set; } // Not Nullable
		public string? Phone { get; set; } // Not Nullable
		public string? Address { get; set; } // Not Nullable
		public DateTime? Hired { get; set; } // Not Nullable
		public int? RoleID { get; set; } // Not Nullable
		public int? Salary { get; set; } // Not Nullable
	}
}
