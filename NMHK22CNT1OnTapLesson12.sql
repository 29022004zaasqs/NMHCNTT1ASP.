USE [NguyenMinhHiep_20123212]
GO
/****** Object:  Table [dbo].[NguyenMinhHiep_SACH]    Script Date: 12/07/2024 8:15:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenMinhHiep_SACH](
	[NguyenMinhHiep_MaSach] [int] NOT NULL,
	[NguyenMinhHiep_TenSach] [nvarchar](255) NULL,
	[NguyenMinhHiep_SoTrang] [int] NULL,
	[NguyenMinhHiep_NamXB] [int] NULL,
	[NguyenMinhHiep_MaTG] [int] NULL,
	[NguyenMinhHiep_TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[NguyenMinhHiep_MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguyenMinhHiep_TACGIA]    Script Date: 12/07/2024 8:15:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenMinhHiep_TACGIA](
	[NguyenMinhHiep_MaTG] [int] NOT NULL,
	[NguyenMinhHiep_TenTacGia] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[NguyenMinhHiep_MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[NguyenMinhHiep_SACH] ([NguyenMinhHiep_MaSach], [NguyenMinhHiep_TenSach], [NguyenMinhHiep_SoTrang], [NguyenMinhHiep_NamXB], [NguyenMinhHiep_MaTG], [NguyenMinhHiep_TrangThai]) VALUES (1, N'Cho Toi Xin Mot Ve Di Tuoi Tho', 210, 2008, 1, 1)
INSERT [dbo].[NguyenMinhHiep_SACH] ([NguyenMinhHiep_MaSach], [NguyenMinhHiep_TenSach], [NguyenMinhHiep_SoTrang], [NguyenMinhHiep_NamXB], [NguyenMinhHiep_MaTG], [NguyenMinhHiep_TrangThai]) VALUES (2, N'De Men Phieu Luu Ky', 180, 1941, 2, 1)
INSERT [dbo].[NguyenMinhHiep_SACH] ([NguyenMinhHiep_MaSach], [NguyenMinhHiep_TenSach], [NguyenMinhHiep_SoTrang], [NguyenMinhHiep_NamXB], [NguyenMinhHiep_MaTG], [NguyenMinhHiep_TrangThai]) VALUES (3, N'Chi Pheo', 160, 1941, 3, 1)
INSERT [dbo].[NguyenMinhHiep_TACGIA] ([NguyenMinhHiep_MaTG], [NguyenMinhHiep_TenTacGia]) VALUES (1, N'Nguyen Minh Hiep')
INSERT [dbo].[NguyenMinhHiep_TACGIA] ([NguyenMinhHiep_MaTG], [NguyenMinhHiep_TenTacGia]) VALUES (2, N'To Hoai')
INSERT [dbo].[NguyenMinhHiep_TACGIA] ([NguyenMinhHiep_MaTG], [NguyenMinhHiep_TenTacGia]) VALUES (3, N'Nam Cao')
ALTER TABLE [dbo].[NguyenMinhHiep_SACH]  WITH CHECK ADD FOREIGN KEY([NguyenMinhHiep_MaTG])
REFERENCES [dbo].[NguyenMinhHiep_TACGIA] ([NguyenMinhHiep_MaTG])
GO
