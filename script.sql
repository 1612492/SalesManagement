USE [master]
GO
/****** Object:  Database [CMart]    Script Date: 6/15/2019 3:15:08 PM ******/
CREATE DATABASE [CMart]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CMart', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\CMart.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CMart_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\CMart_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CMart] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CMart].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CMart] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CMart] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CMart] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CMart] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CMart] SET ARITHABORT OFF 
GO
ALTER DATABASE [CMart] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CMart] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CMart] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CMart] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CMart] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CMart] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CMart] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CMart] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CMart] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CMart] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CMart] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CMart] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CMart] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CMart] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CMart] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CMart] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CMart] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CMart] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CMart] SET  MULTI_USER 
GO
ALTER DATABASE [CMart] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CMart] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CMart] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CMart] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CMart] SET DELAYED_DURABILITY = DISABLED 
GO
USE [CMart]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/15/2019 3:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](30) NULL,
	[gender] [nvarchar](10) NULL,
	[birthday] [date] NULL,
	[addr] [nvarchar](50) NULL,
	[idCard] [varchar](20) NULL,
	[phone] [char](10) NULL,
	[startWorking] [date] NULL,
	[position] [nvarchar](10) NULL,
	[username] [varchar](30) NULL,
	[pass] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 6/15/2019 3:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dateBill] [date] NOT NULL,
	[price] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 6/15/2019 3:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 6/15/2019 3:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](30) NULL,
	[gender] [nvarchar](10) NULL,
	[birthday] [date] NULL,
	[addr] [nvarchar](50) NULL,
	[cardId] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Item]    Script Date: 6/15/2019 3:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product] [int] NOT NULL,
	[bill] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 6/15/2019 3:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](30) NULL,
	[category] [int] NOT NULL,
	[importPrice] [int] NULL,
	[exportPrice] [int] NULL,
	[number] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Promotion]    Script Date: 6/15/2019 3:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promotion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](30) NULL,
	[dateStart] [date] NULL,
	[dateEnd] [date] NULL,
	[product] [int] NULL,
	[endow] [int] NULL,
	[dcription] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Provider]    Script Date: 6/15/2019 3:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provider](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](30) NULL,
	[addr] [nvarchar](50) NULL,
	[phone] [char](10) NULL,
	[product] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([id], [name], [gender], [birthday], [addr], [idCard], [phone], [startWorking], [position], [username], [pass]) VALUES (1, N'adsfà', N'Female', CAST(N'2019-06-08' AS Date), N'ádfádf', N'123123123', N'232123    ', CAST(N'2019-06-08' AS Date), N'Manager', N'vp123', N'123')
INSERT [dbo].[Account] ([id], [name], [gender], [birthday], [addr], [idCard], [phone], [startWorking], [position], [username], [pass]) VALUES (5, N'adsfà', N'Female', CAST(N'2019-06-08' AS Date), N'ádfádf', N'123123123', N'232123    ', CAST(N'2019-06-08' AS Date), N'Seller', N'tn123', N'123')
SET IDENTITY_INSERT [dbo].[Account] OFF
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([id], [dateBill], [price]) VALUES (1, CAST(N'2019-02-01' AS Date), 22200)
INSERT [dbo].[Bill] ([id], [dateBill], [price]) VALUES (2, CAST(N'2019-06-05' AS Date), 22200)
INSERT [dbo].[Bill] ([id], [dateBill], [price]) VALUES (3, CAST(N'2019-04-07' AS Date), 24000)
INSERT [dbo].[Bill] ([id], [dateBill], [price]) VALUES (4, CAST(N'2019-01-12' AS Date), 0)
SET IDENTITY_INSERT [dbo].[Bill] OFF
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([id], [name]) VALUES (1, N'Nước ngọt')
INSERT [dbo].[Category] ([id], [name]) VALUES (2, N'Bia')
INSERT [dbo].[Category] ([id], [name]) VALUES (3, N'Bánh kẹo')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([id], [name], [gender], [birthday], [addr], [cardId]) VALUES (1, N'Nguyễn A', N'Male', CAST(N'1990-01-01' AS Date), N'Tân Bình', N'0123456789444444')
INSERT [dbo].[Customer] ([id], [name], [gender], [birthday], [addr], [cardId]) VALUES (2, N'Nguyễn A', N'Male', CAST(N'1990-01-25' AS Date), N'Tân Bình', N'0123456789444444')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Item] ON 

INSERT [dbo].[Item] ([id], [product], [bill]) VALUES (1, 1, 2)
INSERT [dbo].[Item] ([id], [product], [bill]) VALUES (2, 1, 2)
INSERT [dbo].[Item] ([id], [product], [bill]) VALUES (3, 1, 2)
INSERT [dbo].[Item] ([id], [product], [bill]) VALUES (4, 2, 2)
INSERT [dbo].[Item] ([id], [product], [bill]) VALUES (5, 1, 3)
INSERT [dbo].[Item] ([id], [product], [bill]) VALUES (6, 2, 3)
INSERT [dbo].[Item] ([id], [product], [bill]) VALUES (7, 2, 3)
INSERT [dbo].[Item] ([id], [product], [bill]) VALUES (8, 1, 3)
SET IDENTITY_INSERT [dbo].[Item] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([id], [name], [category], [importPrice], [exportPrice], [number]) VALUES (1, N'pepsi', 1, 5000, 6000, 200)
INSERT [dbo].[Product] ([id], [name], [category], [importPrice], [exportPrice], [number]) VALUES (2, N'coca', 1, 5000, 6000, 20)
INSERT [dbo].[Product] ([id], [name], [category], [importPrice], [exportPrice], [number]) VALUES (3, N'333', 2, 6000, 8000, 100)
INSERT [dbo].[Product] ([id], [name], [category], [importPrice], [exportPrice], [number]) VALUES (4, N'tiger', 2, 6000, 8000, 100)
INSERT [dbo].[Product] ([id], [name], [category], [importPrice], [exportPrice], [number]) VALUES (5, N'chocopie', 3, 5000, 6000, 200)
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[Promotion] ON 

INSERT [dbo].[Promotion] ([id], [name], [dateStart], [dateEnd], [product], [endow], [dcription]) VALUES (1, N'big sales', CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 1, 10, N'adfadsf')
INSERT [dbo].[Promotion] ([id], [name], [dateStart], [dateEnd], [product], [endow], [dcription]) VALUES (2, N'summer sales', CAST(N'2019-06-13' AS Date), CAST(N'2019-07-31' AS Date), 1, 40, N'adfadsf')
SET IDENTITY_INSERT [dbo].[Promotion] OFF
SET IDENTITY_INSERT [dbo].[Provider] ON 

INSERT [dbo].[Provider] ([id], [name], [addr], [phone], [product]) VALUES (1, N'pepsi Bình chánh', N'123', N'0258794612', 1)
INSERT [dbo].[Provider] ([id], [name], [addr], [phone], [product]) VALUES (2, N'pepsi Bình chánh', N'123', N'0258794612', 2)
INSERT [dbo].[Provider] ([id], [name], [addr], [phone], [product]) VALUES (4, N'bánh kẹo miền nam', N'123', N'1234455599', 5)
SET IDENTITY_INSERT [dbo].[Provider] OFF
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [fk_Item_Bill] FOREIGN KEY([bill])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [fk_Item_Bill]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [fk_Item_Product] FOREIGN KEY([product])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [fk_Item_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [fk_Prodcut_Category] FOREIGN KEY([category])
REFERENCES [dbo].[Category] ([id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [fk_Prodcut_Category]
GO
ALTER TABLE [dbo].[Promotion]  WITH CHECK ADD  CONSTRAINT [fk_Promotion_Product] FOREIGN KEY([product])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[Promotion] CHECK CONSTRAINT [fk_Promotion_Product]
GO
ALTER TABLE [dbo].[Provider]  WITH CHECK ADD  CONSTRAINT [fk_Provider_Product] FOREIGN KEY([product])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[Provider] CHECK CONSTRAINT [fk_Provider_Product]
GO
USE [master]
GO
ALTER DATABASE [CMart] SET  READ_WRITE 
GO
