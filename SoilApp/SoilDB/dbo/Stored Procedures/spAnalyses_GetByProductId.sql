CREATE PROCEDURE [dbo].[spAnalyses_GetByProductId]
	@ProductId int=NULL
AS
BEGIN
	SELECT * FROM Analyses
	WHERE (@ProductId is NULL OR Analyses.ProductId = @ProductId)
END	

