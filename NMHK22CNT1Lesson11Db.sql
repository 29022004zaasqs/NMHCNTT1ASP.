USE [NmhLesson11Dba]
GO
/****** Object:  Table [dbo].[NmhTaiKhoan]    Script Date: 01/07/2024 3:33:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NmhTaiKhoan](
	[NmhId] [int] NOT NULL,
	[NmhUserName] [nvarchar](50) NULL,
	[NmhPassword] [nvarchar](50) NULL,
	[NmhAge] [int] NULL,
	[NmhEmail] [nvarchar](50) NULL,
	[NmhPhone] [nvarchar](50) NULL,
	[NmhStatus] [bit] NULL,
 CONSTRAINT [PK_NmhTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[NmhId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[NmhTaiKhoan] ([NmhId], [NmhUserName], [NmhPassword], [NmhAge], [NmhEmail], [NmhPhone], [NmhStatus]) VALUES (1, N'NguyenMinhHiep', N'123466', 20, N'hiepvip292@gmail.com', N'0397896729', 1)
CREATE TABLE [dbo].[Login] (
    [LoginId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [UserName] NVARCHAR(50) NOT NULL,
    [Password] NVARCHAR(50) NOT NULL
);
INSERT INTO [dbo].[Login] ([UserName], [Password])
VALUES (N'NguyenMinhHiep', N'123466');


INSERT INTO [dbo].[Login] ([UserName], [Password])
VALUES (N'NguyenMinhHiep', N'123466');
