-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSoilSamples_Insert]
	-- Add the parameters for the stored procedure here
	@FieldId int,
	@SampleYear int,
	@id int=0 output 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF NOT EXISTS (SELECT * FROM dbo.SoilSamples WHERE FieldId = @FieldId AND SampleYear = @SampleYear)
		BEGIN
			INSERT INTO dbo.SoilSamples (FieldId, SampleYear)
			VALUES (@FieldId, @SampleYear);

			SELECT @id = SCOPE_IDENTITY();
		END
	ELSE
		BEGIN
			SELECT @id = (SELECT dbo.SoilSamples.id FROM dbo.SoilSamples WHERE FieldId = @FieldId AND SampleYear = @SampleYear)
		END
END
