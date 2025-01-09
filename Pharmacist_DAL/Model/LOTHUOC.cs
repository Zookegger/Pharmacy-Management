namespace Pharmacist_DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOTHUOC")]
    public partial class LOTHUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOTHUOC()
        {
            GIAODICH = new HashSet<GIAODICH>();
        }

        [Key]
        [StringLength(10)]
        public string MaLo { get; set; }

        [Required]
        [StringLength(10)]
        public string MaThuoc { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySanXuat { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayHetHan { get; set; }

        public int SoLuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAODICH> GIAODICH { get; set; }

        public virtual THUOC THUOC { get; set; }
    }
}
