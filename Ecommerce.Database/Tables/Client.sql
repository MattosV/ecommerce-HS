CREATE TABLE [dbo].[Client]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [CardNumber] NUMERIC(16) NOT NULL, 
    [Birthday] DATE NOT NULL, 
    [Cpf] NUMERIC(11) NOT NULL, 
    [Gender] VARCHAR(6) NOT NULL, 
    [Country] VARCHAR(30) NOT NULL, 
    [State] VARCHAR(30) NOT NULL, 
    [City] VARCHAR(30) NOT NULL, 
    [Street] VARCHAR(50) NOT NULL, 
    [Complement] VARCHAR(30) NOT NULL, 
    [Zipcode] VARCHAR(9) NOT NULL
)
