/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4224)
    Source Database Engine Edition : Microsoft SQL Server Enterprise Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [MovieCollection]    Script Date: 2018-10-03 17:31:31 ******/
CREATE DATABASE [MovieCollection]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MovieCollection', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\MovieCollection.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MovieCollection_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\MovieCollection_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MovieCollection] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MovieCollection].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MovieCollection] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MovieCollection] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MovieCollection] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MovieCollection] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MovieCollection] SET ARITHABORT OFF 
GO
ALTER DATABASE [MovieCollection] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MovieCollection] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MovieCollection] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MovieCollection] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MovieCollection] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MovieCollection] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MovieCollection] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MovieCollection] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MovieCollection] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MovieCollection] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MovieCollection] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MovieCollection] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MovieCollection] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MovieCollection] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MovieCollection] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MovieCollection] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MovieCollection] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MovieCollection] SET RECOVERY FULL 
GO
ALTER DATABASE [MovieCollection] SET  MULTI_USER 
GO
ALTER DATABASE [MovieCollection] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MovieCollection] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MovieCollection] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MovieCollection] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MovieCollection] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MovieCollection', N'ON'
GO
ALTER DATABASE [MovieCollection] SET QUERY_STORE = OFF
GO
USE [MovieCollection]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [MovieCollection]
GO
/****** Object:  Table [dbo].[ActorDirector]    Script Date: 2018-10-03 17:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActorDirector](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IsActor] [bit] NOT NULL,
	[IsDirector] [bit] NOT NULL,
 CONSTRAINT [PK_ActorDirector] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 2018-10-03 17:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[Id] [uniqueidentifier] NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[IsUrlRequired] [bit] NOT NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie]    Script Date: 2018-10-03 17:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie](
	[Id] [uniqueidentifier] NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Year] [int] NULL,
	[ActorId] [uniqueidentifier] NULL,
	[DirectorId] [uniqueidentifier] NULL,
	[LocationId] [uniqueidentifier] NOT NULL,
	[LocationUrl] [varchar](2083) NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[MovieResult]    Script Date: 2018-10-03 17:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[MovieResult]
AS
SELECT        dbo.Movie.Id, dbo.Movie.Title, dbo.Movie.Year, Actor.Id AS ActorId, Actor.Name AS ActorName, Director.Id AS DirectorId, Director.Name AS DirectorName, Location.Id AS LocationId, dbo.Location.Description AS LocationDescription, dbo.Movie.LocationUrl
FROM            dbo.Movie LEFT JOIN
                         dbo.ActorDirector AS Actor ON dbo.Movie.ActorId = Actor.Id LEFT JOIN
						 dbo.ActorDirector AS Director ON dbo.Movie.DirectorId = Director.Id INNER JOIN
                         dbo.Location ON dbo.Movie.LocationId = dbo.Location.Id
GO
/****** Object:  Index [IX_ActorDirector_IsActor]    Script Date: 2018-10-03 17:31:31 ******/
CREATE NONCLUSTERED INDEX [IX_ActorDirector_IsActor] ON [dbo].[ActorDirector]
(
	[IsActor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ActorDirector_IsDirector]    Script Date: 2018-10-03 17:31:31 ******/
CREATE NONCLUSTERED INDEX [IX_ActorDirector_IsDirector] ON [dbo].[ActorDirector]
(
	[IsDirector] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ActorDirector_Name]    Script Date: 2018-10-03 17:31:31 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_ActorDirector_Name] ON [dbo].[ActorDirector]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Location_Description]    Script Date: 2018-10-03 17:31:31 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Location_Description] ON [dbo].[Location]
(
	[Description] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ActorDirector] ADD  CONSTRAINT [DF_Actor_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[ActorDirector] ADD  CONSTRAINT [DF_ActorDirector_IsActor]  DEFAULT ((0)) FOR [IsActor]
GO
ALTER TABLE [dbo].[ActorDirector] ADD  CONSTRAINT [DF_ActorDirector_IsDirector]  DEFAULT ((0)) FOR [IsDirector]
GO
ALTER TABLE [dbo].[Location] ADD  CONSTRAINT [DF_Location_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Location] ADD  CONSTRAINT [DF_Location_IsUrlRequired]  DEFAULT ((0)) FOR [IsUrlRequired]
GO
ALTER TABLE [dbo].[Movie] ADD  CONSTRAINT [DF_Movie_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Movie]  WITH CHECK ADD  CONSTRAINT [FK_Movie_Actor] FOREIGN KEY([ActorId])
REFERENCES [dbo].[ActorDirector] ([Id])
GO
ALTER TABLE [dbo].[Movie] CHECK CONSTRAINT [FK_Movie_Actor]
GO
ALTER TABLE [dbo].[Movie]  WITH CHECK ADD  CONSTRAINT [FK_Movie_Director] FOREIGN KEY([DirectorId])
REFERENCES [dbo].[ActorDirector] ([Id])
GO
ALTER TABLE [dbo].[Movie] CHECK CONSTRAINT [FK_Movie_Director]
GO
ALTER TABLE [dbo].[Movie]  WITH CHECK ADD  CONSTRAINT [FK_Movie_Location] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Location] ([Id])
GO
ALTER TABLE [dbo].[Movie] CHECK CONSTRAINT [FK_Movie_Location]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Movie"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 172
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Actor"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 102
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Location"
            Begin Extent = 
               Top = 195
               Left = 232
               Bottom = 308
               Right = 402
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MovieResult'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MovieResult'
GO
USE [master]
GO
ALTER DATABASE [MovieCollection] SET  READ_WRITE 
GO
