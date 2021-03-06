USE [master]
GO
/****** Object:  Database [db_Attended]    Script Date: 21/03/2022 8:47:33 CH ******/
CREATE DATABASE [db_Attended]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_Attended', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_Attended.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_Attended_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_Attended_log.ldf' , SIZE = 139264KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_Attended] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_Attended].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_Attended] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_Attended] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_Attended] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_Attended] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_Attended] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_Attended] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_Attended] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_Attended] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_Attended] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_Attended] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_Attended] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_Attended] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_Attended] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_Attended] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_Attended] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_Attended] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_Attended] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_Attended] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_Attended] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_Attended] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_Attended] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_Attended] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_Attended] SET RECOVERY FULL 
GO
ALTER DATABASE [db_Attended] SET  MULTI_USER 
GO
ALTER DATABASE [db_Attended] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_Attended] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_Attended] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_Attended] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_Attended] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_Attended] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_Attended', N'ON'
GO
ALTER DATABASE [db_Attended] SET QUERY_STORE = OFF
GO
USE [db_Attended]
GO
/****** Object:  Table [dbo].[tb_Accounts]    Script Date: 21/03/2022 8:47:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Accounts](
	[col_UserID] [varchar](12) NOT NULL,
	[col_Password] [varchar](32) NOT NULL,
	[col_Role] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[col_UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Attended]    Script Date: 21/03/2022 8:47:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Attended](
	[col_Index_Attended] [int] IDENTITY(1,1) NOT NULL,
	[col_DateAtd] [datetime] NOT NULL,
	[col_TimeAtd] [time](7) NOT NULL,
	[col_CoursesID] [int] NOT NULL,
	[col_StudentID] [varchar](10) NOT NULL,
	[col_TeacherID] [varchar](12) NOT NULL,
	[col_RoomID] [varchar](5) NOT NULL,
	[col_Note] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[col_Index_Attended] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_ClassRooms]    Script Date: 21/03/2022 8:47:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ClassRooms](
	[col_RoomID] [varchar](5) NOT NULL,
	[col_RoomName] [nvarchar](50) NULL,
	[col_Capacity] [int] NULL,
	[col_CreateID] [varchar](12) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[col_RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Courses]    Script Date: 21/03/2022 8:47:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Courses](
	[col_CoursesID] [int] IDENTITY(1,1) NOT NULL,
	[col_CoursesName] [nvarchar](50) NOT NULL,
	[col_Semester] [varchar](15) NOT NULL,
	[col_DateStr] [date] NULL,
	[col_DateEnd] [date] NULL,
	[col_DayoWeek] [varchar](10) NULL,
	[col_Status] [nvarchar](30) NULL,
	[col_TeacherID] [varchar](12) NOT NULL,
	[col_RoomID] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[col_CoursesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_RegisterCourses]    Script Date: 21/03/2022 8:47:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_RegisterCourses](
	[col_Index_RegisterCourses] [int] IDENTITY(1,1) NOT NULL,
	[col_CoursesID] [int] NOT NULL,
	[col_StudentID] [varchar](10) NOT NULL,
	[col_Status] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[col_Index_RegisterCourses] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Students]    Script Date: 21/03/2022 8:47:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Students](
	[col_StudentID] [varchar](10) NOT NULL,
	[col_FName] [nvarchar](30) NOT NULL,
	[col_DayoBirth] [date] NOT NULL,
	[col_Major] [nvarchar](40) NULL,
	[col_Email] [varchar](50) NULL,
	[col_Phone] [varchar](10) NULL,
	[col_Sex] [bit] NULL,
	[col_Avatar] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[col_StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Teachers]    Script Date: 21/03/2022 8:47:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Teachers](
	[col_TeacherID] [varchar](12) NOT NULL,
	[col_FName] [nvarchar](30) NOT NULL,
	[col_Department] [nvarchar](100) NULL,
	[col_Email] [varchar](50) NULL,
	[col_Phone] [varchar](10) NULL,
	[col_Sex] [bit] NULL,
	[col_Avatar] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[col_TeacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_Accounts]  WITH CHECK ADD FOREIGN KEY([col_UserID])
REFERENCES [dbo].[tb_Teachers] ([col_TeacherID])
GO
ALTER TABLE [dbo].[tb_Attended]  WITH CHECK ADD FOREIGN KEY([col_CoursesID])
REFERENCES [dbo].[tb_Courses] ([col_CoursesID])
GO
ALTER TABLE [dbo].[tb_Attended]  WITH CHECK ADD FOREIGN KEY([col_RoomID])
REFERENCES [dbo].[tb_ClassRooms] ([col_RoomID])
GO
ALTER TABLE [dbo].[tb_Attended]  WITH CHECK ADD FOREIGN KEY([col_StudentID])
REFERENCES [dbo].[tb_Students] ([col_StudentID])
GO
ALTER TABLE [dbo].[tb_Attended]  WITH CHECK ADD FOREIGN KEY([col_TeacherID])
REFERENCES [dbo].[tb_Teachers] ([col_TeacherID])
GO
ALTER TABLE [dbo].[tb_ClassRooms]  WITH CHECK ADD FOREIGN KEY([col_CreateID])
REFERENCES [dbo].[tb_Teachers] ([col_TeacherID])
GO
ALTER TABLE [dbo].[tb_Courses]  WITH CHECK ADD FOREIGN KEY([col_RoomID])
REFERENCES [dbo].[tb_ClassRooms] ([col_RoomID])
GO
ALTER TABLE [dbo].[tb_Courses]  WITH CHECK ADD FOREIGN KEY([col_TeacherID])
REFERENCES [dbo].[tb_Teachers] ([col_TeacherID])
GO
ALTER TABLE [dbo].[tb_RegisterCourses]  WITH CHECK ADD FOREIGN KEY([col_CoursesID])
REFERENCES [dbo].[tb_Courses] ([col_CoursesID])
GO
ALTER TABLE [dbo].[tb_RegisterCourses]  WITH CHECK ADD FOREIGN KEY([col_StudentID])
REFERENCES [dbo].[tb_Students] ([col_StudentID])
GO
USE [master]
GO
ALTER DATABASE [db_Attended] SET  READ_WRITE 
GO
