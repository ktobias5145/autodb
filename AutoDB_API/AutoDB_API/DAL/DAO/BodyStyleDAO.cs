using AutoDB_API.DAL.DomainClasses;
using Microsoft.EntityFrameworkCore;

namespace AutoDB_API.DAL.DAO
{
    public class BodyStyleDAO
    {
        private readonly AppDbContext _appDbContext;
        public BodyStyleDAO(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<BodyStyles>> GetAll()
        {
            return await _appDbContext.BodyStyle!.ToListAsync();
        }
    }
}
