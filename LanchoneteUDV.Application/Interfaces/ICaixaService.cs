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

        Task<ResumoVendasDTO> ListarResumo(string frente);

        Task<IEnumerable<ResumoVendasDTO>> ListarResumoMesAMes(int ano);

        void AtualizarDinheiroCaixa(double valor);

        public void RemoverPorIDEscala(int idEscala);
    }
}
