using Microsoft.EntityFrameworkCore; // Add this
using MauiApp1.Modles; // Ensure the namespace matches your DbContext class
using Microsoft.Extensions.Logging;

namespace MauiApp1
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});

			builder.Services.AddMauiBlazorWebView();

#if DEBUG
			builder.Services.AddBlazorWebViewDeveloperTools();
			builder.Logging.AddDebug();
#endif

			// Add the connection string for your SQL Server database
			var connectionString = "Server=SABO_JIMMY_SD\\CPRG211FPDB;Database=123456;User Id=sa;Password=12345;Encrypt=True;TrustServerCertificate=True;";


			// Register the DbContext with the connection string
			builder.Services.AddDbContext<FinalProjectDbContext>(options =>
	options.UseSqlServer(connectionString)
		   .EnableSensitiveDataLogging() // Logs parameters
		   .LogTo(Console.WriteLine));   // Logs queries to console


			return builder.Build();
		}
	}
}

