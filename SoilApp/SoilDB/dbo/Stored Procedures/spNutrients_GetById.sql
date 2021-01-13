CREATE PROCEDURE [dbo].[spNutrients_GetById]
	@NutrientId int
AS
BEGIN
	SELECT * FROM Nutrients
	WHERE (Nutrients.id = @NutrientId)
END	

