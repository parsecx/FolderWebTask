CREATE DATABASE [FOLDERTASK];
USE [FOLDERTASK];
CREATE TABLE [Folders] (
    [FolderId]     INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (200) NOT NULL,
    [RootFolderId] INT            NULL,
    CONSTRAINT [PK_Folders] PRIMARY KEY CLUSTERED ([FolderId] ASC)
);
INSERT INTO [Folders] ([Name], [RootFolderId])
VALUES ('Creating Digital Images', NULL),
VALUES ('Resources', 1),
VALUES ('Evidence', 1),
VALUES ('Graphic Products', 1),
VALUES ('Primary Sources', 2),
VALUES ('Secondary Sources', 2),
VALUES ('Process', 4),
VALUES ('Final Product', 4);

