using System.Collections.Generic;
using System.Linq;
using ClassLibrary.Core;
using Microsoft.EntityFrameworkCore;
using Remotion.Linq.Clauses;

namespace ClassLibrary.Data
{
	public class SqlRestaurantData : IRestaurantData
	{
		private readonly RestaurantDbContext _dbContext;

		public SqlRestaurantData(RestaurantDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public Restaurant Add(Restaurant newRestaurant)
		{
			_dbContext.Add(newRestaurant);
			return newRestaurant;
		}

		public int GetCountOfRestaurants()
		{
			return _dbContext.Restaurants.Count();
		}

		public int Commit()
		{
			return _dbContext.SaveChanges();
		}

		public Restaurant Delete(int id)
		{
			var restaurant = GetById(id);
			if (restaurant != null)
			{
				_dbContext.Restaurants.Remove(restaurant);
			}

			return restaurant;
		}

		public Restaurant GetById(int id)
		{
			return _dbContext.Restaurants.Find(id);
		}

		public IEnumerable<Restaurant> GetRestaurantsByName(string name)
		{
			var query = from r in _dbContext.Restaurants
				where r.Name.StartsWith(name) || string.IsNullOrEmpty(name)
				orderby r.Name
				select r;
			return query;
		}

		public Restaurant Update(Restaurant updatedRestaurant)
		{
			var entity = _dbContext.Restaurants.Attach(updatedRestaurant);
			entity.State = EntityState.Modified;
			return updatedRestaurant;
		}
	}
}