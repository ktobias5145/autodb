using AutoDB_API.DAL.HelperClasses;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace AutoDB_API.DAL.DAO
{
    public class VehicleDAO
    {
        private readonly AppDbContext _appDbContext;
        public VehicleDAO(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<VehicleHelper>> GetAllVehicles()
        {
           // Vehicle? vehicle = new();
            List<VehicleHelper> allVehicles = new();

            var results = from v in _appDbContext.Vehicle
                          join model in _appDbContext.Model! on v.ModelId equals model.ModelId
                          join manu in _appDbContext.Manufacturer! on v.ManufacturerId equals manu.ManufacturerId
                          join body in _appDbContext.BodyStyle! on v.BodyStyleId equals body.BodyStyleId
                          select new VehicleHelper
                          {
                            ManufacturerName = manu.ManufacturerName,
                              ModelName = model.ModelName,
                              BodyStyle = body.BodyStyle
                          };

            allVehicles = await results.ToListAsync();
            return allVehicles;
        }
    }
}
