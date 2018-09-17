namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeAddress")]
    public partial class EmployeeAddress
    {
        public long Id { get; set; }

        public int? FkEmployeeId { get; set; }

        public long? FkAddressId { get; set; }

        public virtual Address Address { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
