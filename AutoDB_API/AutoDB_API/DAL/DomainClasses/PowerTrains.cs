using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AutoDB_API.DAL.DomainClasses
{
    public class PowerTrains
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PowerTrainId { get; set; }
        [StringLength(50)]
        public string? PowerTrainType { get; set; }
    }
}
