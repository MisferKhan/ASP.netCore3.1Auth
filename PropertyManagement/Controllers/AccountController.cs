using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models.Domain_Models;
using Models.WebModels;

namespace PropertyManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AspNetUsers> userManager;

        public AccountController(UserManager<AspNetUsers> userManager)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegistrationModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return View(userModel);
            }

            AspNetUsers user = null;

            var result = await userManager.CreateAsync(user, userModel.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }

                return View(userModel);
            }


            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}