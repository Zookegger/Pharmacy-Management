using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PharmacistManagement_DAL.Model
{
    public partial class PharmacyManagementDB : DbContext
    {
        public PharmacyManagementDB()
            : base("name=PharmacyManagementDB")
        {
        }

        public virtual DbSet<BANGLUONG> BANGLUONG { get; set; }
        public virtual DbSet<CHITIETDONTHUOC> CHITIETDONTHUOC { get; set; }
        public virtual DbSet<CHUCVU> CHUCVU { get; set; }
        public virtual DbSet<DIEUCHINHKHO> DIEUCHINHKHO { get; set; }
        public virtual DbSet<DONTHUOC> DONTHUOC { get; set; }
        public virtual DbSet<GIAODICH> GIAODICH { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANG { get; set; }
        public virtual DbSet<LOTHUOC> LOTHUOC { get; set; }
        public virtual DbSet<NGUYENNHAN> NGUYENNHAN { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAP { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOAN { get; set; }
        public virtual DbSet<THUOC> THUOC { get; set; }
        public virtual DbSet<TIEMTHUOCTAY> TIEMTHUOCTAY { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BANGLUONG>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<BANGLUONG>()
                .Property(e => e.LanCuoiCapNhat)
                .IsFixedLength();

            modelBuilder.Entity<CHITIETDONTHUOC>()
                .Property(e => e.MaDonThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETDONTHUOC>()
                .Property(e => e.MaThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.NHANVIEN)
                .WithRequired(e => e.CHUCVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIEUCHINHKHO>()
                .Property(e => e.MaDieuChinh)
                .IsUnicode(false);

            modelBuilder.Entity<DIEUCHINHKHO>()
                .Property(e => e.MaThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<DIEUCHINHKHO>()
                .Property(e => e.MaNguyenNhan)
                .IsUnicode(false);

            modelBuilder.Entity<DONTHUOC>()
                .Property(e => e.MaDonThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<DONTHUOC>()
                .Property(e => e.MaKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<DONTHUOC>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<DONTHUOC>()
                .HasMany(e => e.CHITIETDONTHUOC)
                .WithRequired(e => e.DONTHUOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GIAODICH>()
                .Property(e => e.MaGiaoDich)
                .IsUnicode(false);

            modelBuilder.Entity<GIAODICH>()
                .Property(e => e.MaLo)
                .IsUnicode(false);

            modelBuilder.Entity<GIAODICH>()
                .Property(e => e.MaNhaCungCap)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MaKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.DONTHUOC)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOTHUOC>()
                .Property(e => e.MaLo)
                .IsUnicode(false);

            modelBuilder.Entity<LOTHUOC>()
                .Property(e => e.MaThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<NGUYENNHAN>()
                .Property(e => e.MaNguyenNhan)
                .IsUnicode(false);

            modelBuilder.Entity<NGUYENNHAN>()
                .HasMany(e => e.DIEUCHINHKHO)
                .WithRequired(e => e.NGUYENNHAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.MaNhaCungCap)
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaTiemThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.BANGLUONG)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.DONTHUOC)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.TAIKHOAN)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<THUOC>()
                .Property(e => e.MaThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<THUOC>()
                .HasMany(e => e.CHITIETDONTHUOC)
                .WithRequired(e => e.THUOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THUOC>()
                .HasMany(e => e.DIEUCHINHKHO)
                .WithRequired(e => e.THUOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THUOC>()
                .HasMany(e => e.LOTHUOC)
                .WithRequired(e => e.THUOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIEMTHUOCTAY>()
                .Property(e => e.MaTiemThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<TIEMTHUOCTAY>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<TIEMTHUOCTAY>()
                .HasMany(e => e.NHANVIEN)
                .WithRequired(e => e.TIEMTHUOCTAY)
                .WillCascadeOnDelete(false);
        }
    }
}
