using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AutoDB_API.DAL.DomainClasses
{
    public class Interiors
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InteriorId { get; set; }
        public bool HeatedSeats { get; set; }
        public bool VentilatedSeats { get; set; }
        public bool DriverSeatElectricAdjustment { get; set; }
        public bool PassengerSeatElectricAdjustment { get; set; }
        public bool RemoteStart { get; set; }
        public bool HeatedSteeringWheel { get; set; }
        public bool PaddleShifters { get; set; }

    }
}
