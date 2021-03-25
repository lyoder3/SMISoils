CREATE VIEW [dbo].[vNutrientLevels]
	AS 
	SELECT f.Farm, f.Field, f.Acreage, n.ItemName as Nutrient, fn.Amount, fn.Goal, fn.LastSampledYear
	FROM dbo.FieldsNutrients fn
	inner join dbo.Fields f on f.id = fn.FieldId
	inner join dbo.Nutrients n on fn.NutrientId = n.id
	
