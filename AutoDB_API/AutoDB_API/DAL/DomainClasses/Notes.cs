using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AutoDB_API.DAL.DomainClasses
{
    public class Notes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NoteId { get; set; }
        [ForeignKey("VehicleId")]
        [Required]
        public int VehicleId { get; set; }
        [StringLength(2000)]
        public string? NoteContent { get; set; }
    }
}
