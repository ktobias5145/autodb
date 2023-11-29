using AutoDB_API.DAL.HelperClasses;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AutoDB_API.DAL.DAO
{
    public class VehicleHelperDAO
    {
        private readonly AppDbContext _db;
        public VehicleHelperDAO(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public List<VehicleHelper> GetAllVehicleVarations(List<ParamaterList> props)
        {
            List<VehicleHelper> allVehicles = new();

            List<DynamicFilter> filter = new List<DynamicFilter>();

                foreach (ParamaterList p in props)
                {
                    filter.Add(
                        new DynamicFilter
                        {
                            PropertyName = p.Property,
                            Operation = Op.Equals,
                            Value = p.Value
                        }
                        );
                }


            var deleg = ExpressionBuilder.GetExpression<VehicleHelper>(filter).Compile();


            IQueryable<VehicleHelper> results = from vehc in _db.Vehicle
                                                        join mod in _db.Model! on vehc.ModelId equals mod.ModelId
                                                        join manu in _db.Manufacturer! on vehc.ManufacturerId equals manu.ManufacturerId
                                                        join body in _db.BodyStyle! on vehc.BodyStyleId equals body.BodyStyleId

                                                select new VehicleHelper
                                                {
                                                            ManufacturerName = manu.ManufacturerName,
                                                            ModelName = mod.ModelName,
                                                            BodyStyle = body.BodyStyle,
                                                };
            var filteredCollection = results.Where(deleg).ToList();
            //allVehicles = await results.ToListAsync();
            return filteredCollection;
        }
    }
}
