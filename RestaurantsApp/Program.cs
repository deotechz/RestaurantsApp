using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace RestaurantsApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//			CreateWebHostBuilder(args).Build().Run();
			var host = CreateWebHostBuilder(args).Build();

			MigrateDatabase(host);

			host.Run();
		}

		private static void MigrateDatabase(IWebHost host)
		{
			using (var scope = host.Services.CreateScope())
			{
				var db = scope.ServiceProvider.GetRequiredService<RestaurantDbContext>();
				db.Database.Migrate();
			}
		}

		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>();
	}
}
