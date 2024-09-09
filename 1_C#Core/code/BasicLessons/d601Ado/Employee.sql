CREATE TABLE [dbo].[Employee] (
    [Id]     INT          NOT NULL,
    [name]   VARCHAR (50) NOT NULL,
    [salary] DECIMAL (18) NOT NULL,
    [ver]    INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
