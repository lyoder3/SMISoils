CREATE PROCEDURE [dbo].[spFieldsNutrients_Upsert]
	@FieldId int,
	@NutrientId int,
	@Amount decimal(10,5) = NULL,
	@Goal int = NULL,
	@SampleYear int = NULL,
	@id int=0 output
AS
	BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	BEGIN TRANSACTION
	UPDATE dbo.FieldsNutrients 
	SET Amount = @Amount, Goal = @Goal, LastSampledYear = @SampleYear
	WHERE 
		(dbo.FieldsNutrients.FieldId = @FieldId AND dbo.FieldsNutrients.NutrientId=@NutrientId);
	IF @@ROWCOUNT = 0
	BEGIN
		INSERT INTO dbo.FieldsNutrients (FieldId, NutrientId, Amount, Goal,LastSampledYear) 
		VALUES (@FieldId, @NutrientId, @Amount, @Goal, @SampleYear);
		SELECT @id = SCOPE_IDENTITY();
	END
	COMMIT TRANSACTION;
END