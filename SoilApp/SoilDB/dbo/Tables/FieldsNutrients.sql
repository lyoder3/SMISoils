CREATE TABLE [dbo].[FieldsNutrients] (
    [id]              INT            IDENTITY (1, 1) NOT NULL,
    [FieldId]         INT            NOT NULL,
    [NutrientId]      INT            NOT NULL,
    [Amount]          DECIMAL (8, 3) NOT NULL,
    [Goal]            INT            NOT NULL,
    [LastSampledYear] NCHAR (10)     NULL,
    CONSTRAINT [PK_FieldsNutrients] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_FieldsNutrients_Fields] FOREIGN KEY ([FieldId]) REFERENCES [dbo].[Fields] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [FK_FieldsNutrients_Nutrients] FOREIGN KEY ([NutrientId]) REFERENCES [dbo].[Nutrients] ([id])
);

