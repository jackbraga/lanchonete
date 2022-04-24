	SELECT B.Nome,A.DataEscala,A.Descricao,A.TipoPagamento,'LANCHONETE' AS Frente, SUM(Valor) AS VALOR
	FROM (
	SELECT ISNULL(C.ResponsavelFinanceiro,C.ID) AS ID, B.Descricao,B.DataEscala, A.TipoPagamento ,SUM(D.Quantidade * D.PrecoProduto) AS Valor
	FROM		tbVendas	AS A
	INNER JOIN	tbEscalas	AS B ON B.ID=A.Escala
	INNER JOIN	tbSocios	AS C ON C.ID=A.Socio
	INNER JOIN	tbVendasPedido AS D ON D.Venda=A.ID	
	INNER JOIN  tbProdutos AS E ON E.ID=D.Produto
	WHERE E.Categoria=15 AND B.ID=1033
	GROUP BY  ISNULL(C.ResponsavelFinanceiro,C.ID),NOME,B.Descricao,B.DataEscala,A.TipoPagamento

	) AS A
	INNER JOIN tbSocios as B ON B.ID=A.ID
	GROUP BY NOME, A.DataEscala, A.Descricao,A.TipoPagamento
UNION ALL
	SELECT B.Nome,A.DataEscala,A.Descricao,A.TipoPagamento,'CHURRASCO', SUM(Valor) AS VALOR
	FROM (
	SELECT ISNULL(C.ResponsavelFinanceiro,C.ID) AS ID, B.Descricao,B.DataEscala, A.TipoPagamento ,SUM(D.Quantidade * D.PrecoProduto) AS Valor
	FROM		tbVendas	AS A
	INNER JOIN	tbEscalas	AS B ON B.ID=A.Escala
	INNER JOIN	tbSocios	AS C ON C.ID=A.Socio
	INNER JOIN	tbVendasPedido AS D ON D.Venda=A.ID	
	INNER JOIN  tbProdutos AS E ON E.ID=D.Produto
	WHERE E.Categoria<>15 AND B.ID=1033
	GROUP BY  ISNULL(C.ResponsavelFinanceiro,C.ID),NOME,B.Descricao,B.DataEscala,A.TipoPagamento

	) AS A
	INNER JOIN tbSocios as B ON B.ID=A.ID
	GROUP BY NOME, A.DataEscala, A.Descricao,A.TipoPagamento
	ORDER BY DataEscala DESC, B.Nome

