USE [Auta]
GO
/****** Object:  Table [dbo].[Auta]    Script Date: 05.10.2020 06:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Auta](
	[Id] [int] IDENTITY(3,1) NOT NULL,
	[Marka] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Numer] [varchar](50) NULL,
	[Ubezpieczenie] [date] NULL,
	[OC] [date] NULL,
 CONSTRAINT [PK_Auta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Auta] ON 

INSERT [dbo].[Auta] ([Id], [Marka], [Model], [Numer], [Ubezpieczenie], [OC]) VALUES (32, N'Marka', N'Model', N'Numer', CAST(N'2020-09-21' AS Date), CAST(N'2020-09-22' AS Date))
SET IDENTITY_INSERT [dbo].[Auta] OFF
