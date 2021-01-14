CREATE TABLE [dbo].[AnalysesNutrients] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [AnalysisId] INT            NOT NULL,
    [NutrientId] INT            NOT NULL,
    [Amount]     DECIMAL (10, 5) NOT NULL,
    CONSTRAINT [PK_AnalysesNutrients] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_AnalysesNutrients_Analyses] FOREIGN KEY ([AnalysisId]) REFERENCES [dbo].[Analyses] ([id]),
    CONSTRAINT [FK_AnalysesNutrients_Nutrients] FOREIGN KEY ([NutrientId]) REFERENCES [dbo].[Nutrients] ([id])
);

