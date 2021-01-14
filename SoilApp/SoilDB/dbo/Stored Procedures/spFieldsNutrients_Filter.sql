CREATE PROCEDURE [dbo].[spFieldsNutrients_Filter]
	@Farm nvarchar(25) = NULL,
	@RotationYear int,
	@CropId int = NULL,
	@NutrientId int = NULL
AS
BEGIN
	SELECT f.Farm, f.Field, n.ItemName as Nutrient, fn.Amount,fn.Goal, fn.LastSampledYear, p.ItemName as Crop
	FROM dbo.FieldsNutrients fn
	INNER JOIN dbo.Nutrients n on fn.NutrientId = n.id
	INNER JOIN dbo.Fields f on fn.FieldId = f.id
	INNER JOIN dbo.Rotations r on r.FieldId = fn.FieldId
	INNER JOIN dbo.Products p on r.ProductId = p.id
	WHERE 
	(@Farm is NULL or f.Farm = @Farm)
	AND (@RotationYear = r.RotationYear)
	AND (@CropId IS NULL OR r.ProductId = @CropId)
	AND (@NutrientId IS NULL or fn.NutrientId = @NutrientId)
END
