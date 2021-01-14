CREATE PROCEDURE [dbo].[spFields_GetByFarm]
	@FarmName nvarchar(25)
AS
BEGIN
	SELECT * from dbo.Fields WHERE dbo.Fields.Farm = @FarmName
END
