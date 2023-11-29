USE AutoDB;
GO 

CREATE OR ALTER PROCEDURE dbo.InsertNewVehicle (@ModelName VARCHAR(150),@ManufacturerName VARCHAR(50), @BodyStyle VARCHAR(50))
AS BEGIN 
SET XACT_ABORT ON;
SET NOCOUNT ON;

	BEGIN
		INSERT INTO Vehicle (ModelId,ManufacturerId,BodyStyleId)
		SELECT ModelId,ManufacturerId, BodyStyleId FROM dbo.Model,dbo.Manufacturer,dbo.BodyStyle
		WHERE ModelName = @ModelName 
		AND ManufacturerName = @ManufacturerName
		AND BodyStyle = @BodyStyle
		END;
	
END;

--ACURA--
EXECUTE dbo.InsertNewVehicle @ModelName = 'MDX', @ManufacturerName = 'Acura', @BodyStyle = 'SUV'
EXECUTE dbo.InsertNewVehicle @ModelName = 'RDX',@ManufacturerName = 'Acura', @BodyStyle = 'SUV'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Integra',@ManufacturerName = 'Acura', @BodyStyle = 'Sedan'
EXECUTE dbo.InsertNewVehicle @ModelName = 'TLX',@ManufacturerName = 'Acura', @BodyStyle = 'Sedan'
--Alfa Romeo--
EXECUTE dbo.InsertNewVehicle @ModelName = 'Stelvio',@ManufacturerName = 'Alfa Romeo', @BodyStyle = 'SUV'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Giulia',@ManufacturerName = 'Alfa Romeo', @BodyStyle = 'Sedan'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Tonale',@ManufacturerName = 'Alfa Romeo', @BodyStyle = 'SUV'
--Chevrolet--
EXECUTE dbo.InsertNewVehicle @ModelName = 'Trax',@ManufacturerName = 'Chevrolet', @BodyStyle = 'SUV'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Trailblazer',@ManufacturerName = 'Chevrolet', @BodyStyle = 'SUV'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Equinox',@ManufacturerName = 'Chevrolet', @BodyStyle = 'SUV'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Blazer',@ManufacturerName = 'Chevrolet', @BodyStyle = 'SUV'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Traverse',@ManufacturerName = 'Chevrolet', @BodyStyle = 'SUV'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Tahoe',@ManufacturerName = 'Chevrolet', @BodyStyle = 'SUV'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Suburban',@ManufacturerName = 'Chevrolet', @BodyStyle = 'SUV'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Colorado',@ManufacturerName = 'Chevrolet', @BodyStyle = 'Pickup-Truck'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Silverado 2500',@ManufacturerName = 'Chevrolet', @BodyStyle = 'Pickup-Truck'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Silverado 1500',@ManufacturerName = 'Chevrolet', @BodyStyle = 'Pickup-Truck'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Bolt EV',@ManufacturerName = 'Chevrolet', @BodyStyle = 'Sedan'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Bolt EUV',@ManufacturerName = 'Chevrolet', @BodyStyle = 'SUV'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Silverado 3500',@ManufacturerName = 'Chevrolet', @BodyStyle = 'Pickup-Truck'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Spark',@ManufacturerName = 'Chevrolet', @BodyStyle = 'Sedan'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Malibu',@ManufacturerName = 'Chevrolet', @BodyStyle = 'Sedan'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Corvette Z06',@ManufacturerName = 'Chevrolet', @BodyStyle = 'SportsCar'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Camaro',@ManufacturerName = 'Chevrolet', @BodyStyle = 'Coupe'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Corvette Stringray',@ManufacturerName = 'Chevrolet', @BodyStyle = 'SportsCar'
EXECUTE dbo.InsertNewVehicle @ModelName = 'Express',@ManufacturerName = 'Chevrolet', @BodyStyle = 'Van'


SELECT Model.ModelName, Manufacturer.ManufacturerName, BodyStyle.BodyStyle
FROM Vehicle
INNER JOIN Model On Model.ModelId = Vehicle.ModelId
INNER JOIN Manufacturer ON Manufacturer.ManufacturerId = Vehicle.ManufacturerId
INNER JOIN BodyStyle ON BodyStyle.BodyStyleId = Vehicle.BodyStyleId

SELECT * FROM Vehicle
