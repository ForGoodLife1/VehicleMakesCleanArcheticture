using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using VehicleMakes.Data.Entities;
using VehicleMakes.Data.Entities.Identity;

namespace VehicleMakes.Infrastructure;

public partial class VehicleMakesDbContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
{
    public VehicleMakesDbContext()
    {
    }

    public VehicleMakesDbContext(DbContextOptions<VehicleMakesDbContext> options)
        : base(options)
    {
    }
    public DbSet<User> User { get; set; }
    public DbSet<UserRefreshToken> UserRefreshToken { get; set; }

    public virtual DbSet<Body> Bodies { get; set; }

    public virtual DbSet<DriveType1> DriveTypes { get; set; }

    public virtual DbSet<FuelType> FuelTypes { get; set; }

    public virtual DbSet<Make> Makes { get; set; }

    public virtual DbSet<MakeModel> MakeModels { get; set; }

    public virtual DbSet<SubModel> SubModels { get; set; }





    public virtual DbSet<VehicleDetail> VehicleDetails { get; set; }

    public virtual DbSet<VehicleMasterDetail> VehicleMasterDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-5RPLH84\\SQLEXPRESS;Initial Catalog=VehicleMakes;Integrated Security=SSPI;TrustServerCertificate=true ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        // modelBuilder.UseEncryption(_encryptionProvider);

    }
}


