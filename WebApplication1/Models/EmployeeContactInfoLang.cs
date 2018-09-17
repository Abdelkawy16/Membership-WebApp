namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeContactInfoLang")]
    public partial class EmployeeContactInfoLang
    {
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public long FkEmployeeContactInfoId { get; set; }

        public int FKLangId { get; set; }

        public virtual EmployeeContactInfo EmployeeContactInfo { get; set; }

        public virtual EnumLang EnumLang { get; set; }
    }
}
