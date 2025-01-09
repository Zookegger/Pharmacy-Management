namespace Pharmacist_DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUYENNHAN")]
    public partial class NGUYENNHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUYENNHAN()
        {
            DIEUCHINHKHO = new HashSet<DIEUCHINHKHO>();
        }

        [Key]
        [StringLength(10)]
        public string MaNguyenNhan { get; set; }

        [StringLength(75)]
        public string NoiDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEUCHINHKHO> DIEUCHINHKHO { get; set; }
    }
}
