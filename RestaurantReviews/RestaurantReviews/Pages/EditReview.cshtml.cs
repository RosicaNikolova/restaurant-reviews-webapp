using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Business;
using ClassLibrary.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RestaurantReviews.Pages
{
    public class EditReviewModel : PageModel
    {
        [BindProperty]
        public Review review { get; set; }
        ReviewManager reviewManager = new ReviewManager(new ReviewRepository());

        public void OnGet(int id)
        {
            review =  reviewManager.GetReviewById(id);
        }

        public IActionResult OnPost(int id)
        {
            reviewManager.Update(review.FoodScore, review.ServiceScore, review.PriceScore, review.Comment,id);
            return Page();
        }
    }
}
