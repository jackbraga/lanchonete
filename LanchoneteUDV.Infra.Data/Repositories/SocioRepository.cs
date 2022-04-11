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
    public class SocioRepository : ISocioRepository
    {
        private readonly IConnectionFactory _connection;

        public SocioRepository(IConnectionFactory connection)
        {
            _connection = connection;
        }
        public Socio Add(Socio classe)
        {
            string sql = "INSERT INTO tbSocios(Nome,Email,TipoSocio,DataCriacao) " +
                "VALUES(@nome,@email,@tipoSocio,GETDATE());";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    nome=classe.Nome,
                    email=classe.Email,
                    tipoSocio=classe.TipoSocio
                });
            }
            return classe;
        }

        public IEnumerable<Socio> GetAll()
        {
            string sql = "SELECT A.ID,A.Nome, A.Email, ISNULL(A.ResponsavelFinanceiro,A.ID) AS ResponsavelFinanceiro,ISNULL(B.Nome,A.NOME) AS NomeResponsavel " +
                           "FROM tbSocios AS A " +
                           "LEFT JOIN   tbSocios AS B ON B.ID = A.ResponsavelFinanceiro " +
                           "WHERE A.TipoSocio = 1 order by A.Nome ";


            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<Socio>(sql);

                return result;

            }
        }

        public Socio GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Socio> GetByName(string texto)
        {
            string sql = "SELECT A.ID,A.Nome, A.Email, ISNULL(A.ResponsavelFinanceiro,A.ID) AS ResponsavelFinanceiro,ISNULL(B.Nome,A.NOME) AS NomeResponsavel " +
                           "FROM tbSocios AS A " +
                           "LEFT JOIN   tbSocios AS B ON B.ID = A.ResponsavelFinanceiro " +
                           "WHERE A.TipoSocio = 1 AND Nome LIKE '" + texto + "%' ORDER BY NOME";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<Socio>(sql);

                return result;
            }
        }

        public IEnumerable<Socio> ListarSociosVenda()
        {
                string sql = "SELECT ID,Nome, Email " +
                            "FROM tbSocios " +
                            "WHERE TipoSocio = 1 " +
                            "UNION ALL " +
                            "SELECT ID, Nome, Email " +
                            "FROM tbSocios " +
                            "WHERE TipoSocio = 2 AND DataCriacao>= DATEADD(MONTH, -1, GETDATE()) " +
                            "ORDER BY 2";


                using (var connection = _connection.Connection())
                {
                    connection.Open();
                    var result = connection.Query<Socio>(sql);

                    return result;

                }
            }

        public IEnumerable<Socio> ListarSociosVisitantes()
        {
            string sql = "SELECT ID,Nome, Email FROM tbSocios WHERE TipoSocio=2 order by Nome";


            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<Socio>(sql);

                return result;

            }
        }

        public void Remove(int id)
        {
            string sql = "DELETE FROM tbSocios WHERE ID=@id";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    id = id
                });
            }
        }

        public Socio Update(Socio classe)
        {
            string sql = "UPDATE tbSocios SET Nome=@nome, Email=@email, TipoSocio=@tipoSocio, ResponsavelFinanceiro=@financeiro WHERE ID=@idSocio";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    nome=classe.Nome,
                    email=classe.Email,
                    tipoSocio=classe.TipoSocio,
                    financeiro=classe.ResponsavelFinanceiro,
                    idSocio=classe.Id
                });
            }
            return classe;
        }
    }
}
