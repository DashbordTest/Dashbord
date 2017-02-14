CREATE TABLE [dbo].[Authentication]
(
	[SettingID] INT NOT NULL PRIMARY KEY, 
    [SettingName] NVARCHAR(100) NOT NULL, 
    [CategoryNode] HIERARCHYID NULL, 
    [CateGoryLevel] INT NULL, 
    [Value] NVARCHAR(100) NOT NULL, 
    [ModifiedDate] DATE NOT NULL 
)
