CREATE TABLE [dbo].[Sales]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdClient] INT NOT NULL, 
    [TotalPrice] NUMERIC(8, 2) NOT NULL, 
    CONSTRAINT [FK_Sales_To_Client] FOREIGN KEY ([Idclient]) REFERENCES [Client]([Id])
)
