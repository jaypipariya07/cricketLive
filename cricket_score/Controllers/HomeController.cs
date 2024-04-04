using cricket_score.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace cricket_score.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
           
            return View();
        }
        public IActionResult Archives()
        {
            return View();
        }

        public IActionResult series()
        {
            return View();
        }
        public IActionResult Fixtures()
        {
            return View();
        }
        public IActionResult statscorner()
        {
            return View();
        }
        public IActionResult ranking()
        {
            return View();
        }
        public IActionResult Home()
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
