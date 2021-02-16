CREATE PROCEDURE [dbo].[spFieldsNutrients_GetByIds]
	@FieldId int,
	@NutrientId int NULL
AS
BEGIN
	SELECT fn.id as Id, fn.FieldId, NutrientId, Amount
	FROM dbo.FieldsNutrients fn
	WHERE fn.FieldId = @FieldId AND fn.NutrientId = @NutrientId;
END
