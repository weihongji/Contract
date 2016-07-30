--USE [YLContract]
--GO

IF NOT EXISTS(SELECT * FROM sys.tables WHERE object_id = OBJECT_ID('Setting') AND type in (N'U')) BEGIN
	CREATE TABLE dbo.Setting(
		UserMaxLock int NOT NULL
	) ON [PRIMARY]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SystemUser]') AND type in (N'U')) BEGIN
	CREATE TABLE [dbo].[SystemUser](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[Name] [nvarchar](50) NOT NULL,
		[Account] [varchar](50) NOT NULL,
		[Password] [varchar](100) NOT NULL,
		[Role] [smallint] NOT NULL CONSTRAINT [DF_SystemUser_Role] DEFAULT (1),
		[Status] [smallint] NOT NULL CONSTRAINT [DF_SystemUser_Status] DEFAULT (1),
		[FailedCount] int NULL CONSTRAINT [DF_SystemUser_FailedCount] DEFAULT (0),
		[DateStamp] [datetime] NOT NULL CONSTRAINT [DF_SystemUser_DateStamp] DEFAULT (getdate()),
		CONSTRAINT [PK_SystemUser] PRIMARY KEY CLUSTERED ([Id] ASC)
	) ON [PRIMARY]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Group]') AND type in (N'U')) BEGIN
	CREATE TABLE [dbo].[Group](
		[Id] [int] NOT NULL,
		[Name] [nvarchar](50) NOT NULL,
		CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED ([Id] ASC)
	) ON [PRIMARY]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Contract]') AND type in (N'U')) BEGIN
	CREATE TABLE [dbo].[Contract](
		[Id] [int] NOT NULL,
		[Name] [nvarchar](100) NOT NULL,
		[GroupId] [int] NOT NULL,
		[Sort] [varchar](10) NOT NULL CONSTRAINT [DF_Contract_Sort] DEFAULT ('A'),
		[Active] [bit] NOT NULL CONSTRAINT [DF_Contract_Active] DEFAULT ((1)),
		[DateStamp] [datetime] NOT NULL CONSTRAINT [DF_Contract_DateStamp] DEFAULT (getdate()),
		CONSTRAINT [PK_Contract] PRIMARY KEY CLUSTERED ([Id] ASC)
	) ON [PRIMARY]
	
	ALTER TABLE [dbo].[Contract] WITH CHECK ADD CONSTRAINT [FK_Contract_Group] FOREIGN KEY([GroupId]) REFERENCES [dbo].[Group] ([Id])
	ALTER TABLE [dbo].[Contract] ADD CONSTRAINT IX_Contract_Name UNIQUE NONCLUSTERED (Name) ON [PRIMARY]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Field]') AND type in (N'U')) BEGIN
	CREATE TABLE [dbo].[Field](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[ContractId] [int] NOT NULL,
		[Name] [nvarchar](100) NOT NULL,
		[Token] [nvarchar](50) NOT NULL,
		[FieldType] [smallint] NOT NULL CONSTRAINT [DF_Field_FieldType] DEFAULT ((1)),
		[Description] [nvarchar](100) NULL,
		[Required] [bit] NOT NULL CONSTRAINT [DF_Field_Required] DEFAULT ((1)),
		[X] [int] NOT NULL,
		[Y] [int] NOT NULL,
		[Width] [int] NOT NULL,
		[Height] [int] NOT NULL,
		[Sort] [varchar](10) NOT NULL CONSTRAINT [DF_Field_Sort] DEFAULT ('A'),
		[Active] [bit] NOT NULL CONSTRAINT [DF_Field_Active] DEFAULT ((1)),
		[DateStamp] [datetime] NOT NULL CONSTRAINT [DF_Field_DateStamp] DEFAULT (getdate()),
		CONSTRAINT [PK_Field] PRIMARY KEY CLUSTERED ([Id] ASC)
	) ON [PRIMARY]
	
	ALTER TABLE [dbo].[Field] WITH CHECK ADD CONSTRAINT [FK_Field_Contract] FOREIGN KEY([ContractId]) REFERENCES [dbo].[Contract] ([Id])
	ALTER TABLE dbo.Field ADD CONSTRAINT IX_Field_ContractId_Token UNIQUE NONCLUSTERED (ContractId, Token) ON [PRIMARY]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FieldValue]') AND type in (N'U')) BEGIN
	CREATE TABLE [dbo].[FieldValue](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[SystemUserId] [int] NOT NULL,
		[FieldId] [int] NOT NULL,
		[Value] [nvarchar](max) NULL,
		[DateStamp] [datetime] NOT NULL CONSTRAINT [DF_FieldValue_DateStamp] DEFAULT (getdate()),
		CONSTRAINT [PK_FieldValue] PRIMARY KEY CLUSTERED ([Id] ASC)
	) ON [PRIMARY]
	
	ALTER TABLE [dbo].[FieldValue] WITH CHECK ADD CONSTRAINT [FK_FieldValue_SystemUser] FOREIGN KEY([SystemUserId]) REFERENCES [dbo].[SystemUser] ([Id])
	ALTER TABLE [dbo].[FieldValue] WITH CHECK ADD CONSTRAINT [FK_FieldValue_Field] FOREIGN KEY([FieldId]) REFERENCES [dbo].[Field] ([Id])

	CREATE NONCLUSTERED INDEX IX_FieldValue_FieldId ON dbo.FieldValue(SystemUserId ASC, FieldId ASC) ON [PRIMARY]
END
