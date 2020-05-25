USE [master]
GO
/****** Object:  Database [BDMatricula]    Script Date: 24/05/2020 22:29:34 ******/
CREATE DATABASE [BDMatricula]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDMatricula', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BDMatricula.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BDMatricula_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BDMatricula_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BDMatricula] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDMatricula].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDMatricula] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDMatricula] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDMatricula] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDMatricula] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDMatricula] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDMatricula] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BDMatricula] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDMatricula] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDMatricula] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDMatricula] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDMatricula] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDMatricula] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDMatricula] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDMatricula] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDMatricula] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BDMatricula] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDMatricula] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDMatricula] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDMatricula] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDMatricula] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDMatricula] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDMatricula] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDMatricula] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BDMatricula] SET  MULTI_USER 
GO
ALTER DATABASE [BDMatricula] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDMatricula] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDMatricula] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDMatricula] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BDMatricula] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BDMatricula]
GO
/****** Object:  Table [dbo].[Asignatura]    Script Date: 24/05/2020 22:29:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Asignatura](
	[IdAsignatura] [int] NOT NULL,
	[CodAsig] [int] NOT NULL,
	[NombreAsig] [varchar](100) NOT NULL,
	[CantHoras] [decimal](3, 2) NOT NULL,
	[Creditos] [int] NOT NULL,
 CONSTRAINT [PK_Asignatura] PRIMARY KEY CLUSTERED 
(
	[IdAsignatura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Carrera]    Script Date: 24/05/2020 22:29:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Carrera](
	[IdCarrera] [int] NOT NULL,
	[NombreCarre] [varchar](100) NOT NULL,
	[Facultad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Carrera] PRIMARY KEY CLUSTERED 
(
	[IdCarrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ciclo]    Script Date: 24/05/2020 22:29:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ciclo](
	[IdCiclo] [int] NOT NULL,
	[Ciclo] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Ciclo] PRIMARY KEY CLUSTERED 
(
	[IdCiclo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DetalleMatricula]    Script Date: 24/05/2020 22:29:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleMatricula](
	[IdMatricula] [int] NOT NULL,
	[Item] [int] NOT NULL,
	[IdAsignatura] [int] NOT NULL,
	[IdCiclo] [int] NOT NULL,
	[Vez] [int] NULL,
	[IdDocente] [int] NOT NULL,
 CONSTRAINT [PK_DetalleMatricula] PRIMARY KEY CLUSTERED 
(
	[IdMatricula] ASC,
	[Item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Docente]    Script Date: 24/05/2020 22:29:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Docente](
	[IdDocente] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellidos] [varchar](50) NOT NULL,
	[DNI] [char](8) NOT NULL,
	[Especialidad] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[Telefono] [varchar](11) NULL,
 CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED 
(
	[IdDocente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 24/05/2020 22:29:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estudiante](
	[IdEstudiante] [int] NOT NULL,
	[CodigoE] [char](10) NOT NULL,
	[NombresE] [varchar](50) NOT NULL,
	[ApellidosE] [varchar](50) NOT NULL,
	[DNIE] [char](8) NOT NULL,
	[SexoE] [char](9) NOT NULL,
	[FechNacimientoE] [smalldatetime] NOT NULL,
	[IdCarrera] [int] NULL,
	[Email] [varchar](100) NULL,
	[Telefono] [varchar](11) NULL,
 CONSTRAINT [PK_Estudiante] PRIMARY KEY CLUSTERED 
(
	[IdEstudiante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Periodo]    Script Date: 24/05/2020 22:29:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Periodo](
	[IdPeriodo] [int] NOT NULL,
	[Periodo] [varchar](10) NOT NULL,
	[FechaIni] [smalldatetime] NOT NULL,
	[FechaFin] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Periodo] PRIMARY KEY CLUSTERED 
(
	[IdPeriodo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ReservaMatricula]    Script Date: 24/05/2020 22:29:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservaMatricula](
	[IdMatricula] [int] NOT NULL,
	[Fecha] [smalldatetime] NOT NULL,
	[IdPeriodo] [int] NULL,
	[IdEstudiante] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Pago] [money] NULL,
 CONSTRAINT [PK_Matricula] PRIMARY KEY CLUSTERED 
(
	[IdMatricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 24/05/2020 22:29:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] NOT NULL,
	[Usuario] [varchar](15) NOT NULL,
	[ClaveUsu] [varchar](max) NOT NULL,
	[PerfilUsu] [varchar](30) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[Telefono] [varchar](11) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[DetalleMatricula]  WITH CHECK ADD  CONSTRAINT [FK_DetalleMatricula_Asignatura] FOREIGN KEY([IdAsignatura])
REFERENCES [dbo].[Asignatura] ([IdAsignatura])
GO
ALTER TABLE [dbo].[DetalleMatricula] CHECK CONSTRAINT [FK_DetalleMatricula_Asignatura]
GO
ALTER TABLE [dbo].[DetalleMatricula]  WITH CHECK ADD  CONSTRAINT [FK_DetalleMatricula_Ciclo] FOREIGN KEY([IdCiclo])
REFERENCES [dbo].[Ciclo] ([IdCiclo])
GO
ALTER TABLE [dbo].[DetalleMatricula] CHECK CONSTRAINT [FK_DetalleMatricula_Ciclo]
GO
ALTER TABLE [dbo].[DetalleMatricula]  WITH CHECK ADD  CONSTRAINT [FK_DetalleMatricula_Docente] FOREIGN KEY([IdDocente])
REFERENCES [dbo].[Docente] ([IdDocente])
GO
ALTER TABLE [dbo].[DetalleMatricula] CHECK CONSTRAINT [FK_DetalleMatricula_Docente]
GO
ALTER TABLE [dbo].[DetalleMatricula]  WITH CHECK ADD  CONSTRAINT [FK_DetalleMatricula_Matricula] FOREIGN KEY([IdMatricula])
REFERENCES [dbo].[ReservaMatricula] ([IdMatricula])
GO
ALTER TABLE [dbo].[DetalleMatricula] CHECK CONSTRAINT [FK_DetalleMatricula_Matricula]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_Estudiante_Carrera] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carrera] ([IdCarrera])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_Estudiante_Carrera]
GO
ALTER TABLE [dbo].[ReservaMatricula]  WITH CHECK ADD  CONSTRAINT [FK_Matricula_Estudiante] FOREIGN KEY([IdEstudiante])
REFERENCES [dbo].[Estudiante] ([IdEstudiante])
GO
ALTER TABLE [dbo].[ReservaMatricula] CHECK CONSTRAINT [FK_Matricula_Estudiante]
GO
ALTER TABLE [dbo].[ReservaMatricula]  WITH CHECK ADD  CONSTRAINT [FK_Matricula_Periodo] FOREIGN KEY([IdPeriodo])
REFERENCES [dbo].[Periodo] ([IdPeriodo])
GO
ALTER TABLE [dbo].[ReservaMatricula] CHECK CONSTRAINT [FK_Matricula_Periodo]
GO
ALTER TABLE [dbo].[ReservaMatricula]  WITH CHECK ADD  CONSTRAINT [FK_Matricula_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[ReservaMatricula] CHECK CONSTRAINT [FK_Matricula_Usuario]
GO
USE [master]
GO
ALTER DATABASE [BDMatricula] SET  READ_WRITE 
GO
