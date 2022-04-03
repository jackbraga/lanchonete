using LanchoneteUDV.DataObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Database
{
    public class VendasDAL
    {
        Configuration _banco = new Configuration();


        public DataTable ListarEstoque()
        {
            DataTable dados = new DataTable();
            string query =
                    "SELECT DISTINCT A.ID, A.Descricao, A.PrecoVenda, " +
                    "A.EstoqueInicial, " +
                    "(SELECT SUM(tbCompras.Quantidade) FROM tbCompras WHERE Produto = A.ID) AS Entrada, " +
                    "(SELECT SUM(tbVendasPedido.Quantidade) FROM tbVendasPedido WHERE Produto = A.ID) AS Saida, " +
                    "(ISNULL(EstoqueInicial,0) + ISNULL((SELECT SUM(tbCompras.Quantidade) FROM tbCompras WHERE Produto = A.ID),0) - ISNULL((SELECT SUM(tbVendasPedido.Quantidade) FROM tbVendasPedido WHERE Produto = A.ID),0)) AS Estoque " +
                    "FROM tbProdutos AS A " +
                    "LEFT JOIN tbCompras AS B ON A.ID = B.Produto " +
                    "LEFT JOIN tbVendasPedido AS C ON A.ID = C.Produto " +
                    "WHERE A.ProdutoVenda = 1 " +
                    "GROUP BY A.ID, A.Descricao, A.PrecoVenda, A.EstoqueInicial " +
                    "ORDER BY A.Descricao ;";

            try
            {
                dados = _banco.ExecutarQueryDados(query);
            }
            catch (Exception)
            {

                throw;
            }

            return dados;
        }
        
        public DataTable ListarEstoquePorEscala(int idEscala)
        {
            DataTable dados = new DataTable();
            string query =
                    "SELECT DISTINCT " +
                    "tbProdutos.Descricao, " +
                    "tbProdutos.PrecoVenda, " +
                    "tbEstoqueEscala.QtdVenda, " +
                    "dbo.ItensVendidos(tbVendasPedido.Produto," + idEscala + ") AS Saida, " +
                    "(ISNULL(QtdVenda, 0) - ISNULL(dbo.ItensVendidos(tbVendasPedido.Produto," + idEscala +"),0)) AS Estoque " +
                    "FROM tbProdutos " +
                    "INNER JOIN tbEstoqueEscala ON tbProdutos.ID = tbEstoqueEscala.Produto " +
                    "LEFT JOIN tbVendasPedido ON tbProdutos.ID = tbVendasPedido.Produto " +
                    "WHERE Escala =" + idEscala + " " +
                    "ORDER BY 1;";

            //            "SELECT DISTINCT " +
            //"tbProdutos.Descricao, " +
            //"tbProdutos.PrecoVenda, " +
            //"tbEstoqueEscala.QtdVenda, " +
            //"(SELECT SUM(tbVendasPedido.Quantidade) FROM tbVendasPedido  INNER JOIN tbVendas ON tbVendas.ID = tbVendasPedido.Venda WHERE Produto = tbProdutos.ID AND tbVendas.Escala = " + idEscala + ") AS Saida, " +
            //"(IIF(ISNULL(QtdVenda), 0, QtdVenda) - IIF(ISNULL(Saida), 0, Saida)) AS Estoque " +
            //"FROM tbProdutos " +
            //"INNER JOIN tbEstoqueEscala ON tbProdutos.ID = tbEstoqueEscala.Produto " +
            //"LEFT JOIN tbVendasPedido ON tbProdutos.ID = tbVendasPedido.Produto " +
            //"WHERE Escala =" + idEscala + " " +
            //"ORDER BY 1;";

            try
            {
                dados = _banco.ExecutarQueryDados(query);
            }
            catch (Exception)
            {

                throw;
            }

            return dados;
        }

        public DataTable ListarEstoqueSalgadosPorEscala(int idEscala)
        {
            DataTable dados = new DataTable();
            string query =
                    "SELECT DISTINCT " +
                    "tbProdutos.Descricao, " +
                    "tbProdutos.PrecoVenda, " +
                    "tbEstoqueEscala.QtdVenda, " +
                    "dbo.ItensVendidos(tbVendasPedido.Produto," + idEscala + ") AS Saida, " +
                    "(ISNULL(QtdVenda, 0) - ISNULL(dbo.ItensVendidos(tbVendasPedido.Produto," + idEscala + "),0)) AS Estoque " +
                    "FROM tbProdutos " +
                    "INNER JOIN tbEstoqueEscala ON tbProdutos.ID = tbEstoqueEscala.Produto " +
                    "LEFT JOIN tbVendasPedido ON tbProdutos.ID = tbVendasPedido.Produto " +
                    "WHERE Escala =" + idEscala + " AND tbProdutos.Categoria=10 " +
                    "ORDER BY 1;";

            //            "SELECT DISTINCT " +
            //"tbProdutos.Descricao, " +
            //"tbProdutos.PrecoVenda, " +
            //"tbEstoqueEscala.QtdVenda, " +
            //"(SELECT SUM(tbVendasPedido.Quantidade) FROM tbVendasPedido  INNER JOIN tbVendas ON tbVendas.ID = tbVendasPedido.Venda WHERE Produto = tbProdutos.ID AND tbVendas.Escala = " + idEscala + ") AS Saida, " +
            //"(IIF(ISNULL(QtdVenda), 0, QtdVenda) - IIF(ISNULL(Saida), 0, Saida)) AS Estoque " +
            //"FROM tbProdutos " +
            //"INNER JOIN tbEstoqueEscala ON tbProdutos.ID = tbEstoqueEscala.Produto " +
            //"LEFT JOIN tbVendasPedido ON tbProdutos.ID = tbVendasPedido.Produto " +
            //"WHERE Escala =" + idEscala + " " +
            //"ORDER BY 1;";

            try
            {
                dados = _banco.ExecutarQueryDados(query);
            }
            catch (Exception)
            {

                throw;
            }

            return dados;
        }
        public DataTable PesquisarEstoque(string pesquisa)
        {
            DataTable dados = new DataTable();
            string query =
                    "SELECT DISTINCT A.ID, A.Descricao, A.PrecoVenda, " +
                    "A.EstoqueInicial, " +
                    "(SELECT SUM(tbCompras.Quantidade) FROM tbCompras WHERE Produto = A.ID) AS Entrada, " +
                    "(SELECT SUM(tbVendasPedido.Quantidade) FROM tbVendasPedido WHERE Produto = A.ID) AS Saida, " +
                    "(IIF(ISNULL(EstoqueInicial),0,EstoqueInicial) + IIF(ISNULL(Entrada),0,Entrada) - IIF(ISNULL(Saida),0,Saida)) AS Estoque " +
                    "FROM(tbProdutos AS A LEFT JOIN tbCompras AS B ON A.ID = B.Produto) LEFT JOIN tbVendasPedido AS C ON A.ID = C.Produto " +
                    "WHERE(((A.ProdutoVenda) = True)) " + " AND A.Descricao LIKE '" + pesquisa + "%' " +
                    "GROUP BY A.ID, A.Descricao, A.PrecoVenda, A.EstoqueInicial; ";

            try
            {
                dados = _banco.ExecutarQueryDados(query);
            }
            catch (Exception)
            {

                throw;
            }

            return dados;
        }

        public DataTable ListarVendas(int idEscala)
        {
            DataTable dados = new DataTable();
            string query =
            "SELECT tbVendas.ID, tbSocios.ID,  tbSocios.Nome, tbVendas.TipoPagamento, SUM(tbVendasPedido.Quantidade * tbVendasPedido.PrecoProduto) AS Total,(SELECT COUNT(*) FROM tbVendasPedido WHERE Venda=tbVendas.ID AND Retirado=0) AS PendenteRetirada " +
            "FROM tbSocios " +
            "INNER JOIN(tbEscalas " +
            "INNER JOIN (tbVendas " +
            "INNER JOIN tbVendasPedido " +
            "ON tbVendas.ID = tbVendasPedido.Venda) " +
            "ON tbEscalas.ID = tbVendas.Escala) " +
            "ON tbSocios.ID = tbVendas.Socio " +
            "WHERE tbEscalas.ID=" + idEscala + " " +
            "GROUP BY  tbVendas.ID, tbSocios.ID,  tbSocios.Nome, tbVendas.TipoPagamento " +
            "ORDER BY 6 desc,tbSocios.Nome ; ";

            try
            {
                dados = _banco.ExecutarQueryDados(query);
            }
            catch (Exception)
            {

                throw;
            }

            return dados;

        }

        public DataTable ListarVendasPesquisa(int idEscala, string pesquisa)
        {
            DataTable dados = new DataTable();
            string query =
            "SELECT tbVendas.ID, tbSocios.ID,  tbSocios.Nome, tbVendas.TipoPagamento, SUM(tbVendasPedido.Quantidade * tbVendasPedido.PrecoProduto) AS Total,(SELECT COUNT(*) FROM tbVendasPedido WHERE Venda=tbVendas.ID AND Retirado=0) AS PendenteRetirada " +
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

            try
            {
                dados = _banco.ExecutarQueryDados(query);
            }
            catch (Exception)
            {

                throw;
            }

            return dados;

        }


        public DataTable TrazerEscala(int idEscala)
        {
            DataTable dados = new DataTable();
            string query =
                //"SELECT tbEscalas.ID, tbEscalas.Descricao, tbEscalas.DataEscala, SUM((tbVendasPedido.PrecoProduto * tbVendasPedido.Quantidade)) AS Resumo, tbEscalas.Finalizada  " +
                //"FROM(tbEscalas " +
                //"LEFT JOIN tbVendas ON tbEscalas.ID = tbVendas.Escala) " +
                //"LEFT JOIN tbVendasPedido ON tbVendas.ID = tbVendasPedido.Venda " +
                //"WHERE tbEscalas.ID=" + idEscala + " " +
                //"GROUP BY  tbEscalas.ID, tbEscalas.Descricao, tbEscalas.DataEscala, tbEscalas.Finalizada ";

                "SELECT " +
                "tbEscalas.ID,  " +
                "tbEscalas.Descricao, " +
                "tbEscalas.DataEscala, " +
                "SUM((tbVendasPedido.PrecoProduto * tbVendasPedido.Quantidade)) AS Resumo, " +
                "tbEscalas.Finalizada, " +
                "TipoPagamento " +
                "FROM tbEscalas " +
                "LEFT JOIN tbVendas ON tbEscalas.ID = tbVendas.Escala " +
                "LEFT JOIN tbVendasPedido ON tbVendas.ID = tbVendasPedido.Venda " +
                "WHERE tbEscalas.ID = " + idEscala + " " +
                "GROUP BY  tbEscalas.ID, tbEscalas.Descricao, tbEscalas.DataEscala, TipoPagamento,tbEscalas.Finalizada ";







            try
            {
                dados = _banco.ExecutarQueryDados(query);
            }
            catch (Exception)
            {

                throw;
            }

            return dados;

        }

        public DataTable TrazerVenda(int idEscala, int idSocio)
        {
            DataTable dados = new DataTable();
            string query =
                "SELECT tbVendas.ID, tbVendas.TipoPagamento, SUM(tbVendasPedido.Quantidade * tbVendasPedido.PrecoProduto) AS TotalConsumido " +
                "FROM tbVendas " +
                "INNER JOIN tbVendasPedido ON tbVendasPedido.Venda=tbVendas.ID " +
                "WHERE Escala=" + idEscala + " AND Socio=" + idSocio + " " +
                "GROUP BY tbVendas.ID, tbVendas.TipoPagamento ;";
            try
            {
                dados = _banco.ExecutarQueryDados(query);

            }
            catch (Exception)
            {

                throw;
            }

            return dados;
        }

        public int AdicionarVenda(VendasDTO venda)
        {

            //OleDbCommand cmd = new OleDbCommand();
            SqlCommand cmd = new SqlCommand();


            cmd.CommandText =
                "INSERT INTO tbVendas" +
                    "(Escala,Socio,TipoPagamento) " +
                "VALUES" +
                    "(@idEscala,@idSocio,@tipoPagamento)";

            cmd.Parameters.AddWithValue("@idEscala", venda.IDEscala);
            cmd.Parameters.AddWithValue("@idSocio", venda.IDSocio);
            cmd.Parameters.AddWithValue("@tipoPagamento", venda.TipoPagamento);

            try
            {
                return _banco.ExecutarQueryComando(cmd);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AtualizarVenda(VendasDTO venda)
        {

            //OleDbCommand cmd = new OleDbCommand();
            SqlCommand cmd = new SqlCommand();


            cmd.CommandText =
                "UPDATE tbVendas " +
                "SET TipoPagamento=@tipoPagamento " +
                "WHERE ID=@id";

            cmd.Parameters.AddWithValue("@tipoPagamento", venda.TipoPagamento);
            cmd.Parameters.AddWithValue("@id", venda.ID);

            try
            {
                return _banco.ExecutarQueryComando(cmd);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public 

        //public DataTable PesquisarCompra(string pesquisa, string filtro)
        //{
        //    DataTable dados = new DataTable();
        //    string query =
        //            "SELECT  A.ID,A.DataCompra,B.Descricao, A.Quantidade, A.PrecoUnitario, A.CompradoPor, B.ID AS IDProduto, A.TipoEntrada, A.Observacao  " +
        //            "FROM tbCompras AS A INNER JOIN tbProdutos AS B ON B.ID = A.Produto " +
        //            "WHERE " + filtro + " LIKE '" + pesquisa + "%' " +
        //            "order by A.DataCompra Desc";

        //    try
        //    {
        //        dados = _banco.ExecutarQueryDados(query);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //    return dados;
        //}


        //public int AdicionarCompra(CompraDTO compra)
        //{

        //    OleDbCommand cmd = new OleDbCommand();

        //    cmd.CommandText =
        //        "INSERT INTO tbCompras" +
        //            "(Produto,Quantidade,PrecoUnitario,CompradoPor,DataCompra,TipoEntrada,Observacao) " +
        //        "VALUES" +
        //            "(@descricao,@quantidade,@precoUnitario,@compradoPor,@dataCompra,@tipoEntrada,@observacao)";

        //    cmd.Parameters.Add("@descricao", compra.IDProduto);
        //    cmd.Parameters.Add("@quantidade", compra.Quantidade);
        //    cmd.Parameters.Add("@precoUnitario", compra.PrecoUnitario);
        //    cmd.Parameters.Add("@compradoPor", compra.CompradoPor);
        //    cmd.Parameters.Add("@dataCompra", OleDbType.Date).Value = compra.DataCompra;
        //    cmd.Parameters.Add("@tipoEntrada", compra.TipoEntrada);
        //    cmd.Parameters.Add("@observacao", compra.Observacao);

        //    try
        //    {
        //        return _banco.ExecutarQueryComando(cmd);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        //public void AtualizarCompra(CompraDTO compra)
        //{
        //    OleDbCommand cmd = new OleDbCommand();

        //    cmd.CommandText =
        //            "UPDATE tbCompras SET " +
        //            "Produto=@produto," +
        //            "Quantidade=@quantidade," +
        //            "PrecoUnitario=@precoUnitario," +
        //            "CompradoPor=@compradoPor," +
        //            "DataCompra=@dataCompra, " +
        //            "TipoEntrada=@tipoEntrada, " +
        //            "Observacao=@observacao " +
        //            "WHERE ID=@idCompra;";

        //    cmd.Parameters.AddWithValue("@produto", compra.IDProduto);
        //    cmd.Parameters.AddWithValue("@quantidade", compra.Quantidade);
        //    cmd.Parameters.AddWithValue("@precoUnitario", OleDbType.Double).Value = compra.PrecoUnitario;
        //    cmd.Parameters.AddWithValue("@compradoPor", compra.CompradoPor);
        //    cmd.Parameters.AddWithValue("@dataCompra", OleDbType.Date).Value = compra.DataCompra;
        //    cmd.Parameters.AddWithValue("@tipoEntrada", compra.TipoEntrada);
        //    cmd.Parameters.AddWithValue("@observacao", compra.Observacao);
        //    cmd.Parameters.AddWithValue("@idCompra", compra.ID);

        //    //string query = "UPDATE tbCompras SET " +
        //    //    " Produto='" + compra.IDProduto +
        //    //    "', Quantidade=" + compra.Quantidade +
        //    //    ", PrecoUnitario='" + compra.PrecoUnitario +
        //    //    "', CompradoPor='" + compra.CompradoPor +
        //    //    "', DataCompra='" + compra.DataCompra +
        //    //    "' WHERE ID=" + compra.ID;
        //    //cmd.CommandText = query;
        //    try
        //    {
        //        _banco.ExecutarQueryComando(cmd);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        //public void ExcluirCompra(CompraDTO compra)
        //{
        //    OleDbCommand cmd = new OleDbCommand();

        //    cmd.CommandText =
        //        "DELETE FROM tbCompras WHERE ID=@id" +

        //    cmd.Parameters.Add("@id", compra.ID);


        //    //string query = "DELETE FROM tbCompras WHERE ID=" + compra.ID;

        //    try
        //    {
        //        _banco.ExecutarQueryComando(cmd);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}

