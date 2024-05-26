using WebsiteBanLinhKienDienTu15.Models;
namespace WebsiteBanLinhKienDienTu15.Repository
{
    public interface ILoaiSpRepository
    {
        LoaiSp Add(LoaiSp loaisp);

        LoaiSp Update(LoaiSp loaisp);

        LoaiSp Delete(int id);

        LoaiSp GetLSP(int id);

        IEnumerable<LoaiSp> GetAllLSP();
    }
}
