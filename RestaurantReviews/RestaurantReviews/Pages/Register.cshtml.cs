using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Business;
using ClassLibrary.Exceptions;
using ClassLibrary.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


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
                    if(user != null)
                    {
                        return new RedirectToPageResult("Home");
                    }
                    else
                    {
                        ViewData["Message_register"] = "User with this email already exists.";
                        return Page();
                    }
                }

                catch (DataBaseException)
                {
                    ViewData["Error_message"] = "An error occured while registration. Please, try again.";
                    return new RedirectToPageResult("Error");
                }
            }
            else
            {
                ViewData["Message_register"] = "Please enter all data fields!";
                return Page();
            }
        }
                 
    }
}
