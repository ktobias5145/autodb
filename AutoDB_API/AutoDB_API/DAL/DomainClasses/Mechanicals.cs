using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AutoDB_API.DAL.DomainClasses
{
    public class Mechanicals
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MechanicalId { get; set; }
        public decimal Horsepower { get; set; }
        public decimal Torque { get; set; }
        public decimal EngineSize { get; set; }
        [ForeignKey("CylinderConfigId")]
        public int CylinderConfigId { get; set; }
        [ForeignKey("CompressorId")]
        public int CompressorId { get; set; }
        public decimal AccelTime { get; set; }
        public decimal Topspeed { get; set; }
        public decimal TowingCapability { get; set; }
        public bool AutoStopStart { get; set; }
        [StringLength(50)]
        public string? BatteryType { get; set; }
        public decimal MotorVoltage { get; set; }


    }
}
