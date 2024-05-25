using System;
using System.Collections.Generic;

namespace WebsiteBanLinhKienDienTu15.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            CartItems = new HashSet<CartItem>();
            Ctdhs = new HashSet<Ctdh>();
            PhieuBaoHanhs = new HashSet<PhieuBaoHanh>();
        }

        public int Id { get; set; }
        public string Ten { get; set; } = null!;
        public string? MoTa { get; set; }
        public double? GiaBan { get; set; }
        public double? GiaGiam { get; set; }
        public int? SoLuongTon { get; set; }
        public string? HinhAnh { get; set; }
        public int? IdLsp { get; set; }
        public int? IdNcc { get; set; }

        public virtual LoaiSp? IdLspNavigation { get; set; }
        public virtual Ncc? IdNccNavigation { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<Ctdh> Ctdhs { get; set; }
        public virtual ICollection<PhieuBaoHanh> PhieuBaoHanhs { get; set; }
    }
}
