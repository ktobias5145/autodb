using AutoDB_API.DAL.DomainClasses;
using Microsoft.EntityFrameworkCore;

namespace AutoDB_API.DAL.DAO
{
    public class ModelDAO
    {
        private readonly AppDbContext _appDbContext;
        public ModelDAO(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<Models>> GetAll()
        {
            return await _appDbContext.Model!.ToListAsync();
        }
    }
}
