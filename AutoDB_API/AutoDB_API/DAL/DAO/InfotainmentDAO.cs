using AutoDB_API.DAL.DomainClasses;
using Microsoft.EntityFrameworkCore;

namespace AutoDB_API.DAL.DAO
{
    public class InfotainmentDAO
    {
        private readonly AppDbContext _appDbContext;
        public InfotainmentDAO(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<Infotainments>> GetAll()
        {
            return await _appDbContext.Infotainment!.ToListAsync();
        }
    }
}
