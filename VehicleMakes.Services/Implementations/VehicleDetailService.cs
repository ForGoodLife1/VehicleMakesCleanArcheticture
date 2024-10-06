using Microsoft.EntityFrameworkCore;
using VehicleDetails.Services.Abstracts;
using VehicleMakes.Data.Entities;
using VehicleMakes.Data.Enums;
using VehicleMakes.Infrastructure.Abstract;


namespace VehicleMakes.Services.Implementations
{
    public class VehicleDetailService : IVehicleDetailService
    {
        private readonly IVehicleDetailRepository _VehicleDetailRepository;

        public VehicleDetailService(IVehicleDetailRepository VehicleDetailRepository)
        {
            _VehicleDetailRepository=VehicleDetailRepository;
        }

        public async Task<List<VehicleDetail>> GetVehicleDetailsListAsync()
        {
            return await _VehicleDetailRepository.GetVehicleDetailsListAsync();
        }

        public async Task<VehicleDetail> GetVehicleDetailByIDWithIncludeAsync(int id)
        {
            // var VehicleDetail = await _VehicleDetailRepository.GetByIdAsync(id);
            var VehicleDetail = _VehicleDetailRepository.GetTableNoTracking()
                                          .Include(x => x.DriveTypeId)
                                          .Where(x => x.DriveTypeId.Equals(id))
                                          .FirstOrDefault();
            return VehicleDetail;
        }

        public async Task<string> AddAsync(VehicleDetail VehicleDetail)
        {
            //Added VehicleDetail
            await _VehicleDetailRepository.AddAsync(VehicleDetail);
            return "Success";
        }

        public async Task<bool> IsNameArExist(string nameAr)
        {
            //Check if the name is Exist Or not
            var VehicleDetail = _VehicleDetailRepository.GetTableNoTracking().Where(x => x.NameAr.Equals(nameAr)).FirstOrDefault();
            if (VehicleDetail == null) return false;
            return true;
        }

        public async Task<bool> IsNameArExistExcludeSelf(string nameAr, int id)
        {
            //Check if the name is Exist Or not
            var VehicleDetail = await _VehicleDetailRepository.GetTableNoTracking().Where(x => x.NameAr.Equals(nameAr) & !x.StudID.Equals(id)).FirstOrDefaultAsync();
            if (VehicleDetail == null) return false;
            return true;
        }

        public async Task<string> EditAsync(VehicleDetail VehicleDetail)
        {
            await _VehicleDetailRepository.UpdateAsync(VehicleDetail);
            return "Success";
        }

        public async Task<string> DeleteAsync(VehicleDetail VehicleDetail)
        {
            var trans = _VehicleDetailRepository.BeginTransaction();
            try
            {
                await _VehicleDetailRepository.DeleteAsync(VehicleDetail);
                await trans.CommitAsync();
                return "Success";
            }
            catch (Exception ex)
            {
                await trans.RollbackAsync();
                Log.Error(ex.Message);
                return "Falied";
            }

        }

        public async Task<VehicleDetail> GetByIDAsync(int id)
        {
            var VehicleDetail = await _VehicleDetailRepository.GetByIdAsync(id);
            return VehicleDetail;
        }

        public IQueryable<VehicleDetail> GetVehicleDetailsQuerable()
        {
            return _VehicleDetailRepository.GetTableNoTracking().Include(x => x.Department).AsQueryable();
        }

        public IQueryable<VehicleDetail> FilterVehicleDetailPaginatedQuerable(VehicleDetailOrderingEnum orderingEnum, string search)
        {
            var querable = _VehicleDetailRepository.GetTableNoTracking().Include(x => x.Department).AsQueryable();
            if (search != null)
            {
                querable = querable.Where(x => x.NameAr.Contains(search) || x.Address.Contains(search));
            }
            switch (orderingEnum)
            {
                case VehicleDetailOrderingEnum.StudID:
                    querable = querable.OrderBy(x => x.StudID);
                    break;
                case VehicleDetailOrderingEnum.Name:
                    querable = querable.OrderBy(x => x.NameAr);
                    break;
                case VehicleDetailOrderingEnum.Address:
                    querable = querable.OrderBy(x => x.Address);
                    break;
                case VehicleDetailOrderingEnum.DepartmentName:
                    querable = querable.OrderBy(x => x.Department.DNameAr);
                    break;
            }

            return querable;
        }

        public async Task<bool> IsNameEnExist(string nameEn)
        {
            //Check if the name is Exist Or not
            var VehicleDetail = _VehicleDetailRepository.GetTableNoTracking().Where(x => x.NameEn.Equals(nameEn)).FirstOrDefault();
            if (VehicleDetail == null) return false;
            return true;
        }

        public async Task<bool> IsNameEnExistExcludeSelf(string nameEn, int id)
        {
            //Check if the name is Exist Or not
            var VehicleDetail = await _VehicleDetailRepository.GetTableNoTracking().Where(x => x.NameEn.Equals(nameEn) & !x.StudID.Equals(id)).FirstOrDefaultAsync();
            if (VehicleDetail == null) return false;
            return true;
        }

        public IQueryable<VehicleDetail> GetVehicleDetailsByDriveType1IDQuerable(int DID)
        {
            return _VehicleDetailRepository.GetTableNoTracking().Where(x => x.DriveTypeId.Equals(DID)).AsQueryable();
        }




    }
}
