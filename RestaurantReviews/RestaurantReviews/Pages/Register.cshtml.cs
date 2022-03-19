using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantReviews.Models;

namespace RestaurantReviews.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public User Register { get; set; }




        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            RegistrationManager registrationManager = new RegistrationManager(new UserRepository());

            if (ModelState.IsValid)
            {
                try
                {
                    User user = registrationManager.Register(Register.Email, Register.Password, Register.FirstName, Register.LastName);
                    return new RedirectToPageResult("Home");
                }

                catch (RegistrationException)
                {
                    ViewData["Message_register"] = "User with this email already exists.";
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
