using System;
using System.Collections.Generic;

namespace WebsiteBanLinhKienDienTu15.Models
{
    public partial class Qtv
    {
        public int Id { get; set; }
        public string Ten { get; set; } = null!;
        public DateTime? NgaySinh { get; set; }
        public string? Sdt { get; set; }
        public int? IdUser { get; set; }

        public virtual TaiKhoan? IdUserNavigation { get; set; }
    }
}
