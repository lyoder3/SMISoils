CREATE PROCEDURE [dbo].[spLedger_Update]
	@FieldId int,
	@NutrientId int,
	@NewAmount decimal(8,3),
	@SoilSampleId int=NULL,
	@OperationId int=NULL,
	@id int=0 output
AS
BEGIN
	INSERT INTO dbo.FieldNutrientLedger(FieldId,NutrientId,NewAmount,SoilSampleId,OperationId)
	VALUES (@FieldId, @NutrientId, @NewAmount, @SoilSampleId, @OperationId);
	SELECT @id = SCOPE_IDENTITY();
END
