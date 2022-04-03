using LanchoneteUDV.DataObject;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Database
{
    public class LoggingDAL
    {

        Configuration _banco = new Configuration();

        public LoggingDAL()
        {

        }
        public void AdicionarLog(LoggingDTO log)
        
        {
            //OleDbCommand cmd = new OleDbCommand();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText =
                "INSERT INTO tbLog" +
                    "(Usuario, Formulario, Descricao, Acao,DataHora, IDTabela,Tabela) " +
                "VALUES" +
                    "(@usuario,@formulario,@descricao,@acao,@dataHora,@idTabela,@tabela);";


            cmd.Parameters.AddWithValue("@usuario", log.IDUsuario);
            cmd.Parameters.AddWithValue("@formulario", log.Formulario);
            cmd.Parameters.AddWithValue("@descricao", log.Log);
            cmd.Parameters.AddWithValue("@acao", log.Acao);
            cmd.Parameters.AddWithValue("@dataHora", OleDbType.Date).Value = log.DataHora;
            cmd.Parameters.AddWithValue("@idTabela", log.IDTabela);
            cmd.Parameters.AddWithValue("@tabela", log.NomeTabela);


            //string query =
            //    "INSERT INTO tbLog(Usuario, Formulario, Descricao, Acao,DataHora) " +
            //    "VALUES(" + log.IDUsuario + ",'" + log.Formulario + "','" + log.Log + "','" + log.Acao +"','" +log.DataHora + "')";

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
