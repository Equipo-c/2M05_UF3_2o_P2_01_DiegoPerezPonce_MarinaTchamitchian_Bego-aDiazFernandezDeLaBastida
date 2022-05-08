CREATE TABLE [dbo].[Product] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Summary]    NVARCHAR (50) NULL,
    [Icon]       NTEXT         NULL,
    [Banner]     NTEXT         NULL,
    [Trailer]    NVARCHAR (50) NULL,
    [Price]      FLOAT (53)    NULL,
    [Publishing] DATETIME2 (7) NULL DEFAULT (getdate()),
    [Size]       FLOAT (53)    NULL,
    [Developer_id] INT NULL, 
    [Editor_id] INT NULL, 
    [Type] TINYINT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

