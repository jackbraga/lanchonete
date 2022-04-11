//using LanchoneteUDV.DataObject;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.OleDb;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LanchoneteUDV.Database
//{
//    public class ProdutosDAL
//    {
//        Configuration _banco = new Configuration();
//        public DataTable ListarProdutos()
//        {
//            DataTable dados = new DataTable();
//            string query = "SELECT A.ID,A.Descricao,B.ID AS IDCategoria, B.Descricao AS Categoria,PrecoCustoCaixa,QtdPorCaixa,PrecoCustoUnitario,PrecoVenda,EstoqueInicial,ProdutoVenda " +
//                "FROM tbProdutos A INNER JOIN tbCategorias B ON B.ID=A.Categoria " +
//                "order by A.Descricao";

//            try
//            {
//                dados = _banco.ExecutarQueryDados(query);
//            }
//            catch (Exception)
//            {

//                throw;
//            }

//            return dados;

//        }

//        public DataTable ListarProdutosParaVenda()
//        {
//            DataTable dados = new DataTable();
//            string query = "SELECT ID,Descricao,PrecoVenda " +
//                "FROM tbProdutos " +
//                "WHERE ProdutoVenda=true " +
//                "order by Descricao;";

//            try
//            {
//                dados = _banco.ExecutarQueryDados(query);
//            }
//            catch (Exception)
//            {

//                throw;
//            }

//            return dados;

//        }

//        public DataTable ListarProdutosParaVendaPorEscala(int idEscala)
//        {
//            DataTable dados = new DataTable();
//            string query = "SELECT A.ID,A.Descricao,A.PrecoVenda " +
//                           "FROM tbProdutos AS A " +
//                           "INNER JOIN tbEstoqueEscala AS B ON B.Produto=A.ID " +
//                           "WHERE A.ProdutoVenda=1 AND B.Escala=" + idEscala + " " +
//                           "order by Descricao;";

//            try
//            {
//                dados = _banco.ExecutarQueryDados(query);
//            }
//            catch (Exception)
//            {

//                throw;
//            }

//            return dados;

//        }

//        public DataTable PesquisarProduto(string pesquisa)
//        {
//            DataTable dados = new DataTable();
//            string query = "SELECT A.ID,A.Descricao,B.ID AS IDCategoria, B.Descricao AS Categoria,PrecoCustoCaixa,QtdPorCaixa,PrecoCustoUnitario,PrecoVenda,EstoqueInicial,ProdutoVenda " +
//               "FROM tbProdutos A INNER JOIN tbCategorias B ON B.ID=A.Categoria  WHERE A.Descricao LIKE '" + pesquisa + "%' " +
//               "order by A.Descricao";

//            try
//            {
//                dados = _banco.ExecutarQueryDados(query);
//            }
//            catch (Exception)
//            {

//                throw;
//            }

//            return dados;
//        }

//        public int AdicionarProduto(ProdutoDTO produto)
//        {

//            //OleDbCommand cmd = new OleDbCommand();
//            SqlCommand cmd = new SqlCommand();

//            cmd.CommandText =
//                "INSERT INTO tbProdutos" +
//                    "(Descricao,Categoria,PrecoCustoCaixa,QtdPorCaixa,PrecoCustoUnitario,PrecoVenda,EstoqueInicial,ProdutoVenda) " +
//                    "VALUES(@descricao,@categoria, @precoCustoCaixa, @qtdPorCaixa, @precoCustoUnitario, @precoVenda, @estoqueInicial,@produtoVenda)";

//            cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
//            cmd.Parameters.AddWithValue("@categoria", produto.IDCategoria);
//            cmd.Parameters.AddWithValue("@precoCustoCaixa", produto.PrecoCustoCaixa);
//            cmd.Parameters.AddWithValue("@qtdPorCaixa", produto.QuantidadePorCaixa);
//            cmd.Parameters.AddWithValue("@precoCustoUnitario", produto.PrecoCustoUnitario);
//            cmd.Parameters.AddWithValue("@precoVenda", produto.PrecoVenda);
//            cmd.Parameters.AddWithValue("@estoqueInicial", produto.EstoqueInicial);
//            cmd.Parameters.AddWithValue("@produtoVenda", produto.ProdutoVenda);
 
//            try
//            {
//                return _banco.ExecutarQueryComando(cmd);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }
//        public void AtualizarProduto(ProdutoDTO produto)
//        {
//            //OleDbCommand cmd = new OleDbCommand();
//            SqlCommand cmd = new SqlCommand();

//            cmd.CommandText =
//                "UPDATE tbProdutos SET Descricao=@descricao,Categoria=@categoria,PrecoCustoCaixa=@precoCustoCaixa," +
//                "QtdPorCaixa=@qtdPorCaixa,PrecoCustoUnitario=@precoCustoUnitario,PrecoVenda=@precoVenda," +
//                "EstoqueInicial=@estoqueInicial,ProdutoVenda=@produtoVenda WHERE ID=@id";

//            cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
//            cmd.Parameters.AddWithValue("@categoria", produto.IDCategoria);
//            cmd.Parameters.AddWithValue("@precoCustoCaixa", produto.PrecoCustoCaixa);
//            cmd.Parameters.AddWithValue("@qtdPorCaixa", produto.QuantidadePorCaixa);
//            cmd.Parameters.AddWithValue("@precoCustoUnitario", produto.PrecoCustoUnitario);
//            cmd.Parameters.AddWithValue("@precoVenda", produto.PrecoVenda);
//            cmd.Parameters.AddWithValue("@estoqueInicial", produto.EstoqueInicial);
//            cmd.Parameters.AddWithValue("@produtoVenda", produto.ProdutoVenda);
//            cmd.Parameters.AddWithValue("@id", produto.ID);

//            try
//            {
//                _banco.ExecutarQueryComando(cmd);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }
//        public void ExcluirProduto(ProdutoDTO produto)
//        {
//            //OleDbCommand cmd = new OleDbCommand();
//            SqlCommand cmd = new SqlCommand();

//            cmd.CommandText = "DELETE FROM tbProdutos WHERE ID=@id";
//            cmd.Parameters.Add("@id");

//            //string query = "DELETE FROM tbProdutos WHERE ID=" + produto.ID;

//            try
//            {
//                _banco.ExecutarQueryComando(cmd);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//    }
//}
