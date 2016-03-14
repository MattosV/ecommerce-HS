CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] VARCHAR(20) NOT NULL, 
    [Password] VARCHAR(20) NOT NULL, 
    [IdClient] INT NULL, 
    [Name] VARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Users_To_Client] FOREIGN KEY ([IdClient]) REFERENCES [Client]([Id])
)
