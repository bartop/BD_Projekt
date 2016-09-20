
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/20/2016 19:44:36
-- Generated from EDMX file: C:\Users\Rames\Documents\Visual Studio 2015\Projects\BD_Projekt\BD_Projekt\DataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PosessesRecruited]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PosessesSet] DROP CONSTRAINT [FK_PosessesRecruited];
GO
IF OBJECT_ID(N'[dbo].[FK_DocumentsRecruited]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DocumentSet] DROP CONSTRAINT [FK_DocumentsRecruited];
GO
IF OBJECT_ID(N'[dbo].[FK_RecruitedApplications]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ApplicationSet] DROP CONSTRAINT [FK_RecruitedApplications];
GO
IF OBJECT_ID(N'[dbo].[FK_RecruitedProfessionalExperience]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfessionalExperienceSet] DROP CONSTRAINT [FK_RecruitedProfessionalExperience];
GO
IF OBJECT_ID(N'[dbo].[FK_SkillsPosesses]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PosessesSet] DROP CONSTRAINT [FK_SkillsPosesses];
GO
IF OBJECT_ID(N'[dbo].[FK_SkillsRequires]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RequiresSet] DROP CONSTRAINT [FK_SkillsRequires];
GO
IF OBJECT_ID(N'[dbo].[FK_JobsRequires]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RequiresSet] DROP CONSTRAINT [FK_JobsRequires];
GO
IF OBJECT_ID(N'[dbo].[FK_JobsApplications]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ApplicationSet] DROP CONSTRAINT [FK_JobsApplications];
GO
IF OBJECT_ID(N'[dbo].[FK_JobsStage_Job]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JobsStage] DROP CONSTRAINT [FK_JobsStage_Job];
GO
IF OBJECT_ID(N'[dbo].[FK_JobsStage_Stage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JobsStage] DROP CONSTRAINT [FK_JobsStage_Stage];
GO
IF OBJECT_ID(N'[dbo].[FK_StageStageGrades]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StageGradeSet] DROP CONSTRAINT [FK_StageStageGrades];
GO
IF OBJECT_ID(N'[dbo].[FK_RolesWorkers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WorkerSet] DROP CONSTRAINT [FK_RolesWorkers];
GO
IF OBJECT_ID(N'[dbo].[FK_ApplicationsWorkers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ApplicationSet] DROP CONSTRAINT [FK_ApplicationsWorkers];
GO
IF OBJECT_ID(N'[dbo].[FK_DecisionWorker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DecisionSet] DROP CONSTRAINT [FK_DecisionWorker];
GO
IF OBJECT_ID(N'[dbo].[FK_DecisionApplication]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DecisionSet] DROP CONSTRAINT [FK_DecisionApplication];
GO
IF OBJECT_ID(N'[dbo].[FK_ApprovalWorker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ApprovalSet] DROP CONSTRAINT [FK_ApprovalWorker];
GO
IF OBJECT_ID(N'[dbo].[FK_RecruitedEducation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EducationSet] DROP CONSTRAINT [FK_RecruitedEducation];
GO
IF OBJECT_ID(N'[dbo].[FK_ApplicationStageGrade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StageGradeSet] DROP CONSTRAINT [FK_ApplicationStageGrade];
GO
IF OBJECT_ID(N'[dbo].[FK_DecisionApproval]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ApprovalSet] DROP CONSTRAINT [FK_DecisionApproval];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[RecruitedSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RecruitedSet];
GO
IF OBJECT_ID(N'[dbo].[SkillSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SkillSet];
GO
IF OBJECT_ID(N'[dbo].[DocumentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DocumentSet];
GO
IF OBJECT_ID(N'[dbo].[PosessesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PosessesSet];
GO
IF OBJECT_ID(N'[dbo].[JobSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JobSet];
GO
IF OBJECT_ID(N'[dbo].[RequiresSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RequiresSet];
GO
IF OBJECT_ID(N'[dbo].[ApplicationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ApplicationSet];
GO
IF OBJECT_ID(N'[dbo].[StageSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StageSet];
GO
IF OBJECT_ID(N'[dbo].[StageGradeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StageGradeSet];
GO
IF OBJECT_ID(N'[dbo].[WorkerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WorkerSet];
GO
IF OBJECT_ID(N'[dbo].[RoleSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RoleSet];
GO
IF OBJECT_ID(N'[dbo].[DecisionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DecisionSet];
GO
IF OBJECT_ID(N'[dbo].[ApprovalSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ApprovalSet];
GO
IF OBJECT_ID(N'[dbo].[ProfessionalExperienceSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProfessionalExperienceSet];
GO
IF OBJECT_ID(N'[dbo].[EducationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EducationSet];
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
    [DateOfBirth] datetime  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [PhoneNumber] nvarchar(max)  NOT NULL,
    [Nationality] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SkillSet'
CREATE TABLE [dbo].[SkillSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DocumentSet'
CREATE TABLE [dbo].[DocumentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [File] varbinary(max)  NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Extension] nvarchar(max)  NULL,
    [Recruited_Id] int  NOT NULL
);
GO

-- Creating table 'PosessesSet'
CREATE TABLE [dbo].[PosessesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Level] tinyint  NOT NULL,
    [Recruited_Id] int  NOT NULL,
    [Skills_Id] int  NOT NULL
);
GO

-- Creating table 'JobSet'
CREATE TABLE [dbo].[JobSet] (
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

-- Creating table 'ApplicationSet'
CREATE TABLE [dbo].[ApplicationSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Recruited_Id] int  NOT NULL,
    [Job_Id] int  NOT NULL,
    [Assistant_Id] int  NOT NULL
);
GO

-- Creating table 'StageSet'
CREATE TABLE [dbo].[StageSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StageGradeSet'
CREATE TABLE [dbo].[StageGradeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Grade] tinyint  NULL,
    [Stage_Id] int  NOT NULL,
    [Application_Id] int  NOT NULL
);
GO

-- Creating table 'WorkerSet'
CREATE TABLE [dbo].[WorkerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [PasswordHash] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Roles_Id] int  NOT NULL
);
GO

-- Creating table 'RoleSet'
CREATE TABLE [dbo].[RoleSet] (
    [Id] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DecisionSet'
CREATE TABLE [dbo].[DecisionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Explanation] nvarchar(max)  NOT NULL,
    [Accepted] bit  NOT NULL,
    [Worker_Id] int  NOT NULL,
    [Application_Id] int  NOT NULL
);
GO

-- Creating table 'ApprovalSet'
CREATE TABLE [dbo].[ApprovalSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Approved] bit  NOT NULL,
    [Worker_Id] int  NOT NULL,
    [Decision_Id] int  NOT NULL
);
GO

-- Creating table 'ProfessionalExperienceSet'
CREATE TABLE [dbo].[ProfessionalExperienceSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Job] nvarchar(max)  NOT NULL,
    [Company] nvarchar(max)  NOT NULL,
    [From] datetime  NOT NULL,
    [To] datetime  NOT NULL,
    [Recruited_Id] int  NOT NULL
);
GO

-- Creating table 'EducationSet'
CREATE TABLE [dbo].[EducationSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FromYear] datetime  NOT NULL,
    [SchoolName] nvarchar(max)  NOT NULL,
    [ToYear] datetime  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Recruited_Id] int  NOT NULL
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

-- Creating primary key on [Id] in table 'SkillSet'
ALTER TABLE [dbo].[SkillSet]
ADD CONSTRAINT [PK_SkillSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DocumentSet'
ALTER TABLE [dbo].[DocumentSet]
ADD CONSTRAINT [PK_DocumentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PosessesSet'
ALTER TABLE [dbo].[PosessesSet]
ADD CONSTRAINT [PK_PosessesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JobSet'
ALTER TABLE [dbo].[JobSet]
ADD CONSTRAINT [PK_JobSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RequiresSet'
ALTER TABLE [dbo].[RequiresSet]
ADD CONSTRAINT [PK_RequiresSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ApplicationSet'
ALTER TABLE [dbo].[ApplicationSet]
ADD CONSTRAINT [PK_ApplicationSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StageSet'
ALTER TABLE [dbo].[StageSet]
ADD CONSTRAINT [PK_StageSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StageGradeSet'
ALTER TABLE [dbo].[StageGradeSet]
ADD CONSTRAINT [PK_StageGradeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WorkerSet'
ALTER TABLE [dbo].[WorkerSet]
ADD CONSTRAINT [PK_WorkerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RoleSet'
ALTER TABLE [dbo].[RoleSet]
ADD CONSTRAINT [PK_RoleSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DecisionSet'
ALTER TABLE [dbo].[DecisionSet]
ADD CONSTRAINT [PK_DecisionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ApprovalSet'
ALTER TABLE [dbo].[ApprovalSet]
ADD CONSTRAINT [PK_ApprovalSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProfessionalExperienceSet'
ALTER TABLE [dbo].[ProfessionalExperienceSet]
ADD CONSTRAINT [PK_ProfessionalExperienceSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EducationSet'
ALTER TABLE [dbo].[EducationSet]
ADD CONSTRAINT [PK_EducationSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Jobs_Id], [Stage_Id] in table 'JobsStage'
ALTER TABLE [dbo].[JobsStage]
ADD CONSTRAINT [PK_JobsStage]
    PRIMARY KEY CLUSTERED ([Jobs_Id], [Stage_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Recruited_Id] in table 'PosessesSet'
ALTER TABLE [dbo].[PosessesSet]
ADD CONSTRAINT [FK_PosessesRecruited]
    FOREIGN KEY ([Recruited_Id])
    REFERENCES [dbo].[RecruitedSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PosessesRecruited'
CREATE INDEX [IX_FK_PosessesRecruited]
ON [dbo].[PosessesSet]
    ([Recruited_Id]);
GO

-- Creating foreign key on [Recruited_Id] in table 'DocumentSet'
ALTER TABLE [dbo].[DocumentSet]
ADD CONSTRAINT [FK_DocumentsRecruited]
    FOREIGN KEY ([Recruited_Id])
    REFERENCES [dbo].[RecruitedSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DocumentsRecruited'
CREATE INDEX [IX_FK_DocumentsRecruited]
ON [dbo].[DocumentSet]
    ([Recruited_Id]);
GO

-- Creating foreign key on [Recruited_Id] in table 'ApplicationSet'
ALTER TABLE [dbo].[ApplicationSet]
ADD CONSTRAINT [FK_RecruitedApplications]
    FOREIGN KEY ([Recruited_Id])
    REFERENCES [dbo].[RecruitedSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RecruitedApplications'
CREATE INDEX [IX_FK_RecruitedApplications]
ON [dbo].[ApplicationSet]
    ([Recruited_Id]);
GO

-- Creating foreign key on [Recruited_Id] in table 'ProfessionalExperienceSet'
ALTER TABLE [dbo].[ProfessionalExperienceSet]
ADD CONSTRAINT [FK_RecruitedProfessionalExperience]
    FOREIGN KEY ([Recruited_Id])
    REFERENCES [dbo].[RecruitedSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RecruitedProfessionalExperience'
CREATE INDEX [IX_FK_RecruitedProfessionalExperience]
ON [dbo].[ProfessionalExperienceSet]
    ([Recruited_Id]);
GO

-- Creating foreign key on [Skills_Id] in table 'PosessesSet'
ALTER TABLE [dbo].[PosessesSet]
ADD CONSTRAINT [FK_SkillsPosesses]
    FOREIGN KEY ([Skills_Id])
    REFERENCES [dbo].[SkillSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SkillsPosesses'
CREATE INDEX [IX_FK_SkillsPosesses]
ON [dbo].[PosessesSet]
    ([Skills_Id]);
GO

-- Creating foreign key on [Skills_Id] in table 'RequiresSet'
ALTER TABLE [dbo].[RequiresSet]
ADD CONSTRAINT [FK_SkillsRequires]
    FOREIGN KEY ([Skills_Id])
    REFERENCES [dbo].[SkillSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SkillsRequires'
CREATE INDEX [IX_FK_SkillsRequires]
ON [dbo].[RequiresSet]
    ([Skills_Id]);
GO

-- Creating foreign key on [Jobs_Id] in table 'RequiresSet'
ALTER TABLE [dbo].[RequiresSet]
ADD CONSTRAINT [FK_JobsRequires]
    FOREIGN KEY ([Jobs_Id])
    REFERENCES [dbo].[JobSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JobsRequires'
CREATE INDEX [IX_FK_JobsRequires]
ON [dbo].[RequiresSet]
    ([Jobs_Id]);
GO

-- Creating foreign key on [Job_Id] in table 'ApplicationSet'
ALTER TABLE [dbo].[ApplicationSet]
ADD CONSTRAINT [FK_JobsApplications]
    FOREIGN KEY ([Job_Id])
    REFERENCES [dbo].[JobSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JobsApplications'
CREATE INDEX [IX_FK_JobsApplications]
ON [dbo].[ApplicationSet]
    ([Job_Id]);
GO

-- Creating foreign key on [Jobs_Id] in table 'JobsStage'
ALTER TABLE [dbo].[JobsStage]
ADD CONSTRAINT [FK_JobsStage_Job]
    FOREIGN KEY ([Jobs_Id])
    REFERENCES [dbo].[JobSet]
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
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JobsStage_Stage'
CREATE INDEX [IX_FK_JobsStage_Stage]
ON [dbo].[JobsStage]
    ([Stage_Id]);
GO

-- Creating foreign key on [Stage_Id] in table 'StageGradeSet'
ALTER TABLE [dbo].[StageGradeSet]
ADD CONSTRAINT [FK_StageStageGrades]
    FOREIGN KEY ([Stage_Id])
    REFERENCES [dbo].[StageSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StageStageGrades'
CREATE INDEX [IX_FK_StageStageGrades]
ON [dbo].[StageGradeSet]
    ([Stage_Id]);
GO

-- Creating foreign key on [Roles_Id] in table 'WorkerSet'
ALTER TABLE [dbo].[WorkerSet]
ADD CONSTRAINT [FK_RolesWorkers]
    FOREIGN KEY ([Roles_Id])
    REFERENCES [dbo].[RoleSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RolesWorkers'
CREATE INDEX [IX_FK_RolesWorkers]
ON [dbo].[WorkerSet]
    ([Roles_Id]);
GO

-- Creating foreign key on [Assistant_Id] in table 'ApplicationSet'
ALTER TABLE [dbo].[ApplicationSet]
ADD CONSTRAINT [FK_ApplicationsWorkers]
    FOREIGN KEY ([Assistant_Id])
    REFERENCES [dbo].[WorkerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ApplicationsWorkers'
CREATE INDEX [IX_FK_ApplicationsWorkers]
ON [dbo].[ApplicationSet]
    ([Assistant_Id]);
GO

-- Creating foreign key on [Worker_Id] in table 'DecisionSet'
ALTER TABLE [dbo].[DecisionSet]
ADD CONSTRAINT [FK_DecisionWorker]
    FOREIGN KEY ([Worker_Id])
    REFERENCES [dbo].[WorkerSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DecisionWorker'
CREATE INDEX [IX_FK_DecisionWorker]
ON [dbo].[DecisionSet]
    ([Worker_Id]);
GO

-- Creating foreign key on [Application_Id] in table 'DecisionSet'
ALTER TABLE [dbo].[DecisionSet]
ADD CONSTRAINT [FK_DecisionApplication]
    FOREIGN KEY ([Application_Id])
    REFERENCES [dbo].[ApplicationSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DecisionApplication'
CREATE INDEX [IX_FK_DecisionApplication]
ON [dbo].[DecisionSet]
    ([Application_Id]);
GO

-- Creating foreign key on [Worker_Id] in table 'ApprovalSet'
ALTER TABLE [dbo].[ApprovalSet]
ADD CONSTRAINT [FK_ApprovalWorker]
    FOREIGN KEY ([Worker_Id])
    REFERENCES [dbo].[WorkerSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ApprovalWorker'
CREATE INDEX [IX_FK_ApprovalWorker]
ON [dbo].[ApprovalSet]
    ([Worker_Id]);
GO

-- Creating foreign key on [Recruited_Id] in table 'EducationSet'
ALTER TABLE [dbo].[EducationSet]
ADD CONSTRAINT [FK_RecruitedEducation]
    FOREIGN KEY ([Recruited_Id])
    REFERENCES [dbo].[RecruitedSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RecruitedEducation'
CREATE INDEX [IX_FK_RecruitedEducation]
ON [dbo].[EducationSet]
    ([Recruited_Id]);
GO

-- Creating foreign key on [Application_Id] in table 'StageGradeSet'
ALTER TABLE [dbo].[StageGradeSet]
ADD CONSTRAINT [FK_ApplicationStageGrade]
    FOREIGN KEY ([Application_Id])
    REFERENCES [dbo].[ApplicationSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ApplicationStageGrade'
CREATE INDEX [IX_FK_ApplicationStageGrade]
ON [dbo].[StageGradeSet]
    ([Application_Id]);
GO

-- Creating foreign key on [Decision_Id] in table 'ApprovalSet'
ALTER TABLE [dbo].[ApprovalSet]
ADD CONSTRAINT [FK_DecisionApproval]
    FOREIGN KEY ([Decision_Id])
    REFERENCES [dbo].[DecisionSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DecisionApproval'
CREATE INDEX [IX_FK_DecisionApproval]
ON [dbo].[ApprovalSet]
    ([Decision_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------