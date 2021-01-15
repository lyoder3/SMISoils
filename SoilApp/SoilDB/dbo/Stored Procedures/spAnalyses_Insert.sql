CREATE PROCEDURE [dbo].[spAnalyses_Insert]
	@ProductId int,
	@id int=0 output
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM dbo.Analyses WHERE @id = dbo.Analyses.id)
		BEGIN
			INSERT INTO dbo.Analyses (ProductId)
			VALUES (@ProductId);

			SELECT @id = SCOPE_IDENTITY();
		END
	ELSE
		BEGIN
			SELECT @id = @id
		END
END
	
