CREATE TABLE [dbo].[FieldNutrientLedger]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FieldId] INT NOT NULL, 
    [NutrientId] INT NOT NULL, 
    [Change] DECIMAL(8, 3) NOT NULL, 
    [SoilSampleId] INT NULL, 
    [OperationId] INT NULL
)
