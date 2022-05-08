CREATE TABLE [dbo].[Video] (
    [Id]       INT        IDENTITY (1, 1) NOT NULL,
    [Duration] FLOAT (53) NULL,
    [Product_id] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

