// ProjectEmployee Class just contains/initiates all the attributes
// Attributes are here based on what is in the DbSet or what attributes the table is connected with this class: ProjectEmployee
// Projects table has 2 Attributes:
// projectID; employeeID

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Modles
{
	[Keyless]
	internal class ProjectEmployee
	{
		public int ProjectID { get; set; }
		public int EmployeeID { get; set; }
	}
}
