using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AutoDb_Data_Insertion_Tool.Window1;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoDb_Data_Insertion_Tool
{
    public partial class Window1 : Form
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AutoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public SqlConnection SqlConnection;
        public Window1(SqlConnection connection)
        {
            this.SqlConnection = connection;
            InitializeComponent();


        }
        public class Vehicle 
        {
            public string ManufacturerName { get; set; }
            public int ManufacturerId { get; set; }
            public string ModelName { get; set; }
            public int ModelId { get; set; }
            public string BodyStyle { get; set; }
            public int BodyStyleId { get; set; }
            public string TrimLevel { get; set; }
            public decimal WheelBase { get; set; }
            public decimal VehicleLength { get; set; }
            public decimal Height { get; set; }
            public decimal Width { get; set; }
            public decimal VehicleWeight { get; set; }
            public int PassengerCap { get; set; }
            public decimal PassengerVolume { get; set; }
            public decimal CargoVolume { get; set; }
            public int TireWidth { get; set; }
            public int TireHeight { get; set; }
            public int RimSize { get; set; }
            public int HeatedMirrors { get; set; }
            public int SunRoof { get; set; }
            public int NumDoors { get; set; }
            public decimal ScreenSize { get; set; }
            public int NumSpeakers { get; set; }
            public int NumSubwoofers { get; set; }
            public int WirelessCharging { get; set; }
            public int AppleCarPlay { get; set; }
            public int AndroidAuto { get; set; }
            public int WifiCapable { get; set; }
            public int HeatedSeats { get; set; }
            public int VentilatedSeats { get; set; }
            public int DriverSeatElectricAdjustment { get; set; }
            public int PassengerSeatElectricAdjustment { get; set; }
            public int RemoteStart { get; set; }
            public int HeatedSteeringWheel { get; set; }
            public int PaddleShifters { get; set; }
            public string PowerTrainType { get; set; }
            public string TransmissionType { get; set; }
            public int NumGears { get; set; }
            public int TransmissionTypeId { get; set; }
            public decimal FinalDriveRatio { get; set; }
            public int FuelGrade { get; set; }
            public decimal MPGHighway { get; set; }
            public decimal MPGCity { get; set; }
            public decimal MPGCombined { get; set; }
            public decimal LitersPerKMHighway { get; set; }
            public decimal LitersPerKMCity { get; set; }
            public decimal LitersPerKMCombined { get; set; }
            public decimal TankCapacity { get; set; }
            public decimal BatteryCapacity { get; set; }
            public decimal VehicleRange { get; set; }
            public string DriveType { get; set; }
            public decimal Horsepower { get; set; }
            public decimal Torque { get; set; }
            public decimal EngineSize { get; set; }
            public int CylinderConfigId { get; set; }
            public int CompressorId { get; set; }
            public decimal AccelTime { get; set; }
            public decimal Topspeed { get; set; }
            public decimal TowingCapability { get; set; }
            public int AutoStopStart { get; set; }
            public string BatteryType { get; set; }
            public decimal MotorVoltage { get; set; }
            public int VehicleId { get; set; }
            public int ProductYear { get; set; }
            public decimal MSRPCad { get; set; }
            public decimal MSRPUsd { get; set; }
            public int TrimLevelId { get; set; }
            public int DimensionId { get; set; }
            public int ExteriorId { get; set; }
            public int InfotainmentId { get; set; }
            public int InteriorId { get; set; }
            public int PowerTrainId { get; set; }
            public int GearingId { get; set; }
            public int EconomyId { get; set; }
            public int DriveTypeId { get; set; }
            public int MechanicalId { get; set; }
            public string PictureFile { get; set; }
            public string PictureCitation { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.labelGroup1 = new Label[33];
            this.labelGroup2 = new Label[33];
            int i1 = 60;
            for (int i = 0; i < 33; i++)
            {
                labelGroup1[i] = new Label();
                labelGroup1[i].Name = $"{i}";
                labelGroup1[i].AutoSize = true;
                labelGroup1[i].Location = new System.Drawing.Point(10, i1);
                labelGroup1[i].Size = new System.Drawing.Size(20, 20);
                i1 += 20;
            }
            i1 = 60;
            for (int i = 0; i < 33; i++)
            {
                labelGroup2[i] = new Label();
                labelGroup2[i].Name = $"{i}";
                labelGroup2[i].AutoSize = true;
                labelGroup2[i].Location = new System.Drawing.Point(550, i1);
                labelGroup2[i].Size = new System.Drawing.Size(20, 20);
                i1 += 20;
            }
            //Add Text To Labels
            labelGroup1[0].Text = "WheelBase";
            labelGroup1[0].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup1[1].Text = "Height";
            labelGroup1[1].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup1[2].Text = "VehicleWeight";
            labelGroup1[2].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup1[3].Text = "PassengerVolume";
            labelGroup1[3].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup1[4].Text = "TireWidth / Size";
            labelGroup1[4].BackColor = System.Drawing.Color.LightCoral;
            labelGroup1[5].Text = "HeatedMirrors";
            labelGroup1[5].BackColor = System.Drawing.Color.LightCoral;
            labelGroup1[6].Text = "NumDoors";
            labelGroup1[6].BackColor = System.Drawing.Color.LightCoral;
            labelGroup1[7].Text = "NumSpeakers / NumSuboowfers";
            labelGroup1[7].BackColor = System.Drawing.Color.LightGreen;
            labelGroup1[8].Text = "AppleCarPlay";
            labelGroup1[8].BackColor = System.Drawing.Color.LightGreen;
            labelGroup1[9].Text = "WifiCapable";
            labelGroup1[9].BackColor = System.Drawing.Color.LightGreen;
            labelGroup1[10].Text = "VentilatedSeats";
            labelGroup1[10].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup1[11].Text = "PassElectric";
            labelGroup1[11].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup1[12].Text = "HeatWheel";
            labelGroup1[12].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup1[13].Text = "PowerTrainType";
            labelGroup1[13].BackColor = System.Drawing.Color.LightCoral;
            labelGroup1[14].Text = "NumGears";
            labelGroup1[14].BackColor = System.Drawing.Color.LightGreen;
            labelGroup1[15].Text = "FinalDriveRation";
            labelGroup1[15].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup1[16].Text = "MPGHighway";
            labelGroup1[16].BackColor = System.Drawing.Color.LightCoral;
            labelGroup1[17].Text = "MPGCombined";
            labelGroup1[17].BackColor = System.Drawing.Color.LightCoral;
            labelGroup1[18].Text = "LitersPerKMCity";
            labelGroup1[18].BackColor = System.Drawing.Color.LightCoral;
            labelGroup1[19].Text = "TankCapacity";
            labelGroup1[19].BackColor = System.Drawing.Color.LightCoral;
            labelGroup1[20].Text = "VehicleRange";
            labelGroup1[20].BackColor = System.Drawing.Color.LightCoral;
            labelGroup1[21].Text = "Horsepower";
            labelGroup1[21].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup1[22].Text = "EngineSize";
            labelGroup1[22].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup1[23].Text = "CompressorId";
            labelGroup1[23].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup1[24].Text = "Topspeed";
            labelGroup1[24].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup1[25].Text = "AutoStopStart";
            labelGroup1[25].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup1[26].Text = "MotorVoltage";
            labelGroup1[26].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup1[27].Text = "MSRPCad";
            labelGroup1[27].BackColor = System.Drawing.Color.LightCoral;
            labelGroup1[28].Text = "TrimLevelId";
            labelGroup1[29].Text = "ExteriorId";
            labelGroup1[30].Text = "InteriorId";
            labelGroup1[31].Text = "GearingId";
            labelGroup1[32].Text = "DriveTypeId";


            labelGroup2[0].Text = "VehicleLength";
            labelGroup2[0].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup2[1].Text = "Width";
            labelGroup2[1].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup2[2].Text = "PassengerCap";
            labelGroup2[2].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup2[3].Text = "CargoVolume";
            labelGroup2[3].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup2[4].Text = "RimSize";
            labelGroup2[4].BackColor = System.Drawing.Color.LightCoral;
            labelGroup2[5].Text = "SunRoof";
            labelGroup2[5].BackColor = System.Drawing.Color.LightCoral;
            labelGroup2[6].Text = "ScreenSize";
            labelGroup2[6].BackColor = System.Drawing.Color.LightGreen;
            labelGroup2[7].Text = "WirelessCharging";
            labelGroup2[7].BackColor = System.Drawing.Color.LightGreen;
            labelGroup2[8].Text = "AndroidAuto";
            labelGroup2[8].BackColor = System.Drawing.Color.LightGreen;
            labelGroup2[9].Text = "HeatedSeats";
            labelGroup2[9].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup2[10].Text = "DriverSeatElectric";
            labelGroup2[10].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup2[11].Text = "RemoteStart";
            labelGroup2[11].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup2[12].Text = "PaddleShifters";
            labelGroup2[12].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup2[13].Text = "";
            labelGroup2[14].Text = "TransmissionType";
            labelGroup2[14].BackColor = System.Drawing.Color.LightGreen;
            labelGroup2[15].Text = "FuelGrade";
            labelGroup2[15].BackColor = System.Drawing.Color.LightCoral;
            labelGroup2[16].Text = "MPGCity";
            labelGroup2[16].BackColor = System.Drawing.Color.LightCoral;
            labelGroup2[17].Text = "LitersPerKMHighway";
            labelGroup2[17].BackColor = System.Drawing.Color.LightCoral;
            labelGroup2[18].Text = "LitersPerKMCombined";
            labelGroup2[18].BackColor = System.Drawing.Color.LightCoral;
            labelGroup2[19].Text = "BatteryCapacity";
            labelGroup2[19].BackColor = System.Drawing.Color.LightCoral;
            labelGroup2[20].Text = "DriveType";
            labelGroup2[20].BackColor = System.Drawing.Color.LightGreen;
            labelGroup2[21].Text = "Torque";
            labelGroup2[21].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup2[22].Text = "CylinderConfigId";
            labelGroup2[22].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup2[23].Text = "AccelTime";
            labelGroup2[23].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup2[24].Text = "TowingCapability";
            labelGroup2[24].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup2[25].Text = "BatteryType";
            labelGroup2[25].BackColor = System.Drawing.Color.PaleTurquoise;
            labelGroup2[26].Text = "VehicleId";
            labelGroup2[27].Text = "MSRPUsd";
            labelGroup2[27].BackColor = System.Drawing.Color.LightCoral;
            labelGroup2[28].Text = "DimensionId";
            labelGroup2[29].Text = "InfotainmentId";
            labelGroup2[30].Text = "PowerTrainId";
            labelGroup2[31].Text = "EconomyId";
            labelGroup2[32].Text = "MechanicalId";
            for (int i = 0; i < 33; i++)
            {
                this.Controls.Add(labelGroup1[i]);
            }
            for (int i = 0; i < 33; i++)
            {
                this.Controls.Add(labelGroup2[i]);
            }
            //Load Manufacturer
            this.SqlConnection.Open();
            string query = "SELECT * FROM Manufacturer";
            SqlCommand command = new SqlCommand(query,this.SqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            this.ManufacturerComboBox.Sorted = true;
            this.ManufacturerComboBox.Items.Add("-Create New Entry-");
            while (reader.Read()) 
            {
                this.ManufacturerComboBox.Items.Add(reader.GetString(1));
            }
            reader.Close();
            this.SqlConnection.Close();

            //Load Models
            this.SqlConnection.Open();
             query = "SELECT * FROM Model";
             command = new SqlCommand(query, this.SqlConnection);
             reader = command.ExecuteReader();
            this.ModelComboBox.Sorted = true;
            this.ModelComboBox.Items.Add("-Create New Entry-");
            while (reader.Read())
            {
                this.ModelComboBox.Items.Add(reader.GetString(1));
            }
            reader.Close();
            this.SqlConnection.Close();

            //Load BodyStyles
            this.SqlConnection.Open();
            query = "SELECT * FROM BodyStyle";
            command = new SqlCommand(query, this.SqlConnection);
            reader = command.ExecuteReader();
            this.BodyStyleComboBox.Sorted = true;
            this.BodyStyleComboBox.Items.Add("-Create New Entry-");
            while (reader.Read())
            {
                this.BodyStyleComboBox.Items.Add(reader.GetString(1));
            }
            reader.Close();
            this.SqlConnection.Close();

            //Load TrimLevel
            this.SqlConnection.Open();
            query = "SELECT * FROM TrimLevel";
            command = new SqlCommand(query, this.SqlConnection);
            reader = command.ExecuteReader();
            this.TrimLevelComboBox.Sorted = true;
            this.TrimLevelComboBox.Items.Add("-Create New Entry-");
            while (reader.Read())
            {
                this.TrimLevelComboBox.Items.Add(reader.GetString(1));
            }
            reader.Close();
            this.SqlConnection.Close();
            //Load PowerTrain
            this.SqlConnection.Open();
            query = "SELECT * FROM PowerTrain";
            command = new SqlCommand(query, this.SqlConnection);
            reader = command.ExecuteReader();
            this.PowerTrainComboBox.Sorted = true;
            this.PowerTrainComboBox.Items.Add("-Create New Entry-");
            while (reader.Read())
            {
                this.PowerTrainComboBox.Items.Add(reader.GetString(1));
            }
            reader.Close();
            this.SqlConnection.Close();
            //Load Transmission Type
            this.SqlConnection.Open();
            query = "SELECT DISTINCT TransmissionType FROM TransmissionType";
            command = new SqlCommand(query, this.SqlConnection);
            reader = command.ExecuteReader();
            this.TransmissionComboBox.Sorted = true;
            this.TransmissionComboBox.Items.Add("-Create New Entry-");
            while (reader.Read())
            {
                this.TransmissionComboBox.Items.Add(reader.GetString(0));
            }
            reader.Close();
            this.SqlConnection.Close();
            //Load Compressor
            this.SqlConnection.Open();
            query = "SELECT * FROM Compressor";
            command = new SqlCommand(query, this.SqlConnection);
            reader = command.ExecuteReader();
            this.CompressorTypeBox.Sorted = true;
            while (reader.Read())
            {
                this.CompressorTypeBox.Items.Add(reader.GetString(1));
            }
            reader.Close();
            this.SqlConnection.Close();
            //Load Cylinder Config
            this.SqlConnection.Open();
            query = "SELECT * FROM CylinderConfig";
            command = new SqlCommand(query, this.SqlConnection);
            reader = command.ExecuteReader();
            this.CylinderConfigBox.Sorted = true;
            while (reader.Read())
            {
                this.CylinderConfigBox.Items.Add(reader.GetString(1));
            }
            reader.Close();
            this.SqlConnection.Close();
            //Load Drive Type
            this.SqlConnection.Open();
            query = "SELECT * FROM DriveType";
            command = new SqlCommand(query, this.SqlConnection);
            reader = command.ExecuteReader();
            this.DriveTrainComboBox.Sorted = true;
            this.DriveTrainComboBox.Items.Add("-Create New Entry-");
            while (reader.Read())
            {
                this.DriveTrainComboBox.Items.Add(reader.GetString(1));
            }
            reader.Close();
            this.SqlConnection.Close();
            //Load Bool ComboBoxes
            this.HeatWheelTextBox.Items.Add("0");
            this.HeatWheelTextBox.Items.Add("1");
            this.HeatWheelTextBox.Items.Add("n/a");

            this.SunRoofTextBox.Items.Add("0");
            this.SunRoofTextBox.Items.Add("1");
            this.SunRoofTextBox.Items.Add("n/a");

            this.WirelessChargingTextBox.Items.Add("0");
            this.WirelessChargingTextBox.Items.Add("1");
            this.WirelessChargingTextBox.Items.Add("n/a");

            this.AppleCarPlayTextBox.Items.Add("0");
            this.AppleCarPlayTextBox.Items.Add("1");
            this.AppleCarPlayTextBox.Items.Add("n/a");

            this.AndroidAutoTextBox.Items.Add("0");
            this.AndroidAutoTextBox.Items.Add("1");
            this.AndroidAutoTextBox.Items.Add("n/a");

            this.WifiCapableTextBox.Items.Add("0");
            this.WifiCapableTextBox.Items.Add("1");
            this.WifiCapableTextBox.Items.Add("n/a");

            this.HeatedSeatsTextBox.Items.Add("0");
            this.HeatedSeatsTextBox.Items.Add("1");
            this.HeatedSeatsTextBox.Items.Add("n/a");

            this.VentilatedSeatsTextBox.Items.Add("0");
            this.VentilatedSeatsTextBox.Items.Add("1");
            this.VentilatedSeatsTextBox.Items.Add("n/a");

            this.DriverSeatElectricTextBox.Items.Add("0");
            this.DriverSeatElectricTextBox.Items.Add("1");
            this.DriverSeatElectricTextBox.Items.Add("n/a");

            this.PassElectricTextBox.Items.Add("0");
            this.PassElectricTextBox.Items.Add("1");
            this.PassElectricTextBox.Items.Add("n/a");

            this.RemoteStartTextBox.Items.Add("0");
            this.RemoteStartTextBox.Items.Add("1");
            this.RemoteStartTextBox.Items.Add("n/a");

            this.HeatedMirrorsTextBox.Items.Add("0");
            this.HeatedMirrorsTextBox.Items.Add("1");
            this.HeatedMirrorsTextBox.Items.Add("n/a");

            this.PaddleShiftersTextBox.Items.Add("0");
            this.PaddleShiftersTextBox.Items.Add("1");
            this.PaddleShiftersTextBox.Items.Add("n/a");

            this.AutoStopStartTextBox.Items.Add("0");
            this.AutoStopStartTextBox.Items.Add("1");
            this.AutoStopStartTextBox.Items.Add("n/a");


        }
        //Combo Box Listeners

        private void EnterButton_Click(object sender, EventArgs e)
        {
            GatherInformation();
        }
        private void GatherInformation()
        {

            //Create Sql Instance
            SqlConnection = new SqlConnection(connectionString);
            string query;
            SqlCommand cmd;
            //Create New Vehicle Object And Assigns Values To It
            Vehicle vehicle = new Vehicle();

            //Start with creating base 'vehicle' for database

            //Assign Manufacturer data to Vehicle Object
            if (this.ManufacturerComboBox.SelectedIndex > 0)
            {
                SqlConnection.Open();
                query = $"SELECT  dbo.ReturnManufacturerId ('{this.ManufacturerComboBox.GetItemText(this.ManufacturerComboBox.SelectedItem)}')";
                using (cmd = new SqlCommand(query, SqlConnection))
                {

                         int? returnId = cmd.ExecuteScalar() as int?;
                         vehicle.ManufacturerId = returnId??-1;
                         vehicle.ManufacturerName = this.ManufacturerComboBox.GetItemText(this.ManufacturerComboBox.SelectedItem);
                }
            }
            else
            {
                SqlConnection.Open();
                query = $"EXECUTE dbo.InsertManufacturer @manu = '{this.ManufacturerTextBox.Text}'";
                using (cmd = new SqlCommand(query, SqlConnection))
                {
                    cmd.ExecuteNonQuery();
                }
                query = $"SELECT  dbo.ReturnManufacturerId ('{this.ManufacturerTextBox.Text}')";
                using (cmd = new SqlCommand(query, SqlConnection))
                {
                    int? returnId = cmd.ExecuteScalar() as int?;
                    vehicle.ManufacturerId = returnId ?? -1;
                    vehicle.ManufacturerName = this.ManufacturerTextBox.Text;
                }
            }
            SqlConnection.Close();
            //Assign Model To Vehicle Object
            if (this.ModelComboBox.SelectedIndex > 0)
            {
                SqlConnection.Open();
                query = $"SELECT  dbo.ReturnModelId ('{this.ModelComboBox.GetItemText(this.ModelComboBox.SelectedItem)}')";
                using (cmd = new SqlCommand(query, SqlConnection))
                {

                    int? returnId = cmd.ExecuteScalar() as int?;
                    vehicle.ModelId = returnId ?? -1;
                    vehicle.ModelName = this.ModelComboBox.GetItemText(this.ModelComboBox.SelectedItem);
                }
            }
            else
            {
                SqlConnection.Open();
                query = $"EXECUTE dbo.InsertModel @model = '{this.ModelTextBox.Text}'";
                using (cmd = new SqlCommand(query, SqlConnection))
                {
                    cmd.ExecuteNonQuery();
                }
                query = $"SELECT  dbo.ReturnModelId ('{this.ModelTextBox.Text}')";
                using (cmd = new SqlCommand(query, SqlConnection))
                {
                    int? returnId = cmd.ExecuteScalar() as int?;
                    vehicle.ModelId = returnId ?? -1;
                    vehicle.ModelName = this.ModelTextBox.Text;
                }
            }
            SqlConnection.Close();
            //Assign BodyStyle To Vehicle Object
            if (this.BodyStyleComboBox.SelectedIndex > 0)
            {
                SqlConnection.Open();
                query = $"SELECT  dbo.ReturnBodyStyleId ('{this.BodyStyleComboBox.GetItemText(this.BodyStyleComboBox.SelectedItem)}')";
                using (cmd = new SqlCommand(query, SqlConnection))
                {

                    int? returnId = cmd.ExecuteScalar() as int?;
                    vehicle.BodyStyleId = returnId ?? -1;
                    vehicle.BodyStyle = this.BodyStyleComboBox.GetItemText(this.BodyStyleComboBox.SelectedItem);
                }
            }
            else
            {
                SqlConnection.Open();
                query = $"EXECUTE dbo.InsertBodyStyle @body = '{this.BodyStyleTextBox.Text}'";
                using (cmd = new SqlCommand(query, SqlConnection))
                {
                    cmd.ExecuteNonQuery();
                }
                query = $"SELECT  dbo.ReturnBodyStyleId ('{this.BodyStyleTextBox.Text}')";
                using (cmd = new SqlCommand(query, SqlConnection))
                {
                    int? returnId = cmd.ExecuteScalar() as int?;
                    vehicle.BodyStyleId = returnId ?? -1;
                    vehicle.BodyStyle = this.BodyStyleTextBox.Text;
                }
            }
            SqlConnection.Close();
            //Enter/Check Vehicle Object into database
            SqlConnection.Open();
            vehicle.PictureFile = this.PictureFileTextBox.Text;
            vehicle.PictureCitation = this.PictureCitationTextBox.Text;
            query = $"EXECUTE dbo.InsertVehicle @modelId = {vehicle.ModelId}, @manuId = {vehicle.ManufacturerId}, @bodyStyleId = {vehicle.BodyStyleId}";
            using (cmd = new SqlCommand(query, SqlConnection))
            {
                cmd.ExecuteNonQuery();
            }
            query = $"SELECT dbo.ReturnVehicleId ({vehicle.ModelId},{vehicle.ManufacturerId},{vehicle.BodyStyleId})";
            using (cmd = new SqlCommand(query, SqlConnection))
            {
                int? returnId = cmd.ExecuteScalar() as int?;
                vehicle.VehicleId = returnId ?? -1;
            }
            this.VehicleIdTextBox.Text = vehicle.VehicleId.ToString();
            SqlConnection.Close();

            
            //Create Data For Product Varation
             GatherTrimLevel(SqlConnection, vehicle);
             GatherDimensions(SqlConnection, vehicle);
             GatherExterior(SqlConnection, vehicle);
             GatherInfotainment(SqlConnection, vehicle);
            GatherInterior(SqlConnection, vehicle);
             GatherPowerTrain(SqlConnection, vehicle);
             GatherTransmissionType(SqlConnection, vehicle);
             GatherGearing(SqlConnection, vehicle);
             GatherEconomy(SqlConnection, vehicle);
            GatherDriveType(SqlConnection, vehicle);
            GatherMechanical(SqlConnection, vehicle);
                        
            AssembleVehicleVariation(SqlConnection, vehicle);

            CreateOutFile(vehicle);

        }

        private void GatherTrimLevel(SqlConnection SQLConnection, Vehicle vehicle)
        {
            
            string query;
            SqlCommand cmd;
            if (this.TrimLevelComboBox.SelectedIndex > 0)
            {
                SQLConnection.Open();
                query = $"SELECT  dbo.ReturnTrimLevelId ('{this.TrimLevelComboBox.GetItemText(this.TrimLevelComboBox.SelectedItem)}')";
                using (cmd = new SqlCommand(query, SQLConnection))
                {

                    int? returnId = cmd.ExecuteScalar() as int?;
                    vehicle.TrimLevelId = returnId ?? -1;
                    vehicle.TrimLevel = this.TrimLevelComboBox.GetItemText(this.TrimLevelComboBox.SelectedItem);
                }
            }
            else
            {
                SQLConnection.Open();
                query = $"EXECUTE dbo.InsertTrimLevel @trim = '{this.TrimLevelTextBox.Text}'";
                using (cmd = new SqlCommand(query, SQLConnection))
                {
                    cmd.ExecuteNonQuery();
                }
                query = $"SELECT  dbo.ReturnTrimLevelId ('{this.TrimLevelTextBox.Text}')";
                using (cmd = new SqlCommand(query, SQLConnection))
                {
                    int? returnId = cmd.ExecuteScalar() as int?;
                    vehicle.TrimLevelId = returnId ?? -1;
                    vehicle.TrimLevel = this.TrimLevelTextBox.Text;
                }
            }
            this.TrimLevelIdTextBox.Text = vehicle.TrimLevelId.ToString();
            SQLConnection.Close();
        }
        private void GatherDimensions(SqlConnection SQLconnection, Vehicle vehicle)
        {

            string query;
            SqlCommand SQLcommand;
            SQLconnection.Open();
            decimal d;
            int i;
            if( Decimal.TryParse(this.WheelBaseTextBox.Text, out d ))
            vehicle.WheelBase = d;
            else
            {
                throw new Exception("Invalid Wheel Base Value. Must Be Decimal Value");
            }
            if (Decimal.TryParse(this.VehicleLengthTextBox.Text, out d))
            vehicle.VehicleLength = d;
            else
            {
                throw new Exception("Invalid Vehicle Length Value. Must Be Decimal Value");
            }
            if (Decimal.TryParse(this.WidthTextBox.Text, out d))
                vehicle.Width = d;
            else
            {
                throw new Exception("Invalid Vehicle Width Value. Must Be Decimal Value");
            }
            if (Decimal.TryParse(this.HeightTextBox.Text, out d))
                vehicle.Height = d;
            else
            {
                throw new Exception("Invalid Vehicle Height Value. Must Be Decimal Value");
            }
            if (Decimal.TryParse(this.VehicleWeightTextBox.Text, out d))
                vehicle.VehicleWeight = d;
            else
            {
                throw new Exception("Invalid Vehicle Weight Value. Must Be Decimal Value");
            }
            if (Int32.TryParse(this.PassengerCapTextBox.Text, out i))
                vehicle.PassengerCap = i;
            else  
            {
                throw new Exception("Invalid Passenger Cap Value. Must Be Integer Value");
            }
            if (Decimal.TryParse(this.PassengerVolumeTextBox.Text, out d))
                vehicle.PassengerVolume = d;
            else
            {
                throw new Exception("Invalid Passenger Volume Value. Must Be Decimal Value");
            }
            if (Decimal.TryParse(this.CargoVolumeTextBox.Text, out d))
                vehicle.CargoVolume = d;
            else
            {
                throw new Exception("Invalid Cargo Volume Value. Must Be Decimal Value");
            }

            //Insert Data To Database
            query = $"EXECUTE dbo.InsertDimensions @wheelbase = {vehicle.WheelBase},@length = {vehicle.VehicleLength}," +
                $" @width = {vehicle.Width}, @height = {vehicle.Height}, @weight = {vehicle.VehicleWeight}," +
                $" @passengers = {vehicle.PassengerCap}, @passVolume = {vehicle.PassengerVolume}, @cargoVolume = {vehicle.CargoVolume}";
            using (SQLcommand = new SqlCommand(query, SQLconnection))
            {
                SQLcommand.ExecuteNonQuery();
            }
            //Retrieve Id Value from Dimension Table
            query = $"SELECT dbo.ReturnDimensionsId ({vehicle.WheelBase}, {vehicle.VehicleLength}," +
                $"{vehicle.Width}, {vehicle.Height},{vehicle.VehicleWeight}, {vehicle.PassengerCap}, {vehicle.PassengerVolume}," +
                $"{vehicle.CargoVolume})";

            using (SQLcommand = new SqlCommand(query, SQLconnection))
            {
                int? returnId = SQLcommand.ExecuteScalar() as int?;
                vehicle.DimensionId = returnId ?? -1;
            }

            SQLconnection.Close();
        }
        private void GatherExterior(SqlConnection SQLconnection, Vehicle vehicle)
        {
            string query;
            SqlCommand SQLcommand;
            SQLconnection.Open();
            int i;
            if (Int32.TryParse(this.TireHeightTextBox.Text, out i))
                vehicle.TireHeight = i;
            else
            {
                throw new Exception("Invalid Tire Height Value. Must Be Integer Value");
            }
            if (Int32.TryParse(this.TireWidthTextBox.Text, out i))
                vehicle.TireWidth = i;
            else
            {
                throw new Exception("Invalid Tire Width Value. Must Be Integer Value");
            }
            if (Int32.TryParse(this.RimSizeTextBox.Text, out i))
                vehicle.RimSize = i;
            else
            {
                throw new Exception("Invalid Rim Size Value. Must Be Integer Value");
            }
            vehicle.HeatedMirrors = this.HeatedMirrorsTextBox.SelectedIndex;
            vehicle.SunRoof = this.SunRoofTextBox.SelectedIndex;
            if (Int32.TryParse(this.NumDoorsTextBox.Text, out i))
                vehicle.NumDoors = i;
            else
            {
                throw new Exception("Invalid Number Of Doors Value. Must Be Integer Value");
            }

            //Insert Data To Database
            query = $"EXECUTE dbo.InsertExterior @tireHeight = '{vehicle.TireHeight}', @tireWidth = '{vehicle.TireWidth}'," +
                $" @rimSize = '{vehicle.RimSize}', @mirrorHeat = '{vehicle.HeatedMirrors}'," +
                $" @sunRoof = '{vehicle.SunRoof}', @numDoors = '{vehicle.NumDoors}'";
            using (SQLcommand = new SqlCommand(query, SQLconnection))
            {
                SQLcommand.ExecuteNonQuery();
            }
            //Retrieve Id Value from Dimension Table
            query = $"SELECT dbo.ReturnExteriorId ({vehicle.TireHeight}, {vehicle.TireWidth}," +
                $"{vehicle.RimSize}, {vehicle.HeatedMirrors},{vehicle.SunRoof}, {vehicle.NumDoors})";

            using (SQLcommand = new SqlCommand(query, SQLconnection))
            {
                int? returnId = SQLcommand.ExecuteScalar() as int?;
                vehicle.ExteriorId = returnId ?? -1;
            }

            SQLconnection.Close();
        }
        private void GatherInfotainment(SqlConnection SQLconnection, Vehicle vehicle)
        {
            string query;
            SqlCommand SQLcommand;
            SQLconnection.Open();
            decimal d;
            int i;
            if (Decimal.TryParse(this.ScreenSizeTextBox.Text, out d))
                vehicle.ScreenSize = d;
            else
            {
                throw new Exception("Invalid Screen Size Value. Must Be Decimal Value");
            }
            if (Int32.TryParse(this.NumSpeakersTextBox.Text, out i))
                vehicle.NumSpeakers = i;
            else
            {
                throw new Exception("Invalid Number Of Speakers Value. Must Be Integer Value");
            }
            if (Int32.TryParse(this.SubWooferTextBox.Text, out i))
                vehicle.NumSubwoofers = i;
            else
            {
                throw new Exception("Invalid Number Of Subwoofers Value. Must Be Integer Value");
            }
            if (Int32.TryParse(this.WirelessChargingTextBox.Text, out i))
                vehicle.WirelessCharging = i;
            else
            {
                throw new Exception("Invalid Wireless Charging Value. Must Be Integer Value");
            }
            if (Int32.TryParse(this.AppleCarPlayTextBox.Text, out i))
                vehicle.AppleCarPlay = i;
            else
            {
                throw new Exception("Invalid AppleCarPlay Value. Must Be Integer Value");
            }
            if (Int32.TryParse(this.AndroidAutoTextBox.Text, out i))
                vehicle.AndroidAuto = i;
            else
            {
                throw new Exception("Invalid AndroidAuto Value. Must Be Integer Value");
            }
            if (Int32.TryParse(this.WifiCapableTextBox.Text, out i))
                vehicle.WifiCapable = i;
            else
            {
                throw new Exception("Invalid Wifi Capable Value. Must Be Integer Value");
            }
            //Insert Data To Database
            query = $"EXECUTE dbo.InsertInfotainment @screenSize = {vehicle.ScreenSize}, @speakers = {vehicle.NumSpeakers}," +
                $" @subwoofers = {vehicle.NumSubwoofers}, @wirelessCharging = {vehicle.WirelessCharging}," +
                $" @appleCarPlay = {vehicle.AppleCarPlay}, @androidAuto = {vehicle.AndroidAuto}, @wifi = {vehicle.WifiCapable}";
            using (SQLcommand = new SqlCommand(query, SQLconnection))
            {
                SQLcommand.ExecuteNonQuery();
            }
            //Retrieve Id Value from Dimension Table
            query = $"SELECT dbo.ReturnInfotainmentId ({vehicle.ScreenSize}, {vehicle.NumSpeakers}, " +
                $"{vehicle.NumSubwoofers}, {vehicle.WirelessCharging},{vehicle.AppleCarPlay}, {vehicle.AndroidAuto}, {vehicle.WifiCapable})";

            using (SQLcommand = new SqlCommand(query, SQLconnection))
            {
                int? returnId = SQLcommand.ExecuteScalar() as int?;
                vehicle.InfotainmentId = returnId ?? -1;
            }
            SQLconnection.Close();
        }
        private void GatherInterior(SqlConnection SQLconnection, Vehicle vehicle)
        {
            string query;
            SqlCommand SQLcommand;
            SQLconnection.Open();
            int i;
            if (Int32.TryParse(this.HeatedSeatsTextBox.Text, out i))
                vehicle.HeatedSeats = i;
            else
            {
                throw new Exception("Invalid Heated Seat Value. Must Be Integer Value");
            }
            if (Int32.TryParse(this.VentilatedSeatsTextBox.Text, out i))
                vehicle.VentilatedSeats = i;
            else
            {
                throw new Exception("Invalid Ventilated Seat Value. Must Be Integer Value");
            }
            if (Int32.TryParse(this.DriverSeatElectricTextBox.Text, out i))
                vehicle.DriverSeatElectricAdjustment = i;
            else
            {
                throw new Exception("Invalid Electric Driver Seat Value. Must Be Integer Value");
            }
            if (Int32.TryParse(this.PassElectricTextBox.Text, out i))
                vehicle.PassengerSeatElectricAdjustment = i;
            else
            {
                throw new Exception("Invalid Electric Passenger Seat Value. Must Be Integer Value");
            }
            if (Int32.TryParse(this.RemoteStartTextBox.Text, out i))
                vehicle.RemoteStart = i;
            else
            {
                throw new Exception("Invalid Remote Start Value. Must Be Integer Value");
            }
            if (Int32.TryParse(this.HeatWheelTextBox.Text, out i))
                vehicle.HeatedSteeringWheel = i;
            else
            {
                throw new Exception("Invalid Heated Steering Wheel Value. Must Be Integer Value");
            }
            if (Int32.TryParse(this.PaddleShiftersTextBox.Text, out i))
                vehicle.PaddleShifters = i;
            else
            {
                throw new Exception("Invalid PaddleShifters Value. Must Be Integer Value");
            }

            //Insert Data To Database
            query = $"EXECUTE dbo.InsertInterior @heatedSeats = {vehicle.HeatedSeats}, @ventedSeats = '{vehicle.VentilatedSeats}', " +
                $"@powerDriverSeats = {vehicle.DriverSeatElectricAdjustment}, @powerPassengerSeats = {vehicle.PassengerSeatElectricAdjustment}," +
                $" @remoteStart = {vehicle.RemoteStart}, @heatedSteering = {vehicle.HeatedSteeringWheel}, @paddleShifters = {vehicle.PaddleShifters}";
            using (SQLcommand = new SqlCommand(query, SQLconnection))
            {
                SQLcommand.ExecuteNonQuery();
            }
            //Retrieve Id Value from Dimension Table
            query = $"SELECT dbo.ReturnInteriorId ({vehicle.HeatedSeats}, {vehicle.VentilatedSeats}," +
                $"{vehicle.DriverSeatElectricAdjustment}, {vehicle.PassengerSeatElectricAdjustment},{vehicle.RemoteStart}, {vehicle.HeatedSteeringWheel}," +
                $"{vehicle.PaddleShifters})";

            using (SQLcommand = new SqlCommand(query, SQLconnection))
            {
                int? returnId = SQLcommand.ExecuteScalar() as int?;
                vehicle.InteriorId = returnId ?? -1;
            }

            SQLconnection.Close();
        }
        private void GatherPowerTrain(SqlConnection SQLconnection, Vehicle vehicle)
        {
            string query;
            SqlCommand cmd;
            if (this.PowerTrainComboBox.SelectedIndex > 0)
            {
                SQLconnection.Open();
                query = $"SELECT  dbo.ReturnPowerTrainId ('{this.PowerTrainComboBox.GetItemText(this.PowerTrainComboBox.SelectedItem)}')";
                using (cmd = new SqlCommand(query, SQLconnection))
                {

                    int? returnId = cmd.ExecuteScalar() as int?;
                    vehicle.PowerTrainId = returnId ?? -1;
                    vehicle.PowerTrainType = this.PowerTrainComboBox.GetItemText(this.PowerTrainComboBox.SelectedItem);
                    this.PowerTrainIdTextBox.Text = vehicle.PowerTrainId.ToString();
                }
            }
            else
            {
                SQLconnection.Open();
                query = $"EXECUTE dbo.InsertPowerTrain @powertrainType = '{this.PowerTrainTypeTextBox.Text}'";
                using (cmd = new SqlCommand(query, SQLconnection))
                {
                    cmd.ExecuteNonQuery();
                }
                query = $"SELECT  dbo.ReturnPowerTrainId ('{this.PowerTrainTypeTextBox.Text}')";
                using (cmd = new SqlCommand(query, SQLconnection))
                {
                    int? returnId = cmd.ExecuteScalar() as int?;
                    vehicle.PowerTrainId = returnId ?? -1;
                    vehicle.PowerTrainType = this.PowerTrainTypeTextBox.Text;
                    this.PowerTrainIdTextBox.Text = vehicle.PowerTrainId.ToString();
                }
            }
            SQLconnection.Close();
        }
        private void GatherTransmissionType(SqlConnection SQLconnection, Vehicle vehicle)
        {
            string query;
            SqlCommand cmd;
            int i;
            if (Int32.TryParse(this.NumGearsTextBox.Text, out i))
                vehicle.NumGears = i;
            else
            {
                throw new Exception("Invalid Number Of Gears Value. Must Be Integer Value");
            }
            if (this.TransmissionComboBox.SelectedIndex > 0)
            {
                SQLconnection.Open();
                query = $"EXECUTE dbo.InsertTransmission @transtype = '{this.TransmissionComboBox.GetItemText(this.TransmissionComboBox.SelectedItem)}', @gears = {vehicle.NumGears}";
                using (cmd = new SqlCommand(query, SQLconnection))
                {
                    cmd.ExecuteNonQuery();
                    vehicle.TransmissionType = this.TransmissionComboBox.GetItemText(this.TransmissionComboBox.SelectedItem);
                }
                query = $"SELECT dbo.ReturnTransmissionId ('{vehicle.TransmissionType}', {vehicle.NumGears})";
                using (cmd = new SqlCommand(query, SQLconnection))
                {

                    int? returnId = cmd.ExecuteScalar() as int?;
                    vehicle.TransmissionTypeId = returnId ?? -1;

                }
            }
            else
            {
                SQLconnection.Open();
                query = $"EXECUTE dbo.InsertTransmission @transtype = '{this.TransmissionTypeIdTextBox.Text}', @gears = {vehicle.NumGears}";
                using (cmd = new SqlCommand(query, SQLconnection))
                {
                    cmd.ExecuteNonQuery();
                }
                query = $"SELECT  dbo.ReturnTransmissionId ('{this.TransmissionTypeIdTextBox.Text}', {vehicle.NumGears})";
                using (cmd = new SqlCommand(query, SQLconnection))
                {
                    int? returnId = cmd.ExecuteScalar() as int?;
                    vehicle.TransmissionTypeId = returnId ?? -1;
                    vehicle.TransmissionType = this.TransmissionTypeIdTextBox.Text;
                }
            }
            this.MessageLabel.Text = vehicle.TransmissionTypeId.ToString(); 
            SQLconnection.Close();
        }
        private void GatherGearing(SqlConnection SQLconnection, Vehicle vehicle)
        {
            string query;
            SqlCommand cmd;
            decimal d;
            if (Decimal.TryParse(this.FinalDriveRationTextBox.Text, out d))
                vehicle.FinalDriveRatio = d;
            else
            {
                throw new Exception("Invalid FinalDrive Value. Must Be Decimal Value");
            }
            SQLconnection.Open();
            query = $"EXECUTE dbo.InsertGearing @transTypeId = {vehicle.TransmissionTypeId}, @finalDrive = {vehicle.FinalDriveRatio}";
            using (cmd = new SqlCommand(query, SQLconnection))
            {
                cmd.ExecuteNonQuery();
            }
            query = $"SELECT  dbo.ReturnGearingId ('{vehicle.TransmissionTypeId}', {vehicle.FinalDriveRatio})";
            using (cmd = new SqlCommand(query, SQLconnection))
            {
                int? returnId = cmd.ExecuteScalar() as int?;
                vehicle.GearingId = returnId ?? -1;
            }
            this.GearingIdTextBox.Text = vehicle.GearingId.ToString();
            SQLconnection.Close();
        }
        private void GatherEconomy(SqlConnection SQLconnection, Vehicle vehicle)
        {
            string query;
            SqlCommand SQLcommand;
            SQLconnection.Open();
            int i;
            decimal d;
            if (Int32.TryParse(this.FuelGradeTextBox.Text, out i))
                vehicle.FuelGrade = i;
            else
            {
                throw new Exception("Invalid Fuel Grade Value. Must Be Integer Value");
            }
            if (Decimal.TryParse(this.MPGHighwayTextBox.Text, out d))
                vehicle.MPGHighway = d;
            else
            {
                throw new Exception("Invalid MPG Highway Value. Must Be Decimal Value");
            }
            if (Decimal.TryParse(this.MPGCityTextBox.Text, out d))
                vehicle.MPGCity = d;
            else
            {
                throw new Exception("Invalid MPG City Value. Must Be Decimal Value");
            }
            if (Decimal.TryParse(this.MPGCombinedTextBox.Text, out d))
                vehicle.MPGCombined = d;
            else
            {
                throw new Exception("Invalid MPG Combined Value. Must Be Decimal Value");
            }
            if (Decimal.TryParse(this.LitersPerKMHighwayTextBox.Text, out d))
                vehicle.LitersPerKMHighway = d;
            else
            {
                throw new Exception("Invalid Liters Highway Value. Must Be Decimal Value");
            }
            if (Decimal.TryParse(this.LitersPerKMCityTextBox.Text, out d))
                vehicle.LitersPerKMCity = d;
            else
            {
                throw new Exception("Invalid MPG City Value. Must Be Decimal Value");
            }
            if (Decimal.TryParse(this.LitersPerKMCombinedTextBox.Text, out d))
                vehicle.LitersPerKMCombined = d;
            else
            {
                throw new Exception("Invalid MPG Combined Value. Must Be Decimal Value");
            }
            if (Decimal.TryParse(this.TankCapacityTextBox.Text, out d))
                vehicle.TankCapacity = d;
            else
            {
                throw new Exception("Invalid Fuel Tank Value. Must Be Decimal Value");
            }
            if (Decimal.TryParse(this.BatteryCapacityTextBox.Text, out d))
                vehicle.BatteryCapacity = d;
            else
            {
                throw new Exception("Invalid Battery Capacity Value. Must Be Decimal Value");
            }
            if (Decimal.TryParse(this.VehicleRangeTextBox.Text, out d))
                vehicle.VehicleRange = d;
            else
            {
                throw new Exception("Invalid Vehicle Range Value. Must Be Decimal Value");
            }
            //Insert Data To Database
            query = $"EXECUTE dbo.InsertEconomy @fuelGrade = {vehicle.FuelGrade}, @mpgHighway = {vehicle.MPGHighway}, @mpgCity = {vehicle.MPGCity}," +
                $" @mpgCombined = {vehicle.MPGCombined}, @lkmHighway = {vehicle.LitersPerKMHighway}, @lkmCity = {vehicle.LitersPerKMCity}," +
                $" @lkmCombined = {vehicle.LitersPerKMCombined}, @tankCap = {vehicle.TankCapacity}, @batteryCap = {vehicle.BatteryCapacity}, " +
                $"@range = {vehicle.VehicleRange}";
            using (SQLcommand = new SqlCommand(query, SQLconnection))
            {
                SQLcommand.ExecuteNonQuery();
            }
            //Retrieve Id Value from Dimension Table
            query = $"SELECT dbo.ReturnEconomyId ({vehicle.FuelGrade}, {vehicle.MPGHighway}," +
                $"{vehicle.MPGCity}, {vehicle.MPGCombined},{vehicle.LitersPerKMHighway}, {vehicle.LitersPerKMCity}," +
                $" {vehicle.LitersPerKMCombined}, {vehicle.TankCapacity}, {vehicle.BatteryCapacity}, {vehicle.VehicleRange})";

            using (SQLcommand = new SqlCommand(query, SQLconnection))
            {
                int? returnId = SQLcommand.ExecuteScalar() as int?;
                vehicle.EconomyId = returnId ?? -1;
            }
            this.EconomyIdTextBox.Text = vehicle.EconomyId.ToString();
            SQLconnection.Close();

        }
        private void GatherDriveType(SqlConnection SQLconnection, Vehicle vehicle)
        {
            string query;
            SqlCommand cmd;
            if (this.DriveTrainComboBox.SelectedIndex > 0)
            {
                SQLconnection.Open();
                query = $"SELECT  dbo.ReturnDriveTypeId ('{this.DriveTrainComboBox.GetItemText(this.DriveTrainComboBox.SelectedItem)}')";
                using (cmd = new SqlCommand(query, SQLconnection))
                {

                    int? returnId = cmd.ExecuteScalar() as int?;
                    vehicle.DriveTypeId = returnId ?? -1;
                    vehicle.DriveType = this.DriveTrainComboBox.GetItemText(this.DriveTrainComboBox.SelectedItem);
                }
            }
            else
            {
                SQLconnection.Open();
                query = $"EXECUTE dbo.InsertDriveType @driveType = '{this.DriveTypeTextBox.Text}'";
                using (cmd = new SqlCommand(query, SQLconnection))
                {
                    cmd.ExecuteNonQuery();
                }
                query = $"SELECT  dbo.ReturnDriveTypeId ('{this.DriveTypeTextBox.Text}')";
                using (cmd = new SqlCommand(query, SQLconnection))
                {
                    int? returnId = cmd.ExecuteScalar() as int?;
                    vehicle.DriveTypeId = returnId ?? -1;
                    vehicle.DriveType = this.DriveTypeTextBox.Text;
                }
            }
            this.DriveTypeIdTextBox.Text = vehicle.DriveTypeId.ToString();
            SQLconnection.Close();
        }
        private void GatherMechanical(SqlConnection SQLconnection, Vehicle vehicle)
        {
            string query;
            SqlCommand SQLcommand;
            SQLconnection.Open();
            decimal d; 
            if (Decimal.TryParse(this.HorsepowerTextBox.Text, out d))
                vehicle.Horsepower = d;
            else
            {
                throw new Exception("Invalid Horsepower Value. Must Be Decimal Value");
            }
            if (Decimal.TryParse(this.TorqueTextBox.Text, out d))
                vehicle.Torque = d;
            else
            {
                throw new Exception("Invalid Torque Value. Must Be Decimal Value");
            }
            if (Decimal.TryParse(this.EngineSizeTextBox.Text, out d))
                vehicle.EngineSize = d;
            else
            {
                throw new Exception("Invalid Engine Size Value. Must Be Decimal Value");
            } 
            query = $"SELECT  dbo.ReturnCylinderConfigId ('{this.CylinderConfigBox.GetItemText(this.CylinderConfigBox.SelectedItem)}')";
            using (SQLcommand = new SqlCommand(query, SQLconnection))
            {

                int? returnId = SQLcommand.ExecuteScalar() as int?;
                vehicle.CylinderConfigId = returnId ?? -1;
            }
            query = $"SELECT  dbo.ReturnCompressorId ('{this.CompressorTypeBox.GetItemText(this.CompressorTypeBox.SelectedItem)}')";
            using (SQLcommand = new SqlCommand(query, SQLconnection))
            {

                int? returnId = SQLcommand.ExecuteScalar() as int?;
                vehicle.CompressorId = returnId ?? -1;
            }
            if (Decimal.TryParse(this.TopspeedTextBox.Text, out d))
                vehicle.Topspeed = d;
            else
            {
                throw new Exception("Invalid Top Speed Value. Must Be Decimal Value");
            }
            if (Decimal.TryParse(this.TowingCapabilityTextBox.Text, out d))
                vehicle.TowingCapability = d;
            else
            {
                throw new Exception("Invalid Towing Capacity Value. Must Be Decimal Value");
            }
            vehicle.AutoStopStart = this.AutoStopStartTextBox.SelectedIndex;
            vehicle.BatteryType = this.BatteryTypeTextBox.Text;
            if (Decimal.TryParse(this.MotorVoltageTextBox.Text, out d))
                vehicle.MotorVoltage = d;
            else
            {
                throw new Exception("Invalid Motor Voltage Value. Must Be Decimal Value");
            }
            //Insert Data To Database
            query = $"EXECUTE dbo.InsertMechanical @hp = {vehicle.Horsepower}, @torque = {vehicle.Torque}, @engineSize = {vehicle.EngineSize}, " +
                $"@cylinderConfigId = {vehicle.CylinderConfigId}, @compressorId = {vehicle.CompressorId}, @accelTime = {vehicle.AccelTime}, " +
                $"@topSpeed = {vehicle.Topspeed}, @towing = {vehicle.TowingCapability}, @stopStart = {vehicle.AutoStopStart}, " +
                $"@batteryType = '{vehicle.BatteryType}', @motorVoltage = {vehicle.MotorVoltage}";
            using (SQLcommand = new SqlCommand(query, SQLconnection))
            {
                SQLcommand.ExecuteNonQuery();
            }
            //Retrieve Id Value from Dimension Table
            query = $"SELECT dbo.ReturnMechanicalId ({vehicle.Horsepower}, {vehicle.Torque}," +
                $"{vehicle.EngineSize}, {vehicle.CylinderConfigId},{vehicle.CompressorId}, {vehicle.AccelTime}," +
                $" {vehicle.Topspeed}, {vehicle.TowingCapability}, {vehicle.AutoStopStart}, '{vehicle.BatteryType}', {vehicle.MotorVoltage})";

            using (SQLcommand = new SqlCommand(query, SQLconnection))
            {
                int? returnId = SQLcommand.ExecuteScalar() as int?;
                vehicle.MechanicalId = returnId ?? -1;
            }
            this.MechanicalIdTextBox.Text = vehicle.MechanicalId.ToString();
            SQLconnection.Close();
        }
        private void AssembleVehicleVariation(SqlConnection SQLconnection, Vehicle vehicle)
        {
            string query;
            SqlCommand SQLcommand;
            SQLconnection.Open();
            int i;
            decimal d;
            if (Int32.TryParse(this.YearTextBox.Text, out i))
                vehicle.ProductYear = i;
            else
            {
                throw new Exception("Invalid Year Value. Must Be Int Value");
            }
            if (Decimal.TryParse(this.MSRPCadTextBox.Text, out d))
                vehicle.MSRPCad = d;
            else
            {
                throw new Exception("Invalid MSRPCad Value. Must Be Int Value");
            }
            if (Decimal.TryParse(this.MSRPUsdTextBox.Text, out d))
                vehicle.MSRPUsd = d;
            else
            {
                throw new Exception("Invalid MSRPUsd Value. Must Be Int Value");
            }
            
            //Insert Data To Database
            query = $"EXECUTE dbo.InsertProductVariation @vehicleId = {vehicle.VehicleId}, @year = {vehicle.ProductYear}, " +
                $"@mSRPCad = {vehicle.MSRPCad}, @mSRPUsd = {vehicle.MSRPUsd}, @pictureFile = '{vehicle.PictureFile}', @pictureCitation = '{vehicle.PictureCitation}', " +
                $"@trimLevelId = {vehicle.TrimLevelId}, @dimensionId = {vehicle.DimensionId}, " +
                $"@exteriorId = {vehicle.ExteriorId}, @infotainmentId = {vehicle.InfotainmentId}, @interiorId = {vehicle.InteriorId}, " +
                $"@powerTrainId = {vehicle.PowerTrainId}, @gearingId = {vehicle.GearingId}, @economyId = {vehicle.EconomyId}, " +
                $"@driveTypeId = {vehicle.DriveTypeId}, @mechanicalId = {vehicle.MechanicalId}";
            using (SQLcommand = new SqlCommand(query, SQLconnection))
            {
                SQLcommand.ExecuteNonQuery();
            }
            
            SQLconnection.Close();
        }
        private void ClearAllFields()
        {
            this.MessageLabel.Text = "";
            //Clear Text Boxes
            this.ManufacturerTextBox.Text = string.Empty;
            this.BodyStyleTextBox.Text = string.Empty;
            this.ModelTextBox.Text = string.Empty;
            this.TrimLevelTextBox.Text = string.Empty;
            this.WheelBaseTextBox.Text = string.Empty;
            this.HeightTextBox.Text = string.Empty;
            this.VehicleWeightTextBox.Text = string.Empty;
            this.PassengerVolumeTextBox.Text = string.Empty;
            this.TireHeightTextBox.Text = string.Empty;
            this.HeatedMirrorsTextBox.Text = string.Empty;
            this.NumDoorsTextBox.Text = string.Empty;
            this.NumSpeakersTextBox.Text = string.Empty;
            this.AppleCarPlayTextBox.Text = string.Empty;
            this.WifiCapableTextBox.Text = string.Empty;
            this.VentilatedSeatsTextBox.Text = string.Empty;
            this.PassElectricTextBox.Text = string.Empty;
            this.HeatWheelTextBox.Text = string.Empty;
            this.PowerTrainTypeTextBox.Text = string.Empty;
            this.NumGearsTextBox.Text = string.Empty;
            this.FinalDriveRationTextBox.Text = string.Empty;
            this.MPGHighwayTextBox.Text = string.Empty;
            this.MPGCombinedTextBox.Text = string.Empty;
            this.LitersPerKMCityTextBox.Text = string.Empty;
            this.TankCapacityTextBox.Text = string.Empty;
            this.VehicleRangeTextBox.Text = string.Empty;
            this.HorsepowerTextBox.Text = string.Empty;
            this.EngineSizeTextBox.Text = string.Empty;
            this.CompressorIdTextBox.Text = string.Empty;
            this.TopspeedTextBox.Text = string.Empty;
            this.AutoStopStartTextBox.Text = string.Empty;
            this.MotorVoltageTextBox.Text = string.Empty;
            this.MSRPCadTextBox.Text = string.Empty;
            this.TrimLevelIdTextBox.Text = string.Empty;
            this.ExteriorIdTextBox.Text = string.Empty;
            this.InteriorIdTextBox.Text = string.Empty;
            this.GearingIdTextBox.Text = string.Empty;
            this.DriveTypeIdTextBox.Text = string.Empty;

            //Bottom Right Text Box
            this.VehicleLengthTextBox.Text = string.Empty;
            this.WidthTextBox.Text = string.Empty;
            this.PassengerCapTextBox.Text = string.Empty;
            this.CargoVolumeTextBox.Text = string.Empty;
            this.RimSizeTextBox.Text = string.Empty;
            this.TireWidthTextBox.Text = string.Empty;
            this.SunRoofTextBox.Text = string.Empty;
            this.ScreenSizeTextBox.Text = string.Empty;
            this.WirelessChargingTextBox.Text = string.Empty;
            this.AndroidAutoTextBox.Text = string.Empty;
            this.HeatedSeatsTextBox.Text = string.Empty;
            this.DriverSeatElectricTextBox.Text = string.Empty;
            this.RemoteStartTextBox.Text = string.Empty;
            this.PaddleShiftersTextBox.Text = string.Empty;
            this.TransmissionTypeTextBox.Text = string.Empty;
            this.TransmissionTypeIdTextBox.Text = string.Empty;
            this.FuelGradeTextBox.Text = string.Empty;
            this.MPGCityTextBox.Text = string.Empty;
            this.LitersPerKMHighwayTextBox.Text = string.Empty;
            this.LitersPerKMCombinedTextBox.Text = string.Empty;
            this.BatteryCapacityTextBox.Text = string.Empty;
            this.DriveTypeTextBox.Text = string.Empty;
            this.TorqueTextBox.Text = string.Empty;
            this.CylinderConfigIdTextBox.Text = string.Empty;
            this.AccelTimeTextBox.Text = string.Empty;
            this.TowingCapabilityTextBox.Text = string.Empty;
            this.BatteryTypeTextBox.Text = string.Empty;
            this.VehicleIdTextBox.Text = string.Empty;
            this.MSRPUsdTextBox.Text = string.Empty;
            this.DimensionIdTextBox.Text = string.Empty;
            this.InfotainmentIdTextBox.Text = string.Empty;
            this.PowerTrainIdTextBox.Text = string.Empty;
            this.EconomyIdTextBox.Text = string.Empty;
            this.MechanicalIdTextBox.Text = string.Empty;

            //Reset ComboBoxes
            this.ManufacturerComboBox.SelectedIndex = 0;
            this.BodyStyleComboBox.SelectedIndex = 0;
            this.ModelComboBox.SelectedIndex = 0;
            this.TrimLevelComboBox.SelectedIndex = 0;
            this.PowerTrainComboBox.SelectedIndex = 0;
            this.TransmissionComboBox.SelectedIndex = 0;
            this.CompressorTypeBox.SelectedIndex = 0;
            this.DriveTrainComboBox.SelectedIndex = 0;
            this.CylinderConfigBox.SelectedIndex = 0;

            //Reset Bit ComboBoxes
            this.HeatedMirrorsTextBox.Text = string.Empty;
            this.AppleCarPlayTextBox.Text = string.Empty;
            this.WifiCapableTextBox.Text = string.Empty;
            this.PassElectricTextBox.Text = string.Empty;
            this.HeatWheelTextBox.Text = string.Empty;
            this.AutoStopStartTextBox.Text = string.Empty;
            this.SunRoofTextBox.Text = string.Empty;
            this.WirelessChargingTextBox.Text = string.Empty;
            this.AndroidAutoTextBox.Text = string.Empty;
            this.HeatedSeatsTextBox.Text = string.Empty;
            this.DriverSeatElectricTextBox.Text = string.Empty;
            this.RemoteStartTextBox.Text = string.Empty;
            this.PaddleShiftersTextBox.Text = string.Empty;
            this.PictureCitationTextBox.Text = string.Empty;
            this.PictureFileTextBox.Text = string.Empty;
            this.YearTextBox.Text = string.Empty;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
        public void CreateOutFile(Vehicle vehicle)
        {
            string path = $@"C:\Vehicles\{vehicle.ProductYear}\{vehicle.ManufacturerName}";
            //Create Folder Structure Based Of Vehicle Year And Then Manufacturer
            try
            {
                if(Directory.Exists(path))
                {
                    Console.WriteLine("Path Already Exists");
                    return;
                }
                DirectoryInfo di = Directory.CreateDirectory(path);
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, $"{vehicle.ModelName}.txt")))
                {
                        outputFile.WriteLine(vehicle.ManufacturerName);
                        outputFile.WriteLine(vehicle.ManufacturerId);
                        outputFile.WriteLine(vehicle.ModelName);
                        outputFile.WriteLine(vehicle.ModelId);
                        outputFile.WriteLine(vehicle.BodyStyle);
                        outputFile.WriteLine(vehicle.BodyStyleId);

                        outputFile.WriteLine(vehicle.TrimLevel);
                        outputFile.WriteLine(vehicle.TrimLevelId);

                        outputFile.WriteLine(vehicle.WheelBase);
                        outputFile.WriteLine(vehicle.VehicleLength);
                        outputFile.WriteLine(vehicle.Height);
                        outputFile.WriteLine(vehicle.Width);
                        outputFile.WriteLine(vehicle.VehicleWeight);
                        outputFile.WriteLine(vehicle.PassengerCap);
                        outputFile.WriteLine(vehicle.PassengerVolume);
                        outputFile.WriteLine(vehicle.CargoVolume);

                        outputFile.WriteLine(vehicle.TireWidth);
                        outputFile.WriteLine(vehicle.TireHeight);
                        outputFile.WriteLine(vehicle.RimSize);
                        outputFile.WriteLine(vehicle.HeatedMirrors);
                        outputFile.WriteLine(vehicle.SunRoof);
                        outputFile.WriteLine(vehicle.NumDoors);

                        outputFile.WriteLine(vehicle.ScreenSize);
                        outputFile.WriteLine(vehicle.NumSpeakers);
                        outputFile.WriteLine(vehicle.NumSubwoofers);
                        outputFile.WriteLine(vehicle.WirelessCharging);
                        outputFile.WriteLine(vehicle.AppleCarPlay);
                        outputFile.WriteLine(vehicle.AndroidAuto);
                        outputFile.WriteLine(vehicle.WifiCapable);

                        outputFile.WriteLine(vehicle.HeatedSeats);
                        outputFile.WriteLine(vehicle.VentilatedSeats);
                        outputFile.WriteLine(vehicle.DriverSeatElectricAdjustment);
                        outputFile.WriteLine(vehicle.PassengerSeatElectricAdjustment);
                        outputFile.WriteLine(vehicle.RemoteStart);
                        outputFile.WriteLine(vehicle.HeatedMirrors);
                        outputFile.WriteLine(vehicle.PaddleShifters);

                        outputFile.WriteLine(vehicle.PowerTrainType);

                        outputFile.WriteLine(vehicle.NumGears);
                        outputFile.WriteLine(vehicle.TransmissionType);

                        outputFile.WriteLine(vehicle.FinalDriveRatio);

                        outputFile.WriteLine(vehicle.FuelGrade);
                        outputFile.WriteLine(vehicle.MPGHighway);
                        outputFile.WriteLine(vehicle.MPGCity);
                        outputFile.WriteLine(vehicle.MPGCombined);
                        outputFile.WriteLine(vehicle.LitersPerKMHighway);
                        outputFile.WriteLine(vehicle.LitersPerKMCity);
                        outputFile.WriteLine(vehicle.LitersPerKMCombined);
                        outputFile.WriteLine(vehicle.TankCapacity);
                        outputFile.WriteLine(vehicle.BatteryCapacity);
                        outputFile.WriteLine(vehicle.VehicleRange);

                        outputFile.WriteLine(vehicle.DriveType);

                        outputFile.WriteLine(vehicle.Horsepower);
                        outputFile.WriteLine(vehicle.Torque);
                        outputFile.WriteLine(vehicle.EngineSize);
                        outputFile.WriteLine(vehicle.CylinderConfigId);
                        outputFile.WriteLine(vehicle.CompressorId);
                        outputFile.WriteLine(vehicle.AccelTime);
                        outputFile.WriteLine(vehicle.Topspeed);
                        outputFile.WriteLine(vehicle.TowingCapability);
                        outputFile.WriteLine(vehicle.AutoStopStart);
                        outputFile.WriteLine(vehicle.BatteryType);
                        outputFile.WriteLine(vehicle.MotorVoltage);

                        outputFile.WriteLine(vehicle.ProductYear);
                        outputFile.WriteLine(vehicle.MSRPCad);
                        outputFile.WriteLine(vehicle.MSRPUsd);
                        outputFile.WriteLine(vehicle.VehicleId);
                        outputFile.WriteLine(vehicle.TrimLevelId);
                        outputFile.WriteLine(vehicle.DimensionId);
                        outputFile.WriteLine(vehicle.ExteriorId);
                        outputFile.WriteLine(vehicle.InfotainmentId);
                        outputFile.WriteLine(vehicle.InteriorId);
                        outputFile.WriteLine(vehicle.PowerTrainId);
                        outputFile.WriteLine(vehicle.GearingId);
                        outputFile.WriteLine(vehicle.EconomyId);
                        outputFile.WriteLine(vehicle.DriveTypeId);
                        outputFile.WriteLine(vehicle.MechanicalId);

                        outputFile.WriteLine(vehicle.PictureFile);
                        outputFile.WriteLine(vehicle.PictureCitation);
                }
            }
            catch (Exception ex) { Console.WriteLine($"File Creation Failed: {ex.ToString()}"); }
        }
    }
}
