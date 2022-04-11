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
//    public class EstoqueEscalaDAL
//    {
//        Configuration _banco = new Configuration();

//        public DataTable ListarEstoqueEscala(int idEscala)
//        {
//            DataTable dados = new DataTable();
//            string query = "SELECT B.ID, B.Produto,A.Descricao, B.QtdVenda, B.Observacao " +
//                           "FROM tbProdutos AS A " +
//                           "INNER JOIN tbEstoqueEscala AS B ON A.ID = B.Produto " +
//                           "WHERE B.Escala=" + idEscala + " " +
//                           "ORDER BY A.Descricao; ";

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

//        public void ExcluirEstoqueEscala(EstoqueEscalaDTO estoqueEscala)
//        {
//            //OleDbCommand cmd = new OleDbCommand();
//            SqlCommand cmd = new SqlCommand();

//            cmd.CommandText =
//                "DELETE FROM tbEstoqueEscala WHERE ID=@id";

//            cmd.Parameters.AddWithValue("@id", estoqueEscala.ID);

//            try
//            {
//                _banco.ExecutarQueryComando(cmd);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        public int AdicionarEstoqueEscala(EstoqueEscalaDTO estoque)
//        {

//            //OleDbCommand cmd = new OleDbCommand();
//            SqlCommand cmd = new SqlCommand();

//            cmd.CommandText =
//                "INSERT INTO tbEstoqueEscala" +
//                    "(Escala,Produto,QtdVenda,Observacao) " +
//                "VALUES" +
//                    "(@escala,@produto,@qtdVenda,@observacao)";

//            cmd.Parameters.AddWithValue("@escala", estoque.IDEscala);
//            cmd.Parameters.AddWithValue("@produto", estoque.IDProduto);
//            cmd.Parameters.AddWithValue("@qtdVenda", estoque.QtdVenda);         
//            cmd.Parameters.AddWithValue("@observacao",  estoque.Observacao);


//            try
//            {
//                return _banco.ExecutarQueryComando(cmd);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        public void AtualizarEstoqueEscala(EstoqueEscalaDTO estoque)
//        {
//            //OleDbCommand cmd = new OleDbCommand();
//            SqlCommand cmd = new SqlCommand();

//            cmd.CommandText =
//                    "UPDATE tbEstoqueEscala SET " +
                   
//                    "Produto=@produto," +
//                    "QtdVenda=@qtdvenda," +
//                    "Observacao=@observacao " +
//                    "WHERE ID=@idEstoqueEscala;";

//            cmd.Parameters.AddWithValue("@produto", estoque.IDProduto);
//            cmd.Parameters.AddWithValue("@qtdvenda", estoque.QtdVenda);
//            cmd.Parameters.AddWithValue("@observacao", estoque.Observacao);

//            cmd.Parameters.AddWithValue("@idEstoqueEscala", estoque.ID);

//            try
//            {
//                _banco.ExecutarQueryComando(cmd);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        public int CompletarEstoqueEscala(int idEscala)
//        {

//            //OleDbCommand cmd = new OleDbCommand();
//            SqlCommand cmd = new SqlCommand();

//            cmd.CommandText =
//            "INSERT INTO tbEstoqueEscala(Escala, Produto, QtdVenda, Observacao) " +
//            "SELECT DISTINCT " +
//            "@escala AS ESCALA, " +
//            "A.ID, " +
//            "(ISNULL(EstoqueInicial, 0) + ISNULL((SELECT SUM(tbCompras.Quantidade) FROM tbCompras WHERE Produto = A.ID), 0) - ISNULL((SELECT SUM(tbVendasPedido.Quantidade) FROM tbVendasPedido WHERE Produto = A.ID),0)) AS Estoque, " +
//            "'CARGA COMPLETA' AS Observacao " +
//            "FROM tbProdutos AS A " +
//            "LEFT JOIN tbCompras AS B ON A.ID = B.Produto " +
//            "LEFT JOIN tbVendasPedido AS C ON A.ID = C.Produto " +
//            "WHERE A.ProdutoVenda = 1  and " +
//            "(ISNULL(EstoqueInicial, 0) + ISNULL((SELECT SUM(tbCompras.Quantidade) FROM tbCompras WHERE Produto = A.ID), 0) - ISNULL((SELECT SUM(tbVendasPedido.Quantidade) FROM tbVendasPedido WHERE Produto = A.ID),0)) > 0 " +
//            "GROUP BY A.ID, A.Descricao, A.PrecoVenda, A.EstoqueInicial ";
//            cmd.Parameters.AddWithValue("@escala", idEscala);



//            try
//            {
//                return _banco.ExecutarQueryComando(cmd);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

        

//    }
//}
