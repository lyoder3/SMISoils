CREATE PROCEDURE [dbo].[spFields_FilterForUpcomingSamples]
	@Farm nvarchar(50)=NULL,
	@Field nvarchar(50)=NULL,
	@LastSampleYear int=NULL,
	@RotationYear int=NULL,
	@Crop nvarchar(50)=NULL
AS
BEGIN
	SELECT f.Farm, f.Field, LastSampled, p.ItemName as Crop
	FROM dbo.Fields f
	INNER JOIN (SELECT f.id, ISNULL(MAX(ss.SampleYear), 1900) as LastSampled
	FROM dbo.Fields f
	LEFT JOIN dbo.SoilSamples ss on ss.FieldId = f.id
	GROUP BY f.id) ssmax on ssmax.id = f.id
	INNER JOIN dbo.Rotations r on r.FieldId = f.id
	INNER JOIN dbo.Products p on p.id = r.ProductId
	WHERE (@RotationYear = r.RotationYear) 
	AND (@Farm IS NULL OR @Farm = f.Farm)
	AND (@Field IS NULL OR @Field = f.Field)
	AND (@LastSampleYear IS NULL OR @LastSampleYear >= LastSampled)
	AND (@Crop is NULL OR @Crop = p.ItemName)
END
