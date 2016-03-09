CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] VARCHAR(20) NOT NULL, 
    [Password] VARCHAR(10) NOT NULL, 
    [IdClient] INT NULL, 
    CONSTRAINT [FK_User_To_Client] FOREIGN KEY ([IdClient]) REFERENCES [Client]([Id])
)
