using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleMakes.Data.Entities;

namespace VehicleMakes.Infrastructure.Configurations
{
    public class MakeModelConfigurations : IEntityTypeConfiguration<MakeModel>
    {
        public void Configure(EntityTypeBuilder<MakeModel> builder)
        {
            builder.HasKey(e => e.ModelId);

            builder.Property(e => e.ModelId).HasColumnName("ModelID");
            builder.Property(e => e.MakeId).HasColumnName("MakeID");
            builder.Property(e => e.ModelNameAr).HasMaxLength(100);
            builder.Property(e => e.ModelNameEn).HasMaxLength(100);

            builder.HasOne(d => d.Make).WithMany(p => p.MakeModels)
                .HasForeignKey(d => d.MakeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MakeModels_Makes");

        }
    }
}
