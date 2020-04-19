using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrlyGrp.CountryCatalog.ApplicationCore.Entities;

namespace PrlyGrp.CountryCatalog.Infrastructure.Data.Config
{
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
}
