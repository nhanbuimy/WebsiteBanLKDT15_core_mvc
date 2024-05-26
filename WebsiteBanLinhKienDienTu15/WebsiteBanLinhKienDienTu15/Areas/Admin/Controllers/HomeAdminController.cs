using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebsiteBanLinhKienDienTu15.Models;
using X.PagedList;

namespace WebsiteBanLinhKienDienTu15.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    [Route("admin/homeadmin")]
    public class HomeAdminController : Controller
    {
        WebDienTu15Context da = new WebDienTu15Context();
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("danhsachsanpham")]
        public IActionResult DSSP(int? page)
        {
            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var listSP = da.SanPhams.AsNoTracking().OrderBy(p => p.Id);
            PagedList<SanPham> listpage = new PagedList<SanPham>(listSP, pageNumber, pageSize);
            return View(listpage);
        }
    }
}
