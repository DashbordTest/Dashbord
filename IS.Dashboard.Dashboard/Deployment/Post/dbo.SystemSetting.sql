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
INSERT [dbo].[SystemSetting] ([SettingID], [SettingName], [CategoryNode], [CateGoryLevel], [Value], [ModifiedDate]) VALUES (1001, N'chengchen', N'/1/', 1, N'form', CAST(0x6E390B00 AS Date))
INSERT [dbo].[SystemSetting] ([SettingID], [SettingName], [CategoryNode], [CateGoryLevel], [Value], [ModifiedDate]) VALUES (1002, N'chenyi', N'/2/', 1, N'form', CAST(0xC43A0B00 AS Date))
INSERT [dbo].[SystemSetting] ([SettingID], [SettingName], [CategoryNode], [CateGoryLevel], [Value], [ModifiedDate]) VALUES (1003, N'yangxiaoyi', N'/3/', 1, N'form', CAST(0xB43A0B00 AS Date))
INSERT [dbo].[SystemSetting] ([SettingID], [SettingName], [CategoryNode], [CateGoryLevel], [Value], [ModifiedDate]) VALUES (1004, N'wangpoyu', N'/4/', 1, N'form', CAST(0x6E390B00 AS Date))
INSERT [dbo].[SystemSetting] ([SettingID], [SettingName], [CategoryNode], [CateGoryLevel], [Value], [ModifiedDate]) VALUES (1005, N'liuliju', N'/5/', 1, N'form', CAST(0x6E390B00 AS Date))
INSERT [dbo].[SystemSetting] ([SettingID], [SettingName], [CategoryNode], [CateGoryLevel], [Value], [ModifiedDate]) VALUES (1006, N'yangqichao', N'/', 0, N'form', CAST(0xDA340B00 AS Date))