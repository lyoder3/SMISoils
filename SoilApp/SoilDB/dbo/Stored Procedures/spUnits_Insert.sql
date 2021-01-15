-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUnits_Insert] 
	-- Add the parameters for the stored procedure here
	@Unit varchar(20),
	@id int=0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	  SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	BEGIN TRANSACTION;
	UPDATE dbo.Units
	SET Unit = @Unit
	WHERE 
		dbo.Units.id = @id;
	IF @@ROWCOUNT = 0
	BEGIN
		INSERT INTO dbo.Units (Unit) 
		VALUES (@Unit);

		SELECT @id = SCOPE_IDENTITY();
	END
	COMMIT TRANSACTION;
END
