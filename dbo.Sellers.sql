CREATE TABLE [dbo].[Sellers] (
    [Id]            INT   NOT NULL,
    [IdCardNumber]  VARCHAR (12)  NOT NULL,
    [FirstName]     VARCHAR (50)  NOT NULL,
    [LastName]      VARCHAR (50)  NULL,
    [Email]         VARCHAR (100) NULL,
    [ContactNumber] INT           NULL,
    [Address]       VARCHAR (100) NULL, 
    CONSTRAINT [PK_Sellers] PRIMARY KEY ([Id])
);

