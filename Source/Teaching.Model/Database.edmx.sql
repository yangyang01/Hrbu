
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/17/2014 15:20:17
-- Generated from EDMX file: E:\Teach\Teaching\Teaching.Model\Database.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TCMG];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[DataDic]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DataDic];
GO
IF OBJECT_ID(N'[dbo].[DataDicInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DataDicInfo];
GO
IF OBJECT_ID(N'[dbo].[Menu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Menu];
GO
IF OBJECT_ID(N'[dbo].[Role]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Role];
GO
IF OBJECT_ID(N'[dbo].[StudentBasicInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StudentBasicInfo];
GO
IF OBJECT_ID(N'[dbo].[TeacherBasicInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeacherBasicInfo];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DataDic'
CREATE TABLE [dbo].[DataDic] (
    [id] int  NOT NULL,
    [DataName] varchar(200)  NULL
);
GO

-- Creating table 'DataDicInfo'
CREATE TABLE [dbo].[DataDicInfo] (
    [Id] int  NOT NULL,
    [InfoName] varchar(200)  NULL,
    [DataDicId] int  NULL
);
GO

-- Creating table 'Menu'
CREATE TABLE [dbo].[Menu] (
    [Id] int  NOT NULL,
    [URL] nvarchar(500)  NOT NULL,
    [NameCn] nvarchar(200)  NULL,
    [NameEn] nvarchar(200)  NOT NULL,
    [ParentId] int  NOT NULL,
    [SeqNo] int  NOT NULL
);
GO

-- Creating table 'Role'
CREATE TABLE [dbo].[Role] (
    [Id] int  NOT NULL,
    [roleName] nvarchar(200)  NOT NULL,
    [describe] char(200)  NULL
);
GO

-- Creating table 'StudentBasicInfo'
CREATE TABLE [dbo].[StudentBasicInfo] (
    [id] int  NOT NULL,
    [StudentNo] nvarchar(200)  NOT NULL,
    [Name] nvarchar(200)  NOT NULL,
    [Sex] char(2)  NULL,
    [Major] nvarchar(200)  NULL,
    [Class] nvarchar(200)  NULL,
    [Address] nvarchar(500)  NULL,
    [Tel] nvarchar(50)  NULL,
    [Mail] nvarchar(100)  NULL,
    [Photo] nvarchar(500)  NULL,
    [ZipCope] nvarchar(50)  NULL,
    [Contacts] nvarchar(200)  NULL
);
GO

-- Creating table 'TeacherBasicInfo'
CREATE TABLE [dbo].[TeacherBasicInfo] (
    [Id] int  NOT NULL,
    [EmpNo] nvarchar(200)  NOT NULL,
    [Name] nvarchar(200)  NOT NULL,
    [Sex] char(2)  NULL,
    [Collage] nvarchar(200)  NULL,
    [Major] nvarchar(200)  NULL,
    [Address] nvarchar(500)  NULL,
    [Tel] nvarchar(50)  NULL,
    [Mail] nvarchar(100)  NULL,
    [Photo] nvarchar(500)  NULL,
    [Course1] nvarchar(200)  NULL,
    [Course2] nvarchar(200)  NULL,
    [Course3] nvarchar(200)  NULL,
    [Course4] nvarchar(200)  NULL,
    [PATP] nvarchar(200)  NULL,
    [HightestDegree] nvarchar(200)  NULL,
    [GraduationSchool] nvarchar(200)  NULL,
    [IndividualResume] nvarchar(200)  NULL,
    [IdentityType] nvarchar(200)  NULL
);
GO

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [Id] int  NOT NULL,
    [UserName] nvarchar(200)  NOT NULL,
    [UserNo] nvarchar(200)  NOT NULL,
    [Password] nvarchar(200)  NOT NULL,
    [RoleId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'DataDic'
ALTER TABLE [dbo].[DataDic]
ADD CONSTRAINT [PK_DataDic]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'DataDicInfo'
ALTER TABLE [dbo].[DataDicInfo]
ADD CONSTRAINT [PK_DataDicInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Menu'
ALTER TABLE [dbo].[Menu]
ADD CONSTRAINT [PK_Menu]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Role'
ALTER TABLE [dbo].[Role]
ADD CONSTRAINT [PK_Role]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table 'StudentBasicInfo'
ALTER TABLE [dbo].[StudentBasicInfo]
ADD CONSTRAINT [PK_StudentBasicInfo]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'TeacherBasicInfo'
ALTER TABLE [dbo].[TeacherBasicInfo]
ADD CONSTRAINT [PK_TeacherBasicInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------