CREATE PROCEDURE [dbo].[spRotations_GetYearRange]
	@OldestYear int=0 output,
	@NewestYear int=0 output
AS
BEGIN
	SELECT @NewestYear = MAX(r.RotationYear) from dbo.Rotations r; 
	SELECT @OldestYear = MIN(r.RotationYear) from dbo.Rotations r;
END
