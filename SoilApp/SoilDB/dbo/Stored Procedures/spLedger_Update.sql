CREATE PROCEDURE [dbo].[spLedger_Update]
	@FieldId int,
	@NutrientId int,
	@Change decimal(8,3),
	@SoilSampleId int NULL,
	@OperationId int NULL,
	@id int=0 output
AS
BEGIN
	INSERT INTO dbo.FieldNutrientLedger(FieldId,NutrientId,Change,SoilSampleId,OperationId)
	VALUES (@FieldId, @NutrientId, @Change, @SoilSampleId, @OperationId);
	SELECT @id = SCOPE_IDENTITY();
END
