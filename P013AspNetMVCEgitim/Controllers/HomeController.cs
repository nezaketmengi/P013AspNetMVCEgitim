using Microsoft.AspNetCore.Mvc;
using P013AspNetMVCEgitim.Models;
using System.Diagnostics;

namespace P013AspNetMVCEgitim.Controllers
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
        [HttpGet] //varsayılan değer GET dir. Bunu yazdığımızda ise aşağıdaki metot GET ile çalışacak demek. Varsayılan olduğu için ek yazmaya gerek yok.
        public IActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactUs(string ad)
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