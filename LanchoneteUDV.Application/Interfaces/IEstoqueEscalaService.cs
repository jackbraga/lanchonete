using LanchoneteUDV.Application.DTO;

namespace LanchoneteUDV.Application.Interfaces
{
    public interface IEstoqueEscalaService
    {
        public EstoqueEscalaDTO Add(EstoqueEscalaDTO classe);

        public void CompletarEstoqueEscala(int idEscala);

        public IEnumerable<EstoqueEscalaDTO> ListarProdutosEstoqueEscala(int idEscala);

        public IEnumerable<EstoqueDTO> ListarEstoque();
        public IEnumerable<EstoqueDTO> ListarEstoqueComboProdutos(int idEscala, bool exibeMesmoSemEstoque);
        public IEnumerable<EstoqueDTO> PesquisarEstoque(string pesquisa);

        public void Remove(int id);

        public EstoqueEscalaDTO Update(EstoqueEscalaDTO classe);
    }
}
