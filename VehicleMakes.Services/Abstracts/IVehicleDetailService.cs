using VehicleMakes.Data.Entities;
using VehicleMakes.Data.Enums;

namespace VehicleDetails.Services.Abstracts
{
    public interface IVehicleDetailService
    {

        public Task<List<VehicleDetail>> GetVehicleDetailsListAsync();
        public Task<VehicleDetail> GetVehicleDetailByIDWithIncludeAsync(int id);
        public Task<VehicleDetail> GetByIDAsync(int id);
        public Task<string> AddAsync(VehicleDetail vehicleDetail);
        public Task<bool> IsNameArExist(string nameAr);
        public Task<bool> IsNameEnExist(string nameEn);
        public Task<bool> IsNameArExistExcludeSelf(string nameAr, int id);
        public Task<bool> IsNameEnExistExcludeSelf(string nameEn, int id);
        public Task<string> EditAsync(VehicleDetail vehicleDetail);
        public Task<string> DeleteAsync(VehicleDetail vehicleDetail);
        public IQueryable<VehicleDetail> GetVehicleDetailsQuerable();
        public IQueryable<VehicleDetail> GetVehicleDetailsByDriveType1IDQuerable(int DID);
        public IQueryable<VehicleDetail> FilterVehicleDetailPaginatedQuerable(VehicleDetailOrderingEnum orderingEnum, string search);
    }
}
