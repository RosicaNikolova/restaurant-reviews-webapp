using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Business;
using ClassLibrary.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace RestaurantReviews.Pages
{
    [Authorize]
    public class AddReviewModel : PageModel
    {
        [BindProperty]
        public Review createdReview{ get; set; }

        public List<Restaurant> restaurants = new List<Restaurant>();

        public void OnGet()
        {
            RestaurantManager restaurantManager = new RestaurantManager(new RestaurantRepository());
            restaurants = restaurantManager.GetAllRestaurants();
        }


        public IActionResult OnPost()
        {
            ReviewManager reviewManager = new ReviewManager(new ReviewRepository());
            if (ModelState.IsValid)
            {
                int userId = Convert.ToInt32(User.FindFirst("id").Value);
                try
                {
                    reviewManager.AddReview(userId, createdReview.RestaurantName, createdReview.FoodScore, createdReview.ServiceScore, createdReview.PriceScore, createdReview.Comment);
                    //ViewData["Error_message"] = "Your review has been submitted successfully";
                    return new RedirectToPageResult("Myreviews");
                }
                catch (Exception)
                {
                    ViewData["Error_message"] = "An error occured while adding the review. Please, try again.";
                    return new RedirectToPageResult("Error");
                }
            }
            else
            {
                ViewData["Error_message"] = "Entered infromation is invalid. Please, try again.";
                return Page();
            }
            

        }


    }
}
