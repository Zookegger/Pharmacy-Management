namespace Pharmacist_DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETDONTHUOC")]
    public partial class CHITIETDONTHUOC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaDonThuoc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaThuoc { get; set; }

        public int SoLuong { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayHetHan { get; set; }

        public virtual DONTHUOC DONTHUOC { get; set; }

        public virtual THUOC THUOC { get; set; }
    }
}
