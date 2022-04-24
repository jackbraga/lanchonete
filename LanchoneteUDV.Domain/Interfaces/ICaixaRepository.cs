using LanchoneteUDV.Domain.Entidades;

namespace LanchoneteUDV.Domain.Interfaces
{
    public interface ICaixaRepository : IBaseRepository<Caixa>
    {
        IEnumerable<CategoriaLancamento> ListarCategoriaLancamento();

        Task<ResumoVendas> ListarResumo();

        Task<IEnumerable<ResumoVendas>> ListarResumoMesAMes(int ano);

        void AtualizarDinheiroCaixa(double valor);
    }
}
