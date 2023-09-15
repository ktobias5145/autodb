using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace InsertVehiclesIntoDatabase
{

    internal class Program
    {
        const string JsonFile = "2023-Auto-Data.json";
        static string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AutoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static void Main(string[] args)
        {
            //Create List Of Vehicle Objects
            List<Vehicle> list = new List<Vehicle>();
            string jsonString = File.ReadAllText(JsonFile);
            list = JsonConvert.DeserializeObject<List<Vehicle>>(jsonString);
            //Create Database Connection
            SqlConnection connection = new SqlConnection(ConnectionString);
        }
    }

    public class VehicleArray
    {
        [JsonProperty("")]
public Vehicle Vehicle { get; set; }
    }
    public class Vehicle
    {
        public string ModelName { get; set; }
        public string ManufacturerName { get; set; }
        public string BodyStyle { get; set; }
    }
}
