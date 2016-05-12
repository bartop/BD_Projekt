
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/17/2016 19:21:43
-- Generated from EDMX file: d:\dokumenty\visual studio 2013\Projects\BD2_v1\BD2_v1\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [sqlFileTemp];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_SkillsPosesses]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PosessesSet] DROP CONSTRAINT [FK_SkillsPosesses];
GO
IF OBJECT_ID(N'[dbo].[FK_PosessesRecruited]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PosessesSet] DROP CONSTRAINT [FK_PosessesRecruited];
GO
IF OBJECT_ID(N'[dbo].[FK_DocumentsRecruited]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DocumentsSet] DROP CONSTRAINT [FK_DocumentsRecruited];
GO
IF OBJECT_ID(N'[dbo].[FK_SkillsDocuments_Skills]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SkillsDocuments] DROP CONSTRAINT [FK_SkillsDocuments_Skills];
GO
IF OBJECT_ID(N'[dbo].[FK_SkillsDocuments_Documents]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SkillsDocuments] DROP CONSTRAINT [FK_SkillsDocuments_Documents];
GO
IF OBJECT_ID(N'[dbo].[FK_SkillsRequires]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RequiresSet] DROP CONSTRAINT [FK_SkillsRequires];
GO
IF OBJECT_ID(N'[dbo].[FK_JobsRequires]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RequiresSet] DROP CONSTRAINT [FK_JobsRequires];
GO
IF OBJECT_ID(N'[dbo].[FK_RecruitedApplications]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ApplicationsSet] DROP CONSTRAINT [FK_RecruitedApplications];
GO
IF OBJECT_ID(N'[dbo].[FK_JobsApplications]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ApplicationsSet] DROP CONSTRAINT [FK_JobsApplications];
GO
IF OBJECT_ID(N'[dbo].[FK_StageStageGrades]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StageGradesSet] DROP CONSTRAINT [FK_StageStageGrades];
GO
IF OBJECT_ID(N'[dbo].[FK_ApplicationsStageGrades]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StageGradesSet] DROP CONSTRAINT [FK_ApplicationsStageGrades];
GO
IF OBJECT_ID(N'[dbo].[FK_JobsStage_Jobs]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JobsStage] DROP CONSTRAINT [FK_JobsStage_Jobs];
GO
IF OBJECT_ID(N'[dbo].[FK_JobsStage_Stage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JobsStage] DROP CONSTRAINT [FK_JobsStage_Stage];
GO
IF OBJECT_ID(N'[dbo].[FK_RolesWorkers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WorkersSet] DROP CONSTRAINT [FK_RolesWorkers];
GO
IF OBJECT_ID(N'[dbo].[FK_ApplicationsWorkers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ApplicationsSet] DROP CONSTRAINT [FK_ApplicationsWorkers];
GO
IF OBJECT_ID(N'[dbo].[FK_WorkersApplications]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ApplicationsSet] DROP CONSTRAINT [FK_WorkersApplications];
GO
IF OBJECT_ID(N'[dbo].[FK_StageWorkers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WorkersSet] DROP CONSTRAINT [FK_StageWorkers];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[RecruitedSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RecruitedSet];
GO
IF OBJECT_ID(N'[dbo].[SkillsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SkillsSet];
GO
IF OBJECT_ID(N'[dbo].[DocumentsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DocumentsSet];
GO
IF OBJECT_ID(N'[dbo].[PosessesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PosessesSet];
GO
IF OBJECT_ID(N'[dbo].[JobsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JobsSet];
GO
IF OBJECT_ID(N'[dbo].[RequiresSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RequiresSet];
GO
IF OBJECT_ID(N'[dbo].[ApplicationsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ApplicationsSet];
GO
IF OBJECT_ID(N'[dbo].[StageSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StageSet];
GO
IF OBJECT_ID(N'[dbo].[StageGradesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StageGradesSet];
GO
IF OBJECT_ID(N'[dbo].[WorkersSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WorkersSet];
GO
IF OBJECT_ID(N'[dbo].[RolesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolesSet];
GO
IF OBJECT_ID(N'[dbo].[SkillsDocuments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SkillsDocuments];
GO
IF OBJECT_ID(N'[dbo].[JobsStage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JobsStage];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'RecruitedSet'
CREATE TABLE [dbo].[RecruitedSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [DateOfBirth] nvarchar(max)  NOT NULL,
    [Education] nvarchar(max)  NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [PhoneNumber] nvarchar(max)  NOT NULL,
    [Nationality] nvarchar(max)  NOT NULL,
    [FathersName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SkillsSet'
CREATE TABLE [dbo].[SkillsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DocumentsSet'
CREATE TABLE [dbo].[DocumentsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [File] varbinary(max)  NOT NULL,
    [Recruited_Id] int  NOT NULL
);
GO

-- Creating table 'PosessesSet'
CREATE TABLE [dbo].[PosessesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Level] tinyint  NOT NULL,
    [Skills_Id] int  NOT NULL,
    [Recruited_Id] int  NOT NULL
);
GO

-- Creating table 'JobsSet'
CREATE TABLE [dbo].[JobsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RequiresSet'
CREATE TABLE [dbo].[RequiresSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Weight] float  NOT NULL,
    [Skills_Id] int  NOT NULL,
    [Jobs_Id] int  NOT NULL
);
GO

-- Creating table 'ApplicationsSet'
CREATE TABLE [dbo].[ApplicationsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Explenation] nvarchar(max)  NOT NULL,
    [YearsOfExpirience] tinyint  NOT NULL,
    [Employed] bit  NOT NULL,
    [Resigned] bit  NOT NULL,
    [Approved] bit  NOT NULL,
    [Recruited_Id] int  NOT NULL,
    [Jobs_Id] int  NOT NULL,
    [Workers_Id] int  NOT NULL,
    [Workers1_Id] int  NOT NULL
);
GO

-- Creating table 'StageSet'
CREATE TABLE [dbo].[StageSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StageGradesSet'
CREATE TABLE [dbo].[StageGradesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Grade] tinyint  NULL,
    [Stage_Id] int  NOT NULL,
    [Applications_Id] int  NOT NULL
);
GO

-- Creating table 'WorkersSet'
CREATE TABLE [dbo].[WorkersSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [PasswordHash] nvarchar(max)  NOT NULL,
    [PrehashString] nvarchar(max)  NOT NULL,
    [Roles_Id] int  NOT NULL,
    [Stage_Id] int  NOT NULL
);
GO

-- Creating table 'RolesSet'
CREATE TABLE [dbo].[RolesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SkillsDocuments'
CREATE TABLE [dbo].[SkillsDocuments] (
    [Skills_Id] int  NOT NULL,
    [Documents_Id] int  NOT NULL
);
GO

-- Creating table 'JobsStage'
CREATE TABLE [dbo].[JobsStage] (
    [Jobs_Id] int  NOT NULL,
    [Stage_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'RecruitedSet'
ALTER TABLE [dbo].[RecruitedSet]
ADD CONSTRAINT [PK_RecruitedSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SkillsSet'
ALTER TABLE [dbo].[SkillsSet]
ADD CONSTRAINT [PK_SkillsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DocumentsSet'
ALTER TABLE [dbo].[DocumentsSet]
ADD CONSTRAINT [PK_DocumentsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PosessesSet'
ALTER TABLE [dbo].[PosessesSet]
ADD CONSTRAINT [PK_PosessesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JobsSet'
ALTER TABLE [dbo].[JobsSet]
ADD CONSTRAINT [PK_JobsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RequiresSet'
ALTER TABLE [dbo].[RequiresSet]
ADD CONSTRAINT [PK_RequiresSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ApplicationsSet'
ALTER TABLE [dbo].[ApplicationsSet]
ADD CONSTRAINT [PK_ApplicationsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StageSet'
ALTER TABLE [dbo].[StageSet]
ADD CONSTRAINT [PK_StageSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StageGradesSet'
ALTER TABLE [dbo].[StageGradesSet]
ADD CONSTRAINT [PK_StageGradesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WorkersSet'
ALTER TABLE [dbo].[WorkersSet]
ADD CONSTRAINT [PK_WorkersSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RolesSet'
ALTER TABLE [dbo].[RolesSet]
ADD CONSTRAINT [PK_RolesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Skills_Id], [Documents_Id] in table 'SkillsDocuments'
ALTER TABLE [dbo].[SkillsDocuments]
ADD CONSTRAINT [PK_SkillsDocuments]
    PRIMARY KEY CLUSTERED ([Skills_Id], [Documents_Id] ASC);
GO

-- Creating primary key on [Jobs_Id], [Stage_Id] in table 'JobsStage'
ALTER TABLE [dbo].[JobsStage]
ADD CONSTRAINT [PK_JobsStage]
    PRIMARY KEY CLUSTERED ([Jobs_Id], [Stage_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Skills_Id] in table 'PosessesSet'
ALTER TABLE [dbo].[PosessesSet]
ADD CONSTRAINT [FK_SkillsPosesses]
    FOREIGN KEY ([Skills_Id])
    REFERENCES [dbo].[SkillsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SkillsPosesses'
CREATE INDEX [IX_FK_SkillsPosesses]
ON [dbo].[PosessesSet]
    ([Skills_Id]);
GO

-- Creating foreign key on [Recruited_Id] in table 'PosessesSet'
ALTER TABLE [dbo].[PosessesSet]
ADD CONSTRAINT [FK_PosessesRecruited]
    FOREIGN KEY ([Recruited_Id])
    REFERENCES [dbo].[RecruitedSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PosessesRecruited'
CREATE INDEX [IX_FK_PosessesRecruited]
ON [dbo].[PosessesSet]
    ([Recruited_Id]);
GO

-- Creating foreign key on [Recruited_Id] in table 'DocumentsSet'
ALTER TABLE [dbo].[DocumentsSet]
ADD CONSTRAINT [FK_DocumentsRecruited]
    FOREIGN KEY ([Recruited_Id])
    REFERENCES [dbo].[RecruitedSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DocumentsRecruited'
CREATE INDEX [IX_FK_DocumentsRecruited]
ON [dbo].[DocumentsSet]
    ([Recruited_Id]);
GO

-- Creating foreign key on [Skills_Id] in table 'SkillsDocuments'
ALTER TABLE [dbo].[SkillsDocuments]
ADD CONSTRAINT [FK_SkillsDocuments_Skills]
    FOREIGN KEY ([Skills_Id])
    REFERENCES [dbo].[SkillsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Documents_Id] in table 'SkillsDocuments'
ALTER TABLE [dbo].[SkillsDocuments]
ADD CONSTRAINT [FK_SkillsDocuments_Documents]
    FOREIGN KEY ([Documents_Id])
    REFERENCES [dbo].[DocumentsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SkillsDocuments_Documents'
CREATE INDEX [IX_FK_SkillsDocuments_Documents]
ON [dbo].[SkillsDocuments]
    ([Documents_Id]);
GO

-- Creating foreign key on [Skills_Id] in table 'RequiresSet'
ALTER TABLE [dbo].[RequiresSet]
ADD CONSTRAINT [FK_SkillsRequires]
    FOREIGN KEY ([Skills_Id])
    REFERENCES [dbo].[SkillsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SkillsRequires'
CREATE INDEX [IX_FK_SkillsRequires]
ON [dbo].[RequiresSet]
    ([Skills_Id]);
GO

-- Creating foreign key on [Jobs_Id] in table 'RequiresSet'
ALTER TABLE [dbo].[RequiresSet]
ADD CONSTRAINT [FK_JobsRequires]
    FOREIGN KEY ([Jobs_Id])
    REFERENCES [dbo].[JobsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_JobsRequires'
CREATE INDEX [IX_FK_JobsRequires]
ON [dbo].[RequiresSet]
    ([Jobs_Id]);
GO

-- Creating foreign key on [Recruited_Id] in table 'ApplicationsSet'
ALTER TABLE [dbo].[ApplicationsSet]
ADD CONSTRAINT [FK_RecruitedApplications]
    FOREIGN KEY ([Recruited_Id])
    REFERENCES [dbo].[RecruitedSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RecruitedApplications'
CREATE INDEX [IX_FK_RecruitedApplications]
ON [dbo].[ApplicationsSet]
    ([Recruited_Id]);
GO

-- Creating foreign key on [Jobs_Id] in table 'ApplicationsSet'
ALTER TABLE [dbo].[ApplicationsSet]
ADD CONSTRAINT [FK_JobsApplications]
    FOREIGN KEY ([Jobs_Id])
    REFERENCES [dbo].[JobsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_JobsApplications'
CREATE INDEX [IX_FK_JobsApplications]
ON [dbo].[ApplicationsSet]
    ([Jobs_Id]);
GO

-- Creating foreign key on [Stage_Id] in table 'StageGradesSet'
ALTER TABLE [dbo].[StageGradesSet]
ADD CONSTRAINT [FK_StageStageGrades]
    FOREIGN KEY ([Stage_Id])
    REFERENCES [dbo].[StageSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StageStageGrades'
CREATE INDEX [IX_FK_StageStageGrades]
ON [dbo].[StageGradesSet]
    ([Stage_Id]);
GO

-- Creating foreign key on [Applications_Id] in table 'StageGradesSet'
ALTER TABLE [dbo].[StageGradesSet]
ADD CONSTRAINT [FK_ApplicationsStageGrades]
    FOREIGN KEY ([Applications_Id])
    REFERENCES [dbo].[ApplicationsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ApplicationsStageGrades'
CREATE INDEX [IX_FK_ApplicationsStageGrades]
ON [dbo].[StageGradesSet]
    ([Applications_Id]);
GO

-- Creating foreign key on [Jobs_Id] in table 'JobsStage'
ALTER TABLE [dbo].[JobsStage]
ADD CONSTRAINT [FK_JobsStage_Jobs]
    FOREIGN KEY ([Jobs_Id])
    REFERENCES [dbo].[JobsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Stage_Id] in table 'JobsStage'
ALTER TABLE [dbo].[JobsStage]
ADD CONSTRAINT [FK_JobsStage_Stage]
    FOREIGN KEY ([Stage_Id])
    REFERENCES [dbo].[StageSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_JobsStage_Stage'
CREATE INDEX [IX_FK_JobsStage_Stage]
ON [dbo].[JobsStage]
    ([Stage_Id]);
GO

-- Creating foreign key on [Roles_Id] in table 'WorkersSet'
ALTER TABLE [dbo].[WorkersSet]
ADD CONSTRAINT [FK_RolesWorkers]
    FOREIGN KEY ([Roles_Id])
    REFERENCES [dbo].[RolesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RolesWorkers'
CREATE INDEX [IX_FK_RolesWorkers]
ON [dbo].[WorkersSet]
    ([Roles_Id]);
GO

-- Creating foreign key on [Workers_Id] in table 'ApplicationsSet'
ALTER TABLE [dbo].[ApplicationsSet]
ADD CONSTRAINT [FK_ApplicationsWorkers]
    FOREIGN KEY ([Workers_Id])
    REFERENCES [dbo].[WorkersSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ApplicationsWorkers'
CREATE INDEX [IX_FK_ApplicationsWorkers]
ON [dbo].[ApplicationsSet]
    ([Workers_Id]);
GO

-- Creating foreign key on [Workers1_Id] in table 'ApplicationsSet'
ALTER TABLE [dbo].[ApplicationsSet]
ADD CONSTRAINT [FK_WorkersApplications]
    FOREIGN KEY ([Workers1_Id])
    REFERENCES [dbo].[WorkersSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkersApplications'
CREATE INDEX [IX_FK_WorkersApplications]
ON [dbo].[ApplicationsSet]
    ([Workers1_Id]);
GO

-- Creating foreign key on [Stage_Id] in table 'WorkersSet'
ALTER TABLE [dbo].[WorkersSet]
ADD CONSTRAINT [FK_StageWorkers]
    FOREIGN KEY ([Stage_Id])
    REFERENCES [dbo].[StageSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StageWorkers'
CREATE INDEX [IX_FK_StageWorkers]
ON [dbo].[WorkersSet]
    ([Stage_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------