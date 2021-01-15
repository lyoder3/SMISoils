-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spProducts_Insert] 
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
	UPDATE dbo.Products 
	SET ItemName = @QuantityName, @UnitId = @UnitId
	WHERE 
		dbo.Products.id = @id;
	IF @@ROWCOUNT = 0
	BEGIN
		INSERT INTO dbo.Products (ItemName, UnitId) 
		VALUES (@QuantityName, @UnitId);

		SELECT @id = SCOPE_IDENTITY();
	END
	COMMIT TRANSACTION;
END
