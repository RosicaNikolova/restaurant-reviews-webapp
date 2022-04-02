using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
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

        public IActionResult OnPost(string? returnUrl)
        {

            LoginManager loginManager = new LoginManager(new UserRepository());

            if (ModelState.IsValid)
            {
                User user;
                try
                {
                    user = loginManager.Login(Login.Email, Login.Password);
                }
                catch (LoginException)
                {
                    ViewData["Message"] = "Invalid credentials";
                    return Page();
                }

                string id = user.Id.ToString();
                List<Claim> claims = new List<Claim>();

                claims.Add(new Claim("id", id));

                if(user.Roles == Role.ADMIN)
                {
                    claims.Add(new Claim(ClaimTypes.Role, "admin"));
                }
                else
                {
                    claims.Add(new Claim(ClaimTypes.Role, "user"));
                }

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));


                if(!String.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToPage("Home");
                }
                //User user = new User();
                //try
                //{
                //    user = loginManager.Login(Login.Email, Login.Password);
                //    if(user.Roles == Role.ADMIN)
                //    {
                //        ViewData["Message"] = "Wellcome Admin! You can login to the desktop application";
                //        return Page();
                //    }
                //    else
                //    {
                //        return new RedirectToPageResult("Home");
                //    }

                //}
                //catch (LoginException)
                //{
                //    ViewData["Message"] = "Invalid credentials. Please, try again.";
                //    return Page();
                //}
            }
            else
            {
                ViewData["Message"] = "Please enter all data fields!";
                return Page();
            }
           
        }
    }
}
