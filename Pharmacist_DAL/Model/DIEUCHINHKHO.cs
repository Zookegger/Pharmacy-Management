namespace Pharmacist_DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DIEUCHINHKHO")]
    public partial class DIEUCHINHKHO
    {
        [Key]
        [StringLength(10)]
        public string MaDieuChinh { get; set; }

        [Required]
        [StringLength(10)]
        public string MaThuoc { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNguyenNhan { get; set; }

        public DateTime NgayChinh { get; set; }

        public int SoLuongChinh { get; set; }

        public int SoLuongConLai { get; set; }

        public virtual THUOC THUOC { get; set; }

        public virtual NGUYENNHAN NGUYENNHAN { get; set; }
    }
}
