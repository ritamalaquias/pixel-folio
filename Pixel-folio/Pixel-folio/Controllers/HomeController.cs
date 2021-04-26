using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pixel_folio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Pixel_folio.Controllers
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
            //for dynamic title
            if(DateTime.Now.Hour < 12)
            {
                ViewBag.Hello = "Good morning!";
            }
            else if(DateTime.Now.Hour < 18)
            {
                ViewBag.Hello = "Good afternoon!";
            }
            else
            {
                ViewBag.Hello = "Good night!";
            }
            
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
