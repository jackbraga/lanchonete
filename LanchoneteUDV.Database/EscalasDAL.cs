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
    public class EscalasDAL
    {
        Configuration _banco = new Configuration();
        public DataTable ListarEscalas()
        {
            DataTable dados = new DataTable();
            string query =
                "SELECT tbEscalas.ID, tbEscalas.DataEscala, tbEscalas.Descricao, tbEscalas.TipoSessao, tbEscalas.Observacao, tbEscalas.Finalizada, tbEscalas.RepasseTesouraria, SUM((tbVendasPedido.PrecoProduto * tbVendasPedido.Quantidade)) AS ResumoVendas " +
                "FROM(tbEscalas " +
                "LEFT JOIN tbVendas ON tbEscalas.ID = tbVendas.Escala) " +
                "LEFT JOIN tbVendasPedido ON tbVendas.ID = tbVendasPedido.Venda " +
                "GROUP BY tbEscalas.ID, tbEscalas.DataEscala, tbEscalas.Descricao, tbEscalas.TipoSessao, tbEscalas.Observacao, tbEscalas.Finalizada, tbEscalas.RepasseTesouraria " +
                "ORDER BY tbEscalas.DataEscala DESC; ";

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

        public DataTable PesquisarEscala(string pesquisa)
        {
            DataTable dados = new DataTable();
            string query =
                    "SELECT  A.ID,A.DataEscala, A.Descricao, A.Finalizada, A.Observacao, A.TipoSessao " +
                    "FROM tbEscalas A " +
                    "WHERE A.Descricao " + " LIKE '%" + pesquisa + "%' " +
                    "order by A.DataEscala Desc";

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
        public int AdicionarEscala(EscalaDTO escala)
        {

            //OleDbCommand cmd = new OleDbCommand();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText =
                "INSERT INTO tbEscalas" +
                    "(Descricao,DataEscala,Finalizada,Observacao,TipoSessao) " +
                "VALUES" +
                    "(@descricao,@dataEscala,@finalizada,@observacao,@tipoSessao)";

            cmd.Parameters.AddWithValue("@descricao", escala.Descricao);
            cmd.Parameters.AddWithValue("@dataEscala", OleDbType.Date).Value = escala.DataEscala;
            cmd.Parameters.AddWithValue("@finalizada", escala.Finalizada);
            cmd.Parameters.AddWithValue("@observacao", escala.Observacao);
            cmd.Parameters.AddWithValue("@tipoSessao", escala.TipoSessao);

            try
            {
                return _banco.ExecutarQueryComando(cmd);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AtualizarEscala(EscalaDTO escala)
        {
            //OleDbCommand cmd = new OleDbCommand();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText =
                    "UPDATE tbEscalas SET " +
                    "Descricao=@descricao," +
                    "DataEscala=@dataEscala," +
                    "Finalizada=@finalizada," +
                    "Observacao=@observacao," +
                    "TipoSessao=@tipoSessao " +
                    "WHERE ID=@id";

            cmd.Parameters.AddWithValue("@descricao", escala.Descricao);
            cmd.Parameters.AddWithValue("@dataEscala", OleDbType.Date).Value = escala.DataEscala;
            cmd.Parameters.AddWithValue("@finalizada", escala.Finalizada);
            cmd.Parameters.AddWithValue("@observacao", escala.Observacao);
            cmd.Parameters.AddWithValue("@tipoSessao", escala.TipoSessao);
            cmd.Parameters.AddWithValue("@id", escala.ID);

            try
            {
                _banco.ExecutarQueryComando(cmd);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ExcluirEscala(EscalaDTO escala)
        {
            //OleDbCommand cmd = new OleDbCommand();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText =
                "DELETE FROM tbEscalas WHERE ID=@id";

            cmd.Parameters.AddWithValue("@id", escala.ID);

            try
            {
                _banco.ExecutarQueryComando(cmd);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void FinalizarEscala(int idEscala)
        {
            //OleDbCommand cmd = new OleDbCommand();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText =
                    "UPDATE tbEscalas SET " +
                    "Finalizada=1 " +
                    "WHERE ID=@id";
            cmd.Parameters.AddWithValue("@id", idEscala);

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
