CREATE TABLE [dbo].[Operations] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [FieldId]    INT            NOT NULL,
    [AnalysisId] INT            NOT NULL,
    [Timestamp]  DATETIME2 (7)  DEFAULT (getutcdate()) NOT NULL,
    [Amount]     DECIMAL (10, 5) NOT NULL,
    CONSTRAINT [PK_Operations] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Operations_Analyses] FOREIGN KEY ([AnalysisId]) REFERENCES [dbo].[Analyses] ([id])
);

