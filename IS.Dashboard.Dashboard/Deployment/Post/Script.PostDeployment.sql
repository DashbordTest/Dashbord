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
INSERT INTO [User].Users
	(UserId,LastName,FirstName,EmailAddress,Gender,LogOnName,Password,Title)
VALUES
(1001,'cheng','chen','cchen@hpe.com','M','cchen','111111','Intern'),
(1002,'yi','chen','chenyi@hpe.com','M','chenyi','111111','Intern'),
(1003,'xiaoyi','yang','yangxiaoyi@hpe.com','W','yangxiaoyi','111111','Intern'),
(1004,'poyu','wang','wangpoyu@hpe.com','M','wangpoyu','111111','Intern'),
(1005,'liju','liu','liulijun@hpe.com','W','liulijun','111111','Intern'),
(1006,'qichao','yang','yangqichao@hpe.com','M','yangqichao','111111','regular')

