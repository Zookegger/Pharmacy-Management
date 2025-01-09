namespace Pharmacist_DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIAODICH")]
    public partial class GIAODICH
    {
        [Key]
        [StringLength(10)]
        public string MaGiaoDich { get; set; }

        [StringLength(10)]
        public string MaLo { get; set; }

        [StringLength(10)]
        public string MaNhaCungCap { get; set; }

        [StringLength(30)]
        public string LoaiGiaoDich { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThucHien { get; set; }

        public int? SoLuongTonConLai { get; set; }

        [StringLength(30)]
        public string TinhTrang { get; set; }

        public virtual LOTHUOC LOTHUOC { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
    }
}
