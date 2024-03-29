﻿using Dapper;
using LanchoneteUDV.Domain.Entidades;
using LanchoneteUDV.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Infra.Data.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        private readonly IConnectionFactory _connection;

        public VendaRepository(IConnectionFactory connectionFactory)
        {
            _connection = connectionFactory;
        }
        public IEnumerable<VendaEscala> ListarVendasEscala(int idEscala)
        {
            string sql = "SELECT tbVendas.ID AS IdVenda, tbSocios.ID AS IdSocio,  tbSocios.Nome AS NomeSocio, " +
                        "SUM(tbVendasPedido.Quantidade * tbVendasPedido.PrecoProduto) AS TotalVenda," +
                        "(SELECT COUNT(*) FROM tbVendasPedido WHERE Venda = tbVendas.ID AND Retirado = 0) AS PendenteRetirada " +
                        "FROM tbSocios " +
                        "INNER JOIN(tbEscalas " +
                        "INNER JOIN (tbVendas " +
                        "INNER JOIN tbVendasPedido " +
                        "ON tbVendas.ID = tbVendasPedido.Venda) " +
                        "ON tbEscalas.ID = tbVendas.Escala) " +
                        "ON tbSocios.ID = tbVendas.Socio " +
                        "WHERE tbEscalas.ID=" + idEscala + " " +
                        "GROUP BY  tbVendas.ID, tbSocios.ID,  tbSocios.Nome " +
                        "ORDER BY 5 desc,tbSocios.Nome ; ";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<VendaEscala>(sql);
                return result;

            }
        }

        public IEnumerable<VendaEscala> ListarVendasPesquisa(int idEscala, string pesquisa)
        {
            string sql = "SELECT tbVendas.ID AS IdVenda, tbSocios.ID AS IdSocio,  tbSocios.Nome AS NomeSocio, tbVendas.TipoPagamento, " +
            "SUM(tbVendasPedido.Quantidade * tbVendasPedido.PrecoProduto) AS TotalVenda," +
            "(SELECT COUNT(*) FROM tbVendasPedido WHERE Venda = tbVendas.ID AND Retirado = 0) AS PendenteRetirada " +
            "FROM tbSocios " +
            "INNER JOIN(tbEscalas " +
            "INNER JOIN (tbVendas " +
            "INNER JOIN tbVendasPedido " +
            "ON tbVendas.ID = tbVendasPedido.Venda) " +
            "ON tbEscalas.ID = tbVendas.Escala) " +
            "ON tbSocios.ID = tbVendas.Socio " +
            "WHERE tbEscalas.ID=" + idEscala + " AND tbSocios.Nome LIKE '" + pesquisa + "%' " +
            "GROUP BY  tbVendas.ID, tbSocios.ID,  tbSocios.Nome, tbVendas.TipoPagamento " +
            "ORDER BY 6 desc,tbSocios.Nome ; ";
            //string sql = "SELECT tbVendas.ID, tbSocios.ID,  tbSocios.Nome, tbVendas.TipoPagamento, SUM(tbVendasPedido.Quantidade * tbVendasPedido.PrecoProduto) AS Total,(SELECT COUNT(*) FROM tbVendasPedido WHERE Venda=tbVendas.ID AND Retirado=0) AS PendenteRetirada " +
            //"FROM tbSocios " +
            //"INNER JOIN(tbEscalas " +
            //"INNER JOIN (tbVendas " +
            //"INNER JOIN tbVendasPedido " +
            //"ON tbVendas.ID = tbVendasPedido.Venda) " +
            //"ON tbEscalas.ID = tbVendas.Escala) " +
            //"ON tbSocios.ID = tbVendas.Socio " +
            //"WHERE tbEscalas.ID=" + idEscala + " AND tbSocios.Nome LIKE '" + pesquisa + "%' " +
            //"GROUP BY  tbVendas.ID, tbSocios.ID,  tbSocios.Nome, tbVendas.TipoPagamento " +
            //"ORDER BY 6 desc,tbSocios.Nome ; ";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<VendaEscala>(sql);
                return result;

            }
        }

        public IEnumerable<VendaEscalaResumoVenda> TrazerVendaEscalaResumoVenda(int idEscala)
        {
            string sql = "SELECT " +
                "tbEscalas.ID AS IdEscala,  " +
                "tbEscalas.Descricao, " +
                "tbEscalas.DataEscala, " +
                "SUM((tbVendasPedido.PrecoProduto * tbVendasPedido.Quantidade)) AS ResumoVendas, " +
                "tbEscalas.Finalizada as EscalaFinalizada, " +
                "tbVendasPedido.TipoPagamento " +
                "FROM tbEscalas " +
                "LEFT JOIN tbVendas ON tbEscalas.ID = tbVendas.Escala " +
                "LEFT JOIN tbVendasPedido ON tbVendas.ID = tbVendasPedido.Venda " +
                "INNER JOIN tbProdutos ON tbProdutos.ID = tbVendasPedido.Produto " +
                "WHERE tbEscalas.ID = " + idEscala + " AND tbProdutos.Categoria <> 15 AND tbProdutos.Categoria <> 16 " +
                "GROUP BY  tbEscalas.ID, tbEscalas.Descricao, tbEscalas.DataEscala, tbVendasPedido.TipoPagamento,tbEscalas.Finalizada ";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<VendaEscalaResumoVenda>(sql);
                return result;
            }
        }

        public IEnumerable<VendaEscalaResumoVenda> TrazerVendaEscalaResumoVendaParcerias(int idEscala)
        {
            string sql = "SELECT " +
                "tbEscalas.ID AS IdEscala,  " +
                "tbEscalas.Descricao, " +
                "tbEscalas.DataEscala, " +
                "SUM((tbVendasPedido.PrecoProduto * tbVendasPedido.Quantidade)) AS ResumoVendas, " +
                "tbEscalas.Finalizada as EscalaFinalizada, " +
                "tbVendasPedido.TipoPagamento " +
                "FROM tbEscalas " +
                "LEFT JOIN tbVendas ON tbEscalas.ID = tbVendas.Escala " +
                "LEFT JOIN tbVendasPedido ON tbVendas.ID = tbVendasPedido.Venda " +
                "INNER JOIN tbProdutos ON tbProdutos.ID = tbVendasPedido.Produto " +
                "WHERE tbEscalas.ID = " + idEscala + " AND tbProdutos.Categoria = 16 " +
                "GROUP BY  tbEscalas.ID, tbEscalas.Descricao, tbEscalas.DataEscala, tbVendasPedido.TipoPagamento,tbEscalas.Finalizada ";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<VendaEscalaResumoVenda>(sql);
                return result;
            }
        }
        public IEnumerable<VendaEscalaResumoVenda> TrazerVendaEscalaResumoVendaChurrasco(int idEscala)
        {
            string sql = "SELECT " +
                "tbEscalas.ID AS IdEscala,  " +
                "tbEscalas.Descricao, " +
                "tbEscalas.DataEscala, " +
                "SUM((tbVendasPedido.PrecoProduto * tbVendasPedido.Quantidade)) AS ResumoVendas, " +
                "tbEscalas.Finalizada as EscalaFinalizada, " +
                "tbVendasPedido.TipoPagamento " +
                "FROM tbEscalas " +
                "LEFT JOIN tbVendas ON tbEscalas.ID = tbVendas.Escala " +
                "LEFT JOIN tbVendasPedido ON tbVendas.ID = tbVendasPedido.Venda " +
                "INNER JOIN tbProdutos ON tbProdutos.ID = tbVendasPedido.Produto " +
                "WHERE tbEscalas.ID = " + idEscala + " AND tbProdutos.Categoria = 15 " +
                "GROUP BY  tbEscalas.ID, tbEscalas.Descricao, tbEscalas.DataEscala, tbVendasPedido.TipoPagamento,tbEscalas.Finalizada ";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<VendaEscalaResumoVenda>(sql);
                return result;
            }
        }

        public IEnumerable<VendaEscalaSocio> TrazerVendaEscalaSocio(int idEscala, int idSocio)
        {
            string sql = "SELECT tbVendas.ID as IdVenda, SUM(tbVendasPedido.Quantidade * tbVendasPedido.PrecoProduto) AS TotalConsumido,ISNULL(tbVendasPedido.ItemPago,0) AS ItemPago  " +
                "FROM tbVendas " +
                "INNER JOIN tbVendasPedido ON tbVendasPedido.Venda=tbVendas.ID " +
                "WHERE Escala=" + idEscala + " AND Socio=" + idSocio + " " +
                "GROUP BY tbVendas.ID, tbVendasPedido.ItemPago ;";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<VendaEscalaSocio>(sql);
                return result;

            }
        }

        public async Task<IEnumerable<EstoquePorEscala>> ListarEstoquePorEscala(int idEscala)
        {
            string sql = "SELECT DISTINCT " +
                    "tbProdutos.Descricao as DescricaoProduto, " +
                    "tbProdutos.PrecoVenda, " +
                    "tbEstoqueEscala.QtdVenda, " +
                    "dbo.ItensVendidos(tbVendasPedido.Produto," + idEscala + ") AS Saida, " +
                    "(ISNULL(QtdVenda, 0) - ISNULL(dbo.ItensVendidos(tbVendasPedido.Produto," + idEscala + "),0)) AS Estoque " +
                    "FROM tbProdutos " +
                    "INNER JOIN tbEstoqueEscala ON tbProdutos.ID = tbEstoqueEscala.Produto " +
                    "LEFT JOIN tbVendasPedido ON tbProdutos.ID = tbVendasPedido.Produto " +
                    "WHERE Escala =" + idEscala + " AND tbProdutos.Categoria<>10 AND tbProdutos.Categoria<>15 ";
                   

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = await connection.QueryAsync<EstoquePorEscala>(sql);
                return result;

            }
        }

        public async Task<IEnumerable<EstoquePorEscala>> ListarEstoqueSalgadosPorEscala(int idEscala, bool exibeSalgados, bool exibeChurrasco)
        {
            int idSalgado = exibeSalgados ? 10 : 0;
            int idChurrasco = exibeChurrasco ? 15 : 0;


            string sql = "SELECT DISTINCT " +
                    "tbProdutos.Descricao as DescricaoProduto, " +
                    "tbProdutos.PrecoVenda, " +
                    "tbEstoqueEscala.QtdVenda, " +
                    "dbo.ItensVendidos(tbVendasPedido.Produto," + idEscala + ") AS Saida, " +
                    "(ISNULL(QtdVenda, 0) - ISNULL(dbo.ItensVendidos(tbVendasPedido.Produto," + idEscala + "),0)) AS Estoque " +
                    "FROM tbProdutos " +
                    "INNER JOIN tbEstoqueEscala ON tbProdutos.ID = tbEstoqueEscala.Produto " +
                    "LEFT JOIN tbVendasPedido ON tbProdutos.ID = tbVendasPedido.Produto " +
                    "WHERE Escala =" + idEscala + " AND tbProdutos.Categoria IN(" + idSalgado + "," + idChurrasco + ") "; 
                    

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = await connection.QueryAsync<EstoquePorEscala>(sql);
                return result;

            }

        }
    
        public int Add(Venda classe)
        {
            string sql = "INSERT INTO tbVendas" +
                    "(Escala,Socio) " +
                    "OUTPUT INSERTED.ID " +
                "VALUES" +
                    "(@idEscala,@idSocio)";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.ExecuteScalar<int>(sql, new
                {
                    idEscala = classe.IdEscala,
                    idSocio = classe.IdSocio
                });
                return result;
            }
            
          
        }

        public Venda Update(Venda classe)
        {
            string sql = "UPDATE tbVendas " +
                        "SET TipoPagamento=@tipoPagamento " +
                        "WHERE ID=@id";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    tipoPagamento = classe.TipoPagamento,
                    id = classe.Id
                });
            }
            return classe;
        }

    }
}
