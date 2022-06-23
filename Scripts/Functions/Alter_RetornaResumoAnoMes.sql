alter FUNCTION RetornaResumoAnoMes(@Ano INT, @Mes INT)  
RETURNS TABLE AS   
RETURN  
(  
SELECT @Mes AS MES,    
ISNULL((SELECT SUM(VALOR) AS Entradas FROM tbCaixa WHERE TipoEvento = 'Entrada' AND MONTH(DataEvento)=@Mes AND YEAR(DataEvento)=@Ano),0) AS Entradas,     
ISNULL((SELECT SUM(VALOR) AS Entradas FROM tbCaixa WHERE TipoEvento = 'Saida' AND MONTH(DataEvento)=@Mes AND YEAR(DataEvento)=@Ano),0) AS Saidas,     
ISNULL((SELECT SUM(VALOR) AS Entradas FROM tbCaixa WHERE TipoEvento = 'Entrada' AND CategoriaLancamento NOT IN(3, 4) AND MONTH(DataEvento)=@Mes AND YEAR(DataEvento)=@Ano),0) AS Faturado,     
ISNULL((ISNULL((SELECT SUM(VALOR) AS Entradas FROM tbCaixa WHERE TipoEvento = 'Entrada' AND CategoriaLancamento NOT IN(3, 4) AND MONTH(DataEvento)=@Mes AND YEAR(DataEvento)=@Ano),0) + ISNULL((SELECT SUM(VALOR) AS Entradas FROM tbCaixa WHERE TipoEvento = 'Saida' AND MONTH(
DataEvento)=@Mes AND YEAR(DataEvento)=@Ano),0)),0) AS Lucro    
)