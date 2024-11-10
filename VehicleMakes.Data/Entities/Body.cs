using VehicleMakes.Data.Commons;

namespace VehicleMakes.Data.Entities;

public partial class Body : GeneralLocalizableEntity
{
    public int BodyId { get; set; }

    public string BodyNameAr { get; set; } = null!;
    public string BodyNameEn { get; set; } = null!;

    public virtual ICollection<VehicleDetail> VehicleDetails { get; set; } = new List<VehicleDetail>();
}
