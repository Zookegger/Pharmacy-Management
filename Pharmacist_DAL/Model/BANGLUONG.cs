namespace Pharmacist_DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANGLUONG")]
    public partial class BANGLUONG
    {
        [Key]
        public int MaBangLuong { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNhanVien { get; set; }

        public int? Luong { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] LanCuoiCapNhat { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
