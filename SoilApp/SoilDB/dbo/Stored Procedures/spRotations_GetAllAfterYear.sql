
CREATE PROCEDURE [dbo].[spRotations_GetAllAfterYear] 
	-- Add the parameters for the stored procedure here
	@Year int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT f.*, r.Year, p.ItemName, u.Unit 
	from Fields f
	inner join [dbo].[Rotations] r on r.FieldId = f.id
	inner join [dbo].[DimensionedQuantities] p on p.id = r.ProductId
	inner join [dbo].[Units] u on u.id = p.UnitId
	WHERE r.Year >= @Year;
END
