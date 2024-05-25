using System;
using System.Collections.Generic;

namespace WebsiteBanLinhKienDienTu15.Models
{
    public partial class TaiKhoan
    {
        public TaiKhoan()
        {
            KhachHangs = new HashSet<KhachHang>();
            Qtvs = new HashSet<Qtv>();
        }

        public int Id { get; set; }
        public string Ten { get; set; } = null!;
        public string? UserName { get; set; }
        public string? Pass { get; set; }
        public int? IdRole { get; set; }

        public virtual Pquyen? IdRoleNavigation { get; set; }
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
        public virtual ICollection<Qtv> Qtvs { get; set; }
    }
}
