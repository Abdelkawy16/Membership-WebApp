namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactTypeLang")]
    public partial class ContactTypeLang
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public int? FkContactTypeId { get; set; }

        public int? FkLangId { get; set; }

        public virtual EnumContactType EnumContactType { get; set; }

        public virtual EnumLang EnumLang { get; set; }
    }
}
