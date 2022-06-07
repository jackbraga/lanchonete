select * froM tbVendasPedido

ALTER TABLE tbVendasPedido ADD TipoPagamento VARCHAR(50)

SELECT * FROM tbVendas


---LANCHONETE
SELECT
tbEscalas.ID AS IdEscala,  
tbEscalas.Descricao, 
tbEscalas.DataEscala, 
SUM((tbVendasPedido.PrecoProduto * tbVendasPedido.Quantidade)) AS ResumoVendas,
tbEscalas.Finalizada as EscalaFinalizada, 
tbVendas.TipoPagamento 
FROM tbEscalas 
LEFT JOIN tbVendas ON tbEscalas.ID = tbVendas.Escala 
LEFT JOIN tbVendasPedido ON tbVendas.ID = tbVendasPedido.Venda
INNER JOIN tbProdutos ON tbProdutos.ID = tbVendasPedido.Produto 
WHERE tbEscalas.ID = 1036 AND tbProdutos.Categoria <> 15 
GROUP BY  tbEscalas.ID, tbEscalas.Descricao, tbEscalas.DataEscala, tbVendas.TipoPagamento,tbEscalas.Finalizada 

1036	1° Escala de Junho	2022-06-04 00:00:00.000	592.20	0	BOLETO
1036	1° Escala de Junho	2022-06-04 00:00:00.000	85.50	0	DINHEIRO
1036	1° Escala de Junho	2022-06-04 00:00:00.000	5.00	0	PIX

----------------------------------
--CHURRASCO
SELECT
tbEscalas.ID AS IdEscala,  
tbEscalas.Descricao, 
tbEscalas.DataEscala, 
SUM((tbVendasPedido.PrecoProduto * tbVendasPedido.Quantidade)) AS ResumoVendas,
tbEscalas.Finalizada as EscalaFinalizada, 
tbVendas.TipoPagamento 
FROM tbEscalas 
LEFT JOIN tbVendas ON tbEscalas.ID = tbVendas.Escala 
LEFT JOIN tbVendasPedido ON tbVendas.ID = tbVendasPedido.Venda
INNER JOIN tbProdutos ON tbProdutos.ID = tbVendasPedido.Produto 
WHERE tbEscalas.ID = 1036 AND tbProdutos.Categoria = 15 
GROUP BY  tbEscalas.ID, tbEscalas.Descricao, tbEscalas.DataEscala, tbVendas.TipoPagamento,tbEscalas.Finalizada 









--LANCHONETE
SELECT
tbEscalas.ID AS IdEscala,  
tbEscalas.Descricao, 
tbEscalas.DataEscala, 
SUM((tbVendasPedido.PrecoProduto * tbVendasPedido.Quantidade)) AS ResumoVendas,
tbEscalas.Finalizada as EscalaFinalizada, 
tbVendasPedido.TipoPagamento
FROM tbEscalas 
LEFT JOIN tbVendas ON tbEscalas.ID = tbVendas.Escala 
LEFT JOIN tbVendasPedido ON tbVendas.ID = tbVendasPedido.Venda
INNER JOIN tbProdutos ON tbProdutos.ID = tbVendasPedido.Produto 
WHERE tbEscalas.ID = 1036 AND tbProdutos.Categoria <> 15 
GROUP BY  tbEscalas.ID, tbEscalas.Descricao, tbEscalas.DataEscala, tbVendasPedido.TipoPagamento,tbEscalas.Finalizada 
--------------------------------------------
--CHURRASCO
--LANCHONETE
SELECT
tbEscalas.ID AS IdEscala,  
tbEscalas.Descricao, 
tbEscalas.DataEscala, 
SUM((tbVendasPedido.PrecoProduto * tbVendasPedido.Quantidade)) AS ResumoVendas,
tbEscalas.Finalizada as EscalaFinalizada, 
tbVendasPedido.TipoPagamento
FROM tbEscalas 
LEFT JOIN tbVendas ON tbEscalas.ID = tbVendas.Escala 
LEFT JOIN tbVendasPedido ON tbVendas.ID = tbVendasPedido.Venda
INNER JOIN tbProdutos ON tbProdutos.ID = tbVendasPedido.Produto 
WHERE tbEscalas.ID = 1036 AND tbProdutos.Categoria = 15 
GROUP BY  tbEscalas.ID, tbEscalas.Descricao, tbEscalas.DataEscala, tbVendasPedido.TipoPagamento,tbEscalas.Finalizada 








SELECT * FROM tbEscalas --1036

select * FROM tbVendas WHERE Escala=1036 and Socio not in (41,71,70,75,136) AND TipoPagamento='PIX'
select * FROM tbVendas WHERE Escala=1036 and Socio in (41,71,70,75,136)

SELECT * FROM tbSocios
41	EDSON ROMÃO GOMES --6149
71	JOÃO RAFAEL BOROWSKI TEDESCHI --6147
70	JOÃO LUIZ VANNUZINI FERRER --6153
75	JULIANE CRISTINA FERREIRA --6138
136	RÚBIA RODRIGUES ANGELO --6157


select * froM tbVendasPedido

UPDATE tbVendasPedido SET TipoPagamento='DINHEIRO' WHERE Venda IN (6149,6147,6153,6138)

SELECT * FROM tbVendas WHERE Escala=1036 AND TipoPagamento='BOLETO'

ALTER TABLE tbVendasPedido ADD TipoPagamento VARCHAR(50)
GO
UPDATE tbVendasPedido SET TipoPagamento='BOLETO' WHERE VENDA IN(SELECT ID FROM tbVendas WHERE TipoPagamento='BOLETO')
UPDATE tbVendasPedido SET TipoPagamento='DINHEIRO' WHERE VENDA IN(SELECT ID FROM tbVendas WHERE TipoPagamento='DINHEIRO')
UPDATE tbVendasPedido SET TipoPagamento='PIX' WHERE VENDA IN(SELECT ID FROM tbVendas WHERE TipoPagamento='PIX')