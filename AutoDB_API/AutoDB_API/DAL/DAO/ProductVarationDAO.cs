using AutoDB_API.DAL.DomainClasses;
using Microsoft.EntityFrameworkCore;

namespace AutoDB_API.DAL.DAO
{
    public class ProductVarationDAO
    {
        private readonly AppDbContext _appDbContext;
        public ProductVarationDAO(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<ProductVarations>> GetAll()
        {
            return await _appDbContext.ProductVaration!.ToListAsync();
        }
    }
}
