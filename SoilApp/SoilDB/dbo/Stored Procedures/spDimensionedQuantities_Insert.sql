-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spDimensionedQuantities_Insert]
	-- Add the parameters for the stored procedure here
	@QuantityName varchar(50),
	@UnitId int,
	@TypeId int,
	@id int=0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.DimensionedQuantities (ItemName, UnitId, TypeId) VALUES (@QuantityName, @UnitId, @TypeId);

	SELECT @id = SCOPE_IDENTITY();
END
