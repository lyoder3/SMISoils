﻿
CREATE PROCEDURE [dbo].[spRotations_Upsert] 
	-- Add the parameters for the stored procedure here
	@FieldId int,
	@ProductId int,
	@RotationYear int,
	@id int=0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	BEGIN TRANSACTION;
	UPDATE dbo.Rotations SET ProductId=@ProductId WHERE 
		dbo.Rotations.FieldId= @FieldId AND dbo.Rotations.RotationYear = @RotationYear;
	IF @@ROWCOUNT = 0
	BEGIN
		INSERT INTO dbo.Rotations (FieldId, ProductId, RotationYear) VALUES (@FieldId, @ProductId, @RotationYear);
		SELECT @id = SCOPE_IDENTITY();
	END
	COMMIT TRANSACTION;
END
