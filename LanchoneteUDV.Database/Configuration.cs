using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace LanchoneteUDV.Database
{
    public class Configuration
    {
        //string dadosConexao = "Provider=Microsoft.ace.oledb.12.0; data source=DatabaseLanchonete.ACCDB";
        string dadosConexao = "Data Source=.\\Sqlexpress;Initial Catalog=LANCHONETE;Integrated Security=True";
        //OleDbConnection _conexao = new OleDbConnection();        
        //OleDbDataAdapter adaptador = new OleDbDataAdapter();
        SqlConnection _conexao;
        SqlDataAdapter adaptador =new SqlDataAdapter();




        public void AbrirConexao()
        {
            _conexao = new SqlConnection(dadosConexao);
            _conexao.Open();
        }

        public void EncerrarConexao()
        {
            _conexao.Dispose();
            _conexao.Close();
        }

        public DataTable ExecutarQueryDados(string query)
        {
            DataTable dados = new DataTable();
            SqlCommand cmd = new SqlCommand();
            
            try
            {
                AbrirConexao();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = _conexao;
                cmd.CommandText = query;
                adaptador.SelectCommand = cmd;
                adaptador.Fill(dados);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                EncerrarConexao();
            }
          
           
            return dados;
        }

        public int ExecutarQueryComando(SqlCommand cmd)
        {
            int id=0;
       
            try
            {
                AbrirConexao();
                cmd.Connection = _conexao;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT @@IDENTITY;";
                if (cmd.ExecuteScalar() != DBNull.Value)
                {
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                }
           

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                EncerrarConexao();
            }
            return id;
        }



    }
}