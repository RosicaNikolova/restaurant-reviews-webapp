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
    public class HomeModel : PageModel
    {
        public List<Restaurant> restaurants = new List<Restaurant>();
        public IActionResult OnGet()
        {
            try
            {
                RestaurantManager restaurantManager = new RestaurantManager(new RestaurantRepository());
                restaurants = restaurantManager.GetAllRestaurants();
                return Page();
            }
            catch (DataBaseException)
            {
                ViewData["Error_message"] = "An error occured while adding the content of this page. Please, try again.";
                return new RedirectToPageResult("Error");

            }
            catch (Exception)
            {
                ViewData["Error_message"] = "An error occured while adding the content of this page. Please, try again.";
                return new RedirectToPageResult("Error");
            }

        }
    }
}
