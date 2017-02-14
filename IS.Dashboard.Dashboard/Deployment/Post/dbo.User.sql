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
INSERT [dbo].[User] ([UserId], [LastName], [FirstName], [EmailAddress], [Gender], [BOD], [PicURL], [LogOnName], [Password], [Title]) VALUES (1001, N'cheng', N'chen', N'cchen@hpe.com', N'M', NULL, NULL, N'cchen', N'111111', N'Intern')
INSERT [dbo].[User] ([UserId], [LastName], [FirstName], [EmailAddress], [Gender], [BOD], [PicURL], [LogOnName], [Password], [Title]) VALUES (1002, N'yi', N'chen', N'chenyi@hpe.com', N'M', NULL, NULL, N'chenyi', N'111111', N'Intern')
INSERT [dbo].[User] ([UserId], [LastName], [FirstName], [EmailAddress], [Gender], [BOD], [PicURL], [LogOnName], [Password], [Title]) VALUES (1003, N'xiaoyi', N'yang', N'yangxiaoyi@hpe.com', N'W', NULL, NULL, N'yangxiaoyi', N'111111', N'Intern')
INSERT [dbo].[User] ([UserId], [LastName], [FirstName], [EmailAddress], [Gender], [BOD], [PicURL], [LogOnName], [Password], [Title]) VALUES (1004, N'poyu', N'wang', N'wangpoyu@hpe.com', N'M', NULL, NULL, N'wangpoyu', N'111111', N'Intern')
INSERT [dbo].[User] ([UserId], [LastName], [FirstName], [EmailAddress], [Gender], [BOD], [PicURL], [LogOnName], [Password], [Title]) VALUES (1005, N'liju', N'liu', N'liulijun@hpe.com', N'W', NULL, NULL, N'liulijun', N'111111', N'Intern')
INSERT [dbo].[User] ([UserId], [LastName], [FirstName], [EmailAddress], [Gender], [BOD], [PicURL], [LogOnName], [Password], [Title]) VALUES (1006, N'qichao', N'yang', N'yangqichao@hpe.com', N'M', NULL, NULL, N'yangqichao', N'111111', N'regular')
