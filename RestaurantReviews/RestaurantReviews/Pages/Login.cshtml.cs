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
                try
                {
                    User user = loginManager.Login(Login.Email, Login.Password);
                    if(user.Roles == Role.ADMIN)
                    {
                        ViewData["Message"] = "Wellcome Admin! You can login to the desktop application";
                        return Page();
                    }
                    else
                    {
                        return new RedirectToPageResult("Home");
                    }
                    
                }
                catch (LoginException)
                {
                    ViewData["Message"] = "Invalid credentials. Please, try again.";
                    return Page();
                }
            }
            else
            {
                ViewData["Message"] = "Please enter all data fields!";
                return Page();
            }
           
        }
    }
}
