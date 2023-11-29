using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AutoDB_API.DAL.DomainClasses
{
    public class ProductVarations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductVarationId { get; set; }
        [ForeignKey("VehicleId")]
        public int VehicleId { get; set; }
        public int ProductYear { get; set; }
        public decimal MSRPCad { get; set; }
        public decimal MSRPUsd { get; set; }
        [StringLength(1000)]
        public string? PictureFile { get; set; }
        [StringLength(1000)]
        public string? PictureCitation { get; set; }
        [ForeignKey("TrimLevelId")]
        public int TrimLevelId { get; set; }
        [ForeignKey("DimensionsId")]
        public int DimensionId { get; set; }
        [ForeignKey("ExteriorId")]
        public int ExteriorId { get; set; }
        [ForeignKey("InfotainmentId")]
        public int InfotainmentId { get; set; }
        [ForeignKey("InteriorId")]
        public int InteriorId { get; set; }
        [ForeignKey("PowerTrainId")]
        public int PowerTrainId { get; set; }
        [ForeignKey("GearingId")]
        public int GearingId { get; set; }
        [ForeignKey("EconomyId")]
        public int EconomyId { get; set; }
        [ForeignKey("DriveTypeId")]
        public int DriveTypeId { get; set; }
        [ForeignKey("MechanicalId")]
        public int MechanicalId { get; set; }

    }
}
