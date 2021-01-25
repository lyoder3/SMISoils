CREATE PROCEDURE [dbo].[spFieldsNutrients_GetByIds]
	@FieldId int,
	@NutrientId int
AS
BEGIN
	SELECT *
	FROM dbo.FieldsNutrients fn
	WHERE fn.FieldId = @FieldId AND fn.NutrientId = @NutrientId;
END
