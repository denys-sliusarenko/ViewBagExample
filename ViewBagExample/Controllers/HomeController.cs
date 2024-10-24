using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewBagExample.Models;

namespace ViewBagExample.Controllers
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

        public IActionResult CarsTable()
        {
            var cars = new List<Car>();
            for (int i = 0; i < 10; i++)
            {
                cars.Add(new Car() { Id = Guid.NewGuid(), Name = $"Car{i + 1}" });
            }

            ViewBag.Cars = cars;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
