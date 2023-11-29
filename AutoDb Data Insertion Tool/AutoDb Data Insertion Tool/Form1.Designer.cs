using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace AutoDb_Data_Insertion_Tool
{
    partial class Window1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ManufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.ModelComboBox = new System.Windows.Forms.ComboBox();
            this.BodyStyleComboBox = new System.Windows.Forms.ComboBox();
            this.TrimLevelComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ManuLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.BodyStyleLabel = new System.Windows.Forms.Label();
            this.TrimLabel = new System.Windows.Forms.Label();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.TrimLevelTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.BodyStyleTextBox = new System.Windows.Forms.TextBox();
            this.WheelBaseTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.VehicleWeightTextBox = new System.Windows.Forms.TextBox();
            this.PassengerVolumeTextBox = new System.Windows.Forms.TextBox();
            this.TireHeightTextBox = new System.Windows.Forms.TextBox();
            this.HeatedMirrorsTextBox = new System.Windows.Forms.ComboBox();
            this.NumDoorsTextBox = new System.Windows.Forms.TextBox();
            this.NumSpeakersTextBox = new System.Windows.Forms.TextBox();
            this.AppleCarPlayTextBox = new System.Windows.Forms.ComboBox();
            this.WifiCapableTextBox = new System.Windows.Forms.ComboBox();
            this.VentilatedSeatsTextBox = new System.Windows.Forms.ComboBox();
            this.PassElectricTextBox = new System.Windows.Forms.ComboBox();
            this.HeatWheelTextBox = new System.Windows.Forms.ComboBox();
            this.PowerTrainTypeTextBox = new System.Windows.Forms.TextBox();
            this.NumGearsTextBox = new System.Windows.Forms.TextBox();
            this.FinalDriveRationTextBox = new System.Windows.Forms.TextBox();
            this.MPGHighwayTextBox = new System.Windows.Forms.TextBox();
            this.MPGCombinedTextBox = new System.Windows.Forms.TextBox();
            this.LitersPerKMCityTextBox = new System.Windows.Forms.TextBox();
            this.TankCapacityTextBox = new System.Windows.Forms.TextBox();
            this.VehicleRangeTextBox = new System.Windows.Forms.TextBox();
            this.HorsepowerTextBox = new System.Windows.Forms.TextBox();
            this.EngineSizeTextBox = new System.Windows.Forms.TextBox();
            this.CompressorIdTextBox = new System.Windows.Forms.TextBox();
            this.TopspeedTextBox = new System.Windows.Forms.TextBox();
            this.AutoStopStartTextBox = new System.Windows.Forms.ComboBox();
            this.MotorVoltageTextBox = new System.Windows.Forms.TextBox();
            this.MSRPCadTextBox = new System.Windows.Forms.TextBox();
            this.TrimLevelIdTextBox = new System.Windows.Forms.TextBox();
            this.ExteriorIdTextBox = new System.Windows.Forms.TextBox();
            this.InteriorIdTextBox = new System.Windows.Forms.TextBox();
            this.GearingIdTextBox = new System.Windows.Forms.TextBox();
            this.DriveTypeIdTextBox = new System.Windows.Forms.TextBox();
            this.VehicleLengthTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.PassengerCapTextBox = new System.Windows.Forms.TextBox();
            this.CargoVolumeTextBox = new System.Windows.Forms.TextBox();
            this.RimSizeTextBox = new System.Windows.Forms.TextBox();
            this.SunRoofTextBox = new System.Windows.Forms.ComboBox();
            this.ScreenSizeTextBox = new System.Windows.Forms.TextBox();
            this.WirelessChargingTextBox = new System.Windows.Forms.ComboBox();
            this.AndroidAutoTextBox = new System.Windows.Forms.ComboBox();
            this.HeatedSeatsTextBox = new System.Windows.Forms.ComboBox();
            this.DriverSeatElectricTextBox = new System.Windows.Forms.ComboBox();
            this.RemoteStartTextBox = new System.Windows.Forms.ComboBox();
            this.PaddleShiftersTextBox = new System.Windows.Forms.ComboBox();
            this.TransmissionTypeTextBox = new System.Windows.Forms.TextBox();
            this.TransmissionTypeIdTextBox = new System.Windows.Forms.TextBox();
            this.FuelGradeTextBox = new System.Windows.Forms.TextBox();
            this.MPGCityTextBox = new System.Windows.Forms.TextBox();
            this.LitersPerKMHighwayTextBox = new System.Windows.Forms.TextBox();
            this.LitersPerKMCombinedTextBox = new System.Windows.Forms.TextBox();
            this.BatteryCapacityTextBox = new System.Windows.Forms.TextBox();
            this.DriveTypeTextBox = new System.Windows.Forms.TextBox();
            this.TorqueTextBox = new System.Windows.Forms.TextBox();
            this.CylinderConfigIdTextBox = new System.Windows.Forms.TextBox();
            this.AccelTimeTextBox = new System.Windows.Forms.TextBox();
            this.TowingCapabilityTextBox = new System.Windows.Forms.TextBox();
            this.BatteryTypeTextBox = new System.Windows.Forms.TextBox();
            this.VehicleIdTextBox = new System.Windows.Forms.TextBox();
            this.MSRPUsdTextBox = new System.Windows.Forms.TextBox();
            this.DimensionIdTextBox = new System.Windows.Forms.TextBox();
            this.InfotainmentIdTextBox = new System.Windows.Forms.TextBox();
            this.PowerTrainIdTextBox = new System.Windows.Forms.TextBox();
            this.EconomyIdTextBox = new System.Windows.Forms.TextBox();
            this.MechanicalIdTextBox = new System.Windows.Forms.TextBox();
            this.TransmissionComboBox = new System.Windows.Forms.ComboBox();
            this.CylinderConfigBox = new System.Windows.Forms.ComboBox();
            this.CompressorTypeBox = new System.Windows.Forms.ComboBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.PowerTrainComboBox = new System.Windows.Forms.ComboBox();
            this.DriveTrainComboBox = new System.Windows.Forms.ComboBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TireWidthTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.SubWooferTextBox = new System.Windows.Forms.TextBox();
            this.PictureFileTextBox = new System.Windows.Forms.TextBox();
            this.PictureCitationTextBox = new System.Windows.Forms.TextBox();
            this.PictureFileLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ManufacturerComboBox
            // 
            this.ManufacturerComboBox.BackColor = System.Drawing.Color.LightCoral;
            this.ManufacturerComboBox.Location = new System.Drawing.Point(150, 20);
            this.ManufacturerComboBox.Name = "ManufacturerComboBox";
            this.ManufacturerComboBox.Size = new System.Drawing.Size(140, 21);
            this.ManufacturerComboBox.TabIndex = 12;
            this.ManufacturerComboBox.Text = "-Create New Entry-";
            // 
            // ModelComboBox
            // 
            this.ModelComboBox.BackColor = System.Drawing.Color.LightCoral;
            this.ModelComboBox.Location = new System.Drawing.Point(700, 20);
            this.ModelComboBox.Name = "ModelComboBox";
            this.ModelComboBox.Size = new System.Drawing.Size(140, 21);
            this.ModelComboBox.TabIndex = 13;
            this.ModelComboBox.Text = "-Create New Entry-";
            // 
            // BodyStyleComboBox
            // 
            this.BodyStyleComboBox.BackColor = System.Drawing.Color.LightCoral;
            this.BodyStyleComboBox.Location = new System.Drawing.Point(150, 40);
            this.BodyStyleComboBox.Name = "BodyStyleComboBox";
            this.BodyStyleComboBox.Size = new System.Drawing.Size(140, 21);
            this.BodyStyleComboBox.TabIndex = 14;
            this.BodyStyleComboBox.Text = "-Create New Entry-";
            // 
            // TrimLevelComboBox
            // 
            this.TrimLevelComboBox.BackColor = System.Drawing.Color.LightGreen;
            this.TrimLevelComboBox.Location = new System.Drawing.Point(700, 40);
            this.TrimLevelComboBox.Name = "TrimLevelComboBox";
            this.TrimLevelComboBox.Size = new System.Drawing.Size(140, 21);
            this.TrimLevelComboBox.TabIndex = 15;
            this.TrimLevelComboBox.Text = "-Create New Entry-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Or";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(845, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Or";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Or";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(845, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Or";
            // 
            // ManuLabel
            // 
            this.ManuLabel.AutoSize = true;
            this.ManuLabel.BackColor = System.Drawing.Color.LightCoral;
            this.ManuLabel.Location = new System.Drawing.Point(10, 20);
            this.ManuLabel.Name = "ManuLabel";
            this.ManuLabel.Size = new System.Drawing.Size(70, 13);
            this.ManuLabel.TabIndex = 8;
            this.ManuLabel.Text = "Manufacturer";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.BackColor = System.Drawing.Color.LightCoral;
            this.ModelLabel.Location = new System.Drawing.Point(550, 20);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(36, 13);
            this.ModelLabel.TabIndex = 9;
            this.ModelLabel.Text = "Model";
            // 
            // BodyStyleLabel
            // 
            this.BodyStyleLabel.AutoSize = true;
            this.BodyStyleLabel.BackColor = System.Drawing.Color.LightCoral;
            this.BodyStyleLabel.Location = new System.Drawing.Point(10, 40);
            this.BodyStyleLabel.Name = "BodyStyleLabel";
            this.BodyStyleLabel.Size = new System.Drawing.Size(57, 13);
            this.BodyStyleLabel.TabIndex = 10;
            this.BodyStyleLabel.Text = "Body Style";
            // 
            // TrimLabel
            // 
            this.TrimLabel.AutoSize = true;
            this.TrimLabel.BackColor = System.Drawing.Color.LightGreen;
            this.TrimLabel.Location = new System.Drawing.Point(550, 40);
            this.TrimLabel.Name = "TrimLabel";
            this.TrimLabel.Size = new System.Drawing.Size(56, 13);
            this.TrimLabel.TabIndex = 11;
            this.TrimLabel.Text = "Trim Level";
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.ManufacturerTextBox.Location = new System.Drawing.Point(320, 20);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(200, 20);
            this.ManufacturerTextBox.TabIndex = 0;
            // 
            // TrimLevelTextBox
            // 
            this.TrimLevelTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.TrimLevelTextBox.Location = new System.Drawing.Point(870, 40);
            this.TrimLevelTextBox.Name = "TrimLevelTextBox";
            this.TrimLevelTextBox.Size = new System.Drawing.Size(200, 20);
            this.TrimLevelTextBox.TabIndex = 3;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.ModelTextBox.Location = new System.Drawing.Point(870, 20);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(200, 20);
            this.ModelTextBox.TabIndex = 1;
            // 
            // BodyStyleTextBox
            // 
            this.BodyStyleTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.BodyStyleTextBox.Location = new System.Drawing.Point(320, 40);
            this.BodyStyleTextBox.Name = "BodyStyleTextBox";
            this.BodyStyleTextBox.Size = new System.Drawing.Size(200, 20);
            this.BodyStyleTextBox.TabIndex = 2;
            // 
            // WheelBaseTextBox
            // 
            this.WheelBaseTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.WheelBaseTextBox.Location = new System.Drawing.Point(320, 60);
            this.WheelBaseTextBox.Name = "WheelBaseTextBox";
            this.WheelBaseTextBox.Size = new System.Drawing.Size(200, 20);
            this.WheelBaseTextBox.TabIndex = 4;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.HeightTextBox.Location = new System.Drawing.Point(320, 80);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(200, 20);
            this.HeightTextBox.TabIndex = 6;
            // 
            // VehicleWeightTextBox
            // 
            this.VehicleWeightTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.VehicleWeightTextBox.Location = new System.Drawing.Point(320, 100);
            this.VehicleWeightTextBox.Name = "VehicleWeightTextBox";
            this.VehicleWeightTextBox.Size = new System.Drawing.Size(200, 20);
            this.VehicleWeightTextBox.TabIndex = 8;
            // 
            // PassengerVolumeTextBox
            // 
            this.PassengerVolumeTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PassengerVolumeTextBox.Location = new System.Drawing.Point(320, 120);
            this.PassengerVolumeTextBox.Name = "PassengerVolumeTextBox";
            this.PassengerVolumeTextBox.Size = new System.Drawing.Size(200, 20);
            this.PassengerVolumeTextBox.TabIndex = 10;
            // 
            // TireHeightTextBox
            // 
            this.TireHeightTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.TireHeightTextBox.Location = new System.Drawing.Point(439, 140);
            this.TireHeightTextBox.Name = "TireHeightTextBox";
            this.TireHeightTextBox.Size = new System.Drawing.Size(81, 20);
            this.TireHeightTextBox.TabIndex = 12;
            // 
            // HeatedMirrorsTextBox
            // 
            this.HeatedMirrorsTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.HeatedMirrorsTextBox.Location = new System.Drawing.Point(320, 160);
            this.HeatedMirrorsTextBox.Name = "HeatedMirrorsTextBox";
            this.HeatedMirrorsTextBox.Size = new System.Drawing.Size(200, 21);
            this.HeatedMirrorsTextBox.TabIndex = 14;
            // 
            // NumDoorsTextBox
            // 
            this.NumDoorsTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.NumDoorsTextBox.Location = new System.Drawing.Point(320, 180);
            this.NumDoorsTextBox.Name = "NumDoorsTextBox";
            this.NumDoorsTextBox.Size = new System.Drawing.Size(200, 20);
            this.NumDoorsTextBox.TabIndex = 16;
            // 
            // NumSpeakersTextBox
            // 
            this.NumSpeakersTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.NumSpeakersTextBox.Location = new System.Drawing.Point(320, 200);
            this.NumSpeakersTextBox.Name = "NumSpeakersTextBox";
            this.NumSpeakersTextBox.Size = new System.Drawing.Size(84, 20);
            this.NumSpeakersTextBox.TabIndex = 18;
            // 
            // AppleCarPlayTextBox
            // 
            this.AppleCarPlayTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.AppleCarPlayTextBox.Location = new System.Drawing.Point(320, 220);
            this.AppleCarPlayTextBox.Name = "AppleCarPlayTextBox";
            this.AppleCarPlayTextBox.Size = new System.Drawing.Size(200, 21);
            this.AppleCarPlayTextBox.TabIndex = 20;
            // 
            // WifiCapableTextBox
            // 
            this.WifiCapableTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.WifiCapableTextBox.Location = new System.Drawing.Point(320, 240);
            this.WifiCapableTextBox.Name = "WifiCapableTextBox";
            this.WifiCapableTextBox.Size = new System.Drawing.Size(200, 21);
            this.WifiCapableTextBox.TabIndex = 22;
            // 
            // VentilatedSeatsTextBox
            // 
            this.VentilatedSeatsTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.VentilatedSeatsTextBox.Location = new System.Drawing.Point(320, 260);
            this.VentilatedSeatsTextBox.Name = "VentilatedSeatsTextBox";
            this.VentilatedSeatsTextBox.Size = new System.Drawing.Size(200, 21);
            this.VentilatedSeatsTextBox.TabIndex = 24;
            // 
            // PassElectricTextBox
            // 
            this.PassElectricTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PassElectricTextBox.Location = new System.Drawing.Point(320, 280);
            this.PassElectricTextBox.Name = "PassElectricTextBox";
            this.PassElectricTextBox.Size = new System.Drawing.Size(200, 21);
            this.PassElectricTextBox.TabIndex = 26;
            // 
            // HeatWheelTextBox
            // 
            this.HeatWheelTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.HeatWheelTextBox.Location = new System.Drawing.Point(320, 300);
            this.HeatWheelTextBox.Name = "HeatWheelTextBox";
            this.HeatWheelTextBox.Size = new System.Drawing.Size(200, 21);
            this.HeatWheelTextBox.TabIndex = 28;
            // 
            // PowerTrainTypeTextBox
            // 
            this.PowerTrainTypeTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.PowerTrainTypeTextBox.Location = new System.Drawing.Point(320, 320);
            this.PowerTrainTypeTextBox.Name = "PowerTrainTypeTextBox";
            this.PowerTrainTypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.PowerTrainTypeTextBox.TabIndex = 30;
            // 
            // NumGearsTextBox
            // 
            this.NumGearsTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.NumGearsTextBox.Location = new System.Drawing.Point(320, 340);
            this.NumGearsTextBox.Name = "NumGearsTextBox";
            this.NumGearsTextBox.Size = new System.Drawing.Size(200, 20);
            this.NumGearsTextBox.TabIndex = 32;
            // 
            // FinalDriveRationTextBox
            // 
            this.FinalDriveRationTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.FinalDriveRationTextBox.Location = new System.Drawing.Point(320, 360);
            this.FinalDriveRationTextBox.Name = "FinalDriveRationTextBox";
            this.FinalDriveRationTextBox.Size = new System.Drawing.Size(200, 20);
            this.FinalDriveRationTextBox.TabIndex = 34;
            // 
            // MPGHighwayTextBox
            // 
            this.MPGHighwayTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.MPGHighwayTextBox.Location = new System.Drawing.Point(320, 380);
            this.MPGHighwayTextBox.Name = "MPGHighwayTextBox";
            this.MPGHighwayTextBox.Size = new System.Drawing.Size(200, 20);
            this.MPGHighwayTextBox.TabIndex = 36;
            // 
            // MPGCombinedTextBox
            // 
            this.MPGCombinedTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.MPGCombinedTextBox.Location = new System.Drawing.Point(320, 400);
            this.MPGCombinedTextBox.Name = "MPGCombinedTextBox";
            this.MPGCombinedTextBox.Size = new System.Drawing.Size(200, 20);
            this.MPGCombinedTextBox.TabIndex = 38;
            // 
            // LitersPerKMCityTextBox
            // 
            this.LitersPerKMCityTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.LitersPerKMCityTextBox.Location = new System.Drawing.Point(320, 420);
            this.LitersPerKMCityTextBox.Name = "LitersPerKMCityTextBox";
            this.LitersPerKMCityTextBox.Size = new System.Drawing.Size(200, 20);
            this.LitersPerKMCityTextBox.TabIndex = 40;
            // 
            // TankCapacityTextBox
            // 
            this.TankCapacityTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.TankCapacityTextBox.Location = new System.Drawing.Point(320, 440);
            this.TankCapacityTextBox.Name = "TankCapacityTextBox";
            this.TankCapacityTextBox.Size = new System.Drawing.Size(200, 20);
            this.TankCapacityTextBox.TabIndex = 42;
            // 
            // VehicleRangeTextBox
            // 
            this.VehicleRangeTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.VehicleRangeTextBox.Location = new System.Drawing.Point(320, 460);
            this.VehicleRangeTextBox.Name = "VehicleRangeTextBox";
            this.VehicleRangeTextBox.Size = new System.Drawing.Size(200, 20);
            this.VehicleRangeTextBox.TabIndex = 44;
            // 
            // HorsepowerTextBox
            // 
            this.HorsepowerTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.HorsepowerTextBox.Location = new System.Drawing.Point(320, 480);
            this.HorsepowerTextBox.Name = "HorsepowerTextBox";
            this.HorsepowerTextBox.Size = new System.Drawing.Size(200, 20);
            this.HorsepowerTextBox.TabIndex = 46;
            // 
            // EngineSizeTextBox
            // 
            this.EngineSizeTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.EngineSizeTextBox.Location = new System.Drawing.Point(320, 500);
            this.EngineSizeTextBox.Name = "EngineSizeTextBox";
            this.EngineSizeTextBox.Size = new System.Drawing.Size(200, 20);
            this.EngineSizeTextBox.TabIndex = 48;
            // 
            // CompressorIdTextBox
            // 
            this.CompressorIdTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CompressorIdTextBox.Location = new System.Drawing.Point(320, 520);
            this.CompressorIdTextBox.Name = "CompressorIdTextBox";
            this.CompressorIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.CompressorIdTextBox.TabIndex = 50;
            // 
            // TopspeedTextBox
            // 
            this.TopspeedTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TopspeedTextBox.Location = new System.Drawing.Point(320, 540);
            this.TopspeedTextBox.Name = "TopspeedTextBox";
            this.TopspeedTextBox.Size = new System.Drawing.Size(200, 20);
            this.TopspeedTextBox.TabIndex = 52;
            // 
            // AutoStopStartTextBox
            // 
            this.AutoStopStartTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.AutoStopStartTextBox.Location = new System.Drawing.Point(320, 560);
            this.AutoStopStartTextBox.Name = "AutoStopStartTextBox";
            this.AutoStopStartTextBox.Size = new System.Drawing.Size(200, 21);
            this.AutoStopStartTextBox.TabIndex = 54;
            // 
            // MotorVoltageTextBox
            // 
            this.MotorVoltageTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.MotorVoltageTextBox.Location = new System.Drawing.Point(320, 580);
            this.MotorVoltageTextBox.Name = "MotorVoltageTextBox";
            this.MotorVoltageTextBox.Size = new System.Drawing.Size(200, 20);
            this.MotorVoltageTextBox.TabIndex = 56;
            // 
            // MSRPCadTextBox
            // 
            this.MSRPCadTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.MSRPCadTextBox.Location = new System.Drawing.Point(320, 600);
            this.MSRPCadTextBox.Name = "MSRPCadTextBox";
            this.MSRPCadTextBox.Size = new System.Drawing.Size(200, 20);
            this.MSRPCadTextBox.TabIndex = 58;
            // 
            // TrimLevelIdTextBox
            // 
            this.TrimLevelIdTextBox.Location = new System.Drawing.Point(320, 620);
            this.TrimLevelIdTextBox.Name = "TrimLevelIdTextBox";
            this.TrimLevelIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.TrimLevelIdTextBox.TabIndex = 60;
            // 
            // ExteriorIdTextBox
            // 
            this.ExteriorIdTextBox.Location = new System.Drawing.Point(320, 640);
            this.ExteriorIdTextBox.Name = "ExteriorIdTextBox";
            this.ExteriorIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.ExteriorIdTextBox.TabIndex = 62;
            // 
            // InteriorIdTextBox
            // 
            this.InteriorIdTextBox.Location = new System.Drawing.Point(320, 660);
            this.InteriorIdTextBox.Name = "InteriorIdTextBox";
            this.InteriorIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.InteriorIdTextBox.TabIndex = 64;
            // 
            // GearingIdTextBox
            // 
            this.GearingIdTextBox.Location = new System.Drawing.Point(320, 680);
            this.GearingIdTextBox.Name = "GearingIdTextBox";
            this.GearingIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.GearingIdTextBox.TabIndex = 66;
            // 
            // DriveTypeIdTextBox
            // 
            this.DriveTypeIdTextBox.Location = new System.Drawing.Point(320, 700);
            this.DriveTypeIdTextBox.Name = "DriveTypeIdTextBox";
            this.DriveTypeIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.DriveTypeIdTextBox.TabIndex = 68;
            // 
            // VehicleLengthTextBox
            // 
            this.VehicleLengthTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.VehicleLengthTextBox.Location = new System.Drawing.Point(870, 60);
            this.VehicleLengthTextBox.Name = "VehicleLengthTextBox";
            this.VehicleLengthTextBox.Size = new System.Drawing.Size(200, 20);
            this.VehicleLengthTextBox.TabIndex = 5;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.WidthTextBox.Location = new System.Drawing.Point(870, 80);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(200, 20);
            this.WidthTextBox.TabIndex = 7;
            // 
            // PassengerCapTextBox
            // 
            this.PassengerCapTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PassengerCapTextBox.Location = new System.Drawing.Point(870, 100);
            this.PassengerCapTextBox.Name = "PassengerCapTextBox";
            this.PassengerCapTextBox.Size = new System.Drawing.Size(200, 20);
            this.PassengerCapTextBox.TabIndex = 9;
            // 
            // CargoVolumeTextBox
            // 
            this.CargoVolumeTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CargoVolumeTextBox.Location = new System.Drawing.Point(870, 120);
            this.CargoVolumeTextBox.Name = "CargoVolumeTextBox";
            this.CargoVolumeTextBox.Size = new System.Drawing.Size(200, 20);
            this.CargoVolumeTextBox.TabIndex = 11;
            // 
            // RimSizeTextBox
            // 
            this.RimSizeTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.RimSizeTextBox.Location = new System.Drawing.Point(987, 140);
            this.RimSizeTextBox.Name = "RimSizeTextBox";
            this.RimSizeTextBox.Size = new System.Drawing.Size(83, 20);
            this.RimSizeTextBox.TabIndex = 13;
            // 
            // SunRoofTextBox
            // 
            this.SunRoofTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.SunRoofTextBox.Location = new System.Drawing.Point(870, 160);
            this.SunRoofTextBox.Name = "SunRoofTextBox";
            this.SunRoofTextBox.Size = new System.Drawing.Size(200, 21);
            this.SunRoofTextBox.TabIndex = 15;
            // 
            // ScreenSizeTextBox
            // 
            this.ScreenSizeTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.ScreenSizeTextBox.Location = new System.Drawing.Point(870, 180);
            this.ScreenSizeTextBox.Name = "ScreenSizeTextBox";
            this.ScreenSizeTextBox.Size = new System.Drawing.Size(200, 20);
            this.ScreenSizeTextBox.TabIndex = 17;
            // 
            // WirelessChargingTextBox
            // 
            this.WirelessChargingTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.WirelessChargingTextBox.Location = new System.Drawing.Point(870, 200);
            this.WirelessChargingTextBox.Name = "WirelessChargingTextBox";
            this.WirelessChargingTextBox.Size = new System.Drawing.Size(200, 21);
            this.WirelessChargingTextBox.TabIndex = 19;
            // 
            // AndroidAutoTextBox
            // 
            this.AndroidAutoTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.AndroidAutoTextBox.Location = new System.Drawing.Point(870, 220);
            this.AndroidAutoTextBox.Name = "AndroidAutoTextBox";
            this.AndroidAutoTextBox.Size = new System.Drawing.Size(200, 21);
            this.AndroidAutoTextBox.TabIndex = 21;
            // 
            // HeatedSeatsTextBox
            // 
            this.HeatedSeatsTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.HeatedSeatsTextBox.Location = new System.Drawing.Point(870, 240);
            this.HeatedSeatsTextBox.Name = "HeatedSeatsTextBox";
            this.HeatedSeatsTextBox.Size = new System.Drawing.Size(200, 21);
            this.HeatedSeatsTextBox.TabIndex = 23;
            // 
            // DriverSeatElectricTextBox
            // 
            this.DriverSeatElectricTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DriverSeatElectricTextBox.Location = new System.Drawing.Point(870, 260);
            this.DriverSeatElectricTextBox.Name = "DriverSeatElectricTextBox";
            this.DriverSeatElectricTextBox.Size = new System.Drawing.Size(200, 21);
            this.DriverSeatElectricTextBox.TabIndex = 25;
            // 
            // RemoteStartTextBox
            // 
            this.RemoteStartTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.RemoteStartTextBox.Location = new System.Drawing.Point(870, 280);
            this.RemoteStartTextBox.Name = "RemoteStartTextBox";
            this.RemoteStartTextBox.Size = new System.Drawing.Size(200, 21);
            this.RemoteStartTextBox.TabIndex = 27;
            // 
            // PaddleShiftersTextBox
            // 
            this.PaddleShiftersTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PaddleShiftersTextBox.Location = new System.Drawing.Point(870, 300);
            this.PaddleShiftersTextBox.Name = "PaddleShiftersTextBox";
            this.PaddleShiftersTextBox.Size = new System.Drawing.Size(200, 21);
            this.PaddleShiftersTextBox.TabIndex = 29;
            // 
            // TransmissionTypeTextBox
            // 
            this.TransmissionTypeTextBox.Location = new System.Drawing.Point(870, 320);
            this.TransmissionTypeTextBox.Name = "TransmissionTypeTextBox";
            this.TransmissionTypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.TransmissionTypeTextBox.TabIndex = 31;
            // 
            // TransmissionTypeIdTextBox
            // 
            this.TransmissionTypeIdTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.TransmissionTypeIdTextBox.Location = new System.Drawing.Point(870, 340);
            this.TransmissionTypeIdTextBox.Name = "TransmissionTypeIdTextBox";
            this.TransmissionTypeIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.TransmissionTypeIdTextBox.TabIndex = 33;
            // 
            // FuelGradeTextBox
            // 
            this.FuelGradeTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.FuelGradeTextBox.Location = new System.Drawing.Point(870, 360);
            this.FuelGradeTextBox.Name = "FuelGradeTextBox";
            this.FuelGradeTextBox.Size = new System.Drawing.Size(200, 20);
            this.FuelGradeTextBox.TabIndex = 35;
            // 
            // MPGCityTextBox
            // 
            this.MPGCityTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.MPGCityTextBox.Location = new System.Drawing.Point(870, 380);
            this.MPGCityTextBox.Name = "MPGCityTextBox";
            this.MPGCityTextBox.Size = new System.Drawing.Size(200, 20);
            this.MPGCityTextBox.TabIndex = 37;
            // 
            // LitersPerKMHighwayTextBox
            // 
            this.LitersPerKMHighwayTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.LitersPerKMHighwayTextBox.Location = new System.Drawing.Point(870, 400);
            this.LitersPerKMHighwayTextBox.Name = "LitersPerKMHighwayTextBox";
            this.LitersPerKMHighwayTextBox.Size = new System.Drawing.Size(200, 20);
            this.LitersPerKMHighwayTextBox.TabIndex = 39;
            // 
            // LitersPerKMCombinedTextBox
            // 
            this.LitersPerKMCombinedTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.LitersPerKMCombinedTextBox.Location = new System.Drawing.Point(870, 420);
            this.LitersPerKMCombinedTextBox.Name = "LitersPerKMCombinedTextBox";
            this.LitersPerKMCombinedTextBox.Size = new System.Drawing.Size(200, 20);
            this.LitersPerKMCombinedTextBox.TabIndex = 41;
            // 
            // BatteryCapacityTextBox
            // 
            this.BatteryCapacityTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.BatteryCapacityTextBox.Location = new System.Drawing.Point(870, 440);
            this.BatteryCapacityTextBox.Name = "BatteryCapacityTextBox";
            this.BatteryCapacityTextBox.Size = new System.Drawing.Size(200, 20);
            this.BatteryCapacityTextBox.TabIndex = 43;
            // 
            // DriveTypeTextBox
            // 
            this.DriveTypeTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.DriveTypeTextBox.Location = new System.Drawing.Point(870, 460);
            this.DriveTypeTextBox.Name = "DriveTypeTextBox";
            this.DriveTypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.DriveTypeTextBox.TabIndex = 45;
            // 
            // TorqueTextBox
            // 
            this.TorqueTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TorqueTextBox.Location = new System.Drawing.Point(870, 480);
            this.TorqueTextBox.Name = "TorqueTextBox";
            this.TorqueTextBox.Size = new System.Drawing.Size(200, 20);
            this.TorqueTextBox.TabIndex = 47;
            // 
            // CylinderConfigIdTextBox
            // 
            this.CylinderConfigIdTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CylinderConfigIdTextBox.Location = new System.Drawing.Point(870, 500);
            this.CylinderConfigIdTextBox.Name = "CylinderConfigIdTextBox";
            this.CylinderConfigIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.CylinderConfigIdTextBox.TabIndex = 49;
            // 
            // AccelTimeTextBox
            // 
            this.AccelTimeTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.AccelTimeTextBox.Location = new System.Drawing.Point(870, 520);
            this.AccelTimeTextBox.Name = "AccelTimeTextBox";
            this.AccelTimeTextBox.Size = new System.Drawing.Size(200, 20);
            this.AccelTimeTextBox.TabIndex = 51;
            // 
            // TowingCapabilityTextBox
            // 
            this.TowingCapabilityTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TowingCapabilityTextBox.Location = new System.Drawing.Point(870, 540);
            this.TowingCapabilityTextBox.Name = "TowingCapabilityTextBox";
            this.TowingCapabilityTextBox.Size = new System.Drawing.Size(200, 20);
            this.TowingCapabilityTextBox.TabIndex = 53;
            // 
            // BatteryTypeTextBox
            // 
            this.BatteryTypeTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BatteryTypeTextBox.Location = new System.Drawing.Point(870, 560);
            this.BatteryTypeTextBox.Name = "BatteryTypeTextBox";
            this.BatteryTypeTextBox.Size = new System.Drawing.Size(200, 20);
            this.BatteryTypeTextBox.TabIndex = 55;
            // 
            // VehicleIdTextBox
            // 
            this.VehicleIdTextBox.Location = new System.Drawing.Point(870, 580);
            this.VehicleIdTextBox.Name = "VehicleIdTextBox";
            this.VehicleIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.VehicleIdTextBox.TabIndex = 57;
            // 
            // MSRPUsdTextBox
            // 
            this.MSRPUsdTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.MSRPUsdTextBox.Location = new System.Drawing.Point(870, 600);
            this.MSRPUsdTextBox.Name = "MSRPUsdTextBox";
            this.MSRPUsdTextBox.Size = new System.Drawing.Size(200, 20);
            this.MSRPUsdTextBox.TabIndex = 59;
            // 
            // DimensionIdTextBox
            // 
            this.DimensionIdTextBox.Location = new System.Drawing.Point(870, 620);
            this.DimensionIdTextBox.Name = "DimensionIdTextBox";
            this.DimensionIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.DimensionIdTextBox.TabIndex = 61;
            // 
            // InfotainmentIdTextBox
            // 
            this.InfotainmentIdTextBox.Location = new System.Drawing.Point(870, 640);
            this.InfotainmentIdTextBox.Name = "InfotainmentIdTextBox";
            this.InfotainmentIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.InfotainmentIdTextBox.TabIndex = 63;
            // 
            // PowerTrainIdTextBox
            // 
            this.PowerTrainIdTextBox.Location = new System.Drawing.Point(870, 660);
            this.PowerTrainIdTextBox.Name = "PowerTrainIdTextBox";
            this.PowerTrainIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.PowerTrainIdTextBox.TabIndex = 65;
            // 
            // EconomyIdTextBox
            // 
            this.EconomyIdTextBox.Location = new System.Drawing.Point(870, 680);
            this.EconomyIdTextBox.Name = "EconomyIdTextBox";
            this.EconomyIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.EconomyIdTextBox.TabIndex = 67;
            // 
            // MechanicalIdTextBox
            // 
            this.MechanicalIdTextBox.Location = new System.Drawing.Point(870, 700);
            this.MechanicalIdTextBox.Name = "MechanicalIdTextBox";
            this.MechanicalIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.MechanicalIdTextBox.TabIndex = 69;
            // 
            // TransmissionComboBox
            // 
            this.TransmissionComboBox.BackColor = System.Drawing.Color.LightGreen;
            this.TransmissionComboBox.Location = new System.Drawing.Point(700, 340);
            this.TransmissionComboBox.Name = "TransmissionComboBox";
            this.TransmissionComboBox.Size = new System.Drawing.Size(140, 21);
            this.TransmissionComboBox.TabIndex = 70;
            this.TransmissionComboBox.Text = "-Create New Entry-";
            // 
            // CylinderConfigBox
            // 
            this.CylinderConfigBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CylinderConfigBox.Location = new System.Drawing.Point(700, 500);
            this.CylinderConfigBox.Name = "CylinderConfigBox";
            this.CylinderConfigBox.Size = new System.Drawing.Size(140, 21);
            this.CylinderConfigBox.TabIndex = 71;
            // 
            // CompressorTypeBox
            // 
            this.CompressorTypeBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CompressorTypeBox.Location = new System.Drawing.Point(150, 520);
            this.CompressorTypeBox.Name = "CompressorTypeBox";
            this.CompressorTypeBox.Size = new System.Drawing.Size(140, 21);
            this.CompressorTypeBox.TabIndex = 72;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(660, 785);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(76, 13);
            this.MessageLabel.TabIndex = 73;
            this.MessageLabel.Text = "Picture Citation";
            // 
            // PowerTrainComboBox
            // 
            this.PowerTrainComboBox.BackColor = System.Drawing.Color.LightCoral;
            this.PowerTrainComboBox.Location = new System.Drawing.Point(150, 319);
            this.PowerTrainComboBox.Name = "PowerTrainComboBox";
            this.PowerTrainComboBox.Size = new System.Drawing.Size(140, 21);
            this.PowerTrainComboBox.TabIndex = 74;
            this.PowerTrainComboBox.Text = "-Create New Entry-";
            // 
            // DriveTrainComboBox
            // 
            this.DriveTrainComboBox.BackColor = System.Drawing.Color.LightGreen;
            this.DriveTrainComboBox.Location = new System.Drawing.Point(700, 460);
            this.DriveTrainComboBox.Name = "DriveTrainComboBox";
            this.DriveTrainComboBox.Size = new System.Drawing.Size(140, 21);
            this.DriveTrainComboBox.TabIndex = 75;
            this.DriveTrainComboBox.Text = "-Create New Entry-";
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(663, 726);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(200, 30);
            this.EnterButton.TabIndex = 76;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(870, 726);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(200, 30);
            this.ClearButton.TabIndex = 77;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TireWidthTextBox
            // 
            this.TireWidthTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.TireWidthTextBox.Location = new System.Drawing.Point(320, 140);
            this.TireWidthTextBox.Name = "TireWidthTextBox";
            this.TireWidthTextBox.Size = new System.Drawing.Size(84, 20);
            this.TireWidthTextBox.TabIndex = 78;
            // 
            // YearTextBox
            // 
            this.YearTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.YearTextBox.Location = new System.Drawing.Point(320, 719);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(200, 20);
            this.YearTextBox.TabIndex = 79;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.BackColor = System.Drawing.Color.LightCoral;
            this.YearLabel.Location = new System.Drawing.Point(38, 719);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(29, 13);
            this.YearLabel.TabIndex = 80;
            this.YearLabel.Text = "Year";
            // 
            // SubWooferTextBox
            // 
            this.SubWooferTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.SubWooferTextBox.Location = new System.Drawing.Point(439, 201);
            this.SubWooferTextBox.Name = "SubWooferTextBox";
            this.SubWooferTextBox.Size = new System.Drawing.Size(81, 20);
            this.SubWooferTextBox.TabIndex = 81;
            // 
            // NotesTextBox
            // 
            this.PictureFileTextBox.Location = new System.Drawing.Point(41, 810);
            this.PictureFileTextBox.Multiline = true;
            this.PictureFileTextBox.Name = "NotesTextBox";
            this.PictureFileTextBox.Size = new System.Drawing.Size(479, 78);
            this.PictureFileTextBox.TabIndex = 82;
            // 
            // textBox1
            // 
            this.PictureCitationTextBox.Location = new System.Drawing.Point(663, 810);
            this.PictureCitationTextBox.Multiline = true;
            this.PictureCitationTextBox.Name = "textBox1";
            this.PictureCitationTextBox.Size = new System.Drawing.Size(407, 78);
            this.PictureCitationTextBox.TabIndex = 83;
            // 
            // label5
            // 
            this.PictureFileLabel.AutoSize = true;
            this.PictureFileLabel.Location = new System.Drawing.Point(41, 784);
            this.PictureFileLabel.Name = "label5";
            this.PictureFileLabel.Size = new System.Drawing.Size(35, 13);
            this.PictureFileLabel.TabIndex = 84;
            this.PictureFileLabel.Text = "Picture File Name";
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 900);
            this.Controls.Add(this.PictureFileLabel);
            this.Controls.Add(this.PictureCitationTextBox);
            this.Controls.Add(this.PictureFileTextBox);
            this.Controls.Add(this.SubWooferTextBox);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.TireWidthTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.DriveTrainComboBox);
            this.Controls.Add(this.PowerTrainComboBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ManufacturerTextBox);
            this.Controls.Add(this.BodyStyleTextBox);
            this.Controls.Add(this.TrimLevelTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ManuLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.BodyStyleLabel);
            this.Controls.Add(this.TrimLabel);
            this.Controls.Add(this.ManufacturerComboBox);
            this.Controls.Add(this.ModelComboBox);
            this.Controls.Add(this.BodyStyleComboBox);
            this.Controls.Add(this.TrimLevelComboBox);
            this.Controls.Add(this.WheelBaseTextBox);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.VehicleWeightTextBox);
            this.Controls.Add(this.PassengerVolumeTextBox);
            this.Controls.Add(this.TireHeightTextBox);
            this.Controls.Add(this.HeatedMirrorsTextBox);
            this.Controls.Add(this.NumDoorsTextBox);
            this.Controls.Add(this.NumSpeakersTextBox);
            this.Controls.Add(this.AppleCarPlayTextBox);
            this.Controls.Add(this.WifiCapableTextBox);
            this.Controls.Add(this.VentilatedSeatsTextBox);
            this.Controls.Add(this.PassElectricTextBox);
            this.Controls.Add(this.HeatWheelTextBox);
            this.Controls.Add(this.PowerTrainTypeTextBox);
            this.Controls.Add(this.NumGearsTextBox);
            this.Controls.Add(this.FinalDriveRationTextBox);
            this.Controls.Add(this.MPGHighwayTextBox);
            this.Controls.Add(this.MPGCombinedTextBox);
            this.Controls.Add(this.LitersPerKMCityTextBox);
            this.Controls.Add(this.TankCapacityTextBox);
            this.Controls.Add(this.VehicleRangeTextBox);
            this.Controls.Add(this.HorsepowerTextBox);
            this.Controls.Add(this.EngineSizeTextBox);
            this.Controls.Add(this.TopspeedTextBox);
            this.Controls.Add(this.AutoStopStartTextBox);
            this.Controls.Add(this.MotorVoltageTextBox);
            this.Controls.Add(this.MSRPCadTextBox);
            this.Controls.Add(this.TrimLevelIdTextBox);
            this.Controls.Add(this.ExteriorIdTextBox);
            this.Controls.Add(this.InteriorIdTextBox);
            this.Controls.Add(this.GearingIdTextBox);
            this.Controls.Add(this.DriveTypeIdTextBox);
            this.Controls.Add(this.VehicleLengthTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.PassengerCapTextBox);
            this.Controls.Add(this.CargoVolumeTextBox);
            this.Controls.Add(this.RimSizeTextBox);
            this.Controls.Add(this.SunRoofTextBox);
            this.Controls.Add(this.ScreenSizeTextBox);
            this.Controls.Add(this.WirelessChargingTextBox);
            this.Controls.Add(this.AndroidAutoTextBox);
            this.Controls.Add(this.HeatedSeatsTextBox);
            this.Controls.Add(this.DriverSeatElectricTextBox);
            this.Controls.Add(this.RemoteStartTextBox);
            this.Controls.Add(this.PaddleShiftersTextBox);
            this.Controls.Add(this.TransmissionTypeIdTextBox);
            this.Controls.Add(this.FuelGradeTextBox);
            this.Controls.Add(this.MPGCityTextBox);
            this.Controls.Add(this.LitersPerKMHighwayTextBox);
            this.Controls.Add(this.LitersPerKMCombinedTextBox);
            this.Controls.Add(this.BatteryCapacityTextBox);
            this.Controls.Add(this.DriveTypeTextBox);
            this.Controls.Add(this.TorqueTextBox);
            this.Controls.Add(this.AccelTimeTextBox);
            this.Controls.Add(this.TowingCapabilityTextBox);
            this.Controls.Add(this.BatteryTypeTextBox);
            this.Controls.Add(this.VehicleIdTextBox);
            this.Controls.Add(this.MSRPUsdTextBox);
            this.Controls.Add(this.DimensionIdTextBox);
            this.Controls.Add(this.InfotainmentIdTextBox);
            this.Controls.Add(this.PowerTrainIdTextBox);
            this.Controls.Add(this.EconomyIdTextBox);
            this.Controls.Add(this.MechanicalIdTextBox);
            this.Controls.Add(this.TransmissionComboBox);
            this.Controls.Add(this.CylinderConfigBox);
            this.Controls.Add(this.CompressorTypeBox);
            this.Name = "Window1";
            this.Text = "Insert New Vehicle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //Top ComboBoxes
        private ComboBox ManufacturerComboBox;
        private ComboBox ModelComboBox;
        private ComboBox BodyStyleComboBox;
        private ComboBox TrimLevelComboBox;

        //Top Labels
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label ManuLabel;
        private Label ModelLabel;
        private Label BodyStyleLabel;
        private Label TrimLabel;


        //Top TextBoxes
        private TextBox ManufacturerTextBox;
        private TextBox ModelTextBox;
        private TextBox BodyStyleTextBox;
        private TextBox TrimLevelTextBox;

        //Bottom Labels
        private Label[] labelGroup1;
        private Label[] labelGroup2;
        //Bottom Left TextBoxes
        private TextBox WheelBaseTextBox;
        private TextBox HeightTextBox;
        private TextBox VehicleWeightTextBox;
        private TextBox PassengerVolumeTextBox;
        private TextBox TireHeightTextBox;
        private ComboBox HeatedMirrorsTextBox;
        private TextBox NumDoorsTextBox;
        private TextBox NumSpeakersTextBox;
        private ComboBox AppleCarPlayTextBox;
        private ComboBox WifiCapableTextBox;
        private ComboBox VentilatedSeatsTextBox;
        private ComboBox PassElectricTextBox;
        private ComboBox HeatWheelTextBox;
        private TextBox PowerTrainTypeTextBox;
        private TextBox NumGearsTextBox;
        private TextBox FinalDriveRationTextBox;
        private TextBox MPGHighwayTextBox;
        private TextBox MPGCombinedTextBox;
        private TextBox LitersPerKMCityTextBox;
        private TextBox TankCapacityTextBox;
        private TextBox VehicleRangeTextBox;
        private TextBox HorsepowerTextBox;
        private TextBox EngineSizeTextBox;
        private TextBox CompressorIdTextBox;
        private TextBox TopspeedTextBox;
        private ComboBox AutoStopStartTextBox;
        private TextBox MotorVoltageTextBox;
        private TextBox MSRPCadTextBox;
        private TextBox TrimLevelIdTextBox;
        private TextBox ExteriorIdTextBox;
        private TextBox InteriorIdTextBox;
        private TextBox GearingIdTextBox;
        private TextBox DriveTypeIdTextBox;

        //Bottom Right Text Box
        private TextBox VehicleLengthTextBox;
        private TextBox WidthTextBox;
        private TextBox PassengerCapTextBox;
        private TextBox CargoVolumeTextBox;
        private TextBox RimSizeTextBox;
        private ComboBox SunRoofTextBox;
        private TextBox ScreenSizeTextBox;
        private ComboBox WirelessChargingTextBox;
        private ComboBox AndroidAutoTextBox;
        private ComboBox HeatedSeatsTextBox;
        private ComboBox DriverSeatElectricTextBox;
        private ComboBox RemoteStartTextBox;
        private ComboBox PaddleShiftersTextBox;
        private TextBox TransmissionTypeTextBox;
        private TextBox TransmissionTypeIdTextBox;
        private TextBox FuelGradeTextBox;
        private TextBox MPGCityTextBox;
        private TextBox LitersPerKMHighwayTextBox;
        private TextBox LitersPerKMCombinedTextBox;
        private TextBox BatteryCapacityTextBox;
        private TextBox DriveTypeTextBox;
        private TextBox TorqueTextBox;
        private TextBox CylinderConfigIdTextBox;
        private TextBox AccelTimeTextBox;
        private TextBox TowingCapabilityTextBox;
        private TextBox BatteryTypeTextBox;
        private TextBox VehicleIdTextBox;
        private TextBox MSRPUsdTextBox;
        private TextBox DimensionIdTextBox;
        private TextBox InfotainmentIdTextBox;
        private TextBox PowerTrainIdTextBox;
        private TextBox EconomyIdTextBox;
        private TextBox MechanicalIdTextBox;

        //Remaining Combo Boxes On Bottom Hafl
        private ComboBox TransmissionComboBox;
        private ComboBox CylinderConfigBox;
        private ComboBox CompressorTypeBox;
        private Label MessageLabel;
        private ComboBox PowerTrainComboBox;
        private ComboBox DriveTrainComboBox;
        private Button EnterButton;
        private Button ClearButton;
        private TextBox TireWidthTextBox;
        private TextBox YearTextBox;
        private Label YearLabel;
        private TextBox SubWooferTextBox;
        private TextBox PictureFileTextBox;
        private TextBox PictureCitationTextBox;
        private Label PictureFileLabel;
    }
}

