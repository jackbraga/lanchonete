USE LANCHONETE
GO
CREATE FUNCTION ItensVendidos(@produto INT, @escala INT)
RETURNS INT AS
BEGIN
	DECLARE @qtd INT						
	SET @qtd =(SELECT SUM(tbVendasPedido.Quantidade) 
	FROM tbVendasPedido  
	INNER JOIN tbVendas ON tbVendas.ID = tbVendasPedido.Venda 
	INNER JOIN tbProdutos ON tbProdutos.ID=tbVendasPedido.Produto
	WHERE  tbProdutos.ID=@produto AND tbVendas.Escala =   @escala)
	RETURN @qtd;
END
GO