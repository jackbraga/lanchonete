using LanchoneteUDV.DataObject;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace LanchoneteUDV.Database
{
    public class CategoriasDAL
    {
        Configuration _banco = new Configuration();
        public CategoriasDAL()
        {

        }

        public DataTable ListarCategorias()
        {
            DataTable dados = new DataTable();
            string query = "SELECT ID,Descricao FROM tbCategorias order by Descricao";

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


        public DataTable PesquisarCategoria(string pesquisa)
        {
            DataTable dados = new DataTable();
            string query = "SELECT ID,Descricao FROM tbCategorias WHERE Descricao Like '" + pesquisa +"%'order by Descricao";

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

        public int AdicionarCategoria(CategoriaDTO categoria)
        {
            //OleDbCommand cmd = new OleDbCommand();
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText =
                "INSERT INTO tbCategorias " +
                "(Descricao)" +
                    "VALUES(@descricao)";

            cmd.Parameters.AddWithValue("@descricao", categoria.Descricao);

            //string query = "INSERT INTO tbCategorias(Descricao) VALUES('" + categoria.Descricao.Trim() + "')";

            try
            {
                return _banco.ExecutarQueryComando(cmd);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AtualizarCategoria(CategoriaDTO categoria)
        {
            //OleDbCommand cmd = new OleDbCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                 "UPDATE tbCategorias SET Descricao=@descricao WHERE ID=@id";

            cmd.Parameters.AddWithValue("@descricao", categoria.Descricao);
            cmd.Parameters.AddWithValue("@id", categoria.ID);


            //string query = "UPDATE tbCategorias SET Descricao='" + categoria.Descricao.Trim() + "' WHERE ID=" + categoria.ID;

            try
            {
                _banco.ExecutarQueryComando(cmd);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ExcluirCategoria(CategoriaDTO categoria)
        {
            //OleDbCommand cmd = new OleDbCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM tbCategorias WHERE ID=@id";
            //string query = "DELETE FROM tbCategorias WHERE ID=@id
            cmd.Parameters.AddWithValue("@id", categoria.ID);


            try
            {
                _banco.ExecutarQueryComando(cmd);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}

