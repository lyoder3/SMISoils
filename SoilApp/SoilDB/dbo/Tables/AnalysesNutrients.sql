CREATE TABLE [dbo].[AnalysesNutrients] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [AnalysisId] INT            NOT NULL,
    [NutrientId] INT            NOT NULL,
    [Level]      DECIMAL (8, 3) NOT NULL,
    CONSTRAINT [PK_AnalysesNutrients] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_AnalysesNutrients_Analyses] FOREIGN KEY ([AnalysisId]) REFERENCES [dbo].[Analyses] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [FK_AnalysesNutrients_DimensionedQuantities] FOREIGN KEY ([NutrientId]) REFERENCES [dbo].[DimensionedTypes] ([id])
);

