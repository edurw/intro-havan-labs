
INSERT INTO [dbo].[Produto]
           ([Nome]
           ,[Descicao])
     VALUES
           (
		   'Batata'
           ,'Normal'
		   )
GO

CREATE TABLE Categorias
(
	id INT IDENTITY(1,1) NOT NULL
	, Nome VARCHAR(50) NOT NULL
)