using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AutoDB_API.DAL.DomainClasses
{
    public class TransmissionTypes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransmissionTypeId { get; set; }
        [StringLength(50)]
        public string? TransmissionType { get; set; }
        public int? NumGears { get; set; }
    }
}
