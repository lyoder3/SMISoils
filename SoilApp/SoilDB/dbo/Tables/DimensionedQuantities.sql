CREATE TABLE [dbo].[DimensionedQuantities] (
    [id]       INT          IDENTITY (1, 1) NOT NULL,
    [TypeId]   INT          NOT NULL,
    [UnitId]   INT          NOT NULL,
    [ItemName] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_DimensionedQuantities] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_DimensionedQuantities_Typs] FOREIGN KEY ([TypeId]) REFERENCES [dbo].[DimensionedTypes] ([id]),
    CONSTRAINT [FK_DimensionedQuantities_Units] FOREIGN KEY ([UnitId]) REFERENCES [dbo].[Units] ([id]),
    CONSTRAINT [UK_DimensionedQuantities] UNIQUE NONCLUSTERED ([ItemName] ASC)
);

