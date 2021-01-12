-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSoilSamplesNutrients_Insert] 
	-- Add the parameters for the stored procedure here
	@SoilSampleId int,
	@NutrientId int,
	@Amount decimal(8,3),
	@Goal int,
	@Id int=0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	INSERT INTO dbo.SoilSamplesNutrients(SampleId, NutrientId, Amount, Goal)
	VALUES (@SoilSampleId, @NutrientId, @Amount, @Goal);

	SELECT @Id = SCOPE_IDENTITY();
	
END