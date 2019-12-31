using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using ClassLibrary.Core;

namespace ClassLibrary.Data
{
	public class InMemoryRestaurantData : IRestaurantData
	{
		private List<Restaurant> restaurants;
		public InMemoryRestaurantData()
		{
			restaurants = new List<Restaurant>()
			{
				new Restaurant{Id = 1, Name = "Namaste Thakali", Location = "Durbar Marg", Cuisine = CuisineType.Nepali},
				new Restaurant{Id = 2, Name = "Bombay Biryani", Location = "Thamel", Cuisine = CuisineType.Indian},
				new Restaurant{Id = 3, Name = "Pizzerian", Location = "New Road", Cuisine = CuisineType.Italian}
			};
		}

		public Restaurant GetById(int id)
		{
			return restaurants.SingleOrDefault(r => r.Id == id);
		}

		public Restaurant Add(Restaurant newRestaurant)
		{
			restaurants.Add(newRestaurant);
			newRestaurant.Id = restaurants.Max(r => r.Id) + 1;
			return newRestaurant;
		}

		public Restaurant Delete(int id)
		{
			var restaurant = restaurants.FirstOrDefault(r => r.Id == id);
			if (restaurant != null)
			{
				restaurants.Remove(restaurant);
			}

			return restaurant;
		}

		public Restaurant Update(Restaurant updatedRestaurant)
		{
			var restaurant = restaurants.SingleOrDefault(r => r.Id == updatedRestaurant.Id);
			if (restaurant != null)
			{
				restaurant.Name = updatedRestaurant.Name;
				restaurant.Location = updatedRestaurant.Location;
				restaurant.Cuisine = updatedRestaurant.Cuisine;
			}

			return restaurant;
		}

		public int Commit()
		{
			return 0;
		}

		public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
		{
			return from r in restaurants
				where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
				orderby r.Name
				select r;
		}

		public int GetCountOfRestaurants()
		{
			return restaurants.Count();
		}
	}
}