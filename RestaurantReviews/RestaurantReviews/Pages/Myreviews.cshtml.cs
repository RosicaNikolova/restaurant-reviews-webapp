using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantReviews.Models;

namespace RestaurantReviews.Pages
{
    public class MyreviewsModel : PageModel
    {
        public List<Review> reviews = new List<Review>();
        ReviewManager reviewManager = new ReviewManager();
        public void OnGet()
        {
            ReviewManager reviewManager = new ReviewManager();
            reviews = reviewManager.GetAllReviews();
        }
    }
}
