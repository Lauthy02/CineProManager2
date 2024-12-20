USE [master]
GO
/****** Object:  Database [CineProManagerTEST2]    Script Date: 21/11/2024 16:53:46 ******/
CREATE DATABASE [CineProManagerTEST2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CineProManagerTEST2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CineProManagerTEST2.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CineProManagerTEST2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CineProManagerTEST2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CineProManagerTEST2] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CineProManagerTEST2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CineProManagerTEST2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET ARITHABORT OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CineProManagerTEST2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CineProManagerTEST2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CineProManagerTEST2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CineProManagerTEST2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CineProManagerTEST2] SET  MULTI_USER 
GO
ALTER DATABASE [CineProManagerTEST2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CineProManagerTEST2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CineProManagerTEST2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CineProManagerTEST2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CineProManagerTEST2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CineProManagerTEST2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CineProManagerTEST2] SET QUERY_STORE = ON
GO
ALTER DATABASE [CineProManagerTEST2] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CineProManagerTEST2]
GO
/****** Object:  Table [dbo].[BITACORACAMBIOS_ENTRADA]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BITACORACAMBIOS_ENTRADA](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idusuarioquemodifica] [int] NULL,
	[fechadecambio] [datetime] NULL,
	[activo] [bit] NULL,
	[b_identrada] [int] NULL,
	[b_idusuario] [int] NULL,
	[b_idfuncion] [int] NULL,
	[b_idsala] [int] NULL,
	[b_butaca] [varchar](50) NULL,
	[b_precio] [float] NULL,
	[b_fechadereserva] [datetime] NULL,
	[b_estado] [varchar](50) NULL,
	[b_digitohorizontal] [varchar](70) NULL,
 CONSTRAINT [PK_BITACORACAMBIOS_ENTRADA] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BITACORAEVENTOS]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BITACORAEVENTOS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idusuario] [int] NULL,
	[fecha] [datetime] NULL,
	[accion] [varchar](50) NULL,
 CONSTRAINT [PK_BITACORAEVENTOS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CARTELERA]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CARTELERA](
	[idcine] [int] NOT NULL,
	[idpelicula] [int] NOT NULL,
 CONSTRAINT [PK_CARTELERA_1] PRIMARY KEY CLUSTERED 
(
	[idcine] ASC,
	[idpelicula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CINE]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CINE](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[zona] [varchar](50) NOT NULL,
	[direccion] [varchar](max) NOT NULL,
 CONSTRAINT [PK_CINE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CINE_SALA]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CINE_SALA](
	[idcine] [int] NOT NULL,
	[idsala] [int] NOT NULL,
 CONSTRAINT [PK_CINES_SALAS] PRIMARY KEY CLUSTERED 
(
	[idcine] ASC,
	[idsala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ENTRADA]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ENTRADA](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idusuario] [int] NOT NULL,
	[idfuncion] [int] NOT NULL,
	[idsala] [int] NULL,
	[butaca] [varchar](50) NOT NULL,
	[precio] [float] NULL,
	[fechadereserva] [datetime] NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[digitohorizontal] [varchar](70) NULL,
 CONSTRAINT [PK_ENTRADA] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ETIQUETA]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ETIQUETA](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ETIQUETA] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FUNCION]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FUNCION](
	[id] [int] NOT NULL,
	[idpelicula] [int] NOT NULL,
	[horario] [datetime] NOT NULL,
 CONSTRAINT [PK_FUNCION_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GOLOSINA]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GOLOSINA](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[precio] [float] NULL,
 CONSTRAINT [PK_GOLOSINA] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IDIOMA]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IDIOMA](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[pordefecto] [bit] NOT NULL,
	[listoparausar] [bit] NOT NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PEDIDO]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PEDIDO](
	[id] [int] NOT NULL,
	[idcliente] [int] NULL,
	[fecha] [datetime] NULL,
	[estado] [varchar](50) NULL,
	[montototal] [float] NULL,
 CONSTRAINT [PK_PEDIDO] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PEDIDO_GOLOSINA]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PEDIDO_GOLOSINA](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idpedido] [int] NOT NULL,
	[idgolosina] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[preciounitario] [float] NOT NULL,
 CONSTRAINT [PK_PEDIDO_GOLOSINA_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PELICULA]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PELICULA](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](50) NOT NULL,
	[director] [varchar](50) NOT NULL,
	[duracion] [int] NOT NULL,
	[genero] [varchar](50) NOT NULL,
	[descripcion] [varchar](max) NOT NULL,
	[imagen] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_PELICULAS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERMISOS]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERMISOS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[tipo] [varchar](50) NULL,
 CONSTRAINT [PK_PERMISOS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERMISOS_PERMISOS]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERMISOS_PERMISOS](
	[idpermisopadre] [int] NOT NULL,
	[idpermisohijo] [int] NOT NULL,
 CONSTRAINT [PK_PERMISOS_PERMISOS] PRIMARY KEY CLUSTERED 
(
	[idpermisopadre] ASC,
	[idpermisohijo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SALA]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALA](
	[id] [int] NOT NULL,
	[numerodesala] [int] NOT NULL,
	[capacidad] [int] NOT NULL,
	[formato] [varchar](50) NOT NULL,
	[precio] [float] NULL,
 CONSTRAINT [PK_SALAS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SALA_FUNCION]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALA_FUNCION](
	[idsala] [int] NOT NULL,
	[idfuncion] [int] NOT NULL,
 CONSTRAINT [PK_SALA_FUNCION] PRIMARY KEY CLUSTERED 
(
	[idfuncion] ASC,
	[idsala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLA_DVV]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLA_DVV](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombretabla] [varchar](50) NULL,
	[digitovertical] [varchar](70) NULL,
 CONSTRAINT [PK_TABLA_DVV] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRADUCCION]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRADUCCION](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ididioma] [int] NOT NULL,
	[idetiqueta] [int] NOT NULL,
	[texto] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TRADUCCION] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[ididioma] ASC,
	[idetiqueta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombredeusuario] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[contrasenia] [varchar](50) NOT NULL,
	[correo] [varchar](50) NOT NULL,
	[ididioma] [int] NULL,
 CONSTRAINT [PK_USUARIO] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOS_PERMISOS]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOS_PERMISOS](
	[idusuario] [int] NOT NULL,
	[idpermiso] [int] NOT NULL,
 CONSTRAINT [PK_USUARIOS_PERMISOS] PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC,
	[idpermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BITACORAEVENTOS] ON 
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1, 1, CAST(N'2024-09-23T09:43:15.913' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2, 1, CAST(N'2024-09-23T09:49:40.423' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3, 1, CAST(N'2024-09-23T09:49:43.677' AS DateTime), N'Abrir GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (4, 1, CAST(N'2024-09-23T09:49:45.800' AS DateTime), N'Cerrar GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (5, 1, CAST(N'2024-09-23T09:51:07.267' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (6, 1, CAST(N'2024-09-23T09:51:57.897' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (7, 1, CAST(N'2024-09-23T09:52:42.710' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (8, 1, CAST(N'2024-09-23T10:01:34.583' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (9, 1, CAST(N'2024-09-23T10:01:36.720' AS DateTime), N'Abrir GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (10, 1, CAST(N'2024-09-23T10:01:39.253' AS DateTime), N'Cerrar GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (11, 1, CAST(N'2024-09-23T10:01:43.163' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (12, 1, CAST(N'2024-09-23T11:03:25.680' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (13, 1, CAST(N'2024-09-23T11:03:59.490' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (14, 1, CAST(N'2024-09-23T11:06:01.343' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (15, 1, CAST(N'2024-09-23T11:07:01.453' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (16, 1, CAST(N'2024-09-23T11:13:57.213' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (17, 1, CAST(N'2024-09-23T11:15:57.797' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (18, 1, CAST(N'2024-09-23T11:25:59.703' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (19, 1, CAST(N'2024-09-23T11:27:00.060' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (20, 1, CAST(N'2024-09-23T11:36:28.613' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (21, 1, CAST(N'2024-09-23T11:42:25.960' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (22, 1, CAST(N'2024-09-23T11:43:04.773' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (23, 1, CAST(N'2024-09-23T13:53:02.183' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (24, 1, CAST(N'2024-09-23T13:59:49.410' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (25, 1, CAST(N'2024-09-23T14:02:20.347' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (26, 1, CAST(N'2024-09-23T14:04:33.870' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (27, 1, CAST(N'2024-09-23T14:05:40.060' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (28, 1, CAST(N'2024-09-23T14:06:22.067' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (29, 1, CAST(N'2024-09-23T14:09:24.430' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (30, 1, CAST(N'2024-09-23T14:10:44.433' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (31, 1, CAST(N'2024-09-23T14:12:20.057' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (32, 1, CAST(N'2024-09-23T14:14:33.707' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (33, 1, CAST(N'2024-09-23T14:16:37.083' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (34, 1, CAST(N'2024-09-23T14:17:56.690' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (35, 1, CAST(N'2024-09-24T19:45:20.927' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (36, 1, CAST(N'2024-09-24T19:51:13.543' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (37, 1, CAST(N'2024-09-24T19:52:14.070' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (38, 1, CAST(N'2024-09-24T19:59:12.770' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (39, 1, CAST(N'2024-09-24T20:02:55.490' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (40, 1, CAST(N'2024-09-24T20:27:32.430' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (41, 1, CAST(N'2024-09-24T20:27:40.743' AS DateTime), N'Abrir GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (42, 1, CAST(N'2024-09-24T20:27:43.970' AS DateTime), N'Cerrar GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (43, 1, CAST(N'2024-09-24T20:28:12.663' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (44, 1, CAST(N'2024-09-25T06:28:25.733' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (45, 1, CAST(N'2024-09-25T08:26:45.727' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (46, 1, CAST(N'2024-09-25T08:26:48.843' AS DateTime), N'Abrir gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (47, 1, CAST(N'2024-09-25T08:26:50.250' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (48, 1, CAST(N'2024-09-27T10:10:50.060' AS DateTime), N'Cerrar gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (49, 1, CAST(N'2024-09-27T11:21:10.760' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (50, 1, CAST(N'2024-09-27T11:26:51.870' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (51, 1, CAST(N'2024-09-27T11:44:44.017' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (52, 1, CAST(N'2024-09-27T11:44:46.303' AS DateTime), N'Abrir gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (53, 1, CAST(N'2024-09-27T11:44:47.487' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (54, 1, CAST(N'2024-09-27T11:47:04.580' AS DateTime), N'Cerrar gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (55, 1, CAST(N'2024-09-27T11:47:08.447' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (56, 1, CAST(N'2024-09-27T11:51:41.060' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (57, 1, CAST(N'2024-09-27T11:51:43.180' AS DateTime), N'Abrir gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (58, 1, CAST(N'2024-09-27T11:51:44.500' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (59, 1, CAST(N'2024-09-27T11:51:47.407' AS DateTime), N'Cerrar gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (60, 1005, CAST(N'2024-09-27T15:58:33.240' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (61, 1, CAST(N'2024-09-27T22:58:47.757' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (62, 1, CAST(N'2024-09-27T22:59:43.290' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (63, 1, CAST(N'2024-09-27T22:59:48.837' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (64, 1, CAST(N'2024-09-27T23:05:59.447' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (65, 1, CAST(N'2024-09-27T23:10:24.737' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (66, 1, CAST(N'2024-09-27T23:14:35.357' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (67, 1, CAST(N'2024-09-27T23:16:53.780' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (68, 1, CAST(N'2024-09-27T23:18:46.323' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (69, 1, CAST(N'2024-09-27T23:33:24.270' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (70, 1, CAST(N'2024-09-27T23:33:26.240' AS DateTime), N'Abrir gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (71, 1, CAST(N'2024-09-27T23:33:27.283' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (72, 1, CAST(N'2024-09-29T12:13:26.990' AS DateTime), N'Cerrar gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (73, 1, CAST(N'2024-09-29T12:13:52.330' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (74, 1, CAST(N'2024-09-29T12:13:54.163' AS DateTime), N'Abrir gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (75, 1, CAST(N'2024-09-29T12:13:54.997' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (76, 1, CAST(N'2024-09-29T12:34:32.727' AS DateTime), N'Cerrar gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (77, 1, CAST(N'2024-09-29T12:35:21.873' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (78, 1, CAST(N'2024-09-29T12:35:25.530' AS DateTime), N'Abrir gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (79, 1, CAST(N'2024-09-29T12:35:27.130' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (80, 1, CAST(N'2024-09-29T15:09:20.570' AS DateTime), N'Cerrar gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (81, 1, CAST(N'2024-09-29T15:09:56.437' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (82, 1, CAST(N'2024-09-29T15:09:59.767' AS DateTime), N'Abrir gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (83, 1, CAST(N'2024-09-29T15:10:00.700' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (84, 1, CAST(N'2024-09-29T15:31:52.620' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (85, 1, CAST(N'2024-09-29T15:31:55.637' AS DateTime), N'Cerrar gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (86, 1, CAST(N'2024-09-29T15:31:58.470' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (87, 4, CAST(N'2024-09-29T15:32:02.347' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (88, 1005, CAST(N'2024-09-29T15:44:26.023' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (89, 1005, CAST(N'2024-09-29T15:47:02.490' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (90, 5, CAST(N'2024-09-29T15:47:19.673' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (91, 5, CAST(N'2024-09-29T15:51:29.407' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (92, 1, CAST(N'2024-09-29T15:51:35.080' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (93, 1, CAST(N'2024-09-29T15:51:37.640' AS DateTime), N'Abrir gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (94, 1, CAST(N'2024-09-29T15:51:39.067' AS DateTime), N'Cerrar gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (95, 1, CAST(N'2024-09-29T15:53:28.167' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (96, 1, CAST(N'2024-09-29T15:58:33.347' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (97, 1, CAST(N'2024-09-29T15:59:16.933' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (98, 1, CAST(N'2024-09-29T16:00:08.470' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (99, 1, CAST(N'2024-09-29T16:03:21.650' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (100, 1, CAST(N'2024-09-29T16:05:36.087' AS DateTime), N'Abrir gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (101, 1, CAST(N'2024-09-29T16:05:37.440' AS DateTime), N'Cerrar gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (102, 1, CAST(N'2024-09-29T16:22:49.857' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (103, 1, CAST(N'2024-09-29T16:23:57.440' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (104, 1, CAST(N'2024-09-29T16:28:38.000' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (105, 1, CAST(N'2024-09-29T16:35:46.467' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (106, 1, CAST(N'2024-09-29T16:40:35.070' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (107, 1, CAST(N'2024-09-29T16:44:19.213' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (108, 1, CAST(N'2024-09-29T16:53:24.480' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (109, 1, CAST(N'2024-09-29T16:58:06.917' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (110, 1, CAST(N'2024-09-29T16:59:56.667' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (111, 1, CAST(N'2024-09-29T17:04:38.557' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (112, 1, CAST(N'2024-09-29T17:09:18.660' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (113, 1, CAST(N'2024-09-29T17:10:15.430' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (114, 1, CAST(N'2024-09-29T17:14:19.127' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (115, 1, CAST(N'2024-09-29T17:21:45.810' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (116, 1, CAST(N'2024-09-29T19:29:45.937' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (117, 1, CAST(N'2024-09-29T19:31:48.430' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (118, 1, CAST(N'2024-09-29T19:34:08.130' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (119, 1, CAST(N'2024-09-29T19:46:03.373' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (120, 1, CAST(N'2024-09-29T19:51:23.530' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (121, 1, CAST(N'2024-09-29T19:57:48.640' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (122, 1, CAST(N'2024-09-29T20:00:24.687' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (123, 1, CAST(N'2024-09-29T20:00:27.027' AS DateTime), N'Abrir gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (124, 1, CAST(N'2024-09-29T20:00:28.437' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (125, 1, CAST(N'2024-09-29T20:01:10.520' AS DateTime), N'Cerrar gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (126, 1, CAST(N'2024-09-29T20:01:13.697' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (127, 1, CAST(N'2024-09-29T20:11:29.090' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (128, 1, CAST(N'2024-09-29T21:29:12.323' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (129, 1, CAST(N'2024-09-29T21:39:17.353' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (130, 1, CAST(N'2024-09-29T21:39:19.310' AS DateTime), N'Abrir Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (131, 1, CAST(N'2024-09-29T21:39:20.857' AS DateTime), N'Cerrar Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (132, 1, CAST(N'2024-09-29T21:39:50.280' AS DateTime), N'Abrir GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (133, 1, CAST(N'2024-09-29T21:39:52.123' AS DateTime), N'Cerrar GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (134, 1, CAST(N'2024-09-29T21:54:27.597' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (135, 1, CAST(N'2024-09-29T21:54:30.460' AS DateTime), N'Abrir gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (136, 1, CAST(N'2024-09-29T21:54:32.397' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (137, 1, CAST(N'2024-09-29T21:54:35.387' AS DateTime), N'Cerrar gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (138, 1, CAST(N'2024-10-02T19:23:51.620' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (139, 1, CAST(N'2024-10-02T19:23:55.930' AS DateTime), N'Abrir Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (140, 1, CAST(N'2024-10-02T19:24:43.857' AS DateTime), N'Cerrar Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (141, 1, CAST(N'2024-10-02T19:24:48.717' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (142, 1, CAST(N'2024-10-02T19:24:56.500' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (143, 1, CAST(N'2024-10-02T19:24:58.540' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (144, 1, CAST(N'2024-10-02T19:25:00.770' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (145, 1, CAST(N'2024-10-02T19:25:04.190' AS DateTime), N'Abrir Bitacora eventos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (146, 1, CAST(N'2024-10-02T19:25:48.207' AS DateTime), N'Cerrar Bitacora eventos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (147, 1, CAST(N'2024-10-02T19:44:44.713' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (148, 1, CAST(N'2024-10-02T19:44:46.803' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (149, 1, CAST(N'2024-10-02T19:45:43.433' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (150, 1, CAST(N'2024-10-02T20:41:57.293' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (151, 1, CAST(N'2024-10-02T20:42:00.743' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (152, 1, CAST(N'2024-10-10T06:51:19.200' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (153, 1, CAST(N'2024-10-10T06:51:22.550' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (154, 1, CAST(N'2024-10-10T07:09:00.853' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (155, 1, CAST(N'2024-10-10T07:09:03.933' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (156, 1, CAST(N'2024-10-10T07:09:25.457' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1152, 1, CAST(N'2024-10-23T08:51:11.860' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1153, 1, CAST(N'2024-10-23T08:51:15.580' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1154, 1, CAST(N'2024-10-23T08:56:00.757' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1155, 1, CAST(N'2024-10-23T09:03:22.320' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1156, 1, CAST(N'2024-10-23T09:03:24.337' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1157, 1, CAST(N'2024-10-23T09:03:26.320' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1158, 1, CAST(N'2024-10-23T12:54:24.503' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1159, 1, CAST(N'2024-10-23T12:54:27.290' AS DateTime), N'Abrir Gestionar cines')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1160, 1, CAST(N'2024-10-23T12:54:29.503' AS DateTime), N'Abrir ABM Cines')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1161, 1, CAST(N'2024-10-23T12:54:32.417' AS DateTime), N'Cerrar ABM Cines')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1162, 1, CAST(N'2024-10-23T12:54:33.010' AS DateTime), N'Cerrar Gestionar cines')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1163, 1, CAST(N'2024-10-23T12:54:34.883' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1164, 1, CAST(N'2024-10-23T12:54:35.943' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1165, 1, CAST(N'2024-10-23T19:49:38.723' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1166, 1, CAST(N'2024-10-23T19:49:41.050' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1167, 1, CAST(N'2024-10-23T19:49:57.183' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1168, 1, CAST(N'2024-10-23T19:53:22.917' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1169, 1, CAST(N'2024-10-23T19:53:26.727' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1170, 1, CAST(N'2024-10-23T19:53:57.833' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1171, 1, CAST(N'2024-10-23T19:56:48.957' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1172, 1, CAST(N'2024-10-23T19:56:51.477' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1173, 1, CAST(N'2024-10-23T19:57:20.953' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1174, 1, CAST(N'2024-10-23T19:59:46.300' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1175, 1, CAST(N'2024-10-23T19:59:48.293' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1176, 1, CAST(N'2024-10-23T20:00:20.523' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1177, 1, CAST(N'2024-10-23T20:35:24.190' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1178, 1, CAST(N'2024-10-23T20:35:28.223' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1179, 1, CAST(N'2024-10-23T20:35:38.420' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1180, 1, CAST(N'2024-10-23T20:36:39.490' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1181, 1, CAST(N'2024-10-23T20:36:42.117' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1182, 1, CAST(N'2024-10-23T20:37:08.230' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1183, 1, CAST(N'2024-10-23T20:40:20.157' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1184, 1, CAST(N'2024-10-23T20:40:22.717' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1185, 1, CAST(N'2024-10-23T20:40:52.863' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1186, 1, CAST(N'2024-10-23T22:30:13.117' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1187, 1, CAST(N'2024-10-23T22:30:15.777' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1188, 1, CAST(N'2024-10-23T22:30:58.063' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1189, 1, CAST(N'2024-10-23T22:32:59.743' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1190, 1, CAST(N'2024-10-23T22:33:02.160' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1191, 1, CAST(N'2024-10-23T22:33:35.903' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1192, 1, CAST(N'2024-10-23T22:46:34.670' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1193, 1, CAST(N'2024-10-23T22:46:37.490' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1194, 1, CAST(N'2024-10-23T22:49:34.047' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1195, 1, CAST(N'2024-10-23T22:49:37.570' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1196, 1, CAST(N'2024-10-23T22:50:41.107' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1197, 1, CAST(N'2024-10-24T19:13:24.437' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1198, 1, CAST(N'2024-10-24T19:13:28.090' AS DateTime), N'Abrir Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1199, 1, CAST(N'2024-10-24T19:15:31.470' AS DateTime), N'Cerrar Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1200, 1, CAST(N'2024-10-24T19:15:34.083' AS DateTime), N'Abrir GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1201, 1, CAST(N'2024-10-24T19:16:34.203' AS DateTime), N'Cerrar GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1202, 1, CAST(N'2024-10-24T19:16:36.417' AS DateTime), N'Abrir Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1203, 1, CAST(N'2024-10-24T19:17:08.183' AS DateTime), N'Cerrar Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1204, 1, CAST(N'2024-10-24T19:17:09.987' AS DateTime), N'Abrir GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1205, 1, CAST(N'2024-10-24T19:17:26.870' AS DateTime), N'Cerrar GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1206, 1, CAST(N'2024-10-24T19:17:29.980' AS DateTime), N'Abrir Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1207, 1, CAST(N'2024-10-24T19:17:32.913' AS DateTime), N'Cerrar Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1208, 1, CAST(N'2024-10-24T19:17:35.823' AS DateTime), N'Abrir GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1209, 1, CAST(N'2024-10-24T19:17:46.200' AS DateTime), N'Cerrar GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1210, 1, CAST(N'2024-10-24T19:17:48.677' AS DateTime), N'Abrir Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1211, 1, CAST(N'2024-10-24T19:57:21.053' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1212, 1, CAST(N'2024-10-24T19:57:23.317' AS DateTime), N'Abrir Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1213, 1, CAST(N'2024-10-24T19:58:55.203' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1214, 1, CAST(N'2024-10-24T19:58:58.470' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1215, 1, CAST(N'2024-10-24T19:58:59.550' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1216, 1, CAST(N'2024-10-24T20:00:05.067' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1217, 1, CAST(N'2024-10-24T20:00:07.923' AS DateTime), N'Abrir Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1218, 1, CAST(N'2024-10-24T20:13:50.017' AS DateTime), N'Cerrar Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1219, 1, CAST(N'2024-10-25T08:11:49.500' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1220, 1, CAST(N'2024-10-25T08:11:54.870' AS DateTime), N'Abrir Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1221, 1, CAST(N'2024-10-25T08:13:21.590' AS DateTime), N'Cerrar Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1222, 1, CAST(N'2024-10-25T08:13:25.113' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1223, 1, CAST(N'2024-10-25T08:13:30.567' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1224, 1, CAST(N'2024-10-25T08:14:51.030' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1225, 1, CAST(N'2024-10-25T08:14:53.563' AS DateTime), N'Abrir ABM Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1226, 1, CAST(N'2024-10-25T08:16:17.967' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1227, 1, CAST(N'2024-10-25T08:16:20.850' AS DateTime), N'Abrir ABM Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1228, 1, CAST(N'2024-10-25T08:17:03.310' AS DateTime), N'Cerrar ABM Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1229, 1, CAST(N'2024-10-25T08:19:08.703' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1230, 1, CAST(N'2024-10-25T08:19:11.273' AS DateTime), N'Abrir gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1231, 1, CAST(N'2024-10-25T08:19:12.513' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (1232, 1, CAST(N'2024-10-25T08:19:16.827' AS DateTime), N'Cerrar gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2232, 1, CAST(N'2024-10-28T12:05:53.207' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2233, 1, CAST(N'2024-10-28T12:05:57.780' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2234, 1, CAST(N'2024-10-28T12:06:05.333' AS DateTime), N'Cerrar Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2235, 1, CAST(N'2024-10-28T12:11:49.173' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2236, 1, CAST(N'2024-10-28T12:11:51.700' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2237, 1, CAST(N'2024-10-28T12:13:35.523' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2238, 1, CAST(N'2024-10-28T12:13:38.053' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2239, 1, CAST(N'2024-10-28T12:13:51.420' AS DateTime), N'Cerrar Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2240, 1, CAST(N'2024-10-28T12:58:41.617' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2241, 1, CAST(N'2024-10-28T12:58:43.710' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2242, 1, CAST(N'2024-10-28T13:00:48.753' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2243, 1, CAST(N'2024-10-28T13:00:51.683' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2244, 1, CAST(N'2024-10-28T13:02:41.170' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2245, 1, CAST(N'2024-10-28T13:02:43.213' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2246, 1, CAST(N'2024-10-28T13:02:56.337' AS DateTime), N'Cerrar Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2247, 1, CAST(N'2024-10-28T13:03:17.063' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2248, 1, CAST(N'2024-10-28T13:03:19.143' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2249, 1, CAST(N'2024-10-28T13:03:37.043' AS DateTime), N'Cerrar Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2250, 1, CAST(N'2024-10-28T14:12:31.177' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2251, 1, CAST(N'2024-10-28T14:12:33.867' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2252, 1, CAST(N'2024-10-28T14:16:39.213' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2253, 1, CAST(N'2024-10-28T14:16:41.157' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2254, 1, CAST(N'2024-10-28T14:19:47.397' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2255, 1, CAST(N'2024-10-28T14:19:49.513' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2256, 1, CAST(N'2024-10-28T14:20:39.940' AS DateTime), N'Cerrar Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2257, 1, CAST(N'2024-10-28T14:24:38.880' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2258, 1, CAST(N'2024-10-28T14:24:41.957' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2259, 1, CAST(N'2024-10-28T14:25:14.583' AS DateTime), N'Cerrar Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2260, 1, CAST(N'2024-10-28T14:26:38.517' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2261, 1, CAST(N'2024-10-28T14:26:40.893' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2262, 1, CAST(N'2024-10-28T14:26:53.830' AS DateTime), N'Cerrar Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2263, 1, CAST(N'2024-10-28T14:27:41.393' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2264, 1, CAST(N'2024-10-28T14:27:44.470' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2265, 1, CAST(N'2024-10-28T14:27:57.543' AS DateTime), N'Cerrar Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2266, 1, CAST(N'2024-10-28T14:28:37.343' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2267, 1, CAST(N'2024-10-28T14:28:39.400' AS DateTime), N'Abrir Marcar entradas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2268, 1, CAST(N'2024-10-28T14:28:40.363' AS DateTime), N'Cerrar Marcar entradas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2269, 1, CAST(N'2024-10-28T14:28:41.897' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2270, 1, CAST(N'2024-10-28T14:32:01.533' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2271, 1, CAST(N'2024-10-28T14:32:04.607' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2272, 1, CAST(N'2024-10-28T14:34:05.873' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2273, 1, CAST(N'2024-10-28T14:34:07.747' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2274, 1, CAST(N'2024-10-28T14:43:58.267' AS DateTime), N'Cerrar Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2275, 1, CAST(N'2024-10-28T14:47:52.667' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2276, 1, CAST(N'2024-10-28T14:47:55.233' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2277, 1, CAST(N'2024-10-28T14:48:41.080' AS DateTime), N'Cerrar Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2278, 1, CAST(N'2024-10-28T14:49:30.517' AS DateTime), N'Abrir GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2279, 1, CAST(N'2024-10-28T14:49:40.820' AS DateTime), N'Cerrar GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2280, 1, CAST(N'2024-10-28T14:49:43.097' AS DateTime), N'Abrir Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2281, 1, CAST(N'2024-10-28T14:50:08.430' AS DateTime), N'Cerrar Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2282, 1, CAST(N'2024-10-28T14:50:11.237' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2283, 1, CAST(N'2024-10-28T14:50:16.707' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2284, 1, CAST(N'2024-10-28T14:50:32.010' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2285, 1, CAST(N'2024-10-28T14:50:33.097' AS DateTime), N'Cerrar Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2286, 1, CAST(N'2024-10-28T14:52:48.770' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2287, 1, CAST(N'2024-10-28T14:52:51.197' AS DateTime), N'Abrir Pedido pagar')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2288, 1, CAST(N'2024-10-28T14:52:55.040' AS DateTime), N'Abrir Entregar pedido')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2289, 1, CAST(N'2024-10-28T14:54:05.060' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2290, 1, CAST(N'2024-10-28T14:54:07.220' AS DateTime), N'Abrir Pedido pagar')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2291, 1, CAST(N'2024-10-28T14:54:12.987' AS DateTime), N'Abrir Entregar pedido')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2292, 1, CAST(N'2024-10-28T14:54:18.273' AS DateTime), N'Cerrar Entregar pedido')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2293, 1, CAST(N'2024-10-28T14:54:18.853' AS DateTime), N'Cerrar Pedido pagar')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2294, 1, CAST(N'2024-10-28T14:56:52.050' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2295, 1, CAST(N'2024-10-28T14:56:54.397' AS DateTime), N'Abrir gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2296, 1, CAST(N'2024-10-28T14:56:55.327' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2297, 1, CAST(N'2024-10-28T14:56:59.050' AS DateTime), N'Cerrar gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2298, 1, CAST(N'2024-10-28T15:06:36.267' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2299, 1, CAST(N'2024-10-28T15:06:39.583' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2300, 1, CAST(N'2024-10-28T15:06:41.317' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2301, 1, CAST(N'2024-10-28T15:06:46.683' AS DateTime), N'Abrir Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2302, 1, CAST(N'2024-10-28T15:07:00.170' AS DateTime), N'Cerrar Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2303, 1, CAST(N'2024-10-28T15:07:25.143' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (2304, 1, CAST(N'2024-10-28T15:08:37.703' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3297, 1, CAST(N'2024-11-02T08:06:22.480' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3298, 1, CAST(N'2024-11-08T13:47:18.323' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3299, 1, CAST(N'2024-11-08T13:48:37.220' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3300, 1, CAST(N'2024-11-08T13:48:42.323' AS DateTime), N'Abrir ABM Peliculas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3301, 1, CAST(N'2024-11-08T13:49:23.537' AS DateTime), N'Cerrar ABM Peliculas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3302, 1, CAST(N'2024-11-08T13:53:39.210' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3303, 1, CAST(N'2024-11-08T13:53:43.880' AS DateTime), N'Abrir gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3304, 1, CAST(N'2024-11-08T13:53:45.120' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3305, 1, CAST(N'2024-11-08T13:53:48.480' AS DateTime), N'Cerrar gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3306, 1, CAST(N'2024-11-08T13:54:57.077' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3307, 1, CAST(N'2024-11-08T13:55:00.813' AS DateTime), N'Abrir ABM Peliculas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3308, 1, CAST(N'2024-11-08T13:55:12.667' AS DateTime), N'Cerrar ABM Peliculas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3309, 1, CAST(N'2024-11-08T13:55:49.250' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3310, 1, CAST(N'2024-11-08T13:55:56.627' AS DateTime), N'Abrir ABM Peliculas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3311, 1, CAST(N'2024-11-08T13:55:58.057' AS DateTime), N'Cerrar ABM Peliculas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3312, 1, CAST(N'2024-11-08T14:07:46.740' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3313, 1, CAST(N'2024-11-08T14:07:49.717' AS DateTime), N'Abrir gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3314, 1, CAST(N'2024-11-08T14:07:50.790' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3315, 1, CAST(N'2024-11-08T14:07:54.233' AS DateTime), N'Cerrar gestor backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3316, 1, CAST(N'2024-11-09T11:52:22.777' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3317, 1, CAST(N'2024-11-09T11:52:27.233' AS DateTime), N'Abrir Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3318, 1, CAST(N'2024-11-09T11:52:44.583' AS DateTime), N'Cerrar Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3319, 1, CAST(N'2024-11-09T11:52:47.550' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3320, 1, CAST(N'2024-11-09T11:52:54.707' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3321, 1, CAST(N'2024-11-09T11:52:57.773' AS DateTime), N'Abrir Gestor serializar')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3322, 1, CAST(N'2024-11-09T11:53:08.293' AS DateTime), N'Abrir ABM Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3323, 1, CAST(N'2024-11-09T11:53:15.990' AS DateTime), N'Cerrar ABM Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3324, 1, CAST(N'2024-11-09T11:53:25.617' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3325, 1, CAST(N'2024-11-09T11:54:03.910' AS DateTime), N'Abrir Pedido pagar')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3326, 1, CAST(N'2024-11-09T11:57:48.240' AS DateTime), N'Cerrar Gestor serializar')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3327, 1, CAST(N'2024-11-09T11:57:48.277' AS DateTime), N'Cerrar Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3328, 1, CAST(N'2024-11-09T11:57:48.280' AS DateTime), N'Cerrar Pedido pagar')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3329, 1, CAST(N'2024-11-09T12:00:20.633' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3330, 1, CAST(N'2024-11-09T12:00:22.693' AS DateTime), N'Abrir Gestor serializar')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3331, 1, CAST(N'2024-11-09T12:03:53.260' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3332, 1, CAST(N'2024-11-09T12:03:56.263' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3333, 1, CAST(N'2024-11-09T12:06:57.603' AS DateTime), N'Abrir Pedido pagar')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3334, 1, CAST(N'2024-11-09T12:07:00.550' AS DateTime), N'Cerrar Pedido pagar')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3335, 1, CAST(N'2024-11-10T11:48:20.667' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3336, 1, CAST(N'2024-11-10T11:48:24.683' AS DateTime), N'Abrir Gestor serializar')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3337, 1, CAST(N'2024-11-10T11:48:31.957' AS DateTime), N'Cerrar Gestor serializar')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3338, 1, CAST(N'2024-11-10T11:48:51.557' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3339, 1, CAST(N'2024-11-10T11:48:54.370' AS DateTime), N'Abrir Gestor serializar')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3340, 1, CAST(N'2024-11-10T11:51:19.707' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3341, 1, CAST(N'2024-11-10T11:51:21.483' AS DateTime), N'Abrir Gestor serializar')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3342, 1, CAST(N'2024-11-10T11:52:06.450' AS DateTime), N'Cerrar Gestor serializar')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3343, 1, CAST(N'2024-11-10T13:49:55.540' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3344, 1, CAST(N'2024-11-10T13:49:58.550' AS DateTime), N'Abrir Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3345, 1, CAST(N'2024-11-10T13:50:00.060' AS DateTime), N'Cerrar Reportes')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3346, 1, CAST(N'2024-11-10T13:50:01.837' AS DateTime), N'Abrir Form_GestorBackup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3347, 1, CAST(N'2024-11-10T13:50:02.700' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3348, 1, CAST(N'2024-11-10T13:50:40.720' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3349, 1, CAST(N'2024-11-10T13:51:04.737' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3350, 1, CAST(N'2024-11-10T13:51:24.033' AS DateTime), N'Cerrar Form_GestorBackup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3351, 1, CAST(N'2024-11-10T14:54:11.223' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3352, 1, CAST(N'2024-11-10T14:54:19.990' AS DateTime), N'Abrir Form_GestorBackup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3353, 1, CAST(N'2024-11-10T14:54:27.553' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3354, 1, CAST(N'2024-11-10T14:55:25.303' AS DateTime), N'Cerrar Form_GestorBackup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3355, 1, CAST(N'2024-11-10T14:58:45.313' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3356, 1, CAST(N'2024-11-10T14:58:48.307' AS DateTime), N'Abrir Form_GestorBackup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3357, 1, CAST(N'2024-11-10T14:58:49.530' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3358, 1, CAST(N'2024-11-10T14:59:04.643' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3359, 1, CAST(N'2024-11-10T14:59:28.537' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3360, 1, CAST(N'2024-11-10T14:59:35.343' AS DateTime), N'Cerrar Form_GestorBackup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3361, 1, CAST(N'2024-11-10T15:00:55.393' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3362, 1, CAST(N'2024-11-10T15:00:57.580' AS DateTime), N'Abrir Bitacora cambios entradas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3363, 1, CAST(N'2024-11-10T15:00:58.853' AS DateTime), N'Cerrar Bitacora cambios entradas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3364, 1, CAST(N'2024-11-10T15:01:01.177' AS DateTime), N'Abrir Form_GestorBackup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3365, 1, CAST(N'2024-11-10T15:01:02.133' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3366, 1, CAST(N'2024-11-10T15:01:07.267' AS DateTime), N'Cerrar Form_GestorBackup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3367, 2, CAST(N'2024-11-11T01:35:28.260' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3368, 2, CAST(N'2024-11-11T01:35:37.113' AS DateTime), N'Abrir ABM Usuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3369, 2, CAST(N'2024-11-11T01:35:56.007' AS DateTime), N'Cerrar ABM Usuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3370, 1, CAST(N'2024-11-21T12:49:21.797' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3371, 1, CAST(N'2024-11-21T12:49:24.423' AS DateTime), N'Abrir Form_GestorBackup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3372, 1, CAST(N'2024-11-21T12:49:25.767' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3373, 1, CAST(N'2024-11-21T12:49:55.227' AS DateTime), N'Cerrar Form_GestorBackup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3374, 1, CAST(N'2024-11-21T12:52:20.467' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3375, 1, CAST(N'2024-11-21T12:52:53.403' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3376, 1, CAST(N'2024-11-21T14:23:09.387' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3377, 1, CAST(N'2024-11-21T14:23:12.610' AS DateTime), N'Abrir Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3378, 1, CAST(N'2024-11-21T14:23:13.640' AS DateTime), N'Cerrar Venta Golosinas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3379, 1, CAST(N'2024-11-21T14:23:19.167' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3380, 1, CAST(N'2024-11-21T14:23:27.503' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3381, 1, CAST(N'2024-11-21T14:23:32.783' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3382, 2, CAST(N'2024-11-21T14:27:17.590' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3383, 2, CAST(N'2024-11-21T14:27:24.263' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3384, 1, CAST(N'2024-11-21T14:29:37.010' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3385, 1, CAST(N'2024-11-21T14:29:42.940' AS DateTime), N'Abrir ABM Usuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3386, 1, CAST(N'2024-11-21T14:30:47.063' AS DateTime), N'Cerrar ABM Usuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3387, 1, CAST(N'2024-11-21T14:30:50.347' AS DateTime), N'Abrir GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3388, 1, CAST(N'2024-11-21T14:32:18.717' AS DateTime), N'Cerrar GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3389, 1, CAST(N'2024-11-21T14:32:29.497' AS DateTime), N'Abrir ABM Usuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3390, 1, CAST(N'2024-11-21T14:32:33.167' AS DateTime), N'Abrir GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3391, 1, CAST(N'2024-11-21T14:32:34.593' AS DateTime), N'Cerrar GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3392, 1, CAST(N'2024-11-21T14:32:35.277' AS DateTime), N'Cerrar ABM Usuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3393, 1, CAST(N'2024-11-21T14:32:37.493' AS DateTime), N'Abrir Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3394, 1, CAST(N'2024-11-21T14:36:07.183' AS DateTime), N'Cerrar Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3395, 1, CAST(N'2024-11-21T14:36:16.103' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3396, 2007, CAST(N'2024-11-21T14:36:21.160' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3397, 2007, CAST(N'2024-11-21T14:36:28.937' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3398, 2007, CAST(N'2024-11-21T14:38:55.587' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3399, 2007, CAST(N'2024-11-21T14:38:58.433' AS DateTime), N'Abrir ABM Usuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3400, 2007, CAST(N'2024-11-21T14:40:50.493' AS DateTime), N'Cerrar ABM Usuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3401, 2007, CAST(N'2024-11-21T14:40:52.260' AS DateTime), N'Abrir GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3402, 2007, CAST(N'2024-11-21T14:43:26.577' AS DateTime), N'Cerrar GestorPermisosUsuarios')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3403, 2007, CAST(N'2024-11-21T14:43:29.797' AS DateTime), N'Abrir Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3404, 2007, CAST(N'2024-11-21T14:44:03.867' AS DateTime), N'Cerrar Permisos')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3405, 2007, CAST(N'2024-11-21T14:44:32.110' AS DateTime), N'Abrir Form_GestorBackup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3406, 2007, CAST(N'2024-11-21T14:44:36.330' AS DateTime), N'Crear backup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3407, 2007, CAST(N'2024-11-21T14:44:40.670' AS DateTime), N'Cerrar Form_GestorBackup')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3408, 2007, CAST(N'2024-11-21T14:52:09.357' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3409, 2007, CAST(N'2024-11-21T14:52:13.970' AS DateTime), N'Abrir Cartelera')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3410, 2007, CAST(N'2024-11-21T14:52:26.400' AS DateTime), N'Cerrar Cartelera')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3411, 2007, CAST(N'2024-11-21T14:53:13.203' AS DateTime), N'Abrir Cartelera')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3412, 2007, CAST(N'2024-11-21T14:53:26.020' AS DateTime), N'Cerrar Cartelera')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3413, 2007, CAST(N'2024-11-21T16:38:30.470' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3414, 2007, CAST(N'2024-11-21T16:38:42.327' AS DateTime), N'Abrir Cartelera')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3415, 2007, CAST(N'2024-11-21T16:38:43.837' AS DateTime), N'Cerrar Cartelera')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3416, 2007, CAST(N'2024-11-21T16:38:45.237' AS DateTime), N'Abrir Pagar entradas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3417, 2007, CAST(N'2024-11-21T16:38:46.063' AS DateTime), N'Cerrar Pagar entradas')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3418, 2007, CAST(N'2024-11-21T16:40:23.437' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3419, 2007, CAST(N'2024-11-21T16:40:26.210' AS DateTime), N'Abrir Cartelera')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3420, 2007, CAST(N'2024-11-21T16:40:47.383' AS DateTime), N'Cerrar Cartelera')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3421, 2007, CAST(N'2024-11-21T16:41:06.613' AS DateTime), N'LogOut')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3422, 2007, CAST(N'2024-11-21T16:44:54.630' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3423, 2007, CAST(N'2024-11-21T16:44:56.917' AS DateTime), N'Abrir Gestor serializar')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3424, 2007, CAST(N'2024-11-21T16:45:09.297' AS DateTime), N'Cerrar Gestor serializar')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3425, 2007, CAST(N'2024-11-21T16:46:59.217' AS DateTime), N'LogIn')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3426, 2007, CAST(N'2024-11-21T16:47:01.310' AS DateTime), N'Abrir Gestor serializar')
GO
INSERT [dbo].[BITACORAEVENTOS] ([id], [idusuario], [fecha], [accion]) VALUES (3427, 2007, CAST(N'2024-11-21T16:47:09.150' AS DateTime), N'Cerrar Gestor serializar')
GO
SET IDENTITY_INSERT [dbo].[BITACORAEVENTOS] OFF
GO
INSERT [dbo].[CARTELERA] ([idcine], [idpelicula]) VALUES (1, 3)
GO
INSERT [dbo].[CARTELERA] ([idcine], [idpelicula]) VALUES (1, 7)
GO
INSERT [dbo].[CARTELERA] ([idcine], [idpelicula]) VALUES (1, 8)
GO
INSERT [dbo].[CARTELERA] ([idcine], [idpelicula]) VALUES (1, 9)
GO
INSERT [dbo].[CARTELERA] ([idcine], [idpelicula]) VALUES (2, 10)
GO
INSERT [dbo].[CARTELERA] ([idcine], [idpelicula]) VALUES (2, 11)
GO
INSERT [dbo].[CARTELERA] ([idcine], [idpelicula]) VALUES (2, 13)
GO
INSERT [dbo].[CARTELERA] ([idcine], [idpelicula]) VALUES (4, 24)
GO
INSERT [dbo].[CARTELERA] ([idcine], [idpelicula]) VALUES (4, 25)
GO
INSERT [dbo].[CARTELERA] ([idcine], [idpelicula]) VALUES (4, 26)
GO
SET IDENTITY_INSERT [dbo].[CINE] ON 
GO
INSERT [dbo].[CINE] ([id], [nombre], [zona], [direccion]) VALUES (1, N'Hoyts', N'Abasto', N'Av. Corrientes 3247 1193 Buenos Aires Ciudad autónoma de Buenos Aires')
GO
INSERT [dbo].[CINE] ([id], [nombre], [zona], [direccion]) VALUES (2, N'Cinemark', N'Avellaneda', N'Av. Güemes 897 1872 Avellaneda Buenos Aires')
GO
INSERT [dbo].[CINE] ([id], [nombre], [zona], [direccion]) VALUES (4, N'Hoyts', N'Temperley', N'Av. Hipólito Yrigoyen 10699 1834 Temperley Buenos Aires')
GO
INSERT [dbo].[CINE] ([id], [nombre], [zona], [direccion]) VALUES (6, N'Cinemark', N'Caballito', N'Avenida La Plata 96 1184 Buenos Aires Ciudad autónoma de Buenos Aires')
GO
INSERT [dbo].[CINE] ([id], [nombre], [zona], [direccion]) VALUES (7, N'Hoyts', N'Morón', N'J.M. de Rosas 658 1708 Morón Buenos Aires')
GO
INSERT [dbo].[CINE] ([id], [nombre], [zona], [direccion]) VALUES (8, N'Cinemark', N'Palermo', N'Beruti 3399 1425 Buenos Aires Ciudad autónoma de Buenos Aires')
GO
SET IDENTITY_INSERT [dbo].[CINE] OFF
GO
INSERT [dbo].[CINE_SALA] ([idcine], [idsala]) VALUES (1, 1)
GO
INSERT [dbo].[CINE_SALA] ([idcine], [idsala]) VALUES (1, 4)
GO
INSERT [dbo].[CINE_SALA] ([idcine], [idsala]) VALUES (1, 5)
GO
INSERT [dbo].[CINE_SALA] ([idcine], [idsala]) VALUES (1, 6)
GO
INSERT [dbo].[CINE_SALA] ([idcine], [idsala]) VALUES (2, 2)
GO
INSERT [dbo].[CINE_SALA] ([idcine], [idsala]) VALUES (2, 7)
GO
INSERT [dbo].[CINE_SALA] ([idcine], [idsala]) VALUES (4, 3)
GO
INSERT [dbo].[CINE_SALA] ([idcine], [idsala]) VALUES (8, 8)
GO
SET IDENTITY_INSERT [dbo].[ETIQUETA] ON 
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1, N'Guardar')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (2, N'Entrar')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1002, N'Sesion')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1003, N'Gestores')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1004, N'Cine')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1005, N'Idiomas')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1006, N'IniciarSesion')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1007, N'CerrarSesion')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1008, N'PermisosDeUsuarios')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1009, N'Permisos')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1010, N'ABMUsuarios')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1011, N'ABMPeliculas')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1012, N'ABMCines')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1013, N'Cartelera')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1014, N'Cines')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1015, N'FormIniciarSesion (no se usa)')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1016, N'NombreDeUsuario')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1017, N'Contrasenia')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1018, N'Agregar')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1019, N'GuardarCambios')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1020, N'TodosLosUsuarios')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1021, N'AgregarAccionesPatentes')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1022, N'AgregarRolesFamilias')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1023, N'Configurar')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1024, N'Acciones')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1025, N'Roles')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1026, N'Nombre')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1027, N'ConfigurarRoles')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1028, N'NuevaAccion')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1029, N'NuevoRol')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1030, N'TodasLasAcciones')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1031, N'TodosLosRoles')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1032, N'Apellido')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1033, N'CorreoElectronico')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1034, N'Alta')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1035, N'Baja')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1036, N'Modificacion')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1037, N'Titulo')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1038, N'Director')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1039, N'Duracion')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1040, N'Genero')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1041, N'Descripcion')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1042, N'Imagen')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1043, N'BuscarImagen')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1044, N'Zona')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1045, N'Direccion')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1046, N'SeleccioneCine')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1047, N'Peliculas')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1048, N'SeleccionePelicula')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1049, N'DetallesPelicula')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1050, N'ComprarEntradas')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1051, N'IdiomaDelUsuario')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1052, N'GestionarPermisosDeUsuarios')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1053, N'GestionarPermisos')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1054, N'ReservarEntradas')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1055, N'PagarEntradas')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1056, N'EmitirEntradas')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1057, N'MarcarEntradas')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1058, N'GestionarCines')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1059, N'ABMSalas')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1060, N'Capacidad')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1061, N'NumeroDeSala')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1062, N'Formato')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1063, N'ABMFunciones')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1064, N'Horario')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1065, N'SeleccioneSala')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1066, N'Sala')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1067, N'Anio')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1068, N'Mes')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1069, N'Dia')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1070, N'Butaca')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1071, N'ConfirmarLoSeleccionado')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1072, N'Butacas')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1073, N'Pelicula')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1075, N'NumeroDeFuncion')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1076, N'EstablecerEntradaComoPagada')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1077, N'EstablecerEntradaComoEmitida')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1078, N'EstablecerEntradaComoUtilizada')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1079, N'EstablecerEntradaComoVencida')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1080, N'SeleccioneFuncion')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1081, N'ABMIdiomas')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1082, N'ListoParaUsar')
GO
INSERT [dbo].[ETIQUETA] ([id], [nombre]) VALUES (1083, N'Precio')
GO
SET IDENTITY_INSERT [dbo].[ETIQUETA] OFF
GO
INSERT [dbo].[FUNCION] ([id], [idpelicula], [horario]) VALUES (13, 3, CAST(N'2024-07-11T12:10:00.000' AS DateTime))
GO
INSERT [dbo].[FUNCION] ([id], [idpelicula], [horario]) VALUES (14, 3, CAST(N'2024-07-11T13:40:00.000' AS DateTime))
GO
INSERT [dbo].[FUNCION] ([id], [idpelicula], [horario]) VALUES (15, 3, CAST(N'2024-07-11T16:00:00.000' AS DateTime))
GO
INSERT [dbo].[FUNCION] ([id], [idpelicula], [horario]) VALUES (16, 3, CAST(N'2024-07-11T16:50:00.000' AS DateTime))
GO
INSERT [dbo].[FUNCION] ([id], [idpelicula], [horario]) VALUES (17, 3, CAST(N'2024-07-11T18:20:00.000' AS DateTime))
GO
INSERT [dbo].[FUNCION] ([id], [idpelicula], [horario]) VALUES (18, 7, CAST(N'2024-07-11T12:10:00.000' AS DateTime))
GO
INSERT [dbo].[FUNCION] ([id], [idpelicula], [horario]) VALUES (19, 8, CAST(N'2024-07-11T12:10:00.000' AS DateTime))
GO
INSERT [dbo].[FUNCION] ([id], [idpelicula], [horario]) VALUES (20, 26, CAST(N'1900-01-01T16:50:00.000' AS DateTime))
GO
INSERT [dbo].[FUNCION] ([id], [idpelicula], [horario]) VALUES (21, 26, CAST(N'1900-01-01T18:20:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[GOLOSINA] ON 
GO
INSERT [dbo].[GOLOSINA] ([id], [nombre], [precio]) VALUES (1, N'Pochoclo chico', 10)
GO
INSERT [dbo].[GOLOSINA] ([id], [nombre], [precio]) VALUES (2, N'Pochoclo mediano', 20)
GO
INSERT [dbo].[GOLOSINA] ([id], [nombre], [precio]) VALUES (3, N'Pochoclo grande', 40)
GO
INSERT [dbo].[GOLOSINA] ([id], [nombre], [precio]) VALUES (4, N'CocaCola 250ml', 35)
GO
SET IDENTITY_INSERT [dbo].[GOLOSINA] OFF
GO
SET IDENTITY_INSERT [dbo].[IDIOMA] ON 
GO
INSERT [dbo].[IDIOMA] ([id], [nombre], [pordefecto], [listoparausar]) VALUES (2, N'Espaniol', 1, 1)
GO
INSERT [dbo].[IDIOMA] ([id], [nombre], [pordefecto], [listoparausar]) VALUES (3, N'English', 0, 1)
GO
INSERT [dbo].[IDIOMA] ([id], [nombre], [pordefecto], [listoparausar]) VALUES (11, N'Deutsch', 0, 0)
GO
SET IDENTITY_INSERT [dbo].[IDIOMA] OFF
GO
INSERT [dbo].[PEDIDO] ([id], [idcliente], [fecha], [estado], [montototal]) VALUES (1, 1, CAST(N'2024-10-28T14:34:14.000' AS DateTime), N'Entregado', 0)
GO
INSERT [dbo].[PEDIDO] ([id], [idcliente], [fecha], [estado], [montototal]) VALUES (2, 1, CAST(N'2024-10-28T14:48:16.063' AS DateTime), N'Reservado', 110)
GO
INSERT [dbo].[PEDIDO] ([id], [idcliente], [fecha], [estado], [montototal]) VALUES (3, 1, CAST(N'2024-11-09T11:53:38.650' AS DateTime), N'Reservado', 110)
GO
INSERT [dbo].[PEDIDO] ([id], [idcliente], [fecha], [estado], [montototal]) VALUES (4, 1, CAST(N'2024-11-09T12:04:03.633' AS DateTime), N'Reservado', 45)
GO
INSERT [dbo].[PEDIDO] ([id], [idcliente], [fecha], [estado], [montototal]) VALUES (5, 1, CAST(N'2024-11-09T12:05:11.823' AS DateTime), N'Reservado', 155)
GO
SET IDENTITY_INSERT [dbo].[PEDIDO_GOLOSINA] ON 
GO
INSERT [dbo].[PEDIDO_GOLOSINA] ([id], [idpedido], [idgolosina], [cantidad], [preciounitario]) VALUES (23, 1, 1, 2, 10)
GO
INSERT [dbo].[PEDIDO_GOLOSINA] ([id], [idpedido], [idgolosina], [cantidad], [preciounitario]) VALUES (24, 1, 4, 1, 35)
GO
INSERT [dbo].[PEDIDO_GOLOSINA] ([id], [idpedido], [idgolosina], [cantidad], [preciounitario]) VALUES (25, 2, 4, 2, 35)
GO
INSERT [dbo].[PEDIDO_GOLOSINA] ([id], [idpedido], [idgolosina], [cantidad], [preciounitario]) VALUES (26, 2, 3, 1, 40)
GO
INSERT [dbo].[PEDIDO_GOLOSINA] ([id], [idpedido], [idgolosina], [cantidad], [preciounitario]) VALUES (27, 3, 4, 2, 35)
GO
INSERT [dbo].[PEDIDO_GOLOSINA] ([id], [idpedido], [idgolosina], [cantidad], [preciounitario]) VALUES (28, 3, 3, 1, 40)
GO
INSERT [dbo].[PEDIDO_GOLOSINA] ([id], [idpedido], [idgolosina], [cantidad], [preciounitario]) VALUES (29, 4, 1, 1, 10)
GO
INSERT [dbo].[PEDIDO_GOLOSINA] ([id], [idpedido], [idgolosina], [cantidad], [preciounitario]) VALUES (30, 4, 4, 1, 35)
GO
INSERT [dbo].[PEDIDO_GOLOSINA] ([id], [idpedido], [idgolosina], [cantidad], [preciounitario]) VALUES (31, 5, 2, 4, 20)
GO
INSERT [dbo].[PEDIDO_GOLOSINA] ([id], [idpedido], [idgolosina], [cantidad], [preciounitario]) VALUES (32, 5, 3, 1, 40)
GO
INSERT [dbo].[PEDIDO_GOLOSINA] ([id], [idpedido], [idgolosina], [cantidad], [preciounitario]) VALUES (33, 5, 4, 1, 35)
GO
SET IDENTITY_INSERT [dbo].[PEDIDO_GOLOSINA] OFF
GO
SET IDENTITY_INSERT [dbo].[PELICULA] ON 
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (3, N'Volver al futuro', N'Robert Zemeckis', 117, N'Ciencia_ficcion', N'Marty McFly, un estudiante de secundaria de 17 años, es enviado accidentalmente treinta años al pasado en un DeLorean que viaja en el tiempo, inventado por su gran amigo, el excéntrico científico Doc Brown.', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00E0CDC205618C71C56F5969705FE9D6B790C49B5A5114C00EE78FE783F8D731BD08EC722BABF04F8974DD212EED7508AE248E565785608F79DDDF8CFB0FCAA71B3AB1A7CD4F56BA77E8FF00CCAC32845BE65A3F9DBAFF00C01D368F6D0457CC2DC3B5980D220EB823391F867F2A6DD786A1B8B069AD1033B43E74447F18EBFE7F0A92D7C576B6BE27D52FEFAC6EBFB3AF54C423F2F0E00FBBC1C0CE339FAD7776DA6BE9F69A74765A5489042723ED379106F2D81E3AFA91D7D2BCCAB8AAD46D77ABB6ED5B6D56AFB9D12AD4A5F655BC96BBEFA2EC797691A4DA6A764CE899921702650C7953FC5FE7D0D68FFC22B6CF24C91DBC92490B8478D1F919190793D315D7DA58D869DACE9E2C340686E7545765CDD821E3037364738EA31441A4DD5D6B7A96B0EBA71D26E6016F340F7BB4A15E016603039CFE0689E3A7CCE49D96EAED6F7B5B4F9D8CA1568A8D9C6EFD1F6DF638DB8F088FB33BC314824542F86E808EAA7DEA8FFC21FAACB6105DDB59F991CB109082704679E077E315E8915BCB6296B65A45A5A46BA94AC2D7374D320280977395E50800707B8229F1DB6AB15AB8D22FEC749F362965FB3B4AD2A6D43832A294F9067078E0E7A53FED0AF1564D6FA5FB75BDB53294A849A7CBD3A69AF7D51E547C3FAA019168AC3191B1C1DDC6463D7201C7AE0FA566C728047CA304E7A57A24FA3EBD069D777775E2AB786E6D6D45ECF6CB0731866F314160300971903B1CF635E6CD746599A590E5DD8B371D493935E9D0C47B5BB4F6F5FD4CE11BF41D081B72DE95AFE1FD623D12EE5BC589DE63198D369C6D07EF1CF5071C553F2411C0EBED517944640208FD6B59C39972B5A1B46DD0EAB51F1547E2692D6DEE6D650B03F9A19A6181D33918E49000EBDEA4D47C5E350D4FCB9ACAC6541FBBF3A64DECA3BE0F4F5C571A6304F247E35E87A2FC28BA9B4C8EFF0058D521D29255DD1C32283211DBAB0009F4AE6950A51B36B6BDBE7B9B2768B56DDEA5593C5417525D463903CB0DA9B7B6894E7664E4F4F5C01F4158D35EADA7851B4ADE42DE4E24BB91472D9393FC87E5572E343B6B5D424B581F5079A2FF00586EE248C63D4619B39ED497D65673CC96CEE2311C62426470AA7270066A29D0A5A25E5BF96DF89A55AB7BC9452DF62CC7E32B182EA09E313016F6DF66851578893BE3DCE00CFB53AE3C74B35B8492DAE0468C388D7019074563E9EA2B39F454B7B841240548FE123FCE6AE0D3239D48F2FE8BF5AEB8E554E4937D3638A78F57D236BF9195AC788E6D66D2E6DADA19635BB9C4D72F2382D2100051FEE8C0E3DAB9C92230E148C377AEEA5F0FADAC2C0E3CC71C03DBDAB9E9F4BB9591CEC462BF367A607A552C2FB38DA0B41C711193BB218DB3827E5AB1E4E54155CD6579E470A6BA3F0D490DDDD0B59982B755F7F6AED94125739D49A373C05E1D6B9D65B54B8B26B9B6D3C093CBC643B93F28FC393F857517D7DAFEB9E21DDB258632DF25AC0A0123B6F3D5BDF902BADF04C02C018211FBB993CE909E31D971F5E6B775CFB0D959497D35B6F9148C04254C87B038EA3EB5E649A94D9D6A4D455CF32B0F006B56F7D308E65FB2B2B487CC747457C67695E8A324818E9552EFC39ACB5EDE5B40B2DE436916247054C28D8CB4680A9C1031F5C9F6ADDB8D5755D63CD9264416F6EBE62DAAE5538238207DEFC6B9DF0B6A5797BA86B3345AA4DA60DA527BB91576348C49270DC703273C1F4ACEA52517693FEBB1B52AADBD17F5DCC0D474FBBD2F5CB4B48AEE7B98640639BCD7F91A4032405232801C62BA3D3AC469D60B77329F319731C4E4641EE4E38E2B32DADF45D76C16FAF7C5F1F9F6D1859196D5C6D393B4B1EF9C75EF59D717F79A9788EDECED6EE3BDB094A2B9898393C7CDD3951C67B7BD6985ACE0F964F4F2162E946515382FBCB1717B35CCE593E6407973DFE9503C2F73992566588718C75AE8068ED04789402E07DC5E82A95DA10A119B1923806BDA4D4B44793CAE3AD8F3586D9E6976A633D87AD6CDA689A8A95B98540F2D87CD9C60D654426DE0A0E7EB5B7629AA798AD04615FB7CE0FF00335949C52DCDE9A727B1EE9E0DD5EDDF4B82CA4B498DE7940CB26570E47BE7DEB4358BCB569A2B4B83222280725772A64E32C41E05796F865F55B3D4FED77C92192205E34444CBB7F7491D88A9241A8DFC1A84BA9CCD15CC8ACEAACB80C7B2820FE15E549C60EC99E9428B96AD1EA23C36570C8EBEBF29C57947C62D4D743D362D06DA602EAFC996E5011C463804FB9C607B035E87E08F149BEB44D26FC98AFA0B65912471C3A63073FED29EBF8578B7C41D06D53C43757635C93529E76DD23980E57DB39C7B6054BBCD7731E7E5DF46644567FD97651C73BB47F6EB5DA50718390C99EF8391F9D7A9781A3B383C0B6F33C2B1CC9238130C7CCACC4953DF231DEBC9F58B84D42C2C92D12496E63E09258BA81FCC7F2C57A37C3D82EA4D1A7D3AF09843482E444CB86208C71ED91FCAB0A919464A48E8A352138F24CBDA8DFBCCCC21E06719EF597169F34928620A82DD4D75971676F69F71557D49EB556F750B230451C5130941F9D81E0D6DFDA0A9AD59D6B031A96E489E2E926D3915A769AA490B0E7E5CF2476ACDB30D7B751DBC16EECD23003D4FE02BA0D734C874175B27DD34C4876645C03C71FD6B96B62E57507BB230F84D1CA2F446A7FC243756B0845BB658CF4DBCFE5DE90EB42F62F9EEDDA45192D24842A8F4FAFD2B9F7C83E4A59B348E005214F19FAE79AAF7FF0069B331A4B0ED60BF77FC6B89DE6D26F53D1578A72B592F23A9D175836BADDBCA4992156DB20504E51B86C7E1FCABD82E3C29A2F92B3B5B24C4F209E983ED5F3C5B5FDEC454A40B92372B60F03D6BDEF4DBC923F03E92F39DB23DB82735D58694E9DE3D0F3B174E151C65D7D0C2F12E8B6775A63C1676B6F05CC7F35B48AA06D61DB8EC7A1AF3BD0BC5777FDA9A58B9CC73C1726DA65C60EC93820FD1803F857757D7570CCFE58DF8E4E3B0AF35F1369F796F7D26BD6B2FD99B2AFEA4C9918231D01EB93FD6952AF37395396CF60C4E1631A71AB0E8F53D47569EDFCC1E5B3150392FD73DEB9DB8BD822F99E4445CF5638AE7351D4F54BBB64B88E789239543AA81C80467AD71F7BF6A91CB4AC5DB3D4B66B8165F56A4AF5256F43D2866B468C2D4E2DBF3D0F5AD134AD3B43D7E46DA44702A88E57C0539EA724FEB4FD53FE11D8F5CB9D46E7558D9E404C487E6C1C7B578D4FAA5FEA0FBAE6EA698FF00B6E4D4D67A65FDFC852DA19242064E07007BD6FF0052924DD49FF5EA73AC7A9497B38FF5E963D386BDE1A8611124CF2800302AADBB7F7E4D58B9B8D3F5B821922B299D8C9E5AA64076078DC4F61D8571765E0EBB3622F2E1C2A9E4246431C7BF381F8D7A4E90E6DACA458479B7091795C800A85FBA4FF4AE1AD0A7092E4773D0A556ACA379AB7642E99A5D94DA15D5CCB62906D72A12339381C1EBD067B568DD5D3ABC514B771C36712AB6180CC6B8EC6AA5D5CCF0692EF232AC8CBBD43A603391CF1ED5E37ACEB1797B725E791B3E9D85561E152A4BDDD17532AF38D38B9CF5D743D5F50D6624121D29432CA49F35BBE7D05725A84B2EA36B7F6B76AECCD0EFDD1AE5998107005723A6EBB7360DC3EE8FBA31E2BD0FC25AC695712B6A0C5FCF806444A46F2482381DEBD8A34141DD6E7895F132A8B95EC72D61A8A9D12D6D656293C3100D1B820E3B633ED58D76C3CC273919ED5AFA9CAED793CB1E857D1127249181F5C7358D72A663E6DBE9D75111C3A8E467F2AD9C6CCE753563180F2DBE52455F8353BDB62BE4DCC89F434514AAA474619B52D0D3B7F14EB08BB05D02BCF0635FF0A9ADBC5FAC8B846F3D3F76CAC06C0067F0A28AE19C23AE87A909CACB524D43C5BAB5D993CE991B8FEE573B34AF2C84B9C9A28AD30C919E35BE44427FD49A8812B8752430E84514576A3C691A50F88354B6063176F227F7643B856A5BDF4CF2C721DB9623200E0D1455A323FFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (7, N'El expreso polar', N'Robert Zemeckis', 100, N'Animacion', N'Esta es la historia de un jovencito en la víspera de Navidad quien aborda un poderoso y mágico tren que se dirige al hogar de Papá Noel, en el Polo Norte. Lo que se desarrolla es una aventura que sigue al dubitativo niño, quien toma un tren extraordinario al Polo Norte; durante este viaje, se embarca en una experiencia de autodescubrimiento que le muestra que las maravillas de la vida nunca se desvanecen para quienes creen.', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00E0C9432B0214E3D0F4A7ACB1A8CB286DA3B1EF54AD5E18F5102653E593C8C67B539CC7E42796C04996DD853939C639C7D6BB6552D3E5B1C8A1757B9A76FAAC6F341F2B29563E6631C8ED8CFB56FCA60BF52D22C8A8506D0300E71C939AC5B43049346A114AEC55384E436064F4F5C9F7E7D6BA1B6B62D0051C808173B7E62C73D3DB91F9564EBB4BE1653A69BDD1C62E977AD7815ACAE9E1624111C67E6E0E307EB4B3786E58E0BAB96B4BB8955BF74CE000A33D1BDF15DBC9A54D3281E612A8EC582361480781D7B0FE7558E948A442EF2932820452499C939C13E98E297B74FECB3449A5BA3935B6B4C5BED8A511820DC61864F4CEDFD7AD55860012540CEB9906C38E368CE770FCABBABBF0CA6C74820C22264311C96E7F3EA33F4AAD69A3EF0900B590E38674419638FD2AE352F2B72B13768DEE8E7F48D1DE6BA8D562FBA70001C0F7AF56D32C4C1045124B9218670A3355F4AD02F23817ECF6F22DC1209655F940DA4F53EE0575E618AD2086564D842AE43000E7DC0EF535316BE08A6BD4985377E793B9F2F4975BE7240E8DD2ADC53EFC055073D2B0926C3B20FBC4E073D2B4AD01C029C91C13E9ED5AA776128D91D058AB6E05C71F957A1787600F6E1091F39E8464FD2BCE2D1A58DC3336EF4EF5D6E97AB3DBB248C4AC6A41E056DCBCD1D0E494F965A9E99A769C0405638155989DC303AD497BA446906FF2D3728EB8C550F0EF8C2D2EAE16DF2006E80FDE26B47C4BE26F0F8B6B8D3975CB24D402902332720819233D338AE692719599D1171946E8E26EAFD6495A08B0C5495E4F7ADCF0FE98907CC57323F6AE53C3DA85B6B77D65656292CC6DDE43717260DA8E7B05E7381EA7AFA57B1E9BA48B7895D97E6C7E54BEB49526D2B3D507B07CFEF0E8225B5B6EBDB26B87F18EBCB04654B0555191CD763ACDD0B7B66ED853F857CF9E38D78CF78D142FF2027247358D08733E799AB96BCB1DCF34057CDF41EBED5AD652E31962AA39C13590E18B6581DC4F4353C0E40CB16CFA63AD6D17665C95D1D759DC42319E00F4EF52DCEA4D1AB2C6480A79F4CD73B6F33719C0C1C8F7AB0D3066278FC79C9AE8551D8E4741395D92C577750DC79D14D22C83A3AB6081EDE9C5335AD4350F10DDDC6B174AAAA5921C27CA8B84C018F5DAB926BAEF0BF86967F09EB1AEDE0221D8F6B6E148CB3946E467B8E07E35C7C290B3DA09C4B15B4ABEB80B2719CFE43F0158549366F04933D83E15F81AF6D2C61D7250D16F1BA30BC161EBEE2BD5FF00B72DB22D5E68D2ECA93E5938240EA47B5720DF157C37A4783E192290B5CC5008D2D00E4385C60FA0F7AF27D27C6F7775E2E1AA5C48B99ADE647871F706DC8C7E42B93D9B7357D8D9BBC5D8F41F1DF8884704914727F0E339CE6BC2350BA6B9BA6918E793CFAD6F6B3AF1BD8DC364963F863FC6B977F9DF3F8D76E8959195285B56430C3B090514FBE39AB5E591D001DFEB5A474F789F0467E829E2DCB70475F5AAE4688F6A9EC66A673C718AB30DB195D88FF571A191CE31841C93F95584B0677FBA40C1E6AC2DAC91C96912C418C844B863856039009E98C7CC73D80F5A99688A52BB373C57E2967F0EDAF83EC16286CE048E669C92ACEE7E6E46321B256B9586480E992DB5D02F7887EE9398DD7B303D9AB22E249249A1B8272D236E3DF9DC73FCAA4BA48C59AAA610120B9E4F738AC799EACAE55A21562B99A190949DE3520E421207E34D8EE961BA5DCEF85C92C83AF1C03ED4D8250A8EB1DF490165C61378071EB83CD1026E9D9279FCE51D793B971D7AD4A7AD915B2B9667EC5810C7A822AB8192707AD6FDC69724B6ACF13B4BE5C8CA19BAB007193EFD3F3AA6342D404292FD86E763AEE46F2CE1867A835BD9B052563D4ECBC1516A1630CF05F47B9ADD246057A647FF005AB99FECD5DC1B7AF0D8191D7FFAFCD6C785B581A7DBDE47209155AD1555634C9DDB49156ECA255D36CEE268C079503220E492781FE7B576CD7BC7970B72DCC6BBD35ECADBED022F36052AB21660AA0BE76AF3C9CED39C74156EE0411F85A787C9DBA85E84896629C81B86460F40703F0ABA9E19D4F57D6E0991CA8DB95E7201E79DBD06326BBC9FC1774DA45908A243340E5A5071975C76F7E0715C73A96BDCEAA706ECD1E331F822DFEC6C5EF41BE8DCFEE42ED4DAC3D4E0923DB8E71CD60EAFE1BFECD489BED513A9EE58641FA57B878C42787F43821B305356B991650F85DCB1A302E0E73C374AC5F17F87AD7C41E18B5D674BB45586E91E52871BA3DA0961F9822B257B5EC6DCCB9AD7D51E24DB22942F9DB5978DF1918344B1C92CCCED3B160324328EFD0F5FA536E3497B6924DCAC8101DC1C608C100FFE842A8B43C7DC23BF4FCFF5A8BAEC6B67DCEF3C19AADA1D563D2EF23674BE99218DF70C23B601273D8E0702BAB377A8681E239A2BD39D39C7EFC47F2ECEDB973D08E0607503A565FC114B19758D4ACE5B5B76BE7844B6B3CB18674DBF782E7A6720F1E95E81AAF846E2FDF74C54B86DDF39EA48C75AEFC2C95BDE672574D3B2573963E1EB8B0B3BA9ED2FF17DE5848635B6395E83824E0F19EBEB5D1681E4269C90DE413C926D04095F1E5E3B0EDD73D2B0F50F1435D49FEB3681D40354575BFF00A69FAD77BA2A4B53CF53945FBA7A9DA6B3696C018608D188E493CD69C1E245247985464750D9E2BC5E5F11C51A9124A07B5665D78E61B541F6785E57278241DABF5AE7A986A515AB3A615AAC9E88F55F1BD92EAA23BFB28E4BABB75F2CA861848D1598E07D493F80ABDA7D9DBE97E13B7B0BB577964859E44DDFEACC83E60A476FF135E436DE2592E27496E67DD11520C68C54F3FEEFAD689F1449FF002CEE58A0E8AC4E7F3ACA38593D2FA0DCD464E496ACDEF11786B4DD623955564566126DF9D700BAAA9EDDB6823DEB81BBF871ABF9A0DB08D97764169571C8C1E3D38ADE6F14B11CC9F98A6AF8B4A63E6E879E78AB7828EE5471134AD62CF867C0B268DAE596A4B2DC4325BB0766F395837A8031D0FB9E95EC4BAD59E17793BBB8DB5E2FFF0009874FDE9A6BF8D0E410E723B8347D51772BDACA5BA380175316FBE683753F4F308FA51450E4CB491564772797273EF50E3F7CA33EE68A2B16F53444C1D947CA76FB0A904F281C39A28AABB1590D69E5CFDF350B4D2107E734514A4D971488FCF9718DE69BE7C99C6F345159DD9A248FFFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (8, N'Alien: El octavo pasajero', N'Ridley Scott', 116, N'Ciencia_ficcion', N'De regreso a la Tierra, la nave de carga Nostromo interrumpe su viaje y despierta a sus siete tripulantes. El ordenador central, MADRE, ha detectado la misteriosa transmisión de una forma de vida desconocida, procedente de un planeta cercano aparentemente deshabitado. La nave se dirige entonces al extraño planeta para investigar el origen de la comunicación.', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F00A28A2800A28A2800A28A2800A28A2800A28A2800A28A2803674BD262BDD1355BB72C26B74536E370018E72FC7538404F15474DB64BBBB3138623C995C05EB958D987EA05456F2AA48A2532F9393B9636C13918353DACF696F3193FD2D586DF2DA2902B2F1F373FCA9014BA75AD6F1369B068FE23BDD3ED9CBC303855663927807FAD40B2E9AECAF3C576CC5819089179E573D475C6FFC48F434D8E5B17C35D25D3C85B2CCB20F986E5F51FDDDDF891E94C09B5BB4B7B2BA861B75007911BB1DCC496640C7390077EDC55D8344B69BC1771AB8693ED50CC51933F2ED2630ADFAB03F55AA06E6CA56885C9BE95115140328E00DBB80C8E07DFC7A645569E58B0A96C6658B60DEAEF9CB77E9DB81F952B015E8A28A601451450014515B5E12D09FC4DE2CD334652545D4E15D875541CB1FC141A00947856EA2F09B788AF9C5B5B48FE5DA46C3E7B83DC81D947AD608049C0EB5EABF1BEFE06D6ECB48B58D63B6B08BCB8A35180800031F4E001F8D7952B156041208EE280128A9EEA331BA360012207007F9F506A0A0028A28A0028A28A002BBEF8317315BFC52D2BCE20095668949FEF346C07F87E35C0D58B1BCB8D3EFEDEF6D1CC771048B244C3B30391FAD007B0FC45F0349A86B979ABC13ACF06E0AF1A365A038E847A71C1FEB5C4E9DE04B9D5AFD2D2D43195CF00F007A926BD67C2FACFF006FF8812EAE2D85AC3A85A793776C7F858720AF6DB9E47A77A97C4B7967F0D5659ED6682E2EEE97088EBC22773F53D2BCBAB899A9B8C1DFB1C8F9DBE78CBDDEBFF00F10F16D82E937367A73143716F1159B67201DE71FA73F8D73B5A1AD6A1FDA9AA4D78461A4396F4CFB7B567D7A34F9B95736E74C5B6B50A28A2ACA0A28A2800A7C6CAB22B3A96507900E0FE74CA2803D174EF19C76702BA962A8A019091907F9FE3595E25F182788216596269240A1559F1C63BD71F9E31457247054A33E7B6A73430B18756145145759D21451450014514500145153DB468F2AF9AB2B47DFCB5C9A04DD910609E82976B019DA71F4AEB60D4F44B6409F60BAC63A9887F8D596D574A918451E9F3F987EEA95500FE39AC5D49FF29C8F1156FA536711456D5FCBA75DFF00C7BDA4E9201CE00E0FA75E6B1B6B60900E07538E95A45B6B5563A61272576AC2514515458E450CC41F4CD496D1ACB3046CE0FA5145005858E37BA587600A481919CF5A9AEE444BC9E158230B13B2820B6481EBCE28A28015A6065CAC31264EDF9474C5747E29B2834FF1147690A13125B5B91B89C9DD1AB1E98F5FD28A2803375187ECFE24758E5906D97E539E47CD8FE554EFCADAEB574B1C6BB0163B09383C138383D28A2818CD5AC20B1BC64841D988CE18E7EF2827F9D53D46DA3B5BC31C79DB80793451408FFFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (9, N'Monster house', N'Gil Kenan', 91, N'Fantasia', N'D.J. Walters es un chico de doce años al que se le ha metido en la cabeza que en la casa del anciano Nebbercracker, al otro lado de la calle, ocurre algo extraño. La víspera de Halloween, el balón con el que juegan D.J. y su amigo va a parar al jardín del señor Nebbercracker, pero misteriosamente llega al interior de la vivienda. Cuando su amiga Jenny está a punto de ser engullida por la extraña casa, nadie cree a los asustados chicos; así que los tres deciden investigar qué sucede en esa extraña casa.', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F00A29E6271D54D3921638254E0D00478ABF6163E7B82C719E07BD4421F9BE95AB6B3DB4512AC9DBA103A1AD211D75264DDB43523864D3AD55F01A3738E9DE984968C9B711F999E87AD52D56FAD679544333F96AA001D89F5C76AAD10B7601FCF3B8F50A39ADDC95EC8C141DAECBD35C050A25D8A7BD67DEA897951C9E98ABB0DEC1BFCB96255232031A6DCCC8DB9E340157D7D2A5EA8B8E8F6304EE898F1C8EA29AF2798790063D2ADDD344CE8EA4EFFE3C8AA732EC9597D2B07A1B2348E038523B8CD340652EFB882091D3DE9F0DBB5D297DDB580C9F7A59C9448A47C9DCE5580EFC73FC81AD1AD2E475B1096908620719E5874150885DDB00127D00CE2B5F4FB233DE0814E2345E188C9C9E781DD8F4F6AEFB49F041982F911FEE7232C4F009F53DCD553A6E7A9152AA868799C1A74854332375C722AF3E9F3A6088B9E87FC8AF6BB1F01E99FDBF158DDB8413DBB4B12EE1925480D8F6E41CD752BF0CB49DBB9A625517EF64703DEB4E4A71D1B32F69565AA47CBD7104EB91BF9CE08618233D0F5E9EF54DE1963936C8AC1875E739FA57B7789BE1D7D8D6E649DD1EC55F313A0CB9F6F6AF2FD52DE28166B2983F9C1B304A470FE9F43D8D454A56574F42E9D6BBE56B533A68246F206DF9881B1B18CFA0AAB776CC8D9EACA4A30F7156A1BF97ECD1C221F32484E43639E3A0FA0AB2D198AC448EC3CCFBC4B0CEE249CD4F2A92D0D399A7A93A4681C9420AB7422AADE2612CE020EF0E41CF7E98C7B53F4C7531ECF9460E702ACDF22BEA9628DF748EBF8D53D61727EDD8DFB1D19DAFA045F9A22BE6485472A80E33F89E95BF1F8B6D3C3774FBEE9E6910ED58637C92A3F8581E9D2AA785251189652C4B16DCD96C12ABC2819F761F4C66B2BC69A369F67AFC77BBC4AD74AD24C85B3970D8247B1E40FA56AE6E10F751CF1829CFDE656F1678CAEFC57AA4572D0A5AC30C6628638DC92149C9DC7B9271F9552B1F17EB3A3DC462C6F1E17CE0156EBF5CF047B1A7EA4744BE4B77B3D3CDB3246526321FBEDD8819E302B9DBDB38E18A1BB85D1A0772B807A11ED5C719CA51E66AC76CA318CB953B9E95A278DD2533C5E23B8658A41FBA6857117B82BFC88AC4D4FECFA8390115ADD89F28820903B608EF59B378874EB8D160D2C58DAC6B16419950EF901CFB75FF000AECB55D32D6C2DD6C84651D52378485C6D18E3F9F3EE0D74519CEA45A99CB5E10A6D4A079FC16C6DF51950B7CEA3823B83505E4CFB0C20FCA0F5F5ABD7C026A76EF93F3C783FAD66CDC1A96ECAC6AB595CAF0CD3A3FCAA39EB5A12DCB79D6735C000AB8E9E99AA8A88390F8345F303144A5F2706A364568D9D6DD457A344B71A6DC18E659E4529B4723AEECF518C572378F7F15D3A5E3B34C876B6E6C91DFAD757A2EB127D8E07CA924323B11D33C13F5C562CC86E6EA592E17E69642E7E53D4D5C93924D19C25CADA665C5BE5382C154900B3390067D6B735BF09DF68DA6DB5FCAB6F2DA4FC472412EE5271E9807BD4BA7E950486F0E33E48501477DDCE4FB803F9D7432C90FFC2B4D3D1EE0967D41A568D9F77C8C368519F71D07420D71D5E78CA36DAE754391C5DF73CE00657CA2A861C823A8C575DA4DC6B9A93C525FEA334D6A06E50EDBCB63F8727A77FCAAB9D28473E405E0F4FF003F8D6969933D9D97D9B78F2C49BF91CFF9E4D76429B4F5392A544E3A183AB4806AF020E8A327F13D2A2B928A73B33EF505ECFF0069D67CD1D0C802FD33535CC459CE4934AF7B97B5AE67C224958051FA568C5A44B2B6F76CF1DFFA55AB58A28C02A2B4E37F9715A429A7B994E6D7C265C36B1D9FCD993939C06C56DDADDCEF1C72476CAEAEC541C0EA064E7D38A81A28DC67A91DEADC70795A8CD6E93B24714596192007C63AE31D5BEB58D794A8AF74D707858E2A6FDA5ECADF889617B243777F78B62AD2BC12C0E0E0804850BF2FA8E4FAFCDED572FB55B1BC4749B4B80469234F0AAFCA631B106EC71DD73FF023EB59621B81A8DCC734D224709761231C10CA33BC8E80123EBD39A6CF1B5BDF496E5A730A9C955DBB886DA08E9DC1ACD55979773B5E0E9A5657DEDD0B9717B74E9248605063FF0059C0F94F7AC2BB925BBDC3ED2517BAAD6AC30CD2ACB22DC348240F8C02017519DACAC339DB9E2B2AE74E267F3E170B1B9C80A3A7AD3A55A551B4CE7C4E021874A74EFF003D4C99EC1A3E5589F7CD557BAB85386919BFDEAE9BC90B1608CFAD67DDD8A4AA768C1AD9D36B639E32BFC5A8D4B90064548350C11CD618948EE697CD63DE9299A7B33A15D48704360D4A9A839F3141C89461F3CEEFAD733E637AD4F0DD943CD372BEE0A2E3F0BB1D3EF69F0642CF8E819891C74A9F7B98F619A42831F297240C74AC3875104633563EDCBD09AB5C9D8CDBA9D1B3552468C2E1DBE5FBBCF4A8E5B8240DCC4E3A027A5651D4327AD35AEC3739E29F347A2172C9E8D979EE055296E31D4D5496E97A2F5355649F7753CD439DCA502A814FD83345159A371C10138A511AD145301C1402319A9718A28A04C4248CE298CC79E68A28111B74A89BAD1454328FFFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (10, N'Terminator', N'James Cameron', 108, N'Ciencia_ficcion', N'Un cyborg ha sido enviado desde el futuro en una misión mortal: eliminar a Sarah Connor, una joven cuya vida tendrá una gran importancia en los próximos años. Sarah tiene sólo un protector —Kyle Reese— también enviado desde el futuro. El Terminator utiliza su inteligencia excepcional y fuerza para encontrar a Sarah, pero ¿hay alguna forma de detener al cyborg aparentemente indestructible?', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F9FE8A28A0028A2B66CBC377F7BA7ADEC303491B363E5E368F524F007E343761C62E4EC8C6A2B61B4C29279588E428B96F2CEF3D7B9ADAB086CB43BC51AB68A2E5186E7CA9242838C81D3AD4F3A365879B38DA2BD0752F0BE91AEC52DF6877B6F66618CBBD9CE8EA7FEFAC9058FA00074AF3F208241EA29A69EC6738383B3128A28A6412416F35D4AB15BC4F2C8C70A88A598FD00A960D3EEEE6ECDA456D235C02418B6FCC08EA31EB5A3E1190C3E2BD3A418F965CF3E9835D9F8374D4D5FC4FE26BD69143DB33CA99EF92FD3F2AA4B405ABB1E75796377A7CAB15E5BCB03B2091448A46E53D08F507D6BA64F105AAE8B65A35A58EE41B64BC99C8DEE7B853D851F10004BED1621F763D22DD40F4FBD5CCDB8612B28CA92A718383D38A9969745D36D48FA53E1949A5C1A742C6D63B78E639C3DB64B1EC338E83B57A7CAD652444CD25A9858601755C60F6E6BE284691820297CED8C615CF3F4AF43D1BE19DD6A5F0BEF3521712FF006824C274B10CB968070460F218F2476E2B9E3151566CE9ACDD497325FD7DC6DFC5CD36CF4DF2755D28794AD2324C6D5B620C8FBDB41E0E702BC3E46679599D8B3124924F24D5C96C2F618D8CF04E889D43AB0FE95498E5B35A538F2ADCC6B49C9ABAB09453A38DE67091A9663D0015736C163CBED9EE07F00FB8BF5F5356DD888D372577A2EE496576AB7CB711C42291237276F42769C1C76AEE3E184C2DEFB5DB7B8DA92DE5A8489E43C0666C6ECFA73D6B81436D0CC4113A8652A7206573FCEAF594ED61731C90CB2344C72858632013549D922ADCD277DCD7F88F13C5AD69C5B054E996FB5D4E55B0BCE0FD6B052E6D65B0822D856EE262030030EA4F7F71CFE95D4789349BAD52CF409604924DF608A8635DEB904E5495CED3F5AE29E17B6BAF2A50432B608A5357B841B834FB9E9BE0AB89EFB55FB2BCA4C704664F255F6B4C40CED07B56C9B7B2BAD4E5BF96DA2B3495F73D9BDE156E390A196360833EA4FE15E63E55D5AF97730485D4FBE194FF005AEEED7C47AADAE96643A30488A02EC61055876C927A570B8D9DD1EC73B9692297C4E8FECF710CB14725ADB5DC3E62D9C9287309CF4C83C83D4579EC3664C6269DFC987B31EADF41DEBA1D6667BE5BAD51E18A370F1BA42809440723001CFB559B4F0DE9DE25B192F2D35492DE789374E2E54BC71FD59465075E7047BD74D08371B23CFC54E2A6B9F5FEBAFF005F339692F02A18AD50C519FBCD9F99BEA7FA5578E29266DB1A3337A015A73696D6372D0340D732AFF12B0F2BEA08EA3F1AAB76F3A20469620A7FE5944781F5C555ECEC8CE516D73CDE9E5FD5BEEB95E49A498869642E54606E39AB325D09A3880409E5215E3DC93FD69F6DA8C304933CBA65A5C6F8F6287DC021FEF00AC39FAF1556E6348E4DA8DBB8049CE467D2AEDA18B93BEF73E84F01E9BA62FC3A935BB3D2CDE6B8D6FE406DBB0444F08A8588007CD927D6B98D77E1078C6FEE6EB5E6B4B07B9BC63B6CA07D8EA4E06E20E1738CB100F06BCF747F105DC4A2DEF75AD422D3E201BECD0CEEBE6E3A20C703EB5D2695E2EB54B8975593C53E21B0D4A5608590F9E028E80866CB00001C9FC29454BB8E528BD9151F49BDD17516D2B5DB492D24036957E99238208E08F71572EAE02E926CDAE18E0602E78ADCD27C59E2BF8857177E1381F4EBDB4749266BAB9B609205CFDF0338DD9231C715574EF861E229F5B5B2BF8C456EADB9D8383BC0F4AE49D3B3D4F5A857538DD997A769177A9E9D70B676DE71542082A58310338FD3150F8062B987C6106A9A5C127D8623B2F629509558DB21D4F623B8CFA0F4AFA2F40D021D23478ADC242D7317DF70830FE991EBEF5E65E3599FC277FAF6A1022177BCB594A94055D6589D594AF427E4C8F7C56F866D3B33871B28D47CD1E8715E28F0A0B9D2535DD06DE54B29B7492D81604C233F79707807D2BCF16091DB11C6EF9F4535D5F895A19DEDEE92577B4B9525444C4818E9F29248C67919C647158AFA6011B4F6D789E5138019F0718CF38F4FE75D334EFA1C506BA85CCC8B22985163824D8F14A07CC8C00CF4F7CE456AA5FCFA85B416F3476F24A095F3FCBC6D0707690075381CF4ED9EB5CDC73BA44F1863B1BF8719145BDCC96B309223C8EA0F423D0D5C6A28B25C5B25BAB76B1BF9ADE642AD1B152AD838FCB8A81F691951536A1726EEEBCE60C0B28C866DC7F3AADB4E3358CD25276348B7CB6677FF0007B51FECCF1AB5D3CAA90ADA4825047DE4CAE40F7006EFF80E3BD7D0FAC6A69A6186756560FF00287C8C107A1FA57C9BA66A52E920C96E563B9CE72C33C7A63F3AF46D23C66353F090B5BA918DC59B6C45CE4B2754FC871F8545587B975B9D1869273E57B1EED697B2481E2B978C1FEF27435E65F102F60D4AD3C41A2ED52C27B5C4A3AF11B37E848FCCD4163E3980DF3472CCA8C4636EECE0FA579EEA5AFCB75E29D58AB13E7DC95E48C615768FE54E8453770C57BAAC7316A1CC91DB36F770182AA0C9008CF1EBDF8ADA9522D16DADE4B84B4BF58597CD899428F30FCC620C39200C6E23B903D6B2ED6D26004825689FCC22275EAA17E667E39C018AADABDFC77934715B822D2DD7643B800C467259B1D49249AD9BB239376508DCC722B8EAA723EB5D4DB5F34B6D692BE1C963E6808BC8C9AE507E941EBC0C56138292D4EDC26327866F9767FE69FF00C0F46CEE4DC400E41438EDC5578AF1658CBCD6AA8EA4ED46656DD91EBDAB8EA2B9FEAB1EE7A6F3EAADDF957F5F2E876517D921558551762701980CB6704FF9F6A6D9CD1A4D35C347E54CE76B05230D8270C39E2B93F95F8E8DEBEB4D5628E1875539154F0DFDE21674D34D535A7FC37E0BFE09D5C6D2417B1CF106860958996270320E3820FA7D29B04D7335AFEF67486E3CC259DA356DCBD8550BDD6BED9F2B469E5119D98E86B194A8049FC2A9E1A3DC9FED692DA3A6BA5DF5B76DB6BE9DDF73B39F535B50A522DD19CEF60C176AFD3BE79AE56FDA29750B89626063662570300D55277BF3C0E83D852BB7F0FA53A74634F5473E3732A98B5CB2492BDC6F6C5251456A79C14B4514006294F4A28A007281B7A5474514000241C8A28A2803FFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (11, N'Rambo: Acorralado', N'Ted Kotcheff', 93, N'Accion', N'John Rambo (Sylvester Stallone) es un veterano de la guerra de Vietnam que sufre de estrés postraumático. Un día, llega a un pequeño pueblo de Oregón, donde el sheriff Will Teasle (Brian Dennehy) le detiene por vagabundear. Rambo logra escapar de la comisaría y se refugia en el bosque, donde usa sus habilidades de supervivencia y combate para enfrentarse a los policías que le persiguen. El coronel Samuel Trautman (Richard Crenna), el antiguo jefe de Rambo, llega al pueblo para intentar negociar con él y evitar una masacre. Rambo tendrá que luchar contra sus propios demonios y contra las fuerzas del orden que le quieren capturar o matar.', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F7FA2B375DD54E8FA2DC5EA5BCB712A2811431216691CF0A303DCD7229E25F12FF0064A413DB490DF0BA44B8B9364C7CA81813E67960F24118E0918C1A894D2D0E9A3859D58F346D6BD8F40A2B861AD6B2F6E8ABA97FA209DD24D50E98CB80141036138209C8DF8C700639ACF935FF001A4C2CE2B5B70DB9EE479A2DC235C469B76385738527278279ED4BDAAEC6BF509FF32FC57E6BCB6DFC8F49A2BCC27F1278E1A180C169BA45D305D4CB15AFFCB42EC3186C738DB951CF5C568DC78C75986FECDD34F9E7B081225D42482D58A1761F394279C2E470073CD2F6D129E5B57A34FE7FD6FD0EFA8AE4A1F14CF0E93A8B4D14D3EA504B288205B7702419FDDE081C8C11CFD7D2B09BC5BE248EC20B4BC865B3D452FD22B89C58348BE432B1DEAA3238231C1F4F5A6EAC5110C05595F6D3FABFA7F99E954579F4DE20F12411C315DC8B69686EA589B55160EC4A2A8287CAE76E4923278E2BA7F0BDFEA1A8692CFA942E934733C4B2B45E57DA101F9640879504763E94E334DD8CEAE1654E3CCDA7FD7F5A6FDD16A1D6F4D9F589F4986EE37D42DE359658173B914F426AF071EB5F3E7823C40D278EA3D46596DD9EE18C735CC6FC4A48E833C8E781FEEF5AF72F3F9EB58CB10A2ECC8F64CD2DC3D6932BD335516607BD1713C36B6B2DD4F2AC51428647766C050064926AA3579B625C2DB973273D28FAD7CB1E30F8EBE22D6A56B7D1243A4D8838DD11CCD27B96FE1FA0C7D4D51F07FC66F13E89AD5B3EABA95CEA7A6EEDB3C1310EDB4F7563CEE1D7AF3D2B65720FADA8AA70DDADC5BC7321252450EA48C1C1191C549E61CD47B543E4658A4E6A1695B692064F6C9C5579EFE4B58774CB6D1B9FBBE64FB413F5C51ED221C8CF967C2FA9CB65770C96D1206501A318F30A376C7A7E55EDE7C4B2DC6B9A728FB3BDA08C4D3B29C18DCA90463F8BA8FA5780E8BA95918E38143A4E5486C9C12C78F4C0FCBBD7A6D87911DE69B6D040A7605595D662C3241E197D8E304763CD73568EB73AA1668F620F1B00CB8C1190477AA9ACDA3EA7A2DEE9F14A91BDCC2D1069137AF231C8EE2AB6817BF6EB8BA8650A4A905197A1006081F4A9BC41AF68FE19B659F529DD03024246A5DB03A9C0EDEF58C6134AEAC1CBCD2E44AECF9C7C19F0D62F14C3A9E9EF3182FF004CBF0933842E1A2E430E0F041538E39CFB54BADF83747B4F0DEA97BA549F6C6B39D6559BCB00220E0A30E09CE4751CE3EB57354F1BE85378A6F2EBC276D7D64F78419C4CE04372E5813B900CAE78390C39EC2B9293C51ADE9D7972D3D9C91C33ABBAC2EAFB1B938277F2CA093D49AED7CCF6223CA97BC8FA7FC21A95EEA5E12D2EF752804175340ACD1824E076EBCE48C1FC6B77CDF4AF14F04FC63631AC7E2C8FC98AE25630DCC71B3796BB41E4724A673CF6C8EDD3D974FB8B4D52D12EF4FBB82EADDFEEC9138606B9650A8A5A0DDBA92B3EF564619561823D45626A9E16D3F57B3FB098C416CE479A91AFDFC1C8E4F4C7A8F535D10B720FFF005EA39E48AD15249DB62B489183EACCC140FCC8A6A9D4EA2E74B63E238A6789CB5A441DF01B737CCDC77E6BD46CAE26BFFB36A22154BC863314F192CBBD9460647B0C671F518AF38D22EE0D39A299D1A5573920678C1EE3FCFE95D87844DDDF6A724B69616B04265314E6463BC64F4FAE0F41E95D1556971527D0F63F09EBC91ACB717BB50C441610A13818E83D7D6B9BF175CC9E21F185B689709E5C7A85CAC0252460A8F9B6FE2063F1AC3BEF12C3E1FB18E1D3B4E924B933366E0B80149E3B9E3B0E7A6055CF056ABE19D658DF96F3FC4909CC32CEE5046D8CAAC6A4E39E993C9E7A702B149DAEF6474B4A0DA4FDE67AB58F83F4BD1EDA182CAD6DB646BB712460EF18C60FBFBD79D7C4BD425D53C337D6724491476C87CC1090557E71D0FA01F8574D7FAFEAF234F1084C6CA02A7F7812320FD40F4EF5CAF8A2D6FDBC0D7F1A5A3CB2347B6472005393C8CF623835BC2DB9CB3BDECCE1BC3FA978693C43716DAFE67B2FB09B785606C18E4661CA9F5000C7D6BD5BE1BC163A6EAB6D6FA6DCDCCD1B5BC8939B90158804327CA38E39C7D4D7857C33B8834DF899A14F740341F6931FCD8FE2054647D48AFA0F59BF8D7C696B3409BA6173085F2FAEC6E18B63B7DEFCAA2A7B8D58E8A52755CAEB74CEF6FEF7EC96C2544DC4B05C1AE3FC7BADFD8340D2DA793C969F50832F9E06D60DCFE42B3343F135CEBDA85C41736B32C104B23DB5C38F96404E3E5CFA0AE7BE30BC537856195E6DB240C4F97C9DC0F4C81DB701CD47B66EA7298FB1B42E703E14D1AD92CD35C0E6786DE02890CB18F9D8B37E7CF155D3C4FAA41A8CCD6C16DA69F0CB6E837ED6CF19CF2179FE75D6E8B7161E1C125A6A3BD564667892D14DC7960F20123391CE739FF1ABFAAE89E1BF116A16419AE649044C1AE2CB6A1765036A91D73DBDBBE33439FBCF996869C9EEAE5641E1197C3BE2DD3AFB48D5D4DBEB122C8B18906D3267FBA3A1FC2B928BC1F17857C54B6B7377F3A95F2A531612646EBD7A30E9D7078C75AF47B7D0FC2C1F4FB2BAD3B53418F35679D8A88E45E70581C8279F415A7AC78AACACACFCBBAB296E34F92471712DCDB160531CE7D0127F4E29D3A893D10AA45CBA9C249AEF8934C9DE16BDB609644395B87DE655278CB37CF824E38E060F20715D36B1E32D035CF08ADAC1125B5CB811DD5A3101A171C91B8E037D46ECE7A76AF25B9F13FD8BC5516A961A718C655BCABA0CD1DC2E30ADF3F3823A67DBAD6B6ABA4BF892D64BEF0F0B88DADE28FED166CCAB3066CFDC5072C99C103FDAF97D2BA9C53D8E553717A9956FA4DB5EC36F68AEF6D7F35C34914A203956DC703206E207A9DA076563CD7D096DF67B0B9D234C91201A84B6F20B8102739F28825BF1CFFDF55E2BA2EA77DA369F2FD84DDEA3ADC5289102C5E643123312C5703F76D9E4EE0318E6BD7BC15A16A1A75A49A86B1E58D46F3076C6DB8431E3842C7EF127924719C75C57356938EACE8828D8E6351F0C78A6CF56173A68B7823683CB54F3D8853B719F63C0C81D715C9DFF00873C453DA4C35E0D76A3EEB79BE5E3B0DC79C819E98AF78667312F98E1D94F2CAA573ED8ACD96DA496E1DDAFE68D188C45B17098EA41C67F3AE58D56BB1B593DEE72423B6D115EE8E9B39B508B1968CE1E1039E8BD89EB823DFD2ADC135E5FA4896B01B76C663BBDE195C91C649193F9D776BA38232D1A32B28DCB8E3A53A3D2228FE548C00CB8200E2A9C25D87EDA99C25868844C7ED51CA6361FBC85DB72EEEE48E41C9CF4F5AE73E20DF69DA2E9725ADBC16B262036F2C59DCEA0F200E30003C9FF00EBD7AAEB2F6FA168F75A9CE176C11EEC91D4F6AF8E35DD566D6758B8BC9A467DEEC5771C90339AD6853939F34BA1956AB1E4F751D768DE26D134ABCFB4DBE8F3181154488D702551961D032F518241EDC66AC78A3C5569AEEAB67A869133DBDC5ADB1432EE11A950C70A40E7B803FF00D58E074DD3AF356D461B0D3EDE4B8BA99B6C7146B9663FFEAAEBFE26780C781351D3608A53341736818CAC796954E1F8EC3918FAD753B732EE73733E568DAB88A5974736B712DEE9D757C524B99EE86D4B99D7273230279F9890DD083F32E46FAF77D07C4B6BAF40551DD2F60502E2DE65DB22363AE3BA9EA08E0E457CBFE1FF00173D9C49A6EA9BA7D38E1436DDCF08F61FC4BFECF6EA0835D8C323697F66BAB5D4FCFB755DF6D796EE3CDB604FF08270D19279438E7AED3C99AD45558DBA8A13707A9F40CCCD8F95437B5539E2BE765FB32C2B9233E60CE2BCD746F1FEB9E20F1269DA5B5D69B63684B09EF626E2E4A82485DFFEADB1FC279CFB57AEC12DACCEB14373048D9E1639158FE40D79D2A3283D4EB5562D686D6D046280801A28AF53A9C67957ED01752DB78021489B6ACD78AAFEE36B1AF96481CD145311EB5FB3C59C373F10EE6695497B6D3E4922E7A316453FA31FCEBD2FF680D22CAE7E1EFF0068C90837765709E4CA3AA8721587D0F1C7A81451401F2D77AED7C13ACDF4B3BE9FE6A2DBDA58DD5CC404284EF8E27719241CF23F22718A28A00EF6D2296EFC2B1EAB2DCB79E3566B3DA2087679620DFD3675C81CFA74C75AEDBE1468969A8DB8F105D0DDA858DD5C5B44C8888BB7A6485032704FB7B5145007FFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (12, N'Rocky', N'John G. Avildsen', 119, N'Drama', N'Rocky Balboa es un desconocido boxeador a quien se le ofrece la posibilidad de pelear por el título mundial de los pesos pesados. Con mucha fuerza de voluntad, Rocky se preparará concienzudamente para este combate, y también para los cambios que producirá en su vida.', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F08C9A32693B53E18A5B89E38218DA496460888A325989C003DC9A924920B5B9BB72B6F0C92B0EA11738ABEDE1CD715599B4CB95550092C98C67A55C9BC0BE2AB6F30CBA25DC62352CCC40C003249CE7D013528F0578C4346A34ABE5696431A2EF00B30CE4633DB073D854B53BE86B0F656F7D3F93FF008050B4D19E5BE3672C728B804864236818196249E9815675BF0F1D19D63995C338DD1B2307571C679EC4647503AD6FD8691E32D363FDD7877CB6982ABB1890BC9B8950325B20939181D7078E2A6B9FF84CB5992EACDFC3E6E3EC922433C2F6CBFBB638DABB89C8EDD0F71ED59BF69CDE43F72C71A3C3DABB64C7A7CF228206553D7A556B8D3EFACC13736B34201C12E84735AF77E1AF14C121F3B4DBC8B2C00553F28CC9E500307FBFF2FD6991783FC4F75179D1E8D7B2C7BE48F705C8DD1E778EBDB07F23E95694FA849D2B7BA9DFD7FE018793464D5ED5345D4B45789352B396D5E652E8B2632C338CE335471546432B47C3F0FDA3C4BA541BE44F32F214DF136D75CB81953CE08EC7159D5B1E13FF0091CB42FF00B08DBFFE8C5A607D257FE01D4DD750B786F22F26E1AEA511ABFCDBA5B748B72A9C01F3876DB9C0DDC1AABA3E9777E327835AB88E4D26DED6FDCC4970885A61E4AC0EA792429759011FC41BAE40AEC25B7D387C475BB17AC7581A43469638C2B43E6E77E71D776075FC2B90D59A66F85BA2B5C44229DB59B732461B70463787233DF07BD50CCDD27C3DA847E248FC38FA7CD1358ADA5D0BA9364B134715CCEE3E7277648900C81BB2AD91839AB1AAF842EED356B9BA766BA8758D52C8C2D0483CAB774283738EA07CAEBC6E0432838C035E8B1FFC8ED73FF60E8BFF0046C95E2FE02D5BC6A63D074D7D2621E151A9656F7CBF98FEF98F5DDFDFE3A5023B26D006A3A94BE194CC571A7450DDBDC6331306B91305EC41251FF9FB5431CF1786743D2B54B22756B3BFD49A285E1503709E5948C827A66565FC01EFC753E2DB69A0F0D78A2E7472A7579EC72467E6015180C7BE37E3DEB82F803AA26ADE12BCD16EE3F3534ABA49E02FC850C4B0C7B86563F8D03381F8DD609A7F8BAC6237314971F615F3238D31E580CDB72DFC44F3D7A0C579AD6CF8BF5D97C4DE2ED4F579B23ED139D8A7F8507CA83F0502B16A4432AEE8F7CBA5EB9A7EA2D19916D2E639CA0382C1583633DB38AA545007B23FC71B76F1FC3E251A14C224D35AC5A0370371264DFB81C7E18A7697F1B74E5B29B4ED6BC38F79651DDB5CD9ED957727EF0C881B3C12A4FDE1E9D2BC6715BFE19D07FB76E6E2107E648C0418FE263807F0A2F6D58E29C9D91E8D6BF1E6FC78C6E75793460FA6C96EB6FF00668DFE78D55890DBF18272C7230074A7DCFC6CD3E18B4BB0D0BC34F69A559DD2DC4B19906E6C316DAB8C85CB1C9249A9FC39E19F2344974ABAB2FB3DF468C24629912839C3A9C60A9CF27A8F4158F656365E1F825D3AEE2B7911B3E55C48CAAC0F656CF3D3AF5E9C566AB26EC8E9FAB34936CD187E358B3F1B5F6BEFA1DC1B1BEB28ADFECFE7AE77C6490D9C63186618F7AC4F01FC4CD37C0FA8EBF2C3A35C4D6BA94CAF044265061405F0A4E39FBC07E1553C4FA35947E1F88E9F20BB785034F2A0F9723249FD4F1E95C0E32B9E38AD534F6309C1C5D9848C1A47619C3312334DA5A075A9204C518A5A29884C5747E0D9BCBD62453133878594EC6C30EE31EF915CE55DD2EE3EC9A95BDCEEDA239158F3D4679A1ABAB174E5CB34CF5CD274DD66DBC456976A6E05B15DD32C974EC4127182A78FD4D6EEB9A12EA7AB4934E5B6C40AA1403729C707923BFE95A297ACDA48995834CD831A919C9EB8C545677F74DAD487525448A4185DA9C1FAF27F3AF3A12E691EDCA0A28F3EBBB3D6E2536FA84D15C5B4BFB9DC7E57C1E9EA4FE66BCC4AEC2C87195622BE86D76C6D84C1FCB8D320ED207DDAF02D4A2587509A248DE308E7EF9C9233C1FC4576D2A8A7D0F3B174F96CEF72AE2954734F006DCF7A6D687191F24D3B141C6E38A72F73E82A9083CB246695C47B38C9CF4F6A746924F208E356663D94127F2ADAFF008447589ED9EEA3D3E654C7CA98F9B1EA73D2939245461296C8F45F096AF6BAF7872DACE76FF4984057F9B00E38E7D474ADD8F49B5B097ED770DA79746DCA238F637E273CD79CFF00C23B6BA5E8906A02EE5B5BEDAA1D558E189F5F4FAD6ADAF856FAE8AC977A8318DB93F393BABCD92A6A4E573DA84AB3828DB537350BE9BC457E965639083892507851DFF1AF37F1B5B7D9FC5374021117CAA87E8A057B2E8FA643A6C6B1C2B8F53EB55F52F075A6B21D6F578918BEE1C30FA1ABA359266788C3B946DD4F01070694D767E2DF873A978711AF2D775F6983932A2FCF17FBE3D3DC71F4AE2B71C7078AEEBA679328B8BB322CF352C49E6C8B186552DDCD30815D8784FC0379AECC9737AB25AE9C08259861E51E8A3D3DE9EC25A94FC3728D2F5EB4B988F99BBE57DC31B49EA3F2AF608357F330B850A6AAEA1E04D0AFE14863B416AD18C2CF0B1565FC3A37E354754F053DA69B9D0F51B917918C849CE565F6FF0064FBD72D5A6E6D34CF430F595256685F175B9BBD26E22B3B547768F733123231CF02AB68B6D2476B613199DA378C48B1B1E1062B85875DD62FEE7EC37174628776D99506338EA09AEF34DBB5BE923F2D71044A114FF7B1FD2B9ABC1C5599DB87AB1A9272476961344C416DCCDFDD4524D5CBC32487643C4B8E431E9F5ACC97524B0B21E481E61E8715409796CBECED3334B3BA3140D8623273C9E327DEB18356E546EE379272763ACD3F312625921248C11B8735E79E3AF8550DD17D4BC3F1A4170D967B3040490FFB3FDD3EDD0FB56E18424223FB0394CE4A141C1F5EB8A9F4937569188EE262CA1C1442DBB68FAD762A9CAAC88AD8284A2E5CC7CE3D391DABE90F0D9377A158DC4A7E792DD18ED1819228A2BAE7B1E0D1DD9A490A92092DC9A82F3F729215E4A8C8CD145671DCDE4783EAAA21F10EA7E58DA1A4DD81D8B609FE75DB785F9B6887A8A28AC31BF09D381F8CE99EDD64E599B8F7AD3D393316371E28A2B817C28F51F52C98C36ECB35556842CA9866EA3BD1456DF64CD6E7FFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (13, N'Taxi Driver', N'Martin Scorsese', 113, N'Drama', N'Para sobrellevar el insomnio crónico que sufre después de su regreso de Vietnam, Travis decide trabajar como taxista nocturno. Como individuo tiene poco contacto con la gente, pero observa la violencia y desolación en la que se hunde la ciudad de Nueva York. Travis anota en su diario todas sus impresiones, hasta que un día decide pasar a la acción.', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F087BA24E506CE735B9697BE198745B4696DB523ADA5D069E446410987772141E7715CF5E335CDD154A4D6A2714F42DEA125B4DA8CF2592CC96CEE4C6B3105C0F7238CD5623E6C7BD4B6F0C9287914029080CE4B0180580FC7923A56CEAFADC5A868BA3698B6314326982546B85396B8DEFB81618E31D3A9A7BAB8D7632AEED4DAC81376EC8CD5639F4AD0BD0CD739200CE2ACE99A5C5A86B31D934F6D1AC8CEA259E6114630A4825CF0066AB941E88CE86E628C8F36CE295447B08C904F39DD9F5ED5645EC44A341A6DBA6D575392CDBB7285C9C9EA0E48F734C36AAAB751B184BC4C70FE670719FBBFDECD3216448327AD2482C437064648B7AA8089B0155C679279F7E6A00579DC09E38C1C60D58B9911C8DA38A864285F3182170383EB8E7F5A996E0328A5A2A4051C303E86B52F2FACA7D2F4E820B5923BAB7120B8959C15972D95C0C7181C7535954F514D0171A769D8335685EE8D736512493285478D6440C0A9653D300FDEFC299A3F87F54D7567FECFB469638466690B0548F3EA49C76E9D6BD57C4D71A6268135B16B3B8D41EC2DED628E2F995654C176CF623923BFCD8A72A96691A423CC9F91E3A9123C13C8CD82806D19EB4C8E32D1E7B6695E3DAAFBF208E9C75AAFE6363018E3EB5ADD190B3A053C5414F2CCF80493E948411D45672D754327B4DA2725C0DBE5C9D7D761C52416F24E584485B6A966C7603AD6F787AD121824D49FE6316E45538E7231D31CF5AEA34FD122B796F6179577DC44C4954C6320824738C55AA7649CB63967894A4E31D59C035991089B3B908CE4557C62BA4D4156DECBEC71E7CB8414DC7D7AD625A595D6A778969670B4B348C111410324F0393C0FC6B2E64CEB47A3F85ECFEC169A0DAC0639AF2FE37B896D883C6F60A858F60106EF6E6B2963492C64BC0256586E782465590AB1524F638047E156AEF523A36A4B1418175169C220637561B826D20907B73F90ED58F7FACD9DBDAAE9E8A92BC70470799F381C29CE30707963D454AD752A9BB37731F538CBDAC570AC30CB971E87711FD07E758E463AD6A5D026040A1980B7F318AF214EEEFF00A564E4B1AD2E412DADBCD75751C16F1B4933B0088A3249ABFADE837BA14C90DF88D663F7911C36CF624719AB3E1E7B6B4BD496E5599411B829C1C7B1AD6F1F6A5A35FC96AFA25A4B05A9CFFAD937B1618CF3F5AD3917236D9CD2AD2F6CA09685F4582DB4292EC799F679DF112AC6C3278247A6783C56E58695A158C135F6A367269CF2C026912E99DBE471907391D73D00E6BA5D23C15A2E96F1DE5A7895AE5EDBF7B1220B6662D8C701B8CFD6B85F10782FC49AADF1363A7CC6D90923ED57F03C8DCE792A40FC39C66B0C552A956CA2DA45E1254695DBB36CD2D225F87773AA2C51451A5C48D84FB42CAA8CC7B72D81D7BD7676DE18D123B436961A7DA4024DF1B4B197DEA7041F9B3907048AF298BE1DF8BD6E0F95A11F9811B7CD4618231D77574D6FA47C4882DA1B66B25511F218DD22B13D32486E4FBD79789C0E22E9D1A8FE6D9E8D2C4517FC448CFF008A3A55868AFA6082CA18256CE64859B7385007392477E08AE0EF6CE48ACEDAF24C9179B9A22CD96215B6E4FE23F4AEAFC736BE20FB3C32EBD1C51CD19DB1AACC1C953D4F5E79C74AC7D562D44D9694BA8431A430B086231F5DBC1C1E7AFF00F5EBBB0F0AD1A718D4D5F5FEBEE31A93A5293717A743B4F0D5859C5A0C69333A2CD6F1B4CA61CABFCC49CB7A1C0CFB5665D786FC29BD9A337A10B607920B81EDD4D731706F9AE764C50C3195568C4A06E0B900119AACB2DF24CEF1BC499624A2B00BCF6C0EDC567EC2ADDBE73675A9689C4D4D7FC217D64EB79A4D96A371A53C61D6E1E1380724104E3B115CEDC2CACDE580C63476DBC7A9AE853C45AA2E9234B3AC34365B8B1855432927D79C9AC992CED5896FED48C9272711915D518B5049BBB38A534E4ECB43B116B22E18470B103B0AB904D79182AB6E854F18DE6B9CB7B1C81BAF500F52C4568269D285FDDEA119F4F9EBB2352A747F91E4D4A341FC5F9336E19AFC1CAC457D36CC6ACC77F788ACAE9758FF00667FF1AC282C6FE3CEDB956FA49524A2EA103CD663EC1CD3752AA5A910A18794AD1FD4CFF1B5FC9711D88CCA230EDBD64218E463A11ED5178D7585D53EC36F0961E416E3681CB63078FA554D4DCDECAB6D32CB1C60972DB32436303F0CE2A8DC36A971F65FB444668A0626308A3A1209E7A9E9DEB96551BBDFA9EBD3A11828DBA5FF00136E7F10E9534490CB03168D42176505988E324D605CDCE9AE498C48A4FB55EBBF1578856694C978C72C46F30273F8EDAC69F55BDB9CF9B70CD9EBC01FCA9295D6A0E959E9F990398C9F949C7B8A67D33F9506473D589FC68123FF007D87E352687D57FF00088F8781046916BC01FC27D3EB520F0E684A78D2ED063FE998AD53D47D07F2AC1D6F466BFD534CB88A0478E29F75D166C6E4DB8031DFA9AFCA29622AD495A755AF9BFF0033DE8422DD9E8688D0F48518FECEB41FF6CC54834ED3546059DB63FDC15853695A8378805FFD96396D65B692D6681A50094FE01E9E9F4CD670F0D6A8BA19D37C885CC57B14B14C651B9A2524ED6F71D07D6B654F992BD6EDD7EFEBD0D55183DE47552697A639F9B4FB427DE25CD45FD8DA5678D3AD323B794B597E27D16F755D46096D123D896B3C44B3EDC338C2FE5D6B3A5F0E6AC355FB50093857B56DCD2ED32796B873EA3D7DFBD3A5052826EB59DB6BF9FA8468C1C53723A53A2E8EC30DA75991E863154E4F08785E6CEFD0B4D39EE2151FCAB224F0EDF9B2BC6458E3BC1AA7DB6D58B8236E4707D38ED56A7D1671E215BB82DE37B34B68E2085946E2AFB8E41E9EB91CD524D3F76BBFBFD3CFCFF307469FF30E6F87BE1090E7FB0AD7FE02587F5A84FC37F081651FD8B08C9ECEFF00E35168FA16A561ACC3752C519884B705B12F2AAE415381D7E9DABACC9DEBF5A55B1388A52B42BB92F57FE644E8D38BB2B32F792A429C9E547F2A3C85F56A28AF26E40BE42FA9A3C85F5345145C03C84CF53486DD3D5A8A284C434DB27AB537ECD1FBD14555D9485FB3A7AB527D9D370E4F5A28A776347FFFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (14, N'El Padrino', N'Francis Ford Coppola', 175, N'Drama', N'Don Vito Corleone, conocido dentro de los círculos del hampa como ''El Padrino'', es el patriarca de una de las cinco familias que ejercen el mando de la Cosa Nostra en Nueva York en los años cuarenta. Don Corleone tiene cuatro hijos: una chica, Connie, y tres varones; Sonny, Michael y Fredo. Cuando el Padrino reclina intervenir en el negocio de estupefacientes, empieza una cruenta lucha de violentos episodios entre las distintas familias del crimen organizado.', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F7D2714D2F5133F3F80A01A57192E7D7F951D7D3F2A68A7D201A49F6FCA97A0C9C7E54E0BDEB2AFB578ADEF1EDB8CC6AACE49E99CE3F953112CF15F5C4EE127482DC001708199BD4F3D2A38B4C9963646BB3B4FA20CD360D5A197A356824CA464521998FA1EDDCF1DD396C701D4115CC6A088C9243796CA154F5D88037E40577BBB22B83F16E9D7CA8F259CD8566CE18640CFE20FF003A6076A7EF7E03F953D450D807F01FCA945201E29E05228A7D34007A70335E47A9F89E17D72EE0D4F4C9AD75073B426FEC07CA3D0F1DC75CD7AE573B3E876173E2A935796D6379E1B71123151D4E72C7D4E303E94C4707A6FC49D1A09963B8D3EF226CED62AAA40FAF7AEFF4BD7F46D623CD85F46EC3AA13861F857997883E1D24FAA4D776776CB1BBE5A1039435B1A77C388364524DAD4FBD40C150A08C7A1EBFAD2D067733DD5C43B9950498FE1F5AC1BAD6239241BE49238C9C30C1247E5CD6F2C50DADAC70899A62A30198E49AC3934B6BC9434CF1C518393230E579E290CEB1BEF7E03F95488B46CE7F014F0314C43C74A5A66693CF8FED020DDFBD285C2FB02067F5145D210F35E63E2DD4B52B0F14CD69A4DEBDBC6C892CEEEA1823B647CA0F51800E3D6BD1E4BFB586E85B4B3A24C53785638C8CE3AF4EB5E73E38D3E587C5515EC56D0DD7DA621F24A3206DE0FF00434269B1D99A16924D71E55C35EADD5E050972047E5EF5ECC17D41FE75666D3EE3018310BED5CFD9EA565A795B84B4B8B5B84387462C6361DC7CC4FE95BEFE2FD29AC3779BB5CF45F7A5619A166235403BE39CD73DE2ED4658A286DECE2967779012B13105403D73F5AC2BEF16CD34FB2C91893C0278AEBFC2FA65C3C2B7776AF2CF2E0B3B7000F4A76B089FC74C52C2C7E6655370376D241236F3D2A2B3F222F10E8F1D8BDC2D9CB14D308E666C86C11C83CF6EF5378E768B1B162FB0ADC061F2939217DA93455BCD6F50B3D6E49A06583CC859550A1191C601FAFAD795535C534B7F77EE56B9D51FE127EA68EABAC5E58BC8B6DA54D70AABCCFB86C538EE3AE07534DD2F54B3F39577B4D7170FB04C48265233D00E8A073E8338E4E6AC6A17E2D264B28A511DE5E3E202632C1781927A7A564D9F87ED74B74BDD4B50FF004F9E4F9662C136B1CF0A0F527BE6B79CAA2ABEEBBA5BDEDA7FC1FEAE66947975FF008713C4BA9787EE665B5BD3BEE2D6552576374C8DC33E98FE556DA2D1FC4966890CA1CDB2801E2054C791D3A7B74A74B656D1CF2B5CEFBD72FB879E0100E3D318E3A564DF4B2C16862B40B6D1B60B2C2A173C75FAD5D38D4555CA56D7CB5FCC5271E5B2BE852D5F454FF8F5B6BD9252A32EAD8F97D0135CAC963F6791A268C2B83C1C135BD06A6BA75BF92B68F2C8CC59DF7E371FCA9A75F78EE61965D1237087721790E73F9575AB991B7E1BF09D969709D4353589AE0FCD89701211F8F19A9B53F1F585B38B7D310DF4E4ED0CBC44BF8F7FC3F3AE416C6EF5EBD79751BD93049930D92ABDF81D056BE8DA1C4B70859091B8633D69DC2C6D78F09FB0D815C6EFB48C67D76D605D4B7FE1FB3160B77345768C6675818796AAC782491924FA7415DBEA5A7DB6A691477719758D83AE18AE0E3DAABDFE87A6EA772D7177033CAC810B0908E074E9DEBCCC4612A4E729C1D9BB5BF53A69D68C62A2CE2E6D42F6E35859E6BA91DE29251164FDCC2F6FF3DAAD2B6A674EB2BEBEB917315D5C44910986E29C9CB0EC0F18CF5AE9FF00E11BD1BCD32FD99BCC2492C256EE307BD4B269762D656F67E537916CE1E25DE72A474E7BF5ACA381AD76E52FC5F96E53AF0D2C8E1CEB1A9AC9237DBE66C89800C72063A62AEE9735C5C0BA86699E608B1952FC9191CD6E7FC23DA6EFC8B63FC5D646FE2EBDE9DFD9F61A259CD34516C0465B2E4938FAFA7357430B5E1514A52BA5E6FB0A7569B8B49146CF49F325695C6074156A5D2629136B0CF707D0D177ABDAE9FE4C53CCE92CE7F72043956E7819F5AB7781FCA68EDAEE249F3C79A995C77E01CD7A67319F158AC391C73D715A56BE442465B0476C5646EB9B70FF006BD421C6404FB34593FF0002DDFD29D05D492CF2C41E2996350432F0C73D381C7041A407572019EBD87F2AAECC077AABAC4C6CAD9AE0C733A8DA0888648E3AE2B160D4A1B89D425E4E015C9CA6DDA7D0D311D18C9EF4FC003FFAD58ABA9B854586F23B877240C8009F6159B05CEB3A9DD49F6859ED638DBF76153AFE7400BE30D6E4D1C5A98DDD44A1B250E3A63FC6B996F17B1B72D3B4F230232991C67EB5DADCE8ADAA346B7AE5E145C042986CFAE467D3D2B1F51F87B149244F6916543664569882E3D01C71F5A6AC0723A978AAE75382289D444118363EF671D083DBF0AB306A72359432CA8638CB6D13492336FC1009C02318CD6ABF82668EE032686CCA08E0DE6E18FC40AB57FA0CD178756D20D349903FC8B28DEC3E7DDD578DB82453D00CDBC4B77D4A5B6B1D6D8A0844A248A6CAE738DBD6B3C5DEA560ED21BE3344ACA19893C72383F519E6B621D3F518955DFC3B611B21CAECB33EC7AEEE3A5431E8FAADCEF85ED2DD6291F2C1E07DC467D718CFBD007ACED04521851BAA83F85145021BF678BFB8BF90A7EC14514006C14BB45145001B451B7EB4514006DF7346DFAD145007FFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (15, N'Blade Runner', N'Ridley Scott', 117, N'Ciencia_ficcion', N'A principios del siglo XXI, la Tyrell Corporation desarrolló un nuevo tipo de robot llamado Nexus, un ser virtualmente idéntico al hombre y conocido como Replicante. Los Replicantes Nexus-6 eran superiores en fuerza y agilidad, y al menos iguales en inteligencia, a los ingenieros de genética que los crearon. En el espacio exterior, los Replicantes fueron usados como trabajadores esclavos en la arriesgada exploración y colonización de otros planetas. Después de la sangrienta rebelión de un equipo de combate de Nexus-6 en una colonia sideral, los Replicantes fueron declarados proscritos en la Tierra bajo pena de muerte. Brigadas de policías especiales, con el nombre de Unidades de Blade Runners, tenían órdenes de tirar a matar al ver a cualquier Replicante invasor. A esto no se le llamó ejecución, se le llamó retiro.', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00E06E2D638557E420607381C134F10A3E7E46247FB02AEEA3139B5CC7E612C3811101BA1E99ACAF38436B113721263B461802072339E39FC6BDEC4578D06AEAF73C3C0E1AA6322F92495BBBB1BB67690E17F73D3B102AFF00D9230C08B7C81DF68AE3D2E58F9C8B744B67746C48D980781BBAE48F4C0FCA925105C5C2AC971954046E0C0865C6013C601C93D79EF9AE7798D34BE166CB21AF395DD45F7F9FA9DFD9D8C72CA375B71EE00C54D3D9411484ADB2E31ED5E6DF6AD3A13B0C9958B91F3025893FA8FAD3FED16ED34CD13C04333EF1C6580195DA3DCF71DA93CC209FC24AC82AB8DD545FD69DF6FD353B192CE3663FE8E7F002A9DC69C9B0FF00A2BFE082B9ACDBA151BD51B7AA3B76C15CB11FCBEB4B1B5BCA8A82E5E2429BF1B806C9E304FB0F7A3FB469AFB2CD219057BFF117DFFF0004BD7366B0A066824507D50553FB3096460B0162074C818EB4D0158CB39965F3A447F97E5DBE80631804F1D055AD0958993CC7CF1B48EB5BD0AEABBB28D8CF178796160A4E6A57ECC7DD5FA4566B7372EF1C2AE14155C9CE0E38A3CCB5D52DC04BA9003D374273F5EB536AC63D3B40FB53DB437082E95764A32BDF9AD5D37597B1B1B530697A7FCC3EFC96CAE4F7EF5BEB2935F81C0B9793992B6BB8DB9F050B3BA86D64BA94B4E81A2289C3E78EBF5AA5ACE996FA597D3AD224DD107569836E2E46724FBF078AF6A1AA4F77A25E4F6BE4FDAA02B2A8280805704A81DB3C8E2B134E8B42D5FC625ADED42C51A676B8EAED924FE19C7E35CF3A9C9094A51D8DE8C1D4A918C6774FFE09E096F63A9DA5E3451473209DF6AB28E09E719AD24B6D463B86B2B8FB51B9E5D55470CAA091D07AAF5AFA88E8FA53C1208AC6257C860EA3183EBF8561EA12FF006698DCBDA86036894850C40EC4D7852C553BDD46ED9F4D4B0F566B954EDF7FF99E4BE13F0FC5E238EEA2B1F3DE7B63B9007C168B3D318EDFD6A5D43C0DA9E9E176585EC51F4511A39EA7A74EB9CD769E10BEB16F887ABCF64E8ABF6450BE437C8E490589238E315278F75598D9ECB6BF984A5810AB3907AFA57AD45539C9454159F91E3627DBD34E5ED2575B6A7945F6877367117BEB7D4C420FCC1EDF03BFF5FE759D693448B32DB0911146009176B673FE151EB9ADEA12C5B66BCB8901071BE427F9D43E1B46B8D36EA4762CDE628C9E7D2B784A10A9C9056309FB4952F69564DEC74DE3083CBF03239E337899FF00C7AA6D2E02F6D600239DE400AC323B7F4CD6878EECB1F0FE200E58DE42A39F50F5D17863C3B6E9A4D8DF4B348D346BE608C3E0938E319FF3D6B684D46A4A4FCBF5381465F568AEADBFD0D4D3648E1D3667794AB49BC18B3C94C1E307047D6AF69F1DBDD410EA96EAACB711AC733C279DC9C163FA8FA014DB9F0C9BED405B4776C86581B24E0823A75F41D6B8FD37C3FAAF857C469A90B98EEB4A776B3BA0921C2123E56DBEB902B8F1525522F959E8659174A69497A7AA3AF6F0559DC4CDAA49AD6A0F123193FE3E5A20BE8A14707B0E7358DAF691A36AB7D6571ABDAC970A2DB11C6646D8ACA79623A124FAD6A1D4D544ACF6EF78B0B320B7DC1541C904B67D39E2B81D6AF5349BF6D4ADECAE2660BB1229E791A081491D005C71CF39EF5F38D4E53D5EA7D8D38D384399ABC7FAFC4E83C1D168DA7F8F2E2D749892DD534F26484CB9CBB383800FB02703A575FAC78523D461926070C46011EBD7AD7CF5A2F88DFF00E13DFED10A8A27976019E80F0306BDF34BF14C4634B3BF492493900AE40E33D6BAFDBD4A2D599CDEC21888BE55A5F6F23C73C65E199AD9F72C64004EF1F8D53F055B6FD16F49C713A8CF6ED5EC5E265B1BFB09991620ACBF28071D47427E95E79E15D382693AD2A903CBBD031DB902BD1C0E2235EAA6F73C6CEB08A86139A1B5D1278DEE8FFC20503020ECBA84E3E9BAA9D9F88B51B8D0C4704C6211360B4671C741CFD6AB78B67F33C18A01CB0B98FF0093553F0DB46DA3CCB1488CF1C787C8EFCF5AF416B5DC3A3478B4A3FEC8A56D533B3D23C477F7AF6F6E24BA694005FC95CB945C9723DCE73F857A5DBDB25DF810C5656F23F9881824A72CCCA464924F702BC0748D67EC77C2689E452CF8215B048C72A0FB8EB5ECDE1EF1B5AC9A4AEF431A280117032DCEDC7A673DB359564E714E1D0ECA118D16F9B77B11DFE99A998A4BEB547B7B9407132286057938753C32F3F5F7AF0EF1778BBC497D753E9FA85C471C69F23476E9B548EBF5F4AFA8E3D4E236877DBB0B731F2CC0631CE777A01DC9AF9CBC45E089E5F106A62D651710B4ACCB3ABEF0C49C8C1F4C102BC69C21CFCC91EDC2AD471E565DF0CF8164D4FC256BAC47AC43061F11A3D989B0C31D5872B83572E0DE685AD4967AA5E34D3B3E58A2950A49E3E839C577FF00070C76BA0CF60F6FE5207F33CA7E4EEE0371F5AC5F112FDB3C41793A2B1632310CC8548CF6E6B86B49DECD9EC65E9F369A1E5DAE6BDE20B4BABA796EC085A628919418603A301EC38CD6CF812E246F0C6A4CD21DEF74AC4FA9E2B27C5B1CD24177E65B3EDB79516293070011F31F7E78A9BC15215F0F5E283FF2DD4FF2AF5B2B8AE74FC8F03891BE494536D5D6FEA43AF5C16F0B15CF3F6843FA3547E0F8CADA5D3EE3968F76DF5AAFAD1FF8A7C8FF00A6CBFC8D4BA0DC24160B904B49C601C631C7F2AF4A36FAD26FB1E572DB0AD2EE5ABDD3A0BAD3766192E4B6E0DD06381FE26BA7D1228B43F055F882E2F7ED9246CAB1E3746A4F3C0C601C03CD739148CD205129F9D58160338E2A796E1E6D223B059A4441B8670491D8EDE7BFBD6B2A70BB715A8A9CE6ED193D0EBA0D62EFC65F0C6F6CADEC2E032AF942477DBE638C375FE227D3BF5ADBF863646EBC0568268F135B4D242DC75C1C8E7E8D8FC2B9FD2753FB3F86EDAD609A3B7FB2B0055A40188C6303D3AE6BDA3C256F60DE1FB77B32AF130CB7FBC7EF67DF35F298A7539DD34ADA9F494B96308D4BDEE725AAC775E1DB71AA58E98D74E1FE7FDEF96B9F73826B95D33C75A5F896FA717504D6BA94233244CFBD580383B4FE5F9D74DF17E28D34AB56285A1497136D959300A9C1E0FAFE7C5793E836A9A55F4FA96AF0A452DE43B6C4AB06CB71F2B63EE9DBCFBD71C2946516E4F53BE9CE4ED3E9D7D0F43F1E49A549E0CBE5C5BAC8D0F0BBD720FB7BFD2BC6FC35398F47BA41DE407F956BF896D6D6FF0040BDBF58EE61BAB59954B193F76EA78C6DF53FD3DEB0F41464D326CF19607F957B592D2F672B277DCF1739D6367E5F996BC47184D0F2B8C19978FC0D73B6570F1270F85CF2315BBACF9977A6F971E0912290B9F63CD62C5A36A20E56007FEDA2FF008D7A18953F6D78A7B1C185E58D1B4DADCD9B5BD62D1382C4F3C11F8568473A96C15258B86031D0719FE558F0E97AA1258D982DC0C895474FC6B4ADF4ED6BCE127D8010A0E3F7A9E9F5ADE9CE696A9FE26151D252D24BEF441A85FCB6D767E74DD0A9650DD0B8C60E3D719C576DE06F88F3E92F3C53CC5602A18A1C724E06E1EF5C7EA3E18D735290BAD82863939F3E31CF1EFF005AA975E14D7D6746FB1602285C89D0E403C77F4AF3711869556D38BD7D4EEA58BA308AF7D7DE8F5897C4F67E2ABC92324B4890BB046C15C671C8EE723BD65EA3A3DA5F7D963BFF003274873F2172A0BE3EF1C571FE1CB2D4B46BE92E26B520BB83C48BC019CF7F7ADED4F5ABC9A10B1DB8470D924C8BCFD79AF35E5F5612F722EDE87BD84CCB08A9B5527177F342EB763653FC29BAD460F3E2962BFF002E587CDDE0953B4124F27E523F1AE4F48C49612E17072073F414EB8BED5A1D3F52B34853ECB7CCACE9E629DAC3B8E7AD53D18CB6D6F2472F0776719EBFE715ED60294A94ED2478398548D68B7195CBB0C28EFCF619C55E0A030A28AF4E3B1E55535ECE043183CE4F5AD58ADD38EB4515B23C7AADDD970C4A149C9F97A0E2B21E466C92719F4A28A99134CAD293B986E3C74E6B266CBBF24D1454B3BA819EE0E4FCC6AAB2067E7FCF068A2B267A71D8FFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (16, N'E.T. el extraterrestre', N'Steven Spielberg', 115, N'Aventura', N'Un pequeño ser de otro planeta se queda abandonado en la Tierra cuando su nave se marcha olvidándose de él. Tiene miedo. Está completamente solo, pero se hará amigo de un niño, que lo esconde en su casa. El niño y sus hermanos intentarán encontrar la forma de que el pequeño extraterrestre regrese a su planeta antes de que los científicos y la policía lo encuentren.', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F0E0B522A7B539579ADBF0CF86EFBC51AD41A658266490FCCC7EEA2F763EC2BD351EACE3948CEB1D3AEB51BB8ED6CADA4B8B890E123890B313F415EA3A0FC07D72F5125D5EEE0D3636E7CB03CD931F41C0FCEBD8BC25E10D1FC1DA70B7D3E30F72C313DDB0F9E43F5EC3D85741207651B64E4D612AFD2252A7D64794C7F02BC3C8A51AF7509E50396CA28FCB19FD6A9DDFC17D01372ADD6A1139E13EEB64FD315EBFCA6016DBEA48EB4D9111499B7280A37176E0003BE6A55692DD8A5453D8F00D67E076AF6A8D2E937715EA8FF96720F2DFFC0FE75E69A96957BA4DDBDAEA16B2DBCEBD5245C1FF00F557D237BF137479B44D7B50D3F7DDA68F2471B15601252E70194F5DA0F7ACCD166D2FE2BE83750EA90402E6D9F6930039881FBACAC7B9C1C8E95AC6ABB7BC0E935AA3E73295195AEABC61E11BDF08EB2D6575F3C4C37C13A8F9654F51EFEA3B5736CB5AB8DF544A9122AD7BCFC26D3868FA31B8118FB4DFE096FE2118E833E9DEBC362505866BE8EF045C5B470225C1C18EDD04791D381CD6938FEEDB392752D5231BDAE77F0C1BE20C4E07402AC84F930383EB8ACDB2D4E094619D77E70101E95A0250E0B0236FD6BCB9269EA7A70716AE88A5859C9E727BF15E7DF163C37AA6B1E1A0BA6788469C8A764B6B3CC228AEB3FC25BAEEE380720FB75AF45F34E318E6B17C43A23EAC6D64867114F02C88036E01964501B0CA432371C30E4648EF4B5295AF73E6EF0169FF00D95ADDD699AD2DB49A6EA0A2CAE648EE11923958318D0B80D8C9520953C6412457A47C358349F0D99AC6D6C6FE29AEDA18E4BC9A50CB26FCF94CABC62363B82B633C8DD8AF41F0EF8634DF0DC52BC515B1BB9642F24B1C58232000A0925B0001D4927926A58F41D3ADEF16EA2B62BB2432C49E6B98E2739CB2213B54F27903B9F5A6AE2934737F107428FC49E10BB8366EBCB153736EC073C0F997F119FC40AF9A19706BEC854494C8766D6752AFC7041AF902F2309792A2FDD57207E75DF41DD3471CF468450C8D8208F515EEFE0AB9B6BFF0D25C3BAAB8B7313B38FBAC83A83EB81DFD6BC3B42D2BC49ACCE21D3ED2498A9C36F0085FAE7A575F0E91A569AC96FE26F10C974C5FE6B0D2DBF749FEFB8E3FEF9C9A98E29D65CB4A2DBFEBA975B0318352AD2497A3BBF91D67FC2650DBEA0AB1BC97530E0416A37313F5E83F3AA7AD7C46F17787350B7171E1D86D2CEED4BC51DCB9679157BE474233E95D769D69069FA6449A4DB5B69D0BA831CD6AB9DC0F7321F98FE7597E2BD0E1D73498AD6F75882099675782EAE3732AB0E08CF5F981C7E55962155945C9B4ADD17F99181787A551538C1C93EAF7FB8D1D1BE23DA5CDB4379A8ADF6910B0186B9859A273FF005D00C0FC40AEAAF3C4B1CAE1ECE64921281925560CAE3D411DABCEEE2E4D8F88AC2EEC2FA085EEAC1E6658F221BE64C26C78F1D70C4671905790715AC9A31FEC78B50D2A35D35EE3E76D36E3E58B27A82A3989BDD78F6ACA949B97BDAFA1D388A7151FDDBE56FBEDE9E5EBB7A1D959DF24D179F2C89BD8E02F4CD5E4D521709122E49E801AE474C9ADA6B5791E4749A26D92DBBAFEF236FE58FF006BA11D2A5B79E3F3BF761D514FEF19FA01EA4F615D1ECE135CD1D8E2954AB424A15159FF005FD7A1BFE20D64683E18D4F51B94F29A18584593D5C8C28FCC8AF931CEE7CB138279C57A1FC49F1C3788275D2ECE4074FB66C96527133F4DDF41DABCECF5AE9A349D38EBBB1CE7CEF4363FE127D64E9F2587DBE516F2E3CC51805C7A16EA47B135980D33D28CD74276D8868EB3C37E37D43C3EA2DC85BAB12726DE42703DD4F63FA577D63E30D13544D90EA0D60D2295921B97280E7B6F5E31F9578BE4D381A528465B9166B63E8CB6D374C834D63A44962934A4EE96DE5124814F2C379248CB1278E31515BC30D9C644B3470C639CC9228FE66BE7A0E47462283231EAC4FD4D671A0A11E58BD0553F7953DA4F57B1EE87C5FE1ED32E95EE658EF829DA45B12C403FDE23823D2B2FC54835DD26797C37741B4A5E1EDC3157F333D5F3CE3EBC7BD79259E1EF214699A15670A640092A09EB81C9AF5CB4B3D334587CA8C5C4771709E59B8B9B8F25E6CF5C4615A42BF5E3E95CF8A9FD5E3CD453737F34FD57F96A77E06842BC92C44BDD8E977D13ECF6F93D3B1E717BE19B8B5D06DF52C92D233ABA63EE9538C7B9E87F115CE1EBCD7A0EA5E0AD6350BC6BAD36CAEAF6D83637C018AB1FEF2E6B06FF00C33ADD8234DA96837D0C2A7994C2463DCD70E1F36524FDB697DBFC8F5F17913834B0F24EDBF9F9F979A7D7EE5CF1FE9453734035EC9F3E6E7877C35A9789EFCD96970ACB38432105C280A3DCFD6BB8B5F823E269941B892C6D86327CC98B11FF007C83537C0BB73278B6E270BC4566D93E84B28FF1AE87C6FE0EF18789BC5579259A3C7A7FCAB179B7415080A012173DCE7B54CAA355392E92B5EEFF00E1C951BC39ACDBBDB4FF0086385F137C3697C35A5B5DDC6B9A54B22903ECD1CA7CC6CFF7411CFE959917C3CF15CC576E837D86E84C781F9D57F16F86352F08EA31DAEA062679230EAF136E53EA3D78A9ACBE20F8A20B386CA2D6EED2DE25DA8AAC0103D338CFEB569B6972B4FF00AF225A4AF75635ADBE10F8BEE18674E58B8CE659907F5CD6C2F80BC57E19B2BBD45B4CB6D4AE8A8DACB399648C0EBF27F1FD3DBB8AEFFC63AA5C597C1C8E796599AEAE6DA08DA5DD86DCC01249EBEB5F3849A95D2CBBD6E255607860E41FCEB28CA5560F9ED6BDAD67AFE26B654E69C6F7DEF7DBF0279B5ED59AFE4BC3A85CADC39E5D242A7F4E83DAB4B4CF883E29D2EED678B59BB940E1A3B890C88C3D0AB715CC331279A6EEAA94AFA74051B6A38B5283CD25A5ADC6A1791DADAC6659E4E11011CE064F5F606A66D3EEE2B8B482488ABDD11E480431605CA64007FBC08FC2B3E7D4D39343DBFE0141CEB371B7A2C5186CFF00BC48FE559BAB69BF117C4BA8DD183FB4CD934CDE57992F931ECDC718048E3159DE19D4B5CF00EA7AAE93A49D3B529B6B493B48C55556162ACCA73C81924F700138A75D78BBE22F88E5B7167A8DB442EA2778A3B2755DC884866EE78208CFAD4FB46AA4A6ADADB727D95E2A2EFA5F6399F137827C45A03C0DAA5B122E1B644E92097737F778E73ED54EE3C2BABE917F656DA959B5AC9798F244A40C8240FC3AF7A9E1FF0084BAEEFACF50FB6CD24EB7DF64B69E5BA0C3CF19C05C9230704023838A97518BC57E23BFD3EEAEAE61BAB89A436F68F1C8A32CA4938C76073CFB1F4AD156B34DB42745D9A47AFF00C5B5FB3F80F4BD2202D24AD711C4AAB925F6211F8F38AF05D7B40D4FC3F79F65D56CE4B59D903857C72A7B8238AEB25BDF1EC86DAF67B9499B4BBE10C5233A122762836FFB47E7518FAFA1C54F19EA7E26F154925C6A696B1C1A6110C9E5483CB476EA49E4F3C73D3A62B284D460A375D6E68E9B7272F43852D499ADC97C1FACC305FCCD1C063B050D7456753E5E54B007DF03A7D07538ACED5B4ABBD12F8D9DE8459D465951C363EB8A5CE9EC572B4436B733D9CE27B699E1942950E870704608FC4122A73AB6A26E2DEE0DECDE75B10607DDCC6474DA7B628A29D905C97FE120D604FE78D4AE04BC82E1B04E739FCF273EB9A8E1D6F55B63198351B988C5179319472A55376EDA31D06EE7EB4514590C72EBDABC6EAC9A95CA95759176BE36B282030F4237373EE6991EB7AA411C31C5A84E8B0A94882B63629CE40F407737E668A2A6C8649FF092EB81B2356BBC87F33FD61FBF90DBBFDEC8073D722AB3EABA8491C91B5E4A524C6F5CE03631C1F5195071D3814514AC87725FEDFD63F7FF00F133BAFF00487324C0C9C48C4004B7A9E075F4AAB797B75A85C19EF2779E66CE5DCE49C924E7F124D1451640CFFFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (17, N'Los cazafantasmas', N'Ivan Reitman', 107, N'Fantasia', N'Los Drs. Venkman, Stantz y Epengler, son tres doctores en parapsicología que se quedan sin empleo tras quedar excluidos de una beca universitaria de investigación. Entonces deciden formar la empresa "Los Cazafantasmas", dedicada a limpiar Nueva York de ectoplasmas. El aumento repentino de apariciones espectrales en la Gran Manzana será el presagio de la llegada de un peligroso y poderoso demonio.', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F3A4B249F32E892BCF8197B2980F3D7D48C7120F75E7D56A18BCABA394F965EEA6AC5B7872F96EDE3BC8E7B468904AAC232E5F900797B7EF1CB0E86B5F50B04FB135C6AA6E5664754174D6C6298E73824138900C727861C726BD7A35795F2BD4F36A2D3431844D1B6D65DAC3B114F09C92173BBEF2E3AD6BDA4F02C690EB4BF68B173B62D42DB9D87DFBE7D88CFB1AB3A87862EEC218EFADDD6F34D90FEEAF20E57E8DFDD35E845C5BB5CE09559A5EF2FF00233F4E7824824D2AF64096574C1E39C8FF008F7980C2C9F4FE161E873D40AABF63B88279ACAE2229756EC5590FB7F3FAF715B23479350849853174064C43FE5AFBAFFB5EDDE8559751B247507FB534F4F932399E15FE13EAC83A7AAE47F08A1C39257E9D488E21558596FD0C9B340F711AB602B1DA78F5AD16D2645764C0E0E3A5594B08EE122BE807EE27EC3F81C755FEB5DBC5A48BFB3B5BB41CC8BB1C01FC6BC1ADF9A315A9E6D5AB5252F737EC50F17581965D2EE481FBEB18DBA7D6B97BAD3B646B80324FA57A36BB0C735A687668C66BD5B77416D0AEF9582B0E768E83DCE07BD51BFF000F5F5B4D62FA869B259D9C92AC4D334A8E1493C06DA4EDCF407919207715CD4B174A315194B5D7F334A986C539B9C23EEE9F8AFD0E03E1EDE3C37F35AEE99C32878EDD652AAC4119C7656232035753E3BB4D34E9EDF6DBC64BB67558D3C92C96EC3AAEE04B15C6073C9233DEB88F0F974B99986E1188C191A304B8F994AEC001CB6EDB818393D78AD1D4ADE38F4D68E1B396DF2EAD72F72BFBF9B2CE448CC090E4B171907238180315E63A16C4C5A67D37D66D879536BAEF6F43163B7D434DFDF44049049F299222248A41E87B7E04035B7A0788EE746B832E98EB12C9C5C58CBF3C138FA1E9FE79ED5EBDF0F3C3DE1BD43C0D03369B6B713C9B92EDE48C33F980F233D40C608C7620D707E3DF0541E1BD492411CA74FB927C99E33964603251C1E18E3907824039E464ED471509CFD9CD1CD5E84A30F6916741A759E93E20559F4D53697446E7B276E87D636EE3DBAD4B7DE166BA905E5B0F2B538886C8E3CD23F93FF3FAD721E1E7BBB3952488ADFDB2F25A1E244FAA1E7F9FD6BB3D6FE20DB69F611C16B12DF6AD226551F21615ECD29EBF451C9F61CD6D8AAD2C3AE7BE9E7F91E6E0707F5AAAE8463EFBEDD7CFCADF77C8E5FEC91E8D732CB7612D74ABC6DB36F3B56DA61D08F6EBC0EC48ED5D2F87614D4BC3F36A123B49E1F8E60A8825F216E5F3B5E4776C15897A63F88A9C83C03CAF87BC37AA7C44F104B737F7933C10301777C401B49E7CA857A2B631923EE823392457B5DE785F46BDF0C1F0E4F649FD93E52C5F67562A02A904720E7A80739AF2EAE3E75E364AD13DFF00EC6A782AA9CE7CD5168EDB2F2F37DFA2FC94D8D969169F6AD2745B69241B7E4B5444665C8C953C6481CE33CD72FF00123C457DA2DBDB5AFF0066D8DF69FA96E89FED21BE420676951D723907231B4FB574771A668FE239F4DBA5B91709A55C79D12DBCC0C7E605C0DC075C0391E95C8FC658251A269BA8E0FD92CEE4FDA187FCB30EBB558FB6703FE055C551B506E3B9E8E0A34E788846AFC2DABFA1E51A1DAB6966EAEA79ADA5856104F95708A73B97072DC2E0E0E48C715A6FA76AB7FA5AC370B692BB959235B13BBE5F9B7124001816CE368C0E79352D8AC11C5331562AB1AB6238FCC6C865230B919E40E322B57C1D6C1EFA79AE346B5D3E497616F26452643824E51490B824E39C9CF35ED5693A7894FF00AEA7CCD1A8F118572DB5FF0022D7834EB1E17BB32C3697124320027B761B7CC03A15CF471DBB11C1EC47A6DFDBD8F8C3C37247048A43FCD13B2730CAA723729E4107A83DB23BD6516963BBB0B2B578E1376CE3CF994B2A9500ED0011963938C9E8A7AD10E957377E22BDB27BD77B6F2E26D424857CAF31803B2218E84A9DCED9C91B17815C58AA919D4E64ACCF43054A74E9F24E5CC8E1B5B6D2747D09AF22B58A2D63CE36B1DA4727FABB81F7B701FC0A3E6CF71B7D6B8545605DE595E69A462F2CD21CB48C7AB135F41DE7863C39ABAC9612E8F6A520014C91C62368D88C80ACB820E083D7B8AA5A57C37F0DE9EA8D2E9E2EA643F7EE646941C743B49DB9FC2B8B16EB625A529688FA0C8F1183CAD4E6A9DE72EBA6DD8A3F082EED65F0325AC4C9F6AB5B9996E9475DCCECE18FD559707FC2BAED6AF6E34DD0EFAFAD6D1EF2E2DE07963B74EB2B004851F5A4B6D0F4BB2BEFB6D9D8C16D705363BC08137AF60C075C76CF4EDD4D5C9E37960748E5685D86164500953EB8208FCEA92B2B1E7D5929CDC96CD989E0AD46E757F0958EA379A48D2AEAE033CB6A10AED3B88CE0F3C800F3EB56FC482C9BC33A9A6A3B4D9BDB48B286EE0A918FA9CF1EF8AB7616F3DADAAC7717925DCB925A6915549F6C28000AC1F13EB5E1FD3A7B77D5EF37BC0C258EC63F98B38E558A8F4EA33800F3D40C0DA4AEC29D39D4972C15DF91E07E1CD49AE9AF229A259A216F968CAC67772A3A49F275C7DEE2B4ACF529344B59AE92D349B3B80D1A3FF663A96C1DC4F9817E51C93B71DB8EC2B9DF0806179792234A922DAB6C78A558DC1240C8660403CF522B5750B578BC3D2AFD8CC56DBA374B8F3E299A79097DC5A48FEF3602FDEC9E7D0D7AB39736262D9E3AA318E1E508E8BFE18F49F0BF897C25A9692BFF000905D23EA2189737C494EA7698F3F2AE063A60839FA9D2D3F5998D9C1A4E83AC69534CD22AB49123CB3BA9601E5218E0100EE258B0EDE82BC1EDA09657DB0A927B9CE07E75D06997F0E8B325C3EA538B88CE512C9B0CA7BFCE7819EE39AB9E5B74E519111CC941A8347D21A6D90B0B08ADF7B48E066495CE5A473F7989F5269ABAADA3EA7358A4D1B4B0461E7C38FDDE7EE83EE4027F0F715F3ADE789356D62F2E8DCEA9A8346B266388DCB00A8402BC2ED07EB8ED59CF6D0C88CAD121DC0E495C939AF02AE23D9CDC1AD51F6F82C8278AA11AEA69292BAEBFE47D0A9E2ED3750F14C5A06977D6D73751A34F77E5C8184518E31C7562C578EC339ED96EBDE3AD0F40DD14D73F68BA5FF977B7C3303EFD97F135F36E8DA1C1A24C2E2DE69BED414AF9AAE5480460818F515A8001D062B2A98B5B40ECC1F0D49FBD8995BC97F99D8EBBF1275BD5F7456AC34EB63C6D84E6423DDFB7E18AE3C1264DC492CC72493924FB9AB7A6693A86B373E469D692DCC9DF60E17EA7A0FC6BD2340F84EAA527D76E7791CFD9ADCE17E8CDD4FE18FAD73A8D5ACEE7B33AF80CAE3CAAC9F65AB7FD799E3DE132F0CF79306990A400EE81C2C8ABBD77153FDEDB9C7AF4EF57B50B68ED7409A782CE0B58E49233B45D19A6206E0AB3124E18280401C0DD8EA2B3BC15E6C9A8DE2424F9CD6ACA87732E324679565238CF46153CE968BE1EB94B5BCB5BBFDF46CFE45B794EBB8311E63125A427B649239F5AFA772BE222D1F9672AF64D7F5D0C759A49060B1DBE83A55EB1B469DB792B1C4BF7A593855FF13ED549484FBDC9FEED5C52D32ABCEE5615FB8A3BFD07F5AF5E1BEA797884ED68E88D3BB36C3CABBB412B4312886E657E37027E57C7600923E8DED4B5D0784EC23BEB79EEEFB65B68B6E08B891864383FF2CD47F131E9F8D7317171696B7D2C76C64FECE2E45BBCAD968876473FA06EFD0F3D7E7339C0B7375A96BDCFB7E0ECF15387D4715A6BEE3FD3EFDBBEC3E6956081E570C55064855C9FCAB991AFEA9ADEA1169BA0D8C8F71336D8D42EE763F4E8057555B1E13F103783EFA7B9B1D3ECE4FB41FDF6E8C2BB7D1C723E9C8F6AF128CA9A7EFA3ECB35A38DA94ED8595BBAD9BF47FF000DEA7AE685FF00092E81A25AC1A868F61765631E60D24888A1C73FBB7C2B7D430CFA56CDA7886CAE5D6374BAB599B8F2AEAD9E339FA9183F8135CBD8FC59D127502F2DAEED1FBFC8245FCD79FD2B557E237855973FDA98F630499FFD06BD15569B5A33E1AA65F8C8CBDEA72BFA367CD1E1FBCB6B49EE16E56268E68826D99731B6195B6B707821719C1C6738AD2D5F59B79F4AF205E24B317DE21B780450DBF2D954C004AEDDA32C33904F19AE5943CB22A229676202AA8C926AEE12C3BAC9763A91CA45FF00C537E83DEBDA8C139A923C193F76C4D0C42101EE07CC465623D7EADE83DBA9ADAD1F4DFED5B869AEE6F26CA2199A53C703F857FCF15836D99E4DD231DB9CB313C9ABF75A919E25B48488EDA3192074E3B9AF423A46E70D55272E55BF57D91ADAFF0088CEA4B158D9A7D9F4BB6E208178CFFB47DCD2E98134CD38DECCAAD3DE2B470230C811747720FAF2A3FE05ED58FA4DAA6A57C564768ACE1432DC483AA443AFFC089200F7614ED53527BCBA79CA88C36123897A471818551EC0605116B6E829D1D2CB764D14BFBD98DA6D482352FE5484ED007F74F24649E01C8E7B55A9A6FB2CCF0DDC6F6F221C307E541FF78647EB54EC596182DDA4FF0096F2F98C0F78E3E7F56FFD06A16BA95E79272E7CC918B3107A92726BCDAF9450AEF9A3EEBF2FF23E8301C4F8FC12F65F1C57F36FF7EFF7DCD5492390663911C7FB2C0D3C03B871DEB199D5FF00D645139F568C13F9E2B4B544B13A5E9B241636D1C9B712958C7CE70393F91AE0970FCFA4D5BD0F723C7704D29D0777FDEFF8062BA0B1D26CE5832B2DE239924FE2001C6D5F407BF73EB8AA31C619D54E704E38A28AF5A9EC8F907B96AEBF768B1A70A476A8651B2089413FBC5DEC7D4E481F851456F57E233EDFD7737FCB5B4F0869C22C83A84B2CB707BB794C1517FDD19271EA73E98E7EE58F9CFCFDDE9451497C1F31BDCD5D410477EF0A93B208228D3E85031FCC927F1AAE07BD145691D919F41E14629D3B31B7452C70A78A28AD96CCCA4BDE8FA9FFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (18, N'Karate Kid, el momento de la verdad', N'John G. Avildsen', 126, N'Accion', N'Daniel Larusso llega a Los Angeles procedente de la costa Este de Estados Unidos dispuesto a hacer nuevos amigos. Sin embargo, se convierte en el blanco de los ataques de los Cobras, un hostil grupo de estudiantes de kárate, cuando comienza a salir con Ali, la antigua novia del cabecilla del grupo. En tal situación, no tiene más remedio que pedirle ayuda a Miyagi, un maestro de artes marciales, para que le enseñe kárate. Bajo la tutela de Miyagi, Daniel desarrolla no sólo sus aptitudes físicas, sino también la seguridad en sí mismo que necesita para superar todos los obstáculos.', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00CA8FC3D35E58C5728B0223A80329D3E6DA3B7B66A38BC1B74669A3135B4850AF2AA4EEDDC8238E9575A5B9857CB8EEA6C01CA83C76C8AD5F0D5A1D420D6B2924B341682580099D06E07001C301B40F5AE14E37B1EA2E7B5EE602F852436F24C93DB34718F9BF764738CE391F4ABDA7785E69208AE44B6EA1E35940D9D01FC2B5753B1BEFB71D2959A1B8B780B5CDC3DC3E251B72480491B70780064FE8190E95ABD82BF997509B7B68A39983CE55444FC2B60F6EDFD2A24D3D12B9BC54959B92455D4FC3DB1A29775BA2CCC1784E031383DBA671F9D546F0DB2DDC56BE75B996405947967180339CE2BAFD774AB9B8D2A29619E26F223F3672B2EE5001037061C1C75F5C1AC9BFF0E6A1697F388EFD592CA38FCD9B7B7EECB81F2F033C92700761CD7D260EBCA5423CD2B3B1F198FC328E227CB1BABF4F3DCABA9786CC7A0451AB405D8BBEE1175C0FA703835E5E3C07753470C915DC1FBF8D248E328DBBE66C63001E4753ED5EF163E1FBCD4343BAB0B93E5EA305E0B7323CAD800A83D8F3DB1F8571175677B7371AE699A76997662B581238A34D45D668CEF0A4E1B3BB3D368200CFE35E5D6938D795F5B9EDE1A9A961A3CBA25F81E7975E02BBB582466BEB6324707DA1A3DAC3E40093CFA8DA78A8F51F025E69DA54FA8C97B6CF0C49BC6D0D971B828C647AB575DAE68777A6F8235E9EFEFC5D6A561790DB2CF0DEBBB207DDBE391738C8FA773CF5AF399F5CD5AE219619B52BA96297EFA3C8486FA8AA4EE2945A7667AC19923011DBCCC00007EB9C7AF615A7A1EA496F0DFDBA451C9F6D84C52798E5582F5C003A9F7FD2B2AEE35C160B9E99E7393FFD6A4B38B73E48CF3D2BC994D2D51EE52A52D99D7DB6BE8FB23B8B5B4796DED7ECA970F2B6F643DC1ECCBD8F6C9ABD06BD1ADC4492C7625A68A2B52CD21C9546F9701BA9E7D4E715CA35B3CEEB1ECF3C3F1D70E3F1EFF8FE757EEF45B4D2A2D3A6549A4B949FCD6564F95471DBDC81C8F4A8555BEA6B3A515EEA5AB3A4D77588D26B9B6B782DFC96B76B6740597393CE31C0391D7BD665CEBD34CF74A52DB65E05F3FCA91D4964002B06EABD318E47269971633491FDA5637681BE6126D3820F4E6A8FD9B0DC8AFADA3469722E5773E16BE26B73B525666F585F1B5F0F5DC8E618A1F396433191B86DB8EA4F6181DF9ACB1E36B16D5AE2EA1934F8AFEE523473E630E410C1B0475C819F5A9AEEF6C34DF0EEFBE844BE55C09204DB925B1CF1DF15C76A3A95DF8874BB4D4EFF0045B6923BA91E389E05612654E338C7E1F515E0635B58895B656FC8FA5CBAD2C346FBBBFE7E451F1BEA8D0693AD5BC5A45A98359B94BA9EE20B872C93292738231B793C76C9E7D3CA335ECFF65DB09B79A323036B249C9C7A1AF3EF15787974D71756C845BB9C32FF0070FF0085187C4A93E596E6B8BC1B82E786C7A7EC8D9B3D781D69AB16D7DCB5521989C64E78157BCE454CE7935E534D687B49ADCD4D32E6DEDE5DF22B1900F936F18344D1CF3F8BE192FAEE448FCA0E5D548DA0745503B9FEB56340D384AE97D7788E05618DFF00C47B0AD9B9B0B7D56F2E77B7EEA5503CC858A39C745561C8FC29D38CAE92EA7357AB04DB7D17F489A7BDBAD42C4196D9ADA157DA88576961D47E559CB6A0B127800124FA01C935B0A8258624490B4112EC41927A71D4F5E94E8A031C9B863B8208EA0F515F538753A54792F767C7625C2B57E74AD1383D4E64BD91A461FBB54DB121ECBEBF53D6AE680AF6BE048C6DD81A5924878FE163D6B56FFC396D6F692CF149738660BE5800851DF0719FCE9FAD451AE8D6A96A8238238D55157A000715F315FDA46528D4DCFB0A32A35234FD8AF776390101672CCDB98F52698F6F1C8FE5C88AE848CAB0C835637114D8C7EF0123BD657676B89CE5ADCEE6009C56FE9F14124AAD2C800CF1DEADBFC3DBF82704A068F009653572DBC3C2CBF86E0CC465047CA8391804D74548B7B687153AD1EAEE742890C8B123C44C11AFCAAF8E4FAE3D6B534D9E0BAF33CBB47842367122E3271D47B555D3209A5891A5468D812BE59E8E7B9CFA63A56DC70081760ED5D583A2DEB23C9C6D557B2295DCD1D85BB4D3B431C2832D34D208D179EE696CEEACAF485B7BBB69A4D81F6C332B9DBEBC76F7A96FA2D49D633A7AD9C9B493247721B0E3B00C3EE9F720D78378C27B3F0FF8D93C4766B209679CB5C698CA60684AE0491B95EA1B3904707AF35EAB9D8F3234F98FA00C28C85587047A679ED5CE5ED94FA7E9728BB904C6772ECD9CE3D8574565751EA1A7DB5F41930DCC4B3267AED6008FE7516AD62DA969AD6C8EA8F9C82DD0D70E3A87B587347747760311ECA6A12D22CF2C70371C1E29A09DC3EB5D1B7843550DF722C7A89050BE0CD4CB8C793C9E9BEBCA542ADBE17F71F44F1743F9D7DE6F8D4F74800B9B8E807F0FA7B56845A8460AACA2524749319FE5571C36EEA7EE8EF8ED4C68C3750A7EA4D7D2CF964ACD1F150E68BBDC86E357D3ED62CB339E7A043927F1AC8B8D67CD26447B98D89F963C800FE3CD6C3C0BD4471FFDF159BA8E9E9776B240F3CD02B0E5EDDB638FA1ED59C63CBB1AB9737C479AF891B51F1578AD6CE0D5AE6CAD34B80996E239C8DB3BF20718C9000C8EDCF4AE23C473F88352D42DF45D5F511A9CD6EFB60941DC48603927009E31D7915EBF6FA47863C3D0B431C48BB9CC8C6477964663D49EA6B80D196397C61E22B993315EF9B882175E9093C30FA80B58D59496BA1D54145AD8F45D2B506D3EC2D34FFED65916DA04887971B0C85006464E2B546B71E39BA95893818E33FAD72304924EA3ED491E627214107A8FE219A94E0E410BD73F8D72BC655DB4FB8E8583A7BEA75275947FBB34A33EAE45226AABE62FEF243C8FF96A6B0237554E640BF952891D9C7EF89191C2F153F5AADDC7F55A57D8F4271F37FC047F2A630E3834D9E78A26F9E48D7E51F7980ED5425D6F4E8739BB833E8181AF56C79243AAB6A2B0B359DC22E064831FF5CD71374F777A733DDC920EEA4E07E55BBACEAC9A8C1E55BBCA39EA0601FAD6398D6340A0D7162AAA5A41FDCCEDC2D26F592FC0A5E4EC5C02BF80AE2B5BF10E9D67E23B1B98CB34F0318EE5C0C0311EABEA483CD774FB546E3C62BC5FC571BC5AF5DAB801B793C7BF23F9D72D08A94B53B6AC9C63A1ED76F22C90A4B191B5D430247507A538A64E4BFE5593A1DE89743B17E30D6E9FFA08AD0138FEF63E86B171B3B1AA95D165404190EC4FD2951B322FCDDEAA34E73C31A48E43BD7E7239F4A2C04D34F26A8E24BA2AC78E8807F4A5F21236C28C628A2BAB132939EACE4C2C62A1A21DBDB18CD308CD14572B3B1114F681E3CF9F32FF00BAD8FE95CF5EF81F49BB99AE6E1EEA595F96264033F90A28AD60DA5A194D26F527B1F0B69B6AB88CDCE17800CED803E99AD05B08236217CCFA9734514A526C71481AD6207F88FD5CD2C76F1065C2F7A28A9B8EDA9FFFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (19, N'Hombres de negro', N'Barry Sonnenfeld', 94, N'Ciencia_ficcion', N'Un agente de policía se une a una organización secreta que controla y monitoriza la actividad extraterrestre en la Tierra.', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F248E2478E46695559470A47DEA8A8ABBA4E917FAEEA51E9DA65B9B8BB941291860090064F2481D057A6DAB1CC52FC3F4A2BAD9FE1878D2DADE59E6D0A658A252EEDE7467000C9380D55343F02789BC49A70D4348D2DAE6D0B941279A8B923AF0C41A9E78F71D99CED48F3C92451C4ED948F3B063A66B7351F03F89349D4B4FD3EFB4D30DD6A0FE5DAC66543E63640C641C0EA3AD4FAC7C3BF15683A5CDA96A7A5182CE1C799279F1B6DC90070189EA453E75DC2CCE628AEC2D7E15F8D2F6CE0BBB7D1B7C13C6B246DF68886E56190705BD0D25E7C2DF1AD8DABDCCDA0CAD1A0CB7952A48D8FF755893F852E78F70B3390DC766DC0C139E9CD03AF4A7C462C9F34315C71B4F39A60EB542035DDFC1BFF0092A3A5FF00D739FF00F45B570C49924C85505BB0E05753F0E7553A2F8DED3515B1B9BD104533182D5434841420E012338EB5335EEB1C773EAD79A07B8364E4191E22E50F75CE0FF3AE7FC1BA3C7E10F0969FA4CE552412BA8C7F1333B30FD3F9571F77E39BF97C5D61AADAF8735136F6B6D2DB5E5B8961694191A329F28738E40EB8E0E7A66975BF1B6A77DAAE897117867518ED6C6E1EEAE11E58774988D9142E1FAE5F383F8571723B58DAE86FC509520F88DE019A56091A5DB3331EC37C74DF8A1E35F0F6B1E01D5F4CB0D4E1B8BC288DE5467760095739C74E86B9FF001EF89AEF51D7B41D78685796D0E89739996596225998A15036B1EF8FCC57377F0C7A5F85FC402DB409ADA3BB8D6D8DCFDA6270A44AAC436D63B983871C723807A55A8BBC457DCF7DD1803F0EB4F06E8DA83A4C7FE903AC5FB91F3FE1D7F0A87C373BC5E0A89F4BD5BFE1289A356097524EAA666C9E0B738C74E726B93D3BC777365E1EB7D22F3C1FA8C8B6D6F1D9CFBA6842B9DA14E32FC8383CFA532DBC76341D17ECDA1781DAD2DD32C81EEE08A05CE4EE660C783EBDFA66A7958EE8F03D605C8D6F50FB6DB8B7BB373219A10302372C4951EC09AA43A8ABFADDE5E5FEBFA85DEA2A16F65B8769D40C057CE08FC3A7E154475E99AED460C029273B4B01D714F8279EDDDA4B79248D8A95668C90769E08C8EC69A24651B4336D2412A0E3356EDAFA78A19208EF27B58E64F2D8C4DC10082372FD40A526D2D15C68B0DE27D75D5436B17985CE089083CFA9EFE9CF6ABBA6EA5E23D66EE3B44D7278C0E8D2DC88D07D4923F2ACB16EAF859FCB8A561F24C33E4CBEF91F75BDBA56BF85A0316B1258DC259F9D35BBBC515DA12ACC8377070406201C75E6B2A925ECDB8EE694D2734A5B106BB79AF59CF3E9F7FAABDCAC8419364A191C8208E475C103F2154EEBC45ACDF4124175A9DCCD148417476C8620E7A7AE6AFF0089965B4D5E14FB25AC245A47298A35047EF177EE2300927775C573AEC9122C934823562429209271D718AAA6D72294B714D2E66A27573DE6BF6D6BB61F104B3C89B9DA186E7CC28158B31E06060B13C1EE6B2C789F5F32997FB62F0B639CC9918E7B74EE7B56D68B7F67A8E8DA8BDC6A42385B4FB86963450B3349185C6474DADB97EB820F7AABA4F852436E353D684969A6260B237CB34C4F4555EBF53DB9ACE94B47CE5544AEB94C1961BC942DE4D14EC2E646C4CEA7123E79F9BB9CD42C8D1C851D4AB29C107B1ADCF126B67519D208240965028486DA261E5C407A63A9F7AC227279393EB5BC24A51B99CA3CAECC5472849014E576FCC338FF00EBD20EBC8CF35612D8B119CD4CB69CF4E287245C68C995E3BB96D239248950AA0DFB24195F4C7BE738A96D3C470CEC6396D7646183C50A4A5446C3A956EA33CF153B69EB2AB232928DC60D73777E45B6B170AAA0C71BB2AE471C719C573557EF7323574DC5599B3E24964D4F5B86EA18C00B04490DBAB12C238C055F7E8BF5AC6D5AE85CDD8D8A5638D42A83D7D493EF926956F5F7A207668C36E600E37FF8D696AD670AB79E6D5E08E5758E332CDBD94F56638E31E83DEB1BF440A2EDCDD893C250F9524F7F258DC5C85429108D7E50DC12C4F4E3D0D3758D6B57D722824B8984A616F255481BC927A7E3FAD673DD6A1A55D3593CF32A40F831A3E075EDDB9FA558D0D7CF372D8F9C306DDDF9CD11E66F95E8168BB72EE4F120B3745056568FEF6E1952DDC01E9DA909CB67D4D5E9616644420610606063FF00D750A2CB09629FC4369C8CF15E845C52B743295392DCDF8EC09C7157E3D21FC9598A8D858A0F5CE33FD6BA48F472A5449B532380C719C0C9EBE839AB7259FD9E0BA7CC8D14767E62AA49C64FF10F438EF5E23C673CAD17FD6C7D256852C34537AFFC35CE51AC4410C9330C08D0B93F419AF2B8A29AFEF962894BCD3C9851EAC4D7B2EA7AA6973F81F54960B8DD3C36BE4C88E4870E405EFF007BAF519AE47E14E8C350F105C5F491EF4B28B2BECEDC0FD3752FAC4A309CA6BE139313C95E74E30EA71D6AB258EB50C73031C914E15C1ED83835B5E3794AEB0B62385B75E47FB4DCFF002C55DF89DA59D37C5EF32A144BB8D661918F9BA37EA33F8D6569F6F71E31F19451B821AEE6DD26DFE040327F2515A42AA94154E963925170E6A0B7BAFD7FE011CFE1DBC4F0EA6B326E21D86548E421E037E7FD29FE136DDAB9B62789908C7B8E47F235EF175A35A5D58496324416DE588C7B40E8B8C0C7D3FA57CFA167F0DF8976CCBFBDB2B8C3AFF7B079FC08FE75961B17EDAF6DD1D188C3470D38496DD7F53BB934E3D855292C8838DB5E88FA65B5D411CF68C191901C8EF900FF00222B2EE348656FBB9E6AE963D37667A4F094EA2BC0F381E2FBA9A3592F2F6E66BC58CAA4CED92B918F5EE38AADA87892E2F6D9AD7CE7F2026C45DE7F0FC07A1E95CED15D29A5B23E69ABEE6FDFEA7692E8BF658D41989425B038C75FCFFA55FF000E6B96DA568B25B09DE396EA4737013037A0501064F4C36E391EB5C8D155CFADD89452563ADF146AB69AAE8DA6C714EED35902A4492972437BFB11547C27A9C3A46A4F792395942158D836003D79FCB1F8D605149B4DDEC56A7A26A1E3FBBB983F75A84913BF2C01EE060631D0719C0C726B93F11EA7FDB3A8ADFB38791E354918A85662A31B881DCD63D150A305B45229CA4F7677DE12F1CCFA358B40E12740A15629A52A1581E181E78C718F6157E5F89F2B5D5BC8618BCB50BE6C68C70EC09278C700820753D2BCCA8A8951A529394A3AB2E35EAC62A31968828A28AD0C828A28A0028A28A0028A28A0028A28A00FFFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (20, N'Jurassic Park', N'Michael Crichton', 120, N'Ciencia_ficcion', N'El multimillonario John Hammond tiene una idea para un espectacular parque temático: una isla retirada donde los visitantes puedan observar dinosaurios reales. Con la última tecnología en el desarrollo de ADN, los científicos pueden clonar braquiosaurios, triceratops, velociraptors y un tiranosaurio rex, utilizando para ello la sangre fosilizada en ámbar contenida en insectos que los mordieron hace millones de años. Los paleontólogos Alan Grant, Ellie Sattler y Ian Malcolm visitan el parque y quedan muy sorprendidos con los resultados obtenidos. Pero cuando un problemático empleado manipula el sofisticado sistema de seguridad los dinosaurios escapan, obligando a los visitantes a luchar por su supervivencia.', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F00A28A2800A2AD69FA75E6AB7A967616F25C5C3FDD441FA9F41EE6BA9B4F0BE956A717B7136A972A70D058304850FA34ED904FB203F5AC2AE229D2D25BF6FEB6F99B51A152B4B969ABB38CA5E2BD0CC76166995D1F43B641DE7592E1BF12CC07E954A6D5B4569045358681306E3F776D2C38FF8123F1F91AE78E35CBE1837FD7DDF89DB532AAF495EA597AB4BF5B9C4515DADD787B45BA5DD134FA3CA47CAD2BFDA2D5BFE0600641EE411EF5CCEABA3DF68B7420BE836332EE8DC10C922F66561C30F715BD2C4D3A8ECB47D9FF567F238EB61AAD176A8AC50A28A2BA0C42A5B5B69AF2EE1B5B78CC934CE238D0756627005455D3F823FD1AF752D5B00BE9BA7CB3C5ED21C229FC0B67F0ACABD474E9B92DFA7AF4FC4708F34923A286CE0D3ADA5D16C1F3021D9A85D21C35E4A3EF203D444A78C0FBC739A959A2B684B36D8E38D7A0E0002B843AEDF0B58ADE393CA58D704A756E7393EF50C226BF936CB70E47032CC48C9C01FE7DABCEFA8CDEB397FC1F3FEB6DB63E9F099BE1F0B4D52C3D3BC9EEDE9AFF921FAAEA525FDD3B6E3E4EEF9169348137DBD5E0804F22825632C0678FD7E95BD169BA7D83007CBB97932A7320C2AF3963E9E94D1A1CDA75CA5FD830B88D39F29BEF63D8F435D1EDE9A872474ED739FFB3B152ACABD47769DE56D5AFF003F95C863D424D22DE2442C9222913DB4EA4293EA87DFF2AD6D3B53D3B53D3A4B1BB461A53B6658CF2D62E7A4D17FB39FBCBD08A75ADD5A6ACCC0C5F3A8E73D47D7D2AEC3636D0090470A8F3461CE3EF0F4AE2AD5216B49352FEBFA47B10CBA7888A8C66A54ADA69AAD3A7EAB67AE8705ABE9771A2EAB71A7DD01E6C0D8DCBD18750C3D88C11F5AA55D6F8B6233687A15F3F33224D6123776F25F084FFC0580FC2B92AF530D51D4A6A4F7D9FAA763E2EAC3D9CDC4ED74FBA4D2FC036779159D8C93CDA9C90BCB716A92908114E06E1F5AEDBC61E16BDD2347D6BFB3F51D3CDAC768AF70834C8E19644323000327FB99ED5C8E8FA5C3ACF81F4CB1B8D461D3A293559C9BA9C1288442A403F5E9F8D779E27F177862EB52D4F47B9BEB97B2BCD3E185AF2CA3F342323BB15F72432F2323A8F7AE6A34A9CDCA5249BE67F83347269257E872AFF07EFADA6D835BD30CECC23852547512C853785191D700FE555C7C3CF10DC786A3D403DA25CBCA2016423DB283E6793D7A633D7B57712FC4DF0BC5752BF9B70E8F72BB65FB230302F9217CC5C8EA08C63AE09ACB93C73E169CCDA39B8BB8ED7FB305BA6B06390CACE1B763CBC75DDF3EEC8E475C575EFAB4119B8A6A2CE7FF00E15C6AB62B76B26B3A535A5A4D141BE40ECA667DB940BB7EF0DEA79F51EF86EABA0F88341B2D56EA7D474D8AD6C67F2232C9B0DD49805846B8ED9EF8E87D0D74B75F11FC3324FA849FE9538B836F018E5B6C24A50E4DD363F880E30003F22FE18DE36F15F877C57A55EDBFDAAEA3B8B3BB79EC1D6DC95B957032181C6D20E793E8319CE2A654E12F891AD3C557A4AD4E6D7CCD34F0ACD79A0E953D96BC1756D46CBED70DACF6CBB24C2A9650C3A60B01CE6A81F09789D6DF4595B51B056D4E448C47E51DD033465C6FE3D148FAD694FE35D2F42F0D78512D7EC975A88B25B77B859379B052B1EF250756F6E3EEF7E9576D3E23784AE758BE372F35B410CF0CB6D7623924370514A83B36FC981C7BE6A1D0A7FCABEE36598E2FFE7ECBEF66445E13F13C7A74F0C12E87AA59C4B25DDBBB5A8984B216C3A2E470D918E78FC8D63EB562D6FA578A2C2FED7447BAD3E3B7649B4FB654D85A4008CE01CE3822BAA3F1334384CD7D67712C322594B141A77D9DC45E6890953900001C633E9F9D729A94FA45E69FE34BDD10CFF65BA86D6674950A98E46972CA33D467BD615E8C2094A2ACF9A3FF00A5239B9F99EAEFBFE471761E20D634BB736F61A9DD5B425B718E290A8CFAE3F0AB7FF099789BB6BBA87FDFF35878A2BAE587A5277714DFA239D4E4B6674965E3BF10DB5C079F5092FA020ACB6D787CC8A453D4106B6A3BED0B56451A76ACFA0DC753677A0C96F9F44940CA8F6615C10AE8747F148D26C3EC8749B2BB05B24DC2E411CF6F5E7AE7A015854C1527AC172BF2B7E2B67F75FCCDE8E26AD3778C9AFBCD66F0BF8A4C78D3CDADE42463759DFA480F39C8CB6453BFE119F19312D771456B852BE65C5E4712A83EDBAA9378D20FDE15F0DE988EE08CA2E366463E5E38F5FA9CD4563E2DB7B2D360B46F0FE9F74618F6F9B7237B31DC5B3D3D4FE42A7D857EF1FF00C075FF00D28D7EB953F99FDFFF0000D97B8D2B4B87FE275AFA6A12018FB1E90BF7BD9A63C01EBB79AC6BDF1DEB123A47A648349B2886D86D2CFE5551EE7AB1F52692E3C5B14C922C5A0E9D06F468FF00769D88C73C738FC2B99C714E9E0A9A77A9EF3F3B5BE4B6F9EFE6456C5D5ABF149BFBCDDFF84D7C4FFF0041CBDFFBF950DE78A75DD46D24B4BCD5AEA7B7931BE377C86C1C8CFE3591456EB0D453BA82FB91CFCF2EE14514B8F7AD8812940F6A303D2971ED41485C7B5348A5E68A004C506968C500252D252D0037BD2E6938A0D048A29D4D1EF4EE282907149463DA9714009452D250025029714A050034504514504894A28A281A1726968A281876A28A281B12928A2811FFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (21, N'Indiana Jones: En busca del arca perdida ', N'Steven Spielberg', 155, N'Aventura', N'Año 1936. Indiana Jones es un profesor de arqueología, dispuesto a correr peligrosas aventuras con tal de conseguir valiosas reliquias históricas. Después de una infructuosa misión en Sudamérica, el gobierno estadounidense le encarga la búsqueda del Arca de la Alianza, donde se conservan las Tablas de la Ley que Dios entregó a Moisés. Según la leyenda, quien las posea tendrá un poder absoluto, razón por la cual también la buscan los nazis.', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F22518000EE3001A9768EAC401DC54FE50C617AFA574BE1B33DAF84F50D56E844B0405C45224786723A9C9FF0068803E95E7D4A9C91BFCBEF3E8E9D34E7CB276DF5F43921E671B206C6320B8DB91EA3BD4F15B5DCF9D9692B01D4A26E1F98AEF746D127D4B4A16DAB5C3BEA1A941F6865C00C91020003038C647E24D57FB23DDE8D7D7F1EA71E9F6F77388ADA47908F2E088EDDC8A3925883D3DAB0FADC5B692DBFAFF003FB8AF67149372DFA69FD76EBD7C8E1CC728121D8C44633210BF747BFA5486D6650C1E1914AA866CA11807A1FC6BAC9355F0F496126A10799752C938924B4DA519D940552E48C6140DD8EEC697FE126D3E2D559EDAC25B98263FE90F315591B685D8547230304E0F739A7EDAA3DA1FA0D460F54EFF00D7F5F89C94D653C0B2B4B0BAAC2DB6562BC213CE09EC6ACFF606A4D6A93ADB6E8DD43A61D7257D719E057402E2C35EB49B4BB8BCB2D19166F3A279B7B79ABCF5E305F249273CE47155B52D5AD6299ECEC2D62B8D262B74B544B853FBC0A73BF8208CB738FA669FB5A8ECADAFE845A2DB4B5FF3301746D4CC8CBF62903062A41C6370C719FF00812FE755EE6C2F2C115EE51515E468D70EA7257EF0E3D09ADA9BC4FAD38402EA35557570A2150032E70718F7FF00C747A5655F5D5D5F430413C80C71B3BA22A000163963C0FE7E82B683A8DFBD632946DB5CBBA759FDBB50B6B017105BBCF9559A76DA898524927D00AEEB5C97C2E9E0383C3B65ACC173736691B6C806E5B875392188E36963B8E0E6B8516F14986923562A3824671F4AB11583DF491C308632E728471B7DFE95CD562A728C9C9AB6BF33A278794DDDEDD89B53D4F50D5F545D46EAE196710F923ECFFBA4D99CEDC0EA33EA6A1D274FD39EF2485CBA481372A40A4B919E7B1C7B67A922BA13E169F4FB2FB4DF5C46EA9F3C8B0C6D9C7B7A9ED59314AD6134E2C4883F79FBD11B64EE07804FB1FF001AAA738B8FBAF45A68395352B4692B3EE4FA6E916F6CD0E1E6650372388C919C0EB95EB9DC7F014B2D9C1234125E4B71E480A8AF1AF2493C8C6D18C7CDEA4E29AB7971222A349E6208F6056008C71C018F614C796E4AC3BA470226568F7745206063F0A4E4DBD4B5849AB797F5D884E9DB6DA4699A68A404B6D6858EC519C163D3271DBD0D53B8B5BAF31C25ADC6D5FEF4647CA338278F63F91F4AD192EEE7CB29E7B60B0725BE63B877C9FA74A865BFBE24B34DBD8E0EF650C410319048CF4FCF27D4D526C4E9D64D999F60BC257FD16721B81F21E4F3FE07F2355AEA3649B1E5B298CE0A918239E41F7EB5AC353BD137FAED9800332A85271C727193D31F9FA9AA9262495A590B333B1624F73924FE3CD68A4EE47249EE491EE0300F4C56D68D37D98CB751306B98C15450B9C9C704F38E0E3AD615D42D2A858A42873CF1D45749A269DE7423F76A916EE095E580FF00EBD4BE450729334A9ED5CD422BE7F266869F7B7BA94B133C73086052B2B9949F3A5E3B1E76FAF6E948FE13372FBFED21246EB2244430FC7773F8D6BD8430473B3A909938200FF3FE4D737E29F11F897C3BAE21B148E4D3650A232D0E5437420B7AE6B92329CEA3851B2F5FE98AAA8D0A5CD56EFD3FE058E53C413DE596A971A6C374EB1C0155828DBBCE0649FCFE95A3E1346D4E378175199258651338CFDF42B82A33DB2055E97457BBB9BAD52FECE7324931F31AD98302470480474E2AF599D374B954D8E8376D3B2E55A35CB11EE4F4AEF9D45ECF961BFC8F35539F3F3CFF005344F87A09A06B949142B1C053193E99E86A91D2235242943FF016FF00E2AA68759D6EE2E1EDEC3C3F318CC856433CC0246DDC92071D7A66B4EDF6492159034574A3E681C61BEA3D47B8CD704E7569EED7E0CF5B0B2A557495EFEB25FA9CE6A3A441696924BE5A97084AE370C11CF726B9B8406609EAD8AEDF5E21B4E751D70C39FA571A909560DE9E9D73FE4574539B953527B8A7050AD28C76D3CFA799ABA4D88BE926DC1BCB863DEC00EB9C0033DB9FE55D943125BDB600C606001589E14B97934AB8B64B805164DD2C5B39DACA06E3DC8CFE58F7AD6BDB48E4884516A6E832049098B2D8F66F7F5ACAB4799A8DC2189509CB997A125A289230E632C3AE5549183D3A7B62B7ADE78E14D92C67691F323A71F91AA3A3DE3D9DC490103C92CA9132B9085391DBD0803E86BAA8228AFC312EC50609C3F43D4FE8706B96AD38A9EA613C64E5049C4E3ED2E56796E92383C953236D89FEF6D1C6467BF7AB2B33246CE5E22178F90F18F439E73F4AB5E30B2822B782469DD6F55B6C329E1A5E338DDC0DE0671EBCD71FAB5ECEDA6E04F3DDB2BAABF9A0020646EC003AE2ABD87B469DB76553AB785D3D91D9471B585818B6812C877C87D5BFCF1585AA325D26D9A3FBA72A7382A7D411C835B4B20BBB5668270EC840058101B3F5FE7D2B16746DE5655C3A9C329EC6B2942509DD9D7839C2AA6BA9CFEA92CC96AA939053276CDDFA7423D7DEB9F9800C318C939209EE7FFAD5D2F8830B6801FBA49FE46B9496E3CBC86C107EEB743F5AF4697BD4E2D19D4B46B4D3F2FC8AD6F7125BDC2CF048D1CABCAB035AF2F8A3506B48ECE68A3B8377E62F9A8A23923DB82082B80473D08AE7F71CF279EF4EBA6C47A6393FC7375FF80D75D38293D4F331B36A9A6BB9D768FE2692511F9B0EE448D98A22B36DDA5460FA039CE4FBD775E0ED53FD02E1CEE321DB288C724FA8F73815E63E12BC58E4B958E54076B16F2D40DBF2B6D1EFC85350F86B5EBCD2F5DB4BF8A2134519449226936F964FCB9F7C6E26B1AD868C935139615A4E2AFA9F40CF1D9EB56442C91CD0B1565642328CA72AC3DC1E7F0AE4AD2ED6FEE6F34DD422417D67218E6038CE79575F40473FA55F68ACE178AEED610164EA18E4027A123D2B2FC53147A5C7A7EBF13ED9D408AE23C01E646D96C7B6D3D2BCE51534E9A7ABDBD7FE09D5093A52E664122DE6917606FF00B4DA900C719E0A9CF6F739FA5626B3ADAC42E6EAD211343014DCAEFB599987DD5183923AD68DF78C74982FA1486E5657897CDF917705F407B0AF2F9F5FBDFED3BD37323BDADCDCBDC120E37139E54F41C71F8574E1E84EA46F523FA5CBA98B546A7341EAF7B1D56A97F6DA86929716EE5F76ECA8FBCBF2F391D8D72B7133348428E060007B543A04D37D967566CC5B0B904F7C7FFAE89496C9C64E735D8A92A7EEAD874F12EBA7525BE9F908D27A743FE14EBC23FB3F4D6C7F1CD8F6E56A9ABE3E5CE7D2AFC5A85BA5B5BC735ABCA61672089000C1B1904107D2B5868CC3117A9149771D69712DAE9D3EA410C7E6BF970075C741C9C0EF54E19CDBCA26B9EB300FBBDC1EBEC6B4AFB5687552C678250A4602A48AAAA07603671549A3B0655CC17385FBA0DC038FFC76B4E68F5393D8D55F0AD0F47D1F538E3D32E6DAF75359E76915A1FDE6F28A074071D339AE7FC7BE2BB9974FB4D221BA2633979A65E37AFF000AF3C8EF9FC2B9C12DBC72B4B1C7728E79CACC38FF00C76A58AFE3440AB0C98073F3C81BDFBAD611A34D54F68CDA7EDA50E4513334BDA6530899522707CC1C6E3C1EC7823B6339C9ABB736B14716E56568D142C6A4104E4F61CF23EB4C93EC52124DA3027AED900CFE4B49E6DB4246219BEF6EE650707F15AE9738B39561EA47745B8116DE49E3049D90370474E07154CC80B005B8CD3E4D463C4AC2290BBC663C97040CFD00AA225EE7A565349EC765072826A4307634F4E7AD1450CA8EE2A92BB803C54B1E5B824E28A2A19AC4931F3114AAA3145148B1A1005C8CFAD452F6CFA51455112D881B8FCAA36E338F4A28AA46133FFFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (22, N'Interstellar', N'Christopher Nolan', 169, N'Aventura', N'Narra las aventuras de un grupo de exploradores que hacen uso de un agujero de gusano recientemente descubierto para superar las limitaciones de los viajes espaciales tripulados y vencer las inmensas distancias que tiene un viaje interestelar.', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00E4DBC25E22C2FF00C48AFB1C7FCB03518F097889731AE817E5436E62213C57BEEA1197B3992DE51BE48088D973C315E318F7AA4D63790369B2473BAB4714715D2B0252518F99BD981E87BF20D5D8C39CF21D23C33AB43A8992F7C377B716E558ED681F616C719DBCF5F4AD26F0D4D33C51DDF872431866F3960D3E70CC0BF1B4938521319CE73EC4E6BD4FFB36F12D75110DCBF9F3F168DBCFEEC6D5CE7D3E604F1EB55AFF004FD4E431A585D2C7709E612C1C82EC4823F91FA668B0F9EDD0F1BBDF09EB91DDDC08345D452DDCB2411ADB61B6EEF94FCDFECF18FD6AB43E17BC91BF7FE1AD64146F9B6328CAE30472BC73CE6BD2753D1F5F934D690CEDF69DE248DD58B11C938607B73DB1EE2A36D0F5796E8DC2C826866B7D90AE7698DF2858B7E4DF9D3E5F317B4F238487C217914647FC23FAA79E634D8CF1929BC2FCE76AE0E33CE33F95569FC3DACC72328D1EEC2B3164063E7693C67F0C57677FE16D646951C464669D24958B2B9CB82576F7E30377D33515EF86A78FC43F6C82D239D5A6322D9C9C26D04614F5E3AD1CBE64BAAFB1E7E7C1BE20DF23BE9375F3125498FBD322F0678858EF1A5DDE1DB057CBCE7B71EF5E8769A32D949791C9A65C4F6B35CA8B6670AEF1C787041E7AF2BF5DB5BFE18DB6DE18D32C2E23486F2395F734CBC1CB1EFD7B8A7CA0AA1DD269C50431C592B1807F7C0E738F4E956C09826D64DDC805801F9E29CD32165CB7181DFDAA65F2D88C315F7A96348CB9F4FBCF35DE1CB31428369C051F4A75B69EF6702A4ECED248079CDCE0003EE8F4AD3314D9DD04EA47AD4531B848D9E664DAA325B3C01EA695C7CB63175CF1168BA3227DBE6FDE311B228465FF001C76ACBFF84A747D52EE1D3505C43E7F0BE6C5B564F55F5E6BCE3E216A162BE3D6BC8E481A5B6458E48677C249C7241C601C11CFB533C39E29D36F3C55A60B83690C70BA84F246589CE31C76C53D6E168B8B6DEA7B35DB5B25B3C9244E5506408C649FA5507B1FB32BCF6F19914A870F1FCCC40E9C1F6AD7B46B1D46D37DA4E5A32010D8CE3D0FD38A69B178700160A9808558E31E98A2E43463C705B882E30C42CE7CC60CB860DDC7B11FA565D92B5E5E324B6E76EE1E5312791E99E83AE7A735D64B0B1C97B5674652DB9460FA63FF00AF52DBA4019093C93F78F0453B8B94CC694160036381DFDAAC5B9936BC7BCAEE19049C7D6AABE9ACAF9562DC0FE5572D902FC8E4ED3EB4021260C9B044C77AFCCBCE437D3D2A8EB9AF43676BE46A3208A2BB912DD768CE4BF1C9AD67B32C3E46F9739FA5703E37B65BA867B59238DE2563C93D49FE5FE342B0F5452D6FC0DA45DDA39B9863B8BA58F65B9926319247DD0EC3031DBF0EB59FA2784B41D234F865BAB4857506DC24F2375C119E9CA9CAF1EFDEBB23A7436F2956F9A58E35DACE7705E39C67A7E3CD65C17FF6B98437B628C1DB6878FF00E598C67248E71DB23BD55B426FA935978BE1B2D56EF4CB3B7F2E35890C731E712151C15EBE9C577DA56A097F631DC23AB2B0C1E38DC3AE33EF5E6DA9D922DD25E5BBA33922260131838C823DB191F85767E188E65D2BCAB81B191C9403B035324AC545BB9D1993777C1F6AA9F648A49D588C1DD9E0D29562793CFB52AA1F357A8E454A2DBB9198589007F747F2A4F24A8DC0023D73C5569F576DA3CA8CF200F9987A556967BA44F96409CE4A98C631F5A7A93A1A2CB222310A7819C7AF15C5A326B5ACD9A150327CC65724900727DB1C015D1CD34FB3E6E370208047CBC7715CED8792B76D325DCA5901468F681BBA0CE39C62A96C26C76B16F347A95C4CF34912672AC0820838EC07D7AD644D3C72C27CEBDB99109C6228F19F4E8B5D7EA42E5ACB16E6156EB890160C31EDC835C3FDB87DAA484DBBC132B6268CF4FAFD0D3B89A37B4256BAFB7C573951E4EE11CC41DFB70463D31CFE75B5A25E4316A12C0AD888C7B915416C81D79F5F635CED8DD44BAAE26572AF134781C87047209EC476A974CD76CDF51945ADB2B5CDB215DB19FBA09C60E78CF1435B827B1DDC57B6B29C29704F3878CAFF00314E379025C223B05C9E0B103F4AE7ADFC42CA36DC452A9C92432938FF003F5AA9AA6A11DD222C570E8CCE0ED23A7E7FD2B3E52F9CCE7B3BFB22D1CE8D182010C4F5E3D455D8AEA564C349194C0F98B13FD2B3E7F115B5DDB9B7BA49A41220DACA4291C552D3CADADC2CF11936A9E98C123D2AC83AC8AC894F3636465238DA73501B21E6BCC2D9124DB869030C91D6A4B5BB882F99CA2B7711E0FE383567EDDBC153123E070C4618D218D7966E17E5017A2E3AD70BE2289A0F10ADC7204EA065C6496538FE47F4ADE6B39A7D4259A1BAC468773648217D8E39FC2A2D46D5350F0E33FDA0A5E41BA68D4AF3F4FC450054D20992E42BC642B2F0F9E8C3FC6B6FC93A746CF1C617CC3B9BCB50A58FB91D7AD717E1FD5A59EEE0495E35491D413D31EF5DE4B62F2B349148922919553F303FAD364A293DE47EACA0E71B8EEFCC561DD5E5BACE0490425DBABED3D07F9EB5A175A5EA521256D3AFDDDABC0FFF005D3F4CD0AE86A31B5FDA958CB0CF46FD3A503337FB119DC60C464DA090DD471EB5243A75C295DAA31F9574133C590B210ECC01FBBED4B1BA9211638F3DE8B88CD3637AAC5BCA704F5C73FD6AE442ED6203616E31865E47AE2AF2923EF22B103D2A58EE9471E500C3A8CD03389BC875C9A696EADE2F26DCCBF2BF9889B803DC6327F1CD74682ED612AFB598AE318E09C74AE3F53D57C32DA8CF21D6A6136E2628924F951B9CAE7A75FC457431F893479ACD275BC52A06241F3120FE1D68B858F36B54921BEF2365DB5CEF2A2364C6083C631D6BD7AC279A2D22D9659C46E9128285724103D7BD79C5BEA9B7C42D28B5924854E7CC0C3A03D4007FC2BA57F14DB796D2247336C1F312C0151F8D0DDC4958DB9B5BBC0D8894BA8FF676E6A34D52FE59D4B4400C8C7247F5AE6EEBC58B02EE5542C1F6053281FA5353C42CD2207586262DB9400327DB9A0353A77B78E4D8C72385E07D2A9DF5F4B6572D1C4A988D72323D8FF85145008E664F146AAD6F3C82655652AA0AA01D71CFD79ACBBBD5F5098EE92F263BA4D980D80067D05145494605C6A3731440871B8E32DB4679EBD29B2DEDDF98A86E242BB381C0C741C628A29807DA658A0594393B9DC329E8768E3A735744D214B7998862403865040CF6A28A00AF3EA5711DC907CB93276FCE83F3E3BD5B86E6631C7289087F90E700F5233D734514091FFFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (23, N'Star Wars: La amenza fantasma', N'George Lucas', 131, N'Ciencia_ficcion', N'La Federación de Comercio ha bloqueado el pequeño planeta de Naboo, gobernado por la joven Reina Amidala, como parte de un plan ideado por Sith Darth Sidious, que manteniéndose en el anonimato dirige a los neimoidianos, que están al mando de la Federación. Amidala es convencida por los Jedis Qui-Gon Jinn y su aprendiz, o padawan, Obi-Wan Kenobi a viajar hasta Coruscant, capital de la República y sede del Consejo Jedi para intentar mediar esta amenaza. Pero esquivando el bloqueo, la nave real resulta dañada, obligando a la tripulación a aterrizar en el desértico y remoto planeta de Tatooine...', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F01C52E29E169DB6AD405722C574BE1EF05DD78874DB9D452F6D2D6D6DDB6C8F313C6064920038183D693C2D05A36A713C8E1EE83308AD9ED8CC92FC8700807AE703F5AF43B3D5352B38B504B1D362B30D33DAC7343A43FEF3E5C2E7E6E18B10A010719CD3E50B9CA3FC33116990EA52F8AB438ECA762B14ED23EC761D403B793C547A97C30D5F4CF0D3EB32DCDA398EDE3B996D10B79A91B9C024631FFEA35D11D1B52BBF0B5A684B6B73776DA1DEB48C23D325CEE281C890EEE996208001C60F7ADDFF008497C51E244B8BDB181353D36F98D8CF143A337971C3B70CC24077315C9F949EF9A7CA2B9C1FFC2ADD44C76D8D4ACBCDB9844D146564E4119E4EDC0EB5C43C4D1CAF1B63723156C1CF22BD993C41A9497CBA54574C5ACEDD2DE4B36D2A5F9903EDDEE3395608037A1CE3DEB99D734C86E6F2DFED30456772142A5BC366615914B36E6E7D30BF5DDED550A7CD2B214A7CAAECF3DDB8ED49B6BBEF1C783E3F0CDE476CB2894B4292EE031F786715C3B260D39D1E5142A2921D0279926D03B558F236C6E4F5029BA69DB7F193D3073F955B9B1F669BD4B2D7650A69D3727E66739352B19F6F752D9DE437309C490C81D0FB839AF5DB3F8B1A5477209B6B81108F760A0DC64CF4EBD3DEBC8961663D2BD0743D67C250F86934CD574F9639C96F3654B512B3671CA1DC307031F30201E47535CFEC9B5766A9ABD8E9B47F88B068B69A7A1B0BF96617125D5E389150349213BB239DE006E0123EE8ACFB1F883A1691A15CE971E9375736ADAA3DD2432808163620F0437DE5EDD8D7357045DEA0174CB1BBB6D38038FB4FDEC7383FC875E6B0752867B6B878F746DCE72873DABA3D842D71C924AE8F406F1FF87FFB76EF5957D5DA7BB411CB1BAC7B36AFDD00039E3EB5C859DFFF00686BCF3A997C96909892590B98D49E1726B06DE10D3832C4F20CF4519CD745630ECD5A33F6296D771185742A3E833FE34E85349DD1CD5E5EE34769F198EDD7A31FF4E90FFE835E4AC39AF5BF8CE33E228C7FD3AC3FFA0D7953AF342873417A0A9BB37EA45660FDAE3C7738AE82CB479AF0EC55272C2B234E8F377193D9857BEFC33F0FDBCA66BD9950F938F2C3742E7A67D718AD69B54E8B9488AAE52A8A11DD9E55A969969A0CBF649E2967BF00168231F73232371FE950DBF8AAE3498BC88B41B64761C493EE2E3E9E95EA9E295B6B7BC996DC4614FCCCC898C9FEB5E7F756DF696DA632D96EA6942A7B45A6874FB054D5DEE5FF000F6B9A7EAF3A5B6A48F6723118958EE8DBEA7031F88C5686BBE038CDE3BDA46D8C0EDC118ED567C35E15479159D46D3D4115ECDA76976E9A62C2D83B570BBBAE3D2B09D574DEBA97F12B1F3F69FE15B4FB508AF91F9256355C8E7DFEB9C57A6E87A158DF68C91A65E207CA6460481C70467A107BD59D56CA0B5B95313AA32C81C6781C722BA3D22354B5661B4B48DBD8A9C839A5ED5D9B4658849C123CBFE3168924DABADCA292A2045CFD05789CA8636642BCD7D55E3C8A07B490CA07DC1C9AF9AF568A21792854279CEE07A0FA57461DF3D348C2F69BF528588DB30AF60F0D7892E6C3C39A82DA88942C0D2F9CFF00795F854C0FC4D790C4A41C8AEDFC3826BED3E7D2E3992017186794C7B9B0B92140C8EA4FF2AD2AD3BD1711C24A35A3261656DE22D756E1A5BB94DD0914AABB7CACA7393E981C574F61A1ADA3F973DC096403920719AC6D15AEF49D4E6B1944923B1C031A10A476217B574B25C8D2B4B9F51768C3A2B15790656303AB91DF04800776603D6B0A6F9637E874D66EF646ADAEADA5E96C21B89F171E63462141B9FE56C6E23F847B9C54779F1123D3EF2395620D04ABF203260E17A1F4E6B9AB1F0BDDEB36B16B710DF25EBABDF3DC3AAC9022C6986901EAA7E627181FA572FE28B885B5CF9AEBED16E245F2E445C0201EC3A62B28B8CDBB8D4794F54BEF17687A9DD471DECF169AB80D21B861B99F1C463D3A8C9EDD2B72C273A7009BF745FC1CE463B7E18AF9E95A1BB9E0B8D6609469F7A3635DAFDE824762DBC7F780CF23D2B67C31E2EBEF06F8825F0B6BD279D630CE60126726039E194F743D71DB39154E314ADD0CAA2725A1E91F1175F956E1E288FC85071F8578A5F159EE1E5652ACC79DA3806BD8BC556C934D9DBBDB72AE3D8F19CD7253E95657179710359CB6EC92EC60546D5E9D0FA1FEB5DB87518C12399DEED9C3470127815D4787192D352B5927DC20122972BD76E79A6DAE9C4C13EC8D4CDB54C259B0A0FF0016EE3A63A62BB9D13C2C97D7322080451300612D28663C73E95A54AB18A772145C87DF4CF71E20B8934EB5B748A56DC24888C37BE49CE4D4FE29D12ECF82EEE08A1596EA0D93B43BB3BFCB903943F519FF00BE6AF7F63A69170A7EFB29C8D833935AF67E508A59261BE390624694E131EF5E7C94796D1D8E9F69272BC8E4D75BD3BC4BA06AF1E996ACBAA5F58C6F0AE09611921254C0EA15939F6706B89F1D9B192EADACB47B18A191954BC71A104BE318C738E7F9D7A15FE8FE1F5F33FB1609D6F522616F3DB48EBE53124B60F5C1CD62DAE81756C8B7AD6C1B52D9B565316047C60B7FB4DEE6B3A546CEE6B2AAAC72174D67A8DAE99A3DEEA16B63A5E92812E5589F3A771CB6D00773C5721A93DE78C7C5F34D6B6A44F7D3E238907DD1D07E000E4D7A758786ECED2597FB63488F53499F7BC8CCCB2AB7AAB03C83DC1FD2BAEB2D3ADAD6C6593C3FA4C10C6003218FE4948EFC9049FA6715B4E1756E864AAA5B14B5B95E2B730A3923CB11B7A3E0639AF38BDB7D436B4ECB3BDBBBF572705871C7AF502BD6ED2D1753B39AEC1BA8D40DA1E7452A5B9FBBCE0E3B8ACA9B4CB89258E46BAB29C8558CA798536007F878C1CE727DEBA29CF9744636B2D59C9BAB4FA65D5BC4712CB0346BCF72B8152D9E95A9DE58C70DF6A2B6F1C080450C4A19F21368CC808239EC3354619F663072715A42E254B679151A4DA32C01C7EA7A56B56926EECCA9D46B443744835CD4BC2DA6C371B225B3C2B4D307132E1986D420F718CE7DBDABB9D37ED77930B5327EE18EE6C9E00F7F4AF2F3E3EBCB29C2CFA53AC592BBD64DE18EDC800E31DC7E06B5ACFC677D2EA7690DF584A9A45E93848E201E742ACA4647B91DFA0E6B91A49591D2E336EEF43A6D63C53E5EB0BA6E8ECA96A8DE5B4B11E5FB673F5F4AECBC3F25B0B626E2EC19906D659A5DCAC3DF27F5AF0AB0D07559F5DFB349677A7CB6D927EEDB8C7032471D00E7DEBD2B4CD13558111134D3845C62E14326727A1E0E318A89C6EAD7B17A24771A8693097F36355F2C8CE7B0AC6BA810DAC8905D20475DA70DB0E2B66CF52B86B14B4BBB568832B0DE79C60F03F2EFED5C56B5A4C2A93F913CD3B6E3B40055549FE2CF7E7B63BD2A57DA46534AF7456D5A4D56CEDA2495585A463647B3EE0FCB8CD63457A5DC7CD839E86B3759BDBEFECF6B54D46FA1B877FDEA85E0A85F95401D3900727BF4E2A2B292D96C8AB5C4AF303C2CAC4B0E7DC576D3EC63356D482CA1592550C4D7A168BA4DAB20660C78F5E28A2B6ABB1CC8C5D43C39A6C5A8DD1113346D209042CD94438EC3B75AD3D3A46DCB10C2A28DAA00FBA3DA8A2B9D247636F951D1C717953C31ACB2052809E719E6BA68608CC2095078EFCD14572E23A0E9EE666AD6CB1B9F2DDD1594128A78AE4EF659622DB657E3DE8A2B4A3AC5113DD997AC46B2CD6A5BAB2E49F5AC97B485A660C81B0D8E40F5A28AE886C267FFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (24, N'Matrix', N'Hermanas Wachowskii', 138, N'Ciencia_ficcion', N'Thomas Anderson lleva una doble vida: por el día es programador en una importante empresa de software, y por la noche un hacker informático llamado Neo. Su vida no volverá a ser igual cuando unos misteriosos personajes le inviten a descubrir la respuesta a la pregunta que no le deja dormir: ¿qué es Matrix?', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F74BED42D34CB56B9BD9D208107CD23F41F53DAA659A3785664911A265DC1C10548EB9CFA56578AA19AE7C27AB5B5B46F24F3DA49146A8BB896652071F5358BA7786752D2E59F4849525F0CE04D0C3BBF7AA4FDEB719FF009679F9B39E876F4A4909B675CB2A491ABC6E8E8C32ACA41047AE69F9FA563DADADD597876CADA3B5437690C713636E2338009E7AE39E3BD53B4D1AE34AF11FDB6CD5A5B5BA8765CA860BB5D7EEBE09E49E41E9EB4AC2BB36E7D4ACAD439B8BB82211FDF2EE06DFAFA5490DDC13B32C52A3B280481D403D0D64789AD27D4BC3F77636D68ED2DCE1792A067239639E981D7DAB5A25944485D82B85008C038FC68E83BBB8E8EE6095CA47344EC064AAB0271EB4CFB75A7DA1ADC5CC46751968C30DC07A91D6B1ED6DB51B2BBB59DEDFED31083C82AA555EDFA67D9D4951DF23DE9F6B6D74BE2FBDBE6B574B69AD6289242579652C4E4673DC53B0AECD44D42CE5BB6B58EEA16B851B9A20C3781EA475C53E1BBB7B892448668E468DB6C814E4A9F43E86B0755D32E757BC8EF6D43D85E58366099D7FD7FAAB60E761E98EBDFEBA7A34B3496282E34E7B1987DF899830CF72181E73EA79F5A765604DDCBEAC1C647A0E3D296B226BDB9B52BE5C5E7A901557F889C727E957AD2EFED3182F0BC3263947C67F4EB517B8EE59A6C8EB144F23676A02C703D293CD512046F949FBB9EF591E2D89E6F096A8B1DCC96CC2DD984D1361931CE47E5D3BD35A83D89AEF5A5B1B07BFB981D2DA35DEF9FBC07D2AF5ADD417B670DD5B48B2413A092371D1948C835F3F5CEBB6FA6241A8DA5CDFB4F1858FEC73DC3B40F818F39CE06493C94E95E97E11F14580F013EAC66B89EDAC6396599A48F690C09F95074DA07031DB14DC5A44C6576779487DBAD79769FE3EF1B6A368B7F65E0D8DEC1D4B45BAE02BB2F2430C904E7E82BB3F0AF88A3F14E8B16AD1DBC96ECCCF0B412758DD4E181FC4527A14A48DFAAD35E2452AC7D5B2062AAEA5ABDBD8C890190999C80551773283C0E3D49E053B4FB32585DDCC02398E76C64E760CF527BB1EFE9482FAD8B13DA24934528055D0F0CBE98E45606ADE19BFB8D49B52D275D9EC2E1CA97478C488D8180307A0FF001A87C7FAE6BDA1E911CDA069EF733025E6610F98B1C6A327BF5FC0F7AF3DF09F8D7C5BE34F16E98D25E4169A6433032848F6249F293E5F272EC403D3A727B5528F525B57B1EB76CD7767A1B4FE20BAB433421DE59ED90A22A0C907072720579E788751D47E22DA359E8C254F0FA02D7173191BAE194644617A93D38F719F6E9FE26CF35AF81EF56D61124D3B247B48C82B9CB67DB008FC6BC6F46BDB916E57ED5AA594C5B317D91D5563001C8C63F8BFBDDB19AB8C5DB991337AD8E46E651757F25B430DF37944AA477721CA11D7703D3E9ED5D647E26BD3E178742698241791085E3850720B60F3E98049C7B55CF887069461B7D46083171791AF9F319039DE98071C72C4632DDF35C59D41E7D4229A159238634588631B82018217B0279FCEAD7BCB533BF63D2746BBB8B7D321B3B0F105CC12CA98B585ADA3916DB0FC2312016DC381E99AF58D074E7F0D7866D6CDA392E2EB24CA63519795D8B331EC0649C9AF9CF49F12AD84B32DEADDCD6CCA49B48E5088588C0624F4C7B57A4782FC7979A3E83696FE22B896EED6753F66BC560EE140FBA7FBD8F5EB53283E85464A3B9EAB058429702E6548DEEF9F9F6F2B9EB8ABA3AD73DA57892DF5EB7927F0ECB6B7B0C442CAACEC92236338208EFC7EB5AF0CF7194134257239C0E86B2DB7364D74279504B1BC6CB9575DA47A8239AF08D7FE1A78B7449DCF8753EDDA75ABB4D6C0CA1670F229562A38FBBEC41EF5EF468A6A560714F73E43D5F5FF0017421F4DF10DD6AA508C1B6BDDC037E07A8FA567C9769770C324B3234A0ED1188F6B201C004E30722BD17E3BEA2D75E274B00015B38236CE3905B7123F22B5E4D1920EEE78AD519D8DDD635C6BAD3AC34E52E61B18D9577F7763963FA0154E1BF48E1098C923AE6B324C8C027A804D1CED1F4A698B95589EE2512CBD7E51DBDEADD8DDDC47FBB86674DA19D141E0363A81D3B565E79A7AB95F981E945C6D6963D83E046A2D1F8A2FACD64062BBB5F3194F043A91DBE84D7D0008C8F7AF8C341D5EEBC3FAE5A6A10131DC5ACA1D49254903AA9F623239F5AFB22C2F60D4AC2DAFAD9C3C1711ACB1B039C82322B39AD6E5C7B13BA871839C7D68000000ED4A681D6B328F98FE285EC1A878FB5858CE4ACA2DDC9EC51141C7E22BCEE15258A9E3D7FAD777E22D2669BC61756D1666BAB9BB9A5662A5554B487824F651D4D739A969A9A24FA8595D4B1CD78932C61E1C942A46E2CA4E0FB74AE8EC629EE61BB6F90B1E01357112DB056591D0852402BC9E381F8D53552D205504E4F0054B2CC646E40CED0339F418A48A644DD78A58F0C71D47A52025595863208233D2BB6F126AF69E20820BD3A6C71DC2A6D96489151B2074C0C647E140363BE2858436BE29B6D56C540D3F54B286E6DD9071C20561F5181F9D7B37C1AD7AE35BF08B4370B086B190448F12ECDCA79195E80F5E4706B89D37C3ADE2DF8233DB20336A5A45D4B259AAF2C060398FE8431E3D40F4ADAF82DA7EAFA05C5E596A096E905D0DC882E14C88E9D415F4233C8C8E2A5DAD60BEA8F62A8A797CB4F948DC4F02AA5D5DB0BE821470A8CACD8FEFE31FA0CD65DEEA25E3B9531B3476FF003178C839EFC81CF158B7A94E47927C64B982C35BB5B8B640BF6F87CC620ED390704FE381FCEBCC6FE091E2CC8FB4C63259DB259BA919FA7EB5DEFC49D567D635DD3EF5142DB476FB0A46381B4963D7D722B81BEF3AFE650642CEA32E1DBE6DDEC3FA56EAF6D485BDCCC89990B3A9C1C6338A6C8FBCE4800F7C54B244F6E648A55DAC8DF303FA5406994256A5BDC4E20D8AFF00BB2010300E0E31F8565D4F6A58DC2C6AA58B9DA00EB93E940347B47C04D5F17BAC6952CDFEBA35BA404F52BF2B7E857F2AF5DD3346B65D48EAF2ABBDE344218FCC0008231FC283B67B92727F4AF01F052CBA3F88B4DD544602C528598ED285A3236B12A7D0678F615F485A5EDA5FA092D6E23997AE51B359C934EE116999C2C229AEE0DCD2068A0608C1B91838FD41E7E82B97D4DCDBF85F52962F92496E02BB2F0486201A28ACD6E8896C702BA65BCBAAC8ADBF11DA9947CDD5874CD605F69B669ABEAB2FD9D0FF00675B2CD0291C6F601B737738278E714515D2C889C2DE4D25D2432C872C411C74001AA78A28A93640455DD2541D52DC7FB74514D03D8F528F73F904C8C0E3248EF5D6477B3D8DC699736EFB242819B1D1B9C73EC68A286627FFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (25, N'El club de la pelea', N'David Fincher', 139, N'Drama', N'Un joven sin ilusiones lucha contra su insomnio, consecuencia quizás de su hastío por su gris y rutinaria vida. En un viaje en avión conoce a Tyler Durden, un carismático vendedor de jabón que sostiene una filosofía muy particular: el perfeccionismo es cosa de gentes débiles; en cambio, la autodestrucción es lo único que hace que realmente la vida merezca la pena. Ambos deciden entonces formar un club secreto de lucha donde descargar sus frustaciones y su ira que tendrá un éxito arrollador.', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F9FE8A2BD6BC21F076DBC49E194D4A4D5A55B89B21238A31B633DB76EE5BF0C7B66A275230B73752E14E53D8F25A2BD534FF00819ACDCE98F7377A9DA59CD96D90BAB30E0E01661F773F8D61DAFC24F17DD5A4970B6112052424724EAAF263FBA33F96719A9F6F4FB8DD29AE870F455DBAD1F53B288CB75A75DC11838DF242CAB9CE3A918EB54AB44D3D8CC28A28A601451450069683A4CDADEB56D610A93E637CE47F0A0E59BF019AFA2BCD49208ECCDB8F25556354899A33B40C019520D63F84FC0E3C21E158A7BA1FF138D470660307CB8FA88FF913EFF4ADD82D99650B9DAFB7E763D133D00FF6B1FCE9D151AB16E4B4E9FE67BD97D28D3A4E6F764FFF0009588D069F3687A908E1408658A312A14031B81072477F5E2A7D4FC41A43E93E569D3C970481986D6326455CF3C11C6066ABC3B9B2EAC1519C1CEE232A07007A7033EC0530CC615DEC5B20066DAC33B8F407D3B0E7D3EB58CF0106F7F2F91B2A51E64D2FC7FCEE4F3EAC9E21D365B1D06CEE2E0B2847FB6A1489477DDBBEF71D866BC43C55F0B35FF0DC13EA33476F2D82C83735B396318638195201C6481DEBDA3CF960463267CDFBC57183CF4F4E33F9015C6F8EF56BC9B4EB7B0779A582673E7052708A3A138ED9C0E69AC346845CD331C56154A9B92DA3F37F79E2BF666C9CA9007DE27B5594D2276E36F3C671D45742B669776D1C1671B4D337F7C6DC1F7FA01C63B93566DBC2FE20B89043140C108C9F976EE1EB584B1318EEEDEA7931A3296CAE71B25A38CECF9F1C9C7A556AF47D57467D151229A22A244C97C75F5AF3DB987C89D93B03C1F6ABA1885595D194E0E2ECCFA87528B57D52D6C9F4CBF823920EA248CB06E0707D2B0EEEE7C5F62ED1DC69D0DD230209B56C139EF838E6B5AC6EF56B4BCF2EE34F29B80CC9136F5E9D71D47E55B0FE208A06CDC44411F7B1D87AFD2BC5C363274A2A3CFF00A9F44DCA12F75268E720BED5CC6B35DE87782151B4A46075F523BF3DBD85357C436266449CDC4170A0B84B9848CC9FDE3EBC7F9E6BB58B5CB4281D64478C8E181047E750DD6B5A711B9D63771D015C9AF4A39924AEE49FC888D7937AD3FB8E6DA68E4B52968FBFCD6CC8C063383FC8F61E80FAD64E9D7B6F7BFDA968F6CCF386DA776143463B027B673D2BA19356D1642D35D4102499E3E4DA48FA8AD08637D7ADA3486C63B4B15FB92C899247FB0A7F99FD6B0C5E3562297B38A36759C6369474F3FEB519A2E83A040A977676289301F3063B8A9357AEADD5A4578A1DA0719C55AB0D32C74889961F9779DCEECD9663EA6B235FF1DE83A03AC13BBCD336488E05DC6B82A61A13872CDABFDEFF00CCE0F68D4AF0BB46378BBC3EFAD68E638A3065439191F9D7816B3A3496E933B0F29ADF0A51872DCE3F0C57D096BE2F9759309B1D1EE92094E44D2C4C148E9D7B563F8CB44B35D27C41A95CA8CC9605B07A07038FC738C7D6B97078A960AAFB196A9BD3BEFB19E228FB48F39DDDD2B6F4391800673E98AC3D5A02CBB210824393973D0574177F348140EC327F0AF34D4EF2E359BD9D219596DDDCC6083FC038FD4E6AA74F9A76468AA2A707396C8E135BD424D37599174B9E48A12E558A312A48196C0E95D7E83E1AD475CB28EEE5F104E16400A8450401FCEAB6B5E1F8A0B7B79420548A298F4C9E831FD6ACF837C493595EE9BA44FA5341F6F3B6073364FF00BCC98C815D55A529D34A8AD56FB7EA6586C44AAFBD27BFA9D35AE9379A64B7D6B1C70CD3A32C96F34880E548E7AFB8FD6B16FF0042F166AEC0DEEA973691EFE22833212BEED9001FC315DA2BEAF7B74C2EB4C8EDC5BE424CB2E4BAFD3B8352D95C0B96D93C98C1AF32539D2ACEC96BDD1D76E65EF181E19D0B53D2B508E5D435BBABCB424C66DA600ED07A1C8F4AD95F07E916FA94D7705BA4576D213E77F173D81EC3DAA7D72F9F43B34BDB6D32E2FD55B6B45063701D7773D6B2E0F15EA3E23BF8EDF4AD27ECD0E01B89AF558151DC2AF73EFD2BB634EF06EA3D6FD34BAF907BF27CD0D8E845AB5B40C16362DDCB36735E51F1896F2E3C330CF1C8E2186E82CE8A70A411F2923BE08FD6BD86F1963B72A188E38DC79AE1FC476916A1A2DEE9F2F2B3C7B4FB1CF07EB9C562DC6862E9B8F42141D6A524F766FF00886F4DA69970C87F78630898F52315CAE9366896F1F19C8E327A7A553F1A6BE228923571E63B00067BE302934CD4A1B34B7B4BDBDB58EE8A0DB13BE19F8F43D33EF8AD2119BA7CFDCF3B316D4234A2AF7D4EB5AC23BBB196DDD1583A95E7B6462BCB61BDD52D7E2159B5FB665B3223884A9901573EE3DF9ADED67C7F7BA2DD7911D85B98DE3DE923BB743C64638383F5AE3341BFD567D6E37B49D45D2073BD981620F2C083D73D6AF0B87A908CA6FAA1E16328B517B1EFD6D25D493ACC266114A98681B070DD9948E99EE2B8293C4AB67A9B59EA7E5C32EE2D148ADF24A849C60FE98F6AEA6D3C4115BE916F7571229964C2067F9515CFF79BA28F527F9D71FF001034AB35D3E287CB4924841CB63E6CB12C4FB0249AE6A71F6F26EB2F2FF8637C4D59509270DFB775FD6C7452789276B5F2ED9EDB701D66C918FA023F9D73D2EAD33BEC9B58D4E5909E6DACA010AB1FF79416C7E35E7B1DF5FE8EF0C36EE659445E7C9048BB9638C91B727B13D7D3915D5E91F1361482482EED228EE00FDDEC5D809F7FFEB574BC356A2B9A9AE6FEBCCEAA38B85B58D9F53B5B083ECB602678E48DF04BC970C4B63DC924FEB59935FADDC85E36F918ED4F71EBF8D71BAE78CAE3596DAEFE5DA8FE15CF356B4CD484A632DC0C803E959D3C254D6A54DCE8A75B9E57672BADEA725FDDADE072A20C329CFF0010E98AAD0E83A9F889D6F07CAB70D9334EE30C7EBD735853DD1940407083A0AB9A2EBF269AB2DA4ACCF67303B93FBA7D47BD7BAA8CE10FDDEE8F2AB4DDAEB73A483C15365AD2EB5351B46638F07637F786EFE13F8551D7350BCD1F56F2A22EB7D1C518133AAF98BB7EE90CBC302B81923381CF4A8EE3C5D2C712A865B89428D929EE3A7CC3D7FC6B15B549AF2667BA6F364DA154B0E807403DAA6953AB7E6A9AA32A579CAD23D574BB3D3F55B592F75065293C68F7313B650E3D3B05E33F5AC4D4B58804EF04375712E9F12759886758D7F803637107A0C92466B8C4BC3146CB11D9B861B6F00FB546CD25C42D10242B101CFB6471F99FD2A21867CD793D3F23B614E1453AB2D59D9782EDA7BD3A8EA77982BA946C8ABEAA09C8FA0C0FC85615DD9149DA365DB22310091D715D15BEB11DB1B6011032465320E368C7000E9D29CD7D05E23DACC89873B91BD0D6B5AABE5DB6FC8F99C25797D66539FDBFD36387B8695488CF186C9CD6BE9D7375318A0872093C1157AF6C2DDD4640C8EA7D6934D78AC80087273F78D14E51A8BC8F5315987B0A778ABC9EC8E1C75A4B88C4772C8A4E300D145762DCBABB21B8001A8D2568CE54F3F4A28AA4449D9AB1A50B196342F839A9202490B938DC3F9FFF005A8A2B07B9D9575A0FD0D3946C82393712F83C9A125728ADB8E7AD1454FD93E627A3D0B1773C86DA33BBEF75AAFBD8700E39028A2B2A692A6BD4BADACF5FEB43FFD9)
GO
INSERT [dbo].[PELICULA] ([id], [titulo], [director], [duracion], [genero], [descripcion], [imagen]) VALUES (26, N'Origen', N'Christopher Nolan', 148, N'Ciencia_ficcion', N'Dom Cobb es un ladrón hábil, el mejor de todos, especializado en el peligroso arte de extracción: el robo de secretos valiosos desde las profundidades del subconsciente durante el estado de sueño cuando la mente está más vulnerable. Esta habilidad excepcional de Cobb le ha hecho un jugador codiciado en el traicionero nuevo mundo de espionaje corporativo, pero al mismo tiempo, le ha convertido en un fugitivo internacional y ha tenido que sacrificar todo que le importaba. Ahora a Cobb se le ofrece una oportunidad para redimirse. Con un último trabajo podría recuperar su vida anterior, pero solamente si logra lo imposible.', 0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC00011080064005003012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00F15B9CEC51BB7607F08A7C65D02B28C9231C8AB1A9AAF98A167598607CD1AE0559D3ADE09750B64B8E622DCE7807D335A4BDDBBEC73D28FB59469AD399DB5F333CA651D7D455368805273D0576D0A5C4D733437D691A5A0073FBB0A107621A9B6D0B7D934D8A29A088B86CACB007320DDEB8F4AE69D74BA1EB51CADCDE92B7AAB3BA696CDAD35D1DFBAB5CE1B6FA8A6F4AEC248AD24B4BB260F2203A8A290CB828BDFE9563ECF7335FDC58F9296D6B8222C5A0742B83F36FEC6A1D64BA171CAE4DD94AF7ECBD7BB565A6FF0081C3EEE7AE2A40927F935D8C2BB348D3CC4251BA33931592CDBB9EE4F4A624704BA3C51DE47B1E7B89409B60531B678C8F4EC45355AFD3A84B2C697C56D2FAEDD34BDFCF7691CA206E73F4A8661F33F1D0D74FAE5A3433DB47B5015B640C54704838CD615C43F3C9C56D17CD152479D5E9FB0AF2A4F746C6A97325E5DACD2F968EC14111A05030319C54DF652594609FA538865BA8235D8378180CB9EB5D0DBDBC324CA88E4F6231DEBAE313CAA93B2463885CE9D319662141C2EF63807B7157B53D2A47D3219E065CA6EDFB72001807A7635A377A729D21C142C19F1C75E71C55C7B6BB9F47BE2C854ACA578E7E41C1CFD28692D01549CB5B9C0F96F2821CC8C198672C4E4D392DE428B199A4F248C942E7681F4AE8AD2C62568F746CFF00BC5EA7AF279AB169A68BABAB640A91C6A499778C864C9CD472237F6F3BEE730C0C70158EE5C05E811CAE3D80A8FC98E455125C4838DC54F383CF35DF5E68BA4C9916D2D9242D0F25B3BC119E571DFA573BA9C315AE8F025B664DCCC1A4DBEF4D416F62255A6FDDBB3999272B295472C36ED05F9206474ACE99E4DCF9DD96ED56A522399CB020ED239A86E49F311F1C95041CF06B0933A23DCDC82D317512EECFCEB939F715E816F0B1BC5FDEA818FBB8E6B9AF354DC33794AA721828030BC0E056DE9CED3DCEE479F18C67B838AED8248F36ACDCAC6B5E59BB5B46415D8CEAA09E839E735A89A40BDF0BDD8B6754293492E31BB2413C0FA9ACF96DE432AC770DBE2077A99173823BF1D6B7ACEDE13A2C36D6F32B4AACCCC81B9C93C11EDFFD6A99974B7399B1D1A693C9C4647EF13391F8D3A7D22F2D6D525B20AF70CAEA55C7CA0679FAD76567A1DDE21DA1CFEF149393C702AEC7A5BC70C524BF2F97BF713DAA1B573754DD8E3D3C3F786146924877BC462F9223E8727E82B89D6268BCB8E0855C1B66752CBC861EE3F3E7D2BD46DA586EADAEDED53CC924595036E6C8049FE1C81D315E61AB6917914D7620B49FF740F2BCB263192475C73D7A734D79994E3AAB1C55C32BCE44A7E5E483D7AF6AAB3EE8EE1BCA24C632632C3AAFD2AFB5A4A922968A4DB920B2F3F36338FCB3FAD4BAD6910D9F96D0990878D1C06E78239C7B6738AC1C5BD4E98CD2B23A7D274B7BABB09B7A26EE7DABAFD1AC8C93C13D944CE232B0DC29425519B1D180C74CF1CF6ABD1E9E9A2E9D757F3AC4A628CB172739E3E5503DCFBF7AA7E11D4E7D5756B5693E489723601850DC96E3D73D6B79E9B195085D3E645ED7D85B3BC24AC67CF2239154121475057A11C7D79A9FC3F358EB972D2E9ACCEA1F6B9D843E7B7CBE9581F15F557B7D4F4BB38ADF6C31C524B248576AC8CFF28507D4004FE35BDF05EC6D934BBFB99611279CEA15D90EDE339001E320F7EBCD45DAD4D7922DA89B9E38BBB0D33C292CFA8C8A8913AC682443991987200F500139FAD3FC3BAE586ADE16D3A0B0BA9242B1EC963B8399979EE3AB606307DAB94F8C9AC2C5E29F0D69AB6F0CB0DA235F3DB91F2BB6EDA8187A7CA4E3B826B95F0BEB007C48B2BC70634372A876F070E0A13C7A939A851BEA6B39F2B513D47C4773A4E913309D9F3343F304755548D70BB82918CE4FE9583E28D45A59ED6DAD9A24BA9676713BB87954050A02E7EEAB739FCB15CD78DE0997C5B7C2F6095AD517ECD04B71CE542839DDEB9E6B3758B4BAB9D2743D462124B2DDDBFD9C82492664765DA3FF001D3F88A22C270B12EB56705A68B19BA48A2FB206692550048C49C283DD81CE31D0565DC9B3D4B4CB79ADC4B3BA6232FE69FDD6DC6D5C63D3D6B37C6DABCF2EBB7D6F0B1555B891480D9E84AE3E8307F3AD9F861A7893FB58DC5B9BAB3FB3A39915CA88A6EA17DCEDCE7F0AD2E94AC73CA9B70BF54745A85BDDEB1F6380DC5CB23CC12458FEE6D2392DDB80322B37C2826D33E21FF673CE7CB8659157200DC36923E99C8CD6A45ABB46AA6E25023400850B855E3AE0715CBDDEB16F77E398EF2CDD58A9894BA9FBCC33FD38AD6A2D6E45093B5BB1DA7C51115C691A5CCCA1D20D4137AE320AB70463F0ABDE18D423F08EA1E26D21F2D15B29D46CE21C978883C28EB90405AC9D42DECB5428D78B24BB1832012B00A47420038CD3D4491EA116A4B3BC97512144776F9829E48F4352E05C6AAB9C8F8BE1D60F8E5B52D7A2114F7B6F1BC4A8C5923F9798C13FDDE98AB9E04D3DF51F1859BAC5BA28275966624602A73FCC8A3E215F5CEAB6165732A81F649487F757C0CFE6055BF86BAB8B4D23508971B8DCAB13EA0A8FF0350A2D7BA68DC5FBE741E3ED0E0F13F8D2C6D2599A31F60918BA9E54863B7F0DC467DAB3747D76DC58785E3BF0562B5D42696F26DA594B200AA78FA0FCB356758BA99F5EB0D5218CBAC704B0CBB4F201C15C7AF22B03C3D7F3697A57F67DE4250A48EDBF390FB8E7EA0D5F25F4666EA5AED1C2EBB11B5F10DFC4AE268C132A947DC181E4127BF5AF70F0AC1068FE0CD3608C44B3CF18B99CA8037BBF393F4181F8578F78BC0FED75BBB50823B880C6C14771D7F4C5757A5EAB2DC6916332CADFEA94153D0638FCB8A2115CCD31D59BF669AEA1E7EF0780781C1155CE9B6CCFE63DB47BBAEEDB5047201DE9C2498E4094633C0C55377314ADB16489A2C08647FA139A996F6E97E5939154E2170CFF00338231E94B22DD719756CFB5171A349EE6CE6D3EE63BFD8613049BB71FF64E3F5C572DE0A9445677133CE0EE9026DC0E0A8EBEBCE6B66DB4E93519CC53C10CAA8858091030AA0FA1C7FD9315CC3108984851D978CD63295AA1BC52F66D1D3477D1BAF0E1BE9515C08E5C82A08ED5CA2DADE27292671EA6A659B534EBCFE15BF318382E8C875CD2AF2F1B6C09088D1B72F2493EC7B545A7FF006959DB245E5481509EAA077F4ABEB757BD1B20771B6A7372F819EBEF53657B97CCD2E5640B18E393D054C91827A9EB451422597224183C9E9532A0CB724628A2992CD7F0EC4AF75744939107F5AA50C4ADE13B9273F2CBC7E6B4515C157F8AFD627753FE12F49188BC64E7AD5B58C73C9E28A2BD0470B18E831D4D53950038E68A293047FFD9)
GO
SET IDENTITY_INSERT [dbo].[PELICULA] OFF
GO
SET IDENTITY_INSERT [dbo].[PERMISOS] ON 
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (3, N'Administrador', NULL)
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (4, N'Taquillero', NULL)
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (7, N'Limpiador', NULL)
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1006, N'Gerente de cine', NULL)
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1007, N'Supervisor de salas', NULL)
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1008, N'Operador de proyeccion', NULL)
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1009, N'Usuario', NULL)
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1010, N'Cliente', NULL)
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1011, N'Control de acceso', NULL)
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1013, N'ReservarEntradas', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1014, N'GestionarPermisosDeUsuarios', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1015, N'GestionarPermisos', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1016, N'ABMUsuarios', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1017, N'ABMPeliculas', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1018, N'ABMCines', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1019, N'PagarEntradas', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1020, N'EmitirEntradas', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1021, N'MarcarEntradas', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1022, N'GestionarCines', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1023, N'ABMSalas', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1024, N'ABMFunciones', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1025, N'ABMIdiomas', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1026, N'GestionarBitacoraEventos', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1027, N'GestionarBackup', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1028, N'GestionarBitacoraCambios', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1029, N'GestionarReportes', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1030, N'VentaGolosinas', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1031, N'Empleado de golosinas', NULL)
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1032, N'ReservarGolosinas', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1033, N'ReservarPedido', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1034, N'ReservarPedido', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1035, N'PagarPedido', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1036, N'EntregarPedido', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1037, N'ABMGolosinas', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1038, N'GestionarSerializacion', N'Accion')
GO
SET IDENTITY_INSERT [dbo].[PERMISOS] OFF
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 4)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 1006)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 1010)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 1011)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 1014)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 1015)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 1016)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 1017)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 1018)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 1025)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 1026)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 1027)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 1028)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 1029)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 1030)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 1031)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 1037)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 1038)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (4, 1019)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (4, 1020)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (1006, 1016)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (1006, 1017)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (1006, 1018)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (1006, 1022)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (1006, 1023)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (1006, 1024)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (1006, 1029)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (1006, 1037)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (1010, 1013)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (1011, 1021)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (1031, 1030)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (1031, 1035)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (1031, 1036)
GO
INSERT [dbo].[SALA] ([id], [numerodesala], [capacidad], [formato], [precio]) VALUES (1, 1, 20, N'_2D', 100)
GO
INSERT [dbo].[SALA] ([id], [numerodesala], [capacidad], [formato], [precio]) VALUES (2, 1, 15, N'_3D', 150)
GO
INSERT [dbo].[SALA] ([id], [numerodesala], [capacidad], [formato], [precio]) VALUES (3, 3, 10, N'_4D', 200)
GO
INSERT [dbo].[SALA] ([id], [numerodesala], [capacidad], [formato], [precio]) VALUES (4, 2, 10, N'_COMFORT', 300)
GO
INSERT [dbo].[SALA] ([id], [numerodesala], [capacidad], [formato], [precio]) VALUES (5, 3, 15, N'_XD', 250)
GO
INSERT [dbo].[SALA] ([id], [numerodesala], [capacidad], [formato], [precio]) VALUES (6, 4, 25, N'_2D', 100)
GO
INSERT [dbo].[SALA] ([id], [numerodesala], [capacidad], [formato], [precio]) VALUES (7, 2, 20, N'_2D', 100)
GO
INSERT [dbo].[SALA] ([id], [numerodesala], [capacidad], [formato], [precio]) VALUES (8, 1, 10, N'_PREMIUM', 500)
GO
INSERT [dbo].[SALA_FUNCION] ([idsala], [idfuncion]) VALUES (1, 13)
GO
INSERT [dbo].[SALA_FUNCION] ([idsala], [idfuncion]) VALUES (1, 14)
GO
INSERT [dbo].[SALA_FUNCION] ([idsala], [idfuncion]) VALUES (1, 15)
GO
INSERT [dbo].[SALA_FUNCION] ([idsala], [idfuncion]) VALUES (1, 16)
GO
INSERT [dbo].[SALA_FUNCION] ([idsala], [idfuncion]) VALUES (1, 17)
GO
INSERT [dbo].[SALA_FUNCION] ([idsala], [idfuncion]) VALUES (2, 18)
GO
INSERT [dbo].[SALA_FUNCION] ([idsala], [idfuncion]) VALUES (1, 19)
GO
INSERT [dbo].[SALA_FUNCION] ([idsala], [idfuncion]) VALUES (8, 20)
GO
INSERT [dbo].[SALA_FUNCION] ([idsala], [idfuncion]) VALUES (8, 21)
GO
SET IDENTITY_INSERT [dbo].[TRADUCCION] ON 
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1, 3, 1, N'Save')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (2, 3, 2, N'Access')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1002, 3, 1002, N'Session')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1003, 3, 1003, N'Managers')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1005, 3, 1004, N'Cinema')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1007, 3, 1005, N'Languages')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1008, 3, 1006, N'Log in')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1010, 3, 1007, N'Log out')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1011, 3, 1008, N'User permissions')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1012, 3, 1009, N'Permissions')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1013, 3, 1010, N'CDM Users')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1015, 3, 1011, N'CDM Films')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1016, 3, 1012, N'CDM Cinemas')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1017, 3, 1013, N'Films by cinema')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1018, 3, 1014, N'Cinemas')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1019, 2, 1, N'Guardar')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1020, 2, 2, N'Entrar')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1021, 2, 1002, N'Sesión')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1022, 2, 1003, N'Gestores')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1023, 2, 1004, N'Cine')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1024, 2, 1005, N'Idiomas')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1025, 2, 1006, N'Iniciar sesión')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1026, 2, 1007, N'Cerrar sesión')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1027, 2, 1008, N'Permisos de usuarios')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1028, 2, 1009, N'Permisos')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1029, 2, 1010, N'ABM Usuarios')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1030, 2, 1011, N'ABM Peliculas')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1031, 2, 1012, N'ABM Cines')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1032, 2, 1013, N'Cartelera')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1033, 2, 1014, N'Cines')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1034, 3, 1015, N'Log in')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1035, 2, 1015, N'Iniciar sesión')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1036, 3, 1016, N'Username')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1037, 2, 1016, N'Nombre de usuario')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1039, 3, 1017, N'Password')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1040, 2, 1017, N'Contraseña')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1041, 3, 1018, N'Add')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1042, 2, 1018, N'Agregar')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1043, 3, 1019, N'Save changes')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1044, 2, 1019, N'Guardar cambios')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1045, 3, 1020, N'All users')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1046, 2, 1020, N'Todos los usuarios')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1047, 3, 1021, N'Add actions/patents')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1049, 2, 1021, N'Agregar acciones/patentes')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1050, 3, 1022, N'Add roles/families')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1051, 2, 1022, N'Agregar roles/familias')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1052, 3, 1023, N'Configure')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1053, 2, 1023, N'Configurar')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1054, 3, 1024, N'Actions')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1056, 2, 1024, N'Acciones')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1057, 3, 1025, N'Roles')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1058, 2, 1025, N'Roles')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1059, 3, 1026, N'Name')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1061, 2, 1026, N'Nombre')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1062, 3, 1027, N'Configure roles')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1063, 2, 1027, N'Configurar roles')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1064, 3, 1028, N'New action')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1065, 2, 1028, N'Nueva acción')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1066, 3, 1029, N'New role')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1067, 2, 1029, N'Nuevo rol')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1068, 3, 1030, N'All actions')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1069, 2, 1030, N'Todas las acciones')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1070, 3, 1031, N'All roles')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1071, 2, 1031, N'Todos los roles')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1072, 3, 1032, N'Last name')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1073, 2, 1032, N'Apellido')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1074, 3, 1033, N'Email address')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1075, 2, 1033, N'Correo electrónico')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1076, 3, 1034, N'Create')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1077, 2, 1034, N'Alta')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1078, 3, 1035, N'Delete')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1079, 2, 1035, N'Baja')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1080, 3, 1036, N'Modification')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1081, 2, 1036, N'Modificación')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1082, 3, 1037, N'Title')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1083, 2, 1037, N'Título')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1084, 3, 1038, N'Film diector')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1085, 2, 1038, N'Director')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1086, 3, 1039, N'Duration (minutes)')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1087, 2, 1039, N'Duración (minutos)')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1088, 3, 1040, N'Film genre')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1089, 2, 1040, N'Género')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1090, 3, 1041, N'Description')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1092, 2, 1041, N'Descripción')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1093, 3, 1042, N'Image')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1094, 2, 1042, N'Imagen')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1095, 3, 1043, N'Search image')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1096, 2, 1043, N'Buscar imagen')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1097, 3, 1044, N'Zone')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1098, 2, 1044, N'Zona')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1099, 3, 1045, N'Address')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1100, 2, 1045, N'Dirección')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1101, 3, 1046, N'Select a cinema')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1102, 2, 1046, N'Selccione un cine')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1103, 3, 1047, N'Films')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1104, 2, 1047, N'Películas')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1105, 3, 1048, N'Select a film')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1106, 2, 1048, N'Seleccione una película')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1107, 3, 1049, N'Film details')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1108, 2, 1049, N'Detalles de la película')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1109, 3, 1050, N'Buy tickets')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1110, 2, 1050, N'Comprar entradas')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1111, 3, 1051, N'User language')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1112, 2, 1051, N'Idoma del usuario')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1113, 3, 1052, N'Manage user permissions')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1114, 2, 1052, N'Gestionar permisos de usuarios')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1115, 3, 1053, N'Manage permissions')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1117, 2, 1053, N'Gestionar permisos')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1118, 3, 1054, N'Book tickets')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1119, 2, 1054, N'Reservar entradas')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1120, 3, 1055, N'Pay tickets')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1121, 2, 1055, N'Pagar entradas')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1122, 3, 1056, N'Issue tickets')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1123, 2, 1056, N'Emitir entradas')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1124, 3, 1057, N'Mark tickets')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1125, 2, 1057, N'Marcar entradas')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1126, 3, 1058, N'Manage cinemas')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1127, 2, 1058, N'Gestionar cines')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1128, 3, 1059, N'CDM Auditoriums')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1130, 2, 1059, N'ABM Salas')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1131, 3, 1060, N'Capacity')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1132, 2, 1060, N'Capacidad')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1133, 3, 1061, N'Auditorium number')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1134, 2, 1061, N'Número de sala')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1135, 3, 1062, N'Format')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1136, 2, 1062, N'Formato')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1137, 3, 1063, N'CDM Functions')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1138, 2, 1063, N'ABM Funciones')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1139, 3, 1064, N'Hour')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1140, 2, 1064, N'Horario')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1141, 3, 1065, N'Select a auditorium')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1142, 2, 1065, N'Seleccione una sala')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1143, 3, 1066, N'Auditorium')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1144, 2, 1066, N'Sala')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1145, 3, 1067, N'Year')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1146, 2, 1067, N'Año')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1147, 3, 1068, N'Month')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1148, 2, 1068, N'Mes')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1149, 3, 1069, N'Day')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1150, 2, 1069, N'Día')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1151, 3, 1070, N'Seat')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1152, 2, 1070, N'Butaca')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1153, 3, 1071, N'Confirm selected')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1154, 2, 1071, N'Confirmar lo seleccionado')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1155, 3, 1072, N'Seats')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1156, 2, 1072, N'Butacas')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1157, 3, 1073, N'Film')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1158, 2, 1073, N'Pelicula')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1159, 3, 1075, N'Function number')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1160, 2, 1075, N'Numero de funcion')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1161, 3, 1076, N'Set ticket as paid')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1162, 2, 1076, N'Establecer entrada como pagada')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1163, 3, 1077, N'Set ticket as issued')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1164, 2, 1077, N'Establecer entrada como emitida')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1165, 3, 1078, N'Set ticket as used')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1166, 2, 1078, N'Establecer entrada como utilizada')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1167, 3, 1079, N'Set ticket as overdue')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1168, 2, 1079, N'Establecer entrada como vencida')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1169, 3, 1080, N'Select a function')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1170, 2, 1080, N'Seleccione una funcion')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1171, 3, 1081, N'CDM Languages')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1172, 2, 1081, N'ABM Idiomas')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1173, 3, 1082, N'Ready for use')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1176, 2, 1082, N'Listo para usar')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1341, 11, 1, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1342, 11, 2, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1343, 11, 1002, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1344, 11, 1003, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1345, 11, 1004, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1346, 11, 1005, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1347, 11, 1006, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1348, 11, 1007, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1349, 11, 1008, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1350, 11, 1009, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1351, 11, 1010, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1352, 11, 1011, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1353, 11, 1012, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1354, 11, 1013, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1355, 11, 1014, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1356, 11, 1015, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1357, 11, 1016, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1358, 11, 1017, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1359, 11, 1018, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1360, 11, 1019, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1361, 11, 1020, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1362, 11, 1021, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1363, 11, 1022, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1364, 11, 1023, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1365, 11, 1024, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1366, 11, 1025, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1367, 11, 1026, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1368, 11, 1027, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1369, 11, 1028, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1370, 11, 1029, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1371, 11, 1030, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1372, 11, 1031, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1373, 11, 1032, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1374, 11, 1033, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1375, 11, 1034, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1376, 11, 1035, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1377, 11, 1036, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1378, 11, 1037, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1379, 11, 1038, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1380, 11, 1039, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1381, 11, 1040, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1382, 11, 1041, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1383, 11, 1042, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1384, 11, 1043, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1385, 11, 1044, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1386, 11, 1045, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1387, 11, 1046, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1388, 11, 1047, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1389, 11, 1048, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1390, 11, 1049, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1391, 11, 1050, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1392, 11, 1051, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1393, 11, 1052, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1394, 11, 1053, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1395, 11, 1054, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1396, 11, 1055, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1397, 11, 1056, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1398, 11, 1057, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1399, 11, 1058, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1400, 11, 1059, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1401, 11, 1060, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1402, 11, 1061, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1403, 11, 1062, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1404, 11, 1063, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1405, 11, 1064, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1406, 11, 1065, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1407, 11, 1066, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1408, 11, 1067, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1409, 11, 1068, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1410, 11, 1069, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1411, 11, 1070, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1412, 11, 1071, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1413, 11, 1072, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1414, 11, 1073, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1415, 11, 1075, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1416, 11, 1076, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1417, 11, 1077, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1418, 11, 1078, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1419, 11, 1079, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1420, 11, 1080, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1421, 11, 1081, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (1422, 11, 1082, N'Traducción pendiente')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (2177, 3, 1083, N'Price')
GO
INSERT [dbo].[TRADUCCION] ([id], [ididioma], [idetiqueta], [texto]) VALUES (2178, 2, 1083, N'Precio')
GO
SET IDENTITY_INSERT [dbo].[TRADUCCION] OFF
GO
SET IDENTITY_INSERT [dbo].[USUARIOS] ON 
GO
INSERT [dbo].[USUARIOS] ([id], [nombredeusuario], [nombre], [apellido], [contrasenia], [correo], [ididioma]) VALUES (1, N'Lauta', N'Lautaro', N'Rojas', N'dOLrys7faKWPqir8OWcMNA==', N'lautaro.rojas02@gmail.com', 2)
GO
INSERT [dbo].[USUARIOS] ([id], [nombredeusuario], [nombre], [apellido], [contrasenia], [correo], [ididioma]) VALUES (2, N'MaxV', N'Max', N'Verstappen', N'dOLrys7faKWPqir8OWcMNA==', N'max.verstappen@gmail.com', 2)
GO
INSERT [dbo].[USUARIOS] ([id], [nombredeusuario], [nombre], [apellido], [contrasenia], [correo], [ididioma]) VALUES (4, N'Nano', N'Fernando', N'Alonso', N'dOLrys7faKWPqir8OWcMNA==', N'fernando.alonso@gmail.com', 2)
GO
INSERT [dbo].[USUARIOS] ([id], [nombredeusuario], [nombre], [apellido], [contrasenia], [correo], [ididioma]) VALUES (5, N'Checo', N'Sergio', N'Perez', N'dOLrys7faKWPqir8OWcMNA==', N'sergio.perez@gmail.com', 2)
GO
INSERT [dbo].[USUARIOS] ([id], [nombredeusuario], [nombre], [apellido], [contrasenia], [correo], [ididioma]) VALUES (1005, N'CharLec', N'Charles', N'Leclerc', N'dOLrys7faKWPqir8OWcMNA==', N'charles.leclerc@gmail.com', 3)
GO
INSERT [dbo].[USUARIOS] ([id], [nombredeusuario], [nombre], [apellido], [contrasenia], [correo], [ididioma]) VALUES (1006, N'Nor', N'Lando', N'Norris', N'jaERRQ8Pl2OPqir8OWcMNA==', N'lando.norris@gmail.com', 3)
GO
INSERT [dbo].[USUARIOS] ([id], [nombredeusuario], [nombre], [apellido], [contrasenia], [correo], [ididioma]) VALUES (2005, N'CarlosJr', N'Carlos', N'Sainz Jr', N'dOLrys7faKWPqir8OWcMNA==', N'carlos.sainzjr@gmail.com', 2)
GO
INSERT [dbo].[USUARIOS] ([id], [nombredeusuario], [nombre], [apellido], [contrasenia], [correo], [ididioma]) VALUES (2006, N'OscarP', N'Oscar', N'Piastri', N'dOLrys7faKWPqir8OWcMNA==', N'oscar.piastri@gmail.com', 2)
GO
INSERT [dbo].[USUARIOS] ([id], [nombredeusuario], [nombre], [apellido], [contrasenia], [correo], [ididioma]) VALUES (2007, N'admin', N'Admin', N'Admin', N'Q+y2W7W7UwrKRuXCjsf/WA==', N'-', 2)
GO
SET IDENTITY_INSERT [dbo].[USUARIOS] OFF
GO
INSERT [dbo].[USUARIOS_PERMISOS] ([idusuario], [idpermiso]) VALUES (1, 3)
GO
INSERT [dbo].[USUARIOS_PERMISOS] ([idusuario], [idpermiso]) VALUES (2, 1006)
GO
INSERT [dbo].[USUARIOS_PERMISOS] ([idusuario], [idpermiso]) VALUES (4, 1010)
GO
INSERT [dbo].[USUARIOS_PERMISOS] ([idusuario], [idpermiso]) VALUES (5, 1011)
GO
INSERT [dbo].[USUARIOS_PERMISOS] ([idusuario], [idpermiso]) VALUES (1005, 4)
GO
INSERT [dbo].[USUARIOS_PERMISOS] ([idusuario], [idpermiso]) VALUES (1006, 1031)
GO
INSERT [dbo].[USUARIOS_PERMISOS] ([idusuario], [idpermiso]) VALUES (2007, 3)
GO
ALTER TABLE [dbo].[BITACORACAMBIOS_ENTRADA]  WITH CHECK ADD  CONSTRAINT [FK_BITACORACAMBIOS_ENTRADA_ENTRADA] FOREIGN KEY([b_identrada])
REFERENCES [dbo].[ENTRADA] ([id])
GO
ALTER TABLE [dbo].[BITACORACAMBIOS_ENTRADA] CHECK CONSTRAINT [FK_BITACORACAMBIOS_ENTRADA_ENTRADA]
GO
ALTER TABLE [dbo].[BITACORACAMBIOS_ENTRADA]  WITH CHECK ADD  CONSTRAINT [FK_BITACORACAMBIOS_ENTRADA_USUARIOS] FOREIGN KEY([idusuarioquemodifica])
REFERENCES [dbo].[USUARIOS] ([id])
GO
ALTER TABLE [dbo].[BITACORACAMBIOS_ENTRADA] CHECK CONSTRAINT [FK_BITACORACAMBIOS_ENTRADA_USUARIOS]
GO
ALTER TABLE [dbo].[BITACORAEVENTOS]  WITH CHECK ADD  CONSTRAINT [FK_BITACORAEVENTOS_USUARIOS] FOREIGN KEY([idusuario])
REFERENCES [dbo].[USUARIOS] ([id])
GO
ALTER TABLE [dbo].[BITACORAEVENTOS] CHECK CONSTRAINT [FK_BITACORAEVENTOS_USUARIOS]
GO
ALTER TABLE [dbo].[CARTELERA]  WITH CHECK ADD  CONSTRAINT [FK_CARTELERA_CINE] FOREIGN KEY([idcine])
REFERENCES [dbo].[CINE] ([id])
GO
ALTER TABLE [dbo].[CARTELERA] CHECK CONSTRAINT [FK_CARTELERA_CINE]
GO
ALTER TABLE [dbo].[CARTELERA]  WITH CHECK ADD  CONSTRAINT [FK_CARTELERA_PELICULA] FOREIGN KEY([idpelicula])
REFERENCES [dbo].[PELICULA] ([id])
GO
ALTER TABLE [dbo].[CARTELERA] CHECK CONSTRAINT [FK_CARTELERA_PELICULA]
GO
ALTER TABLE [dbo].[CINE_SALA]  WITH CHECK ADD  CONSTRAINT [FK_CINE_SALA_CINE] FOREIGN KEY([idcine])
REFERENCES [dbo].[CINE] ([id])
GO
ALTER TABLE [dbo].[CINE_SALA] CHECK CONSTRAINT [FK_CINE_SALA_CINE]
GO
ALTER TABLE [dbo].[CINE_SALA]  WITH CHECK ADD  CONSTRAINT [FK_CINE_SALA_SALA] FOREIGN KEY([idsala])
REFERENCES [dbo].[SALA] ([id])
GO
ALTER TABLE [dbo].[CINE_SALA] CHECK CONSTRAINT [FK_CINE_SALA_SALA]
GO
ALTER TABLE [dbo].[ENTRADA]  WITH CHECK ADD  CONSTRAINT [FK_ENTRADA_FUNCION] FOREIGN KEY([idfuncion])
REFERENCES [dbo].[FUNCION] ([id])
GO
ALTER TABLE [dbo].[ENTRADA] CHECK CONSTRAINT [FK_ENTRADA_FUNCION]
GO
ALTER TABLE [dbo].[ENTRADA]  WITH CHECK ADD  CONSTRAINT [FK_ENTRADA_USUARIOS] FOREIGN KEY([idusuario])
REFERENCES [dbo].[USUARIOS] ([id])
GO
ALTER TABLE [dbo].[ENTRADA] CHECK CONSTRAINT [FK_ENTRADA_USUARIOS]
GO
ALTER TABLE [dbo].[FUNCION]  WITH CHECK ADD  CONSTRAINT [FK_FUNCION_PELICULA1] FOREIGN KEY([idpelicula])
REFERENCES [dbo].[PELICULA] ([id])
GO
ALTER TABLE [dbo].[FUNCION] CHECK CONSTRAINT [FK_FUNCION_PELICULA1]
GO
ALTER TABLE [dbo].[PEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDO_USUARIOS] FOREIGN KEY([idcliente])
REFERENCES [dbo].[USUARIOS] ([id])
GO
ALTER TABLE [dbo].[PEDIDO] CHECK CONSTRAINT [FK_PEDIDO_USUARIOS]
GO
ALTER TABLE [dbo].[PEDIDO_GOLOSINA]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDO_GOLOSINA_GOLOSINA] FOREIGN KEY([idgolosina])
REFERENCES [dbo].[GOLOSINA] ([id])
GO
ALTER TABLE [dbo].[PEDIDO_GOLOSINA] CHECK CONSTRAINT [FK_PEDIDO_GOLOSINA_GOLOSINA]
GO
ALTER TABLE [dbo].[PEDIDO_GOLOSINA]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDO_GOLOSINA_PEDIDO] FOREIGN KEY([idpedido])
REFERENCES [dbo].[PEDIDO] ([id])
GO
ALTER TABLE [dbo].[PEDIDO_GOLOSINA] CHECK CONSTRAINT [FK_PEDIDO_GOLOSINA_PEDIDO]
GO
ALTER TABLE [dbo].[PERMISOS_PERMISOS]  WITH CHECK ADD  CONSTRAINT [FK_PERMISOS_PERMISOS_PERMISOS] FOREIGN KEY([idpermisopadre])
REFERENCES [dbo].[PERMISOS] ([id])
GO
ALTER TABLE [dbo].[PERMISOS_PERMISOS] CHECK CONSTRAINT [FK_PERMISOS_PERMISOS_PERMISOS]
GO
ALTER TABLE [dbo].[PERMISOS_PERMISOS]  WITH CHECK ADD  CONSTRAINT [FK_PERMISOS_PERMISOS_PERMISOS1] FOREIGN KEY([idpermisohijo])
REFERENCES [dbo].[PERMISOS] ([id])
GO
ALTER TABLE [dbo].[PERMISOS_PERMISOS] CHECK CONSTRAINT [FK_PERMISOS_PERMISOS_PERMISOS1]
GO
ALTER TABLE [dbo].[SALA_FUNCION]  WITH CHECK ADD  CONSTRAINT [FK_SALA_FUNCION_FUNCION1] FOREIGN KEY([idfuncion])
REFERENCES [dbo].[FUNCION] ([id])
GO
ALTER TABLE [dbo].[SALA_FUNCION] CHECK CONSTRAINT [FK_SALA_FUNCION_FUNCION1]
GO
ALTER TABLE [dbo].[SALA_FUNCION]  WITH CHECK ADD  CONSTRAINT [FK_SALA_FUNCION_SALA] FOREIGN KEY([idsala])
REFERENCES [dbo].[SALA] ([id])
GO
ALTER TABLE [dbo].[SALA_FUNCION] CHECK CONSTRAINT [FK_SALA_FUNCION_SALA]
GO
ALTER TABLE [dbo].[TRADUCCION]  WITH CHECK ADD  CONSTRAINT [FK_TRADUCCION_ETIQUETA] FOREIGN KEY([idetiqueta])
REFERENCES [dbo].[ETIQUETA] ([id])
GO
ALTER TABLE [dbo].[TRADUCCION] CHECK CONSTRAINT [FK_TRADUCCION_ETIQUETA]
GO
ALTER TABLE [dbo].[TRADUCCION]  WITH CHECK ADD  CONSTRAINT [FK_TRADUCCION_IDIOMA] FOREIGN KEY([ididioma])
REFERENCES [dbo].[IDIOMA] ([id])
GO
ALTER TABLE [dbo].[TRADUCCION] CHECK CONSTRAINT [FK_TRADUCCION_IDIOMA]
GO
ALTER TABLE [dbo].[USUARIOS]  WITH CHECK ADD  CONSTRAINT [FK_USUARIOS_IDIOMA] FOREIGN KEY([ididioma])
REFERENCES [dbo].[IDIOMA] ([id])
GO
ALTER TABLE [dbo].[USUARIOS] CHECK CONSTRAINT [FK_USUARIOS_IDIOMA]
GO
ALTER TABLE [dbo].[USUARIOS_PERMISOS]  WITH CHECK ADD  CONSTRAINT [FK_USUARIOS_PERMISOS_PERMISOS] FOREIGN KEY([idpermiso])
REFERENCES [dbo].[PERMISOS] ([id])
GO
ALTER TABLE [dbo].[USUARIOS_PERMISOS] CHECK CONSTRAINT [FK_USUARIOS_PERMISOS_PERMISOS]
GO
ALTER TABLE [dbo].[USUARIOS_PERMISOS]  WITH CHECK ADD  CONSTRAINT [FK_USUARIOS_PERMISOS_USUARIOS] FOREIGN KEY([idusuario])
REFERENCES [dbo].[USUARIOS] ([id])
GO
ALTER TABLE [dbo].[USUARIOS_PERMISOS] CHECK CONSTRAINT [FK_USUARIOS_PERMISOS_USUARIOS]
GO
/****** Object:  StoredProcedure [dbo].[ACCION_LISTAR]    Script Date: 21/11/2024 16:53:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ACCION_LISTAR]
AS
BEGIN
	SELECT * FROM PERMISOS WHERE tipo IS NOT NULL
END
GO
/****** Object:  StoredProcedure [dbo].[BITACORA_CAMBIOS_ENTRADA_INSERTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BITACORA_CAMBIOS_ENTRADA_INSERTAR]
@idusuarioquemodifica int, @fechadecambio DateTime, @activo bit, @b_identrada int, @b_idusuario int, @b_idfuncion int, @b_idsala int, @b_butaca varchar(50), @b_precio float, @b_fechadereserva DateTime, @b_estado varchar(50), @b_digitohorizontal varchar(70)
AS
BEGIN
	UPDATE BITACORACAMBIOS_ENTRADA SET activo = 0 WHERE b_identrada = @b_identrada;
	INSERT INTO BITACORACAMBIOS_ENTRADA VALUES (@idusuarioquemodifica, @fechadecambio, @activo, @b_identrada, @b_idusuario, @b_idfuncion, @b_idsala, @b_butaca, @b_precio, @b_fechadereserva, @b_estado, @b_digitohorizontal);
END
GO
/****** Object:  StoredProcedure [dbo].[BITACORA_CAMBIOS_ENTRADA_LISTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BITACORA_CAMBIOS_ENTRADA_LISTAR]
AS
BEGIN
	SELECT * FROM BITACORACAMBIOS_ENTRADA
END
GO
/****** Object:  StoredProcedure [dbo].[BITACORA_CAMBIOS_ENTRADA_MODIFICAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BITACORA_CAMBIOS_ENTRADA_MODIFICAR]
@fechadecambio DateTime, @activo bit, @b_identrada int
AS
BEGIN
	UPDATE BITACORACAMBIOS_ENTRADA SET activo = 0 WHERE b_identrada = @b_identrada;
	UPDATE BITACORACAMBIOS_ENTRADA SET 
		activo = @activo
	WHERE fechadecambio = @fechadecambio;
END
GO
/****** Object:  StoredProcedure [dbo].[BITACORAEVENTOS_INSERTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BITACORAEVENTOS_INSERTAR]
@idusuario int, @fecha datetime, @accion varchar(50)
AS
BEGIN
	INSERT INTO BITACORAEVENTOS VALUES (@idusuario, @fecha, @accion)
END
GO
/****** Object:  StoredProcedure [dbo].[BITACORAEVENTOS_LISTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[BITACORAEVENTOS_LISTAR]
AS
BEGIN
	SELECT * FROM BITACORAEVENTOS
END
GO
/****** Object:  StoredProcedure [dbo].[BUTACA_OCUPADA_BUSCAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BUTACA_OCUPADA_BUSCAR]
@idfuncion int
AS
BEGIN
	SELECT butaca FROM ENTRADA WHERE idfuncion = @idfuncion AND (estado = 'Pagada' OR estado = 'Emitida')
END
GO
/****** Object:  StoredProcedure [dbo].[CARTELERA_BUSCAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CARTELERA_BUSCAR]
@idcine int
AS
BEGIN
	SELECT * FROM CARTELERA WHERE idcine = @idcine
END
GO
/****** Object:  StoredProcedure [dbo].[CINE_BORRAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[CINE_BORRAR]
@id int
AS
BEGIN
	DELETE FROM CINE WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[CINE_BUSCAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[CINE_BUSCAR]
@nombre varchar(50)
AS
BEGIN
	SELECT * FROM CINE WHERE nombre = @nombre
END
GO
/****** Object:  StoredProcedure [dbo].[CINE_EDITAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[CINE_EDITAR]
@id int, @nombre varchar(50), @zona varchar(50), @direccion varchar(MAX)
AS
BEGIN
	UPDATE CINE SET 
		nombre = @nombre, 
		zona = @zona,
		direccion = @direccion
	WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[CINE_INSERTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CINE_INSERTAR]
@nombre varchar(50), @zona varchar(50), @direccion varchar(MAX)
AS
BEGIN
	INSERT INTO CINE VALUES (@nombre, @zona, @direccion)
END
GO
/****** Object:  StoredProcedure [dbo].[CINE_LISTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[CINE_LISTAR]
AS
BEGIN
	SELECT * FROM CINE
END
GO
/****** Object:  StoredProcedure [dbo].[CINE_SALA_BUSCAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CINE_SALA_BUSCAR]
@idcine int
AS
BEGIN
	SELECT * FROM CINE_SALA WHERE idcine = @idcine
END
GO
/****** Object:  StoredProcedure [dbo].[CINE_SALA_INSERTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CINE_SALA_INSERTAR]
@idcine int, @idsala int
AS
BEGIN
	INSERT INTO CINE_SALA VALUES (@idcine, @idsala)
END
GO
/****** Object:  StoredProcedure [dbo].[ENTRADA_BORRAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ENTRADA_BORRAR]
@id int
AS 
BEGIN
	DELETE FROM ENTRADA WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[ENTRADA_BUSCAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ENTRADA_BUSCAR]
@id int
AS
BEGIN
	SELECT * FROM ENTRADA WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[ENTRADA_BUSCARESTADO]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ENTRADA_BUSCARESTADO]
@estado varchar(50)
AS
BEGIN
	SELECT * FROM ENTRADA WHERE estado = @estado
END
GO
/****** Object:  StoredProcedure [dbo].[ENTRADA_BUSCARFECHA]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ENTRADA_BUSCARFECHA]
@fecha DateTime
AS
BEGIN
	SELECT * FROM ENTRADA WHERE fechadereserva = @fecha
END
GO
/****** Object:  StoredProcedure [dbo].[ENTRADA_EDITAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ENTRADA_EDITAR]
@id int, @idusuario int, @idfuncion int, @idsala int, @butaca varchar(50), @precio float, @fechadereserva DateTime, @estado varchar(50), @digitohorizontal varchar(70)
AS 
BEGIN
    UPDATE ENTRADA SET 
        idusuario = @idusuario, 
        idfuncion = @idfuncion,
        idsala = @idsala,
        butaca = @butaca,
        precio = @precio,
        fechadereserva = @fechadereserva,
        estado = @estado,
		digitohorizontal = @digitohorizontal
    WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[ENTRADA_INSERTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ENTRADA_INSERTAR]
@idusuario int, @idfuncion int, @idsala int, @butaca varchar(50), @precio float, @fehcadereserva datetime, @estado varchar(50), @digitohorizontal varchar(70)
AS 
BEGIN
	INSERT INTO ENTRADA VALUES (@idusuario, @idfuncion,@idsala, @butaca, @precio, @fehcadereserva, @estado, @digitohorizontal )
END
GO
/****** Object:  StoredProcedure [dbo].[ENTRADA_LISTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ENTRADA_LISTAR]
AS
BEGIN
	SELECT * FROM ENTRADA
END
GO
/****** Object:  StoredProcedure [dbo].[FUNCION_BORRAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[FUNCION_BORRAR]
@id int
AS
BEGIN
	DELETE FROM FUNCION WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[FUNCION_BUSCAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[FUNCION_BUSCAR]
@idpelicula int
AS
BEGIN
	SELECT * FROM FUNCION WHERE idpelicula = @idpelicula
END
GO
/****** Object:  StoredProcedure [dbo].[FUNCION_BUSCARID]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[FUNCION_BUSCARID]
@id int
AS
BEGIN
	SELECT * FROM FUNCION WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[FUNCION_EDITAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[FUNCION_EDITAR]
@id int, @idpelicula int, @horario DateTime
AS
BEGIN
	UPDATE FUNCION SET 
		idpelicula = @idpelicula, 
		horario = @horario
    WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[FUNCION_INSERTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[FUNCION_INSERTAR]
@id int, @idpelicula int, @horario DateTime
AS
BEGIN
	INSERT INTO FUNCION VALUES (@id, @idpelicula, @horario)
END
GO
/****** Object:  StoredProcedure [dbo].[FUNCION_LISTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[FUNCION_LISTAR]
AS
BEGIN 
	SELECT * FROM FUNCION
END
GO
/****** Object:  StoredProcedure [dbo].[GOLOSINA_BORRAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GOLOSINA_BORRAR]
@id int
AS
BEGIN
	DELETE FROM GOLOSINA WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[GOLOSINA_BUSCAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GOLOSINA_BUSCAR]
@nombre varchar(50)
AS
BEGIN
	SELECT * FROM GOLOSINA WHERE nombre = @nombre
END
GO
/****** Object:  StoredProcedure [dbo].[GOLOSINA_BUSCARID]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GOLOSINA_BUSCARID]
@id int
AS
BEGIN
	SELECT * FROM GOLOSINA WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[GOLOSINA_EDITAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GOLOSINA_EDITAR]
@id int, @nombre varchar(50), @precio float
AS
BEGIN
	UPDATE GOLOSINA SET 
		nombre = @nombre, 
		precio = @precio
	WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[GOLOSINA_INSERTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GOLOSINA_INSERTAR]
@nombre varchar(50), @precio float
AS
BEGIN
	INSERT INTO GOLOSINA VALUES (@nombre, @precio)
END
GO
/****** Object:  StoredProcedure [dbo].[GOLOSINA_LISTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GOLOSINA_LISTAR]
AS
BEGIN
	SELECT * FROM GOLOSINA
END
GO
/****** Object:  StoredProcedure [dbo].[IDIOMA_BORRAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[IDIOMA_BORRAR]
@id int
AS
BEGIN
	DELETE FROM TRADUCCION WHERE ididioma = @id
	DELETE FROM IDIOMA WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[IDIOMA_BUSCAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[IDIOMA_BUSCAR]
@nombre varchar(50)
AS
BEGIN
	SELECT * FROM IDIOMA WHERE nombre = @nombre
END
GO
/****** Object:  StoredProcedure [dbo].[IDIOMA_EDITAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[IDIOMA_EDITAR]
@id int, @nombre varchar(50), @listoparausar bit
AS
BEGIN
	UPDATE IDIOMA SET 
		nombre = @nombre,
		listoparausar = @listoparausar
	WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[IDIOMA_INSERTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[IDIOMA_INSERTAR]
@nombre varchar(50), @pordefecto bit, @listoparausar bit
AS
BEGIN
	INSERT INTO IDIOMA VALUES (@nombre, @pordefecto, @listoparausar)
	--Cree un trigger para cuando se inserte un nuevo idioma se puedan crear las traducciones de forma automática
END
GO
/****** Object:  StoredProcedure [dbo].[IDIOMA_LISTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[IDIOMA_LISTAR]
AS
BEGIN
	SELECT * FROM IDIOMA
END
GO
/****** Object:  StoredProcedure [dbo].[OBTENER_TRADUCCIONES]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[OBTENER_TRADUCCIONES]
@ididioma int
AS
BEGIN
	SELECT t.id AS 'idtraduccion', i.id AS 'ididioma', i.nombre AS 'nombreidioma', i.pordefecto, e.id AS 'idetiqueta', e.nombre AS 'nombreetiqueta', t.texto AS 'traduccion' FROM TRADUCCION t INNER JOIN IDIOMA i ON t.ididioma = i.id INNER JOIN ETIQUETA e ON t.idetiqueta = e.id WHERE i.id = @ididioma
END
GO
/****** Object:  StoredProcedure [dbo].[PEDIDO_BORRAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PEDIDO_BORRAR]
@id int
AS
BEGIN
	DELETE FROM PEDIDO WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[PEDIDO_BUSCAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PEDIDO_BUSCAR]
@id int
AS
BEGIN
	SELECT * FROM PEDIDO WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[PEDIDO_BUSCARESTADO]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PEDIDO_BUSCARESTADO]
@estado varchar(50)
AS
BEGIN
	SELECT * FROM PEDIDO WHERE estado = @estado
END
GO
/****** Object:  StoredProcedure [dbo].[PEDIDO_EDITAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PEDIDO_EDITAR]
@id int, @idcliente int, @fecha datetime, @estado varchar(50), @montototal float
AS
BEGIN
	UPDATE PEDIDO SET 
        idcliente = @idcliente, 
        fecha = @fecha,
        estado = @estado,
        montototal = @montototal
    WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[PEDIDO_GOLOSINA_BUSCAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PEDIDO_GOLOSINA_BUSCAR]
@idpedido int
AS
BEGIN
	SELECT * FROM PEDIDO_GOLOSINA WHERE idpedido = @idpedido
END
GO
/****** Object:  StoredProcedure [dbo].[PEDIDO_GOLOSINA_INSERTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PEDIDO_GOLOSINA_INSERTAR]
@idpedido int, @idgolosina int, @cantidad int, @preciounitario float
AS
BEGIN
	INSERT INTO PEDIDO_GOLOSINA VALUES (@idpedido, @idgolosina, @cantidad, @preciounitario)
END
GO
/****** Object:  StoredProcedure [dbo].[PEDIDO_INSERTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PEDIDO_INSERTAR]
@id int, @idcliente int, @fecha datetime, @estado varchar(50), @montototal float
AS
BEGIN
	INSERT INTO PEDIDO VALUES (@id, @idcliente, @fecha, @estado, @montototal)
END
GO
/****** Object:  StoredProcedure [dbo].[PEDIDO_LISTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PEDIDO_LISTAR]
AS
BEGIN
	SELECT * FROM PEDIDO
END
GO
/****** Object:  StoredProcedure [dbo].[PELICULA_BORRAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PELICULA_BORRAR]
@id int
AS
BEGIN
	DELETE FROM PELICULA WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[PELICULA_BUSCAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PELICULA_BUSCAR]
@titulo varchar(50)
AS
BEGIN
	SELECT * FROM PELICULA WHERE titulo = @titulo
END
GO
/****** Object:  StoredProcedure [dbo].[PELICULA_BUSCARID]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PELICULA_BUSCARID]
@id int
AS
BEGIN
	SELECT * FROM PELICULA WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[PELICULA_EDITAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PELICULA_EDITAR]
@id int, @titulo varchar(50), @director varchar(50), @duracion int, @genero varchar(50), @descripcion varchar(MAX), @imagen varbinary(MAX)
AS
BEGIN
	UPDATE PELICULA SET 
        titulo = @titulo, 
        director = @director,
        duracion = @duracion,
        genero = @genero,
		descripcion = @descripcion,
        imagen = @imagen
    WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[PELICULA_INSERTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PELICULA_INSERTAR]
@titulo varchar(50), @director varchar(50), @duracion int, @genero varchar(50), @descripcion varchar(MAX), @imagen varbinary(MAX)
AS
BEGIN
	INSERT INTO PELICULA VALUES (@titulo, @director, @duracion, @genero, @descripcion, @imagen)
END
GO
/****** Object:  StoredProcedure [dbo].[PELICULA_LISTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PELICULA_LISTAR]
AS
BEGIN
	SELECT * FROM PELICULA
END
GO
/****** Object:  StoredProcedure [dbo].[PERMISO_INSERTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PERMISO_INSERTAR]
@nombre varchar(50), @tipo varchar(50)
AS
BEGIN
	INSERT INTO PERMISOS VALUES (@nombre, @tipo)
	--SELECT id AS LastID FROM PERMISOS WHERE id = @@Identity
END
GO
/****** Object:  StoredProcedure [dbo].[PERMISO_LISTAR_RECURSIVO]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PERMISO_LISTAR_RECURSIVO]
@where varchar(50)
AS
BEGIN
	WITH recursivo AS	(
							SELECT PP2.idpermisopadre, PP2.idpermisohijo FROM PERMISOS_PERMISOS PP2
							WHERE PP2.idpermisopadre = @where --acá se va variando la familia que busco
							UNION ALL 
							SELECT PP1.idpermisopadre, PP1.idpermisohijo FROM PERMISOS_PERMISOS PP1 
							inner join recursivo rec ON rec.idpermisohijo = PP1.idpermisopadre
						)
						SELECT rec.idpermisopadre, rec.idpermisohijo, P.id, P.nombre, P.tipo
						FROM recursivo rec 
						inner join PERMISOS P ON rec.idpermisohijo = P.id
END
GO
/****** Object:  StoredProcedure [dbo].[PERMISO_PERMISO_BORRAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PERMISO_PERMISO_BORRAR]
@id int
AS
BEGIN
	DELETE FROM PERMISOS_PERMISOS WHERE idpermisopadre = @id
END
GO
/****** Object:  StoredProcedure [dbo].[PERMISO_PERMISO_INSERTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PERMISO_PERMISO_INSERTAR]
@idpermisopadre int, @idpermisohijo int
AS
BEGIN
	INSERT INTO PERMISOS_PERMISOS VALUES (@idpermisopadre, @idpermisohijo) 
END
GO
/****** Object:  StoredProcedure [dbo].[REALIZAR_BACKUP]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[REALIZAR_BACKUP]
@nombrebd varchar(50), @rutabackup varchar(200)
AS
BEGIN
	BACKUP DATABASE @nombrebd TO DISK = @rutabackup
END
GO
/****** Object:  StoredProcedure [dbo].[REPORTE_CINE]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[REPORTE_CINE]
@idcine int
AS
BEGIN
	SELECT CINE.Id AS IdCine, CINE.Nombre AS NombreCine, COUNT(ENTRADA.Id) AS CantidadEntradasVendidas
	FROM CINE
	INNER JOIN CINE_SALA ON CINE.Id = CINE_SALA.IdCine
	INNER JOIN SALA ON CINE_SALA.IdSala = SALA.Id
	INNER JOIN SALA_FUNCION ON SALA.Id = SALA_FUNCION.IdSala
	INNER JOIN FUNCION ON SALA_FUNCION.IdFuncion = FUNCION.Id
	INNER JOIN ENTRADA ON FUNCION.Id = ENTRADA.IdFuncion
	WHERE CINE.Id = @idcine
	AND ENTRADA.Estado = 'Pagada'
	GROUP BY CINE.Id, CINE.Nombre;
END
GO
/****** Object:  StoredProcedure [dbo].[ROL_LISTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ROL_LISTAR]
AS
BEGIN
	SELECT * FROM PERMISOS WHERE tipo IS NULL
END
GO
/****** Object:  StoredProcedure [dbo].[SALA_BORRAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SALA_BORRAR]
@id int
AS
BEGIN
	DELETE FROM SALA WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SALA_BUSCAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SALA_BUSCAR]
@id int
AS
BEGIN
	SELECT * FROM SALA WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SALA_BUSCARID]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SALA_BUSCARID]
@id int
AS
BEGIN
	SELECT * FROM SALA WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SALA_EDITAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SALA_EDITAR]
@id int, @numerodesala int, @capacidad int, @formato varchar(50), @precio float
AS
BEGIN
	UPDATE SALA SET 
		numerodesala = @numerodesala,
		capacidad = @capacidad, 
		formato = @formato,
		precio = @precio
    WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[SALA_FUNCION_BUSCAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SALA_FUNCION_BUSCAR]
@idsala int
AS
BEGIN
	SELECT * FROM SALA_FUNCION WHERE idsala = @idsala
END
GO
/****** Object:  StoredProcedure [dbo].[SALA_FUNCION_INSERTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SALA_FUNCION_INSERTAR]
@idsala int, @idfuncion int
AS
BEGIN
	INSERT INTO SALA_FUNCION VALUES (@idsala, @idfuncion)
END
GO
/****** Object:  StoredProcedure [dbo].[SALA_INSERTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SALA_INSERTAR]
@id int, @numerodesala int, @capacidad int, @formato varchar(50), @precio float
AS
BEGIN
	INSERT INTO SALA VALUES (@id, @numerodesala, @capacidad, @formato, @precio)
END
GO
/****** Object:  StoredProcedure [dbo].[SALA_LISTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SALA_LISTAR]
AS
BEGIN 
	SELECT * FROM SALA
END
GO
/****** Object:  StoredProcedure [dbo].[TABLA_DVV_INSERTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TABLA_DVV_INSERTAR] --Digito verificador vertical
@nombretabla varchar(50), @digitovertical varchar(70)
AS
BEGIN
	IF EXISTS (SELECT * FROM TABLA_DVV WHERE nombretabla = @nombretabla)
	BEGIN
		UPDATE TABLA_DVV SET 
			digitovertical = @digitovertical
		WHERE nombretabla = @nombretabla;
	END
	ELSE
	BEGIN
		INSERT INTO TABLA_DVV VALUES (@nombretabla, @digitovertical);
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_BORRAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USUARIO_BORRAR]
@id int
AS 
BEGIN
	DELETE FROM USUARIOS WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_BUSCAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USUARIO_BUSCAR]
@nombredeusuario varchar(50), @contrasenia varchar(50)
AS
BEGIN
	SELECT * FROM USUARIOS WHERE nombredeusuario = @nombredeusuario AND contrasenia = @contrasenia
END
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_BUSCARID]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USUARIO_BUSCARID]
@id int
AS
BEGIN
	SELECT * FROM USUARIOS WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_EDITAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USUARIO_EDITAR]
@id int, @nombredeusuario varchar(50), @contrasenia varchar(50), @nombre varchar(50), @apellido varchar(50), @correo varchar(50), @ididioma int 
AS 
BEGIN
	update USUARIOS SET 
		nombredeusuario = @nombredeusuario, 
		contrasenia = @contrasenia,
		nombre = @nombre,
		apellido = @apellido,
		correo = @correo,
		ididioma = @ididioma
	WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_INSERTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USUARIO_INSERTAR]
@nombredeusuario varchar(50), @nombre varchar(50), @apellido varchar(50), @contrasenia varchar(50), @correo varchar(50), @ididioma int
AS 
BEGIN
	INSERT INTO USUARIOS VALUES (@nombredeusuario, @nombre, @apellido, @contrasenia, @correo, @ididioma)
END
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_LISTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USUARIO_LISTAR]
AS
BEGIN
	SELECT * FROM USUARIOS
END
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_PERMISO_LISTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USUARIO_PERMISO_LISTAR]
@id int
AS
BEGIN
	SELECT P.* FROM USUARIOS_PERMISOS UP INNER JOIN PERMISOS P ON UP.idpermiso = P.id WHERE idusuario = @id
END
GO
/****** Object:  StoredProcedure [dbo].[USUARIOS_PERMISOS_BORRAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USUARIOS_PERMISOS_BORRAR]
@id int
AS
BEGIN
	DELETE FROM USUARIOS_PERMISOS WHERE idusuario = @id
END
GO
/****** Object:  StoredProcedure [dbo].[USUARIOS_PERMISOS_INSERTAR]    Script Date: 21/11/2024 16:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USUARIOS_PERMISOS_INSERTAR]
@idusuario int, @idpermiso int
AS
BEGIN
	INSERT INTO USUARIOS_PERMISOS VALUES (@idusuario, @idpermiso)
END
GO
USE [master]
GO
ALTER DATABASE [CineProManagerTEST2] SET  READ_WRITE 
GO
