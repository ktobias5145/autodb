using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AutoDB_API.DAL.DomainClasses
{
    public class Vehicles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VehicleId { get; set; }
        [ForeignKey("ModelId")]
       // public Model? Model { get; set; }   //FK For Model
        [Required]
        public int ModelId { get; set; }

        [ForeignKey("ManufacturerId")]
       // public Manufacturer? Manufacturer { get; set; }
        [Required]
        public int ManufacturerId { get; set; }

        [ForeignKey("BodyStyleId")]
        //public BodyStyle? BodyStyle { get; set; }
        [Required]
        public int BodyStyleId { get; set; }

    }
}
