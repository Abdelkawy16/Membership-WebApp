namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeLang")]
    public partial class EmployeeLang
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public int? FkEmployeeId { get; set; }

        public int? FkEnumLangId { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual EnumLang EnumLang { get; set; }
    }
}
