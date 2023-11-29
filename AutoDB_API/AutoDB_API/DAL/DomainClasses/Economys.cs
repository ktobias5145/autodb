using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AutoDB_API.DAL.DomainClasses
{
    public class Economys
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EconomyId { get; set; }
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
    }
}
