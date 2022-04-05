using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using intexnew.Models;

namespace intexnew.Controllers
{
    public class HomeController : Controller
    {
        private ICrashRepository repo;


        public HomeController(ICrashRepository temp)
        {
            repo = temp;
        }

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
