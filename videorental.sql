USE [master]
GO

/****** Object:  Database [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF]    Script Date: 14/12/2018 5:11:04 PM ******/
CREATE DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VBMoviesFullData', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VBMoviesFullData.mdf' , SIZE = 9216KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VBMoviesFullData_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VBMoviesFullData_log.ldf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET ARITHABORT OFF 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET  DISABLE_BROKER 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET  MULTI_USER 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET DB_CHAINING OFF 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET QUERY_STORE = OFF
GO

ALTER DATABASE [C:\USERS\ADMIN\DESKTOP\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\MOVIE-RENTAL-MANAGEMENT-SYSTEM-MASTER\DATA\VBMOVIESFULLDATA.MDF] SET  READ_WRITE 
GO

