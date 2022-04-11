using LanchoneteUDV.Domain.Entidades;

namespace LanchoneteUDV.Domain.Interfaces
{
    public interface IEstoqueEscalaRepository
    {
        public EstoqueEscala Add(EstoqueEscala classe);

        public void CompletarEstoqueEscala(int idEscala);

        public IEnumerable<EstoqueEscala> ListarProdutosEstoqueEscala(int idEscala);

        public IEnumerable<Estoque> ListarEstoque();

        public IEnumerable<Estoque> PesquisarEstoque(string pesquisa);

        public void Remove(int id);

        public EstoqueEscala Update(EstoqueEscala classe);

    }
}
