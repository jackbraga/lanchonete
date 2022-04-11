using LanchoneteUDV.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.Interfaces
{
    public interface ICaixaService : IBaseService<CaixaDTO>
    {
        IEnumerable<CategoriaLancamentoDTO> ListarCategoriaLancamento();

        Task<ResumoVendasDTO> ListarResumo();

        Task<IEnumerable<ResumoVendasDTO>> ListarResumoMesAMes(int ano);
    }
}
