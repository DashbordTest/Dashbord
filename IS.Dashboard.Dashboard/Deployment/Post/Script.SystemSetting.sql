/*
后期部署脚本模板							
--------------------------------------------------------------------------------------
 此文件包含将附加到生成脚本中的 SQL 语句。		
 使用 SQLCMD 语法将文件包含到后期部署脚本中。			
 示例:      :r .\myfile.sql								
 使用 SQLCMD 语法引用后期部署脚本中的变量。		
 示例:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT [dbo].[SystemSetting]
	([SettingID],[SettingName],[CategoryNode],[CateoryLevel],[Value],[ModifiedDate])
VALUES
(1001,'chengchen','/1/',1,'chengchen',GETDATE()),
(1002,'chenyi','/2/',1,'chenyi',GETDATE()),
(1003,'yangxiaoyi','/3/',1,'yangxiaoyi',GETDATE()),
(1004,'wangpoyu','/4/',1,'wangpoyu',GETDATE()),
(1005,'liuliju','/5',1,'liuliju',GETDATE()),
(1006,'yangqichao','/',0,'yangqichao',GETDATE())
