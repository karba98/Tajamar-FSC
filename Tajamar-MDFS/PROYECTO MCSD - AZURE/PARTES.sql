USE [master]
GO
/****** Object:  Database [PARTES]    Script Date: 17/02/2021 13:27:13 ******/
CREATE DATABASE [PARTES]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PARTES', FILENAME = N'E:\MCSD\SQLServer\MSSQL15.MSSQLSERVER\MSSQL\DATA\PARTES.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PARTES_log', FILENAME = N'E:\MCSD\SQLServer\MSSQL15.MSSQLSERVER\MSSQL\DATA\PARTES_log.ldf' , SIZE = 139264KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PARTES] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PARTES].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PARTES] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PARTES] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PARTES] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PARTES] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PARTES] SET ARITHABORT OFF 
GO
ALTER DATABASE [PARTES] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PARTES] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PARTES] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PARTES] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PARTES] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PARTES] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PARTES] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PARTES] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PARTES] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PARTES] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PARTES] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PARTES] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PARTES] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PARTES] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PARTES] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PARTES] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PARTES] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PARTES] SET RECOVERY FULL 
GO
ALTER DATABASE [PARTES] SET  MULTI_USER 
GO
ALTER DATABASE [PARTES] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PARTES] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PARTES] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PARTES] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PARTES] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PARTES] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PARTES', N'ON'
GO
ALTER DATABASE [PARTES] SET QUERY_STORE = OFF
GO
USE [PARTES]
GO
/****** Object:  Table [dbo].[partes]    Script Date: 17/02/2021 13:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[partes](
	[N_Parte] [varchar](40) NOT NULL,
	[Envios] [varchar](255) NOT NULL,
	[Bult] [int] NOT NULL,
	[F_Albaran] [date] NOT NULL,
	[Orig] [varchar](255) NOT NULL,
	[Dest] [varchar](255) NOT NULL,
	[Propi] [varchar](255) NOT NULL,
	[Serv] [varchar](45) NOT NULL,
	[Abonado] [varchar](255) NOT NULL,
	[Tipo] [varchar](255) NOT NULL,
	[Estado] [varchar](255) NOT NULL,
	[Gestor] [varchar](255) NOT NULL,
	[Resolucion] [varchar](255) NOT NULL,
	[Fecha_parte] [date] NOT NULL,
	[Tiempo] [varchar](255) NULL,
	[Accion] [varchar](500) NOT NULL,
	[F_Resolucion] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[N_Parte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 17/02/2021 13:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[ID] [int] NOT NULL,
	[Username] [nvarchar](255) NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[Nombre] [nvarchar](255) NOT NULL,
	[Apellido] [nvarchar](255) NOT NULL,
	[Password] [varbinary](max) NOT NULL,
	[Salt] [nvarchar](500) NOT NULL,
	[ROL] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[users] ([ID], [Username], [Email], [Nombre], [Apellido], [Password], [Salt], [ROL]) VALUES (6, N'admin', N'admin@admin.es', N'Admin', N'Admin', 0xBB710CDA7F37983CE2D065B89D750C12D242EDE5125FAE7EAF310688B762100A, N'᫂ᑾ֘᠕ഺᦜǨᡂ⌉⌫⍙ᬸ᧦๵↢އޜ◫Ἑ⁸ᵂࡻ⁚Ǡୌᔪᛓ൒♾ᤖ₥Ԛ²⏽րᡯ࢛Ꮜ⃗֨ᅵᤨᚓ፟ጌೠ⇫ᔷᑢ᫙զɹ໋"ቇᬳθ೉἞ˈᮤᣒ৳ʅḾ᪆᳸ࣵळ◻۽ሞ║᫐ௌᙡ৆ᖐ὎ࡊ᯷Ἢሜ╋ᬿʠᣵ⏛ᩇ⑊Ӣ᫤ᮽḏᄒᾱ༵ᐎᰯᾕᛷ᣶ఄᕵᏜᩖзᬉ᭤⋴ᅬᔷᒊᛔෟ⎉ڶஶ๕ᮝƐ‫ᖼ௷℘ጧᵰ݁ঽጪܬ᳆⁯⛇ᡢ́ጥ⎵ᅯè╸⓺ࡷṡዞᚺٚӨုᒘ᣻;ֹḅ̹ᷚ᭬´⏵␄ᅌ࠺ᯈ᮵ᯖᓑ▁૞ၣਏ⅖൬ᴴΤ឴Ṫ ੝್ᢈḡᰴℽήᜍ῞ࣂ↖⛖ጙࡉႺЂŴᎮ=ʙ', N'A')
GO
USE [master]
GO
ALTER DATABASE [PARTES] SET  READ_WRITE 
GO
