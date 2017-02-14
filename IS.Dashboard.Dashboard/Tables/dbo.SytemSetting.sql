CREATE TABLE [dbo].[SystemSetting](
	[SettingID] [int] NOT NULL,
	[SettingName] [nvarchar](100) NOT NULL,
	[CategoryNode] [hierarchyid] NULL,
	[CateGoryLevel] [int] NULL,
	[Value] [nvarchar](100) NOT NULL,
	[ModifiedDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SettingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]