using ExampleAspNetTodo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAspNetTodo.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm(Name = "login")] LoginViewModel model, string returnurl)
        {
            if (!ModelState.IsValid)
            {
                return View(new AuthProcess { LoginViewModel = model });
            }

            if (model.Email == "admin" && model.Password == "password123")
            {
                // Normally set authentication cookie here
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View(new AuthProcess { LoginViewModel = model });
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View("Login");
        }

        [HttpPost]
        public IActionResult Register([FromForm(Name = "register")] RegisterViewModel model, string returnurl)
        {
            if (!ModelState.IsValid)
            {
                return View("Login", new AuthProcess { RegisterViewModel = model });
            }


            return RedirectToAction("Index", "Home");
        }
    }
}
