using AutoDB_API.DAL.DomainClasses;
using Microsoft.EntityFrameworkCore;
namespace AutoDB_API.DAL.DAO
{
    public class EconomyDAO
    {
        private readonly AppDbContext _appDbContext;
        public EconomyDAO(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<Economys>> GetAll()
        {
            return await _appDbContext.Economy!.ToListAsync();
        }
    }
}
