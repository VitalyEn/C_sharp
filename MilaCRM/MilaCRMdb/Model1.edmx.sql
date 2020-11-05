
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/22/2019 13:47:04
-- Generated from EDMX file: C:\Users\Engel\source\repos\MilaCRM\MilaCRMdb\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Mila_db];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FIOVizit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VizitSet] DROP CONSTRAINT [FK_FIOVizit];
GO
IF OBJECT_ID(N'[dbo].[FK_AnamnezVizit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VizitSet] DROP CONSTRAINT [FK_AnamnezVizit];
GO
IF OBJECT_ID(N'[dbo].[FK_DiagnozVizit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VizitSet] DROP CONSTRAINT [FK_DiagnozVizit];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AnamnezSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AnamnezSet];
GO
IF OBJECT_ID(N'[dbo].[DiagnozSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DiagnozSet];
GO
IF OBJECT_ID(N'[dbo].[FIOSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FIOSet];
GO
IF OBJECT_ID(N'[dbo].[VizitSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VizitSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AnamnezSet'
CREATE TABLE [dbo].[AnamnezSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Anam] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DiagnozSet'
CREATE TABLE [dbo].[DiagnozSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Diag] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FIOSet'
CREATE TABLE [dbo].[FIOSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SerName] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [SecondName] nvarchar(max)  NOT NULL,
    [BirthDate] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'VizitSet'
CREATE TABLE [dbo].[VizitSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [VizitDate] nvarchar(max)  NOT NULL,
    [Weight] nvarchar(max)  NOT NULL,
    [Height] nvarchar(max)  NOT NULL,
    [FIO_Id] int  NOT NULL,
    [Anamnez_Id] int  NOT NULL,
    [Diagnoz_Id] int  NOT NULL,
    [Claim_Id] int  NOT NULL
);
GO

-- Creating table 'ClaimsSet'
CREATE TABLE [dbo].[ClaimsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Claim] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AnamnezSet'
ALTER TABLE [dbo].[AnamnezSet]
ADD CONSTRAINT [PK_AnamnezSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DiagnozSet'
ALTER TABLE [dbo].[DiagnozSet]
ADD CONSTRAINT [PK_DiagnozSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FIOSet'
ALTER TABLE [dbo].[FIOSet]
ADD CONSTRAINT [PK_FIOSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VizitSet'
ALTER TABLE [dbo].[VizitSet]
ADD CONSTRAINT [PK_VizitSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClaimsSet'
ALTER TABLE [dbo].[ClaimsSet]
ADD CONSTRAINT [PK_ClaimsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [FIO_Id] in table 'VizitSet'
ALTER TABLE [dbo].[VizitSet]
ADD CONSTRAINT [FK_FIOVizit]
    FOREIGN KEY ([FIO_Id])
    REFERENCES [dbo].[FIOSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FIOVizit'
CREATE INDEX [IX_FK_FIOVizit]
ON [dbo].[VizitSet]
    ([FIO_Id]);
GO

-- Creating foreign key on [Anamnez_Id] in table 'VizitSet'
ALTER TABLE [dbo].[VizitSet]
ADD CONSTRAINT [FK_AnamnezVizit]
    FOREIGN KEY ([Anamnez_Id])
    REFERENCES [dbo].[AnamnezSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AnamnezVizit'
CREATE INDEX [IX_FK_AnamnezVizit]
ON [dbo].[VizitSet]
    ([Anamnez_Id]);
GO

-- Creating foreign key on [Diagnoz_Id] in table 'VizitSet'
ALTER TABLE [dbo].[VizitSet]
ADD CONSTRAINT [FK_DiagnozVizit]
    FOREIGN KEY ([Diagnoz_Id])
    REFERENCES [dbo].[DiagnozSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DiagnozVizit'
CREATE INDEX [IX_FK_DiagnozVizit]
ON [dbo].[VizitSet]
    ([Diagnoz_Id]);
GO

-- Creating foreign key on [Claim_Id] in table 'VizitSet'
ALTER TABLE [dbo].[VizitSet]
ADD CONSTRAINT [FK_ClaimsVizit]
    FOREIGN KEY ([Claim_Id])
    REFERENCES [dbo].[ClaimsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClaimsVizit'
CREATE INDEX [IX_FK_ClaimsVizit]
ON [dbo].[VizitSet]
    ([Claim_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------