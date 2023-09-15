using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

/*
 * =======================================================================================================================
 * This Program Is Intended For Initial DataBase Construction.
 * User will combine the data of each model to its respective manufacturer and body style.
 * =======================================================================================================================
 *          It would have been faster to manually insert the data with sql than to create and run this program.
 * =======================================================================================================================                 
 *                                                    -Kevin Tobias-
 *                                                    (c) 2023-09-14
 * =======================================================================================================================
 */

namespace DataInsertionTool
{
    internal class Program
    {
       static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AutoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        const string DataFile = "2023-Auto-Data.json";
        static List<BodyStyle> BodyList;
        static List<Model> ModelList;
        static List<Manufacturer> ManufacturerList;
        static void Main(string[] args)
        {
            //Variables
            BodyList = new List<BodyStyle>();
            ModelList = new List<Model>();
            ManufacturerList = new List<Manufacturer>();
            List<Vehicle>   VehicleList = new List<Vehicle>();
            int modelMin,modelMax = 0,manuMin, manuMax = 0,bodyMin, bodyMax = 0,selection,i=0,n=0;
            string userChoice,userChoiceBody;
            bool rightManu = false,rightBody = false;
            Model model = new Model();
            Manufacturer manufacturer = new Manufacturer();
            BodyStyle body;
            //Vehicle vehicle;
            //Create Json Writer Object


            //Create Universal Connection
            SqlConnection cnn;    
            cnn = new SqlConnection(connectionString);

            //Populate Lists With Data
            BodyList = GetBodyStyle(cnn);
            ModelList = GetModel(cnn);
            ManufacturerList = GetManufacturers(cnn);

            //Create Starting Objects
            model = ModelList[0];
            manufacturer = ManufacturerList[0];
            body = BodyList[0];

            //Get min and max ids for model
            modelMin = model.id;
            foreach(Model model2 in ModelList)
            {
                if(modelMax <=model2.id)
                    modelMax = model2.id;
            }

            //Get min and max ids for manufacturer
            manuMin = manufacturer.id;
            foreach(Manufacturer manufacturer2 in ManufacturerList)
            {
                if(manuMax <= manufacturer2.id)
                    manuMax = manufacturer2.id;
            }
            //Get min and max ids for body style
            bodyMin = body.id;
            foreach(BodyStyle bod in BodyList)
            {
                if (bodyMax <= bod.id)
                    bodyMax = bod.id;
            }



            selection = modelMin;
           
            // selection = 1418;
            // n = 50;
            //Juicy Part Of Program Where You Actually Add Information To Out File
            while (selection <= modelMax)
            {

                model = ModelList[i];
                manufacturer = ManufacturerList[n];

                //Ensure Model Has Correct Manufacturer. Will Increment Next Manufacturer If Not Correct.
                do
                {
                    Console.Clear();
                    Console.Write($"Is {model.ModelName} | {manufacturer.ManufacturerName} | Correct? y\\n : ");
                    userChoice = Console.ReadLine();
                    switch (userChoice)
                    {
                        case "Y": case "y":
                            rightManu = true;
                            break;
                        case "N": case "n":

                            rightManu = false;
                            if (n < ManufacturerList.Count() - 1)
                            {
                                n++;
                            }
                            manufacturer = ManufacturerList[n];
                            Console.WriteLine($"| {model.ModelName} | Is Now {manufacturer.ManufacturerName}");
                            break;

                        default:
                            Console.Write($"Invalid Choice: {userChoice}. Please Enter y\\n: ");
                            rightManu = false;
                            break;
                    }

                } while (rightManu != true);
                //Body Style
                do
                {
                    Console.WriteLine($"What Body Style ID For {manufacturer.ManufacturerName} {model.ModelName}: ");
                    foreach (BodyStyle bodys in BodyList)
                    {
                        Console.WriteLine($"{bodys.id} | {bodys.BodyType}");
                    }
                    userChoiceBody = Console.ReadLine();
                    var isNumeric = int.TryParse(userChoiceBody, out int value);
                    if (!isNumeric)
                    {
                        Console.WriteLine("Not Int");
                    }
                    else
                    if (value > bodyMax || value < bodyMin)
                    {
                        Console.WriteLine("Invalid Selection");
                    }
                    else
                    {
                        var item = BodyList.FirstOrDefault(b => b.id == value);
                        body = new BodyStyle
                        {
                            id = value,
                            BodyType = item.BodyType
                        };
                        rightBody = true;
                    }

                } while (rightBody != true);

                //Add Vehicles To List
                Vehicle vehicle = new Vehicle {
                    ModelName = model.ModelName,
                    ManufacturerName = manufacturer.ManufacturerName,
                    BodyStyle = body.BodyType
            };
                //End Of Loop Iteration
                VehicleList.Add(vehicle);
                i++;
                selection++;
            }
            //Add Data To Json File And Close
            var json = JsonConvert.SerializeObject(VehicleList);
            File.WriteAllText(DataFile, json);
            cnn.Close();
        }
        static List<Model> GetModel( SqlConnection cnn)
        {
            List<Model> models = new List<Model>();
            //Create Connection
            string query = $"SELECT * FROM Model";
            cnn.Open();
            SqlCommand command = new SqlCommand(query, cnn);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Model model = new Model();
                model.id = reader.GetInt32(0);
                model.ModelName = reader.GetString(1);
                models.Add(model);
            }
            cnn.Close();
            return models;
        }
        static List<Manufacturer> GetManufacturers(SqlConnection cnn)
        {
            List<Manufacturer> manufacturers = new List<Manufacturer>();
            //Create Connection
            string query = $"SELECT * FROM Manufacturer";
            cnn.Open();
            SqlCommand command = new SqlCommand(query, cnn);
            SqlDataReader reader = command.ExecuteReader();
            //Populate List With Values

            while (reader.Read())
            {
                Manufacturer manufacturer = new Manufacturer();
                manufacturer.id = reader.GetInt32(0);
                manufacturer.ManufacturerName = reader.GetString(1);
                manufacturers.Add(manufacturer);
            }
            cnn.Close();
            return manufacturers;
        }

       static List<BodyStyle> GetBodyStyle(SqlConnection cnn)
        {
            List<BodyStyle> bodyStyleId = new List<BodyStyle>();

            //Create Connection
            string query = $"SELECT * FROM BodyStyle";
            cnn.Open();
            SqlCommand command = new SqlCommand(query, cnn);
            SqlDataReader reader = command.ExecuteReader();
            //Populate List With Values

            while (reader.Read())
            {
                BodyStyle bodyStyle = new BodyStyle();
                bodyStyle.id = reader.GetInt32(0);
                bodyStyle.BodyType = reader.GetString(1);
                bodyStyleId.Add(bodyStyle);
            }
            cnn.Close();
            return bodyStyleId;
        }
    }
    //Object Classes That Correspond With Their Related Sql Tables
    public class BodyStyle
    {
        public int id;
        public string BodyType;
    }
    public class Manufacturer
    {
        public int id;
        public string ManufacturerName;
    }
    public class Model
    {
        public int id;
        public string ModelName;
    }
    public class Vehicle
    {
        public string ModelName { get; set; }
        public string ManufacturerName { get; set; }
        public string BodyStyle { get; set; }
    }
}
