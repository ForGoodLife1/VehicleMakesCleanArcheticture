using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleMakes.Data.Entities;

namespace VehicleMakes.Infrastructure.Configurations
{
    public class BodyConfigurations : IEntityTypeConfiguration<Body>
    {
        public void Configure(EntityTypeBuilder<Body> builder)
        {
            builder.Property(e => e.BodyId).HasColumnName("BodyID");
            builder.Property(e => e.BodyNameAr).HasMaxLength(50);
            builder.Property(e => e.BodyNameEn).HasMaxLength(50);
        }
    }
}
