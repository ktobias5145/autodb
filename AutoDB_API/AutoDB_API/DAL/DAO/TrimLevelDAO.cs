using AutoDB_API.DAL.DomainClasses;
using Microsoft.EntityFrameworkCore;
namespace AutoDB_API.DAL.DAO
{
    public class TrimLevelDAO
    {
        private readonly AppDbContext _appDbContext;
        public TrimLevelDAO(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<TrimLevels>> GetAll()
        {
            return await _appDbContext.TrimLevel!.ToListAsync();
        }
    }
}
