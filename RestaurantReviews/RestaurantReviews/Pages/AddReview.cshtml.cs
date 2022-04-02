using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantReviews.Models;

namespace RestaurantReviews.Pages
{
    [Authorize]
    public class AddReviewModel : PageModel
    {
        public List<Restaurant> restaurants = new List<Restaurant>();

        public void OnGet()
        {
            RestaurantManager restaurantManager = new RestaurantManager(new RestaurantRepository());
            restaurants = restaurantManager.GetAllRestaurants();
        }
    }
}
