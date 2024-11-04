using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tuotekuvasto_app.Models;
using Newtonsoft.Json;

namespace Tuotekuvasto_app.Controllers
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

        public IActionResult Product()

        {

            var products = GetProducts();

            return View(products);

        }

        private List<Product> GetProducts()

        {

            var json = System.IO.File.ReadAllText("wwwroot/products.json");

            return JsonConvert.DeserializeObject<List<Product>>(json);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
