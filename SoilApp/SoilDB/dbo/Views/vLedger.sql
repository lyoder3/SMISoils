CREATE VIEW [dbo].[vLedger]
	AS SELECT f.Farm, f.Field, f.Acreage, n.ItemName as Nutrient, fl.NewAmount,ss.SampleYear, p.ItemName as Product, o.Timestamp
	FROM dbo.FieldNutrientLedger fl
	inner join dbo.Fields f on f.id = fl.FieldId
	inner join dbo.Nutrients n on n.id = fl.NutrientId
	left join dbo.Operations o on o.id = fl.OperationId
	left join dbo.SoilSamples ss on ss.id = fl.SoilSampleId
	left join dbo.Analyses a on a.id = o.AnalysisId
	left join dbo.Products p on a.ProductId = p.id
	
