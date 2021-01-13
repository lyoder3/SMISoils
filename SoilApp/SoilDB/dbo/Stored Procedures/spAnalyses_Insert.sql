CREATE PROCEDURE [dbo].[spAnalyses_Insert]
	@AnalysisName nvarchar(50),
	@ProductId int,
	@id int=0 output
AS
BEGIN
	INSERT INTO dbo.Analyses (AnalysisName, ProductId)
	VALUES (@AnalysisName, @ProductId);

	SELECT @id = SCOPE_IDENTITY();
END
	
