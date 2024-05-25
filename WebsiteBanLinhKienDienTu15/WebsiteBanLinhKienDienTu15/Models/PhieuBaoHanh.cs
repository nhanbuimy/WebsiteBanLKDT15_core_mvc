using System;
using System.Collections.Generic;

namespace WebsiteBanLinhKienDienTu15.Models
{
    public partial class PhieuBaoHanh
    {
        public int Id { get; set; }
        public string? TenChinhSachBh { get; set; }
        public DateTime? NgayBdbh { get; set; }
        public DateTime? NgayKtbh { get; set; }
        public int? Slsp { get; set; }
        public int? IdSp { get; set; }
        public int? IdDh { get; set; }
        public int? IdKh { get; set; }

        public virtual DonHang? IdDhNavigation { get; set; }
        public virtual KhachHang? IdKhNavigation { get; set; }
        public virtual SanPham? IdSpNavigation { get; set; }
    }
}
