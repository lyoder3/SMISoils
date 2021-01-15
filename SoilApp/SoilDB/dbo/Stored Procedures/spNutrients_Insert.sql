-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spNutrients_Insert] 
	-- Add the parameters for the stored procedure here
	@QuantityName nvarchar(50),
	@UnitId int,
	@id int=0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	BEGIN TRANSACTION;
	UPDATE dbo.Nutrients 
	SET ItemName = @QuantityName, @UnitId = @UnitId
	WHERE 
		dbo.Nutrients.id = @id;
	IF @@ROWCOUNT = 0
	BEGIN
		INSERT INTO dbo.Nutrients (ItemName, UnitId) 
		VALUES (@QuantityName, @UnitId);

		SELECT @id = SCOPE_IDENTITY();
	END
	COMMIT TRANSACTION;
END
