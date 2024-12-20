USE [FersaTesh]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/17/2024 9:32:33 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Alertas]    Script Date: 11/17/2024 9:32:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alertas](
	[AlertasId] [bigint] IDENTITY(1,1) NOT NULL,
	[TransaccionesId] [bigint] NOT NULL,
	[NombreArchivo] [varchar](100) NULL,
	[Descripcion] [varchar](100) NULL,
	[FechaCarga] [datetime] NULL,
	[NumLinea] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AlertasId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BitacoraIncidencias]    Script Date: 11/17/2024 9:32:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BitacoraIncidencias](
	[BitacoraIncidenciasId] [bigint] IDENTITY(1,1) NOT NULL,
	[TransaccionesId] [bigint] NOT NULL,
	[NombreArchivo] [varchar](100) NULL,
	[FechaCarga] [datetime] NULL,
	[Incidencia] [varchar](200) NULL,
	[NumLinea] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[BitacoraIncidenciasId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovementType]    Script Date: 11/17/2024 9:32:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovementType](
	[MovementTypeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[DateCreated] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MovementTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transacciones]    Script Date: 11/17/2024 9:32:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transacciones](
	[TransaccionesId] [bigint] IDENTITY(1,1) NOT NULL,
	[NombreArchivo] [varchar](100) NULL,
	[FechaCarga] [datetime] NULL,
	[TotalProcesados] [int] NULL,
	[TotalAlertas] [int] NULL,
	[TotalIncidencias] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TransaccionesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransaccionesDetalle]    Script Date: 11/17/2024 9:32:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransaccionesDetalle](
	[TransaccionesDetalleId] [bigint] IDENTITY(1,1) NOT NULL,
	[TransaccionesId] [bigint] NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
	[Monto] [decimal](18, 2) NOT NULL,
	[NumLinea] [int] NULL,
	[Fecha] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TransaccionesDetalleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
