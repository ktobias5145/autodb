using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoDB_API.DAL.DomainClasses
{
    public class Manufacturers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ManufacturerId { get; set; }
        [StringLength(50)]
        public string? ManufacturerName { get; set; }
    }
}
