CREATE TABLE [dbo].[Client] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (50) NOT NULL,
    [CardNumber] NUMERIC (16) NOT NULL,
    [Birthday]   DATE         NOT NULL,
    [Cpf]        VARCHAR(14) NOT NULL,
    [Gender]     VARCHAR (6)  NOT NULL,
    [Country]    VARCHAR (30) NOT NULL,
    [State]      VARCHAR (30) NOT NULL,
    [City]       VARCHAR (30) NOT NULL,
    [Street]     VARCHAR (50) NOT NULL,
    [Complement] VARCHAR (30) NOT NULL,
    [Zipcode]    VARCHAR (9)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

