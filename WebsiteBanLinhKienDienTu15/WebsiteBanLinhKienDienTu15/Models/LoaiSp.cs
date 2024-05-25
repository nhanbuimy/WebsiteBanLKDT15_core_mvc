using System;
using System.Collections.Generic;

namespace WebsiteBanLinhKienDienTu15.Models
{
    public partial class LoaiSp
    {
        public LoaiSp()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int Id { get; set; }
        public string Ten { get; set; } = null!;

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
