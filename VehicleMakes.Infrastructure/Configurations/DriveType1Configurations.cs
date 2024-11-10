using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleMakes.Data.Entities;

namespace VehicleMakes.Infrastructure.Configurations
{
    public class DriveType1Configurations : IEntityTypeConfiguration<DriveType1>
    {
        public void Configure(EntityTypeBuilder<DriveType1> builder)
        {
            builder.HasKey(e => e.DriveTypeId).HasName("PK_DriveType1");
            builder.Property(e => e.DriveTypeId).HasColumnName("DriveTypeID");
            builder.Property(e => e.DriveTypeNameAr).HasMaxLength(50);
            builder.Property(e => e.DriveTypeNameEn).HasMaxLength(50);
        }
    }
}
