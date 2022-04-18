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
    public class MyreviewsModel : PageModel
    {
        public List<Review> reviews = new List<Review>();
        ReviewManager reviewManager = new ReviewManager(new ReviewRepository());

        public IActionResult OnGet()
        {
            int id = Convert.ToInt32(User.FindFirst("id").Value);

            try
            {
                reviews = reviewManager.GetReviewsForUser(id);
                return Page();
            }
            catch (DataBaseException)
            {
                @ViewData["Error_message"] = "An error occured while loading your reviews. Please, try again.";
                return new RedirectToPageResult("Error");
            }

          
        }
    }
}
