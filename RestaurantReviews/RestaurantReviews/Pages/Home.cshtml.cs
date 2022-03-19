using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantReviews.Models;

namespace RestaurantReviews.Pages
{
    public class HomeModel : PageModel
    {
        public List<Restaurant> restaurants = new List<Restaurant>();
        public IActionResult OnGet()
        {
            try
            {
                RestaurantManager restaurantManager = new RestaurantManager();
                restaurants = restaurantManager.GetAllRestaurants();
                return new RedirectToPageResult("Home");
            }
            catch (RestaurantException)
            {
                return Page();
            }

        }
    }
}
