USE master;
Go

DROP DATABASE IF EXISTS AutoDB;
GO

CREATE DATABASE AutoDb;
GO

USE AutoDB;
GO

CREATE TABLE dbo.BodyStyle (
BodyStyleId INT IDENTITY NOT NULL,
BodyStyle VARCHAR(50),

CONSTRAINT PK_BodyStyleId PRIMARY KEY(BodyStyleId)
);
GO

CREATE TABLE dbo.Manufacturer (
ManufacturerId INT IDENTITY NOT NULL,
ManufacturerName VARCHAR(50),

CONSTRAINT PK_ManufacturerId PRIMARY KEY(ManufacturerId)
);
GO

CREATE TABLE dbo.Vehicle (
VehicleId INT IDENTITY NOT NULL,
ModelName VARCHAR(150),
ManufacturerId INT,
BodyStyleId INT,

CONSTRAINT PK_VehicleId PRIMARY KEY (VehicleId),
CONSTRAINT FK_BodyStyleId FOREIGN KEY (BodyStyleId) REFERENCES dbo.BodyStyle (BodyStyleId),
CONSTRAINT FK_ManufacturerId FOREIGN KEY (ManufacturerId) REFERENCES dbo.Manufacturer(ManufacturerId)
);
GO

CREATE TABLE dbo.Interior (
InteriorId INT IDENTITY NOT NULL,
HeatedSeats BIT,
VentilatedSeats BIT,
DriverSeatElectricAdjustment BIT,
PassengerSeatElectricAdjustment BIT,
RemoteStart BIT,
HeatedSteeringWheel BIT,
PaddleShifters BIT,

CONSTRAINT PK_InteriorId PRIMARY KEY (InteriorId)
);
GO

CREATE TABLE dbo.Infotainment (
InfotainmentId INT IDENTITY NOT NULL,
ScreenSize DECIMAL,
NumSpeakers INT,
WirelessCharging BIT,
AppleCarPlay BIT,
AndroidAuto BIT,
WifiCapable BIT,

CONSTRAINT PK_InfotainmentId PRIMARY KEY (InfotainmentId)
);
GO

CREATE TABLE dbo.Exterior (
ExteriorId INT IDENTITY NOT NULL,
TireSize VARCHAR(50),
RimSize INT,
HeatedMirrors BIT,
SunRoof BIT,
NumDoors INT,

CONSTRAINT PK_ExteriorId PRIMARY KEY(ExteriorId)
);
Go

CREATE TABLE dbo.Dimensions(
DimensionsID INT IDENTITY NOT NULL,
WheelBase DECIMAL,
VehicleLength DECIMAL,
Width DECIMAL,
Height DECIMAL,
GroundClearance DECIMAL,
VehicleWeight DECIMAL,
GVWR DECIMAL,
PassengerCap INT,
PassengerVolume DECIMAL,
CargoVolume DECIMAL,

CONSTRAINT PK_DimensionsId PRIMARY KEY(DimensionsId)
);
GO

CREATE TABLE dbo.TrimLevel (
TrimLevelId INT IDENTITY NOT NULL,
TrimLevel VARCHAR(50),

CONSTRAINT PK_TrimLevelId PRIMARY KEY(TrimLevelId)
);
GO

CREATE TABLE dbo.DriveType(
DriveTypeId INT IDENTITY NOT NULL,
DriveType VARCHAR(50),

CONSTRAINT PK_DriveTypeId PRIMARY KEY(DriveTypeId)
);
GO

CREATE TABLE dbo.TransmissionType (
TransmissionTypeId INT IDENTITY NOT NULL,
TransmissionType VARCHAR(50),

CONSTRAINT PK_TransmissionTypeId PRIMARY KEY(TransmissionTypeId)
);

CREATE TABLE dbo.Gearing (
GearingId INT IDENTITY NOT NULL,
TransmissionTypeId INT,
FinalDriveRation DECIMAL,

CONSTRAINT PK_GearingId PRIMARY KEY (GearingId),
CONSTRAINT FK_TransmissionTypeId FOREIGN KEY(TransmissionTypeId) REFERENCES dbo.TransmissionType(TransmissionTypeId)
);
GO

CREATE TABLE dbo.PowerTrain (
PowerTrainId INT IDENTITY NOT NULL,
PowerTrainType VARCHAR(50),

CONSTRAINT PK_PowerTrainId PRIMARY KEY(PowerTrainId)
);
GO



CREATE TABLE dbo.CylinderConfig (
CylinderConfigId INT IDENTITY NOT NULL,
CylinderConfig VARCHAR(50),

CONSTRAINT PK_CylinderConfigId PRIMARY KEY (CylinderConfigId)
);
GO

CREATE TABLE dbo.Compressor (
CompressorId INT IDENTITY NOT NULL,
CompressorType VARCHAR(50),

CONSTRAINT PK_CompressorId PRIMARY KEY(CompressorId)
);
GO

CREATE TABLE dbo.Economy (
EconomyId INT IDENTITY NOT NULL,
FuelGrade INT,
MPGHighway INT,
MPGCity INT,
MPGCombined INT,
LitersPerKMHighway INT,
LitersPerKMCity INT,
LitersPerKMCombined INT,
TankCapacity INT,
BatteryCapacity INT,
VehicleRange INT,

CONSTRAINT PK_EcnomyId PRIMARY KEY(EconomyId),
);
GO
CREATE TABLE dbo.ProductVaration (
ProductVarationId INT IDENTITY NOT NULL,
VehicleId INT,
MSRPCad DECIMAL,
MSRPUsd DECIMAL,
TrimLevelId INT,
DimensionId INT,
ExteriorId INT,
InfotainmentId INT,
InteriorId INT,
PowerTrainId INT,
GearingId INT,
EconomyId INT,
DriveTypeId INT

CONSTRAINT PK_ProductVarationId PRIMARY KEY(ProductVarationId),
CONSTRAINT FK_VehicleId FOREIGN KEY (VehicleId) REFERENCES dbo.Vehicle (VehicleId),
CONSTRAINT FK_TrimLevelId FOREIGN KEY(TrimLevelId) REFERENCES dbo.TrimLevel (TrimLevelId),
CONSTRAINT FK_DimensionId FOREIGN KEY (DimensionId) REFERENCES dbo.Dimensions (DimensionsId),
CONSTRAINT FK_ExteriorId FOREIGN KEY (ExteriorId) REFERENCES dbo.Exterior (ExteriorId),
CONSTRAINT FK_InfotainmentId FOREIGN KEY (InfotainmentId) REFERENCES dbo.Infotainment (InfotainmentId),
CONSTRAINT FK_InteriorId FOREIGN KEY (InteriorId) REFERENCES dbo.Interior (InteriorId),
CONSTRAINT FK_PowerTrainId FOREIGN KEY (PowerTrainId) REFERENCES dbo.PowerTrain (PowerTrainId),
CONSTRAINT FK_GearingId FOREIGN KEY (GearingId) REFERENCES dbo.Gearing (GearingId),
CONSTRAINT FK_EconomyId FOREIGN KEY(EconomyId) REFERENCES dbo.Economy (EconomyId),
CONSTRAINT FK_DriveTypeId FOREIGN KEY (DriveTypeId) REFERENCES dbo.DriveType(DriveTypeId),
);

CREATE TABLE dbo.Mechanical (
MechanicalId INT IDENTITY NOT NULL,
Horsepower DECIMAL,
Torque DECIMAL,
EngineSize DECIMAL,
CylinderConfigId INT,
CompressorId INT,
AccelTime DECIMAL,
TowingCapability DECIMAL,
AutoStopStart BIT,
BatteryType VARCHAR(50),
MotorVoltage DECIMAL,
BatteryCapacity DECIMAL,
ProductVarationId INT,

CONSTRAINT PK_MechanicalId PRIMARY KEY(MechanicalId),
CONSTRAINT FK_CylinderConfigId_Mechanical FOREIGN KEY (CylinderConfigId) REFERENCES dbo.CylinderConfig (CylinderConfigId),
CONSTRAINT FK_CompressorId_Mechanical FOREIGN KEY(CompressorId) REFERENCES dbo.Compressor (CompressorId),
CONSTRAINT FK_ProductVarationId_Mechanical FOREIGN KEY(ProductVarationId) REFERENCES dbo.ProductVaration (ProductVarationId),
);
GO

