using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleMakes.Data.Entities;

namespace VehicleMakes.Infrastructure.Configurations
{
    public class VehicleMasterDetailConfigurations : IEntityTypeConfiguration<VehicleMasterDetail>
    {
        public void Configure(EntityTypeBuilder<VehicleMasterDetail> builder)
        {
            builder
                .HasNoKey()
                .ToView("VehicleMasterDetails");

            builder.Property(e => e.BodyId).HasColumnName("BodyID");
            builder.Property(e => e.BodyName).HasMaxLength(50);
            builder.Property(e => e.DriveTypeId).HasColumnName("DriveTypeID");
            builder.Property(e => e.DriveTypeName).HasMaxLength(50);
            builder.Property(e => e.Engine).HasMaxLength(100);
            builder.Property(e => e.EngineCc).HasColumnName("Engine_CC");
            builder.Property(e => e.EngineCylinders).HasColumnName("Engine_Cylinders");
            builder.Property(e => e.EngineLiterDisplay)
                .HasColumnType("money")
                .HasColumnName("Engine_Liter_Display");
            builder.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");
            builder.Property(e => e.FuelTypeName).HasMaxLength(50);
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Make).HasMaxLength(100);
            builder.Property(e => e.MakeId).HasColumnName("MakeID");
            builder.Property(e => e.ModelId).HasColumnName("ModelID");
            builder.Property(e => e.ModelName).HasMaxLength(100);
            builder.Property(e => e.SubModelId).HasColumnName("SubModelID");
            builder.Property(e => e.SubModelName).HasMaxLength(100);
            builder.Property(e => e.VehicleDisplayName)
                .HasMaxLength(150)
                .HasColumnName("Vehicle_Display_Name");
        }
    }
}
