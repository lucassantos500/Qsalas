USE [master]
GO
/****** Object:  Database [dbComercio]    Script Date: 31/07/2018 12:47:15 ******/
CREATE DATABASE [dbComercio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbComercio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\dbComercio.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbComercio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\dbComercio_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [dbComercio] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbComercio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbComercio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbComercio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbComercio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbComercio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbComercio] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbComercio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbComercio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbComercio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbComercio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbComercio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbComercio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbComercio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbComercio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbComercio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbComercio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbComercio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbComercio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbComercio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbComercio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbComercio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbComercio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbComercio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbComercio] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbComercio] SET  MULTI_USER 
GO
ALTER DATABASE [dbComercio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbComercio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbComercio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbComercio] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbComercio] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbComercio] SET QUERY_STORE = OFF
GO
USE [dbComercio]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
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
USE [dbComercio]
GO
/****** Object:  Table [dbo].[apresentacao]    Script Date: 31/07/2018 12:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[apresentacao](
	[idapresentacao] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[descricao] [varchar](100) NULL,
 CONSTRAINT [PK_apresentacao] PRIMARY KEY CLUSTERED 
(
	[idapresentacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 31/07/2018 12:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[idcategoria] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[descricao] [varchar](100) NULL,
 CONSTRAINT [PK_categoria] PRIMARY KEY CLUSTERED 
(
	[idcategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 31/07/2018 12:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[idcliente] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[sobrenome] [varchar](50) NULL,
	[sexo] [varchar](1) NULL,
	[tipo_documento] [varchar](50) NULL,
	[num_documento] [varchar](50) NULL,
	[endereco] [varchar](100) NULL,
	[telefone] [varchar](50) NULL,
	[email] [varchar](50) NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalhe_entrada]    Script Date: 31/07/2018 12:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalhe_entrada](
	[iddetalhe_entrada] [int] IDENTITY(1,1) NOT NULL,
	[identrada] [int] NOT NULL,
	[idproduto] [int] NOT NULL,
	[preco_compra] [money] NOT NULL,
	[preco_venda] [money] NOT NULL,
	[estoque_inicial] [int] NOT NULL,
	[estoque_atual] [int] NOT NULL,
	[data_producao] [date] NULL,
	[data_vencimento] [date] NOT NULL,
 CONSTRAINT [PK_detalhe_entrada] PRIMARY KEY CLUSTERED 
(
	[iddetalhe_entrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalhe_venda]    Script Date: 31/07/2018 12:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalhe_venda](
	[iddetalhe_venda] [int] IDENTITY(1,1) NOT NULL,
	[idvenda] [int] NOT NULL,
	[iddetalhe_entrada] [int] NOT NULL,
	[quantidade] [int] NOT NULL,
	[preco_venda] [money] NOT NULL,
	[desconto] [money] NULL,
 CONSTRAINT [PK_detalhe_venda] PRIMARY KEY CLUSTERED 
(
	[iddetalhe_venda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[entrada]    Script Date: 31/07/2018 12:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[entrada](
	[identrada] [int] IDENTITY(1,1) NOT NULL,
	[idfuncionario] [int] NOT NULL,
	[idfornecedor] [int] NOT NULL,
	[data] [date] NOT NULL,
	[tipo_comprovante] [varchar](50) NOT NULL,
	[serie] [varchar](4) NOT NULL,
	[correlativo] [varchar](7) NOT NULL,
	[imposto] [decimal](4, 2) NULL,
 CONSTRAINT [PK_entrada] PRIMARY KEY CLUSTERED 
(
	[identrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fornecedor]    Script Date: 31/07/2018 12:47:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fornecedor](
	[idfornecedor] [int] IDENTITY(1,1) NOT NULL,
	[empresa] [varchar](50) NOT NULL,
	[setor_comercial] [varchar](50) NOT NULL,
	[tipo_documento] [varchar](50) NOT NULL,
	[num_documento] [varchar](50) NOT NULL,
	[endereco] [varchar](100) NOT NULL,
	[telefone] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[site] [varchar](50) NULL,
 CONSTRAINT [PK_fornecedor] PRIMARY KEY CLUSTERED 
(
	[idfornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[funcionario]    Script Date: 31/07/2018 12:47:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[funcionario](
	[idfuncionario] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[sexo] [varchar](1) NOT NULL,
	[data_nascimento] [date] NOT NULL,
	[num_identificacao] [varchar](50) NOT NULL,
	[endereco] [varchar](100) NOT NULL,
	[telefone] [varchar](50) NOT NULL,
	[email] [varchar](50) NULL,
	[acesso] [varchar](50) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[senha] [varchar](50) NOT NULL,
 CONSTRAINT [PK_funcionario] PRIMARY KEY CLUSTERED 
(
	[idfuncionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produto]    Script Date: 31/07/2018 12:47:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produto](
	[idproduto] [int] NOT NULL,
	[codigo] [varchar](50) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[descricao] [varchar](500) NULL,
	[imagem] [image] NULL,
	[idcategoria] [int] NOT NULL,
	[idapresentacao] [int] NOT NULL,
 CONSTRAINT [PK_produto] PRIMARY KEY CLUSTERED 
(
	[idproduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venda]    Script Date: 31/07/2018 12:47:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venda](
	[idvenda] [int] IDENTITY(1,1) NOT NULL,
	[idcliente] [int] NOT NULL,
	[idfuncionario] [int] NOT NULL,
	[data] [date] NOT NULL,
	[tipo_comprovante] [varchar](50) NOT NULL,
	[serie] [varchar](4) NOT NULL,
	[correlativo] [varchar](7) NOT NULL,
	[imposto] [decimal](4, 2) NULL,
 CONSTRAINT [PK_venda] PRIMARY KEY CLUSTERED 
(
	[idvenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[detalhe_entrada]  WITH CHECK ADD  CONSTRAINT [FK_detalhe_entrada_entrada] FOREIGN KEY([identrada])
REFERENCES [dbo].[entrada] ([identrada])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detalhe_entrada] CHECK CONSTRAINT [FK_detalhe_entrada_entrada]
GO
ALTER TABLE [dbo].[detalhe_entrada]  WITH CHECK ADD  CONSTRAINT [FK_detalhe_entrada_produto] FOREIGN KEY([idproduto])
REFERENCES [dbo].[produto] ([idproduto])
GO
ALTER TABLE [dbo].[detalhe_entrada] CHECK CONSTRAINT [FK_detalhe_entrada_produto]
GO
ALTER TABLE [dbo].[detalhe_venda]  WITH CHECK ADD  CONSTRAINT [FK_detalhe_venda_detalhe_entrada] FOREIGN KEY([iddetalhe_entrada])
REFERENCES [dbo].[detalhe_entrada] ([iddetalhe_entrada])
GO
ALTER TABLE [dbo].[detalhe_venda] CHECK CONSTRAINT [FK_detalhe_venda_detalhe_entrada]
GO
ALTER TABLE [dbo].[detalhe_venda]  WITH CHECK ADD  CONSTRAINT [FK_detalhe_venda_venda] FOREIGN KEY([idvenda])
REFERENCES [dbo].[venda] ([idvenda])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detalhe_venda] CHECK CONSTRAINT [FK_detalhe_venda_venda]
GO
ALTER TABLE [dbo].[entrada]  WITH CHECK ADD  CONSTRAINT [FK_entrada_fornecedor] FOREIGN KEY([idfornecedor])
REFERENCES [dbo].[fornecedor] ([idfornecedor])
GO
ALTER TABLE [dbo].[entrada] CHECK CONSTRAINT [FK_entrada_fornecedor]
GO
ALTER TABLE [dbo].[entrada]  WITH CHECK ADD  CONSTRAINT [FK_entrada_funcionario] FOREIGN KEY([idfuncionario])
REFERENCES [dbo].[funcionario] ([idfuncionario])
GO
ALTER TABLE [dbo].[entrada] CHECK CONSTRAINT [FK_entrada_funcionario]
GO
ALTER TABLE [dbo].[produto]  WITH CHECK ADD  CONSTRAINT [FK_produto_apresentacao] FOREIGN KEY([idapresentacao])
REFERENCES [dbo].[apresentacao] ([idapresentacao])
GO
ALTER TABLE [dbo].[produto] CHECK CONSTRAINT [FK_produto_apresentacao]
GO
ALTER TABLE [dbo].[produto]  WITH CHECK ADD  CONSTRAINT [FK_produto_categoria] FOREIGN KEY([idcategoria])
REFERENCES [dbo].[categoria] ([idcategoria])
GO
ALTER TABLE [dbo].[produto] CHECK CONSTRAINT [FK_produto_categoria]
GO
ALTER TABLE [dbo].[venda]  WITH CHECK ADD  CONSTRAINT [FK_venda_cliente] FOREIGN KEY([idcliente])
REFERENCES [dbo].[cliente] ([idcliente])
GO
ALTER TABLE [dbo].[venda] CHECK CONSTRAINT [FK_venda_cliente]
GO
ALTER TABLE [dbo].[venda]  WITH CHECK ADD  CONSTRAINT [FK_venda_funcionario] FOREIGN KEY([idfuncionario])
REFERENCES [dbo].[funcionario] ([idfuncionario])
GO
ALTER TABLE [dbo].[venda] CHECK CONSTRAINT [FK_venda_funcionario]
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_nome]    Script Date: 31/07/2018 12:47:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_nome]
@textobuscar varchar(50)
as select * from categoria 
where nome like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spdeletar_categoria]    Script Date: 31/07/2018 12:47:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spdeletar_categoria]
@idcategoria int
as
delete from categoria
where idcategoria = @idcategoria
GO
/****** Object:  StoredProcedure [dbo].[speditar_categoria]    Script Date: 31/07/2018 12:47:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speditar_categoria]
@idcategoria int,
@nome varchar(50),
@descricao varchar(100)
as
update categoria set nome = @nome,
descricao = @descricao
where idcategoria = @idcategoria
GO
/****** Object:  StoredProcedure [dbo].[spinserir_categoria]    Script Date: 31/07/2018 12:47:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spinserir_categoria]
@idcategoria int output,
@nome varchar(50),
@descricao varchar(100)
as
insert into categoria(nome, descricao) 
values (@nome, @descricao)
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_categoria]    Script Date: 31/07/2018 12:47:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spmostrar_categoria]
as
select top 200 * from categoria
order by idcategoria desc
GO
USE [master]
GO
ALTER DATABASE [dbComercio] SET  READ_WRITE 
GO
