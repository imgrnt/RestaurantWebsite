using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RestaurantWebsite.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantWebsite.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        public IActionResult LogIn()
        {
            return View();
        }


        [HttpPost]
        public IActionResult LogIn(LoginModel model)
        {
            string username = Request.Form["username"]; // get the value of the "username" form field
            bool isValid = false;
            if (ModelState.IsValid)
            {

                // perform validation logic here, such as checking against a database
                if (username == "admin") // example validation, checking against a hardcoded value
                {
                    isValid = true;
     
                }

                if (isValid)
                {
                    // redirect to Admin page if sucessful
                   
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                   
                }
                else
                {
                    // redirect to error page or display error message
                   
                    return RedirectToAction("Error", "Account");
                }

            }
            else
            {
                return View(model);
            }
        }




    }
}

