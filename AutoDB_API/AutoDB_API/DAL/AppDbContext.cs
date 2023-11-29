using Microsoft.EntityFrameworkCore;
using AutoDB_API.DAL.DomainClasses;

namespace AutoDB_API.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public virtual DbSet<Vehicles>? Vehicle { get; set; }
        public virtual DbSet<Models>? Model { get; set; }
        public virtual DbSet<Manufacturers>? Manufacturer { get; set; }
        public virtual DbSet<BodyStyles>? BodyStyle { get; set; }
        public virtual DbSet<Notes>? Note { get; set; }
        public virtual DbSet<Interiors>? Interior { get; set; }
        public virtual DbSet<Infotainments>? Infotainment { get; set; }
        public virtual DbSet<Exteriors>? Exterior { get; set; }
        public virtual DbSet<Dimensions>? Dimensions { get; set; }
        public virtual DbSet<TrimLevels>? TrimLevel { get; set; }
        public virtual DbSet<DriveTypes>? DriveType { get; set; }
        public virtual DbSet<TransmissionTypes>? TransmissionType { get; set; }
        public virtual DbSet<Gearings>? Gearing { get; set; }
        public virtual DbSet<PowerTrains>? PowerTrain { get; set; }
        public virtual DbSet<CylinderConfigs>? CylinderConfig { get; set; }
        public virtual DbSet<Compressors>? Compressor { get; set; }
        public virtual DbSet<Economys>? Economy { get; set; }
        public virtual DbSet<Mechanicals>? Mechanical { get; set; }
        public virtual DbSet<ProductVarations>? ProductVaration { get; set; }

    }
}
