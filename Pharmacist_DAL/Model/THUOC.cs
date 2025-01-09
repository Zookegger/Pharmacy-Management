namespace Pharmacist_DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THUOC")]
    public partial class THUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THUOC()
        {
            CHITIETDONTHUOC = new HashSet<CHITIETDONTHUOC>();
            DIEUCHINHKHO = new HashSet<DIEUCHINHKHO>();
            LOTHUOC = new HashSet<LOTHUOC>();
        }

        [Key]
        [StringLength(10)]
        public string MaThuoc { get; set; }

        [Required]
        [StringLength(30)]
        public string TenThuoc { get; set; }

        public int GiaDonVi { get; set; }

        [Required]
        [StringLength(50)]
        public string LieuThuoc { get; set; }

        [StringLength(125)]
        public string MoTa { get; set; }

        public int SoLuongTon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONTHUOC> CHITIETDONTHUOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEUCHINHKHO> DIEUCHINHKHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOTHUOC> LOTHUOC { get; set; }
    }
}
