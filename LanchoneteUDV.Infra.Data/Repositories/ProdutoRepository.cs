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
    public class ProdutoRepository : IProdutoRepository
    {

        private readonly IConnectionFactory _connection;

        public ProdutoRepository(IConnectionFactory connection)
        {
            _connection = connection;
        }

        public Produto Add(Produto classe)
        {
            string sql = "INSERT INTO tbProdutos" +
                    "(Descricao,Categoria,PrecoCustoCaixa,QtdPorCaixa,PrecoCustoUnitario,PrecoVenda,EstoqueInicial,ProdutoVenda) " +
                    "VALUES(@descricao,@categoria, @precoCustoCaixa, @qtdPorCaixa, @precoCustoUnitario, @precoVenda, @estoqueInicial,@produtoVenda)";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    descricao = classe.Descricao,
                    categoria = classe.CategoriaId,
                    precoCustoCaixa = classe.PrecoCustoCaixa,
                    qtdPorCaixa = classe.QtdPorCaixa,
                    precoCustoUnitario = classe.PrecoCustoUnitario,
                    precoVenda = classe.PrecoVenda,
                    estoqueInicial = classe.EstoqueInicial,
                    produtoVenda = classe.ProdutoVenda
                });
            }
            return classe;
        }

        public IEnumerable<Produto> GetAll()
        {
            string sql = "SELECT A.ID,A.Descricao,A.PrecoCustoCaixa,A.QtdPorCaixa,A.PrecoCustoUnitario,A.PrecoVenda,A.EstoqueInicial,A.ProdutoVenda," +
                "B.ID AS CategoriaID,B.ID, B.Descricao " +
                "FROM tbProdutos A " +
                "INNER JOIN tbCategorias B ON B.ID=A.Categoria " +
                "order by A.Descricao";


            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<Produto, Categoria, Produto>(sql,
                    (a, b) =>
                    {
                        a.Categoria = b.Descricao;
                        a.CategoriaId = b.Id;
                        return a;
                    },
                    splitOn: "CategoriaID").AsQueryable();

                return result;

            }
        }

        public Produto GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produto> GetByName(string texto)
        {
            string sql = "SELECT A.ID,A.Descricao,A.PrecoCustoCaixa,A.QtdPorCaixa,A.PrecoCustoUnitario,A.PrecoVenda,A.EstoqueInicial,A.ProdutoVenda," +
                "B.ID AS CategoriaID,B.ID, B.Descricao " +
                "FROM tbProdutos A " +
                "INNER JOIN tbCategorias B ON B.ID=A.Categoria " +
                "WHERE A.Descricao LIKE '" + texto + "%' " +
                "order by A.Descricao";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<Produto, Categoria, Produto>(sql,
                    (a, b) =>
                    {
                        a.Categoria = b.Descricao;
                        a.CategoriaId = b.Id;
                        return a;
                    },
                    splitOn: "CategoriaID"
                   ).AsQueryable();

                return result;

            }
        }

        public IEnumerable<Produto> ListarProdutosParaVenda()
        {
            string sql = "SELECT ID,Descricao,PrecoVenda " +
                        "FROM tbProdutos " +
                        "WHERE ProdutoVenda=true " +
                        "order by Descricao;";


            using (var connection = _connection.Connection())
            {
                connection.Open();
                return connection.Query<Produto>(sql);

            }
        }

        public IEnumerable<Produto> ListarProdutosParaVendaPorEscala(int idEscala)
        {
            string sql = "SELECT A.ID,A.Descricao,A.PrecoVenda " +
                           "FROM tbProdutos AS A " +
                           "INNER JOIN tbEstoqueEscala AS B ON B.Produto=A.ID " +
                           "WHERE A.ProdutoVenda=1 AND B.Escala=@idEscala " +
                           "order by Descricao;";


            using (var connection = _connection.Connection())
            {
                connection.Open();
                return connection.Query<Produto>(sql, new
                {
                    idEscala = idEscala
                });

            }
        }

        public void Remove(int id)
        {
            string sql = "DELETE FROM tbProdutos WHERE ID=@id";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    id = id
                });
            }
        }

        public Produto Update(Produto classe)
        {
            string sql = "UPDATE tbProdutos SET Descricao = @descricao, Categoria = @categoria, PrecoCustoCaixa = @precoCustoCaixa," +
                        "QtdPorCaixa=@qtdPorCaixa,PrecoCustoUnitario=@precoCustoUnitario,PrecoVenda=@precoVenda," +
                        "EstoqueInicial=@estoqueInicial,ProdutoVenda=@produtoVenda " +
                        "WHERE ID=@id";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    descricao = classe.Descricao,
                    categoria = classe.CategoriaId,
                    precoCustoCaixa = classe.PrecoCustoCaixa,
                    qtdPorCaixa = classe.QtdPorCaixa,
                    precoCustoUnitario = classe.PrecoCustoUnitario,
                    precoVenda = classe.PrecoVenda,
                    estoqueInicial = classe.EstoqueInicial,
                    produtoVenda = classe.ProdutoVenda,
                    id = classe.Id
                });
            }
            return classe;
        }
    }
}
