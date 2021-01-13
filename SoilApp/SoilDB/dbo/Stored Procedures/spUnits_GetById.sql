CREATE PROCEDURE [dbo].[spUnits_GetById]
	@UnitId int
AS
BEGIN
	SELECT * FROM Units
	WHERE (Units.id = @UnitId)
END	

