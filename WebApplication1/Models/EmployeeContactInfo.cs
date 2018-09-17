namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeContactInfo")]
    public partial class EmployeeContactInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeContactInfo()
        {
            EmployeeContactInfoLangs = new HashSet<EmployeeContactInfoLang>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Value { get; set; }

        public int FkContactTypeId { get; set; }

        public int? FkEmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual EnumContactType EnumContactType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeContactInfoLang> EmployeeContactInfoLangs { get; set; }
    }
}
