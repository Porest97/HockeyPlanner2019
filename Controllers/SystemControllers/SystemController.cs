using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HockeyPlanner2019.Controllers.SystemControllers
{
    public class SystemController : Controller
    {
        public IActionResult IndexSystem()
        {
            return View();
        }
    }
}