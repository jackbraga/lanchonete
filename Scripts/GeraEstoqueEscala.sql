INSERT INTO tbEstoqueEscala(Escala,Produto,QtdVenda,Observacao)
SELECT DISTINCT 
21 AS ESCALA, 
A.ID,
(ISNULL(EstoqueInicial,0) + ISNULL((SELECT SUM(tbCompras.Quantidade) FROM tbCompras WHERE Produto = A.ID),0) - ISNULL((SELECT SUM(tbVendasPedido.Quantidade) FROM tbVendasPedido WHERE Produto = A.ID),0)) AS Estoque  , 
'CARGA COMPLETA' AS Observacao
FROM tbProdutos AS A  
LEFT JOIN tbCompras AS B ON A.ID = B.Produto  
LEFT JOIN tbVendasPedido AS C ON A.ID = C.Produto  
WHERE A.ProdutoVenda = 1  and
(ISNULL(EstoqueInicial,0) + ISNULL((SELECT SUM(tbCompras.Quantidade) FROM tbCompras WHERE Produto = A.ID),0) - ISNULL((SELECT SUM(tbVendasPedido.Quantidade) FROM tbVendasPedido WHERE Produto = A.ID),0)) >0
GROUP BY A.ID, A.Descricao, A.PrecoVenda, A.EstoqueInicial  



SELECT * FROM tbEstoqueEscala where Escala=21
SELECT * FROM tbEscalas

--DELETE FROM tbEstoqueEscala where Escala=21