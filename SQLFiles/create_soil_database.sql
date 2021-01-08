USE [master]
GO
/****** Object:  Database [Soil]    Script Date: 1/8/2021 12:48:37 PM ******/
CREATE DATABASE [Soil]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Soil', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Soil.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Soil_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Soil_log.ldf' , SIZE = 270336KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Soil] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Soil].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Soil] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Soil] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Soil] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Soil] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Soil] SET ARITHABORT OFF 
GO
ALTER DATABASE [Soil] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Soil] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Soil] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Soil] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Soil] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Soil] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Soil] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Soil] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Soil] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Soil] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Soil] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Soil] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Soil] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Soil] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Soil] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Soil] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Soil] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Soil] SET RECOVERY FULL 
GO
ALTER DATABASE [Soil] SET  MULTI_USER 
GO
ALTER DATABASE [Soil] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Soil] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Soil] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Soil] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Soil] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Soil] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Soil', N'ON'
GO
ALTER DATABASE [Soil] SET QUERY_STORE = OFF
GO
USE [Soil]
GO
/****** Object:  Table [dbo].[Analyses]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Analyses](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Timestamp] [datetime] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Analyses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnalysesNutrients]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnalysesNutrients](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[AnalysisId] [int] NOT NULL,
	[NutrientId] [int] NOT NULL,
	[Level] [decimal](8, 3) NOT NULL,
 CONSTRAINT [PK_AnalysesNutrients] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DimensionedQuantities]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DimensionedQuantities](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TypeId] [int] NOT NULL,
	[UnitId] [int] NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DimensionedQuantities] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_DimensionedQuantities] UNIQUE NONCLUSTERED 
(
	[ItemName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DimensionedTypes]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DimensionedTypes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DimensionedTypes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fields]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fields](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Farm] [varchar](25) NOT NULL,
	[Field] [char](3) NOT NULL,
 CONSTRAINT [PK_Fields] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FieldsNutrients]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FieldsNutrients](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FieldId] [int] NOT NULL,
	[NutrientId] [int] NOT NULL,
	[Level] [decimal](8, 3) NOT NULL,
	[Goal] [int] NOT NULL,
 CONSTRAINT [PK_FieldsNutrients] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Operations]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operations](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FieldId] [int] NOT NULL,
	[AnalysisId] [int] NOT NULL,
	[Timestamp] [datetime] NOT NULL,
	[Amount] [decimal](8, 3) NOT NULL,
 CONSTRAINT [PK_Operations] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rotations]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rotations](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FieldId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Year] [int] NOT NULL,
 CONSTRAINT [PK_Rotations] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_FieldYear] UNIQUE NONCLUSTERED 
(
	[FieldId] ASC,
	[Year] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SoilSamples]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SoilSamples](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FieldId] [int] NOT NULL,
	[Timestamp] [datetime] NOT NULL,
 CONSTRAINT [PK_SoilSamples] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SoilSamplesNutrients]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SoilSamplesNutrients](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SampleId] [int] NOT NULL,
	[NutrientId] [int] NOT NULL,
	[Level] [decimal](8, 3) NOT NULL,
	[Recommendation] [int] NOT NULL,
 CONSTRAINT [PK_SoilSamplesNutrients] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Units]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Units](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Unit] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Units] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Units] UNIQUE NONCLUSTERED 
(
	[Unit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_FarmField]    Script Date: 1/8/2021 12:48:37 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UK_FarmField] ON [dbo].[Fields]
(
	[Farm] ASC,
	[Field] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Analyses]  WITH CHECK ADD  CONSTRAINT [FK_Analyses_DimensionedQuantities] FOREIGN KEY([ProductId])
REFERENCES [dbo].[DimensionedQuantities] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Analyses] CHECK CONSTRAINT [FK_Analyses_DimensionedQuantities]
GO
ALTER TABLE [dbo].[AnalysesNutrients]  WITH CHECK ADD  CONSTRAINT [FK_AnalysesNutrients_Analyses] FOREIGN KEY([AnalysisId])
REFERENCES [dbo].[Analyses] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[AnalysesNutrients] CHECK CONSTRAINT [FK_AnalysesNutrients_Analyses]
GO
ALTER TABLE [dbo].[AnalysesNutrients]  WITH CHECK ADD  CONSTRAINT [FK_AnalysesNutrients_DimensionedQuantities] FOREIGN KEY([NutrientId])
REFERENCES [dbo].[DimensionedTypes] ([id])
GO
ALTER TABLE [dbo].[AnalysesNutrients] CHECK CONSTRAINT [FK_AnalysesNutrients_DimensionedQuantities]
GO
ALTER TABLE [dbo].[DimensionedQuantities]  WITH NOCHECK ADD  CONSTRAINT [FK_DimensionedQuantities_Typs] FOREIGN KEY([TypeId])
REFERENCES [dbo].[DimensionedTypes] ([id])
GO
ALTER TABLE [dbo].[DimensionedQuantities] CHECK CONSTRAINT [FK_DimensionedQuantities_Typs]
GO
ALTER TABLE [dbo].[DimensionedQuantities]  WITH NOCHECK ADD  CONSTRAINT [FK_DimensionedQuantities_Units] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Units] ([id])
GO
ALTER TABLE [dbo].[DimensionedQuantities] CHECK CONSTRAINT [FK_DimensionedQuantities_Units]
GO
ALTER TABLE [dbo].[FieldsNutrients]  WITH CHECK ADD  CONSTRAINT [FK_FieldsNutrients_DimensionedQuantities] FOREIGN KEY([NutrientId])
REFERENCES [dbo].[DimensionedQuantities] ([id])
GO
ALTER TABLE [dbo].[FieldsNutrients] CHECK CONSTRAINT [FK_FieldsNutrients_DimensionedQuantities]
GO
ALTER TABLE [dbo].[FieldsNutrients]  WITH CHECK ADD  CONSTRAINT [FK_FieldsNutrients_Fields] FOREIGN KEY([FieldId])
REFERENCES [dbo].[Fields] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[FieldsNutrients] CHECK CONSTRAINT [FK_FieldsNutrients_Fields]
GO
ALTER TABLE [dbo].[Operations]  WITH CHECK ADD  CONSTRAINT [FK_Operations_Analyses] FOREIGN KEY([AnalysisId])
REFERENCES [dbo].[Analyses] ([id])
GO
ALTER TABLE [dbo].[Operations] CHECK CONSTRAINT [FK_Operations_Analyses]
GO
ALTER TABLE [dbo].[Rotations]  WITH CHECK ADD  CONSTRAINT [FK_Rotations_DimensionedQuantities] FOREIGN KEY([ProductId])
REFERENCES [dbo].[DimensionedQuantities] ([id])
GO
ALTER TABLE [dbo].[Rotations] CHECK CONSTRAINT [FK_Rotations_DimensionedQuantities]
GO
ALTER TABLE [dbo].[Rotations]  WITH CHECK ADD  CONSTRAINT [FK_Rotations_Fields] FOREIGN KEY([FieldId])
REFERENCES [dbo].[Fields] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Rotations] CHECK CONSTRAINT [FK_Rotations_Fields]
GO
ALTER TABLE [dbo].[SoilSamples]  WITH CHECK ADD  CONSTRAINT [FK_SoilSamples_Fields] FOREIGN KEY([FieldId])
REFERENCES [dbo].[Fields] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SoilSamples] CHECK CONSTRAINT [FK_SoilSamples_Fields]
GO
ALTER TABLE [dbo].[SoilSamplesNutrients]  WITH CHECK ADD  CONSTRAINT [FK_SoilSamplesNutrients_DimensionedQuantities] FOREIGN KEY([NutrientId])
REFERENCES [dbo].[DimensionedQuantities] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SoilSamplesNutrients] CHECK CONSTRAINT [FK_SoilSamplesNutrients_DimensionedQuantities]
GO
ALTER TABLE [dbo].[SoilSamplesNutrients]  WITH CHECK ADD  CONSTRAINT [FK_SoilSamplesNutrients_SoilSamples] FOREIGN KEY([SampleId])
REFERENCES [dbo].[SoilSamples] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SoilSamplesNutrients] CHECK CONSTRAINT [FK_SoilSamplesNutrients_SoilSamples]
GO
/****** Object:  StoredProcedure [dbo].[spDimensionedQuantities_GetAllByType]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spDimensionedQuantities_GetAllByType] 
	-- Add the parameters for the stored procedure here
	@TypeId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT dq.* 
	from dbo.DimensionedQuantities dq
	inner join dbo.DimensionedTypes dt on dt.id = dq.TypeId
	inner join dbo.Units u on u.id = dq.UnitId
	where dt.id = @TypeId
END
GO
/****** Object:  StoredProcedure [dbo].[spDimensionedQuantities_Insert]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spDimensionedQuantities_Insert]
	-- Add the parameters for the stored procedure here
	@QuantityName varchar(50),
	@UnitId int,
	@TypeId int,
	@id int=0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.DimensionedQuantities (ItemName, UnitId, TypeId) VALUES (@QuantityName, @UnitId, @TypeId);

	SELECT @id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spDimensionedTypes_GetAll]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spDimensionedTypes_GetAll] 
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from dbo.DimensionedTypes;
END
GO
/****** Object:  StoredProcedure [dbo].[spDimensionedTypes_GetByName]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spDimensionedTypes_GetByName] 
	-- Add the parameters for the stored procedure here
	@Type varchar(50),
	@id int=0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SET @id = (SELECT id from dbo.DimensionedTypes where Type = @Type);
END
GO
/****** Object:  StoredProcedure [dbo].[spFields_Upsert]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spFields_Upsert] 
	-- Add the parameters for the stored procedure here
	@FarmName varchar(25),
	@Field char(3),
	@id int=0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	BEGIN TRANSACTION;
	UPDATE dbo.Fields SET Farm = @FarmName, Field=@Field WHERE dbo.Fields.id = @id;
	IF @@ROWCOUNT = 0
	BEGIN
		INSERT INTO dbo.Fields (Farm, Field) VALUES (@FarmName, @Field);
		SELECT @id = SCOPE_IDENTITY();
	END
	COMMIT TRANSACTION;
END
GO
/****** Object:  StoredProcedure [dbo].[spRotations_GetAllAfterYear]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spRotations_GetAllAfterYear] 
	-- Add the parameters for the stored procedure here
	@Year int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT f.*, r.Year, p.ItemName, u.Unit 
	from Fields f
	inner join [dbo].[Rotations] r on r.FieldId = f.id
	inner join [dbo].[DimensionedQuantities] p on p.id = r.ProductId
	inner join [dbo].[Units] u on u.id = p.UnitId
	WHERE r.Year >= @Year;
END
GO
/****** Object:  StoredProcedure [dbo].[spRotations_Upsert]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spRotations_Upsert] 
	-- Add the parameters for the stored procedure here
	@FieldId int,
	@ProductId int,
	@Year int,
	@id int=0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	BEGIN TRANSACTION;
	UPDATE dbo.Rotations SET ProductId=@ProductId WHERE 
		dbo.Rotations.FieldId= @FieldId AND dbo.Rotations.Year = @Year;
	IF @@ROWCOUNT = 0
	BEGIN
		INSERT INTO dbo.Rotations (FieldId, ProductId, Year) VALUES (@FieldId, @ProductId, @Year);
		SELECT @id = SCOPE_IDENTITY();
	END
	COMMIT TRANSACTION;
END
GO
/****** Object:  StoredProcedure [dbo].[spUnits_GetAll]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUnits_GetAll]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM dbo.Units
END
GO
/****** Object:  StoredProcedure [dbo].[spUnits_Insert]    Script Date: 1/8/2021 12:48:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUnits_Insert] 
	-- Add the parameters for the stored procedure here
	@Unit varchar(20),
	@id int=0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO dbo.Units (Unit) VALUES (@Unit);
	SELECT @id = SCOPE_IDENTITY();
END
GO
USE [master]
GO
ALTER DATABASE [Soil] SET  READ_WRITE 
GO
