namespace VehicleMakes.Data.Entities;

public partial class Make
{
    public int MakeId { get; set; }

    public string MakeNameAr { get; set; } = null!;
    public string MakeNameEn { get; set; } = null!;

    public virtual ICollection<MakeModel> MakeModels { get; set; } = new List<MakeModel>();
}
