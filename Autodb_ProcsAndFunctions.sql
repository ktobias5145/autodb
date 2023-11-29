
USE AutoDB;
GO
--TrimLevel

DROP PROCEDURE IF EXISTS dbo.InsertTrimLevel;
GO
DROP FUNCTION IF EXISTS ReturnTrimLevelId;
GO

CREATE OR ALTER PROCEDURE dbo.InsertTrimLevel (@trim nvarchar(50))
AS BEGIN 
SET XACT_ABORT ON;
IF NOT EXISTS 
(
SELECT * FROM dbo.TrimLevel
WHERE TrimLevel = @trim 
)
BEGIN;
INSERT INTO dbo.TrimLevel (TrimLevel)
VALUES (@trim)
END;
END;
GO

CREATE FUNCTION dbo.ReturnTrimLevelId (@trim nvarchar(50))
RETURNS INT 
AS
BEGIN;
DECLARE @trimId INT;

SELECT @trimId = TrimLevelId 
FROM dbo.TrimLevel
WHERE TrimLevel = @trim

RETURN @trimId
END;
GO
--End TrimLevel

--Dimensions

DROP PROCEDURE IF EXISTS dbo.InsertDimensions
GO

DROP FUNCTION IF EXISTS dbo.ReturnDimensionsId 
GO

CREATE OR ALTER PROCEDURE dbo.InsertDimensions 
(
@wheelbase DECIMAL,
@length DECIMAL,
@width DECIMAL,
@height DECIMAL,
@weight DECIMAL,
@passengers INT,
@passVolume DECIMAL,
@cargoVolume DECIMAL
)
AS BEGIN 
SET XACT_ABORT ON;
IF NOT EXISTS 
(
SELECT * FROM dbo.Dimensions
WHERE WheelBase = @wheelbase
AND VehicleLength = @length
AND Width = @width
AND Height = @height
AND VehicleWeight = @weight
AND PassengerCap = @passengers
AND PassengerVolume = @passVolume
AND CargoVolume = @cargoVolume
)
BEGIN;
INSERT INTO dbo.Dimensions
(
WheelBase,VehicleLength,Width,Height,VehicleWeight,PassengerCap,PassengerVolume,CargoVolume
)
VALUES (@wheelbase,@length,@width,@height,@weight,@passengers,@passVolume,@cargoVolume)
END;
END;
GO

CREATE FUNCTION dbo.ReturnDimensionsId 
(
@wheelbase DECIMAL,
@length DECIMAL,
@width DECIMAL,
@height DECIMAL,
@weight DECIMAL,
@passengers INT,
@passVolume DECIMAL,
@cargoVolume DECIMAL
)
RETURNS INT 
AS
BEGIN;
DECLARE @dimensionsId INT;

SELECT @dimensionsId = DimensionsID
FROM dbo.Dimensions
WHERE WheelBase = @wheelbase
AND VehicleLength = @length
AND Width = @width
AND Height = @height
AND VehicleWeight = @weight
AND PassengerCap = @passengers
AND PassengerVolume = @passVolume
AND CargoVolume = @cargoVolume

RETURN @dimensionsId
END;
GO

--End Dimensions

--Exterior
DROP PROCEDURE IF EXISTS dbo.InsertExterior
Go
DROP FUNCTION IF EXISTS dbo.ReturnExteriorId 
GO

CREATE OR ALTER PROCEDURE dbo.InsertExterior 
(
@tireHeight INT,
@tireWidth INT,
@rimSize INT,
@mirrorHeat BIT,
@sunRoof BIT,
@numDoors INT
)
AS BEGIN 
SET XACT_ABORT ON;
IF NOT EXISTS 
(
SELECT * FROM dbo.Exterior
WHERE TireWidth = @tireWidth
AND TireHeight = @tireHeight
AND RimSize = @rimSize
AND HeatedMirrors = @mirrorHeat
AND SunRoof = @sunRoof
AND NumDoors = @numDoors
)
BEGIN;
INSERT INTO dbo.Exterior (TireWidth, TireHeight,RimSize,HeatedMirrors,SunRoof,NumDoors)
VALUES (@tireWidth,@tireHeight,@rimSize,@mirrorHeat,@sunRoof,@numDoors)
END;
END;
GO

CREATE FUNCTION dbo.ReturnExteriorId 
(
@tireHeight INT,
@tireWidth INT,
@rimSize INT,
@mirrorHeat BIT,
@sunRoof BIT,
@numDoors INT
)
RETURNS INT 
AS
BEGIN;
DECLARE @exteriorId INT;

SELECT @exteriorId = ExteriorId 
FROM dbo.Exterior
WHERE TireWidth = @tireWidth
AND TireHeight = @tireHeight
AND RimSize = @rimSize
AND HeatedMirrors = @mirrorHeat
AND SunRoof = @sunRoof
AND NumDoors = @numDoors

RETURN @exteriorId
END;
GO

--End Exterior

--Infotainment
DROP PROCEDURE IF EXISTS dbo.InsertInfotainment
Go
DROP FUNCTION IF EXISTS dbo.ReturnInfotainmentId 
GO

CREATE OR ALTER PROCEDURE dbo.InsertInfotainment 
(
@screenSize DECIMAL,
@speakers INT,
@subwoofers INT,
@wirelessCharging BIT,
@appleCarPlay BIT,
@androidAuto BIT,
@wifi BIT
)
AS BEGIN 
SET XACT_ABORT ON;
IF NOT EXISTS 
(
SELECT * FROM dbo.Infotainment
WHERE ScreenSize = @screenSize
AND NumSpeakers = @speakers
AND NumSubwoofers = @subwoofers
AND WirelessCharging = @wirelessCharging
AND AppleCarPlay = @appleCarPlay
AND AndroidAuto = @androidAuto
AND WifiCapable = @wifi
)
BEGIN;
INSERT INTO dbo.Infotainment (ScreenSize,
NumSpeakers,
NumSubwoofers,
WirelessCharging,
AppleCarPlay,
AndroidAuto,
WifiCapable)
VALUES (@screenSize,
@speakers,
@subwoofers,
@wirelessCharging,
@appleCarPlay,
@androidAuto,
@wifi)
END;
END;
GO

CREATE FUNCTION dbo.ReturnInfotainmentId 
(
@screenSize DECIMAL,
@speakers INT,
@subwoofers INT,
@wirelessCharging BIT,
@appleCarPlay BIT,
@androidAuto BIT,
@wifi BIT
)
RETURNS INT 
AS
BEGIN;
DECLARE @infotainmentId INT;

SELECT @infotainmentId = InfotainmentId 
FROM dbo.Infotainment
WHERE ScreenSize = @screenSize
AND NumSpeakers = @speakers
AND NumSubwoofers = @subwoofers
AND WirelessCharging = @wirelessCharging
AND AppleCarPlay = @appleCarPlay
AND AndroidAuto = @androidAuto
AND WifiCapable = @wifi

RETURN @infotainmentId
END;
GO
--End Infotainment

--Interior
DROP PROCEDURE IF EXISTS dbo.InsertInterior
Go
DROP FUNCTION IF EXISTS dbo.ReturnInteriorId 
GO

CREATE OR ALTER PROCEDURE dbo.InsertInterior 
(
@heatedSeats BIT,
@ventedSeats BIT,
@powerDriverSeats BIT,
@powerPassengerSeats BIT,
@remoteStart BIT,
@heatedSteering BIT,
@paddleShifters BIT
)
AS BEGIN 
SET XACT_ABORT ON;
IF NOT EXISTS 
(
SELECT * FROM dbo.Interior
WHERE HeatedSeats = @heatedSeats
AND VentilatedSeats = @ventedSeats
AND DriverSeatElectricAdjustment = @powerDriverSeats
AND PassengerSeatElectricAdjustment = @powerPassengerSeats
AND RemoteStart = @remoteStart
AND HeatedSteeringWheel = @heatedSteering
AND PaddleShifters = @paddleShifters
)
BEGIN;
INSERT INTO dbo.Interior (HeatedSeats,
VentilatedSeats,
DriverSeatElectricAdjustment,
PassengerSeatElectricAdjustment,
RemoteStart,
HeatedSteeringWheel,
PaddleShifters)
VALUES (@heatedSeats,
@ventedSeats,
@powerDriverSeats,
@powerPassengerSeats,
@remoteStart,
@heatedSteering,
@paddleShifters)
END;
END;
GO

CREATE FUNCTION dbo.ReturnInteriorId 
(
@heatedSeats BIT,
@ventedSeats BIT,
@powerDriverSeats BIT,
@powerPassengerSeats BIT,
@remoteStart BIT,
@heatedSteering BIT,
@paddleShifters BIT
)
RETURNS INT 
AS
BEGIN;
DECLARE @interiorId INT;

SELECT @interiorId = InteriorId 
FROM dbo.Interior
WHERE  HeatedSeats = @heatedSeats
AND VentilatedSeats = @ventedSeats
AND DriverSeatElectricAdjustment = @powerDriverSeats
AND PassengerSeatElectricAdjustment = @powerPassengerSeats
AND RemoteStart = @remoteStart
AND HeatedSteeringWheel = @heatedSteering
AND PaddleShifters = @paddleShifters

RETURN @interiorId
END;
GO

--End Interior

--PowerTrain

DROP FUNCTION IF EXISTS dbo.ReturnPowerTrainId
GO
DROP PROCEDURE IF EXISTS dbo.InsertPowerTrain
GO

CREATE OR ALTER PROCEDURE dbo.InsertPowerTrain (@powertrainType nvarchar(50))
AS BEGIN 
SET XACT_ABORT ON;
IF NOT EXISTS 
(
SELECT * FROM dbo.PowerTrain
WHERE PowerTrainType = @powertrainType 
)
BEGIN;
INSERT INTO dbo.PowerTrain (PowerTrainType)
VALUES (@powertrainType)
END;
END;
GO

CREATE FUNCTION dbo.ReturnPowerTrainId (@powertrainType nvarchar(50))
RETURNS INT 
AS
BEGIN;
DECLARE @powertrainId INT;

SELECT @powertrainId = PowerTrainId 
FROM dbo.PowerTrain
WHERE PowerTrainType = @powertrainType

RETURN @powertrainId
END;
GO
--End PowerTrain

--Transmission

DROP FUNCTION IF EXISTS dbo.ReturnTransmissionId
GO
DROP PROCEDURE IF EXISTS dbo.InsertTransmission
GO

CREATE OR ALTER PROCEDURE dbo.InsertTransmission (@transtype nvarchar(50), @gears INT)
AS BEGIN 
SET XACT_ABORT ON;
IF NOT EXISTS 
(
SELECT * FROM dbo.TransmissionType
WHERE TransmissionType = @transtype AND NumGears = @gears
)
BEGIN;
INSERT INTO dbo.TransmissionType (TransmissionType, NumGears)
VALUES (@transtype,@gears)
END;
END;
GO

CREATE FUNCTION dbo.ReturnTransmissionId (@transtype nvarchar(50), @gears INT)
RETURNS INT 
AS
BEGIN;
DECLARE @transId INT;

SELECT @transId = TransmissionTypeId 
FROM dbo.TransmissionType
WHERE TransmissionType = @transtype AND NumGears = @gears

RETURN @transId
END;
GO

--End Transmission

--Gearing
DROP FUNCTION IF EXISTS dbo.ReturnGearingId
GO
DROP PROCEDURE IF EXISTS dbo.InsertGearing
GO

CREATE OR ALTER PROCEDURE dbo.InsertGearing (@transTypeId INT, @finalDrive DECIMAl)
AS BEGIN 
SET XACT_ABORT ON;
IF NOT EXISTS 
(
SELECT * FROM dbo.Gearing
WHERE TransmissionTypeId = @transTypeId AND FinalDriveRation = @finalDrive
)
BEGIN;
INSERT INTO dbo.Gearing (TransmissionTypeId, FinalDriveRation)
VALUES (@transTypeId,@finalDrive)
END;
END;
GO


CREATE FUNCTION dbo.ReturnGearingId (@transTypeId INT, @finalDrive DECIMAl)
RETURNS INT 
AS
BEGIN;
DECLARE @gearingId INT;

SELECT @gearingId = GearingId 
FROM dbo.Gearing
WHERE TransmissionTypeId = @transTypeId AND FinalDriveRation = @finalDrive

RETURN @gearingId
END;
GO
--End Gearing

--Economy
DROP PROCEDURE IF EXISTS dbo.InsertEconomy
Go
DROP FUNCTION IF EXISTS dbo.ReturnEconomyId 
GO

CREATE OR ALTER PROCEDURE dbo.InsertEconomy
(
@fuelGrade INT,
@mpgHighway DECIMAL,
@mpgCity DECIMAL,
@mpgCombined DECIMAL,
@lkmHighway DECIMAl,
@lkmCity DECIMAL,
@lkmCombined DECIMAL,
@tankCap DECIMAL,
@batteryCap DECIMAL,
@range DECIMAl
)
AS BEGIN 
SET XACT_ABORT ON;
IF NOT EXISTS 
(
SELECT * FROM dbo.Economy
WHERE FuelGrade = @fuelGrade
AND MPGHighway = @mpgHighway
AND MPGCity = @mpgCity
AND MPGCombined = @mpgCombined
AND LitersPerKMHighway = @lkmHighway
AND LitersPerKMCity = @lkmCity
AND LitersPerKMCombined = @lkmCombined
AND TankCapacity = @tankCap
AND BatteryCapacity = @batteryCap
AND VehicleRange = @range
)
BEGIN;
INSERT INTO dbo.Economy
(
FuelGrade,
MPGHighway,
MPGCity,
MPGCombined,
LitersPerKMHighway,
LitersPerKMCity,
LitersPerKMCombined,
TankCapacity,
BatteryCapacity,
VehicleRange
)
VALUES (@fuelGrade,
@mpgHighway,
@mpgCity,
@mpgCombined,
@lkmHighway,
@lkmCity,
@lkmCombined,
@tankCap,
@batteryCap,
@range)
END;
END;
GO

CREATE FUNCTION dbo.ReturnEconomyId 
(
@fuelGrade INT,
@mpgHighway DECIMAL,
@mpgCity DECIMAL,
@mpgCombined DECIMAL,
@lkmHighway DECIMAl,
@lkmCity DECIMAL,
@lkmCombined DECIMAL,
@tankCap DECIMAL,
@batteryCap DECIMAL,
@range DECIMAl
)
RETURNS INT 
AS
BEGIN;
DECLARE @economyId INT;

SELECT @economyId = EconomyId 
FROM dbo.Economy
WHERE FuelGrade = @fuelGrade
AND MPGHighway = @mpgHighway
AND MPGCity = @mpgCity
AND MPGCombined = @mpgCombined
AND LitersPerKMHighway = @lkmHighway
AND LitersPerKMCity = @lkmCity
AND LitersPerKMCombined = @lkmCombined
AND TankCapacity = @tankCap
AND BatteryCapacity = @batteryCap
AND VehicleRange = @range

RETURN @economyId
END;
GO
--End Economy

--DriveType
DROP FUNCTION IF EXISTS dbo.ReturnDriveTypeId
GO
DROP PROCEDURE IF EXISTS dbo.InsertDriveType
GO

CREATE OR ALTER PROCEDURE dbo.InsertDriveType (@driveType nvarchar(50))
AS BEGIN 
SET XACT_ABORT ON;
IF NOT EXISTS 
(
SELECT * FROM dbo.DriveType
WHERE DriveType = @driveType 
)
BEGIN;
INSERT INTO dbo.DriveType (DriveType)
VALUES (@driveType)
END;
END;
GO

CREATE FUNCTION dbo.ReturnDriveTypeId (@driveType nvarchar(50))
RETURNS INT 
AS
BEGIN;
DECLARE @driveTypeId INT;

SELECT @driveTypeId = DriveTypeId 
FROM dbo.DriveType
WHERE DriveType = @driveType

RETURN @driveTypeId
END;
GO
--End DriveType

--Mechanical
DROP PROCEDURE IF EXISTS dbo.InsertMechanical
Go
DROP FUNCTION IF EXISTS dbo.ReturnMechanicalId 
GO

CREATE OR ALTER PROCEDURE dbo.InsertMechanical
(
@hp DECIMAL,
@torque DECIMAL,
@engineSize DECIMAL,
@cylinderConfigId INT,
@compressorId INT,
@accelTime DECIMAL,
@topSpeed DECIMAL,
@towing DECIMAL,
@stopStart BIT,
@batteryType VARCHAR(50),
@motorVoltage DECIMAl
)
AS BEGIN 
SET XACT_ABORT ON;
IF NOT EXISTS 
(
SELECT * FROM dbo.Mechanical
WHERE Horsepower = @hp
AND Torque = @torque
AND EngineSize = @engineSize
AND CylinderConfigId = @cylinderConfigId
AND CompressorId = @compressorId
AND AccelTime = @accelTime
AND Topspeed = @topSpeed
AND TowingCapability = @towing
AND AutoStopStart = @stopStart
AND BatteryType = @batteryType
AND MotorVoltage = @motorVoltage
)
BEGIN;
INSERT INTO dbo.Mechanical
(
Horsepower,
Torque,
EngineSize,
CylinderConfigId,
CompressorId,
AccelTime,
Topspeed,
TowingCapability,
AutoStopStart,
BatteryType,
MotorVoltage
)
VALUES (@hp,
@torque,
@engineSize,
@cylinderConfigId,
@compressorId,
@accelTime,
@topSpeed,
@towing,
@stopStart,
@batteryType,
@motorVoltage)
END;
END;
GO

CREATE FUNCTION dbo.ReturnMechanicalId 
(
@hp DECIMAL,
@torque DECIMAL,
@engineSize DECIMAL,
@cylinderConfigId INT,
@compressorId INT,
@accelTime DECIMAL,
@topSpeed DECIMAL,
@towing DECIMAL,
@stopStart BIT,
@batteryType VARCHAR(50),
@motorVoltage DECIMAl
)
RETURNS INT 
AS
BEGIN;
DECLARE @mechanicalId INT;

SELECT @mechanicalId = MechanicalId 
FROM dbo.Mechanical
WHERE Horsepower = @hp
AND Torque = @torque
AND EngineSize = @engineSize
AND CylinderConfigId = @cylinderConfigId
AND CompressorId = @compressorId
AND AccelTime = @accelTime
AND Topspeed = @topSpeed
AND TowingCapability = @towing
AND AutoStopStart = @stopStart
AND BatteryType = @batteryType
AND MotorVoltage = @motorVoltage

RETURN @mechanicalId
END;
GO
--End Mechanical

--Cylinder Config
DROP FUNCTION IF EXISTS dbo.ReturnCylinderConfigId
GO

CREATE FUNCTION dbo.ReturnCylinderConfigId (@cylinderConfig nvarchar(50))
RETURNS INT 
AS
BEGIN;
DECLARE @cylinderConfigId INT;

SELECT @cylinderConfigId = CylinderConfigId 
FROM dbo.CylinderConfig
WHERE CylinderConfig = @cylinderConfig

RETURN @cylinderConfigId
END;
GO
--End Cylinder Config

--Compressor
DROP FUNCTION IF EXISTS dbo.ReturnCompressorId
GO

CREATE FUNCTION dbo.ReturnCompressorId (@compressor nvarchar(50))
RETURNS INT 
AS
BEGIN;
DECLARE @compressorId INT;

SELECT @compressorId = CompressorId 
FROM dbo.Compressor
WHERE CompressorType = @compressor

RETURN @compressorId
END;
GO
--End Compressor

--Vehicle
DROP PROCEDURE IF EXISTS dbo.InsertVehicle;
GO
DROP FUNCTION IF EXISTS ReturnVehicleId;
GO

CREATE OR ALTER PROCEDURE dbo.InsertVehicle (@modelId INT, @manuId INT, @bodyStyleId INT)
AS BEGIN 
SET XACT_ABORT ON;
IF NOT EXISTS 
(
SELECT * FROM dbo.Vehicle
WHERE ModelId = @modelId 
AND ManufacturerId = @manuId 
AND BodyStyleId = @bodyStyleId 
)
BEGIN;
INSERT INTO dbo.Vehicle (ModelId,ManufacturerId,BodyStyleId )
VALUES (@modelId,@manuId,@bodyStyleId)
END;
END;
GO

CREATE FUNCTION dbo.ReturnVehicleId (@modelId INT, @manuId INT, @bodyStyleId INT)
RETURNS INT 
AS
BEGIN;
DECLARE @vehicleId INT;

SELECT @vehicleId = VehicleId 
FROM dbo.Vehicle
WHERE ModelId = @modelId 
AND ManufacturerId = @manuId 
AND BodyStyleId = @bodyStyleId 

RETURN @vehicleId
END;
GO
--End Vehicle

--Model
DROP PROCEDURE IF EXISTS dbo.InsertModel;
GO
DROP FUNCTION IF EXISTS ReturnModelId;
GO

CREATE OR ALTER PROCEDURE dbo.InsertModel (@model nvarchar(150))
AS BEGIN 
SET XACT_ABORT ON;
IF NOT EXISTS 
(
SELECT * FROM dbo.Model
WHERE ModelName = @model 
)
BEGIN;
INSERT INTO dbo.Model (ModelName)
VALUES (@model)
END;
END;
GO

CREATE FUNCTION dbo.ReturnModelId (@model nvarchar(150))
RETURNS INT 
AS
BEGIN;
DECLARE @modelId INT;

SELECT @modelId = ModelId 
FROM dbo.Model
WHERE ModelName = @model

RETURN @modelId
END;
GO
--End Model

--Manufacturer
DROP PROCEDURE IF EXISTS dbo.InsertManufacturer;
GO
DROP FUNCTION IF EXISTS ReturnManufacturerId;
GO

CREATE OR ALTER PROCEDURE dbo.InsertManufacturer (@manu nvarchar(50))
AS BEGIN 
SET XACT_ABORT ON;
IF NOT EXISTS 
(
SELECT * FROM dbo.Manufacturer
WHERE ManufacturerName = @manu 
)
BEGIN;
INSERT INTO dbo.Manufacturer (ManufacturerName)
VALUES (@manu)
END;
END;
GO

CREATE FUNCTION dbo.ReturnManufacturerId (@manu nvarchar(50))
RETURNS INT 
AS
BEGIN;
DECLARE @manuId INT;

SELECT @manuId = ManufacturerId 
FROM dbo.Manufacturer
WHERE ManufacturerName = @manu

RETURN @manuId
END;
GO
--End Manufacturer

--BodyStyle
DROP PROCEDURE IF EXISTS dbo.InsertBodyStyle;
GO
DROP FUNCTION IF EXISTS ReturnBodyStyleId;
GO

CREATE OR ALTER PROCEDURE dbo.InsertBodyStyle (@body nvarchar(50))
AS BEGIN 
SET XACT_ABORT ON;
IF NOT EXISTS 
(
SELECT * FROM dbo.BodyStyle
WHERE BodyStyle = @body 
)
BEGIN;
INSERT INTO dbo.BodyStyle (BodyStyle)
VALUES (@body)
END;
END;
GO

CREATE FUNCTION dbo.ReturnBodyStyleId (@body nvarchar(50))
RETURNS INT 
AS
BEGIN;
DECLARE @bodyId INT;

SELECT @bodyId = BodyStyleId 
FROM dbo.BodyStyle
WHERE BodyStyle = @body 

RETURN @bodyId
END;
GO
--End BodyStyle

--ProductVaration
DROP PROCEDURE IF EXISTS dbo.InsertProductVariation 
Go

CREATE OR ALTER PROCEDURE dbo.InsertProductVariation 
(
@vehicleId INT,
@year INT,
@mSRPCad DECIMAL,
@mSRPUsd DECIMAL,
@pictureFile NVARCHAR(1000),
@pictureCitation NVARCHAR(1000),
@trimLevelId INT,
@dimensionId INT,
@exteriorId INT,
@infotainmentId INT,
@interiorId INT,
@powerTrainId INT,
@gearingId INT,
@economyId INT,
@driveTypeId INT,
@mechanicalId INT
)
AS BEGIN 
SET XACT_ABORT ON;
IF NOT EXISTS 
(
SELECT * FROM dbo.ProductVaration
WHERE VehicleId = @vehicleId 
AND ProductYear = @year
AND MSRPCad = @mSRPCad 
AND MSRPUsd = @mSRPUsd 
AND PictureFile = @pictureFile
AND PictureCitation = @pictureCitation
AND TrimLevelId = @trimLevelId 
AND DimensionId = @dimensionId 
AND ExteriorId = @exteriorId 
AND InfotainmentId = @infotainmentId 
AND InteriorId = @interiorId 
AND PowerTrainId = @powerTrainId 
AND GearingId = @gearingId 
AND EconomyId = @economyId 
AND DriveTypeId = @driveTypeId 
AND MechanicalId = @mechanicalId 
)
BEGIN;
INSERT INTO dbo.ProductVaration 
(
VehicleId,
ProductYear,
MSRPCad,
MSRPUsd,
PictureFile,
PictureCitation,
TrimLevelId,
DimensionId,
ExteriorId,
InfotainmentId,
InteriorId,
PowerTrainId,
GearingId,
EconomyId,
DriveTypeId,
MechanicalId
)
VALUES 
(@vehicleId,
@year,
@mSRPCad,
@mSRPUsd,
@pictureFile,
@pictureCitation,
@trimLevelId,
@dimensionId,
@exteriorId,
@infotainmentId,
@interiorId,
@powerTrainId,
@gearingId,
@economyId,
@driveTypeId,
@mechanicalId 

)
END;
END;
GO
--End ProductVaration
CREATE OR ALTER PROCEDURE dbo.InsertNotes (@vehicleId INT, @noteContent NVARCHAR(2000))
AS BEGIN 
SET XACT_ABORT ON;
IF NOT EXISTS 
(
SELECT * FROM dbo.Notes
WHERE VehicleId = @vehicleId
AND NoteContent = @noteContent
)
BEGIN;
INSERT INTO dbo.Notes (VehicleId,NoteContent )
VALUES (@vehicleId, @noteContent)
END;
END;
GO

