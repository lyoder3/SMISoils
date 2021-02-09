CREATE PROCEDURE [dbo].[spOperations_Insert]
	@FieldId int,
	@AnalysisId int,
	@Timestamp datetime2,
	@AmountApplied decimal(10,3),
	@id int=0 output
AS
BEGIN
	INSERT INTO dbo.Operations (FieldId, AnalysisId, Amount, dbo.Operations.Timestamp)
	VALUES (@FieldId, @AnalysisId, @AmountApplied, @Timestamp);
	SELECT @id = SCOPE_IDENTITY();
END