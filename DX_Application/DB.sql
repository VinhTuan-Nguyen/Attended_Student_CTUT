
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/24/2023 19:48:49
-- Generated from EDMX file: D:\Source\Attended_Student_CTUT\DX_Application\DX_Application\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
GO
USE [db_Attended];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__tb_Accoun__col_U__440B1D61]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_Accounts] DROP CONSTRAINT [FK__tb_Accoun__col_U__440B1D61];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_Attend__col_C__33D4B598]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_Attended] DROP CONSTRAINT [FK__tb_Attend__col_C__33D4B598];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_Attend__col_R__36B12243]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_Attended] DROP CONSTRAINT [FK__tb_Attend__col_R__36B12243];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_Attend__col_S__34C8D9D1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_Attended] DROP CONSTRAINT [FK__tb_Attend__col_S__34C8D9D1];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_Attend__col_T__35BCFE0A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_Attended] DROP CONSTRAINT [FK__tb_Attend__col_T__35BCFE0A];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_ClassR__col_C__48CFD27E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_ClassRooms] DROP CONSTRAINT [FK__tb_ClassR__col_C__48CFD27E];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_Course__col_R__49C3F6B7]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_Courses] DROP CONSTRAINT [FK__tb_Course__col_R__49C3F6B7];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_Course__col_T__2B3F6F97]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_Courses] DROP CONSTRAINT [FK__tb_Course__col_T__2B3F6F97];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_Regist__col_C__2E1BDC42]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_RegisterCourses] DROP CONSTRAINT [FK__tb_Regist__col_C__2E1BDC42];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_Regist__col_S__2F10007B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_RegisterCourses] DROP CONSTRAINT [FK__tb_Regist__col_S__2F10007B];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[tb_Accounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_Accounts];
GO
IF OBJECT_ID(N'[dbo].[tb_Attended]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_Attended];
GO
IF OBJECT_ID(N'[dbo].[tb_ClassRooms]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_ClassRooms];
GO
IF OBJECT_ID(N'[dbo].[tb_Courses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_Courses];
GO
IF OBJECT_ID(N'[dbo].[tb_RegisterCourses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_RegisterCourses];
GO
IF OBJECT_ID(N'[dbo].[tb_Students]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_Students];
GO
IF OBJECT_ID(N'[dbo].[tb_Teachers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_Teachers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'tb_Accounts'
CREATE TABLE [dbo].[tb_Accounts] (
    [col_UserID] varchar(12)  NOT NULL,
    [col_Password] varchar(32)  NOT NULL,
    [col_Role] varchar(10)  NOT NULL
);
GO

-- Creating table 'tb_Attended'
CREATE TABLE [dbo].[tb_Attended] (
    [col_Index_Attended] int IDENTITY(1,1) NOT NULL,
    [col_DateAtd] datetime  NOT NULL,
    [col_TimeAtd] time  NOT NULL,
    [col_CoursesID] int  NOT NULL,
    [col_StudentID] varchar(10)  NOT NULL,
    [col_TeacherID] varchar(12)  NOT NULL,
    [col_RoomID] varchar(5)  NOT NULL,
    [col_Note] nvarchar(100)  NULL
);
GO

-- Creating table 'tb_ClassRooms'
CREATE TABLE [dbo].[tb_ClassRooms] (
    [col_RoomID] varchar(5)  NOT NULL,
    [col_RoomName] nvarchar(50)  NULL,
    [col_Capacity] int  NULL,
    [col_CreateID] varchar(12)  NOT NULL
);
GO

-- Creating table 'tb_Courses'
CREATE TABLE [dbo].[tb_Courses] (
    [col_CoursesID] int IDENTITY(1,1) NOT NULL,
    [col_CoursesName] nvarchar(50)  NOT NULL,
    [col_Semester] varchar(15)  NOT NULL,
    [col_DateStr] datetime  NULL,
    [col_DateEnd] datetime  NULL,
    [col_DayoWeek] varchar(10)  NULL,
    [col_Status] nvarchar(30)  NULL,
    [col_TeacherID] varchar(12)  NOT NULL,
    [col_RoomID] varchar(5)  NOT NULL
);
GO

-- Creating table 'tb_RegisterCourses'
CREATE TABLE [dbo].[tb_RegisterCourses] (
    [col_Index_RegisterCourses] int IDENTITY(1,1) NOT NULL,
    [col_CoursesID] int  NOT NULL,
    [col_StudentID] varchar(10)  NOT NULL,
    [col_Status] nvarchar(30)  NULL
);
GO

-- Creating table 'tb_Students'
CREATE TABLE [dbo].[tb_Students] (
    [col_StudentID] varchar(10)  NOT NULL,
    [col_FName] nvarchar(30)  NOT NULL,
    [col_DayoBirth] datetime  NOT NULL,
    [col_Major] nvarchar(40)  NULL,
    [col_Email] varchar(50)  NULL,
    [col_Phone] varchar(10)  NULL,
    [col_Sex] bit  NULL,
    [col_Avatar] varbinary(max)  NULL
);
GO

-- Creating table 'tb_Teachers'
CREATE TABLE [dbo].[tb_Teachers] (
    [col_TeacherID] varchar(12)  NOT NULL,
    [col_FName] nvarchar(30)  NOT NULL,
    [col_Department] nvarchar(100)  NULL,
    [col_Email] varchar(50)  NULL,
    [col_Phone] varchar(10)  NULL,
    [col_Sex] bit  NULL,
    [col_Avatar] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [col_UserID] in table 'tb_Accounts'
ALTER TABLE [dbo].[tb_Accounts]
ADD CONSTRAINT [PK_tb_Accounts]
    PRIMARY KEY CLUSTERED ([col_UserID] ASC);
GO

-- Creating primary key on [col_Index_Attended] in table 'tb_Attended'
ALTER TABLE [dbo].[tb_Attended]
ADD CONSTRAINT [PK_tb_Attended]
    PRIMARY KEY CLUSTERED ([col_Index_Attended] ASC);
GO

-- Creating primary key on [col_RoomID] in table 'tb_ClassRooms'
ALTER TABLE [dbo].[tb_ClassRooms]
ADD CONSTRAINT [PK_tb_ClassRooms]
    PRIMARY KEY CLUSTERED ([col_RoomID] ASC);
GO

-- Creating primary key on [col_CoursesID] in table 'tb_Courses'
ALTER TABLE [dbo].[tb_Courses]
ADD CONSTRAINT [PK_tb_Courses]
    PRIMARY KEY CLUSTERED ([col_CoursesID] ASC);
GO

-- Creating primary key on [col_Index_RegisterCourses] in table 'tb_RegisterCourses'
ALTER TABLE [dbo].[tb_RegisterCourses]
ADD CONSTRAINT [PK_tb_RegisterCourses]
    PRIMARY KEY CLUSTERED ([col_Index_RegisterCourses] ASC);
GO

-- Creating primary key on [col_StudentID] in table 'tb_Students'
ALTER TABLE [dbo].[tb_Students]
ADD CONSTRAINT [PK_tb_Students]
    PRIMARY KEY CLUSTERED ([col_StudentID] ASC);
GO

-- Creating primary key on [col_TeacherID] in table 'tb_Teachers'
ALTER TABLE [dbo].[tb_Teachers]
ADD CONSTRAINT [PK_tb_Teachers]
    PRIMARY KEY CLUSTERED ([col_TeacherID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [col_UserID] in table 'tb_Accounts'
ALTER TABLE [dbo].[tb_Accounts]
ADD CONSTRAINT [FK__tb_Accoun__col_U__440B1D61]
    FOREIGN KEY ([col_UserID])
    REFERENCES [dbo].[tb_Teachers]
        ([col_TeacherID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [col_CoursesID] in table 'tb_Attended'
ALTER TABLE [dbo].[tb_Attended]
ADD CONSTRAINT [FK__tb_Attend__col_C__33D4B598]
    FOREIGN KEY ([col_CoursesID])
    REFERENCES [dbo].[tb_Courses]
        ([col_CoursesID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__tb_Attend__col_C__33D4B598'
CREATE INDEX [IX_FK__tb_Attend__col_C__33D4B598]
ON [dbo].[tb_Attended]
    ([col_CoursesID]);
GO

-- Creating foreign key on [col_RoomID] in table 'tb_Attended'
ALTER TABLE [dbo].[tb_Attended]
ADD CONSTRAINT [FK__tb_Attend__col_R__36B12243]
    FOREIGN KEY ([col_RoomID])
    REFERENCES [dbo].[tb_ClassRooms]
        ([col_RoomID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__tb_Attend__col_R__36B12243'
CREATE INDEX [IX_FK__tb_Attend__col_R__36B12243]
ON [dbo].[tb_Attended]
    ([col_RoomID]);
GO

-- Creating foreign key on [col_StudentID] in table 'tb_Attended'
ALTER TABLE [dbo].[tb_Attended]
ADD CONSTRAINT [FK__tb_Attend__col_S__34C8D9D1]
    FOREIGN KEY ([col_StudentID])
    REFERENCES [dbo].[tb_Students]
        ([col_StudentID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__tb_Attend__col_S__34C8D9D1'
CREATE INDEX [IX_FK__tb_Attend__col_S__34C8D9D1]
ON [dbo].[tb_Attended]
    ([col_StudentID]);
GO

-- Creating foreign key on [col_TeacherID] in table 'tb_Attended'
ALTER TABLE [dbo].[tb_Attended]
ADD CONSTRAINT [FK__tb_Attend__col_T__35BCFE0A]
    FOREIGN KEY ([col_TeacherID])
    REFERENCES [dbo].[tb_Teachers]
        ([col_TeacherID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__tb_Attend__col_T__35BCFE0A'
CREATE INDEX [IX_FK__tb_Attend__col_T__35BCFE0A]
ON [dbo].[tb_Attended]
    ([col_TeacherID]);
GO

-- Creating foreign key on [col_CreateID] in table 'tb_ClassRooms'
ALTER TABLE [dbo].[tb_ClassRooms]
ADD CONSTRAINT [FK__tb_ClassR__col_C__48CFD27E]
    FOREIGN KEY ([col_CreateID])
    REFERENCES [dbo].[tb_Teachers]
        ([col_TeacherID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__tb_ClassR__col_C__48CFD27E'
CREATE INDEX [IX_FK__tb_ClassR__col_C__48CFD27E]
ON [dbo].[tb_ClassRooms]
    ([col_CreateID]);
GO

-- Creating foreign key on [col_RoomID] in table 'tb_Courses'
ALTER TABLE [dbo].[tb_Courses]
ADD CONSTRAINT [FK__tb_Course__col_R__49C3F6B7]
    FOREIGN KEY ([col_RoomID])
    REFERENCES [dbo].[tb_ClassRooms]
        ([col_RoomID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__tb_Course__col_R__49C3F6B7'
CREATE INDEX [IX_FK__tb_Course__col_R__49C3F6B7]
ON [dbo].[tb_Courses]
    ([col_RoomID]);
GO

-- Creating foreign key on [col_TeacherID] in table 'tb_Courses'
ALTER TABLE [dbo].[tb_Courses]
ADD CONSTRAINT [FK__tb_Course__col_T__2B3F6F97]
    FOREIGN KEY ([col_TeacherID])
    REFERENCES [dbo].[tb_Teachers]
        ([col_TeacherID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__tb_Course__col_T__2B3F6F97'
CREATE INDEX [IX_FK__tb_Course__col_T__2B3F6F97]
ON [dbo].[tb_Courses]
    ([col_TeacherID]);
GO

-- Creating foreign key on [col_CoursesID] in table 'tb_RegisterCourses'
ALTER TABLE [dbo].[tb_RegisterCourses]
ADD CONSTRAINT [FK__tb_Regist__col_C__2E1BDC42]
    FOREIGN KEY ([col_CoursesID])
    REFERENCES [dbo].[tb_Courses]
        ([col_CoursesID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__tb_Regist__col_C__2E1BDC42'
CREATE INDEX [IX_FK__tb_Regist__col_C__2E1BDC42]
ON [dbo].[tb_RegisterCourses]
    ([col_CoursesID]);
GO

-- Creating foreign key on [col_StudentID] in table 'tb_RegisterCourses'
ALTER TABLE [dbo].[tb_RegisterCourses]
ADD CONSTRAINT [FK__tb_Regist__col_S__2F10007B]
    FOREIGN KEY ([col_StudentID])
    REFERENCES [dbo].[tb_Students]
        ([col_StudentID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__tb_Regist__col_S__2F10007B'
CREATE INDEX [IX_FK__tb_Regist__col_S__2F10007B]
ON [dbo].[tb_RegisterCourses]
    ([col_StudentID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------