CREATE TABLE [dbo].[MovieSales]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdMovie] INT NOT NULL, 
    [IdSales] INT NOT NULL, 
    [Quantity] INT NOT NULL, 
    CONSTRAINT [FK_MovieSales_To_Movie] FOREIGN KEY ([IdMovie]) REFERENCES [Movie]([Id]), 
    CONSTRAINT [FK_MovieSales_To_Sales] FOREIGN KEY ([IdSales]) REFERENCES [Sales]([Id])
)
