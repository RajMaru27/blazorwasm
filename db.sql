USE [BlazorWASMPractice]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 26-05-2023 6.09.39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[banks]    Script Date: 26-05-2023 6.09.39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[banks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[AccountNumber] [nvarchar](max) NOT NULL,
	[AccountType] [int] NOT NULL,
	[Branch] [nvarchar](max) NOT NULL,
	[IfscCode] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_banks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230526061109_init', N'8.0.0-preview.4.23259.3')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230526105155_bank', N'8.0.0-preview.4.23259.3')
GO
SET IDENTITY_INSERT [dbo].[banks] ON 

INSERT [dbo].[banks] ([Id], [Name], [AccountNumber], [AccountType], [Branch], [IfscCode]) VALUES (1, N'Naynesh Lathiya', N'9876845115654', 1, N'Naka', N'BARBH0THA')
INSERT [dbo].[banks] ([Id], [Name], [AccountNumber], [AccountType], [Branch], [IfscCode]) VALUES (2, N'Shrey Shah', N'0354987987651', 2, N'Mulund', N'UBIN0135468')
INSERT [dbo].[banks] ([Id], [Name], [AccountNumber], [AccountType], [Branch], [IfscCode]) VALUES (3, N'Raj Maru', N'01646413646464', 3, N'Anjurphata', N'IBKL0002056')
INSERT [dbo].[banks] ([Id], [Name], [AccountNumber], [AccountType], [Branch], [IfscCode]) VALUES (4, N'Yash Shah', N'0876841303236', 1, N'Thane', N'TJSB0236546')
INSERT [dbo].[banks] ([Id], [Name], [AccountNumber], [AccountType], [Branch], [IfscCode]) VALUES (5, N'Sagar Malde', N'0354848646846', 2, N'Anjurphata', N'ICIC0054684')
SET IDENTITY_INSERT [dbo].[banks] OFF
GO
