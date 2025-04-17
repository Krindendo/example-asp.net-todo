using Microsoft.AspNetCore.Mvc;

namespace ExampleAspNetTodo.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
