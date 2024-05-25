using System;
using System.Collections.Generic;

namespace WebsiteBanLinhKienDienTu15.Models
{
    public partial class Cart
    {
        public Cart()
        {
            CartItems = new HashSet<CartItem>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }

        public virtual KhachHang? User { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
