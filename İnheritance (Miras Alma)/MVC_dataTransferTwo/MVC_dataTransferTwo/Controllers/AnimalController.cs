using Microsoft.AspNetCore.Mvc;
using MVC_dataTransferTwo.Models;

namespace MVC_dataTransferTwo.Controllers
{
    public class AnimalController : Controller
    {



        public IActionResult Index()
        {


            var animal = new Animal()
            {
                Id = 1,
                name = "Ares",
                LikedFood = "YaşMama"
            };

            return View(animal);
        }

        public IActionResult List()
        {
            var animals = new List<Animal>()
            {
            new Animal {Id = 1,name="Vegas",LikedFood="Kuzu"},
            new Animal { Id = 2, name = "Taci", LikedFood = "Dudu Peri" },
            new Animal { Id = 3, name = "Meksiko", LikedFood = "Acı" },
            new Animal { Id = 4, name = "Koyun", LikedFood = "Ot" }
            new Animal { Id = 4, name = "Koyun", LikedFood = "Ot" }
            new Animal { Id = 4, name = "Koyun", LikedFood = "Ot" }
            new Animal { Id = 4, name = "Koyun", LikedFood = "Ot" }
            new Animal { Id = 4, name = "Koyun", LikedFood = "Ot" }
            new Animal { Id = 4, name = "Koyun", LikedFood = "Ot" }
            new Animal { Id = 4, name = "Koyun", LikedFood = "Ot" }
            new Animal { Id = 4, name = "Koyun", LikedFood = "Ot" }
            new Animal { Id = 4, name = "Koyun", LikedFood = "Ot" }
            };

            return View(animals);
        }
    }
}
