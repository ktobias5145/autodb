using AutoDB_API.DAL.DomainClasses;
using Microsoft.EntityFrameworkCore;

namespace AutoDB_API.DAL.DAO
{
    public class ExteriorDAO
    {
        private readonly AppDbContext _appDbContext;
        public ExteriorDAO(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<Exteriors>> GetAll()
        {
            return await _appDbContext.Exterior!.ToListAsync();
        }
    }
}
