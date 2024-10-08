USE [master]
GO
/****** Object:  Database [Farmacia_1]    Script Date: 24/08/2024 20:16:16 ******/
CREATE DATABASE [Farmacia_1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP_Integrador', FILENAME = N'C:\SQLData\MSSQL16.SQLEXPRESS\MSSQL\DATA\TP_Integrador.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP_Integrador_log', FILENAME = N'C:\SQLData\MSSQL16.SQLEXPRESS\MSSQL\DATA\TP_Integrador_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Farmacia_1] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Farmacia_1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Farmacia_1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Farmacia_1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Farmacia_1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Farmacia_1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Farmacia_1] SET ARITHABORT OFF 
GO
ALTER DATABASE [Farmacia_1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Farmacia_1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Farmacia_1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Farmacia_1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Farmacia_1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Farmacia_1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Farmacia_1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Farmacia_1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Farmacia_1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Farmacia_1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Farmacia_1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Farmacia_1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Farmacia_1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Farmacia_1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Farmacia_1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Farmacia_1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Farmacia_1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Farmacia_1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Farmacia_1] SET  MULTI_USER 
GO
ALTER DATABASE [Farmacia_1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Farmacia_1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Farmacia_1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Farmacia_1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Farmacia_1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Farmacia_1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Farmacia_1] SET QUERY_STORE = ON
GO
ALTER DATABASE [Farmacia_1] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Farmacia_1]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 24/08/2024 20:16:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apellido] [nvarchar](50) NULL,
	[id_estado] [int] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClienteObrasSociales]    Script Date: 24/08/2024 20:16:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClienteObrasSociales](
	[id_cliente] [int] NOT NULL,
	[id_obraSocial] [int] NOT NULL,
	[nroObraSocial] [nvarchar](17) NULL,
	[id_estado] [int] NULL,
 CONSTRAINT [PK_ClienteObrasSociales] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC,
	[id_obraSocial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallePedido]    Script Date: 24/08/2024 20:16:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallePedido](
	[id_NotaPedido] [int] NOT NULL,
	[id_medcamento] [int] NOT NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [PK_DetallePedido] PRIMARY KEY CLUSTERED 
(
	[id_NotaPedido] ASC,
	[id_medcamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 24/08/2024 20:16:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[id_venta] [numeric](9, 0) NOT NULL,
	[id_medicamento] [int] NOT NULL,
	[cantidad] [int] NULL,
	[precioUnitario] [float] NULL,
	[descuento] [float] NULL,
 CONSTRAINT [PK_Detalle Venta] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC,
	[id_medicamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 24/08/2024 20:16:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NULL,
	[nombre] [nvarchar](50) NULL,
	[apellido] [nvarchar](50) NULL,
	[usuario] [nvarchar](50) NULL,
	[contraseña] [nvarchar](50) NULL,
	[estado] [int] NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 24/08/2024 20:16:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[id_estado] [int] NOT NULL,
	[descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Laboratorio]    Script Date: 24/08/2024 20:16:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Laboratorio](
	[id_laboratorio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[cuit] [nvarchar](13) NULL,
	[telefono] [numeric](38, 0) NULL,
	[id_estado] [int] NULL,
 CONSTRAINT [PK_Laboratorio] PRIMARY KEY CLUSTERED 
(
	[id_laboratorio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicamento]    Script Date: 24/08/2024 20:16:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicamento](
	[id_medicamento] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[droga] [nvarchar](50) NULL,
	[id_laboratorio] [int] NULL,
	[receta] [nvarchar](50) NULL,
	[precio] [float] NULL,
	[stock_real] [int] NULL,
	[id_estado] [int] NULL,
 CONSTRAINT [PK_Medicamento] PRIMARY KEY CLUSTERED 
(
	[id_medicamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotaPedido]    Script Date: 24/08/2024 20:16:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotaPedido](
	[id_notaPedido] [int] IDENTITY(1,1) NOT NULL,
	[id_laboratorio] [int] NULL,
	[fechaPedido] [date] NULL,
 CONSTRAINT [PK_Nota Pedido] PRIMARY KEY CLUSTERED 
(
	[id_notaPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ObraSocial]    Script Date: 24/08/2024 20:16:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ObraSocial](
	[id_obraSocial] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[cuit] [nvarchar](13) NULL,
	[tipo] [nvarchar](50) NULL,
	[id_estado] [int] NULL,
 CONSTRAINT [PK_Obra Social] PRIMARY KEY CLUSTERED 
(
	[id_obraSocial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDescuento]    Script Date: 24/08/2024 20:16:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDescuento](
	[id_medicamento] [int] NOT NULL,
	[id_obraSocial] [int] NOT NULL,
	[descuento] [int] NULL,
	[id_estado] [int] NULL,
 CONSTRAINT [PK_TipoDescuento] PRIMARY KEY CLUSTERED 
(
	[id_medicamento] ASC,
	[id_obraSocial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 24/08/2024 20:16:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NULL,
	[nivel] [int] NULL,
	[id_estado] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 24/08/2024 20:16:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[id_venta] [numeric](9, 0) IDENTITY(100,1) NOT NULL,
	[id_empleado] [int] NULL,
	[id_cliente] [int] NULL,
	[total_venta] [float] NULL,
	[fecha_venta] [date] NULL,
	[tipoFactura] [nvarchar](1) NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [id_estado]) VALUES (1, N'David', N'Gerasimchuk', 1)
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [id_estado]) VALUES (2, N'Hernesto', N'Gusman', 1)
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [id_estado]) VALUES (3, N'Juan', N'Gonzales', 1)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
INSERT [dbo].[ClienteObrasSociales] ([id_cliente], [id_obraSocial], [nroObraSocial], [id_estado]) VALUES (1, 1, N'5-55555555-55/555', 1)
INSERT [dbo].[ClienteObrasSociales] ([id_cliente], [id_obraSocial], [nroObraSocial], [id_estado]) VALUES (1, 2, N'3-66666666-07/055', 1)
INSERT [dbo].[ClienteObrasSociales] ([id_cliente], [id_obraSocial], [nroObraSocial], [id_estado]) VALUES (3, 2, N'7-77755456-46/549', 1)
GO
INSERT [dbo].[DetallePedido] ([id_NotaPedido], [id_medcamento], [cantidad]) VALUES (4, 1, 100)
INSERT [dbo].[DetallePedido] ([id_NotaPedido], [id_medcamento], [cantidad]) VALUES (4, 2, 50)
INSERT [dbo].[DetallePedido] ([id_NotaPedido], [id_medcamento], [cantidad]) VALUES (5, 2, 20)
INSERT [dbo].[DetallePedido] ([id_NotaPedido], [id_medcamento], [cantidad]) VALUES (6, 1, 1)
GO
INSERT [dbo].[DetalleVenta] ([id_venta], [id_medicamento], [cantidad], [precioUnitario], [descuento]) VALUES (CAST(100 AS Numeric(9, 0)), 1, 2, 150, NULL)
INSERT [dbo].[DetalleVenta] ([id_venta], [id_medicamento], [cantidad], [precioUnitario], [descuento]) VALUES (CAST(100 AS Numeric(9, 0)), 2, 1, 999, NULL)
INSERT [dbo].[DetalleVenta] ([id_venta], [id_medicamento], [cantidad], [precioUnitario], [descuento]) VALUES (CAST(101 AS Numeric(9, 0)), 1, 2, 150, NULL)
INSERT [dbo].[DetalleVenta] ([id_venta], [id_medicamento], [cantidad], [precioUnitario], [descuento]) VALUES (CAST(102 AS Numeric(9, 0)), 1, 10, 150, NULL)
INSERT [dbo].[DetalleVenta] ([id_venta], [id_medicamento], [cantidad], [precioUnitario], [descuento]) VALUES (CAST(102 AS Numeric(9, 0)), 2, 1, 999, NULL)
INSERT [dbo].[DetalleVenta] ([id_venta], [id_medicamento], [cantidad], [precioUnitario], [descuento]) VALUES (CAST(103 AS Numeric(9, 0)), 1, 10, 150, NULL)
INSERT [dbo].[DetalleVenta] ([id_venta], [id_medicamento], [cantidad], [precioUnitario], [descuento]) VALUES (CAST(103 AS Numeric(9, 0)), 2, 5, 999, NULL)
INSERT [dbo].[DetalleVenta] ([id_venta], [id_medicamento], [cantidad], [precioUnitario], [descuento]) VALUES (CAST(104 AS Numeric(9, 0)), 1, 10, 150, NULL)
INSERT [dbo].[DetalleVenta] ([id_venta], [id_medicamento], [cantidad], [precioUnitario], [descuento]) VALUES (CAST(104 AS Numeric(9, 0)), 2, 10, 999, NULL)
INSERT [dbo].[DetalleVenta] ([id_venta], [id_medicamento], [cantidad], [precioUnitario], [descuento]) VALUES (CAST(105 AS Numeric(9, 0)), 1, 10, 150, NULL)
INSERT [dbo].[DetalleVenta] ([id_venta], [id_medicamento], [cantidad], [precioUnitario], [descuento]) VALUES (CAST(105 AS Numeric(9, 0)), 2, 20, 999, NULL)
INSERT [dbo].[DetalleVenta] ([id_venta], [id_medicamento], [cantidad], [precioUnitario], [descuento]) VALUES (CAST(107 AS Numeric(9, 0)), 2, 1, 999, 0)
INSERT [dbo].[DetalleVenta] ([id_venta], [id_medicamento], [cantidad], [precioUnitario], [descuento]) VALUES (CAST(107 AS Numeric(9, 0)), 3, 2, 20, 12)
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([id_empleado], [id_usuario], [nombre], [apellido], [usuario], [contraseña], [estado]) VALUES (1, 1, N'admin', N'administrador', N'admin', N'123', 1)
INSERT [dbo].[Empleado] ([id_empleado], [id_usuario], [nombre], [apellido], [usuario], [contraseña], [estado]) VALUES (2, 2, N'Joaquin', N'Bertolini', N'joa99', N'qwer12', 1)
INSERT [dbo].[Empleado] ([id_empleado], [id_usuario], [nombre], [apellido], [usuario], [contraseña], [estado]) VALUES (3, 3, N'Emilia', N'Caseres', N'casi', N'5522', 1)
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
INSERT [dbo].[Estado] ([id_estado], [descripcion]) VALUES (1, N'Habilitado')
INSERT [dbo].[Estado] ([id_estado], [descripcion]) VALUES (2, N'Deshabilitado')
GO
SET IDENTITY_INSERT [dbo].[Laboratorio] ON 

INSERT [dbo].[Laboratorio] ([id_laboratorio], [nombre], [cuit], [telefono], [id_estado]) VALUES (1, N'Genoma Laboratorio', N'40-22343658-1', CAST(4772638 AS Numeric(38, 0)), 1)
INSERT [dbo].[Laboratorio] ([id_laboratorio], [nombre], [cuit], [telefono], [id_estado]) VALUES (2, N'Bago', N'55-55555555-8', CAST(152325148 AS Numeric(38, 0)), 1)
INSERT [dbo].[Laboratorio] ([id_laboratorio], [nombre], [cuit], [telefono], [id_estado]) VALUES (3, N'Gilead Sciencies Inc.', N'88-88888888-8', CAST(7665485 AS Numeric(38, 0)), 1)
INSERT [dbo].[Laboratorio] ([id_laboratorio], [nombre], [cuit], [telefono], [id_estado]) VALUES (4, N'Fernandes Lab.', N'55-61213514-6', NULL, 2)
SET IDENTITY_INSERT [dbo].[Laboratorio] OFF
GO
SET IDENTITY_INSERT [dbo].[Medicamento] ON 

INSERT [dbo].[Medicamento] ([id_medicamento], [nombre], [droga], [id_laboratorio], [receta], [precio], [stock_real], [id_estado]) VALUES (1, N'Tafirol', N'Parasetamol', 2, N'false', 150, 200, 1)
INSERT [dbo].[Medicamento] ([id_medicamento], [nombre], [droga], [id_laboratorio], [receta], [precio], [stock_real], [id_estado]) VALUES (2, N'Sovaldi', N'Sofosbuvir', 3, N'false', 1100, 100, 1)
INSERT [dbo].[Medicamento] ([id_medicamento], [nombre], [droga], [id_laboratorio], [receta], [precio], [stock_real], [id_estado]) VALUES (3, N'Ibuprofeno', N'Parasetamol', 1, N'true', 20, 198, 1)
SET IDENTITY_INSERT [dbo].[Medicamento] OFF
GO
SET IDENTITY_INSERT [dbo].[NotaPedido] ON 

INSERT [dbo].[NotaPedido] ([id_notaPedido], [id_laboratorio], [fechaPedido]) VALUES (4, 1, CAST(N'2018-10-22' AS Date))
INSERT [dbo].[NotaPedido] ([id_notaPedido], [id_laboratorio], [fechaPedido]) VALUES (5, 3, CAST(N'2018-11-13' AS Date))
INSERT [dbo].[NotaPedido] ([id_notaPedido], [id_laboratorio], [fechaPedido]) VALUES (6, 2, CAST(N'2018-11-13' AS Date))
SET IDENTITY_INSERT [dbo].[NotaPedido] OFF
GO
SET IDENTITY_INSERT [dbo].[ObraSocial] ON 

INSERT [dbo].[ObraSocial] ([id_obraSocial], [nombre], [cuit], [tipo], [id_estado]) VALUES (1, N'Medife', N'30-12345678-1', N'Plata', 1)
INSERT [dbo].[ObraSocial] ([id_obraSocial], [nombre], [cuit], [tipo], [id_estado]) VALUES (2, N'Met', N'20-87456321-7', N'Nivel-5', 1)
INSERT [dbo].[ObraSocial] ([id_obraSocial], [nombre], [cuit], [tipo], [id_estado]) VALUES (3, N'Osde', N'66-99999999-5', N'Profecional', 1)
SET IDENTITY_INSERT [dbo].[ObraSocial] OFF
GO
INSERT [dbo].[TipoDescuento] ([id_medicamento], [id_obraSocial], [descuento], [id_estado]) VALUES (1, 2, 70, 1)
INSERT [dbo].[TipoDescuento] ([id_medicamento], [id_obraSocial], [descuento], [id_estado]) VALUES (2, 1, 50, 1)
INSERT [dbo].[TipoDescuento] ([id_medicamento], [id_obraSocial], [descuento], [id_estado]) VALUES (3, 1, 30, 1)
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([id_usuario], [descripcion], [nivel], [id_estado]) VALUES (1, N'Administrador', 1, 1)
INSERT [dbo].[Usuario] ([id_usuario], [descripcion], [nivel], [id_estado]) VALUES (2, N'Empleado', 2, 1)
INSERT [dbo].[Usuario] ([id_usuario], [descripcion], [nivel], [id_estado]) VALUES (3, N'Supervisor', 1, 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([id_venta], [id_empleado], [id_cliente], [total_venta], [fecha_venta], [tipoFactura]) VALUES (CAST(100 AS Numeric(9, 0)), 1, 1, 1299, CAST(N'2018-10-18' AS Date), N'B')
INSERT [dbo].[Venta] ([id_venta], [id_empleado], [id_cliente], [total_venta], [fecha_venta], [tipoFactura]) VALUES (CAST(101 AS Numeric(9, 0)), 1, 1, 120, CAST(N'2018-10-18' AS Date), N'B')
INSERT [dbo].[Venta] ([id_venta], [id_empleado], [id_cliente], [total_venta], [fecha_venta], [tipoFactura]) VALUES (CAST(102 AS Numeric(9, 0)), 1, 1, 2499, CAST(N'2018-10-18' AS Date), N'A')
INSERT [dbo].[Venta] ([id_venta], [id_empleado], [id_cliente], [total_venta], [fecha_venta], [tipoFactura]) VALUES (CAST(103 AS Numeric(9, 0)), 2, 1, 6495, CAST(N'2018-10-18' AS Date), N'B')
INSERT [dbo].[Venta] ([id_venta], [id_empleado], [id_cliente], [total_venta], [fecha_venta], [tipoFactura]) VALUES (CAST(104 AS Numeric(9, 0)), 1, 1, 11490, CAST(N'2018-10-18' AS Date), N'A')
INSERT [dbo].[Venta] ([id_venta], [id_empleado], [id_cliente], [total_venta], [fecha_venta], [tipoFactura]) VALUES (CAST(105 AS Numeric(9, 0)), 2, 1, 21480, CAST(N'2018-10-18' AS Date), N'A')
INSERT [dbo].[Venta] ([id_venta], [id_empleado], [id_cliente], [total_venta], [fecha_venta], [tipoFactura]) VALUES (CAST(107 AS Numeric(9, 0)), 1, 1, 1027, CAST(N'2018-11-13' AS Date), N'A')
SET IDENTITY_INSERT [dbo].[Venta] OFF
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Estado] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estado] ([id_estado])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Estado]
GO
ALTER TABLE [dbo].[ClienteObrasSociales]  WITH CHECK ADD  CONSTRAINT [FK_ClienteObrasSociales_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[ClienteObrasSociales] CHECK CONSTRAINT [FK_ClienteObrasSociales_Cliente]
GO
ALTER TABLE [dbo].[ClienteObrasSociales]  WITH CHECK ADD  CONSTRAINT [FK_ClienteObrasSociales_Estado] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estado] ([id_estado])
GO
ALTER TABLE [dbo].[ClienteObrasSociales] CHECK CONSTRAINT [FK_ClienteObrasSociales_Estado]
GO
ALTER TABLE [dbo].[ClienteObrasSociales]  WITH CHECK ADD  CONSTRAINT [FK_ClienteObrasSociales_ObraSocial] FOREIGN KEY([id_obraSocial])
REFERENCES [dbo].[ObraSocial] ([id_obraSocial])
GO
ALTER TABLE [dbo].[ClienteObrasSociales] CHECK CONSTRAINT [FK_ClienteObrasSociales_ObraSocial]
GO
ALTER TABLE [dbo].[DetallePedido]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Medicamento] FOREIGN KEY([id_medcamento])
REFERENCES [dbo].[Medicamento] ([id_medicamento])
GO
ALTER TABLE [dbo].[DetallePedido] CHECK CONSTRAINT [FK_Detalle_Medicamento]
GO
ALTER TABLE [dbo].[DetallePedido]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_NotaPedido] FOREIGN KEY([id_NotaPedido])
REFERENCES [dbo].[NotaPedido] ([id_notaPedido])
GO
ALTER TABLE [dbo].[DetallePedido] CHECK CONSTRAINT [FK_Detalle_NotaPedido]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DV_medic] FOREIGN KEY([id_medicamento])
REFERENCES [dbo].[Medicamento] ([id_medicamento])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DV_medic]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DV_venta] FOREIGN KEY([id_venta])
REFERENCES [dbo].[Venta] ([id_venta])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DV_venta]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Estado] FOREIGN KEY([estado])
REFERENCES [dbo].[Estado] ([id_estado])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Estado]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_user] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_user]
GO
ALTER TABLE [dbo].[Laboratorio]  WITH CHECK ADD  CONSTRAINT [FK_Laboratorio_Estado] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estado] ([id_estado])
GO
ALTER TABLE [dbo].[Laboratorio] CHECK CONSTRAINT [FK_Laboratorio_Estado]
GO
ALTER TABLE [dbo].[Medicamento]  WITH CHECK ADD  CONSTRAINT [FK_Medicamento_Estado] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estado] ([id_estado])
GO
ALTER TABLE [dbo].[Medicamento] CHECK CONSTRAINT [FK_Medicamento_Estado]
GO
ALTER TABLE [dbo].[Medicamento]  WITH CHECK ADD  CONSTRAINT [FK_Medicamento_Lab] FOREIGN KEY([id_laboratorio])
REFERENCES [dbo].[Laboratorio] ([id_laboratorio])
GO
ALTER TABLE [dbo].[Medicamento] CHECK CONSTRAINT [FK_Medicamento_Lab]
GO
ALTER TABLE [dbo].[NotaPedido]  WITH CHECK ADD  CONSTRAINT [FK_NP_lab] FOREIGN KEY([id_laboratorio])
REFERENCES [dbo].[Laboratorio] ([id_laboratorio])
GO
ALTER TABLE [dbo].[NotaPedido] CHECK CONSTRAINT [FK_NP_lab]
GO
ALTER TABLE [dbo].[ObraSocial]  WITH CHECK ADD  CONSTRAINT [FK_Obra Social_Estado] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estado] ([id_estado])
GO
ALTER TABLE [dbo].[ObraSocial] CHECK CONSTRAINT [FK_Obra Social_Estado]
GO
ALTER TABLE [dbo].[TipoDescuento]  WITH CHECK ADD  CONSTRAINT [FK_TipoDescuento_Estado] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estado] ([id_estado])
GO
ALTER TABLE [dbo].[TipoDescuento] CHECK CONSTRAINT [FK_TipoDescuento_Estado]
GO
ALTER TABLE [dbo].[TipoDescuento]  WITH CHECK ADD  CONSTRAINT [FK_TipoDescuento_Medicamento] FOREIGN KEY([id_medicamento])
REFERENCES [dbo].[Medicamento] ([id_medicamento])
GO
ALTER TABLE [dbo].[TipoDescuento] CHECK CONSTRAINT [FK_TipoDescuento_Medicamento]
GO
ALTER TABLE [dbo].[TipoDescuento]  WITH CHECK ADD  CONSTRAINT [FK_TipoDescuento_ObraSocial] FOREIGN KEY([id_obraSocial])
REFERENCES [dbo].[ObraSocial] ([id_obraSocial])
GO
ALTER TABLE [dbo].[TipoDescuento] CHECK CONSTRAINT [FK_TipoDescuento_ObraSocial]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Estado] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estado] ([id_estado])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Estado]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_ventaCliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_ventaCliente]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_ventaEmpleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_ventaEmpleado]
GO
USE [master]
GO
ALTER DATABASE [Farmacia_1] SET  READ_WRITE 
GO
