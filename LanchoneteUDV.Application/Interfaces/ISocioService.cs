using LanchoneteUDV.Application.DTO;

namespace LanchoneteUDV.Application.Interfaces
{
    public interface ISocioService :IBaseService<SocioDTO>
    {
        IEnumerable<SocioDTO> ListarSociosVenda();
        IEnumerable<SocioDTO> ListarSociosVisitantes();
    }
}
