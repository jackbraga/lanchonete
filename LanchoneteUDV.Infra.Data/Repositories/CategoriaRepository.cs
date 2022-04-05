using LanchoneteUDV.Domain.Entidades;
using LanchoneteUDV.Domain.Interfaces;
using Dapper;

namespace LanchoneteUDV.Infra.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly IConnectionFactory Connection;

        public CategoriaRepository(IConnectionFactory connection)
        {
            Connection = connection;
        }

        public  IEnumerable<Categoria> GetCategorias()
        {
            string sql = "SELECT ID,Descricao FROM tbCategorias WITH(NOLOCK) order by Descricao";
            IList<Categoria> categorias = new List<Categoria>();
            
            using (var connectionDb = Connection.Connection())
            {
                connectionDb.Open();

               return  connectionDb.Query<Categoria>(sql);
                
            }
           
        }
        public Categoria GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public  IEnumerable<Categoria> GetByName(string texto)
        {
            string sql = "SELECT ID,Descricao FROM tbCategorias WHERE Descricao Like @texto% order by Descricao";
            IList<Categoria> categorias = new List<Categoria>();

            using (var connectionDb = Connection.Connection())
            {
                connectionDb.Open();


                return  connectionDb.Query<Categoria>(sql,
                    new
                    {
                        texto = texto
                    }
                    );

            }
        }

        public  Categoria Create(Categoria categoria)
        {
            string sql = "INSERT INTO tbCategorias(Descricao) VALUES(@descricao)";

            using (var connectionDb = Connection.Connection())
            {
                connectionDb.Open();

                var result =  connectionDb.Execute(sql,
                    new
                    {
                        descricao = categoria.Descricao
                    });

            }

            return categoria;

        }

        public  Categoria Remove(Categoria categoria)
        {
            string sql = "DELETE FROM tbCategorias WHERE ID=@id";

            using (var connectionDb = Connection.Connection())
            {
                connectionDb.Open();

                var result =  connectionDb.Execute(sql,
                    new
                    {
                        id = categoria.Id
                    });

            }

            return categoria;
        }
        public  Categoria Update(Categoria categoria)
        {
            string sql = "UPDATE tbCategorias SET Descricao = @descricao WHERE ID = @id";

            using (var connectionDb = Connection.Connection())
            {
                connectionDb.Open();

                var result =  connectionDb.Execute(sql,
                    new
                    {
                        descricao=categoria.Descricao,
                        id=categoria.Id
                    });
            }
            return categoria;
        }

    }
}
