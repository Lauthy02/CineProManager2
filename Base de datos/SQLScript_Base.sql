USE [master]
GO
/****** Object:  Database [CineProManagerTEST2]    Script Date: 27/5/2024 13:39:19 ******/
CREATE DATABASE [CineProManagerTEST2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CineProManagerTEST2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CineProManagerTEST2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
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
/****** Object:  Table [dbo].[PERMISOS]    Script Date: 27/5/2024 13:39:20 ******/
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
/****** Object:  Table [dbo].[PERMISOS_PERMISOS]    Script Date: 27/5/2024 13:39:20 ******/
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
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 27/5/2024 13:39:20 ******/
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
 CONSTRAINT [PK_USUARIO] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOS_PERMISOS]    Script Date: 27/5/2024 13:39:20 ******/
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
SET IDENTITY_INSERT [dbo].[PERMISOS] ON 
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1, N'IngresarAVentas', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (2, N'VerVenta', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (3, N'Administrador', NULL)
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (4, N'Taquillero', NULL)
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (6, N'LimpiarCine', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (7, N'Limpiador', NULL)
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (8, N'Test', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (9, N'GestionarPermisosUsuarios', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (10, N'GestionarPermisos', N'Accion')
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1006, N'Gerente de cine', NULL)
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1007, N'Supervisor de salas', NULL)
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1008, N'Operador de proyeccion', NULL)
GO
INSERT [dbo].[PERMISOS] ([id], [nombre], [tipo]) VALUES (1009, N'Usuario', NULL)
GO
SET IDENTITY_INSERT [dbo].[PERMISOS] OFF
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 1)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 4)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 7)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 9)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (3, 10)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (4, 1)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (7, 6)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (1006, 9)
GO
INSERT [dbo].[PERMISOS_PERMISOS] ([idpermisopadre], [idpermisohijo]) VALUES (1006, 10)
GO
SET IDENTITY_INSERT [dbo].[USUARIOS] ON 
GO
INSERT [dbo].[USUARIOS] ([id], [nombredeusuario], [nombre], [apellido], [contrasenia], [correo]) VALUES (1, N'Lauta', N'Lautaro', N'Rojas', N'MQAyADMANAA=', N'lautaro.rojas02@gmail.com')
GO
INSERT [dbo].[USUARIOS] ([id], [nombredeusuario], [nombre], [apellido], [contrasenia], [correo]) VALUES (2, N'MaxV', N'Max', N'Verstappen', N'MQAyADMANAA=', N'max.verstappen@gmail.com')
GO
INSERT [dbo].[USUARIOS] ([id], [nombredeusuario], [nombre], [apellido], [contrasenia], [correo]) VALUES (4, N'Nano', N'Fernando', N'Alonso', N'MQAyADMANAA=', N'fernando.alonso@gmail.com')
GO
INSERT [dbo].[USUARIOS] ([id], [nombredeusuario], [nombre], [apellido], [contrasenia], [correo]) VALUES (5, N'Checo', N'Sergio', N'Perez', N'MQAyADMANAA=', N'sergio.perez@gmail.com')
GO
INSERT [dbo].[USUARIOS] ([id], [nombredeusuario], [nombre], [apellido], [contrasenia], [correo]) VALUES (1005, N'CharLec', N'Charles', N'Leclerc', N'MQAyADMANAA=', N'charles.leclerc@gmail.com')
GO
INSERT [dbo].[USUARIOS] ([id], [nombredeusuario], [nombre], [apellido], [contrasenia], [correo]) VALUES (1006, N'Nor', N'Lando', N'Norris', N'NQA2ADcAOAA=', N'lando.norris@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[USUARIOS] OFF
GO
INSERT [dbo].[USUARIOS_PERMISOS] ([idusuario], [idpermiso]) VALUES (1, 3)
GO
INSERT [dbo].[USUARIOS_PERMISOS] ([idusuario], [idpermiso]) VALUES (1, 4)
GO
INSERT [dbo].[USUARIOS_PERMISOS] ([idusuario], [idpermiso]) VALUES (2, 1006)
GO
INSERT [dbo].[USUARIOS_PERMISOS] ([idusuario], [idpermiso]) VALUES (1005, 4)
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
/****** Object:  StoredProcedure [dbo].[ACCION_LISTAR]    Script Date: 27/5/2024 13:39:20 ******/
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
/****** Object:  StoredProcedure [dbo].[PERMISO_INSERTAR]    Script Date: 27/5/2024 13:39:20 ******/
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
/****** Object:  StoredProcedure [dbo].[PERMISO_LISTAR_RECURSIVO]    Script Date: 27/5/2024 13:39:20 ******/
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
/****** Object:  StoredProcedure [dbo].[PERMISO_PERMISO_BORRAR]    Script Date: 27/5/2024 13:39:20 ******/
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
/****** Object:  StoredProcedure [dbo].[PERMISO_PERMISO_INSERTAR]    Script Date: 27/5/2024 13:39:20 ******/
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
/****** Object:  StoredProcedure [dbo].[ROL_LISTAR]    Script Date: 27/5/2024 13:39:20 ******/
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
/****** Object:  StoredProcedure [dbo].[USUARIO_BORRAR]    Script Date: 27/5/2024 13:39:20 ******/
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
/****** Object:  StoredProcedure [dbo].[USUARIO_BUSCAR]    Script Date: 27/5/2024 13:39:20 ******/
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
/****** Object:  StoredProcedure [dbo].[USUARIO_EDITAR]    Script Date: 27/5/2024 13:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USUARIO_EDITAR]
@id int, @nombredeusuario varchar(50), @contrasenia varchar(50), @nombre varchar(50), @apellido varchar(50), @correo varchar(50) 
AS 
BEGIN
	update USUARIOS SET 
		nombredeusuario = @nombredeusuario, 
		contrasenia = @contrasenia,
		nombre = @nombre,
		apellido = @apellido,
		correo = @correo
	WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_INSERTAR]    Script Date: 27/5/2024 13:39:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USUARIO_INSERTAR]
@nombredeusuario varchar(50), @nombre varchar(50), @apellido varchar(50), @contrasenia varchar(50), @correo varchar(50)
AS 
BEGIN
	INSERT INTO USUARIOS VALUES (@nombredeusuario, @nombre, @apellido, @contrasenia, @correo)
END
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_LISTAR]    Script Date: 27/5/2024 13:39:20 ******/
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
/****** Object:  StoredProcedure [dbo].[USUARIO_PERMISO_LISTAR]    Script Date: 27/5/2024 13:39:20 ******/
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
/****** Object:  StoredProcedure [dbo].[USUARIOS_PERMISOS_BORRAR]    Script Date: 27/5/2024 13:39:20 ******/
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
/****** Object:  StoredProcedure [dbo].[USUARIOS_PERMISOS_INSERTAR]    Script Date: 27/5/2024 13:39:20 ******/
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
