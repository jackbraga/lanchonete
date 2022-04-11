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



    public class CompraRepository : ICompraRepository
    {

        private readonly IConnectionFactory _connection;

        public CompraRepository(IConnectionFactory connection)
        {
            _connection = connection;
        }
        public Compra Add(Compra classe)
        {
            string sql = "INSERT INTO tbCompras" +
                    "(Produto,Quantidade,PrecoUnitario,CompradoPor,DataCompra,TipoEntrada,Observacao) " +
                "VALUES" +
                    "(@produto,@quantidade,@precoUnitario,@compradoPor,@dataCompra,@tipoEntrada,@observacao)";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    produto = classe.IdProduto,
                    quantidade = classe.Quantidade,
                    precoUnitario = classe.PrecoUnitario,
                    compradoPor = classe.CompradoPor,
                    dataCompra = classe.DataCompra,
                    tipoEntrada = classe.TipoEntrada,
                    observacao = classe.Observacao
                });
            }
            return classe;
        }

        public IEnumerable<Compra> GetAll()
        {
            string sql = "SELECT  A.ID,A.DataCompra, A.Quantidade, A.PrecoUnitario, A.CompradoPor,  A.TipoEntrada, A.Observacao,B.ID AS IDProduto, B.ID,B.Descricao " +
                    "FROM tbCompras AS A WITH(NOLOCK) " +
                    "INNER JOIN tbProdutos AS B  WITH(NOLOCK) ON B.ID = A.Produto " +
                "order by A.DataCompra Desc";


            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<Compra, Produto, Compra>(sql,
                    (a, b) =>
                    {
                        a.DescricaoProduto = b.Descricao;
                        a.IdProduto = b.Id;
                        return a;
                    },
                    splitOn: "IDProduto").AsQueryable();

                return result;

            }
        }

        public Compra GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Compra> GetByName(string texto)
        {
            string sql = "SELECT  A.ID,A.DataCompra, A.Quantidade, A.PrecoUnitario, A.CompradoPor, A.TipoEntrada, A.Observacao,B.ID AS IDProduto,B.Descricao  " +
                    "FROM tbCompras AS A INNER JOIN tbProdutos AS B ON B.ID = A.Produto " +
                    "WHERE DataCompra > '" + texto + "' " +
                    "order by A.DataCompra Desc";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<Compra, Produto, Compra>(sql,
                    (a, b) =>
                    {
                        a.DescricaoProduto = b.Descricao;
                        a.IdProduto = b.Id;
                        return a;
                    },
                    splitOn: "IDProduto"
                   ).AsQueryable();

                return result;

            }
        }

        public void Remove(int id)
        {
            string sql = "DELETE FROM tbCompras WHERE ID=@id";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    id = id
                });
            }
        }

        public Compra Update(Compra classe)
        {
            string sql = "UPDATE tbCompras SET " +
                    "Produto=@produto," +
                    "Quantidade=@quantidade," +
                    "PrecoUnitario=@precoUnitario," +
                    "CompradoPor=@compradoPor," +
                    "DataCompra=@dataCompra, " +
                    "TipoEntrada=@tipoEntrada, " +
                    "Observacao=@observacao " +
                    "WHERE ID=@idCompra;";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    produto = classe.IdProduto,
                    quantidade = classe.Quantidade,
                    precoUnitario = classe.PrecoUnitario,
                    compradoPor = classe.CompradoPor,
                    dataCompra = classe.DataCompra,
                    tipoEntrada = classe.TipoEntrada,
                    observacao = classe.Observacao,
                    idCompra = classe.Id

                });
            }
            return classe;
        }
    }

}
