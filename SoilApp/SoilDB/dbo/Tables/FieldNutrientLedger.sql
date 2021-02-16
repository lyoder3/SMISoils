CREATE TABLE [dbo].[FieldNutrientLedger]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [FieldId] INT NOT NULL, 
    [NutrientId] INT NOT NULL, 
    [NewAmount] DECIMAL(8, 3) NOT NULL, 
    [SoilSampleId] INT NULL, 
    [OperationId] INT NULL
)
