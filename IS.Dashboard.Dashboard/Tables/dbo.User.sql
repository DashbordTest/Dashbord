CREATE TABLE [dbo].[User](
	[UserId] [int] NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[EmailAddress] [nvarchar](100) NOT NULL,
	[Gender] [nchar](1) NOT NULL,
	[BOD] [date] NULL,
	[PicURL] [nvarchar](255) NULL,
	[LogOnName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Title] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]