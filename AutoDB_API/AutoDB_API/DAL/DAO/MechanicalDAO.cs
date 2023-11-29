using AutoDB_API.DAL.DomainClasses;
using Microsoft.EntityFrameworkCore;
namespace AutoDB_API.DAL.DAO
{
    public class MechanicalDAO
    {
        private readonly AppDbContext _appDbContext;
        public MechanicalDAO(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<Mechanicals>> GetAll()
        {
            return await _appDbContext.Mechanical!.ToListAsync();
        }
    }
}
