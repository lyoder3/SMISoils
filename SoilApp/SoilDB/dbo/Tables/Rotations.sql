CREATE TABLE [dbo].[Rotations] (
    [id]        INT IDENTITY (1, 1) NOT NULL,
    [FieldId]   INT NOT NULL,
    [ProductId] INT NOT NULL,
    [RotationYear]      INT NOT NULL,
    CONSTRAINT [PK_Rotations] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Rotations_DimensionedQuantities] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[DimensionedQuantities] ([id]),
    CONSTRAINT [FK_Rotations_Fields] FOREIGN KEY ([FieldId]) REFERENCES [dbo].[Fields] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [UK_FieldYear] UNIQUE NONCLUSTERED ([FieldId] ASC, [RotationYear] ASC)
);

