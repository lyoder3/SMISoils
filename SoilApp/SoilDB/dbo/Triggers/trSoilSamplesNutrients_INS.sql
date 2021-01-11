CREATE TRIGGER [dbo].[trSoilSamplesNutrients_INS]
	ON [dbo].[SoilSamplesNutrients]
	AFTER INSERT
	AS
	BEGIN
		DECLARE @SampleId INT
		DECLARE @Amount decimal(8,3)
		DECLARE @Goal int
		DECLARE @NutrientId int
		DECLARE @FieldId int

		SELECT @SampleId = (SELECT i.SampleId from inserted i);
		SELECT @NutrientId = (SELECT i.NutrientId from inserted i);
		SELECT @Amount = (SELECT i.Amount from inserted i);
		SELECT @Goal = (SELECT i.Goal from inserted i);


		SELECT @FieldId = (SELECT ss.FieldId 
						from dbo.SoilSamples ss 
						inner join inserted i on i.SampleId = ss.id)


		SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
		BEGIN TRANSACTION;
		UPDATE dbo.FieldsNutrients 
		SET [dbo].[FieldsNutrients].[Amount] = @Amount, [dbo].[FieldsNutrients].[Goal] = @Goal
		FROM inserted i
		INNER JOIN [dbo].[SoilSamples] on @SampleId = [dbo].[SoilSamples].[id]
		WHERE [dbo].[FieldsNutrients].[FieldId] = @FieldId

		IF @@ROWCOUNT = 0
		BEGIN
			INSERT INTO dbo.FieldsNutrients (FieldId, NutrientId, Amount, Goal)
			VALUES (@FieldId, @NutrientId, @Amount, @Goal)
		END
		COMMIT TRANSACTION;
		
END