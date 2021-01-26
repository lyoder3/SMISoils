CREATE PROCEDURE [dbo].[spFieldsNutrients_Filter]
	@Farm nvarchar(25) = NULL,
	@RotationYear int,
	@CropId int = NULL,
	@NutrientId int = NULL
AS
BEGIN
SELECT lastCrop.id, 
	lastCrop.Farm, 
	lastCrop.Field, 
	lastCrop.Acreage,
	n.ItemName as Nutrient, 
	fn.Amount,
	fn.Goal,
	fn.LastSampledYear as LastSampled,
	lastCrop.LastCrop, 
	p.ItemName as UpcomingCrop
FROM dbo.FieldsNutrients fn
INNER JOIN 
	(SELECT f.id, f.Farm, f.Field, f.Acreage, r.RotationYear, p.ItemName as LastCrop
	FROM dbo.Fields f
	INNER JOIN dbo.Rotations r on r.FieldId = f.id
	INNER JOIN dbo.Products p on r.ProductId = p.id
	WHERE (r.RotationYear = @RotationYear - 1)) lastCrop on fn.FieldId = lastCrop.id
	INNER JOIN dbo.Nutrients n on n.id = fn.NutrientId
	INNER JOIN dbo.Rotations r on fn.FieldId = r.FieldId
	INNER JOIN dbo.Products p on r.ProductId = p.id
	WHERE (r.RotationYear = @RotationYear)
	AND (@CropId IS NULL or p.id = @CropId)
	AND (@NutrientId IS NULL or n.id = @NutrientId);
END
