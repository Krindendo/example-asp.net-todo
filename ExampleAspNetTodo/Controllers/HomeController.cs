using System.Diagnostics;
using ExampleAspNetTodo.Data;
using ExampleAspNetTodo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAspNetTodo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DataTable()
        {
            var users = MockUserData.GetUsers();
            return View(users);
        }

        public IActionResult UserInfo(int id)
        {
            var user = MockUserData.GetUsers().FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound(new { message = $"User with ID {id} not found." });
            }
            return View(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
