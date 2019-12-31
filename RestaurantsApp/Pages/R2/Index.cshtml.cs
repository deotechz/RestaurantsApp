using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Core;
using ClassLibrary.Data;

namespace RestaurantsApp.Pages.R2
{
    public class IndexModel : PageModel
    {
        private readonly ClassLibrary.Data.RestaurantDbContext _context;

        public IndexModel(ClassLibrary.Data.RestaurantDbContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get;set; }

        public async Task OnGetAsync()
        {
            Restaurant = await _context.Restaurants.ToListAsync();
        }
    }
}
