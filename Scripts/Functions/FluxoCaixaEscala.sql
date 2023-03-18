ALTER FUNCTION FluxoCaixaEscala (  
    @idEscala INT  
)  
RETURNS TABLE  
AS  
RETURN  
SELECT   
tbEscalas.DataEscala,   
'Entrada' AS TipoEvento,  
SUM((tbVendasPedido.PrecoProduto * tbVendasPedido.Quantidade)) AS ResumoVendas,   
tbEscalas.Descricao,   
2 AS CategoriaLancamento,--Vendas Lanchonete  
tbVendasPedido.TipoPagamento,  
'LANCHONETE' AS Frente  
FROM tbEscalas   
LEFT JOIN tbVendas ON tbEscalas.ID = tbVendas.Escala   
LEFT JOIN tbVendasPedido ON tbVendas.ID = tbVendasPedido.Venda   
INNER JOIN tbProdutos ON tbProdutos.ID = tbVendasPedido.Produto   
WHERE tbEscalas.ID = @idEscala AND tbProdutos.Categoria <> 15 AND tbProdutos.Categoria <> 16   AND tbProdutos.Categoria <> 17 
GROUP BY  tbEscalas.ID, tbEscalas.Descricao, tbEscalas.DataEscala, tbVendasPedido.TipoPagamento  
UNION ALL  
SELECT   
tbEscalas.DataEscala,   
'Entrada' AS TipoEvento,  
SUM((tbVendasPedido.PrecoProduto * tbVendasPedido.Quantidade)) AS ResumoVendas,   
tbEscalas.Descricao,   
6 AS CategoriaLancamento,--Vendas Lanchonete  
tbVendasPedido.TipoPagamento,  
'LANCHONETE' AS Frente  
FROM tbEscalas   
LEFT JOIN tbVendas ON tbEscalas.ID = tbVendas.Escala   
LEFT JOIN tbVendasPedido ON tbVendas.ID = tbVendasPedido.Venda   
INNER JOIN tbProdutos ON tbProdutos.ID = tbVendasPedido.Produto   
WHERE tbEscalas.ID = @idEscala AND tbProdutos.Categoria = 16   
GROUP BY  tbEscalas.ID, tbEscalas.Descricao, tbEscalas.DataEscala, tbVendasPedido.TipoPagamento  
UNION ALL  
SELECT   
tbEscalas.DataEscala,   
'Entrada' AS TipoEvento,  
SUM((tbVendasPedido.PrecoProduto * tbVendasPedido.Quantidade)) AS ResumoVendas,   
tbEscalas.Descricao,   
2 AS CategoriaLancamento,--Vendas Lanchonete  
tbVendasPedido.TipoPagamento,  
'CHURRASCO' AS Frente  
FROM tbEscalas   
LEFT JOIN tbVendas ON tbEscalas.ID = tbVendas.Escala   
LEFT JOIN tbVendasPedido ON tbVendas.ID = tbVendasPedido.Venda   
INNER JOIN tbProdutos ON tbProdutos.ID = tbVendasPedido.Produto   
WHERE tbEscalas.ID = @idEscala AND tbProdutos.Categoria = 15   
GROUP BY  tbEscalas.ID, tbEscalas.Descricao, tbEscalas.DataEscala, tbVendasPedido.TipoPagamento
UNION ALL  
SELECT   
tbEscalas.DataEscala,   
'Entrada' AS TipoEvento,  
SUM((tbVendasPedido.PrecoProduto * tbVendasPedido.Quantidade)) AS ResumoVendas,   
tbEscalas.Descricao,   
7 AS CategoriaLancamento,--Vendas Lanchonete  
tbVendasPedido.TipoPagamento,  
'LANCHONETE' AS Frente  
FROM tbEscalas   
LEFT JOIN tbVendas ON tbEscalas.ID = tbVendas.Escala   
LEFT JOIN tbVendasPedido ON tbVendas.ID = tbVendasPedido.Venda   
INNER JOIN tbProdutos ON tbProdutos.ID = tbVendasPedido.Produto   
WHERE tbEscalas.ID =@idEscala AND tbProdutos.Categoria = 17  
GROUP BY  tbEscalas.ID, tbEscalas.Descricao, tbEscalas.DataEscala, tbVendasPedido.TipoPagamento  