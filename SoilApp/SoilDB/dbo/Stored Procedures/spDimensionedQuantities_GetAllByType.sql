-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spDimensionedQuantities_GetAllByType] 
	-- Add the parameters for the stored procedure here
	@TypeId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT dq.* 
	from dbo.DimensionedQuantities dq
	inner join dbo.DimensionedTypes dt on dt.id = dq.TypeId
	inner join dbo.Units u on u.id = dq.UnitId
	where dt.id = @TypeId
END
