using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebsiteBanLinhKienDienTu15.Models;
using X.PagedList;

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

        public IActionResult Index(int? page)
        {
            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var listSP = da.SanPhams.AsNoTracking().OrderBy(p => p.Id);
            PagedList<SanPham> listpage = new PagedList<SanPham>(listSP, pageNumber, pageSize);
            return View(listpage);
        }

        public IActionResult SanPhamTheoLoai(int maloai, int? page)
        {
            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var listSP = da.SanPhams.AsNoTracking().Where(x=>x.IdLsp==maloai)
                .OrderByDescending(p => p.Id);
            PagedList<SanPham> listpage = new PagedList<SanPham>(listSP, pageNumber, pageSize);
            ViewBag.maloai = maloai;
            return View(listpage);
        }

        public IActionResult ChiTietSanPham(int masp)
        {
            var sp = da.SanPhams.SingleOrDefault(x => x.Id == masp);
            ViewBag.sp = sp;
            return View(sp);
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
