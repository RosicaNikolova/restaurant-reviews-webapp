using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Business;
using ClassLibrary.Exceptions;
using ClassLibrary.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RestaurantReviews.Pages
{
    [Authorize]
    public class RestaurantModel : PageModel
    {
        public Restaurant restaurant;
        public List<Review> reviews;
        
        public IActionResult OnGet(int id)
        {
            RestaurantManager restaurantManager = new RestaurantManager(new RestaurantRepository());
            ReviewManager reviewManager = new ReviewManager(new ReviewRepository());

            try {
                restaurant = restaurantManager.GetRestaurant((int)id);
                reviews = reviewManager.GetReviewsForRestaurant((int)id);
                return Page();
            }
            catch(DataBaseException)
            {
                ViewData["Error_message"] = "An error occured while loading the page. Please, try again.";
                return new RedirectToPageResult("Error");
            }
            catch (Exception)
            {
                ViewData["Error_message"] = "An error occured while loading the page. Please, try again.";
                return new RedirectToPageResult("Error");
            } 
        }
    }
}
