CREATE PROCEDURE [dbo].[spSoilSamplesNutrients_GetFieldIdAndSampleYear]
	@SoilSampleId int,
	@FieldId int=0 output,
	@SampleYear int=0 output
AS
BEGIN
	SELECT @FieldId = ss.FieldId, @SampleYear = ss.SampleYear
	FROM dbo.SoilSamples ss
	WHERE ss.id = @SoilSampleId
END