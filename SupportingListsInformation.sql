USE AutoDB;
GO 

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

--MODELS

DELETE FROM Model

INSERT INTO Model (ModelName)
VALUES 
--ACURA--
('MDX'),('RDX'),('Integra'),('TLX'),
--Alfa Romeo--
('Stelvio'),('Giulia'),('Tonale'),
--Aston Martin--
('DBX'),('Vantage'),('DB11'),('DBS'),('Valhalla'),('Valkyrie'),
--Audi--
('e-tron'),('e-tron Sportback'),('e-tron GT Quattro'),('RS e-tron GT Quattro'),('Q3'),('Q4 e-tron'),('Q4 e-tron Sportback'),('Q5'),
('Q5 Sportback'), ('Q5 TFSI'),('SQ5'),('SQ5 Sportback'),('Q7'),('SQ7'),('Q8'),('SQ8'),('RS Q8'),('A3'),('S3'),('A4'),
('A4 Allroad'),('S4'),('A5 Coupe'),('S5 Coupe'),('RS5 Coupe'),('A5 Sportback'),('S5 Sportback'),('RS5 Sportback'),
('A5 Cabriolet'),('S5 Cabriolet'),('A6 Sedan'),('S6 Sedan'),('A6 Allroad'),('RS6 Avant'),('A7 Sportback'),
('S7 Sportback'),('RS7 Sportback'),('A8'),('S8'),('TT Coupe'),('TTS Coupe'),('TT Roadster'),('R8 Coupe'),('R8 Spyder'),
--BMW--
('iX'),('i7'),('i4 Gran Coupe'),('XM'),('X7'),('X6'),('X5'),('X4'),('X3'),('X1'),
('X6 M'),('X5 M'),('X4 M'),('X3 M'),('M8 Gran Coupe'),('M8 Cabriolet'),('M8 Coupe'),
('M5 Competition'),('M4 Convertible'),('M4 Coupe'),('M4 CSL'),('M3 CS'),('M3 Competition Sedan'),
('M2 Coupe'),('8 Series Gran Coupe'),('8 Series Coupe'),('8 Series Cabriolet'),('Alpina B8 Gran Coupe'),
('760i xDrive'),('5 Series Sedan'),('5 Series PHEV'),('4 Series Coupe'),('4 Series Cabriolet'),
('3 Series Sedan'),('3 Series PHEV'),('2 Series Coupe'),('Z4 Roadster')

INSERT INTO Model (ModelName)
VALUES 
--Bentley--
('Bentayga EWB'),('Bentayga'),('Flying Spur'),('Continental Gt'),('Continental GTC'),('Mulliner'),

--Bollinger Motors--
('B1'),('B2'),

--Bugatti--
('Chiron'),('W16 Mistral'),

--Buick--
('Encore GX'),('Encore GX ST'),('Envision'),('Envision ST'),('Envision Avenir'),
('Enclave'),('Enclave ST'),('Enclave Avenir'),

--Cadillac--
('Lyriq'),('Celstiq'),('CT4'),('CT4-V'),('CT4-V Blackwing'),('CT5'),('CT5-V'),('CT5-V Blackwing'),
('XT4'),('XT5'),('XT6'),('Escalade'),('Escalade-V'),

--Chevrolet--
('Trax'),('Trailblazer'),('Equinox'),('Blazer'),('Traverse'),('Tahoe'),('Suburban'),('Colorado'),
('Silverado 2500'),('Silverado 1500'),('Bolt EV'),('Bolt EUV'),('Silverado 3500'),('Spark'),
('Malibu'),('Corvette Z06'),('Camaro'),('Corvette Stringray'),('Express'),

--Chrysler--
('Grand Caravan'),('Pacifica'),('Pacifica Hybrid'),('300')

INSERT INTO Model (ModelName)
VALUES 
--Dodge--
('Durango'),('Challenger'),('Charger'),('Hornet'),

--Ferrari--
('Purosangue'),('812 GTS'),('296 GTB'),('296 GTS'),('SF90 Stradale'),('SF90 Spider'),
('F8 Tributo'),('F8 Spider'),('Roma'),('Portofino M'),('812 Competizione'),('812 Competizione A'),
('Daytona SP3'),('Monza SP1'),('Monza SP2'),

--Fiat--
('500X'),

--Fisker--
('Ocean'),

--Ford--
('Edge ST'),('Explorer ST'),('F-150 Raptor'),('Mustang Shelby GT500'),('GT'),('Ecosport'),('Escape'),
('Bronco Sport'),('Edge'),('Bronco'),('Explorer'),('Mustang Mach-E'),('Expedition'),('Maverick'),
('Transit Connect'),('Ranger'),('F-150'),('Transit'),('Super Duty F-250'),('Super Duty F-350'),('Super Duty F-450'),
('F-150 Lightning'),('Escape St-Line Elite Hybrid'),('Escape Plug-In Hybrid'),('Explorer Limited'),
('E-Transit'),('F-150 Limited'),('Mustang'),

--GMC--
('Canyon'),('Sierra 1500'),('Sierra HD 2500'),('Sierra HD 3500'),('Acadia'),('Terrain'),('Yukon'),
('Hummer EV Pickup'),('Hummer EV SUV'),('Savana Passenger'),('Savana Cargo')

INSERT INTO Model (ModelName)
VALUES 
--Genesis--
('G70'),('G80'),('G90'),('GV60'),('GV70'),('GV80'),

--Honda--
('Civic Sedan'),('Civic Si'),('Civic Hatchback'),('Civic Type R'),('Accord'),('HR-V'),
('CR-V'),('Passport'),('Pilot'),('Odyssey'),('Ridgeline'),

--Hyundai--
('Tucson'),('Santa Fe'),('Palisade'),('Ioniq 5'),('Santa Cruz'),('Kona'),
('Venue'),('Nexo'),('Elantra'),('Sonata'),

--Infiniti--
('Q50'),('Q60'),('QX50'),('QX55'),('QX60'),('QX80'),

--Jaguar--
('E-Pace'),('F-Pace'),('I-Pace'),('F-Type'),('XF'),

--Jeep--
('Grand Cherokee'),('Grand Cherokee L'),('Wrangler 4xe'),('Wrangler'),('Gladiator'),('Cherokee'),
('Compass'),('Grand Cherokee WK'),('Renegade'),('Wagoneer'),('Grand Wagoneer'),

--Karma--
('GS-6'),

--KIA--
('Niro'),('Telluride'),('Sportage'),('Carnival'),('Sorento'),('Forte'),
('Seltos'),('Stinger'),('Rio'),('Forte5'),('K5'),('Soul'),('EV6')

INSERT INTO Model (ModelName)
VALUES 
--Lamborghini--
('Aventador'),('Huracan'),('Urus'),('Countach LPI 800-4'),('Sian FKP 37'),('Sian Roadster'),

--Land Rover--
('Range Rover'),('Range Rover Sport'),('Range Rover Velar'),('Range Rover Evoque'),
('Defender'),('Discovery'),('Discovery Sport'),

--Lexus--
('IS'),('RC'),('RC F'),('ES'),('LC'),('LC Convertible'),('LS'),('UXh'),
('NX'),('RZ'),('RX'),('GX'),('LX'),

--Lincoln--
('Navigator'),('Aviator'),('Nautilus'),('Corsair'),

--Lordstown Motors--
('Endurance'),

--Lotus--
('Eletre'),('Emira'),('Evija'),

--Lucid--
('Air'),('Gravity'),

--Maserati--
('Grecale'),('Ghibli'),('Levante'),('Quattroporte'),('GranTurismo MC20'),('MC20 Cielo'),

--Mazda--
('CX-90'),('CX-50'),('MX-30 EV'),('3'),('3 Sport'),('CX-30'),('CX-5'),('CX-9'),('MX-5 Soft Top'),('MX-5 RF'),

--Mclaren--
('GT'),('765LT Spider'),('765LT'),('720S Spider'),('720S'),('Artura'),('Elva Senna GTR'),('SpeedTail'),('Senna'),('Solus GT')

INSERT INTO Model (ModelName)
VALUES 
--Mercedes-Benz--
('GLA'),('GLB'),('GLC SUV'),('GLC Coupe'),('GLE SUV'),('EQB'),('GLE Coupe'),('GLS'),('EQS SUV'),('G-Class'),
('Maybach GLS'),('A-Class Hatch'),('A-Class Sedan'),('C-Class Sedan'),('E-Class Sedan'),('S-Class Sedan'),
('EQS Sedan'),('Maybach S-Class'),('E-Class Wagon'),('CLA Coupe'),('C-Class Coupe'),('E-Class Coupe'),
('CLS Coupe'),('AMG GT 4 Door Coupe'),('C-Class Cabriolet'),('E-Class Cabriolet'),('SL Roadster'),

--Mini--
('Electric'),('Cooper 3 Door'),('Cooper 5 Door'),('Countryman'),('Cooper Convertible'),('John Cooper Works'),

--Mitsubishi--
('Outlander PHEV'),('Outlander'),('Eclipse Cross'),('RVR'),('Mirage'),

--Nissan--
('Versa'),('Sentra'),('Altima'),('Maxima'),('Ariya'),('Leaf'),('GT-R'),('Z'),('Kicks'),
('Qashqai'),('Rogue'),('Murano'),('Pathfinder'),('Armada'),('Frontier'),

--Polestar--
('Polestar 1'),('Polestar 2'),('Polestar 3'),

--Porsche--
('718'),('911'),('Taycan'),('Panamera'),('Macan'),('Cayenne')

INSERT INTO Model (ModelName)
VALUES 
--Ram--
('Ram 1500'),('Ram 1500 Classic'),('Ram 2500'),('Ram 3500'),('Promaster'),('Promaster City'),

--Rivian--
('R1T'),('R1S'),

--Rolls Royce--
('Phantom'),('Phantom Extended'),('Spectre'),('Ghost'),('Ghost Extended'),('Cullinan'),('Wraith'),('Dawn'),

--Subaru--
('Solterra'),('Ascent'),('Outback'),('Forester'),('Crosstrek'),('Impreza'),('Legacy'),('BRZ'),('WRX'),

--Tesla--
('Model S'),('Model 3'),('Model X'),('Model Y'),

--Toyota--
('GR86'),('GR Corolla'),('GR Supra'),('Prius'),('Prius Prime'),('Corolla Hatchback'),('Corolla'),('Camry'),
('Mirai'),('Crown'),('bZ4X'),('Corolla Cross'),('Corolla Cross Hybrid'),('Rav4'),('Rav4 Prime'),('Venza'),
('Highlander'),('Grand Highlander'),('Sienna'),('4Runner'),('Sequoia'),('Tacoma'),('Tundra'),

--Volkswagen--
('ID.4'),('Atlas'),('Atlas Cross Sport'),('Tiguan'),('Taos'),('Golf GTI'),('Golf R'),('Jetta'),('Jetta GLI'),

--Vinfast
('VF8'),('VF9'),

--Volvo--
('XC90'),('XC60'),('XC40'),('S90'),('S60'),('V60'),('V60 Cross Country'),('V90 Cross Country'),('XC90 Recharge'),
('XC60 Recharge'),('S90 Recharge'),('S60 Recharge'),('V60 Recharge'),('C40 Recharge')



SELECT COUNT (*) FROM Model