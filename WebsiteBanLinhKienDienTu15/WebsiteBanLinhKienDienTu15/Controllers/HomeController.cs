using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebsiteBanLinhKienDienTu15.Models;

namespace WebsiteBanLinhKienDienTu15.Controllers
{
    public class HomeController : Controller
    {
        WebDienTu15Context da = new WebDienTu15Context();
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
