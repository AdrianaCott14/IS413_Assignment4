using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using resturants.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace resturants.Controllers
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
            List<string> restList = new List<string>();

            foreach (Top5 t5 in Top5.GetRestaraunts())
            {
                restList.Add($"#{t5.Rank}: {t5.RestaurantName}, {t5.FavDish}, {t5.Address}, {t5.PhoneNum}, {t5.Website}");
            }

            return View(restList);
        }

        [HttpGet]
        public IActionResult submitRest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult submitRest(UserRestaurants rests)
        {
            TempStorage.AddApplication(rests);
            return View("confirmation", rests);
        }

        public IActionResult userRests()
        {
            return View(TempStorage.Applications);
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
