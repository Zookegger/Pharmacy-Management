using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Login_DAL
{
    public partial class ModelPharmacyLogin : DbContext
    {
        public ModelPharmacyLogin()
            : base("name=ModelPharmacyLogin")
        {
        }

        public virtual DbSet<CHUCVU> CHUCVU { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOAN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.NHANVIEN)
                .WithRequired(e => e.CHUCVU)
                .WillCascadeOnDelete(false);

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
                .HasMany(e => e.TAIKHOAN)
                .WithRequired(e => e.NHANVIEN)
                .HasForeignKey(e => e.MaNhanVien);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.TAIKHOAN1)
                .WithRequired(e => e.NHANVIEN1)
                .HasForeignKey(e => e.MaNhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);
        }
    }
}
