using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoDB_API.DAL.DomainClasses
{
    public class Models
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ModelId { get; set; }
        [StringLength(150)]
        public string? ModelName { get; set; }
    }
}
