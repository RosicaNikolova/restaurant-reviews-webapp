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
            catch (RestaurantException)
            {
                return new RedirectToPageResult("Home");
            }
        }
    }
}
