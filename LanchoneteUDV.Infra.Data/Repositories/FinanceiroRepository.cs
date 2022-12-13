using Dapper;
using LanchoneteUDV.Domain.Entidades;
using LanchoneteUDV.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Infra.Data.Repositories
{
    public class FinanceiroRepository : IFinanceiroRepository
    {
        private readonly IConnectionFactory _connection;
        public FinanceiroRepository(IConnectionFactory connection)
        {
            _connection = connection;
        }
        public void AtualizaEmailDisparado(int idVenda)
        {
            string sql= "UPDATE tbVendas " +
                        "SET EmailDisparado=1 " +
                        "WHERE ID=@id";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    id = idVenda
                });
            }
        }

        public IEnumerable<RepasseFinanceiro> ListarItensRepasseFinanceiro(int idEscala, int idSocio)
        {
            string sql = "SELECT A.DataEscala,A.Descricao as Escala, B.Nome,C.ID AS IdProduto, C.Descricao as Produto, E.PrecoProduto, SUM(E.Quantidade) AS Quantidade " +
                            "FROM tbEscalas AS A " +
                            "INNER JOIN(tbSocios AS B " +
                            "INNER JOIN (tbProdutos AS C " +
                            "INNER JOIN (tbVendas AS D " +
                            "INNER JOIN tbVendasPedido AS E ON D.ID = E.Venda) ON C.ID = E.Produto) ON B.ID = D.Socio) ON A.ID = D.Escala " +
                            "WHERE A.ID =" + idEscala + " AND B.ID = " + idSocio + " AND E.TipoPagamento='BOLETO' " +
                            "GROUP BY A.DataEscala,A.Descricao, B.Nome,C.ID, C.Descricao, E.PrecoProduto ;";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<RepasseFinanceiro>(sql);

                return result;
            }
            
        }

        public IEnumerable<VendaRepasseFinanceiro> ListarVendasRepasseFinanceiro(int idEscala)
        {
            string sql = "SELECT tbVendas.ID as IdVenda, tbSocios.ID as IdSocio,  tbSocios.Nome, SUM(tbVendasPedido.Quantidade * tbVendasPedido.PrecoProduto) AS Total, ISNULL(tbVendas.EmailDisparado,0) AS EmailDisparado, tbSocios.Email  " +
                        "FROM tbSocios " +
                        "INNER JOIN(tbEscalas " +
                        "INNER JOIN (tbVendas " +
                        "INNER JOIN tbVendasPedido " +
                        "ON tbVendas.ID = tbVendasPedido.Venda) " +
                        "ON tbEscalas.ID = tbVendas.Escala) " +
                        "ON tbSocios.ID = tbVendas.Socio " +
                        "WHERE tbEscalas.ID=" + idEscala + " " +
                        "AND tbVendasPedido.TipoPagamento='BOLETO' " +
                        "GROUP BY  tbVendas.ID, tbSocios.ID,  tbSocios.Nome, ISNULL(tbVendas.EmailDisparado,0), tbSocios.Email " +
                        "ORDER BY tbSocios.Nome ; ";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<VendaRepasseFinanceiro>(sql);
                return result;
            }
        }

        public IEnumerable<RepasseFinanceiroExcel> GerarListaRepasseFinanceiroExcel(int idEscala)
        {
            string sql =
	"SELECT B.Nome,A.DataEscala,A.Descricao,A.TipoPagamento,'Churrasco' AS Frente, SUM(Valor) AS VALOR " +
    "FROM ( " +
    "SELECT ISNULL(C.ResponsavelFinanceiro,C.ID) AS ID, B.Descricao,B.DataEscala, D.TipoPagamento ,SUM(D.Quantidade * D.PrecoProduto) AS Valor " +
    "FROM		tbVendas	AS A " +
    "INNER JOIN	tbEscalas	AS B ON B.ID=A.Escala " +
	"INNER JOIN	tbSocios	AS C ON C.ID=A.Socio " +
	"INNER JOIN	tbVendasPedido AS D ON D.Venda=A.ID	" +
	"INNER JOIN  tbProdutos AS E ON E.ID=D.Produto " +
	"WHERE E.Categoria=15 AND B.ID=" + idEscala + " " +
	"GROUP BY  ISNULL(C.ResponsavelFinanceiro,C.ID),NOME,B.Descricao,B.DataEscala,D.TipoPagamento " +
	") AS A " +
	"INNER JOIN tbSocios as B ON B.ID=A.ID " +
	"GROUP BY NOME, A.DataEscala, A.Descricao,A.TipoPagamento " +
    "UNION ALL " +
	"SELECT B.Nome,A.DataEscala,A.Descricao,A.TipoPagamento,'Lanchonete', SUM(Valor) AS VALOR " +
	"FROM ( " +
	"SELECT ISNULL(C.ResponsavelFinanceiro,C.ID) AS ID, B.Descricao,B.DataEscala, D.TipoPagamento ,SUM(D.Quantidade * D.PrecoProduto) AS Valor " +
    "FROM		tbVendas	AS A " +
    "INNER JOIN	tbEscalas	AS B ON B.ID=A.Escala " +
    "INNER JOIN	tbSocios	AS C ON C.ID=A.Socio " +
    "INNER JOIN	tbVendasPedido AS D ON D.Venda=A.ID	 " +
    "INNER JOIN  tbProdutos AS E ON E.ID=D.Produto " +
    "WHERE E.Categoria<>15 AND E.Categoria<>16 AND B.ID=" + idEscala + " " +
    "GROUP BY  ISNULL(C.ResponsavelFinanceiro,C.ID),NOME,B.Descricao,B.DataEscala,D.TipoPagamento " +
    ") AS A " +
    "INNER JOIN tbSocios as B ON B.ID=A.ID " +
    "GROUP BY NOME, A.DataEscala, A.Descricao,A.TipoPagamento " +
    "ORDER BY DataEscala DESC, B.Nome ";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<RepasseFinanceiroExcel>(sql);
                return result;
            }
        }

        public IEnumerable<RepasseFinanceiroExcel> GerarListaRepasseFinanceiroParceriaExcel(int idEscala)
        {
            string sql =
                "SELECT B.Nome,A.DataEscala,A.Descricao,A.TipoPagamento,'Lanchonete' AS Frente,SUM(Valor) AS VALOR , A.Parceria " +
                "FROM( " +
                "SELECT ISNULL(C.ResponsavelFinanceiro, C.ID) AS ID, B.Descricao, B.DataEscala, D.TipoPagamento, G.Descricao AS Parceria, SUM(D.Quantidade * D.PrecoProduto) AS Valor " +
                "FROM        tbVendas    AS A " +
                "INNER JOIN  tbEscalas   AS B ON B.ID = A.Escala " +
                "INNER JOIN  tbSocios    AS C ON C.ID = A.Socio " +
                "INNER JOIN  tbVendasPedido AS D ON D.Venda = A.ID " +
                "INNER JOIN  tbProdutos AS E ON E.ID = D.Produto " +
                "INNER JOIN  tbParceriasProduto AS F ON F.IDProduto = E.ID " +
                "INNER JOIN  tbParcerias        AS G ON G.ID = F.IDParceira " +
                "WHERE E.Categoria = 16 AND B.ID = " + idEscala  + " " +
                "GROUP BY  ISNULL(C.ResponsavelFinanceiro, C.ID), NOME, B.Descricao, B.DataEscala, D.TipoPagamento, G.Descricao " +
                ") AS A " +
                "INNER JOIN tbSocios as B ON B.ID = A.ID " +
                "GROUP BY NOME, A.DataEscala, A.Descricao,A.TipoPagamento, A.Parceria " +
                "ORDER BY DataEscala DESC, B.Nome  ";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<RepasseFinanceiroExcel>(sql);
                return result;
            }
        }

        public IEnumerable<Caixa> GerarListaFluxoCaixaEscala(int idEscala)
        {
            string sql =
            @" SELECT DataEscala AS DataEvento,
                TipoEvento,ResumoVendas AS Valor,Descricao AS Observacao,CategoriaLancamento AS IdCategoria,
                TipoPagamento AS EspecieMoeda, Frente from dbo.FluxoCaixaEscala(@idEscala)  ";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<Caixa>(sql, new
                {
                    idEscala = idEscala
                });
                return result;
            }
        }
    }
}