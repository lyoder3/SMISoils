CREATE TABLE [dbo].[SoilSamples] (
    [id]         INT IDENTITY (1, 1) NOT NULL,
    [FieldId]    INT NOT NULL,
    [SampleYear] INT DEFAULT (datepart(year,getutcdate())) NOT NULL,
    CONSTRAINT [PK_SoilSamples] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_SoilSamples_Fields] FOREIGN KEY ([FieldId]) REFERENCES [dbo].[Fields] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [UK_SoilSamples_FieldIdSampleYear] UNIQUE NONCLUSTERED ([FieldId] ASC, [SampleYear] ASC)
);

