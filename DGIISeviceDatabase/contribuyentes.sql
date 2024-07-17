CREATE TABLE [dbo].[contribuyentes]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [rnc] CHAR(13) NOT NULL UNIQUE, 
    [nombre] VARCHAR(100) NOT NULL, 
    [tipo] INT NOT NULL, 
    [estatus] INT NOT NULL, 
    CONSTRAINT [FK_contribuyentes_tipos] FOREIGN KEY (tipo) REFERENCES contribuyentes_tipos(id), 
    CONSTRAINT [FK_contribuyentes_estatus] FOREIGN KEY (estatus) REFERENCES contribuyentes_estatus(id),

)
