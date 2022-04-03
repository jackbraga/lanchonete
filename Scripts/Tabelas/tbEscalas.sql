USE LANCHONETE
GO
CREATE TABLE tbEscalas
(
	ID INT PRIMARY KEY IDENTITY,
	Descricao VARCHAR(150),
	DataEscala DATETIME,
	Finalizada BIT,
	Observacao VARCHAR(MAX),
	TipoSessao VARCHAR(50),
	RepasseTesouraria BIT
)

--SET IDENTITY_INSERT tbEscalas ON
--INSERT INTO tbEscalas(ID,Descricao,DataEscala,Finalizada,Observacao,TipoSessao,RepasseTesouraria) VALUES(3,'1� Escala de Outubro','2021-10-02',0,'','Escala',0)
--INSERT INTO tbEscalas(ID,Descricao,DataEscala,Finalizada,Observacao,TipoSessao,RepasseTesouraria) VALUES(4,'2� Escala de Outubro','2021-10-16',0,'','Escala',0)
--INSERT INTO tbEscalas(ID,Descricao,DataEscala,Finalizada,Observacao,TipoSessao,RepasseTesouraria) VALUES(5,'1� de Novembro','2021-11-01',0,'','Anual',0)
--INSERT INTO tbEscalas(ID,Descricao,DataEscala,Finalizada,Observacao,TipoSessao,RepasseTesouraria) VALUES(6,'Sess�o de Casal','2021-10-30',0,'','Extra',0)
--INSERT INTO tbEscalas(ID,Descricao,DataEscala,Finalizada,Observacao,TipoSessao,RepasseTesouraria) VALUES(7,'1� Escala de Novembro','2021-11-06',0,'','Escala',0)
--INSERT INTO tbEscalas(ID,Descricao,DataEscala,Finalizada,Observacao,TipoSessao,RepasseTesouraria) VALUES(8,'2� Escala de Novembro','2021-11-20',1,'','Escala',0)
--INSERT INTO tbEscalas(ID,Descricao,DataEscala,Finalizada,Observacao,TipoSessao,RepasseTesouraria) VALUES(9,'1� Escala de Dezembro','2021-12-04',1,'','Escala',0)
--INSERT INTO tbEscalas(ID,Descricao,DataEscala,Finalizada,Observacao,TipoSessao,RepasseTesouraria) VALUES(11,'2� Escala de Dezembro','2021-12-18',1,'','Escala',0)
--INSERT INTO tbEscalas(ID,Descricao,DataEscala,Finalizada,Observacao,TipoSessao,RepasseTesouraria) VALUES(12,'Sess�o Instrutiva Dezembro 2021','2021-12-12',1,'','Instrutiva',0)
--INSERT INTO tbEscalas(ID,Descricao,DataEscala,Finalizada,Observacao,TipoSessao,RepasseTesouraria) VALUES(13,'Sess�o de Natal','2021-12-24',1,'','Anual',0)
--INSERT INTO tbEscalas(ID,Descricao,DataEscala,Finalizada,Observacao,TipoSessao,RepasseTesouraria) VALUES(14,'1� Escala de Janeiro 2022','2022-01-01',1,'','Escala',0)
--INSERT INTO tbEscalas(ID,Descricao,DataEscala,Finalizada,Observacao,TipoSessao,RepasseTesouraria) VALUES(15,'Escala Anual - Dia de Reis','2022-01-06',1,'','Anual',0)
--INSERT INTO tbEscalas(ID,Descricao,DataEscala,Finalizada,Observacao,TipoSessao,RepasseTesouraria) VALUES(16,'Multir�o extra','2022-01-08',1,'','Extra',0)
--INSERT INTO tbEscalas(ID,Descricao,DataEscala,Finalizada,Observacao,TipoSessao,RepasseTesouraria) VALUES(17,'2� Escala de Janeiro 2022','2022-01-15',1,'','Escala',0)

--SET IDENTITY_INSERT tbEscalas OFF