USE Soil;
GO

CREATE PROCEDURE [dbo].[spFields_Insert]
	@Farm varchar(25),
	@FieldTypeId int,
	@Field char(3),
	@CationExchangeCapacity decimal(6,3),
	@PotassiumSaturation decimal(6,3),
	@MagnesiumSaturation decimal(6,3),
	@CalciumSaturation decimal(7,3),
	@pH decimal(4,2),
	@BufferpH decimal(4,2),
	@OrganicMatter decimal(4,2),
	@Phosphorus int,
	@Potassium int,
	@Magnesium int,
	@Calcium int,
	@Sulfur int,
	@Boron decimal(4,2),
	@Copper decimal(4,2),
	@Iron int,
	@Manganese int,
	@Zinc decimal(4,2),
	@id int=0 output 
AS
	INSERT INTO dbo.Fields (Farm,
	FieldTypeId,
	Field,
	CationExchangeCapacity,
	PotassiumSaturation,
	MagnesiumSaturation,
	CalciumSaturation,
	pH,
	BufferpH,
	OrganicMatter,
	Phosphorus,
	Potassium,
	Magnesium,
	Calcium,
	Sulfur,
	Boron,
	Copper,
	Iron,
	Manganese,
	Zinc)

	VALUES (@Farm,
	@FieldTypeId,
	@Field,
	@CationExchangeCapacity,
	@PotassiumSaturation,
	@MagnesiumSaturation,
	@CalciumSaturation,
	@pH,
	@BufferpH,
	@OrganicMatter,
	@Phosphorus,
	@Potassium,
	@Magnesium,
	@Calcium,
	@Sulfur,
	@Boron,
	@Copper,
	@Iron,
	@Manganese,
	@Zinc
	)

	SELECT @id = SCOPE_IDENTITY()
END

GO