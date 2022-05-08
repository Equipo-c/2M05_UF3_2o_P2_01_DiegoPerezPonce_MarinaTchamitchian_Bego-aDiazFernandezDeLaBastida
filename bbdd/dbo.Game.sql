CREATE TABLE [dbo].[Game] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Rating]  FLOAT (53)    NULL,
    [Version] NVARCHAR (50) NULL,
    [Product_id] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

