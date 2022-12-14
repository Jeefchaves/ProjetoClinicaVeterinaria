CREATE DATABASE CLINICA_VETERINARIA
USE [CLINICA_VETERINARIA]
GO
/****** Object:  Table [dbo].[ANIMAL]    Script Date: 09/12/2022 01:44:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ANIMAL](
	[Codigo_animal] [int] IDENTITY(1,1) NOT NULL,
	[Nome_animal] [varchar](100) NULL,
	[Data_nasc_animal] [date] NULL,
	[Especie_animal] [varchar](50) NULL,
	[Raca_animal] [varchar](100) NULL,
	[Pelagem_animal] [varchar](50) NULL,
	[Sexo_animal] [varchar](50) NULL,
	[Codigo_cli] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo_animal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 09/12/2022 01:44:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[Codigo_cli] [int] IDENTITY(1,1) NOT NULL,
	[CPF_cli] [varchar](20) NULL,
	[Data_nasc_cli] [date] NULL,
	[Nome_cli] [varchar](100) NULL,
	[Endereco_cli] [varchar](100) NULL,
	[Numero_cli] [varchar](5) NULL,
	[Bairro_cli] [varchar](30) NULL,
	[CEP_cli] [varchar](20) NULL,
	[Celular_cli] [varchar](20) NULL,
	[Telefone_cli] [varchar](20) NULL,
	[Email_cli] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo_cli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FUNCIONARIO]    Script Date: 09/12/2022 01:44:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FUNCIONARIO](
	[Codigo_funcionario] [int] IDENTITY(1,1) NOT NULL,
	[Senha_funcionario] [varchar](8) NULL,
	[Nome_funcionario] [varchar](100) NULL,
	[CPF_funcionario] [varchar](20) NULL,
	[Data_nasc_funcionario] [varchar](12) NULL,
	[Endereco_funcionario] [varchar](100) NULL,
	[Numero_funcionario] [varchar](5) NULL,
	[Bairro_funcionario] [varchar](30) NULL,
	[CEP_funcionario] [varchar](20) NULL,
	[Cargo_funcionario] [varchar](50) NULL,
	[Celular_funcionario] [varchar](20) NULL,
	[Email_funcionario] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo_funcionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ANIMAL]  WITH CHECK ADD FOREIGN KEY([Codigo_cli])
REFERENCES [dbo].[CLIENTE] ([Codigo_cli])
GO
