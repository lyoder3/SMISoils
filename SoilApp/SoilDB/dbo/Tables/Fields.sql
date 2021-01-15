CREATE TABLE [dbo].[Fields] (
    [id]    INT          IDENTITY (1, 1) NOT NULL,
    [Farm]  VARCHAR (25) NOT NULL,
    [Field] NVARCHAR(8)     NOT NULL,
    CONSTRAINT [PK_Fields] PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [UK_FarmField]
    ON [dbo].[Fields]([Farm] ASC, [Field] ASC);

