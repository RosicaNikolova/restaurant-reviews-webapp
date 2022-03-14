using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantReviews.Models;

namespace RestaurantReviews.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            LoginManager loginManager = new LoginManager();

            try
            {
                loginManager.Login(User.Email, User.Password);
                return new RedirectToPageResult("Home");
            }
            catch (LoginException)
            {
                ViewData["Message"] = "Invalid credentials";
                return Page();
            }
        }
    }
}
