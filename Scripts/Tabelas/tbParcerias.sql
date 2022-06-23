CREATE TABLE tbParcerias
(
	ID INT PRIMARY KEY IDENTITY,
	Descricao VARCHAR(150),
	Responsavel VARCHAR(100),
	Comissao	DECIMAL(10,2)
)
INSERT INTO tbParcerias VALUES ('Pães Casal Natural','Augusto Soares Neto',2.00)