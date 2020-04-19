using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrlyGrp.CountryCatalog.ApplicationCore.Entities;

namespace PrlyGrp.CountryCatalog.Infrastructure.Data.Config
{
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
}
