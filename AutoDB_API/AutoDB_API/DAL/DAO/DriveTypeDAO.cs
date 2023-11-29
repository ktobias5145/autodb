using AutoDB_API.DAL.DomainClasses;
using Microsoft.EntityFrameworkCore;
namespace AutoDB_API.DAL.DAO
{
    public class DriveTypeDAO
    {
        private readonly AppDbContext _appDbContext;
        public DriveTypeDAO(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<DriveTypes>> GetAll()
        {
            return await _appDbContext.DriveType!.ToListAsync();
        }
    }
}
