CREATE TABLE [dbo].[Company] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Name]           NVARCHAR (50) NULL,
    [Icon]           NTEXT         NULL,
    [IconBackground] NVARCHAR (7)  DEFAULT ('#ffffff') NULL,
    [CIF]            NVARCHAR (50) NULL,
    [Address]        NTEXT         NULL,
    [Web]            NTEXT         NULL,
    [Email]          NTEXT         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

