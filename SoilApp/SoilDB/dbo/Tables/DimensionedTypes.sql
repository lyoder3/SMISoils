CREATE TABLE [dbo].[DimensionedTypes] (
    [id]   INT          IDENTITY (1, 1) NOT NULL,
    [Type] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_DimensionedTypes] PRIMARY KEY CLUSTERED ([id] ASC)
);

