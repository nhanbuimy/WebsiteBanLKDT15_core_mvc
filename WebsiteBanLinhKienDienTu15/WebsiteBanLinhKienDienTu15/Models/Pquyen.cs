using System;
using System.Collections.Generic;

namespace WebsiteBanLinhKienDienTu15.Models
{
    public partial class Pquyen
    {
        public Pquyen()
        {
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        public int Id { get; set; }
        public string Ten { get; set; } = null!;
        public string? MoTa { get; set; }

        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
