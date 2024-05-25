using System;
using System.Collections.Generic;

namespace WebsiteBanLinhKienDienTu15.Models
{
    public partial class Ncc
    {
        public Ncc()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int Id { get; set; }
        public string Ten { get; set; } = null!;
        public string? DiaChi { get; set; }
        public string? Sdt { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
