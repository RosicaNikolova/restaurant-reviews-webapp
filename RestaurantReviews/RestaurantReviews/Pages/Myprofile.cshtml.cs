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
    public class MyprofileModel : PageModel
    {
        [BindProperty]
        public User EditedUser { get; set; }
        public User loggedUser { get; set; }
        UserManager userManager = new UserManager(new UserRepository());


        public IActionResult OnGet()
        {
            try
            {
                int userId = Convert.ToInt32(User.FindFirst("id").Value);
                loggedUser = userManager.FindUserById(userId);
                return Page();
            }
            catch (DataBaseException)
            {
                ViewData["Error_message"] = "An error occured while loading the page. Please contact the support.";
                return new RedirectToPageResult("Error");
            }
            catch (Exception)
            {
                ViewData["Error_message"] = "An error occured while loading the page. Please contact the support.";
                return new RedirectToPageResult("Error");
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int userId = Convert.ToInt32(User.FindFirst("id").Value);

                    userManager.UpdateUser(EditedUser.Email, EditedUser.Password, EditedUser.FirstName, EditedUser.LastName, userId);
                    loggedUser = EditedUser;
                    return Page();
                }

                catch (DataBaseException)
                {
                    ViewData["Error_message"] = "An error occured while updating your profile. Please contact the support.";
                    return new RedirectToPageResult("Error");
                }
                catch (Exception)
                {
                    ViewData["Error_message"] = "An error occured while updating your profile. Please contact the support.";
                    return new RedirectToPageResult("Error");
                }
            }
            else
            {
                return Page();
            }
        }
    }
}
