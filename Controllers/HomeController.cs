using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HockeyPlanner2019.Models;

namespace HockeyPlanner2019.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Clubs()
        {
            return View();
        }

        public IActionResult Companies()
        {
            return View();
        }

        public IActionResult People()
        {
            return View();
        }

        public IActionResult Arenas()
        {
            return View();
        }
        public IActionResult Games()
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
