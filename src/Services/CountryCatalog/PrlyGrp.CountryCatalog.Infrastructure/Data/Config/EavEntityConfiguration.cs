using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrlyGrp.CountryCatalog.ApplicationCore.Entities;

namespace PrlyGrp.CountryCatalog.Infrastructure.Data.Config
{
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
}
