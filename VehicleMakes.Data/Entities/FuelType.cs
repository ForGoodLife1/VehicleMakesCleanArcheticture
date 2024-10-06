namespace VehicleMakes.Data.Entities;

public partial class FuelType
{
    public int FuelTypeId { get; set; }

    public string FuelTypeNameAr { get; set; } = null!;
    public string FuelTypeNameEn { get; set; } = null!;

    public virtual ICollection<VehicleDetail> VehicleDetails { get; set; } = new List<VehicleDetail>();
}
