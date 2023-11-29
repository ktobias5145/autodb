using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AutoDB_API.DAL.DomainClasses
{
    public class Infotainments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InfotainmentId { get; set; }
        public decimal ScreenSize { get; set; }
        public int NumSpeakers { get; set; }
        public int NumSubwoofers { get; set; }
        public bool WirelessCharging { get; set; }
        public bool AppleCarPlay { get; set; }
        public bool AndroidAuto { get; set; }
        public bool WifiCapable { get; set; }

    }
}
