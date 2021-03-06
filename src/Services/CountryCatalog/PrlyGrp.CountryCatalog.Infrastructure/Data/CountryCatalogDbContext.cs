﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using PrlyGrp.CountryCatalog.ApplicationCore.Entities;
using System.Reflection;

namespace PrlyGrp.CountryCatalog.Infrastructure.Data
{
    public partial class CountryCatalogDbContext : DbContext
    {
        public CountryCatalogDbContext()
        {
        }

        public CountryCatalogDbContext(DbContextOptions<CountryCatalogDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<EavAttribute> EavAttribute { get; set; }
        public virtual DbSet<EavEntity> EavEntity { get; set; }
        public virtual DbSet<EavValue> EavValue { get; set; }
        public virtual DbSet<StateProvince> StateProvince { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CountryCatalogDbDev;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "1.0.0");
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}