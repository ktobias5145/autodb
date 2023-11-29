using AutoDB_API.DAL.DomainClasses;
using Microsoft.EntityFrameworkCore;
namespace AutoDB_API.DAL.DAO
{
    public class DimensionDAO
    {
        private readonly AppDbContext _appDbContext;
        public DimensionDAO(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<Dimensions>> GetAll()
        {
            return await _appDbContext.Dimensions!.ToListAsync();
        }
    }
}
