CREATE TABLE [dbo].[Client]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [CardNumber] NUMERIC(16) NOT NULL, 
    [Birthday] DATE NOT NULL
)
