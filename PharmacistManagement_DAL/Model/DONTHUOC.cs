namespace PharmacistManagement_DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONTHUOC")]
    public partial class DONTHUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONTHUOC()
        {
            CHITIETDONTHUOC = new HashSet<CHITIETDONTHUOC>();
        }

        [Key]
        [StringLength(10)]
        public string MaDonThuoc { get; set; }

        public int MaKhachHang { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayLenDon { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayHetHan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONTHUOC> CHITIETDONTHUOC { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
