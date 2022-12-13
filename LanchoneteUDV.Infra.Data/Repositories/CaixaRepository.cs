using Dapper;
using LanchoneteUDV.Domain.Entidades;
using LanchoneteUDV.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Infra.Data.Repositories
{
    public class CaixaRepository : ICaixaRepository
    {
        private readonly IConnectionFactory _connection;

        public CaixaRepository(IConnectionFactory connection)
        {
            _connection = connection;
        }
        public Caixa Add(Caixa classe)
        {
            string sql = "INSERT INTO tbCaixa(DataEvento, TipoEvento,CategoriaLancamento,Valor,Observacao,EspecieMoeda,Frente,Escala) " +
                "VALUES(@data,@tipoEvento,@categoria,@valor,@observacao,@moeda,@frente,@escala) ";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Query<Caixa>(sql, new
                {
                    data = classe.DataEvento,
                    tipoEvento = classe.TipoEvento,
                    moeda=classe.EspecieMoeda,
                    categoria = classe.IdCategoria,
                    valor = classe.Valor,
                    observacao = classe.Observacao,
                    frente = classe.Frente,
                    escala = classe.IDEscala
                });
                return classe;
            }
        }

        public IEnumerable<Caixa> GetAll()
        {
            string sql = "SELECT A.ID, A.DataEvento, A.TipoEvento, A.Valor,B.Descricao as DescricaoCategoria, A.Observacao,B.ID as IDCategoria, ISNULL(A.EspecieMoeda,'Nao Definido') AS EspecieMoeda, A.Frente " +
            "FROM tbCaixa AS A " +
            "INNER JOIN tbCategoriaLancamento AS B ON B.ID=A.CAtegoriaLancamento ";
            

            using (var connection = _connection.Connection())
            {
                connection.Open();
                return connection.Query<Caixa>(sql);
            }
        }

        public Caixa GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Caixa> GetByName(string texto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriaLancamento> ListarCategoriaLancamento()
        {
            string sql = "SELECT A.ID, A.Descricao " +
            "FROM tbCategoriaLancamento AS A ;";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                return connection.Query<CategoriaLancamento>(sql);
            }
        }

        public async Task<ResumoVendas> ListarResumo(string frente)
        {
            string sql = "SELECT " +
                            "(SELECT SUM(VALOR)  FROM tbCaixa WHERE TipoEvento = 'Entrada' AND Frente='" + frente + "') AS Entradas, " +
                            "(SELECT SUM(VALOR)  FROM tbCaixa WHERE TipoEvento = 'Saida' AND Frente='" + frente + "') AS Saidas, " +
                            "(SELECT SUM(VALOR)  FROM tbCaixa WHERE TipoEvento = 'Entrada' AND CategoriaLancamento NOT IN(3, 4)  AND Frente='" + frente + "') AS Faturado, " +
                            "((SELECT SUM(VALOR)  FROM tbCaixa WHERE TipoEvento = 'Entrada' AND CategoriaLancamento NOT IN(3, 4) AND Frente='" + frente + "') + (SELECT SUM(VALOR)  FROM tbCaixa WHERE TipoEvento = 'Saida' AND Frente='" + frente + "') ) AS Lucro, " +
                            "(SELECT SUM(VALOR) AS Dinheiro FROM tbCaixa WHERE EspecieMoeda = 'DINHEIRO' AND Frente='" + frente + "') AS Dinheiro, " +
                            "(SELECT SUM(VALOR) AS CARTAO FROM tbCaixa WHERE EspecieMoeda = 'CARTAO' AND Frente='" + frente + "') AS Cartao, " +
                            "(SELECT SUM(VALOR) AS BOLETO FROM tbCaixa WHERE EspecieMoeda = 'BOLETO' AND Frente='" + frente + "') AS BOLETO, " +
                            "((SELECT SUM(VALOR)  FROM tbCaixa WHERE TipoEvento = 'Entrada' AND Frente='" + frente + "') + (SELECT SUM(VALOR)  FROM tbCaixa WHERE TipoEvento = 'Saida' AND Frente='" + frente + "')) AS Saldo, " +
                            "(SELECT SUM(VALOR) AS PARCERIA FROM tbCaixa WHERE CategoriaLancamento = 6 AND Frente='" + frente + "') AS PARCERIA ";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                return await connection.QuerySingleAsync<ResumoVendas>(sql);
            }
        }

        public async Task<IEnumerable<ResumoVendas>> ListarResumoMesAMes(int ano)
        {
            string sql = "select '01' AS Mes, Entradas,Saidas,Faturado,Lucro from RetornaResumoAnoMes(" + ano + ",1) " +
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
            using (var connection = _connection.Connection())
            {
                connection.Open();
                return await connection.QueryAsync<ResumoVendas>(sql);
            }
        }

        public void Remove(int id)
        {
            string sql = "DELETE FROM tbCaixa WHERE ID=@id";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    id = id
                });
            }
        }

        public void RemoverPorIDEscala(int idEscala)
        {
            string sql = "DELETE FROM tbCaixa WHERE Escala=@idEscala";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    idEscala = idEscala
                });
            }
        }

        public Caixa Update(Caixa classe)
        {
            string sql = "UPDATE tbCaixa SET DataEvento=@data, TipoEvento=@tipoEvento,CategoriaLancamento=@categoria,Valor=@valor,Observacao=@observacao, EspecieMoeda=@moeda, Frente=@frente " +
                "WHERE ID=@id ";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Query<Caixa>(sql, new
                {
                    data = classe.DataEvento,
                    tipoEvento = classe.TipoEvento,
                    categoria = classe.IdCategoria,
                    valor = classe.Valor,
                    observacao = classe.Observacao,
                    moeda = classe.EspecieMoeda,
                    frente = classe.Frente,
                    id = classe.Id
                }) ;
                return classe;
            }
        }

       public void AtualizarDinheiroCaixa(double valor)
        {
            string sql = "UPDATE tbCaixa SET Valor = @valor WHERE CategoriaLancamento = 5";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    valor = valor
                });
                
            }
        }


    
    }
}
