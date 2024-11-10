using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleMakes.Data.Entities;

namespace VehicleMakes.Infrastructure.Configurations
{
    public class VehicleDetailConfigurations : IEntityTypeConfiguration<VehicleDetail>
    {
        public void Configure(EntityTypeBuilder<VehicleDetail> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_CarDetails");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            builder.Property(e => e.BodyId).HasColumnName("BodyID");
            builder.Property(e => e.DriveTypeId).HasColumnName("DriveTypeID");
            builder.Property(e => e.Engine).HasMaxLength(100);
            builder.Property(e => e.EngineCc).HasColumnName("Engine_CC");
            builder.Property(e => e.EngineCylinders).HasColumnName("Engine_Cylinders");
            builder.Property(e => e.EngineLiterDisplay)
                .HasColumnType("money")
                .HasColumnName("Engine_Liter_Display");
            builder.Property(e => e.FuelTypeId).HasColumnName("FuelTypeID");
            builder.Property(e => e.MakeId).HasColumnName("MakeID");
            builder.Property(e => e.ModelId).HasColumnName("ModelID");
            builder.Property(e => e.SubModelId).HasColumnName("SubModelID");
            builder.Property(e => e.VehicleDisplayName)
                .HasMaxLength(150)
                .HasColumnName("Vehicle_Display_Name");

            builder.HasOne(d => d.Body).WithMany(p => p.VehicleDetails)
                .HasForeignKey(d => d.BodyId)
                .HasConstraintName("FK_VehicleDetails_Bodies");

            builder.HasOne(d => d.DriveType).WithMany(p => p.VehicleDetails)
                .HasForeignKey(d => d.DriveTypeId)
                .HasConstraintName("FK_VehicleDetails_DriveTypes");

            builder.HasOne(d => d.FuelType).WithMany(p => p.VehicleDetails)
                .HasForeignKey(d => d.FuelTypeId)
                .HasConstraintName("FK_VehicleDetails_FuelTypes");

            builder.HasOne(d => d.SubModel).WithMany(p => p.VehicleDetails)
                .HasForeignKey(d => d.SubModelId)
                .HasConstraintName("FK_VehicleDetails_SubModels");
        }
    }
}
