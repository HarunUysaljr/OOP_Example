using Microsoft.AspNetCore.Mvc;

namespace MVC_dataTransferTwo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.kisi = "harun";
            ViewBag.Sayi = 20;

            string kullanici = "harunUysal";

            return View("Index", kullanici);
        }
    }
}
