CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL , 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(100) NOT NULL, 
    [PersonId] INT NOT NULL, 
    CONSTRAINT [PK_Person] PRIMARY KEY ([Id])
)
