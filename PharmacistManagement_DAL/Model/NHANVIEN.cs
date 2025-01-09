namespace PharmacistManagement_DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            BANGLUONG = new HashSet<BANGLUONG>();
            DONTHUOC = new HashSet<DONTHUOC>();
            TAIKHOAN = new HashSet<TAIKHOAN>();
        }

        [Key]
        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [Required]
        [StringLength(30)]
        public string HoTen { get; set; }

        [StringLength(255)]
        public string Avatar { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        public bool GioiTinh { get; set; }

        [Required]
        [StringLength(50)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(15)]
        public string SoDienThoai { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayVaoLam { get; set; }

        [Required]
        [StringLength(5)]
        public string MaChucVu { get; set; }

        [Required]
        [StringLength(10)]
        public string MaTiemThuoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANGLUONG> BANGLUONG { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONTHUOC> DONTHUOC { get; set; }

        public virtual TIEMTHUOCTAY TIEMTHUOCTAY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAIKHOAN> TAIKHOAN { get; set; }
    }
}
