using AutoDB_API.DAL.DomainClasses;
using Microsoft.EntityFrameworkCore;
namespace AutoDB_API.DAL.DAO
{
    public class PowerTrainDAO
    {
        private readonly AppDbContext _appDbContext;
        public PowerTrainDAO(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<PowerTrains>> GetAll()
        {
            return await _appDbContext.PowerTrain!.ToListAsync();
        }
    }
}
