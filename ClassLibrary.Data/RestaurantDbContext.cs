using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Core;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Data
{
	public class RestaurantDbContext : DbContext
	{
		public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
		{
			
		}
		public DbSet<Restaurant> Restaurants { get; set; }
	}
}
