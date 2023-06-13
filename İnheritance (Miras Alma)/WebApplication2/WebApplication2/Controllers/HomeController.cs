using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserPanel()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View("Profile");
        }
    }
}
