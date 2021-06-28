USE [Deneme]
GO

/****** Object:  Table [MVF].[AtNowMachineStatuses]    Script Date: 5.06.2021 14:57:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [MVF].[AtNowMachineStatuses](
	[AtNowMachineStatusId] [uniqueidentifier] NOT NULL,
	[MachineId] [int] NOT NULL,
	[MachineStatusId] [int] NOT NULL,
 CONSTRAINT [PK_AtNowMachineStatuses] PRIMARY KEY CLUSTERED 
(
	[AtNowMachineStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [MVF].[MachineInfos]    Script Date: 5.06.2021 14:57:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [MVF].[MachineInfos](
	[MachineInfoId] [uniqueidentifier] NOT NULL,
	[MachineId] [int] NULL,
	[MachineName] [nvarchar](50) NULL,
	[MachineType] [int] NULL,
	[ProductionSpeeedOfMachine] [int] NULL,
	[ProductionUnitType] [int] NULL,
	[MachineStatus] [int] NULL,
	[MachineIP] [nvarchar](50) NULL,
	[MachinePort] [int] NULL,
 CONSTRAINT [PK_MachineInfos] PRIMARY KEY CLUSTERED 
(
	[MachineInfoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [MVF].[UserInfos]    Script Date: 5.06.2021 14:57:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [MVF].[UserInfos](
	[UserInfoId] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[IsOnline] [bit] NOT NULL,
	[MachineIP] [nvarchar](50) NULL,
	[MachinePort] [int] NULL,
 CONSTRAINT [PK_UserInfos] PRIMARY KEY CLUSTERED 
(
	[UserInfoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [MVF].[Works]    Script Date: 5.06.2021 14:57:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [MVF].[Works](
	[WorkId] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[MachineType] [int] NOT NULL,
	[QuantityToBeProduced] [int] NOT NULL,
	[ProductionUnitType] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[StartDate] [datetime] NULL,
	[FinishDate] [datetime] NULL,
	[MachineId] [int] NULL,
	[WorkStatus] [int] NOT NULL,
 CONSTRAINT [PK_Works] PRIMARY KEY CLUSTERED 
(
	[WorkId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [MVF].[AtNowMachineStatuses] ADD  CONSTRAINT [DF_AtNowMachineStatuses_AtNowMachineStatusId]  DEFAULT (newid()) FOR [AtNowMachineStatusId]
GO

ALTER TABLE [MVF].[UserInfos] ADD  CONSTRAINT [DF_UserInfos_UserInfoId]  DEFAULT (newid()) FOR [UserInfoId]
GO

ALTER TABLE [MVF].[Works] ADD  CONSTRAINT [DF_Works_WorkId]  DEFAULT (newid()) FOR [WorkId]
GO

ALTER TABLE [MVF].[Works] ADD  CONSTRAINT [DF_Works_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [MVF].[Works] ADD  CONSTRAINT [DF_Works_WorkStatus]  DEFAULT ((0)) FOR [WorkStatus]
GO


