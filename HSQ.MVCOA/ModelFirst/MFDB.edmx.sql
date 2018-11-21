
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/21/2018 21:39:57
-- Generated from EDMX file: D:\视频教学\MVC\MVCOA-again\MVCOA-STUDY\HSQ.MVCOA\ModelFirst\MFDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MFDBTest];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CustomerProduct_Customer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerProduct] DROP CONSTRAINT [FK_CustomerProduct_Customer];
GO
IF OBJECT_ID(N'[dbo].[FK_CustomerProduct_Product]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerProduct] DROP CONSTRAINT [FK_CustomerProduct_Product];
GO
IF OBJECT_ID(N'[dbo].[FK_CustomerOrderInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderInfoes] DROP CONSTRAINT [FK_CustomerOrderInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_CustomerR_Customer_Role]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[R_Customer_Role] DROP CONSTRAINT [FK_CustomerR_Customer_Role];
GO
IF OBJECT_ID(N'[dbo].[FK_RoleR_Customer_Role]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[R_Customer_Role] DROP CONSTRAINT [FK_RoleR_Customer_Role];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[OrderInfoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderInfoes];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO
IF OBJECT_ID(N'[dbo].[R_Customer_Role]', 'U') IS NOT NULL
    DROP TABLE [dbo].[R_Customer_Role];
GO
IF OBJECT_ID(N'[dbo].[CustomerProduct]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerProduct];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CustomerName] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'OrderInfoes'
CREATE TABLE [dbo].[OrderInfoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OrderContent] nvarchar(max)  NOT NULL,
    [CustomerId] int  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'R_Customer_Role'
CREATE TABLE [dbo].[R_Customer_Role] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CustomerId] int  NOT NULL,
    [RoleId] int  NOT NULL
);
GO

-- Creating table 'CustomerProduct'
CREATE TABLE [dbo].[CustomerProduct] (
    [Customers_Id] int  NOT NULL,
    [Products_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrderInfoes'
ALTER TABLE [dbo].[OrderInfoes]
ADD CONSTRAINT [PK_OrderInfoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'R_Customer_Role'
ALTER TABLE [dbo].[R_Customer_Role]
ADD CONSTRAINT [PK_R_Customer_Role]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Customers_Id], [Products_Id] in table 'CustomerProduct'
ALTER TABLE [dbo].[CustomerProduct]
ADD CONSTRAINT [PK_CustomerProduct]
    PRIMARY KEY CLUSTERED ([Customers_Id], [Products_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Customers_Id] in table 'CustomerProduct'
ALTER TABLE [dbo].[CustomerProduct]
ADD CONSTRAINT [FK_CustomerProduct_Customer]
    FOREIGN KEY ([Customers_Id])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Products_Id] in table 'CustomerProduct'
ALTER TABLE [dbo].[CustomerProduct]
ADD CONSTRAINT [FK_CustomerProduct_Product]
    FOREIGN KEY ([Products_Id])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerProduct_Product'
CREATE INDEX [IX_FK_CustomerProduct_Product]
ON [dbo].[CustomerProduct]
    ([Products_Id]);
GO

-- Creating foreign key on [CustomerId] in table 'R_Customer_Role'
ALTER TABLE [dbo].[R_Customer_Role]
ADD CONSTRAINT [FK_CustomerR_Customer_Role]
    FOREIGN KEY ([CustomerId])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerR_Customer_Role'
CREATE INDEX [IX_FK_CustomerR_Customer_Role]
ON [dbo].[R_Customer_Role]
    ([CustomerId]);
GO

-- Creating foreign key on [RoleId] in table 'R_Customer_Role'
ALTER TABLE [dbo].[R_Customer_Role]
ADD CONSTRAINT [FK_RoleR_Customer_Role]
    FOREIGN KEY ([RoleId])
    REFERENCES [dbo].[Roles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RoleR_Customer_Role'
CREATE INDEX [IX_FK_RoleR_Customer_Role]
ON [dbo].[R_Customer_Role]
    ([RoleId]);
GO

-- Creating foreign key on [CustomerId] in table 'OrderInfoes'
ALTER TABLE [dbo].[OrderInfoes]
ADD CONSTRAINT [FK_CustomerOrderInfo]
    FOREIGN KEY ([CustomerId])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerOrderInfo'
CREATE INDEX [IX_FK_CustomerOrderInfo]
ON [dbo].[OrderInfoes]
    ([CustomerId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------