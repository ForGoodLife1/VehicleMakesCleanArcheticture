namespace VehicleMakes.Data.Entities;

public partial class DriveType1
{
    public int DriveTypeId { get; set; }

    public string DriveTypeNameAr { get; set; } = null!;
    public string DriveTypeNameEn { get; set; } = null!;

    public virtual ICollection<VehicleDetail> VehicleDetails { get; set; } = new List<VehicleDetail>();
}
