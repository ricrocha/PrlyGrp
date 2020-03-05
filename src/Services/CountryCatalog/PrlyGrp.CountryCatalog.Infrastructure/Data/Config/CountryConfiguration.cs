using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrlyGrp.CountryCatalog.ApplicationCore.Entities;

namespace PrlyGrp.CountryCatalog.Infrastructure.Data.Config
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            builder.Property(e => e.ChangedBy)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.DeletedBy).HasMaxLength(50);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.ShortName)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
    public class StateProvinceConfiguration : IEntityTypeConfiguration<StateProvince>
    {
        public void Configure(EntityTypeBuilder<StateProvince> builder)
        {
            builder.Property(e => e.ChangedBy)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.CountryCode)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.DeletedBy).HasMaxLength(20);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.ShortName)
                .IsRequired()
                .HasMaxLength(20);

            builder.HasOne(d => d.Country)
                .WithMany(p => p.StateProvince)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StateProvince_Country");
        }
    }
    public class EavAttributeConfiguration : IEntityTypeConfiguration<EavAttribute>
    {
        public void Configure(EntityTypeBuilder<EavAttribute> builder)
        {
            builder.Property(e => e.ChangedBy)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.DataType)
                .IsRequired()
                .HasMaxLength(25);

            builder.Property(e => e.DefaultValue).HasMaxLength(255);

            builder.Property(e => e.DeletedBy).HasMaxLength(50);

            builder.Property(e => e.EavEntityShortName).HasMaxLength(20);

            builder.Property(e => e.Label)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.ShortName)
                .IsRequired()
                .HasMaxLength(20);

            builder.HasOne(d => d.EavEntity)
                .WithMany(p => p.EavAttribute)
                .HasForeignKey(d => d.EavEntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EavAttribute_EavEntity");
        }
    }
    public class EavEntityConfiguration : IEntityTypeConfiguration<EavEntity>
    {
        public void Configure(EntityTypeBuilder<EavEntity> builder)
        {
            builder.Property(e => e.ChangedBy)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.DeletedBy).HasMaxLength(50);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.ShortName)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
    public class EavValueConfiguration : IEntityTypeConfiguration<EavValue>
    {
        public void Configure(EntityTypeBuilder<EavValue> builder)
        {
            builder.Property(e => e.ChangedBy)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.DeletedBy).HasMaxLength(50);

            builder.Property(e => e.EavAttributeShortName).HasMaxLength(20);

            builder.Property(e => e.EavEntityShortName).HasMaxLength(20);

            builder.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(255);

            builder.HasOne(d => d.EavAttribute)
                .WithMany(p => p.EavValue)
                .HasForeignKey(d => d.EavAttributeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EavValue_EavAttribute");

            builder.HasOne(d => d.EavEntity)
                .WithMany(p => p.EavValue)
                .HasForeignKey(d => d.EavEntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EavValue_EavEntity");
        }
    }
}
