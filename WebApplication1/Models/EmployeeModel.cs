namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmployeeModel : DbContext
    {
        public EmployeeModel()
            : base("name=EmpolyeeModelCs")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AdressLang> AdressLangs { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<ContactTypeLang> ContactTypeLangs { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public virtual DbSet<EmployeeContactInfo> EmployeeContactInfoes { get; set; }
        public virtual DbSet<EmployeeContactInfoLang> EmployeeContactInfoLangs { get; set; }
        public virtual DbSet<EmployeeLang> EmployeeLangs { get; set; }
        public virtual DbSet<EnumContactType> EnumContactTypes { get; set; }
        public virtual DbSet<EnumCurrency> EnumCurrencies { get; set; }
        public virtual DbSet<EnumGender> EnumGenders { get; set; }
        public virtual DbSet<EnumLang> EnumLangs { get; set; }
        public virtual DbSet<GenderLang> GenderLangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .Property(e => e.MapLocation)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.AdressLangs)
                .WithOptional(e => e.Address)
                .HasForeignKey(e => e.FkAddressId);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.EmployeeAddresses)
                .WithOptional(e => e.Address)
                .HasForeignKey(e => e.FkAddressId);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Addresses)
                .WithOptional(e => e.City)
                .HasForeignKey(e => e.FkCityId);

            modelBuilder.Entity<Country>()
                .Property(e => e.Falg)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Cities)
                .WithOptional(e => e.Country)
                .HasForeignKey(e => e.FkCountryId);

            modelBuilder.Entity<Employee>()
                .Property(e => e.SiteURL)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.ImageLarge)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.FavoriteColorRGB)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Employee1)
                .WithOptional(e => e.Employee2)
                .HasForeignKey(e => e.FkEmplyeeIdManager);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeAddresses)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.FkEmployeeId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeContactInfoes)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.FkEmployeeId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeLangs)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.FkEmployeeId);

            modelBuilder.Entity<EmployeeContactInfo>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeContactInfo>()
                .HasMany(e => e.EmployeeContactInfoLangs)
                .WithRequired(e => e.EmployeeContactInfo)
                .HasForeignKey(e => e.FkEmployeeContactInfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumContactType>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<EnumContactType>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<EnumContactType>()
                .HasMany(e => e.ContactTypeLangs)
                .WithOptional(e => e.EnumContactType)
                .HasForeignKey(e => e.FkContactTypeId);

            modelBuilder.Entity<EnumContactType>()
                .HasMany(e => e.EmployeeContactInfoes)
                .WithRequired(e => e.EnumContactType)
                .HasForeignKey(e => e.FkContactTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumCurrency>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<EnumCurrency>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<EnumCurrency>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.EnumCurrency)
                .HasForeignKey(e => e.FkCurrencyId);

            modelBuilder.Entity<EnumGender>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<EnumGender>()
                .HasMany(e => e.GenderLangs)
                .WithOptional(e => e.EnumGender)
                .HasForeignKey(e => e.FkGenderId);

            modelBuilder.Entity<EnumLang>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<EnumLang>()
                .Property(e => e.Flag)
                .IsUnicode(false);

            modelBuilder.Entity<EnumLang>()
                .HasMany(e => e.AdressLangs)
                .WithOptional(e => e.EnumLang)
                .HasForeignKey(e => e.FkLangId);

            modelBuilder.Entity<EnumLang>()
                .HasMany(e => e.ContactTypeLangs)
                .WithOptional(e => e.EnumLang)
                .HasForeignKey(e => e.FkLangId);

            modelBuilder.Entity<EnumLang>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.EnumLang)
                .HasForeignKey(e => e.FkLangIdDefault);

            modelBuilder.Entity<EnumLang>()
                .HasMany(e => e.EmployeeContactInfoLangs)
                .WithRequired(e => e.EnumLang)
                .HasForeignKey(e => e.FKLangId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnumLang>()
                .HasMany(e => e.EmployeeLangs)
                .WithOptional(e => e.EnumLang)
                .HasForeignKey(e => e.FkEnumLangId);

            modelBuilder.Entity<EnumLang>()
                .HasMany(e => e.GenderLangs)
                .WithOptional(e => e.EnumLang)
                .HasForeignKey(e => e.FkLangId);
        }
    }
}
