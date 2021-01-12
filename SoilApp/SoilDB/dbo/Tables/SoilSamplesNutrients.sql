CREATE TABLE [dbo].[SoilSamplesNutrients] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [SampleId]   INT            NOT NULL,
    [NutrientId] INT            NOT NULL,
    [Amount]     DECIMAL (8, 3) NOT NULL,
    [Goal]       INT            NOT NULL,
    CONSTRAINT [PK_SoilSamplesNutrients] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_SoilSamplesNutrients_Nutrients] FOREIGN KEY ([NutrientId]) REFERENCES [dbo].[Nutrients] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [FK_SoilSamplesNutrients_SoilSamples] FOREIGN KEY ([SampleId]) REFERENCES [dbo].[SoilSamples] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [UK_SoilSamplesNutrients_SampleIdNutrientId] UNIQUE NONCLUSTERED ([SampleId] ASC, [NutrientId] ASC)
);

