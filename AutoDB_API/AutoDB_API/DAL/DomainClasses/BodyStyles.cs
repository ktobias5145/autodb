using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoDB_API.DAL.DomainClasses
{
    public class BodyStyles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BodyStyleId { get; set; }
        [StringLength(50)]
        public string? BodyStyle { get; set; }
    }
}
