USE AutoDB;
GO 

CREATE OR ALTER PROCEDURE dbo.InsertNewVehicle (@ModelName VARCHAR(150),@ManufacturerName VARCHAR(50), @BodyStyle VARCHAR(50))
AS BEGIN 
SET XACT_ABORT ON;
SET NOCOUNT ON;
IF EXISTS (SELECT ModelName FROM dbo.Model WHERE ModelName = @ModelName)
AND EXISTS(SELECT ManufacturerName FROM dbo.Manufacturer WHERE ManufacturerName = @ManufacturerName)
AND EXISTS (SELECT BodyStyle FROM dbo.BodyStyle WHERE BodyStyle = @BodyStyle)
	BEGIN
	IF NOT EXISTS (SELECT Vehicle.ModelId FROM dbo.Vehicle INNER JOIN dbo.Model ON Vehicle.ModelId = Model.ModelId WHERE Model.ModelName = @ModelName)
	OR NOT EXISTS (SELECT Vehicle.ManufacturerId FROM dbo.Vehicle INNER JOIN dbo.Manufacturer 
	ON Vehicle.ManufacturerId = Manufacturer.ManufacturerId WHERE Manufacturer.ManufacturerName = @ManufacturerName )
	OR NOT EXISTS (SELECT Vehicle.BodyStyleId FROM dbo.Vehicle INNER JOIN dbo.BodyStyle ON Vehicle.BodyStyleId = BodyStyle.BodyStyleId 
	WHERE BodyStyle.BodyStyle = @BodyStyle)
	BEGIN
		INSERT INTO Vehicle (ModelId,ManufacturerId,BodyStyleId)
		SELECT ModelId,ManufacturerId, BodyStyleId FROM dbo.Model,dbo.Manufacturer,dbo.BodyStyle
		WHERE ModelName = @ModelName 
		AND ManufacturerName = @ManufacturerName
		AND BodyStyle = @BodyStyle
		END;
		ELSE
		BEGIN
		PRINT 'Model/Manufacturer Already In Database'
		END;
	END;
ELSE
	BEGIN
		PRINT 'Model/Manufacturer Not In Database'
	END;
END;

EXECUTE dbo.InsertNewVehicle @ModelName = 'MDX', @ManufacturerName = 'Acura', @BodyStyle = 'SUV'
EXECUTE dbo.InsertNewVehicle @ModelName = 'RDX',@ManufacturerName = 'Acura', @BodyStyle = 'SUV'

SELECT * FROM Vehicle
SELECT * FROM model WHERE ModelName = 'RDX'
DELETE FROM Model WHERE ModelName = 'RDX'

DELETE FROM Vehicle

SELECT Model.ModelName, Manufacturer.ManufacturerName, BodyStyle.BodyStyle
FROM Vehicle
INNER JOIN Model On Model.ModelId = Vehicle.ModelId
INNER JOIN Manufacturer ON Manufacturer.ManufacturerId = Vehicle.ManufacturerId
INNER JOIN BodyStyle ON BodyStyle.BodyStyleId = Vehicle.BodyStyleId