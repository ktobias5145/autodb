using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AutoDB_API.DAL.DomainClasses
{
    public class CylinderConfigs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CylinderConfigId { get; set; }
        [StringLength(50)]
        public string? CylinderConfig { get; set; }
    }
}
