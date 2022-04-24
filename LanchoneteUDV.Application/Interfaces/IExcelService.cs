using LanchoneteUDV.Application.DTO;

namespace LanchoneteUDV.Application.Interfaces
{
    public interface IExcelService
    {
        bool CriarPlanilhaRepasse(IEnumerable<RepasseFinanceiroExcelDTO> repasses);
    }
}
