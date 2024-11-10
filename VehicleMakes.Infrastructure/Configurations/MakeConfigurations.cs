using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleMakes.Data.Entities;

namespace VehicleMakes.Infrastructure.Configurations
{
    public class MakeConfigurations : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {

            builder.HasKey(e => e.MakeId).HasName("PK_Make");

            builder.Property(e => e.MakeId).HasColumnName("MakeID");

        }
    }
}
