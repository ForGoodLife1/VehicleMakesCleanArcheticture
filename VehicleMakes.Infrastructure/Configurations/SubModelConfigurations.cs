using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleMakes.Data.Entities;

namespace VehicleMakes.Infrastructure.Configurations
{
    public class SubModelConfigurations : IEntityTypeConfiguration<SubModel>
    {
        public void Configure(EntityTypeBuilder<SubModel> builder)
        {
            builder.Property(e => e.SubModelId).HasColumnName("SubModelID");
            builder.Property(e => e.ModelId).HasColumnName("ModelID");
            builder.Property(e => e.SubModelNameAr).HasMaxLength(100);
            builder.Property(e => e.SubModelNameEn).HasMaxLength(100);

            builder.HasOne(d => d.Model).WithMany(p => p.SubModels)
                .HasForeignKey(d => d.ModelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubModels_MakeModels");
        }
    }
}
