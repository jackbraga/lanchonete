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
//    public class VendasPedidoDAL
//    {
//        Configuration _banco = new Configuration();

//        public DataTable ListarVendasPedido(int idVenda)
//        {
//            DataTable dados = new DataTable();
//            string query =
//            "SELECT tbVendasPedido.ID, tbProdutos.Descricao,tbVendasPedido.PrecoProduto ,tbVendasPedido.Quantidade, " +
//            "(tbVendasPedido.Quantidade * tbVendasPedido.PrecoProduto) AS Total, tbVendasPedido.Observacao, tbVendasPedido.Retirado, tbVendasPedido.DataHoraPedido " +
//            "FROM tbProdutos INNER JOIN tbVendasPedido ON tbProdutos.ID = tbVendasPedido.Produto " +
//            "WHERE tbVendasPedido.Venda=" + idVenda + " " +
//            "ORDER BY tbVendasPedido.Retirado desc, tbProdutos.Descricao;";

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

//        public DataTable ListarTodosVendasPedido(int idEscala)
//        {
//            DataTable dados = new DataTable();
//            string query =
//                        "SELECT tbVendasPedido.ID,tbVendasPedido.DataHoraPedido, tbSocios.Nome, tbProdutos.Descricao, " +
//                        "tbVendasPedido.Quantidade, tbVendasPedido.Retirado, tbVendasPedido.Observacao " +
//                        "FROM tbProdutos " +
//                        "INNER JOIN(tbSocios " +
//                        "INNER JOIN((tbEscalas " +
//                        "INNER JOIN tbVendas ON tbEscalas.ID = tbVendas.Escala) " +
//                        "INNER JOIN tbVendasPedido ON tbVendas.ID = tbVendasPedido.Venda) ON tbSocios.ID = tbVendas.Socio) ON tbProdutos.ID = tbVendasPedido.Produto " +
//                        "WHERE tbEscalas.ID =" + idEscala + " " +
//                        "ORDER BY tbVendasPedido.Retirado asc, tbVendasPedido.DataHoraPedido; ";

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



//        public int AdicionarVendasPedido(VendasPedidoDTO vendaPedido)
//        {
//            //OleDbCommand cmd = new OleDbCommand();
//            SqlCommand cmd = new SqlCommand();


//            cmd.CommandText =
//                "INSERT INTO tbVendasPedido" +
//                    "(Venda,Produto,Quantidade,PrecoProduto,Observacao,Retirado,DataHoraPedido) " +
//                "VALUES" +
//                    "(@idVenda,@idProduto,@quantidade,@precoProduto,@observacao,@retirado,@dataHoraPedido)";

//            cmd.Parameters.AddWithValue("@idVenda", vendaPedido.IDVenda);
//            cmd.Parameters.AddWithValue("@idProduto", vendaPedido.IDProduto);
//            cmd.Parameters.AddWithValue("@quantidade", vendaPedido.Quantidade);
//            cmd.Parameters.AddWithValue("@precoProduto", OleDbType.Double).Value = vendaPedido.PrecoProduto;
//            cmd.Parameters.AddWithValue("@observacao", vendaPedido.Observacao);
//            cmd.Parameters.AddWithValue("@retirado", vendaPedido.Retirado);
//            cmd.Parameters.AddWithValue("@dataHoraPedido", OleDbType.Date).Value = vendaPedido.DataHoraPedidoItem;

//            try
//            {
//                return _banco.ExecutarQueryComando(cmd);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        public void RegistrarRetirada(int idVendaPedido)
//        {
//            //OleDbCommand cmd = new OleDbCommand();
//            SqlCommand cmd = new SqlCommand();


//            cmd.CommandText =
//                "UPDATE tbVendasPedido " +
//                "SET Retirado=1 " +
//                "WHERE ID=@id;";
                    
//            cmd.Parameters.AddWithValue("@id", idVendaPedido);

//            try
//            {
//                 _banco.ExecutarQueryComando(cmd);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        public void DesmarcarRetirada(int idVendaPedido)
//        {
//            //OleDbCommand cmd = new OleDbCommand();
//            SqlCommand cmd = new SqlCommand();


//            cmd.CommandText =
//                "UPDATE tbVendasPedido " +
//                "SET Retirado=0 " +
//                "WHERE ID=@id;";

//            cmd.Parameters.AddWithValue("@id", idVendaPedido);

//            try
//            {
//                _banco.ExecutarQueryComando(cmd);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        public void ExcluirItemPedido(int idVendaPedido)
//        {
//            //OleDbCommand cmd = new OleDbCommand();
//            SqlCommand cmd = new SqlCommand();


//            cmd.CommandText =
//                "DELETE FROM tbVendasPedido " +
//                "WHERE ID=@id;";

//            cmd.Parameters.AddWithValue("@id", idVendaPedido);

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
