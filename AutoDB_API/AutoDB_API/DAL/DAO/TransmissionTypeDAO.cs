using AutoDB_API.DAL.DomainClasses;
using Microsoft.EntityFrameworkCore;

namespace AutoDB_API.DAL.DAO
{
    public class TransmissionTypeDAO
    {
        private readonly AppDbContext _appDbContext;
        public TransmissionTypeDAO(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<TransmissionTypes>> GetAll()
        {
            return await _appDbContext.TransmissionType!.ToListAsync();
        }
    }
}
