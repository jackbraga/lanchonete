ALTER TABLE tbVendasPedido ADD TipoPagamento VARCHAR(50)
GO
UPDATE tbVendasPedido SET TipoPagamento='BOLETO' WHERE VENDA IN(SELECT ID FROM tbVendas WHERE TipoPagamento='BOLETO')
UPDATE tbVendasPedido SET TipoPagamento='DINHEIRO' WHERE VENDA IN(SELECT ID FROM tbVendas WHERE TipoPagamento='DINHEIRO')
UPDATE tbVendasPedido SET TipoPagamento='PIX' WHERE VENDA IN(SELECT ID FROM tbVendas WHERE TipoPagamento='PIX')