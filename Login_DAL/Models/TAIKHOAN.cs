namespace Login_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        public int MaTaiKhoan { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [Required]
        [StringLength(30)]
        public string TenTaiKhoan { get; set; }

        [Required]
        [StringLength(100)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(20)]
        public string TrangThai { get; set; }

        public DateTime? LanCuoiCapNhat { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
