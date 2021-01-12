CREATE TABLE [dbo].[Products] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [ItemName] NVARCHAR (50) NOT NULL,
    [UnitId]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Products_Units] FOREIGN KEY ([UnitId]) REFERENCES [dbo].[Units] ([id])
);

