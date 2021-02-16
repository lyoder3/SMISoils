CREATE PROCEDURE [dbo].[spAnalysisNutrients_GetByAnalysisId]
	@id int
AS
BEGIN
	SELECT AnalysisId as Id, NutrientId, Amount FROM dbo.AnalysesNutrients WHERE dbo.AnalysesNutrients.AnalysisId = @id
END
