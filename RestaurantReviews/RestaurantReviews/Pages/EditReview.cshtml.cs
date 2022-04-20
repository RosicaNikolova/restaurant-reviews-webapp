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
    public class EditReviewModel : PageModel
    {
        [BindProperty]
        public Review review { get; set; }
        ReviewManager reviewManager = new ReviewManager(new ReviewRepository());

        public IActionResult OnGet(int id)
        {
            try
            {
                review = reviewManager.GetReviewById(id);
                return Page();
            }
            catch (DataBaseException)
            {
                ViewData["Error_message"] = "An error occured while loading this page. Please, try again later.";
                return new RedirectToPageResult("Error");
            }
            catch (Exception)
            {
                ViewData["Error_message"] = "An error occured while loading this page. Please, try again later.";
                return new RedirectToPageResult("Error");
            }
        }

        public IActionResult OnPost(int id)
        {
            try
            {
                reviewManager.Update(review.FoodScore, review.ServiceScore, review.PriceScore, review.Comment, id);
                return Page();
            }
            catch (DataBaseException)
            {
                ViewData["Error_message"] = "An error occured while updating the your review. Please, try again later.";
                return new RedirectToPageResult("Error");
            }
            catch (Exception)
            {
                ViewData["Error_message"] = "An error occured while updating the your review. Please, try again later.";
                return new RedirectToPageResult("Error");
            }
        }
    }
}
