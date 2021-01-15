CREATE PROCEDURE [dbo].[spRotationsSoilSamples_GenerateUpcomingIntentions]
	@RotationYear int,
	@CropId int,
	@LastSampledYear int
AS
BEGIN	
	SELECT f.id as Id, f.Farm, f.Field, r.RotationYear, p.ItemName as Crop
		FROM dbo.Fields f
		INNER JOIN 
		(
			SELECT DISTINCT potatoesNext.Farm
			FROM dbo.Rotations r
			INNER JOIN 
				(
					SELECT f.id, f.Field, f.Farm,lastSamples.LastSampled,r.RotationYear,r.ProductId
					FROM dbo.Fields f
					INNER JOIN 
						(
							SELECT f.id, ISNULL(MAX(ss.SampleYear),2018) as LastSampled
							FROM dbo.Fields f
							LEFT JOIN dbo.SoilSamples ss on ss.FieldId = f.id
							GROUP BY f.id
						) lastSamples on f.id = lastSamples.id

					INNER JOIN dbo.Rotations r on r.FieldId = f.id
					WHERE (r.RotationYear = @RotationYear AND r.ProductId = @CropId AND LastSampled <= @LastSampledYear)
				) potatoesNext on potatoesNext.id = r.FieldId
		
		) neededFarms on neededFarms.Farm = f.Farm
		INNER JOIN dbo.Rotations r on r.FieldId = f.id
		INNER JOIN dbo.Products p on p.id = r.ProductId
		WHERE (r.RotationYear >= @RotationYear AND r.RotationYear <= @RotationYear+2)
	ORDER BY f.Farm, f.Field
END