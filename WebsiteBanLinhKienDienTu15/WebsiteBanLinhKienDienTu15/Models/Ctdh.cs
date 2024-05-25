﻿using System;
using System.Collections.Generic;

namespace WebsiteBanLinhKienDienTu15.Models
{
    public partial class Ctdh
    {
        public int Id { get; set; }
        public int? Slsp { get; set; }
        public double? GiaSp { get; set; }
        public double? TongTien { get; set; }
        public int? IdSp { get; set; }
        public int? IdDh { get; set; }

        public virtual DonHang? IdDhNavigation { get; set; }
        public virtual SanPham? IdSpNavigation { get; set; }
    }
}
