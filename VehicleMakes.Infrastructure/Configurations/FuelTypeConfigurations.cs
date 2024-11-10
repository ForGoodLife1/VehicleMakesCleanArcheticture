using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleMakes.Data.Entities;

namespace VehicleMakes.Infrastructure.Configurations
{
    public class FuelTypeConfigurations : IEntityTypeConfiguration<FuelType>
    {
        public void Configure(EntityTypeBuilder<FuelType> builder)
        {
            builder.HasKey(e => e.FuelTypeId).HasName("PK_FuleTypes");

            builder.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");
            builder.Property(e => e.FuelTypeNameAr).HasMaxLength(50);
            builder.Property(e => e.FuelTypeNameEn).HasMaxLength(50);
        }
    }
}
