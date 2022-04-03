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

        public async Task<IEnumerable<Categoria>> GetCategoriasAsync()
        {
            string sql = "SELECT ID,Descricao FROM tbCategorias order by Descricao";
            IList<Categoria> categorias = new List<Categoria>();
            
            using (var connectionDb = Connection.Connection())
            {
                connectionDb.Open();

               return await connectionDb.QueryAsync<Categoria>(sql);
                
            }
           
        }
        public Task<Categoria> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Categoria>> GetByNameAsync(string texto)
        {
            string sql = "SELECT ID,Descricao FROM tbCategorias WHERE Descricao Like @texto% order by Descricao";
            IList<Categoria> categorias = new List<Categoria>();

            using (var connectionDb = Connection.Connection())
            {
                connectionDb.Open();


                return await connectionDb.QueryAsync<Categoria>(sql,
                    new
                    {
                        texto = texto
                    }
                    );

            }
        }


        public async Task<Categoria> CreateAsync(Categoria categoria)
        {
            string sql = "INSERT INTO tbCategorias(Descricao) VALUES(@descricao)";

            using (var connectionDb = Connection.Connection())
            {
                connectionDb.Open();

                var result = await connectionDb.ExecuteAsync(sql,
                    new
                    {
                        descricao = categoria.Descricao
                    });

            }

            return categoria;

        }


        public async Task<Categoria> RemoveAsync(Categoria categoria)
        {
            string sql = "DELETE FROM tbCategorias WHERE ID=@id";

            using (var connectionDb = Connection.Connection())
            {
                connectionDb.Open();

                var result = await connectionDb.ExecuteAsync(sql,
                    new
                    {
                        id = categoria.Id
                    });

            }

            return categoria;
        }
        public async Task<Categoria> UpdateAsync(Categoria categoria)
        {
            string sql = "UPDATE tbCategorias SET Descricao = @descricao WHERE ID = @id";

            using (var connectionDb = Connection.Connection())
            {
                connectionDb.Open();

                var result = await connectionDb.ExecuteAsync(sql,
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
