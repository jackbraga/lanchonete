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

        public IEnumerable<VendasParceriaEscala> BuscarParceriaEscala(int idParceria)
        {
            string sql = @"SELECT A.DataEscala ,A.Descricao AS DescricaoEscala,  
                            G.TipoComissao, G.Comissao, 
                            SUM(C.Quantidade) AS QtdVendidos, SUM(C.Quantidade * C.PrecoProduto) AS Total, 
                            G.ID AS IDParceria,
                            A.ID AS IDEscala,
                            ISNULL(H.Repasse,0) AS RepasseFeito
                            FROM		tbEscalas AS A
                            INNER JOIN	tbVendas  AS B ON B.Escala=A.ID
                            INNER JOIN  tbVendasPedido AS C ON C.Venda=B.ID
                            INNER JOIN	tbProdutos AS D ON D.ID=C.Produto
                            INNER JOIN	tbSocios	AS E ON E.ID=B.Socio
                            INNER JOIN	tbParceriasProduto AS F ON F.IDProduto=D.ID
                            INNER JOIN	tbParcerias	AS G ON G.ID=F.IDParceira
                            LEFT  JOIN	tbRepasseParceriaEscala AS H ON H.IDEscala=A.ID AND H.IDParceria=G.ID
                            WHERE F.IDParceira=@id
                            GROUP BY A.DataEscala, A.Descricao,G.TipoComissao,G.Comissao, H.Repasse, G.ID, A.ID
                            ORDER BY A.DataEscala DESC";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<VendasParceriaEscala>(sql, new
                {
                    id = idParceria
                });

                return result;

            }
        }

        public IEnumerable<VendasParceriaProduto> BuscarVendasProdutosParceria(int idParceria, bool retirados)
        {
            string sql = @"SELECT A.DataEscala, A.Descricao AS DescricaoEscala,E.Nome AS NomeSocio, D.Descricao AS DescricaoProduto, C.Quantidade, C.PrecoProduto, C.Retirado,C.id as IdRetirado
                            FROM		tbEscalas AS A
                            INNER JOIN	tbVendas  AS B ON B.Escala=A.ID
                            INNER JOIN  tbVendasPedido AS C ON C.Venda=B.ID
                            INNER JOIN	tbProdutos AS D ON D.ID=C.Produto
                            INNER JOIN	tbSocios	AS E ON E.ID=B.Socio
                            INNER JOIN	tbParceriasProduto AS F ON F.IDProduto=D.ID
                            WHERE F.IDParceira=@id AND C.Retirado=@retirado
                            ORDER BY A.DataEscala DESC";

            using (var connection = _connection.Connection())
            {
                connection.Open();
                var result = connection.Query<VendasParceriaProduto>(sql, new
                {
                    id = idParceria,
                    retirado = retirados
                });

                return result;

            }
        }

        public void RegistraRepasseParceria(int idEscala, int idParceria, bool repasse)
        {
            string sql = @"INSERT INTO tbRepasseParceriaEscala(IDEscala, IDParceria,Repasse) 
                            VALUES(@idescala,@idparceria,@repasse);";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    idescala = idEscala,
                    idparceria = idParceria,
                    repasse = repasse
                });
            }
        }

        public void DesregistraRepasseParceria(int idEscala, int idParceria)
        {
            string sql = @"DELETE FROM tbRepasseParceriaEscala
                           WHERE IDEscala=@idescala AND IDParceria=@idparceria";
            using (var connection = _connection.Connection())
            {
                connection.Open();
                connection.Execute(sql, new
                {
                    idescala = idEscala,
                    idparceria = idParceria
                });
            }
        }
    }
}
