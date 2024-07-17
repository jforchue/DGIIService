CREATE TABLE [dbo].[contribuyentes_ncfs]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [contribuyente] INT NOT NULL, 
    [ncf] NCHAR(10) NOT NULL, 
    [monto] MONEY NOT NULL, 
    CONSTRAINT [FK_contribuyentes_ncfs_contribuyente] FOREIGN KEY (contribuyente) REFERENCES contribuyentes(id)
)
