﻿CREATE TABLE [dbo].[Units] (
    [id]   INT           IDENTITY (1, 1) NOT NULL,
    [Unit] NVARCHAR (10) NOT NULL,
    CONSTRAINT [PK_Units] PRIMARY KEY CLUSTERED ([id] ASC),
);