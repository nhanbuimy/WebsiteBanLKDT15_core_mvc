using WebsiteBanLinhKienDienTu15.Models;
using Microsoft.AspNetCore.Mvc;
using WebsiteBanLinhKienDienTu15.Repository;
namespace WebsiteBanLinhKienDienTu15.ViewComponents
{
    public class LSPMenuViewComponent: ViewComponent
    {
        private readonly ILoaiSpRepository _loaiSp;

        public LSPMenuViewComponent(ILoaiSpRepository loaiSpRepository)
        {
            _loaiSp = loaiSpRepository;
        }
        public IViewComponentResult Invoke()
        {
            var loaisp = _loaiSp.GetAllLSP().OrderBy(x => x.Id);
            return View(loaisp);
        }
    }
}
