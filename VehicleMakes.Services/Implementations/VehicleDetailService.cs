using Microsoft.EntityFrameworkCore;
using Serilog;
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

        /* public async Task<bool> IsNameArExist(string nameAr)
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
         }*/

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
            return _VehicleDetailRepository.GetTableNoTracking().Include(x => x.Body)
                                                                .Include(x => x.DriveType)
                                                                .Include(x => x.SubModel)
                                                                .Include(x => x.FuelType).AsQueryable();
        }

        public IQueryable<VehicleDetail> FilterVehicleDetailPaginatedQuerable(VehicleDetailOrderingEnum orderingEnum, string search)
        {
            var querable = _VehicleDetailRepository.GetTableNoTracking().Include(x => x.Body)
                                                                        .Include(x => x.FuelType)
                                                                        .Include(x => x.SubModel)
                                                                        .Include(x => x.DriveType).AsQueryable();
            if (search != null)
            {
                querable = querable.Where(x => x.VehicleDisplayName.Contains(search) || x.NumDoors.Equals(search));
            }
            switch (orderingEnum)
            {
                case VehicleDetailOrderingEnum.Id:
                    querable = querable.OrderBy(x => x.Id);
                    break;
                case VehicleDetailOrderingEnum.VehicleDisplayName:
                    querable = querable.OrderBy(x => x.VehicleDisplayName);
                    break;
                case VehicleDetailOrderingEnum.Engine:
                    querable = querable.OrderBy(x => x.Engine);
                    break;
                case VehicleDetailOrderingEnum.BodyName:
                    querable = querable.OrderBy(x => x.Body.BodyNameEn);
                    break;
            }

            return querable;
        }

        /*   public async Task<bool> IsNameEnExist(string nameEn)
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
           }*/

        public IQueryable<VehicleDetail> GetVehicleDetailsByDriveType1IDQuerable(int DID)
        {
            return _VehicleDetailRepository.GetTableNoTracking().Where(x => x.DriveTypeId.Equals(DID)).AsQueryable();
        }




    }
}
