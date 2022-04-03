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
    public class FinanceiroDAL
    {
        Configuration _banco = new Configuration();
        public DataTable ListarItensRepasseFinanceiro(int idEscala, int idSocio)
        {
            DataTable dados = new DataTable();

            string query = "SELECT A.DataEscala,A.Descricao as Escala, C.Descricao as Produto, E.PrecoProduto, B.Nome, SUM(E.Quantidade) AS Quantidade " +
                            "FROM tbEscalas AS A " +
                            "INNER JOIN(tbSocios AS B " +
                            "INNER JOIN (tbProdutos AS C " +
                            "INNER JOIN (tbVendas AS D " +
                            "INNER JOIN tbVendasPedido AS E ON D.ID = E.Venda) ON C.ID = E.Produto) ON B.ID = D.Socio) ON A.ID = D.Escala " +
                            "WHERE A.ID =" + idEscala + " AND B.ID = " + idSocio + " " +
                            "GROUP BY A.DataEscala,A.Descricao, C.Descricao, E.PrecoProduto, B.Nome ;";

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

        public DataTable ListarVendasRepasse(int idEscala)
        {
            DataTable dados = new DataTable();
            string query =
            "SELECT tbVendas.ID, tbSocios.ID,  tbSocios.Nome, tbVendas.TipoPagamento, SUM(tbVendasPedido.Quantidade * tbVendasPedido.PrecoProduto) AS Total, ISNULL(tbVendas.EmailDisparado,0) AS EmailDisparado, tbSocios.Email  " +
            "FROM tbSocios " +
            "INNER JOIN(tbEscalas " +
            "INNER JOIN (tbVendas " +
            "INNER JOIN tbVendasPedido " +
            "ON tbVendas.ID = tbVendasPedido.Venda) " +
            "ON tbEscalas.ID = tbVendas.Escala) " +
            "ON tbSocios.ID = tbVendas.Socio " +
            "WHERE tbEscalas.ID=" + idEscala + " " +
            "AND tbVendas.TipoPagamento='BOLETO' " +
            "GROUP BY  tbVendas.ID, tbSocios.ID,  tbSocios.Nome, tbVendas.TipoPagamento, ISNULL(tbVendas.EmailDisparado,0), tbSocios.Email " +
            "ORDER BY tbSocios.Nome ; ";

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

        public void AtualizaEmailDisparado(int idVenda)
        {
            //OleDbCommand cmd = new OleDbCommand();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText =
                "UPDATE tbVendas " +
                "SET EmailDisparado=1 " +
                "WHERE ID=@id";

            cmd.Parameters.AddWithValue("@id", idVenda);

            try
            {
                _banco.ExecutarQueryComando(cmd);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public int AdicionarEventoCaixa(CaixaDTO caixa)
        {
            //OleDbCommand cmd = new OleDbCommand();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText =
                "INSERT INTO tbCaixa(DataEvento, TipoEvento,CategoriaLancamento,Valor,Observacao) " +
                "VALUES(@data,@tipoEvento,@categoria,@valor,@observacao) ";


            cmd.Parameters.AddWithValue("@data", OleDbType.Date).Value = caixa.DataEvento;
            cmd.Parameters.AddWithValue("@tipoEvento", caixa.TipoEvento);
            cmd.Parameters.AddWithValue("@categoria", caixa.Categoria);
            cmd.Parameters.AddWithValue("@valor", caixa.Valor);
            cmd.Parameters.AddWithValue("@observacao", caixa.Observacao);

            try
            {
                return _banco.ExecutarQueryComando(cmd);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public DataTable ListarCaixa()
        {
            DataTable dados = new DataTable();
            string query =
            "SELECT A.ID, A.DataEvento, A.TipoEvento, A.Valor,B.Descricao, A.Observacao " +
            "FROM tbCaixa AS A " +
            "INNER JOIN tbCategoriaLancamento AS B ON B.ID=A.CAtegoriaLancamento " +
            "ORDER BY 2 desc; ";


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

        public DataTable ListarCategoriaLancamento()
        {
            DataTable dados = new DataTable();
            string query =
            "SELECT A.ID, A.Descricao " +
            "FROM tbCategoriaLancamento AS A ;";

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

        public DataTable ListarResumo()
        {
            DataTable dados = new DataTable();
            string query =
                            "SELECT " +
                            "(SELECT SUM(VALOR) FROM tbCaixa WHERE CategoriaLancamento = 3) AS SaldoInicial, " +
                            "(SELECT SUM(VALOR)  FROM tbCaixa WHERE TipoEvento = 'Entrada') AS Entradas, " +
                            "(SELECT SUM(VALOR)  FROM tbCaixa WHERE TipoEvento = 'Saida') AS Saidas, " +
                            "(SELECT SUM(VALOR)  FROM tbCaixa WHERE TipoEvento = 'Entrada' AND CategoriaLancamento NOT IN(3, 4)) AS Faturado, " +
                            "((SELECT SUM(VALOR)  FROM tbCaixa WHERE TipoEvento = 'Entrada' AND CategoriaLancamento NOT IN(3, 4)) + (SELECT SUM(VALOR)  FROM tbCaixa WHERE TipoEvento = 'Saida') ) AS Lucro, " +
                            "(SELECT SUM(VALOR) AS Dinheiro FROM tbCaixa WHERE CategoriaLancamento = 5) AS Dinheiro, " +
                            "((SELECT SUM(VALOR)  FROM tbCaixa WHERE TipoEvento = 'Entrada') + (SELECT SUM(VALOR)  FROM tbCaixa WHERE TipoEvento = 'Saida')) AS Saldo ";


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


        public DataTable ListarMesAMes(int ano)
        {
            DataTable dados = new DataTable();
            string query =

                "select '01' AS Mes, Entradas,Saidas,Faturado,Lucro from RetornaResumoAnoMes(" + ano + ",1) " +
                "UNION ALL " +
                "select '02' AS Mes, Entradas, Saidas, Faturado, Lucro from RetornaResumoAnoMes(" + ano + ", 2) " +
                "UNION ALL " +
                "select '03' AS Mes, Entradas, Saidas, Faturado, Lucro from RetornaResumoAnoMes(" + ano + ", 3) " +
                "UNION ALL " +
                "select '04' AS Mes, Entradas, Saidas, Faturado, Lucro from RetornaResumoAnoMes(" + ano + ", 4) " +
                "UNION ALL " +
                "select '05' AS Mes, Entradas, Saidas, Faturado, Lucro from RetornaResumoAnoMes(" + ano + ", 5) " +
                "UNION ALL " +
                "select '06' AS Mes, Entradas, Saidas, Faturado, Lucro from RetornaResumoAnoMes(" + ano + ", 6) " +
                "UNION ALL " +
                "select '07' AS Mes, Entradas, Saidas, Faturado, Lucro from RetornaResumoAnoMes(" + ano + ", 7) " +
                "UNION ALL " +
                "select '08' AS Mes, Entradas, Saidas, Faturado, Lucro from RetornaResumoAnoMes(" + ano + ", 8) " +
                "UNION ALL " +
                "select '09' AS Mes, Entradas, Saidas, Faturado, Lucro from RetornaResumoAnoMes(" + ano + ", 9) " +
                "UNION ALL " +
                "select '10' AS Mes, Entradas, Saidas, Faturado, Lucro from RetornaResumoAnoMes(" + ano + ", 10) " +
                "UNION ALL " +
                "select '11' AS Mes, Entradas, Saidas, Faturado, Lucro from RetornaResumoAnoMes(" + ano + ", 11) " +
                "UNION ALL " +
                "select '12' AS Mes, Entradas, Saidas, Faturado, Lucro from RetornaResumoAnoMes(" + ano + ", 12) ";
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

    }
}
