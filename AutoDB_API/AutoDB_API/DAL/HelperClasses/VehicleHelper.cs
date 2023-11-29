using System.ComponentModel.DataAnnotations;

namespace AutoDB_API.DAL.HelperClasses
{
    public class VehicleHelper
    {
        public string? ManufacturerName { get; set; }
        public string? ModelName { get; set; }
        public string? BodyStyle { get; set; }
    }
    public class ParamaterList
    {

        public string? Property { get; set;}

        public string? Value { get; set;}
    }
}
