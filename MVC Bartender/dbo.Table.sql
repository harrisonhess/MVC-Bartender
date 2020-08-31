CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(20) NOT NULL, 
    [Description] NVARCHAR(50) NOT NULL, 
    [Price] MONEY NOT NULL
)
