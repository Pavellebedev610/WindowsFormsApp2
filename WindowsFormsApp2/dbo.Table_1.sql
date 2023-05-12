CREATE TABLE [dbo].[Table_1]
(
	[Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Username] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NULL, 
    [Mail] NVARCHAR(50) NULL
	PRIMARY KEY CLUSTERED ([Id] ASC)
)
