using Homework15_Fish.Models;
using Microsoft.AspNetCore.Mvc;


using System.Diagnostics;

namespace Homework15_Fish.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static readonly Fish[] Fishes = new[]
                                           {
                                               new Fish
                                               {Name = "Щука",
                                                   Weight = 1,
                                                   Speed = 2
                                               },
                                               new Fish
                                               {Name = "Окунь",
                                                   Weight = 2,
                                                   Speed = 5
                                               },
                                               new Fish
                                               {Name = "Язь",
                                                   Weight = 5,
                                                   Speed = 8
                                               }
                                               };

        public IActionResult DataTransportByViewData()
        {
            ViewData["Fishes"] = Fishes;
            return View();
        }

        public IActionResult DataTransportByViewBag()
        {
            ViewBag.Fishes = Fishes;
            return View();
        }

        public IActionResult DataTransportByModel()
        {
            ViewData["Name"] = "Карп";
            ViewBag.Weight = 10;
            return View(Fishes);
        }




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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}