using Dapper;
using LanchoneteUDV.Domain.Entidades;
using LanchoneteUDV.Domain.Interfaces;

namespace LanchoneteUDV.Infra.Data.Repositories
{
    public class EstoqueEscalaRepository : IEstoqueEscalaRepository
    {
        private readonly IConnectionFactory _connection;

        public EstoqueEscalaRepository(IConnectionFactory connection)
        {
            _connection = connection;
        }

        public EstoqueEscala Add(EstoqueEscala classe)
        {
            string sql = "INSERT INTO tbEstoqueEscala" +
                    "(Escala,Produto,QtdVenda,Observacao) " +
                "VALUES" +
                    "(@escala,@produto,@qtdVenda,@observacao)";

            using (var connection = _connection.Connection())
            {
                connection.Open();

                connection.Execute(sql, new
                {
                    escala = classe.IdEscala,
                    produto = classe.IdProduto,
                    qtdVenda = classe.QtdVenda,
                    observacao = classe.Observacao
                });

            }
            return classe;
        }

        public void CompletarEstoqueEscala(int idEscala)
        {
            string sqlDelete = "DELETE FROM tbEstoqueEscala WHERE Escala = @escala ";
            string sql = 
                        "INSERT INTO tbEstoqueEscala(Escala, Produto, QtdVenda, Observacao) " +
                        "SELECT DISTINCT " +
                        "@escala AS ESCALA, " +
                        "A.ID, " +
                        "(ISNULL(EstoqueInicial, 0) + ISNULL((SELECT SUM(tbCompras.Quantidade) FROM tbCompras WHERE Produto = A.ID), 0) - ISNULL((SELECT SUM(tbVendasPedido.Quantidade) FROM tbVendasPedido WHERE Produto = A.ID),0)) AS Estoque, " +
                        "'CARGA COMPLETA' AS Observacao " +
                        "FROM tbProdutos AS A " +
                        "LEFT JOIN tbCompras AS B ON A.ID = B.Produto " +
                        "LEFT JOIN tbVendasPedido AS C ON A.ID = C.Produto " +
                        "WHERE A.ProdutoVenda = 1 AND A.Categoria <> 10 and " +
                        "(ISNULL(EstoqueInicial, 0) + ISNULL((SELECT SUM(tbCompras.Quantidade) FROM tbCompras WHERE Produto = A.ID), 0) - ISNULL((SELECT SUM(tbVendasPedido.Quantidade) FROM tbVendasPedido WHERE Produto = A.ID),0)) > 0 " +
                        "GROUP BY A.ID, A.Descricao, A.PrecoVenda, A.EstoqueInicial ";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sqlDelete, new
                {
                    escala = idEscala
                });
                connection.Execute(sql, new
                {
                    escala = idEscala
                });
            }
        }

        public IEnumerable<EstoqueEscala> ListarProdutosEstoqueEscala(int idEscala)
        {
            string sql= "SELECT B.ID, B.Produto, B.QtdVenda ,B.Observacao,A.ID as IDProduto,A.ID,A.Descricao " +
                           "FROM tbProdutos AS A " +
                           "INNER JOIN tbEstoqueEscala AS B ON A.ID = B.Produto " +
                           "WHERE B.Escala=" + idEscala + " " +
                           "ORDER BY A.Descricao; ";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<EstoqueEscala, Produto, EstoqueEscala>(sql,
                    (a, b) =>
                    {
                        a.IdProduto = b.Id;
                        a.DescricaoProduto = b.Descricao;
                        a.IdEscala = idEscala;
                        return a;
                    },
                    splitOn: "IDProduto").AsQueryable();
                return result;
            }
        }

        public IEnumerable<Estoque> ListarEstoque()
        {
            string sql = "SELECT DISTINCT A.ID AS IdProduto, A.Descricao AS DescricaoProduto, A.PrecoVenda, " +
                    "A.EstoqueInicial, " +
                    "(SELECT SUM(tbCompras.Quantidade) FROM tbCompras WHERE Produto = A.ID) AS Entrada, " +
                    "(SELECT SUM(tbVendasPedido.Quantidade) FROM tbVendasPedido WHERE Produto = A.ID) AS Saida, " +
                    "(ISNULL(EstoqueInicial,0) + ISNULL((SELECT SUM(tbCompras.Quantidade) FROM tbCompras WHERE Produto = A.ID),0) - ISNULL((SELECT SUM(tbVendasPedido.Quantidade) FROM tbVendasPedido WHERE Produto = A.ID),0)) AS QtdEstoque " +
                    "FROM tbProdutos AS A " +
                    "LEFT JOIN tbCompras AS B ON A.ID = B.Produto " +
                    "LEFT JOIN tbVendasPedido AS C ON A.ID = C.Produto " +
                    "WHERE A.ProdutoVenda = 1 " +
                    "GROUP BY A.ID, A.Descricao, A.PrecoVenda, A.EstoqueInicial " +
                    "ORDER BY A.Descricao ;";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<Estoque>(sql);
                return result;

            }
        }

        public IEnumerable<Estoque> ListarEstoqueComboProdutos(int idEscala)
        {
            //string todosProdutos = todos ? " NOT " : "";
            string sql = "SELECT A.ID AS IdProduto, A.Descricao AS DescricaoProduto,(ISNULL(EstoqueInicial,0) + ISNULL((SELECT SUM(tbCompras.Quantidade) FROM tbCompras WHERE Produto = A.ID),0) - ISNULL((SELECT SUM(tbVendasPedido.Quantidade) FROM tbVendasPedido WHERE Produto = A.ID),0)) AS QtdEstoque " +
                         "FROM tbProdutos AS A WITH(NOLOCK) " +
                         "LEFT JOIN tbEstoqueEscala AS B WITH(NOLOCK) ON B.Produto = A.ID AND B.Escala = " + idEscala  + " " +
                         "WHERE B.Produto IS NULL AND A.ProdutoVenda = 1 AND " +
                         "(ISNULL(EstoqueInicial, 0) + ISNULL((SELECT SUM(tbCompras.Quantidade) FROM tbCompras WHERE Produto = A.ID), 0) - ISNULL((SELECT SUM(tbVendasPedido.Quantidade) FROM tbVendasPedido WHERE Produto = A.ID),0)) > 0";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<Estoque>(sql);
                return result;

            }
        }

        public IEnumerable<Estoque> PesquisarEstoque(string pesquisa)
        {
            string sql = "SELECT DISTINCT A.ID, A.Descricao, A.PrecoVenda, " +
                    "A.EstoqueInicial, " +
                    "(SELECT SUM(tbCompras.Quantidade) FROM tbCompras WHERE Produto = A.ID) AS Entrada, " +
                    "(SELECT SUM(tbVendasPedido.Quantidade) FROM tbVendasPedido WHERE Produto = A.ID) AS Saida, " +
                    "(ISNULL(EstoqueInicial,0) + ISNULL((SELECT SUM(tbCompras.Quantidade) FROM tbCompras WHERE Produto = A.ID),0) - ISNULL((SELECT SUM(tbVendasPedido.Quantidade) FROM tbVendasPedido WHERE Produto = A.ID),0)) AS Estoque " +
                    "FROM tbProdutos AS A " +
                    "LEFT JOIN tbCompras AS B ON A.ID = B.Produto " +
                    "LEFT JOIN tbVendasPedido AS C ON A.ID = C.Produto " +
                    "WHERE A.ProdutoVenda = 1  AND A.Descricao LIKE '" + pesquisa + "%' " +
                    "GROUP BY A.ID, A.Descricao, A.PrecoVenda, A.EstoqueInicial " +
                    "ORDER BY A.Descricao ;";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<Estoque>(sql);
                return result;

            }
        }

        public void Remove(int id)
        {
            string sql = "DELETE FROM tbEstoqueEscala WHERE ID=@id";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    id = id
                });
            }
        }

        public EstoqueEscala Update(EstoqueEscala classe)
        {
            string sql = "UPDATE tbEstoqueEscala SET " +

                    "Produto=@produto," +
                    "QtdVenda=@qtdvenda," +
                    "Observacao=@observacao " +
                    "WHERE ID=@idEstoqueEscala;";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    produto=classe.IdProduto,
                    qtdVenda=classe.QtdVenda,
                    observacao=classe.Observacao,
                    idEstoqueEscala=classe.Id
                });
            }
            return classe;
        }
    }
}