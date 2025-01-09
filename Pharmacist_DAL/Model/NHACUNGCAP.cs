namespace Pharmacist_DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHACUNGCAP")]
    public partial class NHACUNGCAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHACUNGCAP()
        {
            GIAODICH = new HashSet<GIAODICH>();
        }

        [Key]
        [StringLength(10)]
        public string MaNhaCungCap { get; set; }

        [StringLength(30)]
        public string TenNhaCungCap { get; set; }

        [StringLength(30)]
        public string DiaChi { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(15)]
        public string SoDienThoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAODICH> GIAODICH { get; set; }
    }
}
