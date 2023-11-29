using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AutoDB_API.DAL.DomainClasses
{
    public class Exteriors
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExteriorId { get; set; }
        public int TireWidth { get; set; }
        public int TireHeight { get; set; }
        public int RimSize { get; set; }
        public bool HeatedMirrors { get; set; }
        public bool SunRoof { get; set; }
        public int NumDoors { get; set; }
    }
}
