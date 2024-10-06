namespace VehicleMakes.Data.Entities;

public partial class SubModel
{
    public int SubModelId { get; set; }

    public int ModelId { get; set; }

    public string SubModelNameAr { get; set; } = null!;
    public string SubModelNameEn { get; set; } = null!;

    public virtual MakeModel Model { get; set; } = null!;

    public virtual ICollection<VehicleDetail> VehicleDetails { get; set; } = new List<VehicleDetail>();
}
