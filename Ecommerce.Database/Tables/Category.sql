CREATE TABLE [dbo].[Category]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ExternalId] INT NOT NULL, 
    [Name] VARCHAR(50) NOT NULL
)
