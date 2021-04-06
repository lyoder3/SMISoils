CREATE VIEW [dbo].[vNutrientLevels]
	AS 
	SELECT f.Farm, f.Field, f.Acreage, n.ItemName as Nutrient,ssn.Amount as SoilSampleAmount, fn.Amount, fn.Goal, fn.LastSampledYear, r.ItemName as NextCrop
	FROM dbo.FieldsNutrients fn
	inner join dbo.Fields f on f.id = fn.FieldId
	inner join dbo.Nutrients n on fn.NutrientId = n.id
	inner join dbo.SoilSamples s on s.FieldId = f.id
	left join dbo.SoilSamplesNutrients ssn on ssn.SampleId = s.id AND ssn.NutrientId = fn.NutrientId
	left join dbo.RotationWithCrops r on r.id = f.id
	WHERE s.SampleYear = fn.LastSampledYear AND 
	r.RotationYear = YEAR(GETDATE())

