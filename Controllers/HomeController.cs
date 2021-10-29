using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NiceHairMVC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NiceHairMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        public IList<Services> serviceList = new List<Services>{
                new Services() { ServiceId = 1, ServiceTitle = "Herreklip", ServicePrice = 18 } ,
                new Services() { ServiceId = 2, ServiceTitle = "Dameklip", ServicePrice = 18 } ,
                new Services() { ServiceId = 3, ServiceTitle = "Børneklip", ServicePrice = 18 }
        };




        [Route("/Services")]
        public IActionResult Services()
        {

            return View();
        }
        [Route("/Services/Herreklip")]
        public IActionResult MaleHair()
        {
            return View();
        }
        [Route("/Services/Dameklip")]
        public IActionResult FemaleHair()
        {
            return View();
        }
        [Route("/Services/Børneklip")]
        public IActionResult ChildHair()
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
