using System;
using System.Collections.Generic;

namespace WebsiteBanLinhKienDienTu15.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            Carts = new HashSet<Cart>();
            DonHangs = new HashSet<DonHang>();
            PhieuBaoHanhs = new HashSet<PhieuBaoHanh>();
        }

        public int Id { get; set; }
        public string Ten { get; set; } = null!;
        public string? Sdt { get; set; }
        public string? DiaChi { get; set; }
        public int? IdUser { get; set; }

        public virtual TaiKhoan? IdUserNavigation { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<DonHang> DonHangs { get; set; }
        public virtual ICollection<PhieuBaoHanh> PhieuBaoHanhs { get; set; }
    }
}
