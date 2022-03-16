using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public User Login { get; set; }

        
        

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            LoginManager loginManager = new LoginManager();

            if (ModelState.IsValid)
            {
                loginManager.Login(Login.Email, Login.Password);
                return new RedirectToPageResult("Home");
            }
            else
            {
                return Page();
            }
           
        }
    }
}
