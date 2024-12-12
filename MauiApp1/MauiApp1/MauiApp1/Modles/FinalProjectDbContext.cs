// FinalProjectDbContext Class
// Inherets from DbContext class which handles interactions with database
// Its here so that we can interact with the database and set
// DbSet<T> to represent tables allowing us the add classes
// with attributes with them so that we can update and use them.


using MauiApp1.Components.Pages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Modles
{
	internal class FinalProjectDbContext : DbContext
	{
		public FinalProjectDbContext(DbContextOptions<FinalProjectDbContext> options) : base(options)
		{
		}

		// Define a DbSet for the Role table
		public DbSet<Role> Role { get; set; }

		// Define a DbSet for the Project table
		public DbSet<Project> Project { get; set; }

		// Define a DbSet for the Department table
		public DbSet<Department> Department { get; set; }

		// Define a DbSet for the Employee table
		public DbSet<Employee> Employee { get; set; }

		// Define a DbSet for the ProjectEmployee table
		public DbSet<ProjectEmployee> ProjectEmployee { get; set; }

		// Initiates the SqlConnection class with the connectiongString
		SqlConnection con = new SqlConnection(connectionString);
		private static string connectionString; // Here so that "connectionString" in line 41 doesn't show error :(
	}
}