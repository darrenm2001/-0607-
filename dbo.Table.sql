CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] NCHAR(50) NOT NULL, 
    [Content] NCHAR(500) NOT NULL, 
    [PublishData] DATETIME2 NOT NULL
)
