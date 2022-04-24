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
    public class EscalaRepository : IEscalaRepository
    {
        private readonly IConnectionFactory _connection;

        public EscalaRepository(IConnectionFactory connection)
        {
            _connection=connection;
        }


        public Escala Add(Escala escala)
        {
            string sql = "INSERT INTO tbEscalas" +
                             "(Descricao,DataEscala,Finalizada,Observacao,TipoSessao) " +
                         "VALUES" +
                            "(@descricao,@dataEscala,@finalizada,@observacao,@tipoSessao)";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                 connection.Execute(sql, new
                {
                    descricao = escala.Descricao,
                    dataEscala=escala.DataEscala,
                    finalizada=escala.Finalizada,
                    observacao=escala.Observacao,
                    tipoSessao=escala.TipoSessao
                });
            }
            return escala;
        }

        public void Remove(int idEscala)
        {
            string sql = "DELETE FROM tbEscalas WHERE ID=@id";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                 connection.Execute(sql, new
                {
                    id = idEscala
                 });
            }
           
        }

        public Escala Update(Escala escala)
        {
            string sql = "UPDATE tbEscalas SET " +
                    "Descricao=@descricao," +
                    "DataEscala=@dataEscala," +
                    "Finalizada=@finalizada," +
                    "Observacao=@observacao," +
                    "TipoSessao=@tipoSessao " +
                    "WHERE ID=@id";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                 connection.Execute(sql, new
                {
                    descricao = escala.Descricao,
                    dataEscala=escala.DataEscala,
                    finalizada=escala.Finalizada,
                    observacao=escala.Observacao,
                    tipoSessao=escala.TipoSessao,
                    id=escala.Id
                });
            }
            return escala;
        }


        public void FinalizarEscala(int idEscala)
        {
            string sql = "UPDATE tbEscalas SET " +
                         "Finalizada=1 " +
                         "WHERE ID=@id";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                 connection.Execute(sql, new
                {
                    id = idEscala
                });
            }

        }

        public Escala GetById(int? id)
        {

        string sql = "SELECT  A.ID, A.Descricao,A.DataEscala, A.Finalizada, A.Observacao, A.TipoSessao, A.RepasseTesouraria " +
           "FROM tbEscalas A with(nolock)" +
           "WHERE A.ID =@id";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                return connection.QuerySingle<Escala>(sql, new
                {
                    id = id
                });                
            }
    }

        public IEnumerable<Escala> GetByName(string texto)
        {
            string sql = "SELECT  A.ID,A.DataEscala, A.Descricao, A.Finalizada, A.Observacao, A.TipoSessao " +
                    "FROM tbEscalas A " +
                    "WHERE A.Descricao LIKE '@pesquisa%' " +
                    "order by A.DataEscala Desc";
            IList<Escala> categorias = new List<Escala>();

            using (var connection = _connection.Connection())
            {
                connection.Open();
                return  connection.Query<Escala>(sql, new
                {
                    pesquisa = texto
                });
                
            }
        }

        public IEnumerable<Escala> GetAll()
        {
            string sql = "SELECT tbEscalas.ID, tbEscalas.DataEscala, tbEscalas.Descricao, tbEscalas.TipoSessao, tbEscalas.Observacao, tbEscalas.Finalizada, tbEscalas.RepasseTesouraria, SUM((tbVendasPedido.PrecoProduto * tbVendasPedido.Quantidade)) AS ResumoVendas " +
    "FROM tbEscalas WITH(NOLOCK) " +
    "LEFT JOIN tbVendas WITH(NOLOCK) ON tbEscalas.ID = tbVendas.Escala " +
    "LEFT JOIN tbVendasPedido WITH(NOLOCK) ON tbVendas.ID = tbVendasPedido.Venda " +
    "GROUP BY tbEscalas.ID, tbEscalas.DataEscala, tbEscalas.Descricao, tbEscalas.TipoSessao, tbEscalas.Observacao, tbEscalas.Finalizada, tbEscalas.RepasseTesouraria ";
   

            IList<Escala> categorias = new List<Escala>();

            using (var connection = _connection.Connection())
            {
                connection.Open();
                return  connection.Query<Escala>(sql);

            }
        }
    }
}
