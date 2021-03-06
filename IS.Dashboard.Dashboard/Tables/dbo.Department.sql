CREATE TABLE [dbo].[Department](
	[DepartmentID] [int] NOT NULL,
	[DepartmentName] [nvarchar](100) NOT NULL,
	[ParentID] [int] NULL,
	[DepartmentAddr] [nvarchar](100) NULL,
	[DepartmentContact] [nvarchar](100) NULL,
	[DepartmentPostCode] [nvarchar](100) NULL,
	[DepartmentDesc] [nvarchar](100) NULL,
	[Administor] [nvarchar](50) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]