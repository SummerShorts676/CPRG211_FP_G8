// Project Class just contains/initiates all the attributes
// Attributes are here based on what is in the DbSet or what attributes the table is connected with this class: Projects
// Projects table has 3 Attributes:
// projectID; projectName; projectManagerID


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Modles
{
	internal class Project
	{
		public int ProjectID { get; set; } // Not Nullable
		public string? ProjectName { get; set; } // Not Nullable
		public int? ProjectManagerID { get; set; } // Not Nullable
	}
}
