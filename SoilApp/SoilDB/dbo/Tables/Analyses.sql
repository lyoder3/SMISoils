CREATE TABLE [dbo].[Analyses] (
    [id]        INT          IDENTITY (1, 1) NOT NULL,
    [ProductId] INT          NOT NULL,
    [Timestamp] DATETIME2     NOT NULL DEFAULT getutcdate(),
    [AnalysisName]      VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Analyses] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Analyses_Products] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([id])
);

GO

CREATE UNIQUE NONCLUSTERED INDEX [UK_AnalysisNameProductId]
    ON [dbo].[Analyses]([ProductId] ASC, [AnalysisName] ASC);
GO