using LanchoneteUDV.DataObject;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace LanchoneteUDV.Database
{
    public class SociosDAL
    {
        Configuration _banco = new Configuration();
        public SociosDAL()
        {

        }

        public DataTable ListarSocios()
        {
            DataTable dados = new DataTable();
            string query = "SELECT A.ID,A.Nome, A.Email, ISNULL(A.ResponsavelFinanceiro,A.ID) AS ResponsavelFinanceiro,ISNULL(B.Nome,A.NOME) AS NomeResponsavel " +
                           "FROM tbSocios AS A " +
                           "LEFT JOIN   tbSocios AS B ON B.ID = A.ResponsavelFinanceiro " +
                           "WHERE A.TipoSocio = 1 order by A.Nome ";

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
        public DataTable ListarSociosVenda()
        {
            DataTable dados = new DataTable();
            string query =  "SELECT ID,Nome, Email " +
                            "FROM tbSocios " +
                            "WHERE TipoSocio = 1 " +
                            "UNION ALL " +
                            "SELECT ID, Nome, Email " +
                            "FROM tbSocios " +
                            "WHERE TipoSocio = 2 AND DataCriacao>= DATEADD(MONTH, -1, GETDATE()) " +
                            "ORDER BY 2";

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


        public DataTable ListarSociosVisitantes()
        {
            DataTable dados = new DataTable();
            string query = "SELECT ID,Nome, Email FROM tbSocios WHERE TipoSocio=2 order by Nome";

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




        public DataTable PesquisarSocio(string pesquisa)
        {
            DataTable dados = new DataTable();
            string query = "SELECT ID,Nome, Email FROM tbSocios WHERE Nome Like '" + pesquisa + "%'order by Nome";

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

        public int AdicionarSocio(SocioDTO socio)
        {
            //OleDbCommand cmd = new OleDbCommand();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "" +
                "INSERT INTO tbSocios(Nome,Email,TipoSocio,DataCriacao) " +
                "VALUES(@nome,@email,@tipoSocio,GETDATE());";
            cmd.Parameters.AddWithValue("@nome", socio.Nome);
            cmd.Parameters.AddWithValue("@email", socio.Email);
            cmd.Parameters.AddWithValue("@tipoSocio", socio.TipoSocio);

            //string query = "INSERT INTO tbSocios(Nome) VALUES('" + socio.Nome.Trim() + "'); " +

            try
            {
                return _banco.ExecutarQueryComando(cmd);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AtualizarSocio(SocioDTO socio)
        {
            //OleDbCommand cmd = new OleDbCommand();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "" +
                "UPDATE tbSocios SET Nome=@nome, Email=@email, TipoSocio=@tipoSocio, ResponsavelFinanceiro=@financeiro WHERE ID=@idSocio";

            cmd.Parameters.AddWithValue("@nome", socio.Nome);
            cmd.Parameters.AddWithValue("@email", socio.Email);
            cmd.Parameters.AddWithValue("@tipoSocio", socio.TipoSocio);
            cmd.Parameters.AddWithValue("@financeiro", socio.ResponsavelFinanceiro);
            cmd.Parameters.AddWithValue("@idSocio", socio.ID);

            //string query = "UPDATE tbSocios SET Nome='" + socio.Nome.Trim() + "' WHERE ID=" + socio.ID;

            try
            {
                _banco.ExecutarQueryComando(cmd);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ExcluirSocio(SocioDTO socio)
        {
            //OleDbCommand cmd = new OleDbCommand();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "" +
                "DELETE FROM tbSocios WHERE ID=@id";

            cmd.Parameters.AddWithValue("@id", socio.ID);

            //string query = "DELETE FROM tbSocios WHERE ID=" + socio.ID;

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
