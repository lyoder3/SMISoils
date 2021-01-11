﻿CREATE TABLE [dbo].[Analyses] (
    [id]        INT          IDENTITY (1, 1) NOT NULL,
    [ProductId] INT          NOT NULL,
    [Timestamp] DATETIME     NOT NULL,
    [Name]      VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Analyses] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Analyses_DimensionedQuantities] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[DimensionedQuantities] ([id]) ON UPDATE CASCADE
);
