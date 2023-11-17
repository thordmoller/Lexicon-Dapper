using Lexicon_Dapper.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lexicon_Dapper.Controllers
{
    public class HomeController:Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            List<City> cityList = CityQuery.GetCitiesPopulationSpan(1000, 10000);
            return View(cityList);
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}