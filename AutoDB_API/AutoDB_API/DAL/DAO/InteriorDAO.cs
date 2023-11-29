using AutoDB_API.DAL.DomainClasses;
using Microsoft.EntityFrameworkCore;
namespace AutoDB_API.DAL.DAO
{
    public class InteriorDAO
    {
        private readonly AppDbContext _appDbContext;
        public InteriorDAO(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<Interiors>> GetAll()
        {
            return await _appDbContext.Interior!.ToListAsync();
        }
    }
}
