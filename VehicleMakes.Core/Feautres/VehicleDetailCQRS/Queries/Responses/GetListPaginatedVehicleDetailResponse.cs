namespace VehicleMakes.Core.Feautres.VehicleDetailCQRS.Queries.Responses
{
    public class GetListPaginatedVehicleDetailResponse
    {
        public GetListPaginatedVehicleDetailResponse(int id, int? makeId, int? modelId, int? subModelId, int? bodyId,
                                         string? vehicleDisplayName, short? year, int? driveTypeId,
                                         string? engine, short? engineCc, byte? engineCylinders, decimal? engineLiterDisplay,
                                         int? fuelTypeId, byte? numDoors)
        {
            Id=id;
            MakeId=makeId;
            ModelId=modelId;
            SubModelId=subModelId;
            BodyId=bodyId;
            VehicleDisplayName=vehicleDisplayName;
            Year=year;
            DriveTypeId=driveTypeId;
            Engine=engine;
            EngineCc=engineCc;
            EngineCylinders=engineCylinders;
            EngineLiterDisplay=engineLiterDisplay;
            FuelTypeId=fuelTypeId;
            NumDoors=numDoors;
        }
        public int Id { get; set; }

        public int? MakeId { get; set; }

        public int? ModelId { get; set; }

        public int? SubModelId { get; set; }

        public int? BodyId { get; set; }

        public string? VehicleDisplayName { get; set; }

        public short? Year { get; set; }

        public int? DriveTypeId { get; set; }

        public string? Engine { get; set; }

        public short? EngineCc { get; set; }

        public byte? EngineCylinders { get; set; }

        public decimal? EngineLiterDisplay { get; set; }

        public int? FuelTypeId { get; set; }

        public byte? NumDoors { get; set; }
    }
}
