USE [master]
GO
/****** Object:  Database [dbcliente]    Script Date: 31/08/2018 11:30:43 ******/
CREATE DATABASE [dbcliente]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbcliente', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\dbcliente.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbcliente_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\dbcliente_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbcliente] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbcliente].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbcliente] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbcliente] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbcliente] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbcliente] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbcliente] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbcliente] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [dbcliente] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbcliente] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbcliente] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbcliente] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbcliente] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbcliente] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbcliente] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbcliente] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbcliente] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbcliente] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbcliente] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbcliente] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbcliente] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbcliente] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbcliente] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbcliente] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbcliente] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbcliente] SET  MULTI_USER 
GO
ALTER DATABASE [dbcliente] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbcliente] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbcliente] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbcliente] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbcliente] SET DELAYED_DURABILITY = DISABLED 
GO
USE [dbcliente]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 31/08/2018 11:30:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[clientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](30) NOT NULL,
	[sobrenome] [varchar](100) NOT NULL,
	[cpf] [varchar](11) NOT NULL,
	[data_nascimento] [date] NOT NULL,
	[idade] [int] NOT NULL,
	[profissao_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[profissao]    Script Date: 31/08/2018 11:30:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[profissao](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cargo] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[clientes] ON 

INSERT [dbo].[clientes] ([id], [nome], [sobrenome], [cpf], [data_nascimento], [idade], [profissao_id]) VALUES (1, N'Thiago', N'Ito', N'39605081822', CAST(N'1989-07-25' AS Date), 29, 1)
SET IDENTITY_INSERT [dbo].[clientes] OFF
SET IDENTITY_INSERT [dbo].[profissao] ON 

INSERT [dbo].[profissao] ([id], [cargo]) VALUES (1, N'Programador')
INSERT [dbo].[profissao] ([id], [cargo]) VALUES (2, N'Estagiário')
INSERT [dbo].[profissao] ([id], [cargo]) VALUES (3, N'Analista')
INSERT [dbo].[profissao] ([id], [cargo]) VALUES (4, N'Gerente')
INSERT [dbo].[profissao] ([id], [cargo]) VALUES (5, N'QA')
SET IDENTITY_INSERT [dbo].[profissao] OFF
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD FOREIGN KEY([profissao_id])
REFERENCES [dbo].[profissao] ([id])
GO
USE [master]
GO
ALTER DATABASE [dbcliente] SET  READ_WRITE 
GO
