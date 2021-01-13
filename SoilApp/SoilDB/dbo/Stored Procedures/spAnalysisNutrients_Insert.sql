CREATE PROCEDURE [dbo].[spAnalysisNutrients_Insert]
	@AnalysisId int,
	@NutrientId int,
	@Amount decimal(8,3),
	@id int=0 output
AS
BEGIN
	INSERT INTO dbo.AnalysesNutrients (AnalysisId,NutrientId, Amount)
	VALUES (@AnalysisId, @NutrientId, @Amount);

	SELECT @id = SCOPE_IDENTITY();
END
