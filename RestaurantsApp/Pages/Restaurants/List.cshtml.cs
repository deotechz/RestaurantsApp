using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Core;
using ClassLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace RestaurantsApp.Pages.Restaurants
{
    public class ListModel : PageModel
    {
	    private readonly IConfiguration _configuration;
	    private readonly IRestaurantData _restaurantData;
	    private readonly ILogger<ListModel> _logger;

	    public ListModel(IConfiguration configuration, IRestaurantData restaurantData, ILogger<ListModel> logger)
	    {
		    _configuration = configuration;
		    _restaurantData = restaurantData;
		    _logger = logger;
	    }
	    public string Message { get; set; }
		public IEnumerable<Restaurant> Restaurants { get; set; }
		[BindProperty(SupportsGet = true)]
		public string SearchTerm { get; set; }

        public void OnGet()
        {
			//_logger.LogError("Executing ListModel");
	        Message = _configuration["Message"];
	        Restaurants = _restaurantData.GetRestaurantsByName(SearchTerm);
        }
    }
}