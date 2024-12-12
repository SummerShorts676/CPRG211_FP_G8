// Department Class just contains/initiates all the attributes
// Attributes are here based on what is in the DbSet or what attributes the table is connected with this class: Department
// Projects table has 2 Attributes:
// departmentID; departmentName


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Modles
{
	internal class Department
	{
		public int DepartmentID { get; set; } // Not Nullable
		public string? DepartmentName { get; set; } // Nullable
	}
}
