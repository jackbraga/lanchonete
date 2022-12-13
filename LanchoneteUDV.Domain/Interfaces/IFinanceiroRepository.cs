using LanchoneteUDV.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Interfaces
{
    public interface IFinanceiroRepository
    {
        IEnumerable<RepasseFinanceiro> ListarItensRepasseFinanceiro(int idEscala, int idSocio);

        IEnumerable<VendaRepasseFinanceiro> ListarVendasRepasseFinanceiro(int idEscala);

        void AtualizaEmailDisparado(int idVenda);

        IEnumerable<RepasseFinanceiroExcel> GerarListaRepasseFinanceiroExcel(int idEscala);

        IEnumerable<RepasseFinanceiroExcel> GerarListaRepasseFinanceiroParceriaExcel(int idEscala);

        IEnumerable<Caixa> GerarListaFluxoCaixaEscala(int idEscala);


    }
}
