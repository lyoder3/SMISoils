-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spDimensionedTypes_GetByName] 
	-- Add the parameters for the stored procedure here
	@Type varchar(50),
	@id int=0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SET @id = (SELECT id from dbo.DimensionedTypes where Type = @Type);
END
