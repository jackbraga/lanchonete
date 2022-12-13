using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Domain.Entidades;

namespace LanchoneteUDV.Application.Interfaces
{
    public interface IFinanceiroService
    {
        IEnumerable<RepasseFinanceiroDTO> ListarItensRepasseFinanceiro(int idEscala, int idSocio);

        IEnumerable<VendaRepasseFinanceiroDTO> ListarVendasRepasseFinanceiro(int idEscala);

        void AtualizaEmailDisparado(int idVenda);

        bool GerarListaRepasseFinanceiroExcel(int idEscala);

        IEnumerable<CaixaDTO> GerarListaFluxoCaixaEscala(int idEscala);
    }
}
