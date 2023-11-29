using AutoDB_API.DAL.DomainClasses;
using Microsoft.EntityFrameworkCore;
namespace AutoDB_API.DAL.DAO
{
    public class CompressorDAO
    {
        private readonly AppDbContext _appDbContext;
        public CompressorDAO(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<Compressors>> GetAll()
        {
            return await _appDbContext.Compressor!.ToListAsync();
        }
    }
}
