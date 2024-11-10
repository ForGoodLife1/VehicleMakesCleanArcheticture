using VehicleMakes.Data.Commons;

namespace VehicleMakes.Data.Entities;

public partial class Make : GeneralLocalizableEntity
{

    public int MakeId { get; set; }

    public string MakeNameAr { get; set; } = null!;
    public string MakeNameEn { get; set; } = null!;

    public virtual ICollection<MakeModel> MakeModels { get; set; } = new List<MakeModel>();
}
