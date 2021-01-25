
CREATE PROCEDURE [dbo].[spFields_Upsert] 
	-- Add the parameters for the stored procedure here
	@FarmName varchar(25),
	@Field char(3),
	@Acreage decimal(8,3),
	@id int=0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	BEGIN TRANSACTION;
	UPDATE dbo.Fields SET Farm = @FarmName, Field=@Field, Acreage = @Acreage WHERE dbo.Fields.id = @id;
	IF @@ROWCOUNT = 0
	BEGIN
		INSERT INTO dbo.Fields (Farm, Field, Acreage) VALUES (@FarmName, @Field, @Acreage);
		SELECT @id = SCOPE_IDENTITY();
	END
	COMMIT TRANSACTION;
END
