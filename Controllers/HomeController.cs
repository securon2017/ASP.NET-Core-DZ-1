using DZ_1.Models;
using DZ_1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DZ_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private SessionService _sessionService;

        public HomeController(ILogger<HomeController> logger, SessionService sessionService)
        {
            _logger = logger;
            _sessionService = sessionService;
        }

        public IActionResult Index()
        {
            return View(_sessionService);
        }

        public IActionResult About()
        {
            return View(_sessionService);
        }


        public IActionResult Contacts()
        {
            return View(_sessionService);
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
