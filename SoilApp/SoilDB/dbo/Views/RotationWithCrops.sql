CREATE VIEW [dbo].[RotationWithCrops]
	AS SELECT f.id, f.Farm, f.Field, r.RotationYear, p.ItemName 
	FROM dbo.Fields f
	INNER JOIN dbo.Rotations r on r.FieldId = f.id
	INNER JOIN dbo.Products p on p.id = r.ProductId

