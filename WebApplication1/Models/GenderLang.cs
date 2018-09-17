namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GenderLang")]
    public partial class GenderLang
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public int? FkGenderId { get; set; }

        public int? FkLangId { get; set; }

        public virtual EnumGender EnumGender { get; set; }

        public virtual EnumLang EnumLang { get; set; }
    }
}
