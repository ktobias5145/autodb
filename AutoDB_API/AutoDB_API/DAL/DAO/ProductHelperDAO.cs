using AutoDB_API.DAL.DomainClasses;
using AutoDB_API.DAL.HelperClasses;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace AutoDB_API.DAL.DAO
{
    public class ProductHelperDAO
    {
        private readonly AppDbContext _db;
        public ProductHelperDAO(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public List<ProductVarationHelper> GetAllProductVarations()
        {
            List<ProductVarationHelper> allVehicles = new();

            List<DynamicFilter> filter = new List<DynamicFilter>()
            {
                new DynamicFilter
                {
                    PropertyName = "PassengerCap" ,Operation = Op .GreaterThan, Value = 2
                },
                                new DynamicFilter
                {
                    PropertyName = "ScreenSize" ,Operation = Op .GreaterThan, Value = (decimal)9.0
                }
            };

            var deleg = ExpressionBuilder.GetExpression<ProductVarationHelper>(filter).Compile();


            IQueryable<ProductVarationHelper> results = from prod in _db.ProductVaration
                                                        join vehc in _db.Vehicle! on prod.VehicleId equals vehc.VehicleId
                                                        join model in _db.Model! on vehc.ModelId equals model.ModelId
                                                        join manu in _db.Manufacturer! on vehc.ManufacturerId equals manu.ManufacturerId
                                                        join body in _db.BodyStyle! on vehc.BodyStyleId equals body.BodyStyleId
                                                        join trim in _db.TrimLevel! on prod.TrimLevelId equals trim.TrimLevelId
                                                        join dim in _db.Dimensions! on prod.DimensionId equals dim.DimensionsID
                                                        join ext in _db.Exterior! on prod.ExteriorId equals ext.ExteriorId
                                                        join info in _db.Infotainment! on prod.InfotainmentId equals info.InfotainmentId
                                                        join interior in _db.Interior! on prod.InteriorId equals interior.InteriorId
                                                        join powtr in _db.PowerTrain! on prod.PowerTrainId equals powtr.PowerTrainId
                                                        join gear in _db.Gearing! on prod.GearingId equals gear.GearingId
                                                        join tran in _db.TransmissionType! on gear.TransmissionTypeId equals tran.TransmissionTypeId
                                                        join econ in _db.Economy! on prod.EconomyId equals econ.EconomyId
                                                        join drive in _db.DriveType! on prod.DriveTypeId equals drive.DriveTypeId
                                                        join mech in _db.Mechanical! on prod.MechanicalId equals mech.MechanicalId
                                                        join cyl in _db.CylinderConfig! on mech.CylinderConfigId equals cyl.CylinderConfigId
                                                        join comp in _db.Compressor! on mech.CompressorId equals comp.CompressorId
                                                        select new ProductVarationHelper
                                                        {
                                                            ManufacturerName = manu.ManufacturerName,
                                                            ModelName = model.ModelName,
                                                            BodyStyle = body.BodyStyle,
                                                            ProductYear = prod.ProductYear,
                                                            MSRPCad = prod.MSRPCad,
                                                            MSRPUsd = prod.MSRPUsd,
                                                            PictureFile = prod.PictureFile,
                                                            PictureCitation = prod.PictureCitation,
                                                            TrimLevel = trim.TrimLevel,
                                                            WheelBase = dim.WheelBase,
                                                            VehicleLength = dim.VehicleLength,
                                                            Width = dim.Width,
                                                            Height = dim.Height,
                                                            VehicleWeight = dim.VehicleWeight,
                                                            PassengerCap = dim.PassengerCap,
                                                            PassengerVolume = dim.PassengerVolume,
                                                            CargoVolume = dim.CargoVolume,
                                                            TireWidth = ext.TireWidth,
                                                            TireHeight = ext.TireHeight,
                                                            RimSize = ext.RimSize,
                                                            HeatedMirrors = ext.HeatedMirrors,
                                                            SunRoof = ext.SunRoof,
                                                            NumDoors = ext.NumDoors,
                                                            ScreenSize = info.ScreenSize,
                                                            NumSpeakers = info.NumSpeakers,
                                                            NumSubwoofers = info.NumSubwoofers,
                                                            WirelessCharging = info.WirelessCharging,
                                                            AppleCarPlay = info.AppleCarPlay,
                                                            AndroidAuto = info.AndroidAuto,
                                                            WifiCapable = info.WifiCapable,
                                                            HeatedSeats = interior.HeatedSeats,
                                                            VentilatedSeats = interior.VentilatedSeats,
                                                            DriverSeatElectricAdjustment = interior.DriverSeatElectricAdjustment,
                                                            PassengerSeatElectricAdjustment = interior.PassengerSeatElectricAdjustment,
                                                            RemoteStart = interior.RemoteStart,
                                                            HeatedSteeringWheel = interior.HeatedSteeringWheel,
                                                            PaddleShifters = interior.PaddleShifters,
                                                            PowerTrainType = powtr.PowerTrainType,
                                                            TransmissionType = tran.TransmissionType,
                                                            NumGears = tran.NumGears,
                                                            FinalDriveRation = gear.FinalDriveRation,
                                                            FuelGrade = econ.FuelGrade,
                                                            MPGHighway = econ.MPGHighway,
                                                            MPGCity = econ.MPGCity,
                                                            MPGCombined = econ.MPGCombined,
                                                            LitersPerKMHighway = econ.LitersPerKMHighway,
                                                            LitersPerKMCity = econ.LitersPerKMCity,
                                                            LitersPerKMCombined = econ.LitersPerKMCombined,
                                                            TankCapacity = econ.TankCapacity,
                                                            BatteryCapacity = econ.BatteryCapacity,
                                                            VehicleRange = econ.VehicleRange,
                                                            DriveType = drive.DriveType,
                                                            Horsepower = mech.Horsepower,
                                                            Torque = mech.Torque,
                                                            EngineSize = mech.EngineSize,
                                                            CylinderConfig = cyl.CylinderConfig,
                                                            CompressorType = comp.CompressorType,
                                                            AccelTime = mech.AccelTime,
                                                            Topspeed = mech.Topspeed,
                                                            TowingCapability = mech.TowingCapability,
                                                            AutoStopStart = mech.AutoStopStart,
                                                            BatteryType = mech.BatteryType,
                                                            MotorVoltage = mech.MotorVoltage
                                                        };
            var filteredCollection = results.Where(deleg).ToList();
            //allVehicles = await results.ToListAsync();
            return filteredCollection;
        }
    }
}
