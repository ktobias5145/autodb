-- Basic Data Insertion Without Vehicles
-- 2023-08-12

--Transmission Values
DELETE FROM TransmissionType

INSERT INTO TransmissionType (TransmissionType)
VALUES ('Manual')

INSERT INTO TransmissionType (TransmissionType)
VALUES ('Automatic')

INSERT INTO TransmissionType (TransmissionType)
VALUES ('Automated Manual')

INSERT INTO TransmissionType (TransmissionType)
VALUES ('Continuously Variable')

INSERT INTO TransmissionType (TransmissionType)
VALUES ('N/A')

SELECT * FROM TransmissionType

--Power Train Values

DELETE FROM PowerTrain

INSERT INTO PowerTrain (PowerTrainType)
VALUES ('Diesel')

INSERT INTO PowerTrain (PowerTrainType)
VALUES ('Gasoline')

INSERT INTO PowerTrain (PowerTrainType)
VALUES ('Battery Electric')

INSERT INTO PowerTrain (PowerTrainType)
VALUES ('Plug In Hybrid')

INSERT INTO PowerTrain (PowerTrainType)
VALUES ('Hybrid')

INSERT INTO PowerTrain (PowerTrainType)
VALUES ('Mild Hybrid')

INSERT INTO PowerTrain (PowerTrainType)
VALUES ('Fuel Cell Electric')

SELECT * FROM PowerTrain

--Big Boy: Manufacturers

DELETE FROM Manufacturer

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Acura')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Alfa Romeo')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Aston Martin')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Audi')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('BMW')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Bentley-Motors')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Bollinger-Motors')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Bugatti')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Buick')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Cadillac')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Chevrolet')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Chrysler')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Dodge')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Ferrari')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Fiat')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Fisker')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Ford')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('GMC')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Genesis')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Honda')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Hyundai')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Infiniti')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Jaguar')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Jeep')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Karma')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Kia')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Lamborghini')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Land Rover')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Lexus')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Lincoln')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Lordstown-Motors')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Lotus')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Lucid-Motors')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Maserati')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Mazda')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Mclaren')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Mercedes-Benz')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Mini')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Mitsubishi')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Nissan')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Polestar')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Porsche')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Ram')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Rivian')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Rolls-Royce')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Subaru')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Tesla')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Toyota')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Volkswagen')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Vinfast')

INSERT INTO Manufacturer (ManufacturerName)
VALUES ('Volvo')

SELECT * FROM Manufacturer

--Drive Type

DELETE FROM DriveType

INSERT INTO DriveType (DriveType)
VALUES ('AWD')

INSERT INTO DriveType (DriveType)
VALUES ('FWD')

INSERT INTO DriveType (DriveType)
VALUES ('RWD')

INSERT INTO DriveType (DriveType)
VALUES ('4WD')

SELECT * FROM DriveType

--Cylinder Configurations
DELETE FROM CylinderConfig

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('Inline-2')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('Inline-3')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('Inline-4')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('Inline-5')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('Inline-6')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('Inline-8')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('V2')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('V3')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('V4')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('V6')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('V8')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('V10')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('V12')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('VR5')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('VR6')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('Flat-2')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('Flat-4')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('Flat-6')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('Flat-8')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('Flat-12')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('W8')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('W12')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('W16')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('Rotary')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('Electric-Motor')

INSERT INTO CylinderConfig (CylinderConfig)
VALUES ('N/A')

SELECT * FROM CylinderConfig

--Compressor Types

DELETE FROM Compressor

INSERT INTO Compressor (CompressorType)
VALUES ('Naturally Aspirated')

INSERT INTO Compressor (CompressorType)
VALUES ('TurboCharged')

INSERT INTO Compressor (CompressorType)
VALUES ('SuperCharged')

INSERT INTO Compressor (CompressorType)
VALUES ('N/A')

SELECT * FROM Compressor

--Body Stype
DELETE FROM BodyStyle

INSERT INTO BodyStyle (BodyStyle)
VALUES ('SUV')

INSERT INTO BodyStyle (BodyStyle)
VALUES ('Sedan')

INSERT INTO BodyStyle (BodyStyle)
VALUES ('Station-Wagon')

INSERT INTO BodyStyle (BodyStyle)
VALUES ('Coupe')

INSERT INTO BodyStyle (BodyStyle)
VALUES ('SportsCar')

INSERT INTO BodyStyle (BodyStyle)
VALUES ('HatchBack')

INSERT INTO BodyStyle (BodyStyle)
VALUES ('Convertible')

INSERT INTO BodyStyle (BodyStyle)
VALUES ('MiniVan')

INSERT INTO BodyStyle (BodyStyle)
VALUES ('Pickup-Truck')

INSERT INTO BodyStyle (BodyStyle)
VALUES ('Van')

SELECT * FROM BodyStyle