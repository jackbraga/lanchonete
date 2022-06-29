USE LANCHONETE
GO
CREATE TABLE tbCaixa
(
	ID INT PRIMARY KEY IDENTITY,
	DataEvento DATETIME,
	TipoEvento VARCHAR(30),
	Valor	   DECIMAL(10,2),
	Observacao VARCHAR(200),
	CategoriaLancamento INT  FOREIGN KEY REFERENCES tbCategoriaLancamento(ID),
	EspecieMoeda VARCHAR(30),
	Frente	VARCHAR(30)
)

