CREATE TABLE [dbo].[Analyses] (
    [id]        INT          IDENTITY (1, 1) NOT NULL,
    [ProductId] INT          NOT NULL,
    [CreatedTimestamp] DATETIME2     NOT NULL DEFAULT getutcdate(),
    CONSTRAINT [PK_Analyses] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Analyses_Products] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([id])
);

GO