USE [tambosoft1.0]
GO
/****** Object:  Table [dbo].[Animal]    Script Date: 19/02/19 18:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Animal](
	[rp] [int] IDENTITY(1,1) NOT NULL,
	[fecha_nacimiento] [datetime] NULL,
	[edad] [int] NULL,
	[foto] [varchar](100) NULL,
	[nombre_animal] [varchar](50) NULL,
	[estado_animal] [varchar](50) NULL,
	[hba] [int] NULL,
	[categoria] [varchar](20) NULL,
	[sexo] [varchar](10) NULL,
	[rp_madre] [int] NULL,
	[rp_padre] [int] NULL,
	[hba_madre] [int] NULL,
	[hba_padre] [int] NULL,
	[id_tambo] [int] NULL,
	[id_raza] [int] NULL,
	[habilitado] [bit] NULL,
 CONSTRAINT [PK_Animal_1] PRIMARY KEY CLUSTERED 
(
	[rp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Control]    Script Date: 19/02/19 18:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Control](
	[id_control] [int] IDENTITY(1,1) NOT NULL,
	[primer_control] [real] NULL,
	[segundo_control] [real] NULL,
	[porcentaje_grasa] [real] NULL,
	[kg_grasa] [real] NULL,
	[grasa_primercontrol] [real] NULL,
	[grasa_segundocontrol] [real] NULL,
 CONSTRAINT [PK_Control] PRIMARY KEY CLUSTERED 
(
	[id_control] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Control_Animal]    Script Date: 19/02/19 18:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Control_Animal](
	[fecha_control] [datetime] NULL,
	[id_control] [int] NULL,
	[rp] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Desc_Subevento]    Script Date: 19/02/19 18:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Desc_Subevento](
	[id_desc] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[abreviacion] [varchar](10) NULL,
	[estado_desc] [bit] NULL,
	[id_subevento] [int] NULL,
 CONSTRAINT [PK_Desc_subevento] PRIMARY KEY CLUSTERED 
(
	[id_desc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Evento]    Script Date: 19/02/19 18:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Evento](
	[id_evento] [int] IDENTITY(1,1) NOT NULL,
	[nombre_evento] [varchar](50) NULL,
 CONSTRAINT [PK_Evento] PRIMARY KEY CLUSTERED 
(
	[id_evento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Evento_Animal]    Script Date: 19/02/19 18:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evento_Animal](
	[rp] [int] NULL,
	[id_evento] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Evento_Subevento]    Script Date: 19/02/19 18:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evento_Subevento](
	[id_evento] [int] NULL,
	[id_subevento] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EventoAnimal_DescSubevento]    Script Date: 19/02/19 18:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventoAnimal_DescSubevento](
	[id_desc_evento] [int] IDENTITY(1,1) NOT NULL,
	[rp] [int] NULL,
	[id_evento] [int] NULL,
	[id_desc] [int] NULL,
	[fecha_desc] [datetime] NULL,
	[id_inseminador] [int] NULL,
	[id_tambo] [int] NULL,
	[estado_evento] [bit] NULL,
 CONSTRAINT [PK_EventoAnimal_DescSubevento] PRIMARY KEY CLUSTERED 
(
	[id_desc_evento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inseminador]    Script Date: 19/02/19 18:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inseminador](
	[id_inseminador] [int] IDENTITY(1,1) NOT NULL,
	[nombre_inseminador] [varchar](50) NULL,
	[estado_inseminador] [bit] NULL,
	[telefono] [varchar](50) NULL,
	[direccion] [varchar](100) NULL,
	[dni] [varchar](9) NULL,
	[id_localidad] [int] NULL,
 CONSTRAINT [PK_Inseminador] PRIMARY KEY CLUSTERED 
(
	[id_inseminador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 19/02/19 18:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Localidad](
	[id_localidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre_localidad] [varchar](50) NULL,
	[id_provincia] [int] NULL,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[id_localidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 19/02/19 18:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provincia](
	[id_provincia] [int] IDENTITY(1,1) NOT NULL,
	[nombre_provincia] [varchar](50) NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[id_provincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Raza]    Script Date: 19/02/19 18:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Raza](
	[id_raza] [int] IDENTITY(1,1) NOT NULL,
	[nombre_raza] [varchar](50) NULL,
	[estado_raza] [bit] NULL,
 CONSTRAINT [PK_Raza] PRIMARY KEY CLUSTERED 
(
	[id_raza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subevento]    Script Date: 19/02/19 18:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subevento](
	[id_subevento] [int] IDENTITY(1,1) NOT NULL,
	[nombre_subevento] [varchar](50) NULL,
	[estado_subevento] [bit] NULL,
 CONSTRAINT [PK_Subevento] PRIMARY KEY CLUSTERED 
(
	[id_subevento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tambo]    Script Date: 19/02/19 18:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tambo](
	[id_tambo] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tambo] [varchar](50) NULL,
	[superficie] [real] NULL,
	[estado_tambo] [bit] NULL,
	[id_localidad] [int] NULL,
 CONSTRAINT [PK_Tambo] PRIMARY KEY CLUSTERED 
(
	[id_tambo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tambo_inseminador]    Script Date: 19/02/19 18:04:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tambo_inseminador](
	[id_tambo] [int] NULL,
	[id_inseminador] [int] NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Animal] ON 

INSERT [dbo].[Animal] ([rp], [fecha_nacimiento], [edad], [foto], [nombre_animal], [estado_animal], [hba], [categoria], [sexo], [rp_madre], [rp_padre], [hba_madre], [hba_padre], [id_tambo], [id_raza], [habilitado]) VALUES (1, CAST(N'2011-07-27 00:00:00.000' AS DateTime), 12, N'', N'Marisa', N'Vendido', 1, N'Vaca', N'Hembra', 4, 5, 4, 5, 1, 5, 1)
INSERT [dbo].[Animal] ([rp], [fecha_nacimiento], [edad], [foto], [nombre_animal], [estado_animal], [hba], [categoria], [sexo], [rp_madre], [rp_padre], [hba_madre], [hba_padre], [id_tambo], [id_raza], [habilitado]) VALUES (2, CAST(N'2007-05-05 00:00:00.000' AS DateTime), 11, N'', N'Chueca', N'Enfermo', 2, N'Vaca', N'Hembra', 4, 5, 5, 5, 1, 1, 1)
INSERT [dbo].[Animal] ([rp], [fecha_nacimiento], [edad], [foto], [nombre_animal], [estado_animal], [hba], [categoria], [sexo], [rp_madre], [rp_padre], [hba_madre], [hba_padre], [id_tambo], [id_raza], [habilitado]) VALUES (13, CAST(N'2018-10-12 00:00:00.000' AS DateTime), 1, N'', N'ewffds', N'Vivo', 1, N'Vaca', N'Hembra', 11, 1, 1, 1, 1, 3, 1)
INSERT [dbo].[Animal] ([rp], [fecha_nacimiento], [edad], [foto], [nombre_animal], [estado_animal], [hba], [categoria], [sexo], [rp_madre], [rp_padre], [hba_madre], [hba_padre], [id_tambo], [id_raza], [habilitado]) VALUES (15, CAST(N'2018-10-12 00:00:00.000' AS DateTime), 3, N'', N'fd', N'Celo', 1, N'Vaca', N'Hembra', 1, 1, 1, 1, 1, 7, 0)
INSERT [dbo].[Animal] ([rp], [fecha_nacimiento], [edad], [foto], [nombre_animal], [estado_animal], [hba], [categoria], [sexo], [rp_madre], [rp_padre], [hba_madre], [hba_padre], [id_tambo], [id_raza], [habilitado]) VALUES (16, CAST(N'2018-10-12 00:00:00.000' AS DateTime), 1, N'', N'wer', N'Vivo', 1, N'Vaca', N'Hembra', 1, 11, 1, 1, 1, 1, 1)
INSERT [dbo].[Animal] ([rp], [fecha_nacimiento], [edad], [foto], [nombre_animal], [estado_animal], [hba], [categoria], [sexo], [rp_madre], [rp_padre], [hba_madre], [hba_padre], [id_tambo], [id_raza], [habilitado]) VALUES (19, CAST(N'2018-11-07 00:00:00.000' AS DateTime), 12, N'', N'asdasd', N'Vendido', 1, N'Vaca', N'Hembra', 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[Animal] ([rp], [fecha_nacimiento], [edad], [foto], [nombre_animal], [estado_animal], [hba], [categoria], [sexo], [rp_madre], [rp_padre], [hba_madre], [hba_padre], [id_tambo], [id_raza], [habilitado]) VALUES (21, CAST(N'2018-12-13 00:00:00.000' AS DateTime), 1, N'', N'wer', N'Vivo', 1, N'Toro', N'Macho', 1, 1, 1, 1, 1, 2, 0)
INSERT [dbo].[Animal] ([rp], [fecha_nacimiento], [edad], [foto], [nombre_animal], [estado_animal], [hba], [categoria], [sexo], [rp_madre], [rp_padre], [hba_madre], [hba_padre], [id_tambo], [id_raza], [habilitado]) VALUES (22, CAST(N'2019-02-06 00:00:00.000' AS DateTime), 11, N'', N'wqeqe', N'Vivo', 1, N'Vaca', N'Hembra', 1, 1, 1, 1, 1, 2, 0)
INSERT [dbo].[Animal] ([rp], [fecha_nacimiento], [edad], [foto], [nombre_animal], [estado_animal], [hba], [categoria], [sexo], [rp_madre], [rp_padre], [hba_madre], [hba_padre], [id_tambo], [id_raza], [habilitado]) VALUES (23, CAST(N'2019-02-08 00:00:00.000' AS DateTime), 12, N'', N'ma', N'Vivo', 1, N'Toro', N'Macho', 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[Animal] ([rp], [fecha_nacimiento], [edad], [foto], [nombre_animal], [estado_animal], [hba], [categoria], [sexo], [rp_madre], [rp_padre], [hba_madre], [hba_padre], [id_tambo], [id_raza], [habilitado]) VALUES (24, CAST(N'2019-02-07 00:00:00.000' AS DateTime), 23, N'', N'Marta', N'Vivo', 725, N'Vaca', N'Hembra', 65, 8599, 678, 937, 1, 2, 1)
INSERT [dbo].[Animal] ([rp], [fecha_nacimiento], [edad], [foto], [nombre_animal], [estado_animal], [hba], [categoria], [sexo], [rp_madre], [rp_padre], [hba_madre], [hba_padre], [id_tambo], [id_raza], [habilitado]) VALUES (25, CAST(N'2019-02-08 00:00:00.000' AS DateTime), 1, N'', N'kkjsjd', N'Vivo', 3, N'Vaca', N'Hembra', 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[Animal] ([rp], [fecha_nacimiento], [edad], [foto], [nombre_animal], [estado_animal], [hba], [categoria], [sexo], [rp_madre], [rp_padre], [hba_madre], [hba_padre], [id_tambo], [id_raza], [habilitado]) VALUES (26, CAST(N'2019-02-08 00:00:00.000' AS DateTime), 1, N'', N'kjhjhj', N'Vivo', 2, N'Vaca', N'Hembra', 2, 2, 2, 2, 1, 1, 1)
INSERT [dbo].[Animal] ([rp], [fecha_nacimiento], [edad], [foto], [nombre_animal], [estado_animal], [hba], [categoria], [sexo], [rp_madre], [rp_padre], [hba_madre], [hba_padre], [id_tambo], [id_raza], [habilitado]) VALUES (27, CAST(N'2019-02-11 00:00:00.000' AS DateTime), 11, N'', N'asdas', N'Vivo', 1, N'Vaca', N'Hembra', 1, 1, 1, 1, 1, 2, 1)
SET IDENTITY_INSERT [dbo].[Animal] OFF
SET IDENTITY_INSERT [dbo].[Control] ON 

INSERT [dbo].[Control] ([id_control], [primer_control], [segundo_control], [porcentaje_grasa], [kg_grasa], [grasa_primercontrol], [grasa_segundocontrol]) VALUES (1011, 0, 0, NULL, NULL, 0, 0)
SET IDENTITY_INSERT [dbo].[Control] OFF
INSERT [dbo].[Control_Animal] ([fecha_control], [id_control], [rp]) VALUES (CAST(N'2019-02-11 00:00:00.000' AS DateTime), 1011, 16)
SET IDENTITY_INSERT [dbo].[Desc_Subevento] ON 

INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (1, N'Hembra', N'H', 1, 1)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (2, N'Macho', N'M', 1, 1)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (3, N'Mell. Hembra-Macho', N'HM', 1, 1)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (4, N'Mell. Hembra-Hembra', N'HH', 1, 1)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (5, N'Mell. Macho-Macho', N'MM', 1, 1)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (6, N'Normal', N'N', 1, 2)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (7, N'Cesarea', N'C', 1, 2)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (8, N'Prematuro', N'Pre', 1, 2)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (9, N'Fetotomia', N'F', 1, 2)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (10, N'Parto con ayuda', N'A', 1, 2)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (11, N'Episiotomia', N'E', 1, 2)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (12, N'Muerto', N'M', 1, 3)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (13, N'Vivo', N'V', 1, 3)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (14, N'Brucelosis', N'B', 1, 4)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (15, N'DVB', N'DVB', 1, 4)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (16, N'Haemophilus', N'Ha', 1, 4)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (17, N'Hiperestrogenismo', N'Hi', 1, 4)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (18, N'IBR', N'IBR', 1, 4)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (19, N'Leptospirosis', N'Lep', 1, 4)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (20, N'Stress', N'SS', 1, 4)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (21, N'Traumatismo', N'T', 1, 4)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (22, N'Trichomoniasis', N'Tri', 1, 4)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (23, N'Vibriosis', N'V', 1, 4)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (24, N'Flujo anormal', N'FA', 1, 5)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (25, N'Flujo con sangre', N'FCS', 1, 5)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (26, N'Irregular', N'Irr', 1, 5)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (27, N'Olvido o causa externa', N'OCE', 1, 5)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (28, N'Por celo debil', N'CD', 1, 5)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (29, N'Por prescripcion', N'PP', 1, 5)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (30, N'Por rechazo', N'PR', 1, 5)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (31, N'Por tratamiento', N'PT', 1, 5)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (32, N'Lotagen-prostaglandina', N'LotPros', 1, 6)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (33, N'Prostaglandina', N'Pros', 1, 6)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (34, N'Terramicina', N'Terra', 1, 6)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (35, N'Intra-muscular', N'IM', 1, 7)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (36, N'Intre-uterina y muscular', N'IUyM', 1, 7)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (37, N'Intra-venosa', N'IV', 1, 7)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (38, N'Retencion con extraccion', N'RCE', 1, 7)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (39, N'Subcutanea', N'Sub', 1, 7)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (40, N'Aherencia utero', N'AdhU', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (41, N'Cria terneros', N'CrT', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (42, N'Desc. por leucosis', N'DPL', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (43, N'Desgano rectal', N'DR', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (44, N'Dureza ordeño', N'DO', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (45, N'Fin vida util', N'FVU', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (46, N'Indocilidad', N'Ind', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (47, N'Lesion p/aft.', N'Les', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (48, N'Mastitis cronica', N'MasC', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (49, N'Otra causa', N'OtraC', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (50, N'Por Patas', N'PPatas', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (51, N'Produccion baja', N'ProdB', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (52, N'Puncion rumen', N'PunRu', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (53, N'R. parametritis', N'RPar', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (54, N'Secada (rechazo)', N'Sec', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (55, N'Septicemia', N'Sep', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (56, N'Subfertilidad', N'Subf', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (57, N'Tuberculosis', N'Tub', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (58, N'Ubre', N'Ub', 1, 8)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (59, N'Muerte accidental', N'MA', 1, 16)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (60, N'Muerte por aftosa', N'MpA', 1, 16)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (61, N'Muerte por anaplasmosis', N'MpAn', 1, 16)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (62, N'Muerte por carbunclo', N'MpC', 1, 16)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (63, N'Muerte por causa desconocida', N'MpCd', 1, 16)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (64, N'Muerte por hemorragia', N'MpH', 1, 16)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (65, N'Muerte por intoxicacion', N'MpI', 1, 16)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (66, N'Muerte por leucosis', N'MpL', 1, 16)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (67, N'Muerte por parto', N'MpPar', 1, 16)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (68, N'Muerte por peritonitis', N'MpPer', 1, 16)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (69, N'Muerte por prolapso matriz', N'MpPro', 1, 16)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (70, N'Muerte por ret. pericard.', N'MpRet', 1, 16)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (71, N'Muerte por sindrome vaca caida', N'MpSvc', 1, 16)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (72, N'Muerte por timpanismo', N'MpT', 1, 16)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (73, N'Abceso', N'Ab', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (74, N'Artritis digital', N'ArD', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (75, N'Brucelosis', N'Bru', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (76, N'Cercivitis', N'Cer', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (77, N'Dermatitis verrucosa', N'Der', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (78, N'Desgarro Rectal', N'Des', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (79, N'Escarsa', N'Esc', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (80, N'Flujo anormal', N'FA', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (81, N'Free-martins', N'Free', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (82, N'Hipocalcemia', N'Hipo', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (83, N'Indigestion', N'Ind', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (84, N'Leucosis', N'Leu', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (85, N'Mastitis', N'Mas', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (86, N'Prolapso', N'Pro', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (87, N'Querato-conjuntivitis', N'Que', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (88, N'Renga', N'Ren', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (89, N'Sindrome vaca caida', N'SVC', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (90, N'Tenosinovitis', N'Ten', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (91, N'Tetano', N'Tet', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (92, N'Timpanismo', N'Tim', 1, 9)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (93, N'Prostaglandina', N'Pro', 1, 10)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (94, N'Librada a servicio', N'Lib', 1, 11)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (95, N'Preñada', N'Preñ', 1, 11)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (96, N'Preñada dudosa', N'PreñD', 1, 11)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (97, N'Vacia anormal', N'VacA', 1, 11)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (98, N'Vacia normal', N'VacN', 1, 11)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (99, N'Involucion uterina lenta', N'IUL', 1, 11)
GO
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (100, N'Involucion uterina normal', N'IUN', 1, 11)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (101, N'Abceso paravaginal', N'AbcPa', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (102, N'Adherencia uterina', N'AdhU', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (103, N'Cervicitis', N'Cer', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (104, N'Desgarros utero-vaginal', N'DesUV', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (105, N'Endometritis 1', N'End1', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (106, N'Endometritis 2', N'End2', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (107, N'Endometritis 3', N'End3', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (108, N'Endometritis y retencion', N'EntyR', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (109, N'Flujo con pus', N'FcP', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (110, N'Flujo hemorragico', N'FH', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (111, N'Involucion uterina lenta', N'IUL', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (112, N'Metritis', N'Met', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (113, N'Mucometra', N'Muc', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (114, N'Neumovagina', N'Neu', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (115, N'Parametritis', N'Par', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (116, N'Paravaginitis', N'Para', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (117, N'Piometria', N'Piom', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (118, N'Salpingitis', N'Sal', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (119, N'Tumor de utero', N'Tum', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (120, N'Urovagina', N'Uro', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (121, N'Vaginitis', N'Vag', 1, 12)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (122, N'Adherencia ovario', N'AdhO', 1, 13)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (123, N'Anesto ovarico', N'AnesO', 1, 13)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (124, N'C. luteo persistente', N'CLP', 1, 13)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (125, N'CLOD', N'CLOD', 1, 13)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (126, N'CLOI', N'CLOI', 1, 13)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (127, N'FOLOD < 0,8', N'FDm', 1, 13)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (128, N'FOLOD > 0,8', N'FDM', 1, 13)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (129, N'FOLOI < 0,8', N'FIm', 1, 13)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (130, N'FOLOI > 0,8', N'FIM', 1, 13)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (131, N'Quiste/s ovarico/s', N'Quis', 1, 13)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (132, N'Salpingitis u/bilat.', N'Salp', 1, 13)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (133, N'Tumor ovarico', N'Tum', 1, 13)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (134, N'Baja produccion', N'BProd', 1, 14)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (135, N'Infertilidad', N'Inf', 1, 14)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (136, N'Patas', N'Patas', 1, 14)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (137, N'Por aborto', N'PorAb', 1, 14)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (138, N'Por edad', N'PorEd', 1, 14)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (139, N'Por enfermedad', N'PorEnf', 1, 14)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (140, N'Por tuberculosis', N'PorTub', 1, 14)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (141, N'BPA', N'BPA', 1, 15)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (142, N'Tuberculosis', N'Tub', 1, 15)
INSERT [dbo].[Desc_Subevento] ([id_desc], [descripcion], [abreviacion], [estado_desc], [id_subevento]) VALUES (1104, N'Inseminador', N'Ins', 1, 17)
SET IDENTITY_INSERT [dbo].[Desc_Subevento] OFF
SET IDENTITY_INSERT [dbo].[Evento] ON 

INSERT [dbo].[Evento] ([id_evento], [nombre_evento]) VALUES (1, N'Parto')
INSERT [dbo].[Evento] ([id_evento], [nombre_evento]) VALUES (2, N'Aborto')
INSERT [dbo].[Evento] ([id_evento], [nombre_evento]) VALUES (3, N'Celo')
INSERT [dbo].[Evento] ([id_evento], [nombre_evento]) VALUES (4, N'Venta')
INSERT [dbo].[Evento] ([id_evento], [nombre_evento]) VALUES (5, N'Muerte')
INSERT [dbo].[Evento] ([id_evento], [nombre_evento]) VALUES (6, N'Enfermedad')
INSERT [dbo].[Evento] ([id_evento], [nombre_evento]) VALUES (7, N'Tacto Rectal')
INSERT [dbo].[Evento] ([id_evento], [nombre_evento]) VALUES (8, N'Medicacion')
INSERT [dbo].[Evento] ([id_evento], [nombre_evento]) VALUES (9, N'Rechazo')
INSERT [dbo].[Evento] ([id_evento], [nombre_evento]) VALUES (10, N'Analisis')
INSERT [dbo].[Evento] ([id_evento], [nombre_evento]) VALUES (11, N'Servicio')
SET IDENTITY_INSERT [dbo].[Evento] OFF
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (1, 1)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (1, 2)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (1, 3)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (2, 4)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (3, 5)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (3, 6)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (3, 7)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (4, 8)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (5, 16)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (6, 9)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (6, 10)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (7, 11)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (7, 12)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (7, 13)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (7, 6)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (8, 10)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (8, 7)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (9, 14)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (10, 15)
INSERT [dbo].[Evento_Subevento] ([id_evento], [id_subevento]) VALUES (11, 17)
SET IDENTITY_INSERT [dbo].[EventoAnimal_DescSubevento] ON 

INSERT [dbo].[EventoAnimal_DescSubevento] ([id_desc_evento], [rp], [id_evento], [id_desc], [fecha_desc], [id_inseminador], [id_tambo], [estado_evento]) VALUES (1, 1, 1, 1, CAST(N'2018-11-29 00:00:00.000' AS DateTime), NULL, 1, 1)
INSERT [dbo].[EventoAnimal_DescSubevento] ([id_desc_evento], [rp], [id_evento], [id_desc], [fecha_desc], [id_inseminador], [id_tambo], [estado_evento]) VALUES (2, 1, 1, 7, CAST(N'2018-11-29 00:00:00.000' AS DateTime), NULL, 1, 1)
INSERT [dbo].[EventoAnimal_DescSubevento] ([id_desc_evento], [rp], [id_evento], [id_desc], [fecha_desc], [id_inseminador], [id_tambo], [estado_evento]) VALUES (3, 1, 1, 13, CAST(N'2018-11-29 00:00:00.000' AS DateTime), NULL, 1, 1)
INSERT [dbo].[EventoAnimal_DescSubevento] ([id_desc_evento], [rp], [id_evento], [id_desc], [fecha_desc], [id_inseminador], [id_tambo], [estado_evento]) VALUES (5, 2, 2, 15, CAST(N'2019-02-03 00:00:00.000' AS DateTime), NULL, 1, 1)
INSERT [dbo].[EventoAnimal_DescSubevento] ([id_desc_evento], [rp], [id_evento], [id_desc], [fecha_desc], [id_inseminador], [id_tambo], [estado_evento]) VALUES (6, 2, 11, 1104, CAST(N'2019-02-14 00:00:00.000' AS DateTime), 4, 1, 1)
INSERT [dbo].[EventoAnimal_DescSubevento] ([id_desc_evento], [rp], [id_evento], [id_desc], [fecha_desc], [id_inseminador], [id_tambo], [estado_evento]) VALUES (7, 15, 6, 76, CAST(N'2019-02-14 00:00:00.000' AS DateTime), NULL, 1, 0)
INSERT [dbo].[EventoAnimal_DescSubevento] ([id_desc_evento], [rp], [id_evento], [id_desc], [fecha_desc], [id_inseminador], [id_tambo], [estado_evento]) VALUES (8, 15, 6, 93, CAST(N'2019-02-14 00:00:00.000' AS DateTime), NULL, 1, 0)
INSERT [dbo].[EventoAnimal_DescSubevento] ([id_desc_evento], [rp], [id_evento], [id_desc], [fecha_desc], [id_inseminador], [id_tambo], [estado_evento]) VALUES (9, 15, 3, 27, CAST(N'2019-02-14 00:00:00.000' AS DateTime), NULL, 1, 1)
INSERT [dbo].[EventoAnimal_DescSubevento] ([id_desc_evento], [rp], [id_evento], [id_desc], [fecha_desc], [id_inseminador], [id_tambo], [estado_evento]) VALUES (10, 15, 3, 33, CAST(N'2019-02-14 00:00:00.000' AS DateTime), NULL, 1, 1)
INSERT [dbo].[EventoAnimal_DescSubevento] ([id_desc_evento], [rp], [id_evento], [id_desc], [fecha_desc], [id_inseminador], [id_tambo], [estado_evento]) VALUES (11, 15, 3, 35, CAST(N'2019-02-14 00:00:00.000' AS DateTime), NULL, 1, 1)
SET IDENTITY_INSERT [dbo].[EventoAnimal_DescSubevento] OFF
SET IDENTITY_INSERT [dbo].[Inseminador] ON 

INSERT [dbo].[Inseminador] ([id_inseminador], [nombre_inseminador], [estado_inseminador], [telefono], [direccion], [dni], [id_localidad]) VALUES (1, N'Jorge Benedetto', 1, N'3406534201', N'Belgrano 214', N'15742347', 4)
INSERT [dbo].[Inseminador] ([id_inseminador], [nombre_inseminador], [estado_inseminador], [telefono], [direccion], [dni], [id_localidad]) VALUES (2, N'Alberto Perez', 1, N'1212312', N'asasdas', N'12323213', 24)
INSERT [dbo].[Inseminador] ([id_inseminador], [nombre_inseminador], [estado_inseminador], [telefono], [direccion], [dni], [id_localidad]) VALUES (3, N'Alberto', 1, N'1111', N'qwwd', N'1231231', 24)
INSERT [dbo].[Inseminador] ([id_inseminador], [nombre_inseminador], [estado_inseminador], [telefono], [direccion], [dni], [id_localidad]) VALUES (4, N'eyyd', 1, N'53523', N'sfddfssfd', N'324243243', 6)
INSERT [dbo].[Inseminador] ([id_inseminador], [nombre_inseminador], [estado_inseminador], [telefono], [direccion], [dni], [id_localidad]) VALUES (5, N'Alnery', 1, N'123213', N'dsasd', N'12412', 24)
INSERT [dbo].[Inseminador] ([id_inseminador], [nombre_inseminador], [estado_inseminador], [telefono], [direccion], [dni], [id_localidad]) VALUES (6, N'45', 1, N'44', N'yy', N'44444444', 25)
INSERT [dbo].[Inseminador] ([id_inseminador], [nombre_inseminador], [estado_inseminador], [telefono], [direccion], [dni], [id_localidad]) VALUES (7, N'j', 1, N'', N'', N'7', 6)
INSERT [dbo].[Inseminador] ([id_inseminador], [nombre_inseminador], [estado_inseminador], [telefono], [direccion], [dni], [id_localidad]) VALUES (8, N'askdasd', 1, N'12321312', N'sa12', N'12321312', 23)
SET IDENTITY_INSERT [dbo].[Inseminador] OFF
SET IDENTITY_INSERT [dbo].[Localidad] ON 

INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (1, N'Pergamino', 1)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (2, N'Corral de Bustos', 5)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (3, N'Landeta', 20)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (4, N'San Jorge', 20)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (5, N'Las Petacas', 20)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (6, N'San Fernando del Valle de Catamarca', 2)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (7, N'Resistencia', 3)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (8, N'Rawson', 4)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (9, N'Goya', 6)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (10, N'Corrientes', 6)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (11, N'Victoria', 7)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (12, N'Formosa', 8)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (13, N'San Salvador de Jujuy', 9)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (14, N'General Pico', 10)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (15, N'La Rioja', 11)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (16, N'Mendoza', 12)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (17, N'Posadas', 13)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (18, N'Neuquen', 14)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (19, N'General Roca', 15)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (20, N'Salta', 16)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (21, N'San Juan', 17)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (22, N'San Luis', 18)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (23, N'Rio Gallegos', 19)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (24, N'Santiago del Estero', 21)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (25, N'Ushuaia', 22)
INSERT [dbo].[Localidad] ([id_localidad], [nombre_localidad], [id_provincia]) VALUES (26, N'San Miguel de Tucuman', 23)
SET IDENTITY_INSERT [dbo].[Localidad] OFF
SET IDENTITY_INSERT [dbo].[Provincia] ON 

INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (1, N'Buenos Aires')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (2, N'Catamarca')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (3, N'Chaco')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (4, N'Chubut')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (5, N'Cordoba')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (6, N'Corrientes')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (7, N'Entre Rios')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (8, N'Formosa')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (9, N'Jujuy')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (10, N'La Pampa')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (11, N'La Rioja')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (12, N'Mendoza')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (13, N'Misiones')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (14, N'Neuquen')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (15, N'Rio Negro')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (16, N'Salta')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (17, N'San Juan')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (18, N'San Luis')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (19, N'Santa Cruz')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (20, N'Santa Fe')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (21, N'Santiago del Estero')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (22, N'Tierra del Fuego')
INSERT [dbo].[Provincia] ([id_provincia], [nombre_provincia]) VALUES (23, N'Tucuman')
SET IDENTITY_INSERT [dbo].[Provincia] OFF
SET IDENTITY_INSERT [dbo].[Raza] ON 

INSERT [dbo].[Raza] ([id_raza], [nombre_raza], [estado_raza]) VALUES (1, N'Holando Argentino', 1)
INSERT [dbo].[Raza] ([id_raza], [nombre_raza], [estado_raza]) VALUES (2, N'Yersey', 1)
INSERT [dbo].[Raza] ([id_raza], [nombre_raza], [estado_raza]) VALUES (3, N'Cruza', 1)
INSERT [dbo].[Raza] ([id_raza], [nombre_raza], [estado_raza]) VALUES (4, N'Shorthorn', 1)
INSERT [dbo].[Raza] ([id_raza], [nombre_raza], [estado_raza]) VALUES (5, N'Pardo Suiza', 1)
INSERT [dbo].[Raza] ([id_raza], [nombre_raza], [estado_raza]) VALUES (6, N'Holstein Negro', 1)
INSERT [dbo].[Raza] ([id_raza], [nombre_raza], [estado_raza]) VALUES (7, N'Holstein Rojo', 1)
INSERT [dbo].[Raza] ([id_raza], [nombre_raza], [estado_raza]) VALUES (8, N'Guernsey', 1)
INSERT [dbo].[Raza] ([id_raza], [nombre_raza], [estado_raza]) VALUES (9, N'Pardo Suiza Americana', 1)
INSERT [dbo].[Raza] ([id_raza], [nombre_raza], [estado_raza]) VALUES (10, N'Charolais', 1)
INSERT [dbo].[Raza] ([id_raza], [nombre_raza], [estado_raza]) VALUES (11, N'Limousin', 1)
INSERT [dbo].[Raza] ([id_raza], [nombre_raza], [estado_raza]) VALUES (12, N'Fleck vieh - Simmental', 1)
INSERT [dbo].[Raza] ([id_raza], [nombre_raza], [estado_raza]) VALUES (13, N'Ayrshire', 1)
INSERT [dbo].[Raza] ([id_raza], [nombre_raza], [estado_raza]) VALUES (14, N'Otra', 1)
SET IDENTITY_INSERT [dbo].[Raza] OFF
SET IDENTITY_INSERT [dbo].[Subevento] ON 

INSERT [dbo].[Subevento] ([id_subevento], [nombre_subevento], [estado_subevento]) VALUES (1, N'Sexo cria', 1)
INSERT [dbo].[Subevento] ([id_subevento], [nombre_subevento], [estado_subevento]) VALUES (2, N'Tipo parto', 1)
INSERT [dbo].[Subevento] ([id_subevento], [nombre_subevento], [estado_subevento]) VALUES (3, N'Estado cria', 1)
INSERT [dbo].[Subevento] ([id_subevento], [nombre_subevento], [estado_subevento]) VALUES (4, N'Causa aborto', 1)
INSERT [dbo].[Subevento] ([id_subevento], [nombre_subevento], [estado_subevento]) VALUES (5, N'Causa de no inseminar', 1)
INSERT [dbo].[Subevento] ([id_subevento], [nombre_subevento], [estado_subevento]) VALUES (6, N'Medicacion genital', 1)
INSERT [dbo].[Subevento] ([id_subevento], [nombre_subevento], [estado_subevento]) VALUES (7, N'Via de aplicacion', 1)
INSERT [dbo].[Subevento] ([id_subevento], [nombre_subevento], [estado_subevento]) VALUES (8, N'Especificacion venta', 1)
INSERT [dbo].[Subevento] ([id_subevento], [nombre_subevento], [estado_subevento]) VALUES (9, N'Tipo enfermedad', NULL)
INSERT [dbo].[Subevento] ([id_subevento], [nombre_subevento], [estado_subevento]) VALUES (10, N'Medicamento', 1)
INSERT [dbo].[Subevento] ([id_subevento], [nombre_subevento], [estado_subevento]) VALUES (11, N'Diagnostico utero', 1)
INSERT [dbo].[Subevento] ([id_subevento], [nombre_subevento], [estado_subevento]) VALUES (12, N'Enfermedad utero', 1)
INSERT [dbo].[Subevento] ([id_subevento], [nombre_subevento], [estado_subevento]) VALUES (13, N'Enfermedad ovario', 1)
INSERT [dbo].[Subevento] ([id_subevento], [nombre_subevento], [estado_subevento]) VALUES (14, N'Causa rechazo', 1)
INSERT [dbo].[Subevento] ([id_subevento], [nombre_subevento], [estado_subevento]) VALUES (15, N'Tipo analisis', 1)
INSERT [dbo].[Subevento] ([id_subevento], [nombre_subevento], [estado_subevento]) VALUES (16, N'Especificacion muerte', 1)
INSERT [dbo].[Subevento] ([id_subevento], [nombre_subevento], [estado_subevento]) VALUES (17, N'Inseminador', 1)
SET IDENTITY_INSERT [dbo].[Subevento] OFF
SET IDENTITY_INSERT [dbo].[Tambo] ON 

INSERT [dbo].[Tambo] ([id_tambo], [nombre_tambo], [superficie], [estado_tambo], [id_localidad]) VALUES (1, N'La Luisa', 200.2, 1, 4)
INSERT [dbo].[Tambo] ([id_tambo], [nombre_tambo], [superficie], [estado_tambo], [id_localidad]) VALUES (8, N'Las vacas', 222, 0, 1)
INSERT [dbo].[Tambo] ([id_tambo], [nombre_tambo], [superficie], [estado_tambo], [id_localidad]) VALUES (11, N'qweqw', 121, 0, 6)
INSERT [dbo].[Tambo] ([id_tambo], [nombre_tambo], [superficie], [estado_tambo], [id_localidad]) VALUES (12, N'nbnnb', 4444, 0, 1)
INSERT [dbo].[Tambo] ([id_tambo], [nombre_tambo], [superficie], [estado_tambo], [id_localidad]) VALUES (1008, N'sdsdfs', 2443, 0, 7)
SET IDENTITY_INSERT [dbo].[Tambo] OFF
INSERT [dbo].[Tambo_inseminador] ([id_tambo], [id_inseminador]) VALUES (1, 1)
ALTER TABLE [dbo].[Animal]  WITH CHECK ADD  CONSTRAINT [FK_Animal_Raza] FOREIGN KEY([id_raza])
REFERENCES [dbo].[Raza] ([id_raza])
GO
ALTER TABLE [dbo].[Animal] CHECK CONSTRAINT [FK_Animal_Raza]
GO
ALTER TABLE [dbo].[Animal]  WITH CHECK ADD  CONSTRAINT [FK_Animal_Tambo] FOREIGN KEY([id_tambo])
REFERENCES [dbo].[Tambo] ([id_tambo])
GO
ALTER TABLE [dbo].[Animal] CHECK CONSTRAINT [FK_Animal_Tambo]
GO
ALTER TABLE [dbo].[Control_Animal]  WITH CHECK ADD  CONSTRAINT [FK_Control_Animal_Animal] FOREIGN KEY([rp])
REFERENCES [dbo].[Animal] ([rp])
GO
ALTER TABLE [dbo].[Control_Animal] CHECK CONSTRAINT [FK_Control_Animal_Animal]
GO
ALTER TABLE [dbo].[Control_Animal]  WITH CHECK ADD  CONSTRAINT [FK_Control_Animal_Control] FOREIGN KEY([id_control])
REFERENCES [dbo].[Control] ([id_control])
GO
ALTER TABLE [dbo].[Control_Animal] CHECK CONSTRAINT [FK_Control_Animal_Control]
GO
ALTER TABLE [dbo].[Desc_Subevento]  WITH CHECK ADD  CONSTRAINT [FK_Desc_Subevento_Subevento] FOREIGN KEY([id_subevento])
REFERENCES [dbo].[Subevento] ([id_subevento])
GO
ALTER TABLE [dbo].[Desc_Subevento] CHECK CONSTRAINT [FK_Desc_Subevento_Subevento]
GO
ALTER TABLE [dbo].[Evento_Animal]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Animal_Animal] FOREIGN KEY([rp])
REFERENCES [dbo].[Animal] ([rp])
GO
ALTER TABLE [dbo].[Evento_Animal] CHECK CONSTRAINT [FK_Evento_Animal_Animal]
GO
ALTER TABLE [dbo].[Evento_Animal]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Animal_Evento] FOREIGN KEY([id_evento])
REFERENCES [dbo].[Evento] ([id_evento])
GO
ALTER TABLE [dbo].[Evento_Animal] CHECK CONSTRAINT [FK_Evento_Animal_Evento]
GO
ALTER TABLE [dbo].[Evento_Subevento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Subevento_Evento] FOREIGN KEY([id_evento])
REFERENCES [dbo].[Evento] ([id_evento])
GO
ALTER TABLE [dbo].[Evento_Subevento] CHECK CONSTRAINT [FK_Evento_Subevento_Evento]
GO
ALTER TABLE [dbo].[Evento_Subevento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Subevento_Subevento] FOREIGN KEY([id_subevento])
REFERENCES [dbo].[Subevento] ([id_subevento])
GO
ALTER TABLE [dbo].[Evento_Subevento] CHECK CONSTRAINT [FK_Evento_Subevento_Subevento]
GO
ALTER TABLE [dbo].[EventoAnimal_DescSubevento]  WITH CHECK ADD  CONSTRAINT [FK_EventoAnimal_DescSubevento_Animal] FOREIGN KEY([rp])
REFERENCES [dbo].[Animal] ([rp])
GO
ALTER TABLE [dbo].[EventoAnimal_DescSubevento] CHECK CONSTRAINT [FK_EventoAnimal_DescSubevento_Animal]
GO
ALTER TABLE [dbo].[EventoAnimal_DescSubevento]  WITH CHECK ADD  CONSTRAINT [FK_EventoAnimal_DescSubevento_Desc_Subevento] FOREIGN KEY([id_desc])
REFERENCES [dbo].[Desc_Subevento] ([id_desc])
GO
ALTER TABLE [dbo].[EventoAnimal_DescSubevento] CHECK CONSTRAINT [FK_EventoAnimal_DescSubevento_Desc_Subevento]
GO
ALTER TABLE [dbo].[EventoAnimal_DescSubevento]  WITH CHECK ADD  CONSTRAINT [FK_EventoAnimal_DescSubevento_Evento] FOREIGN KEY([id_evento])
REFERENCES [dbo].[Evento] ([id_evento])
GO
ALTER TABLE [dbo].[EventoAnimal_DescSubevento] CHECK CONSTRAINT [FK_EventoAnimal_DescSubevento_Evento]
GO
ALTER TABLE [dbo].[EventoAnimal_DescSubevento]  WITH CHECK ADD  CONSTRAINT [FK_EventoAnimal_DescSubevento_Inseminador] FOREIGN KEY([id_inseminador])
REFERENCES [dbo].[Inseminador] ([id_inseminador])
GO
ALTER TABLE [dbo].[EventoAnimal_DescSubevento] CHECK CONSTRAINT [FK_EventoAnimal_DescSubevento_Inseminador]
GO
ALTER TABLE [dbo].[EventoAnimal_DescSubevento]  WITH CHECK ADD  CONSTRAINT [FK_EventoAnimal_DescSubevento_Tambo] FOREIGN KEY([id_tambo])
REFERENCES [dbo].[Tambo] ([id_tambo])
GO
ALTER TABLE [dbo].[EventoAnimal_DescSubevento] CHECK CONSTRAINT [FK_EventoAnimal_DescSubevento_Tambo]
GO
ALTER TABLE [dbo].[Inseminador]  WITH CHECK ADD  CONSTRAINT [FK_Inseminador_Localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidad] ([id_localidad])
GO
ALTER TABLE [dbo].[Inseminador] CHECK CONSTRAINT [FK_Inseminador_Localidad]
GO
ALTER TABLE [dbo].[Localidad]  WITH CHECK ADD  CONSTRAINT [FK_Localidad_Provincia] FOREIGN KEY([id_provincia])
REFERENCES [dbo].[Provincia] ([id_provincia])
GO
ALTER TABLE [dbo].[Localidad] CHECK CONSTRAINT [FK_Localidad_Provincia]
GO
ALTER TABLE [dbo].[Tambo]  WITH CHECK ADD  CONSTRAINT [FK_Tambo_Localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidad] ([id_localidad])
GO
ALTER TABLE [dbo].[Tambo] CHECK CONSTRAINT [FK_Tambo_Localidad]
GO
ALTER TABLE [dbo].[Tambo_inseminador]  WITH CHECK ADD  CONSTRAINT [FK_Tambo_inseminador_Inseminador] FOREIGN KEY([id_inseminador])
REFERENCES [dbo].[Inseminador] ([id_inseminador])
GO
ALTER TABLE [dbo].[Tambo_inseminador] CHECK CONSTRAINT [FK_Tambo_inseminador_Inseminador]
GO
ALTER TABLE [dbo].[Tambo_inseminador]  WITH CHECK ADD  CONSTRAINT [FK_Tambo_inseminador_Tambo] FOREIGN KEY([id_tambo])
REFERENCES [dbo].[Tambo] ([id_tambo])
GO
ALTER TABLE [dbo].[Tambo_inseminador] CHECK CONSTRAINT [FK_Tambo_inseminador_Tambo]
GO
