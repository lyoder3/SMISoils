SELECT *
FROM FieldsNutrients
INNER JOIN SoilSamples on FieldsNutrients.FieldId = SoilSamples.FieldId
INNER JOIN SoilSamplesNutrients on SoilSamples.Id = SoilSamplesNutrients.SampleId
WHERE FieldsNutrients.FieldId = SoilSamples.FieldId