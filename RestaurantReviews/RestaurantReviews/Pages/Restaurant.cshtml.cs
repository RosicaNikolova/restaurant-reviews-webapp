using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantReviews.Models;

namespace RestaurantReviews.Pages
{
    public class RestaurantModel : PageModel
    {
        public Restaurant restaurant;
        public List<Review> reviews;
        
        public IActionResult OnGet(int id)
        {
            RestaurantManager restaurantManager = new RestaurantManager(new RestaurantRepository());
            ReviewManager reviewManager = new ReviewManager();

            try {
                restaurant = restaurantManager.GetRestaurant((int)id);
                reviews = reviewManager.GetReviewsForRestaurant((int)id);
                return Page();
            }
            catch(RestaurantException)
            {
                return new RedirectToPageResult("Home");
            }

            
        }
    }
}
