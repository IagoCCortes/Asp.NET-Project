CREATE TABLE [dbo].[Person]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(100) NOT NULL, 
    [PersonId] INT NOT NULL
)
