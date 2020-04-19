using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrlyGrp.CountryCatalog.ApplicationCore.Entities;

namespace PrlyGrp.CountryCatalog.Infrastructure.Data.Config
{
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
