using introduceDotnetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace introduceDotnetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Türkay";
            ViewBag.Hour = DateTime.Now.Hour;
            var products = new List<Product>()
            {

                new Product{ Id=1, Name="XXX", Price=100},
                new Product{ Id=2, Name="YYY", Price=200},
                new Product{ Id=3, Name="ZZZ", Price=100}

            };

            //ViewBag.Products = products;

            return View(products);
        }
        [HttpGet]
        public IActionResult Invite()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Invite(UserResponseModel model)
        {

            return View();
        }

    }
}
