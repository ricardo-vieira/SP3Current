
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/19/2019 21:01:04
-- Generated from EDMX file: F:\Git\SP3Current\projProjetos\EntityFramework\edmProjetos.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
CREATE DATABASE sp3;
GO
USE [sp3];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__COMPETENC__IDCOM__300424B4]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[COMPETENCIASEXIGIDAS] DROP CONSTRAINT [FK__COMPETENC__IDCOM__300424B4];
GO
IF OBJECT_ID(N'[dbo].[FK__COMPETENC__IDPRO__2F10007B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[COMPETENCIASEXIGIDAS] DROP CONSTRAINT [FK__COMPETENC__IDPRO__2F10007B];
GO
IF OBJECT_ID(N'[dbo].[FK__CRITERIOS__CRITE__503BEA1C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRITERIOSCOMPARACOES] DROP CONSTRAINT [FK__CRITERIOS__CRITE__503BEA1C];
GO
IF OBJECT_ID(N'[dbo].[FK__CRITERIOS__CRITE__51300E55]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRITERIOSCOMPARACOES] DROP CONSTRAINT [FK__CRITERIOS__CRITE__51300E55];
GO
IF OBJECT_ID(N'[dbo].[FK__CRITERIOS__IDCRI__0D44F85C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRITERIOSRESULTADOLISTA] DROP CONSTRAINT [FK__CRITERIOS__IDCRI__0D44F85C];
GO
IF OBJECT_ID(N'[dbo].[FK__CRITERIOS__IDCRI__1F63A897]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRITERIOSRESULTADOLISTA] DROP CONSTRAINT [FK__CRITERIOS__IDCRI__1F63A897];
GO
IF OBJECT_ID(N'[dbo].[FK__CRITERIOS__IDCRI__2057CCD0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRITERIOSRESULTADO] DROP CONSTRAINT [FK__CRITERIOS__IDCRI__2057CCD0];
GO
IF OBJECT_ID(N'[dbo].[FK__CRITERIOS__IDCRI__67DE6983]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRITERIOSPROJETOSRESULTADOLISTA] DROP CONSTRAINT [FK__CRITERIOS__IDCRI__67DE6983];
GO
IF OBJECT_ID(N'[dbo].[FK__CRITERIOS__IDCRI__69C6B1F5]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRITERIOSPROJETOSRESULTADO] DROP CONSTRAINT [FK__CRITERIOS__IDCRI__69C6B1F5];
GO
IF OBJECT_ID(N'[dbo].[FK__CRITERIOS__IDCRI__76619304]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRITERIOSPROJETOSCOMPARACOES] DROP CONSTRAINT [FK__CRITERIOS__IDCRI__76619304];
GO
IF OBJECT_ID(N'[dbo].[FK__CRITERIOS__IDPRO__308E3499]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRITERIOSPROJETOSRESULTADOLISTA] DROP CONSTRAINT [FK__CRITERIOS__IDPRO__308E3499];
GO
IF OBJECT_ID(N'[dbo].[FK__CRITERIOS__IDPRO__68D28DBC]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRITERIOSPROJETOSRESULTADO] DROP CONSTRAINT [FK__CRITERIOS__IDPRO__68D28DBC];
GO
IF OBJECT_ID(N'[dbo].[FK__CRITERIOS__IDPRO__7755B73D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRITERIOSPROJETOSCOMPARACOES] DROP CONSTRAINT [FK__CRITERIOS__IDPRO__7755B73D];
GO
IF OBJECT_ID(N'[dbo].[FK__CRITERIOS__IDPRO__7849DB76]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRITERIOSPROJETOSCOMPARACOES] DROP CONSTRAINT [FK__CRITERIOS__IDPRO__7849DB76];
GO
IF OBJECT_ID(N'[dbo].[FK__CRITERIOS__IDREU__52E34C9D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRITERIOSRESULTADO] DROP CONSTRAINT [FK__CRITERIOS__IDREU__52E34C9D];
GO
IF OBJECT_ID(N'[dbo].[FK__CRITERIOS__IDREU__6ABAD62E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CRITERIOSPROJETOSRESULTADO] DROP CONSTRAINT [FK__CRITERIOS__IDREU__6ABAD62E];
GO
IF OBJECT_ID(N'[dbo].[FK__PAUTAPROJ__IDPRO__4924D839]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PAUTAPROJETOS] DROP CONSTRAINT [FK__PAUTAPROJ__IDPRO__4924D839];
GO
IF OBJECT_ID(N'[dbo].[FK__PAUTAPROJ__IDREU__4830B400]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PAUTAPROJETOS] DROP CONSTRAINT [FK__PAUTAPROJ__IDREU__4830B400];
GO
IF OBJECT_ID(N'[dbo].[FK__PAUTARECE__IDPAU__6F4A8121]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PAUTARECEITAVARIAVEL] DROP CONSTRAINT [FK__PAUTARECE__IDPAU__6F4A8121];
GO
IF OBJECT_ID(N'[dbo].[FK__PERMISSOES__ID__1367E606]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PERMISSOES] DROP CONSTRAINT [FK__PERMISSOES__ID__1367E606];
GO
IF OBJECT_ID(N'[dbo].[FK__PESSOACOM__IDCOM__22AA2996]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PESSOACOMPETENCIAS] DROP CONSTRAINT [FK__PESSOACOM__IDCOM__22AA2996];
GO
IF OBJECT_ID(N'[dbo].[FK__PESSOACOM__IDPES__21B6055D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PESSOACOMPETENCIAS] DROP CONSTRAINT [FK__PESSOACOM__IDPES__21B6055D];
GO
IF OBJECT_ID(N'[dbo].[FK__PROJETOS__GERENT__267ABA7A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PROJETOS] DROP CONSTRAINT [FK__PROJETOS__GERENT__267ABA7A];
GO
IF OBJECT_ID(N'[dbo].[FK__PROJETOSP__IDPES__29572725]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PROJETOSPESSOAS] DROP CONSTRAINT [FK__PROJETOSP__IDPES__29572725];
GO
IF OBJECT_ID(N'[dbo].[FK__PROJETOSP__IDPRO__2A4B4B5E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PROJETOSPESSOAS] DROP CONSTRAINT [FK__PROJETOSP__IDPRO__2A4B4B5E];
GO
IF OBJECT_ID(N'[dbo].[FK__RECEITAVA__IDPRO__2F650636]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RECEITAVARIAVEL] DROP CONSTRAINT [FK__RECEITAVA__IDPRO__2F650636];
GO
IF OBJECT_ID(N'[dbo].[FK__REUNIOES__RESPON__37A5467C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[REUNIOES] DROP CONSTRAINT [FK__REUNIOES__RESPON__37A5467C];
GO
IF OBJECT_ID(N'[dbo].[FK__REUNIOESP__IDPES__3D5E1FD2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[REUNIOESPARTICIPANTES] DROP CONSTRAINT [FK__REUNIOESP__IDPES__3D5E1FD2];
GO
IF OBJECT_ID(N'[dbo].[FK__REUNIOESP__IDREU__3C69FB99]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[REUNIOESPARTICIPANTES] DROP CONSTRAINT [FK__REUNIOESP__IDREU__3C69FB99];
GO
IF OBJECT_ID(N'[dbo].[FK__USUARIOS__PERFIL__173876EA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USUARIOS] DROP CONSTRAINT [FK__USUARIOS__PERFIL__173876EA];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[COMPETENCIAS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[COMPETENCIAS];
GO
IF OBJECT_ID(N'[dbo].[COMPETENCIASEXIGIDAS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[COMPETENCIASEXIGIDAS];
GO
IF OBJECT_ID(N'[dbo].[CRITERIOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CRITERIOS];
GO
IF OBJECT_ID(N'[dbo].[CRITERIOSCOMPARACOES]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CRITERIOSCOMPARACOES];
GO
IF OBJECT_ID(N'[dbo].[CRITERIOSPROJETOSCOMPARACOES]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CRITERIOSPROJETOSCOMPARACOES];
GO
IF OBJECT_ID(N'[dbo].[CRITERIOSPROJETOSRESULTADO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CRITERIOSPROJETOSRESULTADO];
GO
IF OBJECT_ID(N'[dbo].[CRITERIOSPROJETOSRESULTADOLISTA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CRITERIOSPROJETOSRESULTADOLISTA];
GO
IF OBJECT_ID(N'[dbo].[CRITERIOSRESULTADO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CRITERIOSRESULTADO];
GO
IF OBJECT_ID(N'[dbo].[CRITERIOSRESULTADOLISTA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CRITERIOSRESULTADOLISTA];
GO
IF OBJECT_ID(N'[dbo].[PAUTAPROJETOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PAUTAPROJETOS];
GO
IF OBJECT_ID(N'[dbo].[PAUTARECEITAVARIAVEL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PAUTARECEITAVARIAVEL];
GO
IF OBJECT_ID(N'[dbo].[PERFILUSUARIO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PERFILUSUARIO];
GO
IF OBJECT_ID(N'[dbo].[PERMISSOES]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PERMISSOES];
GO
IF OBJECT_ID(N'[dbo].[PESSOACOMPETENCIAS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PESSOACOMPETENCIAS];
GO
IF OBJECT_ID(N'[dbo].[PESSOAS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PESSOAS];
GO
IF OBJECT_ID(N'[dbo].[PROJETOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PROJETOS];
GO
IF OBJECT_ID(N'[dbo].[PROJETOSPESSOAS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PROJETOSPESSOAS];
GO
IF OBJECT_ID(N'[dbo].[RECEITAVARIAVEL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RECEITAVARIAVEL];
GO
IF OBJECT_ID(N'[dbo].[REUNIOES]', 'U') IS NOT NULL
    DROP TABLE [dbo].[REUNIOES];
GO
IF OBJECT_ID(N'[dbo].[REUNIOESPARTICIPANTES]', 'U') IS NOT NULL
    DROP TABLE [dbo].[REUNIOESPARTICIPANTES];
GO
IF OBJECT_ID(N'[dbo].[USUARIOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USUARIOS];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'COMPETENCIAS'
CREATE TABLE [dbo].[COMPETENCIAS] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [DESCRICAO] varchar(50)  NOT NULL,
    [OBSERVAO] varchar(max)  NULL,
    [NIVEL] int  NULL,
    [STATUS] tinyint  NULL
);
GO

-- Creating table 'COMPETENCIASEXIGIDAS'
CREATE TABLE [dbo].[COMPETENCIASEXIGIDAS] (
    [IDPROJETO] bigint  NOT NULL,
    [IDCOMPETENCIA] bigint  NOT NULL,
    [NIVEL] int  NULL,
    [OBSERVACOES] varchar(max)  NULL,
    [STATUS] tinyint  NULL
);
GO

-- Creating table 'PERFILUSUARIOs'
CREATE TABLE [dbo].[PERFILUSUARIOs] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [NOME] nvarchar(50)  NOT NULL,
    [DESCRICAO] nvarchar(100)  NULL,
    [DATACRICAO] datetime  NULL,
    [STATUS] tinyint  NULL
);
GO

-- Creating table 'PERMISSOES'
CREATE TABLE [dbo].[PERMISSOES] (
    [ID] bigint  NOT NULL,
    [DESCRICAO] varchar(100)  NOT NULL,
    [DATA_CRIACAO] datetime  NULL
);
GO

-- Creating table 'PESSOACOMPETENCIAS'
CREATE TABLE [dbo].[PESSOACOMPETENCIAS] (
    [IDPESSOA] bigint  NOT NULL,
    [IDCOMPETENCIA] bigint  NOT NULL,
    [OBSERVACAO] varchar(max)  NOT NULL,
    [STATUS] tinyint  NULL
);
GO

-- Creating table 'PESSOAS'
CREATE TABLE [dbo].[PESSOAS] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [NOME] varchar(50)  NULL,
    [OBSERVACAO] varchar(max)  NULL,
    [DATACRIACAO] datetime  NULL,
    [STATUS] tinyint  NULL
);
GO

-- Creating table 'PROJETOSPESSOAS'
CREATE TABLE [dbo].[PROJETOSPESSOAS] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [IDPROJETO] bigint  NOT NULL,
    [IDPESSOA] bigint  NULL,
    [DATAINGRESSO] datetime  NULL,
    [OCUPACAO] varchar(50)  NULL,
    [OBSERVACOES] varchar(max)  NULL
);
GO

-- Creating table 'REUNIOESPARTICIPANTES'
CREATE TABLE [dbo].[REUNIOESPARTICIPANTES] (
    [IDREUNIAO] bigint  NOT NULL,
    [IDPESSOA] bigint  NOT NULL,
    [OBSERVACAO] varchar(max)  NULL,
    [COMPARECIMENTO] tinyint  NULL,
    [STATUS] tinyint  NULL
);
GO

-- Creating table 'USUARIOS'
CREATE TABLE [dbo].[USUARIOS] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [LOGIN] nvarchar(20)  NOT NULL,
    [PASSWORD] nvarchar(32)  NOT NULL,
    [PERFILUSUARIO] bigint  NULL,
    [DATACRICAO] datetime  NULL,
    [STATUS] tinyint  NULL
);
GO

-- Creating table 'CRITERIOS'
CREATE TABLE [dbo].[CRITERIOS] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [DESCRICAO] varchar(max)  NULL,
    [STATUS] tinyint  NULL,
    [DATACRIACAO] datetime  NULL
);
GO

-- Creating table 'CRITERIOSCOMPARACOES'
CREATE TABLE [dbo].[CRITERIOSCOMPARACOES] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [IDCRITERIOA] bigint  NOT NULL,
    [IDCRITERIOB] bigint  NOT NULL,
    [COMPARACAO] varchar(50)  NULL
);
GO

-- Creating table 'CRITERIOSPROJETOSCOMPARACOES'
CREATE TABLE [dbo].[CRITERIOSPROJETOSCOMPARACOES] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [IDCRITERIO] bigint  NOT NULL,
    [IDPROJETOA] bigint  NOT NULL,
    [IDPROJETOB] bigint  NULL,
    [COMPARACAO] varchar(3)  NULL
);
GO

-- Creating table 'CRITERIOSRESULTADOes'
CREATE TABLE [dbo].[CRITERIOSRESULTADOes] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [IDCRITERIO] bigint  NOT NULL,
    [DATACOMPARACAO] datetime  NULL,
    [RESULTADOCOMPARACAO] decimal(18,4)  NOT NULL,
    [RESULTADOGLOBAL] decimal(18,4)  NOT NULL,
    [IDREUNIAO] bigint  NULL
);
GO

-- Creating table 'CRITERIOSRESULTADOLISTAs'
CREATE TABLE [dbo].[CRITERIOSRESULTADOLISTAs] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [IDCRITERIORESULTADO] bigint  NOT NULL,
    [IDCRITERIO] bigint  NOT NULL,
    [COMPARACAO] char(3)  NULL
);
GO

-- Creating table 'CRITERIOSPROJETOSRESULTADOes'
CREATE TABLE [dbo].[CRITERIOSPROJETOSRESULTADOes] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [IDCRITERIOSRESULTADO] bigint  NOT NULL,
    [IDPROJETO] bigint  NOT NULL,
    [RESULTADO] decimal(18,4)  NOT NULL,
    [DATACOMPARACAO] datetime  NULL,
    [RESULTADOGLOBAL] decimal(18,4)  NOT NULL,
    [IDREUNIAO] bigint  NOT NULL
);
GO

-- Creating table 'CRITERIOSPROJETOSRESULTADOLISTAs'
CREATE TABLE [dbo].[CRITERIOSPROJETOSRESULTADOLISTAs] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [IDCRITERIOSPROJETOSRESULTADO] bigint  NOT NULL,
    [IDPROJETO] bigint  NOT NULL,
    [COMPARACAO] char(3)  NULL
);
GO

-- Creating table 'RECEITAVARIAVELs'
CREATE TABLE [dbo].[RECEITAVARIAVELs] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [IDPROJETO] bigint  NOT NULL,
    [DATAPERIODO] datetime  NOT NULL,
    [TIPO] varchar(10)  NOT NULL,
    [DATACRIACAO] datetime  NULL,
    [VALOR] decimal(15,4)  NULL,
    [STATUS] tinyint  NULL,
    [OBSERVACOES] varchar(max)  NULL
);
GO

-- Creating table 'PAUTARECEITAVARIAVELs'
CREATE TABLE [dbo].[PAUTARECEITAVARIAVELs] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [IDPAUTAPROJETO] bigint  NOT NULL,
    [DATAPERIODO] datetime  NULL,
    [TIPO] varchar(10)  NULL,
    [DATACRIACAO] datetime  NULL,
    [VALOR] decimal(15,4)  NULL,
    [STATUS] tinyint  NULL,
    [OBSERVACOES] varchar(max)  NULL
);
GO

-- Creating table 'PAUTAPROJETOS'
CREATE TABLE [dbo].[PAUTAPROJETOS] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [IDREUNIAO] bigint  NOT NULL,
    [IDPROJETO] bigint  NOT NULL,
    [TEMPOPREVISTOCONCLUSAO] decimal(15,4)  NULL,
    [RECEITACONSTANTE] decimal(15,4)  NULL,
    [RAZAORECEITAVALOR] decimal(15,4)  NULL,
    [RAZAORECEITAPERCENTUAL] decimal(15,4)  NULL,
    [INVESTIMENTOPREVISTO] decimal(15,4)  NULL,
    [RESULTADOPAYBACK] decimal(15,4)  NULL,
    [ORDEMRESULTADOPAYBACK] int  NULL,
    [APROVACAORESULTADOPAYBACK] varchar(5)  NULL,
    [RESULTADOVALORPRESENTELIQUIDO] decimal(15,4)  NULL,
    [ORDEMRESULTADOVALORPRESENTELIQUIDO] int  NULL,
    [APROVACAORESULTADOVALORPRESENTELIQUIDO] varchar(5)  NULL,
    [RESULTADOTAXAINTERNARETORNO] decimal(15,4)  NULL,
    [ORDEMRESULTADOTAXAINTERNARETORNO] int  NULL,
    [APROVACAORESULTADOTAXAINTERNARETORNO] varchar(5)  NULL,
    [RESULTADODICE] decimal(15,4)  NULL,
    [ORDEMRESULTADODICE] int  NULL,
    [APROVACAORESULTADODICE] varchar(5)  NULL,
    [CAPACIDADEENTREGAEQUPE] int  NULL,
    [APOIOALTAGESTAO] int  NULL,
    [APOIOSTEAKHOLDERS] int  NULL,
    [ESFORCOADICIONAL] int  NULL,
    [RESULTADOAHP] decimal(15,4)  NULL,
    [ORDEMRESULTADOAHP] int  NULL,
    [APROVACAORESULTADOAHP] varchar(5)  NULL
);
GO

-- Creating table 'REUNIOES'
CREATE TABLE [dbo].[REUNIOES] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [DESCRICAO] nvarchar(50)  NOT NULL,
    [DATAHORAEVENTO] datetime  NULL,
    [DATACRIACAO] datetime  NULL,
    [PAYBACKACEITAVEL] decimal(15,4)  NULL,
    [TAXAREMUNERACAOMERCADO] decimal(15,4)  NULL,
    [PAUTADESCRICAO] varchar(max)  NULL,
    [LOCAL] nvarchar(50)  NULL,
    [RESPONSAVEL] bigint  NULL,
    [AHPCALCULADO] tinyint  NULL,
    [SITUACAO] varchar(15)  NULL,
    [TAXACUSTOCAPITAL] decimal(15,4)  NULL
);
GO

-- Creating table 'PROJETOS'
CREATE TABLE [dbo].[PROJETOS] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [NOME] nvarchar(50)  NOT NULL,
    [DESCRICAO] nvarchar(100)  NULL,
    [OBSERVACAO] varchar(max)  NULL,
    [GERENTE] bigint  NOT NULL,
    [DATACRIACAO] datetime  NULL,
    [INVESTIMENTOPREVISTO] decimal(15,4)  NULL,
    [RECEITACONSTANTE] decimal(15,4)  NULL,
    [RAZAORECEITAVALOR] decimal(15,4)  NULL,
    [RAZAORECEITAPERCENTUAL] decimal(7,3)  NULL,
    [TEMPOPREVISTOCONCLUSAO] decimal(7,3)  NULL,
    [STATUS] tinyint  NULL,
    [CAPACIDADEENTREGAEQUIPE] int  NULL,
    [APOIOALTAGESTAO] int  NULL,
    [APOIOSTEAKHOLDERS] int  NULL,
    [ESFORCOADICIONAL] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'COMPETENCIAS'
ALTER TABLE [dbo].[COMPETENCIAS]
ADD CONSTRAINT [PK_COMPETENCIAS]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [IDPROJETO], [IDCOMPETENCIA] in table 'COMPETENCIASEXIGIDAS'
ALTER TABLE [dbo].[COMPETENCIASEXIGIDAS]
ADD CONSTRAINT [PK_COMPETENCIASEXIGIDAS]
    PRIMARY KEY CLUSTERED ([IDPROJETO], [IDCOMPETENCIA] ASC);
GO

-- Creating primary key on [ID] in table 'PERFILUSUARIOs'
ALTER TABLE [dbo].[PERFILUSUARIOs]
ADD CONSTRAINT [PK_PERFILUSUARIOs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PERMISSOES'
ALTER TABLE [dbo].[PERMISSOES]
ADD CONSTRAINT [PK_PERMISSOES]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [IDPESSOA], [IDCOMPETENCIA] in table 'PESSOACOMPETENCIAS'
ALTER TABLE [dbo].[PESSOACOMPETENCIAS]
ADD CONSTRAINT [PK_PESSOACOMPETENCIAS]
    PRIMARY KEY CLUSTERED ([IDPESSOA], [IDCOMPETENCIA] ASC);
GO

-- Creating primary key on [ID] in table 'PESSOAS'
ALTER TABLE [dbo].[PESSOAS]
ADD CONSTRAINT [PK_PESSOAS]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PROJETOSPESSOAS'
ALTER TABLE [dbo].[PROJETOSPESSOAS]
ADD CONSTRAINT [PK_PROJETOSPESSOAS]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [IDREUNIAO], [IDPESSOA] in table 'REUNIOESPARTICIPANTES'
ALTER TABLE [dbo].[REUNIOESPARTICIPANTES]
ADD CONSTRAINT [PK_REUNIOESPARTICIPANTES]
    PRIMARY KEY CLUSTERED ([IDREUNIAO], [IDPESSOA] ASC);
GO

-- Creating primary key on [ID] in table 'USUARIOS'
ALTER TABLE [dbo].[USUARIOS]
ADD CONSTRAINT [PK_USUARIOS]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CRITERIOS'
ALTER TABLE [dbo].[CRITERIOS]
ADD CONSTRAINT [PK_CRITERIOS]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CRITERIOSCOMPARACOES'
ALTER TABLE [dbo].[CRITERIOSCOMPARACOES]
ADD CONSTRAINT [PK_CRITERIOSCOMPARACOES]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CRITERIOSPROJETOSCOMPARACOES'
ALTER TABLE [dbo].[CRITERIOSPROJETOSCOMPARACOES]
ADD CONSTRAINT [PK_CRITERIOSPROJETOSCOMPARACOES]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CRITERIOSRESULTADOes'
ALTER TABLE [dbo].[CRITERIOSRESULTADOes]
ADD CONSTRAINT [PK_CRITERIOSRESULTADOes]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CRITERIOSRESULTADOLISTAs'
ALTER TABLE [dbo].[CRITERIOSRESULTADOLISTAs]
ADD CONSTRAINT [PK_CRITERIOSRESULTADOLISTAs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CRITERIOSPROJETOSRESULTADOes'
ALTER TABLE [dbo].[CRITERIOSPROJETOSRESULTADOes]
ADD CONSTRAINT [PK_CRITERIOSPROJETOSRESULTADOes]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CRITERIOSPROJETOSRESULTADOLISTAs'
ALTER TABLE [dbo].[CRITERIOSPROJETOSRESULTADOLISTAs]
ADD CONSTRAINT [PK_CRITERIOSPROJETOSRESULTADOLISTAs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'RECEITAVARIAVELs'
ALTER TABLE [dbo].[RECEITAVARIAVELs]
ADD CONSTRAINT [PK_RECEITAVARIAVELs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PAUTARECEITAVARIAVELs'
ALTER TABLE [dbo].[PAUTARECEITAVARIAVELs]
ADD CONSTRAINT [PK_PAUTARECEITAVARIAVELs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PAUTAPROJETOS'
ALTER TABLE [dbo].[PAUTAPROJETOS]
ADD CONSTRAINT [PK_PAUTAPROJETOS]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'REUNIOES'
ALTER TABLE [dbo].[REUNIOES]
ADD CONSTRAINT [PK_REUNIOES]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PROJETOS'
ALTER TABLE [dbo].[PROJETOS]
ADD CONSTRAINT [PK_PROJETOS]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IDCOMPETENCIA] in table 'COMPETENCIASEXIGIDAS'
ALTER TABLE [dbo].[COMPETENCIASEXIGIDAS]
ADD CONSTRAINT [FK__COMPETENC__IDCOM__300424B4]
    FOREIGN KEY ([IDCOMPETENCIA])
    REFERENCES [dbo].[COMPETENCIAS]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__COMPETENC__IDCOM__300424B4'
CREATE INDEX [IX_FK__COMPETENC__IDCOM__300424B4]
ON [dbo].[COMPETENCIASEXIGIDAS]
    ([IDCOMPETENCIA]);
GO

-- Creating foreign key on [IDCOMPETENCIA] in table 'PESSOACOMPETENCIAS'
ALTER TABLE [dbo].[PESSOACOMPETENCIAS]
ADD CONSTRAINT [FK__PESSOACOM__IDCOM__22AA2996]
    FOREIGN KEY ([IDCOMPETENCIA])
    REFERENCES [dbo].[COMPETENCIAS]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__PESSOACOM__IDCOM__22AA2996'
CREATE INDEX [IX_FK__PESSOACOM__IDCOM__22AA2996]
ON [dbo].[PESSOACOMPETENCIAS]
    ([IDCOMPETENCIA]);
GO

-- Creating foreign key on [ID] in table 'PERMISSOES'
ALTER TABLE [dbo].[PERMISSOES]
ADD CONSTRAINT [FK__PERMISSOES__ID__1367E606]
    FOREIGN KEY ([ID])
    REFERENCES [dbo].[PERFILUSUARIOs]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PERFILUSUARIO] in table 'USUARIOS'
ALTER TABLE [dbo].[USUARIOS]
ADD CONSTRAINT [FK__USUARIOS__PERFIL__173876EA]
    FOREIGN KEY ([PERFILUSUARIO])
    REFERENCES [dbo].[PERFILUSUARIOs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__USUARIOS__PERFIL__173876EA'
CREATE INDEX [IX_FK__USUARIOS__PERFIL__173876EA]
ON [dbo].[USUARIOS]
    ([PERFILUSUARIO]);
GO

-- Creating foreign key on [IDPESSOA] in table 'PESSOACOMPETENCIAS'
ALTER TABLE [dbo].[PESSOACOMPETENCIAS]
ADD CONSTRAINT [FK__PESSOACOM__IDPES__21B6055D]
    FOREIGN KEY ([IDPESSOA])
    REFERENCES [dbo].[PESSOAS]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IDPESSOA] in table 'PROJETOSPESSOAS'
ALTER TABLE [dbo].[PROJETOSPESSOAS]
ADD CONSTRAINT [FK__PROJETOSP__IDPES__29572725]
    FOREIGN KEY ([IDPESSOA])
    REFERENCES [dbo].[PESSOAS]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__PROJETOSP__IDPES__29572725'
CREATE INDEX [IX_FK__PROJETOSP__IDPES__29572725]
ON [dbo].[PROJETOSPESSOAS]
    ([IDPESSOA]);
GO

-- Creating foreign key on [IDPESSOA] in table 'REUNIOESPARTICIPANTES'
ALTER TABLE [dbo].[REUNIOESPARTICIPANTES]
ADD CONSTRAINT [FK__REUNIOESP__IDPES__3D5E1FD2]
    FOREIGN KEY ([IDPESSOA])
    REFERENCES [dbo].[PESSOAS]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__REUNIOESP__IDPES__3D5E1FD2'
CREATE INDEX [IX_FK__REUNIOESP__IDPES__3D5E1FD2]
ON [dbo].[REUNIOESPARTICIPANTES]
    ([IDPESSOA]);
GO

-- Creating foreign key on [IDCRITERIOA] in table 'CRITERIOSCOMPARACOES'
ALTER TABLE [dbo].[CRITERIOSCOMPARACOES]
ADD CONSTRAINT [FK__CRITERIOS__CRITE__503BEA1C]
    FOREIGN KEY ([IDCRITERIOA])
    REFERENCES [dbo].[CRITERIOS]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CRITERIOS__CRITE__503BEA1C'
CREATE INDEX [IX_FK__CRITERIOS__CRITE__503BEA1C]
ON [dbo].[CRITERIOSCOMPARACOES]
    ([IDCRITERIOA]);
GO

-- Creating foreign key on [IDCRITERIOB] in table 'CRITERIOSCOMPARACOES'
ALTER TABLE [dbo].[CRITERIOSCOMPARACOES]
ADD CONSTRAINT [FK__CRITERIOS__CRITE__51300E55]
    FOREIGN KEY ([IDCRITERIOB])
    REFERENCES [dbo].[CRITERIOS]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CRITERIOS__CRITE__51300E55'
CREATE INDEX [IX_FK__CRITERIOS__CRITE__51300E55]
ON [dbo].[CRITERIOSCOMPARACOES]
    ([IDCRITERIOB]);
GO

-- Creating foreign key on [IDCRITERIO] in table 'CRITERIOSPROJETOSCOMPARACOES'
ALTER TABLE [dbo].[CRITERIOSPROJETOSCOMPARACOES]
ADD CONSTRAINT [FK__CRITERIOS__IDCRI__76619304]
    FOREIGN KEY ([IDCRITERIO])
    REFERENCES [dbo].[CRITERIOS]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CRITERIOS__IDCRI__76619304'
CREATE INDEX [IX_FK__CRITERIOS__IDCRI__76619304]
ON [dbo].[CRITERIOSPROJETOSCOMPARACOES]
    ([IDCRITERIO]);
GO

-- Creating foreign key on [IDCRITERIO] in table 'CRITERIOSRESULTADOes'
ALTER TABLE [dbo].[CRITERIOSRESULTADOes]
ADD CONSTRAINT [FK__CRITERIOS__IDCRI__0880433F]
    FOREIGN KEY ([IDCRITERIO])
    REFERENCES [dbo].[CRITERIOS]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CRITERIOS__IDCRI__0880433F'
CREATE INDEX [IX_FK__CRITERIOS__IDCRI__0880433F]
ON [dbo].[CRITERIOSRESULTADOes]
    ([IDCRITERIO]);
GO

-- Creating foreign key on [IDCRITERIO] in table 'CRITERIOSRESULTADOLISTAs'
ALTER TABLE [dbo].[CRITERIOSRESULTADOLISTAs]
ADD CONSTRAINT [FK__CRITERIOS__IDCRI__0D44F85C]
    FOREIGN KEY ([IDCRITERIO])
    REFERENCES [dbo].[CRITERIOS]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CRITERIOS__IDCRI__0D44F85C'
CREATE INDEX [IX_FK__CRITERIOS__IDCRI__0D44F85C]
ON [dbo].[CRITERIOSRESULTADOLISTAs]
    ([IDCRITERIO]);
GO

-- Creating foreign key on [IDCRITERIORESULTADO] in table 'CRITERIOSRESULTADOLISTAs'
ALTER TABLE [dbo].[CRITERIOSRESULTADOLISTAs]
ADD CONSTRAINT [FK__CRITERIOS__IDCRI__0C50D423]
    FOREIGN KEY ([IDCRITERIORESULTADO])
    REFERENCES [dbo].[CRITERIOSRESULTADOes]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CRITERIOS__IDCRI__0C50D423'
CREATE INDEX [IX_FK__CRITERIOS__IDCRI__0C50D423]
ON [dbo].[CRITERIOSRESULTADOLISTAs]
    ([IDCRITERIORESULTADO]);
GO

-- Creating foreign key on [IDCRITERIOSRESULTADO] in table 'CRITERIOSPROJETOSRESULTADOes'
ALTER TABLE [dbo].[CRITERIOSPROJETOSRESULTADOes]
ADD CONSTRAINT [FK__CRITERIOS__IDCRI__214BF109]
    FOREIGN KEY ([IDCRITERIOSRESULTADO])
    REFERENCES [dbo].[CRITERIOSRESULTADOes]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CRITERIOS__IDCRI__214BF109'
CREATE INDEX [IX_FK__CRITERIOS__IDCRI__214BF109]
ON [dbo].[CRITERIOSPROJETOSRESULTADOes]
    ([IDCRITERIOSRESULTADO]);
GO

-- Creating foreign key on [IDCRITERIOSPROJETOSRESULTADO] in table 'CRITERIOSPROJETOSRESULTADOLISTAs'
ALTER TABLE [dbo].[CRITERIOSPROJETOSRESULTADOLISTAs]
ADD CONSTRAINT [FK__CRITERIOS__IDCRI__2F9A1060]
    FOREIGN KEY ([IDCRITERIOSPROJETOSRESULTADO])
    REFERENCES [dbo].[CRITERIOSPROJETOSRESULTADOes]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CRITERIOS__IDCRI__2F9A1060'
CREATE INDEX [IX_FK__CRITERIOS__IDCRI__2F9A1060]
ON [dbo].[CRITERIOSPROJETOSRESULTADOLISTAs]
    ([IDCRITERIOSPROJETOSRESULTADO]);
GO

-- Creating foreign key on [IDREUNIAO] in table 'CRITERIOSPROJETOSRESULTADOes'
ALTER TABLE [dbo].[CRITERIOSPROJETOSRESULTADOes]
ADD CONSTRAINT [FK__CRITERIOS__IDREU__6ABAD62E]
    FOREIGN KEY ([IDREUNIAO])
    REFERENCES [dbo].[REUNIOES]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CRITERIOS__IDREU__6ABAD62E'
CREATE INDEX [IX_FK__CRITERIOS__IDREU__6ABAD62E]
ON [dbo].[CRITERIOSPROJETOSRESULTADOes]
    ([IDREUNIAO]);
GO

-- Creating foreign key on [IDREUNIAO] in table 'CRITERIOSRESULTADOes'
ALTER TABLE [dbo].[CRITERIOSRESULTADOes]
ADD CONSTRAINT [FK__CRITERIOS__IDREU__52E34C9D]
    FOREIGN KEY ([IDREUNIAO])
    REFERENCES [dbo].[REUNIOES]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CRITERIOS__IDREU__52E34C9D'
CREATE INDEX [IX_FK__CRITERIOS__IDREU__52E34C9D]
ON [dbo].[CRITERIOSRESULTADOes]
    ([IDREUNIAO]);
GO

-- Creating foreign key on [IDREUNIAO] in table 'PAUTAPROJETOS'
ALTER TABLE [dbo].[PAUTAPROJETOS]
ADD CONSTRAINT [FK__PAUTAPROJ__IDREU__4830B400]
    FOREIGN KEY ([IDREUNIAO])
    REFERENCES [dbo].[REUNIOES]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__PAUTAPROJ__IDREU__4830B400'
CREATE INDEX [IX_FK__PAUTAPROJ__IDREU__4830B400]
ON [dbo].[PAUTAPROJETOS]
    ([IDREUNIAO]);
GO

-- Creating foreign key on [IDPAUTAPROJETO] in table 'PAUTARECEITAVARIAVELs'
ALTER TABLE [dbo].[PAUTARECEITAVARIAVELs]
ADD CONSTRAINT [FK__PAUTARECE__IDPAU__6F4A8121]
    FOREIGN KEY ([IDPAUTAPROJETO])
    REFERENCES [dbo].[PAUTAPROJETOS]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__PAUTARECE__IDPAU__6F4A8121'
CREATE INDEX [IX_FK__PAUTARECE__IDPAU__6F4A8121]
ON [dbo].[PAUTARECEITAVARIAVELs]
    ([IDPAUTAPROJETO]);
GO

-- Creating foreign key on [RESPONSAVEL] in table 'REUNIOES'
ALTER TABLE [dbo].[REUNIOES]
ADD CONSTRAINT [FK__REUNIOES__RESPON__37A5467C]
    FOREIGN KEY ([RESPONSAVEL])
    REFERENCES [dbo].[PESSOAS]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__REUNIOES__RESPON__37A5467C'
CREATE INDEX [IX_FK__REUNIOES__RESPON__37A5467C]
ON [dbo].[REUNIOES]
    ([RESPONSAVEL]);
GO

-- Creating foreign key on [IDREUNIAO] in table 'REUNIOESPARTICIPANTES'
ALTER TABLE [dbo].[REUNIOESPARTICIPANTES]
ADD CONSTRAINT [FK__REUNIOESP__IDREU__3C69FB99]
    FOREIGN KEY ([IDREUNIAO])
    REFERENCES [dbo].[REUNIOES]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IDPROJETO] in table 'COMPETENCIASEXIGIDAS'
ALTER TABLE [dbo].[COMPETENCIASEXIGIDAS]
ADD CONSTRAINT [FK__COMPETENC__IDPRO__2F10007B]
    FOREIGN KEY ([IDPROJETO])
    REFERENCES [dbo].[PROJETOS]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IDPROJETOA] in table 'CRITERIOSPROJETOSCOMPARACOES'
ALTER TABLE [dbo].[CRITERIOSPROJETOSCOMPARACOES]
ADD CONSTRAINT [FK__CRITERIOS__IDPRO__7755B73D]
    FOREIGN KEY ([IDPROJETOA])
    REFERENCES [dbo].[PROJETOS]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CRITERIOS__IDPRO__7755B73D'
CREATE INDEX [IX_FK__CRITERIOS__IDPRO__7755B73D]
ON [dbo].[CRITERIOSPROJETOSCOMPARACOES]
    ([IDPROJETOA]);
GO

-- Creating foreign key on [IDPROJETOB] in table 'CRITERIOSPROJETOSCOMPARACOES'
ALTER TABLE [dbo].[CRITERIOSPROJETOSCOMPARACOES]
ADD CONSTRAINT [FK__CRITERIOS__IDPRO__7849DB76]
    FOREIGN KEY ([IDPROJETOB])
    REFERENCES [dbo].[PROJETOS]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CRITERIOS__IDPRO__7849DB76'
CREATE INDEX [IX_FK__CRITERIOS__IDPRO__7849DB76]
ON [dbo].[CRITERIOSPROJETOSCOMPARACOES]
    ([IDPROJETOB]);
GO

-- Creating foreign key on [IDPROJETO] in table 'CRITERIOSPROJETOSRESULTADOes'
ALTER TABLE [dbo].[CRITERIOSPROJETOSRESULTADOes]
ADD CONSTRAINT [FK__CRITERIOS__IDPRO__68D28DBC]
    FOREIGN KEY ([IDPROJETO])
    REFERENCES [dbo].[PROJETOS]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CRITERIOS__IDPRO__68D28DBC'
CREATE INDEX [IX_FK__CRITERIOS__IDPRO__68D28DBC]
ON [dbo].[CRITERIOSPROJETOSRESULTADOes]
    ([IDPROJETO]);
GO

-- Creating foreign key on [IDPROJETO] in table 'CRITERIOSPROJETOSRESULTADOLISTAs'
ALTER TABLE [dbo].[CRITERIOSPROJETOSRESULTADOLISTAs]
ADD CONSTRAINT [FK__CRITERIOS__IDPRO__308E3499]
    FOREIGN KEY ([IDPROJETO])
    REFERENCES [dbo].[PROJETOS]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CRITERIOS__IDPRO__308E3499'
CREATE INDEX [IX_FK__CRITERIOS__IDPRO__308E3499]
ON [dbo].[CRITERIOSPROJETOSRESULTADOLISTAs]
    ([IDPROJETO]);
GO

-- Creating foreign key on [IDPROJETO] in table 'PAUTAPROJETOS'
ALTER TABLE [dbo].[PAUTAPROJETOS]
ADD CONSTRAINT [FK__PAUTAPROJ__IDPRO__4924D839]
    FOREIGN KEY ([IDPROJETO])
    REFERENCES [dbo].[PROJETOS]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__PAUTAPROJ__IDPRO__4924D839'
CREATE INDEX [IX_FK__PAUTAPROJ__IDPRO__4924D839]
ON [dbo].[PAUTAPROJETOS]
    ([IDPROJETO]);
GO

-- Creating foreign key on [GERENTE] in table 'PROJETOS'
ALTER TABLE [dbo].[PROJETOS]
ADD CONSTRAINT [FK__PROJETOS__GERENT__267ABA7A]
    FOREIGN KEY ([GERENTE])
    REFERENCES [dbo].[PESSOAS]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__PROJETOS__GERENT__267ABA7A'
CREATE INDEX [IX_FK__PROJETOS__GERENT__267ABA7A]
ON [dbo].[PROJETOS]
    ([GERENTE]);
GO

-- Creating foreign key on [IDPROJETO] in table 'PROJETOSPESSOAS'
ALTER TABLE [dbo].[PROJETOSPESSOAS]
ADD CONSTRAINT [FK__PROJETOSP__IDPRO__2A4B4B5E]
    FOREIGN KEY ([IDPROJETO])
    REFERENCES [dbo].[PROJETOS]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__PROJETOSP__IDPRO__2A4B4B5E'
CREATE INDEX [IX_FK__PROJETOSP__IDPRO__2A4B4B5E]
ON [dbo].[PROJETOSPESSOAS]
    ([IDPROJETO]);
GO

-- Creating foreign key on [IDPROJETO] in table 'RECEITAVARIAVELs'
ALTER TABLE [dbo].[RECEITAVARIAVELs]
ADD CONSTRAINT [FK__RECEITAVA__IDPRO__2F650636]
    FOREIGN KEY ([IDPROJETO])
    REFERENCES [dbo].[PROJETOS]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__RECEITAVA__IDPRO__2F650636'
CREATE INDEX [IX_FK__RECEITAVA__IDPRO__2F650636]
ON [dbo].[RECEITAVARIAVELs]
    ([IDPROJETO]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------