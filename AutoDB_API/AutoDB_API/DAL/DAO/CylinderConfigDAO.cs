using AutoDB_API.DAL.DomainClasses;
using Microsoft.EntityFrameworkCore;
namespace AutoDB_API.DAL.DAO
{
    public class CylinderConfigDAO
    {
        private readonly AppDbContext _appDbContext;
        public CylinderConfigDAO(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<CylinderConfigs>> GetAll()
        {
            return await _appDbContext.CylinderConfig!.ToListAsync();
        }
    }
}
