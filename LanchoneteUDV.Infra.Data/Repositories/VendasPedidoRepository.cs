﻿using Dapper;
using LanchoneteUDV.Domain.Entidades;
using LanchoneteUDV.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Infra.Data.Repositories
{
    public class VendasPedidoRepository : IVendasPedidoRepository
    {
        private readonly IConnectionFactory _connection;

        public VendasPedidoRepository(IConnectionFactory connection)
        {
            _connection = connection;
        }

        public void Add(VendasPedido vendaPedido)
        {
            string sql = "INSERT INTO tbVendasPedido" +
                    "(Venda,Produto,Quantidade,PrecoProduto,Observacao,Retirado,DataHoraPedido,TipoPagamento) " +
                "VALUES" +
                    "(@idVenda,@idProduto,@quantidade,@precoProduto,@observacao,@retirado,@dataHoraPedido, @tipoPagamento)";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Query<VendasPedido>(sql, new
                {
                    idVenda = vendaPedido.IdVenda,
                    idProduto = vendaPedido.IdProduto,
                    quantidade = vendaPedido.Quantidade,
                    precoProduto = vendaPedido.PrecoProduto,
                    observacao = vendaPedido.Observacao,
                    retirado = vendaPedido.Retirado,
                    dataHoraPedido = vendaPedido.DataHoraPedido,
                    tipoPagamento = vendaPedido.TipoPagamento
                });
            }
        }

        public void AtualizaFormaPagamentoItem(int idVendaPedido, string tipoPagamento)
        {
            string sql = "UPDATE tbVendasPedido " +
                          "SET TipoPagamento=@pagamento " +
                          "WHERE ID=@id;";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    pagamento = tipoPagamento,
                    id = idVendaPedido
                });
            }
        }

        public void DesmarcarPagamentoItem(int idVendaPedido)
        {
            string sql = "UPDATE tbVendasPedido " +
                   "SET ItemPago=0 " +
                   "WHERE ID=@id;";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    id = idVendaPedido
                });
            }
        }

        public void DesmarcarRetirada(int idVendaPedido)
        {
            string sql = "UPDATE tbVendasPedido " +
                "SET Retirado=0 " +
                "WHERE ID=@id;";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    id = idVendaPedido
                });
            }
        }

        public IEnumerable<VendasPedidoEscala> ListarTodosVendasPedido(int idEscala, string filtro, bool soSemRetirar)
        {
            string sqlFiltro = "";

            if (!filtro.Equals("Todos"))
            {
                 sqlFiltro =  $"AND tbCategorias.Descricao='{filtro}' ";
            }

            if (soSemRetirar)
            {
                sqlFiltro = sqlFiltro + $" AND tbVendasPedido.Retirado=0 ";
            }


            string sql = "SELECT tbVendasPedido.ID,tbVendasPedido.DataHoraPedido, tbSocios.Nome, tbProdutos.Descricao, tbVendasPedido.TipoPagamento, " +
                        "tbVendasPedido.Quantidade, tbVendasPedido.Retirado, tbVendasPedido.Observacao " +
                        "FROM tbProdutos " +
                        "INNER JOIN(tbSocios " +
                        "INNER JOIN((tbEscalas " +
                        "INNER JOIN tbVendas ON tbEscalas.ID = tbVendas.Escala) " +
                        "INNER JOIN tbVendasPedido ON tbVendas.ID = tbVendasPedido.Venda) ON tbSocios.ID = tbVendas.Socio) ON tbProdutos.ID = tbVendasPedido.Produto " +
                        "INNER JOIN tbCategorias ON tbCategorias.ID=tbProdutos.Categoria " +
                        "WHERE tbEscalas.ID =" + idEscala + " " + sqlFiltro + 
                        "ORDER BY tbVendasPedido.Retirado asc, tbVendasPedido.DataHoraPedido; ";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<VendasPedidoEscala>(sql);
                return result;
            }
        }



        public IEnumerable<VendasPedidoSocio> ListarVendasPedido(int idVenda)
        {
            string sql = "SELECT tbVendasPedido.ID, tbProdutos.Descricao,tbVendasPedido.PrecoProduto ,tbVendasPedido.Quantidade, " +
            "(tbVendasPedido.Quantidade * tbVendasPedido.PrecoProduto) AS Total, tbVendasPedido.Observacao, tbVendasPedido.Retirado, tbVendasPedido.DataHoraPedido,  tbVendasPedido.TipoPagamento, ISNULL(tbVendasPedido.ItemPago,0) AS ItemPago  " +
            "FROM tbProdutos INNER JOIN tbVendasPedido ON tbProdutos.ID = tbVendasPedido.Produto " +
            "WHERE tbVendasPedido.Venda=" + idVenda + " " +
            "ORDER BY tbVendasPedido.Retirado desc, tbProdutos.Descricao;";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<VendasPedidoSocio>(sql);
                return result;
            }
        }

        public void RegistrarPagamentoItem(int idVendaPedido)
        {
            string sql = "UPDATE tbVendasPedido " +
                         "SET ItemPago=1 " +
                         "WHERE ID=@id;";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    id = idVendaPedido
                });
            }
        }

        public void RegistrarRetirada(int idVendaPedido)
        {
            string sql = "UPDATE tbVendasPedido " +
                "SET Retirado=1 " +
                "WHERE ID=@id;";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    id = idVendaPedido
                });
            }
        }

        public void Remove(int idVendaPedido)
        {
            string sql = "DELETE FROM tbVendasPedido " +
                "WHERE ID=@id;";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    id = idVendaPedido
                });
            }
        }


    }
}
