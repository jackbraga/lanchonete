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
                            "WHERE A.ID =" + idEscala + " AND B.ID = " + idSocio + " " +
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
            string sql = "SELECT tbVendas.ID as IdVenda, tbSocios.ID as IdSocio,  tbSocios.Nome, tbVendas.TipoPagamento, SUM(tbVendasPedido.Quantidade * tbVendasPedido.PrecoProduto) AS Total, ISNULL(tbVendas.EmailDisparado,0) AS EmailDisparado, tbSocios.Email  " +
                        "FROM tbSocios " +
                        "INNER JOIN(tbEscalas " +
                        "INNER JOIN (tbVendas " +
                        "INNER JOIN tbVendasPedido " +
                        "ON tbVendas.ID = tbVendasPedido.Venda) " +
                        "ON tbEscalas.ID = tbVendas.Escala) " +
                        "ON tbSocios.ID = tbVendas.Socio " +
                        "WHERE tbEscalas.ID=" + idEscala + " " +
                        "AND tbVendas.TipoPagamento='BOLETO' " +
                        "GROUP BY  tbVendas.ID, tbSocios.ID,  tbSocios.Nome, tbVendas.TipoPagamento, ISNULL(tbVendas.EmailDisparado,0), tbSocios.Email " +
                        "ORDER BY tbSocios.Nome ; ";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<VendaRepasseFinanceiro>(sql);
                return result;
            }
        }
    }
}