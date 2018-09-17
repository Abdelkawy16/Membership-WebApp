namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Employee1 = new HashSet<Employee>();
            EmployeeAddresses = new HashSet<EmployeeAddress>();
            EmployeeContactInfoes = new HashSet<EmployeeContactInfo>();
            EmployeeLangs = new HashSet<EmployeeLang>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(200)]
        public string Password { get; set; }

        [StringLength(150)]
        public string SiteURL { get; set; }

        public int? Age { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        public TimeSpan? TimeOfBirth { get; set; }

        [StringLength(200)]
        public string ImageLarge { get; set; }

        [Column(TypeName = "image")]
        public byte[] ImageSmall { get; set; }

        [StringLength(7)]
        public string FavoriteColorRGB { get; set; }

        public int? FkGenderId { get; set; }

        public bool IsDeleted { get; set; }

        public bool? IsAccepted { get; set; }

        public double? Salary { get; set; }

        public int? FkCurrencyId { get; set; }

        public int? FkLangIdDefault { get; set; }

        public int? FkEmplyeeIdManager { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employee1 { get; set; }

        public virtual Employee Employee2 { get; set; }

        public virtual EnumCurrency EnumCurrency { get; set; }

        public virtual EnumLang EnumLang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeAddress> EmployeeAddresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeContactInfo> EmployeeContactInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeLang> EmployeeLangs { get; set; }
    }
}
