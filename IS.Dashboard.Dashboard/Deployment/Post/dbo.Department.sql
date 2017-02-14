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

INSERT [dbo].[Department] ([DepartmentID], [DepartmentName], [ParentID], [DepartmentAddr], [DepartmentContact], [DepartmentPostCode], [DepartmentDesc], [Administor]) VALUES (1, N'i&s', NULL, NULL, NULL, NULL, N'', NULL)
INSERT [dbo].[Department] ([DepartmentID], [DepartmentName], [ParentID], [DepartmentAddr], [DepartmentContact], [DepartmentPostCode], [DepartmentDesc], [Administor]) VALUES (2, N'UI', 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Department] ([DepartmentID], [DepartmentName], [ParentID], [DepartmentAddr], [DepartmentContact], [DepartmentPostCode], [DepartmentDesc], [Administor]) VALUES (3, N'BackEnd', 1, NULL, NULL, NULL, NULL, NULL)
