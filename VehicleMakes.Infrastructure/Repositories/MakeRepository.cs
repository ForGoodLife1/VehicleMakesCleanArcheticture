using Microsoft.EntityFrameworkCore;
using VehicleMakes.Data.Entities;
using VehicleMakes.Infrastructure.Abstract;
using VehicleMakes.Infrastructure.InfrastructureBases;

namespace VehicleMakes.Infrastructure.Repositories
{
    public class MakeRepository : GenericRepositoryAsync<Make>, IMakeRepository
    {
        #region Fields
        private readonly DbSet<Make> _make;
        #endregion
        #region Constructors
        public MakeRepository(VehicleMakesDbContext dBContext) : base(dBContext)
        {
            _make = dBContext.Set<Make>();
        }

        public Task<List<Make>> GetStudentsListAsync()
        {
            throw new NotImplementedException();
        }



        #endregion


    }
}