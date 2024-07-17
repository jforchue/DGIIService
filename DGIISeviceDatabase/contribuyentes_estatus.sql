CREATE TABLE [dbo].[contribuyentes_estatus]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [nombre] VARCHAR(20) NOT NULL, 
    CONSTRAINT [uk_contribuyentes_estatus] UNIQUE (nombre)
)
