using LanchoneteUDV.Application.DTO;

namespace LanchoneteUDV.Application.Interfaces
{
    public interface IExcelService
    {
        bool CriarPlanilhaRepasse(List<IEnumerable<RepasseFinanceiroExcelDTO>> repasses);
    }
}
