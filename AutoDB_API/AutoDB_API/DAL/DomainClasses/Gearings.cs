using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AutoDB_API.DAL.DomainClasses
{
    public class Gearings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GearingId { get; set; }

        [ForeignKey("ManufacturerId")]
        public int TransmissionTypeId { get; set; }
        public decimal FinalDriveRation { get; set; }
    }
}
