using WebsiteBanLinhKienDienTu15.Models;
namespace WebsiteBanLinhKienDienTu15.Repository
{
    public class LoaiSpRepository : ILoaiSpRepository
    {
        private readonly WebDienTu15Context _context;
        public LoaiSpRepository (WebDienTu15Context context)
        {
            _context = context;
        }
        public LoaiSp Add(LoaiSp loaiSp)
        {
            _context.LoaiSps.Add(loaiSp);
            _context.SaveChanges();
            return loaiSp;
        }

        public LoaiSp Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LoaiSp> GetAllLSP()
        {
            return _context.LoaiSps;
        }

        public LoaiSp GetLSP(int id)
        {
            return _context.LoaiSps.FirstOrDefault(x => x.Id == id);
        }

        public LoaiSp Update(LoaiSp loaiSp)
        {
            _context.Update(loaiSp);
            _context.SaveChanges();
            return loaiSp;
        }
    }
}
