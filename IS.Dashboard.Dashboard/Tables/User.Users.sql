CREATE TABLE [User].[Users]
(
	[UserId] INT NOT NULL PRIMARY KEY, 
    [LastName] NVARCHAR(100) NOT NULL, 
    [FirstName] NVARCHAR(100) NOT NULL, 
    [EmailAddress] NVARCHAR(100) NOT NULL, 
    [Gender] NCHAR(1) NOT NULL, 
    [BOD] DATE NULL, 
    [PicURL] NVARCHAR(255) NULL, 
    [LogOnName] NVARCHAR(100) NOT NULL, 
    [Password] NVARCHAR(100) NOT NULL, 
    [Title] NVARCHAR(200) NULL,
	
)