using AutoDB_API.DAL.DomainClasses;
using Microsoft.EntityFrameworkCore;
namespace AutoDB_API.DAL.DAO
{
    public class ManufacturerDAO
    {
        private readonly AppDbContext _appDbContext;
        public ManufacturerDAO(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<Manufacturers>> GetAll()
        {
            return await _appDbContext.Manufacturer!.ToListAsync();
        }
    }
}
