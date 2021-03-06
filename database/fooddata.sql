USE [foodreceipe]
GO
/****** Object:  Table [dbo].[category]    Script Date: 11/5/2021 4:51:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[catid] [int] IDENTITY(1,1) NOT NULL,
	[catname] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[catid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[menu]    Script Date: 11/5/2021 4:51:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menu](
	[menuid] [int] IDENTITY(1,1) NOT NULL,
	[dishname] [varchar](100) NULL,
	[details] [varchar](max) NULL,
	[price] [int] NULL,
	[img] [varchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[menuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[reservation]    Script Date: 11/5/2021 4:51:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservation](
	[rid] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](250) NULL,
	[phone] [bigint] NULL,
	[r_date] [date] NULL,
	[r_time] [time](7) NULL,
	[person] [int] NULL,
	[msg] [varchar](max) NULL,
	[person_name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[rid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sp_dish]    Script Date: 11/5/2021 4:51:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sp_dish](
	[dishid] [int] IDENTITY(1,1) NOT NULL,
	[dishname] [varchar](100) NULL,
	[catid] [int] NULL,
	[details] [varchar](max) NULL,
	[price] [int] NULL,
	[img] [varchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[dishid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[team]    Script Date: 11/5/2021 4:51:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[team](
	[tid] [int] IDENTITY(1,1) NOT NULL,
	[t_name] [varchar](50) NULL,
	[t_role] [varchar](50) NULL,
	[t_img] [varchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[tid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[category] ON 

INSERT [dbo].[category] ([catid], [catname]) VALUES (1, N'beef')
INSERT [dbo].[category] ([catid], [catname]) VALUES (2, N'chicken')
INSERT [dbo].[category] ([catid], [catname]) VALUES (3, N'mutton')
INSERT [dbo].[category] ([catid], [catname]) VALUES (4, N'lamb')
SET IDENTITY_INSERT [dbo].[category] OFF
SET IDENTITY_INSERT [dbo].[menu] ON 

INSERT [dbo].[menu] ([menuid], [dishname], [details], [price], [img]) VALUES (1, N'Chowmein', N'It the combination of vegetables and chicken with the dash of parmesan cheese.', 2400, N'chowmein.jfif')
SET IDENTITY_INSERT [dbo].[menu] OFF
SET IDENTITY_INSERT [dbo].[reservation] ON 

INSERT [dbo].[reservation] ([rid], [email], [phone], [r_date], [r_time], [person], [msg], [person_name]) VALUES (1, N'smith@gmail.com', 23253456, NULL, CAST(N'06:34:00' AS Time), 4, N'This is birthday party', N'smith')
SET IDENTITY_INSERT [dbo].[reservation] OFF
SET IDENTITY_INSERT [dbo].[sp_dish] ON 

INSERT [dbo].[sp_dish] ([dishid], [dishname], [catid], [details], [price], [img]) VALUES (1, N'Zucchini Chicken Steak', 2, N'Mixed of herbs', 4500, N'zsteack.jfif')
INSERT [dbo].[sp_dish] ([dishid], [dishname], [catid], [details], [price], [img]) VALUES (2, N'Beef chilli dry', 1, N'It has beef and chilli oil', 3000, N'bchilli.jfif')
SET IDENTITY_INSERT [dbo].[sp_dish] OFF
SET IDENTITY_INSERT [dbo].[team] ON 

INSERT [dbo].[team] ([tid], [t_name], [t_role], [t_img]) VALUES (1, N'Sarah Paul', N'Chef', N'chef1.png')
SET IDENTITY_INSERT [dbo].[team] OFF
ALTER TABLE [dbo].[sp_dish]  WITH CHECK ADD FOREIGN KEY([catid])
REFERENCES [dbo].[category] ([catid])
GO
