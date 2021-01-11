
CREATE PROCEDURE [dbo].[spFields_Upsert] 
	-- Add the parameters for the stored procedure here
	@FarmName varchar(25),
	@Field char(3),
	@id int=0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	BEGIN TRANSACTION;
	UPDATE dbo.Fields SET Farm = @FarmName, Field=@Field WHERE dbo.Fields.id = @id;
	IF @@ROWCOUNT = 0
	BEGIN
		INSERT INTO dbo.Fields (Farm, Field) VALUES (@FarmName, @Field);
		SELECT @id = SCOPE_IDENTITY();
	END
	COMMIT TRANSACTION;
END
