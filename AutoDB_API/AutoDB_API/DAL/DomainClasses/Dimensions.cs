using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AutoDB_API.DAL.DomainClasses
{
    public class Dimensions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DimensionsID { get; set; }
        public decimal WheelBase { get; set; }
        public decimal VehicleLength { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal VehicleWeight { get; set; }
        public int PassengerCap { get; set; }
        public decimal PassengerVolume { get; set; }
        public decimal CargoVolume { get; set; }

    }
}
