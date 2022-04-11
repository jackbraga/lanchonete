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
//    public class ComprasDAL
//    {
//        Configuration _banco = new Configuration();

//        public DataTable ListarProdutos()
//        {
//            DataTable dados = new DataTable();

//            string query = "SELECT A.ID,A.Descricao " +
//                "FROM tbProdutos A " +
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

//        public DataTable ListarCompras()
//        {
//            DataTable dados = new DataTable();
//            string query =
//                    "SELECT  A.ID,A.DataCompra,B.Descricao, A.Quantidade, A.PrecoUnitario, A.CompradoPor, B.ID AS IDProduto, A.TipoEntrada, A.Observacao " +
//                    "FROM tbCompras AS A INNER JOIN tbProdutos AS B ON B.ID = A.Produto " +
//                "order by A.DataCompra Desc";

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

//        public DataTable PesquisarCompra(string pesquisa, string filtro)
//        {
//            DataTable dados = new DataTable();
//            string query =
//                    "SELECT  A.ID,A.DataCompra,B.Descricao, A.Quantidade, A.PrecoUnitario, A.CompradoPor, B.ID AS IDProduto, A.TipoEntrada, A.Observacao  " +
//                    "FROM tbCompras AS A INNER JOIN tbProdutos AS B ON B.ID = A.Produto " +
//                    "WHERE " + filtro + " LIKE '" + pesquisa + "%' " +
//                    "order by A.DataCompra Desc";

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


//        public int AdicionarCompra(CompraDTO compra)
//        {

//            //OleDbCommand cmd = new OleDbCommand();
//            SqlCommand cmd = new SqlCommand();

//            cmd.CommandText =
//                "INSERT INTO tbCompras" +
//                    "(Produto,Quantidade,PrecoUnitario,CompradoPor,DataCompra,TipoEntrada,Observacao) " +
//                "VALUES" +
//                    "(@descricao,@quantidade,@precoUnitario,@compradoPor,@dataCompra,@tipoEntrada,@observacao)";

//            cmd.Parameters.AddWithValue("@descricao", compra.IDProduto);
//            cmd.Parameters.AddWithValue("@quantidade", compra.Quantidade);
//            cmd.Parameters.AddWithValue("@precoUnitario", compra.PrecoUnitario);
//            cmd.Parameters.AddWithValue("@compradoPor", compra.CompradoPor);
//            cmd.Parameters.AddWithValue("@dataCompra", OleDbType.Date).Value = compra.DataCompra;
//            cmd.Parameters.AddWithValue("@tipoEntrada", compra.TipoEntrada);
//            cmd.Parameters.AddWithValue("@observacao", compra.Observacao);

//            try
//            {
//                return _banco.ExecutarQueryComando(cmd);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        public void AtualizarCompra(CompraDTO compra)
//        {
//            //OleDbCommand cmd = new OleDbCommand();
//            SqlCommand cmd = new SqlCommand();

//            cmd.CommandText =
//                    "UPDATE tbCompras SET " +
//                    "Produto=@produto," +
//                    "Quantidade=@quantidade," +
//                    "PrecoUnitario=@precoUnitario," +
//                    "CompradoPor=@compradoPor," +
//                    "DataCompra=@dataCompra, " +
//                    "TipoEntrada=@tipoEntrada, " +
//                    "Observacao=@observacao " +
//                    "WHERE ID=@idCompra;";
       
//            cmd.Parameters.AddWithValue("@produto", compra.IDProduto);
//            cmd.Parameters.AddWithValue("@quantidade", compra.Quantidade);
//            cmd.Parameters.AddWithValue("@precoUnitario", OleDbType.Double).Value = compra.PrecoUnitario;
//            cmd.Parameters.AddWithValue("@compradoPor", compra.CompradoPor);
//            cmd.Parameters.AddWithValue("@dataCompra", OleDbType.Date).Value = compra.DataCompra;
//            cmd.Parameters.AddWithValue("@tipoEntrada", compra.TipoEntrada);
//            cmd.Parameters.AddWithValue("@observacao", compra.Observacao);
//            cmd.Parameters.AddWithValue("@idCompra", compra.ID);

//            try
//            {
//                _banco.ExecutarQueryComando(cmd);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        public void ExcluirCompra(CompraDTO compra)
//        {
//            //OleDbCommand cmd = new OleDbCommand();
//            SqlCommand cmd = new SqlCommand();

//            cmd.CommandText =
//                "DELETE FROM tbCompras WHERE ID=@id";

//            cmd.Parameters.AddWithValue("@id", compra.ID);


//            //string query = "DELETE FROM tbCompras WHERE ID=" + compra.ID;

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
