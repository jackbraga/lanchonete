using LanchoneteUDV.Application.DTO;

namespace LanchoneteUDV.Application.Interfaces
{
    public interface IFinanceiroService
    {
        IEnumerable<RepasseFinanceiroDTO> ListarItensRepasseFinanceiro(int idEscala, int idSocio);

        IEnumerable<VendaRepasseFinanceiroDTO> ListarVendasRepasseFinanceiro(int idEscala);

        void AtualizaEmailDisparado(int idVenda);

        bool GerarListaRepasseFinanceiroExcel(int idEscala);
    }
}
