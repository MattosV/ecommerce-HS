﻿CREATE TABLE [dbo].[Movie]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Code] VARCHAR(10) NOT NULL, 
    [Title] VARCHAR(50) NOT NULL, 
    [Description] VARCHAR(150) NOT NULL, 
    [Quantity] INT NOT NULL, 
    [Price] NUMERIC(8, 2) NOT NULL, 
    [IdCategory] INT NOT NULL, 
    [Director] VARCHAR(40) NOT NULL, 
    [Stars] VARCHAR(100) NOT NULL, 
    [ReleaseYear] NUMERIC(4) NOT NULL, 
    CONSTRAINT [FK_Movie_To_Category] FOREIGN KEY ([IdCategory]) REFERENCES [Category]([Id])
)
