using AutoDB_API.DAL.DomainClasses;
using Microsoft.EntityFrameworkCore;
namespace AutoDB_API.DAL.DAO
{
    public class GearingDAO
    {
        private readonly AppDbContext _appDbContext;
        public GearingDAO(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<Gearings>> GetAll()
        {
            return await _appDbContext.Gearing!.ToListAsync();
        }
    }
}
