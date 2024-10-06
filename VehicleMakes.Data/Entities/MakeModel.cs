namespace VehicleMakes.Data.Entities;

public partial class MakeModel
{
    public int ModelId { get; set; }

    public int MakeId { get; set; }

    public string ModelNameAr { get; set; } = null!;
    public string ModelNameEn { get; set; } = null!;

    public virtual Make Make { get; set; } = null!;

    public virtual ICollection<SubModel> SubModels { get; set; } = new List<SubModel>();
}
