using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebsiteBanLinhKienDienTu15.Models
{
    public partial class WebDienTu15Context : DbContext
    {
        public WebDienTu15Context()
        {
        }

        public WebDienTu15Context(DbContextOptions<WebDienTu15Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Cart> Carts { get; set; } = null!;
        public virtual DbSet<CartItem> CartItems { get; set; } = null!;
        public virtual DbSet<Ctdh> Ctdhs { get; set; } = null!;
        public virtual DbSet<DonHang> DonHangs { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<LoaiSp> LoaiSps { get; set; } = null!;
        public virtual DbSet<Ncc> Nccs { get; set; } = null!;
        public virtual DbSet<PhieuBaoHanh> PhieuBaoHanhs { get; set; } = null!;
        public virtual DbSet<Pquyen> Pquyens { get; set; } = null!;
        public virtual DbSet<Qtv> Qtvs { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=HP-E12\\SQLEXPRESS;Initial Catalog=WebDienTu15;User ID=sa;Password=123;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("Cart");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Cart__UserId__5441852A");
            });

            modelBuilder.Entity<CartItem>(entity =>
            {
                entity.ToTable("CartItem");

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.CartItems)
                    .HasForeignKey(d => d.CartId)
                    .HasConstraintName("FK__CartItem__CartId__571DF1D5");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CartItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__CartItem__Produc__5812160E");
            });

            modelBuilder.Entity<Ctdh>(entity =>
            {
                entity.ToTable("CTDH");

                entity.Property(e => e.IdDh).HasColumnName("IdDH");

                entity.Property(e => e.IdSp).HasColumnName("IdSP");

                entity.Property(e => e.Slsp).HasColumnName("SLSP");

                entity.HasOne(d => d.IdDhNavigation)
                    .WithMany(p => p.Ctdhs)
                    .HasForeignKey(d => d.IdDh)
                    .HasConstraintName("FK__CTDH__IdDH__49C3F6B7");

                entity.HasOne(d => d.IdSpNavigation)
                    .WithMany(p => p.Ctdhs)
                    .HasForeignKey(d => d.IdSp)
                    .HasConstraintName("FK__CTDH__IdSP__48CFD27E");
            });

            modelBuilder.Entity<DonHang>(entity =>
            {
                entity.ToTable("DonHang");

                entity.Property(e => e.IdKh).HasColumnName("IdKH");

                entity.Property(e => e.NgayDat).HasColumnType("datetime");

                entity.Property(e => e.Slsp).HasColumnName("SLSP");

                entity.Property(e => e.TrangThai).HasMaxLength(20);

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.DonHangs)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("FK__DonHang__IdKH__45F365D3");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.ToTable("KhachHang");

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(100);

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.KhachHangs)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__KhachHang__IdUse__3F466844");
            });

            modelBuilder.Entity<LoaiSp>(entity =>
            {
                entity.ToTable("LoaiSP");

                entity.Property(e => e.Ten).HasMaxLength(100);
            });

            modelBuilder.Entity<Ncc>(entity =>
            {
                entity.ToTable("NCC");

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(100);
            });

            modelBuilder.Entity<PhieuBaoHanh>(entity =>
            {
                entity.ToTable("PhieuBaoHanh");

                entity.Property(e => e.IdDh).HasColumnName("IdDH");

                entity.Property(e => e.IdKh).HasColumnName("IdKH");

                entity.Property(e => e.IdSp).HasColumnName("IdSP");

                entity.Property(e => e.NgayBdbh)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayBDBH");

                entity.Property(e => e.NgayKtbh)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayKTBH");

                entity.Property(e => e.Slsp).HasColumnName("SLSP");

                entity.Property(e => e.TenChinhSachBh)
                    .HasMaxLength(30)
                    .HasColumnName("TenChinhSachBH");

                entity.HasOne(d => d.IdDhNavigation)
                    .WithMany(p => p.PhieuBaoHanhs)
                    .HasForeignKey(d => d.IdDh)
                    .HasConstraintName("FK__PhieuBaoHa__IdDH__5070F446");

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.PhieuBaoHanhs)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("FK__PhieuBaoHa__IdKH__5165187F");

                entity.HasOne(d => d.IdSpNavigation)
                    .WithMany(p => p.PhieuBaoHanhs)
                    .HasForeignKey(d => d.IdSp)
                    .HasConstraintName("FK__PhieuBaoHa__IdSP__4F7CD00D");
            });

            modelBuilder.Entity<Pquyen>(entity =>
            {
                entity.ToTable("PQuyen");

                entity.Property(e => e.MoTa).HasMaxLength(100);

                entity.Property(e => e.Ten).HasMaxLength(100);
            });

            modelBuilder.Entity<Qtv>(entity =>
            {
                entity.ToTable("QTV");

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(50);

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Qtvs)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__QTV__IdUser__4CA06362");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.ToTable("SanPham");

                entity.Property(e => e.HinhAnh).IsUnicode(false);

                entity.Property(e => e.IdLsp).HasColumnName("IdLSP");

                entity.Property(e => e.IdNcc).HasColumnName("IdNCC");

                entity.Property(e => e.MoTa).HasMaxLength(100);

                entity.Property(e => e.Ten).HasMaxLength(100);

                entity.HasOne(d => d.IdLspNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.IdLsp)
                    .HasConstraintName("FK__SanPham__IdLSP__4222D4EF");

                entity.HasOne(d => d.IdNccNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.IdNcc)
                    .HasConstraintName("FK__SanPham__IdNCC__4316F928");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.ToTable("TaiKhoan");

                entity.Property(e => e.Pass).HasMaxLength(50);

                entity.Property(e => e.Ten).HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.TaiKhoans)
                    .HasForeignKey(d => d.IdRole)
                    .HasConstraintName("FK__TaiKhoan__IdRole__3C69FB99");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
