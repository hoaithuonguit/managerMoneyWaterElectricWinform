USE [db.waterE\]
GO
/****** Object:  Table [dbo].[DataDetail]    Script Date: 3/2/2018 11:53:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DataDetail](
	[ID] [int] NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[P0] [int] NOT NULL,
	[p1] [int] NOT NULL,
	[p2] [int] NOT NULL,
	[p3] [int] NOT NULL,
	[p4] [int] NOT NULL,
	[p5] [int] NOT NULL,
	[p6] [int] NOT NULL,
	[p7] [int] NOT NULL,
	[p8] [int] NOT NULL,
	[p9] [int] NOT NULL,
	[p10] [int] NOT NULL,
	[p11] [int] NOT NULL,
	[p12] [int] NOT NULL,
	[p13] [int] NOT NULL,
	[p14] [int] NOT NULL,
	[p15] [int] NOT NULL,
	[p16] [int] NOT NULL,
	[p17] [int] NOT NULL,
	[p18] [int] NOT NULL,
	[p19] [int] NOT NULL,
	[p20] [int] NOT NULL,
	[p21] [int] NOT NULL,
	[p22] [int] NOT NULL,
	[Datewrite] [date] NULL,
 CONSTRAINT [PK_DataDetail] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sum]    Script Date: 3/2/2018 11:53:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sum](
	[ID] [int] NOT NULL,
	[DateWrite] [date] NOT NULL,
	[Room] [varchar](50) NOT NULL,
	[Elec] [int] NOT NULL,
	[Water] [int] NOT NULL,
	[Total] [int] NOT NULL,
 CONSTRAINT [PK_Sum] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (0, CAST(N'2018-02-01' AS Date), N'p0', 17883, 0, 53649000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (1, CAST(N'2018-02-01' AS Date), N'p1', 3398, 352, 11954000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (2, CAST(N'2018-02-01' AS Date), N'p2', 2222, 779, 10561000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (3, CAST(N'2018-02-01' AS Date), N'p3', 4075, 785, 16150000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (4, CAST(N'2018-02-01' AS Date), N'p4', 3078, 492, 11694000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (5, CAST(N'2018-02-01' AS Date), N'p5', 2305, 563, 9730000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (6, CAST(N'2018-02-01' AS Date), N'p6', 2240, 749, 10465000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (7, CAST(N'2018-02-01' AS Date), N'p7', 2022, 541, 8771000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (8, CAST(N'2018-02-01' AS Date), N'p8', 3394, 726, 13812000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (9, CAST(N'2018-02-01' AS Date), N'p9', 3474, 399, 12417000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (10, CAST(N'2018-02-01' AS Date), N'p10', 2429, 532, 9947000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (11, CAST(N'2018-02-01' AS Date), N'p11', 2835, 523, 11120000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (12, CAST(N'2018-02-01' AS Date), N'p12', 3200, 719, 13195000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (13, CAST(N'2018-02-01' AS Date), N'p13', 3672, 386, 12946000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (14, CAST(N'2018-02-01' AS Date), N'p14', 2758, 544, 10994000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (15, CAST(N'2018-02-01' AS Date), N'p15', 2798, 716, 11974000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (16, CAST(N'2018-02-01' AS Date), N'p16', 3579, 702, 14247000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (17, CAST(N'2018-02-01' AS Date), N'p17', 3343, 0, 10029000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (18, CAST(N'2018-02-01' AS Date), N'p18', 3062, 681, 12591000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (19, CAST(N'2018-02-01' AS Date), N'p19', 3416, 517, 12833000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (20, CAST(N'2018-02-01' AS Date), N'p20', 2810, 96, 8910000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (21, CAST(N'2018-02-01' AS Date), N'p21', 3045, 561, 11940000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (22, CAST(N'2018-02-01' AS Date), N'p22', 3418, 463, 12569000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (23, CAST(N'2018-03-01' AS Date), N'p0', 17883, 0, 53649000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (24, CAST(N'2018-03-01' AS Date), N'p1', 3447, 356, 12121000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (25, CAST(N'2018-03-01' AS Date), N'p2', 2227, 780, 10581000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (26, CAST(N'2018-03-01' AS Date), N'p3', 4085, 787, 16190000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (27, CAST(N'2018-03-01' AS Date), N'p4', 3097, 494, 11761000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (28, CAST(N'2018-03-01' AS Date), N'p5', 2318, 567, 9789000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (29, CAST(N'2018-03-01' AS Date), N'p6', 2262, 755, 10561000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (30, CAST(N'2018-03-01' AS Date), N'p7', 2022, 542, 8776000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (31, CAST(N'2018-03-01' AS Date), N'p8', 3397, 726, 13821000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (32, CAST(N'2018-03-01' AS Date), N'p9', 3554, 401, 12667000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (33, CAST(N'2018-03-01' AS Date), N'p10', 2445, 535, 10010000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (34, CAST(N'2018-03-01' AS Date), N'p11', 2841, 524, 11143000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (35, CAST(N'2018-03-01' AS Date), N'p12', 3222, 724, 13286000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (36, CAST(N'2018-03-01' AS Date), N'p13', 3683, 390, 12999000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (37, CAST(N'2018-03-01' AS Date), N'p14', 2782, 546, 11076000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (38, CAST(N'2018-03-01' AS Date), N'p15', 2812, 718, 12026000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (39, CAST(N'2018-03-01' AS Date), N'p16', 3582, 703, 14261000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (40, CAST(N'2018-03-01' AS Date), N'p17', 3359, 0, 10077000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (41, CAST(N'2018-03-01' AS Date), N'p18', 3066, 681, 12603000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (42, CAST(N'2018-03-01' AS Date), N'p19', 3441, 519, 12918000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (43, CAST(N'2018-03-01' AS Date), N'p20', 2820, 99, 8955000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (44, CAST(N'2018-03-01' AS Date), N'p21', 3057, 563, 11986000)
INSERT [dbo].[Sum] ([ID], [DateWrite], [Room], [Elec], [Water], [Total]) VALUES (45, CAST(N'2018-03-01' AS Date), N'p22', 3439, 467, 12652000)
