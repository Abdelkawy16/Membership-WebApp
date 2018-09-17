namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdressLang")]
    public partial class AdressLang
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        public long? FkAddressId { get; set; }

        public int? FkLangId { get; set; }

        public virtual Address Address { get; set; }

        public virtual EnumLang EnumLang { get; set; }
    }
}
