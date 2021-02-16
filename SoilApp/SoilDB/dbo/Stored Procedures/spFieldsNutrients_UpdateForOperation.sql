CREATE PROCEDURE [dbo].[spFieldsNutrients_UpdateForOperation]
	@id int,
	@Amount decimal(8,3)
AS
BEGIN
	UPDATE dbo.FieldsNutrients
	SET dbo.FieldsNutrients.Amount = @Amount WHERE dbo.FieldsNutrients.id = @id;
END