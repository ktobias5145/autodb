using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AutoDB_API.DAL.HelperClasses
{
    public class ProductVarationHelper
    {
        public string? ManufacturerName { get; set; }
        public string? ModelName { get; set; }
        public string? BodyStyle { get; set; }
        public int ProductYear { get; set; }
        public decimal MSRPCad { get; set; }
        public decimal MSRPUsd { get; set; }
        public string? PictureFile { get; set; }
        public string? PictureCitation { get; set; }
        public string? TrimLevel { get; set; }
        public decimal WheelBase { get; set; }
        public decimal VehicleLength { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal VehicleWeight { get; set; }
        public int PassengerCap { get; set; }
        public decimal PassengerVolume { get; set; }
        public decimal CargoVolume { get; set; }
        public int TireWidth { get; set; }
        public int TireHeight { get; set; }
        public int RimSize { get; set; }
        public bool HeatedMirrors { get; set; }
        public bool SunRoof { get; set; }
        public int NumDoors { get; set; }
        public decimal ScreenSize { get; set; }
        public int NumSpeakers { get; set; }
        public int NumSubwoofers { get; set; }
        public bool WirelessCharging { get; set; }
        public bool AppleCarPlay { get; set; }
        public bool AndroidAuto { get; set; }
        public bool WifiCapable { get; set; }
        public bool HeatedSeats { get; set; }
        public bool VentilatedSeats { get; set; }
        public bool DriverSeatElectricAdjustment { get; set; }
        public bool PassengerSeatElectricAdjustment { get; set; }
        public bool RemoteStart { get; set; }
        public bool HeatedSteeringWheel { get; set; }
        public bool PaddleShifters { get; set; }
        public string? PowerTrainType { get; set; }
        public string? TransmissionType { get; set; }
        public int? NumGears { get; set; }
        public decimal FinalDriveRation { get; set; }
        public int FuelGrade { get; set; }
        public decimal MPGHighway { get; set; }
        public decimal MPGCity { get; set; }
        public decimal MPGCombined { get; set; }
        public decimal LitersPerKMHighway { get; set; }
        public decimal LitersPerKMCity { get; set; }
        public decimal LitersPerKMCombined { get; set; }
        public decimal TankCapacity { get; set; }
        public decimal BatteryCapacity { get; set; }
        public decimal VehicleRange { get; set; }
        public string? DriveType { get; set; }
        public decimal Horsepower { get; set; }
        public decimal Torque { get; set; }
        public decimal EngineSize { get; set; }
        public string? CylinderConfig { get; set; }
        public string? CompressorType { get; set; }
        public decimal AccelTime { get; set; }
        public decimal Topspeed { get; set; }
        public decimal TowingCapability { get; set; }
        public bool AutoStopStart { get; set; }
        public string? BatteryType { get; set; }
        public decimal MotorVoltage { get; set; }

    }
}
