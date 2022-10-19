using Dapper;
using LanchoneteUDV.Domain.Entidades;
using LanchoneteUDV.Domain.Interfaces;

namespace LanchoneteUDV.Infra.Data.Repositories
{
    public class ParceriasRepository : IParceriasRepository
    {

        private readonly IConnectionFactory _connection;


        public ParceriasRepository(IConnectionFactory connection)
        {
            _connection = connection;
        }

        public Parcerias Add(Parcerias classe)
        {
            string sql = "INSERT INTO tbParcerias(Descricao,Responsavel,TipoComissao,Comissao) " +
                         "VALUES(@descricao,@responsavel,@tipoComissao,@comissao);";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    descricao = classe.Descricao,
                    responsavel = classe.Responsavel,
                    tipoComissao = classe.TipoComissao,
                    comissao=classe.Comissao,
                });
            }
            return classe;
        }

        public IEnumerable<Parcerias> GetAll()
        {
            string sql = "SELECT ID, DESCRICAO, Responsavel, TipoComissao, Comissao " +
                         "FROM tbParcerias order by 2";


            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<Parcerias>(sql);

                return result;

            }
        }

        public Parcerias GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Parcerias> GetByName(string texto)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            string sql = "DELETE FROM tbParcerias WHERE ID=@id";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    id = id
                });
            }
        }

        public Parcerias Update(Parcerias classe)
        {
            string sql = "UPDATE tbParcerias SET Descricao=@descricao, Responsavel=@responsavel, " +
                "TipoComissao=@tipoComissao, Comissao=@comissao WHERE ID=@id";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    descricao = classe.Descricao,
                    responsavel = classe.Responsavel,
                    tipoComissao = classe.TipoComissao,
                    comissao = classe.Comissao,
                    id = classe.Id
                });
            }
            return classe;
        }

        public IEnumerable<ParceriasProduto> BuscarProdutosParceria(int idParceria)
        {
            string sql = @"SELECT B.ID,C.ID AS IDParceria,C.Descricao as DescricaoParceria, A.ID AS IDProduto,A.Descricao as DescricaoProduto, A.PrecoVenda,A.ProdutoVenda as ProdutoAtivo
                            FROM tbProdutos AS A
                            INNER JOIN tbParceriasProduto AS B ON B.IDProduto = A.ID
                            INNER JOIN tbParcerias AS C ON C.ID = B.IDParceira
                            WHERE C.ID = @id";


            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<ParceriasProduto>(sql, new
                {
                    id=idParceria
                });

                return result;

            }
        }

        public ParceriasProduto AdicionaProdutoParceria(ParceriasProduto produto)
        {
            string sql = @"INSERT INTO tbParceriasProduto(IDParceira,IDProduto) VALUES(@idParceria,@idProduto)";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    idParceria = produto.IDParceria,
                    idProduto = produto.IDProduto
                });
            }
            return produto;
        }
    }
}
