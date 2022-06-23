using AutoMapper;
using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;
using LanchoneteUDV.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.Services
{
    public class FinanceiroService : IFinanceiroService
    {
        private readonly IFinanceiroRepository _financeiroRepository;
        private readonly IExcelService _excelService;
        private readonly IMapper _mapper;

        public FinanceiroService(IFinanceiroRepository financeiroRepository, IMapper mapper, IExcelService excelService)
        {
            _financeiroRepository = financeiroRepository;
            _mapper = mapper;
            _excelService = excelService;
        }
        public void AtualizaEmailDisparado(int idVenda)
        {
            _financeiroRepository.AtualizaEmailDisparado(idVenda);
        }

        public IEnumerable<RepasseFinanceiroDTO> ListarItensRepasseFinanceiro(int idEscala, int idSocio)
        {
            var lista = _financeiroRepository.ListarItensRepasseFinanceiro(idEscala, idSocio);
            return _mapper.Map<IEnumerable<RepasseFinanceiroDTO>>(lista);
        }

        public IEnumerable<VendaRepasseFinanceiroDTO> ListarVendasRepasseFinanceiro(int idEscala)
        {
            var lista = _financeiroRepository.ListarVendasRepasseFinanceiro(idEscala);
            return _mapper.Map<IEnumerable<VendaRepasseFinanceiroDTO>>(lista);
        }

        public bool GerarListaRepasseFinanceiroExcel(int idEscala)
        {
            List<IEnumerable<RepasseFinanceiroExcelDTO>> planilhas = new List<IEnumerable<RepasseFinanceiroExcelDTO>>();

            var lista = _financeiroRepository.GerarListaRepasseFinanceiroExcel(idEscala);
            var listaDto = _mapper.Map<IEnumerable<RepasseFinanceiroExcelDTO>>(lista);

            var listaParceria = _financeiroRepository.GerarListaRepasseFinanceiroParceriaExcel(idEscala);
            var listaParceriaDto = _mapper.Map<IEnumerable<RepasseFinanceiroExcelDTO>>(listaParceria);

            planilhas.Add(listaDto);
            planilhas.Add(listaParceriaDto);
            return _excelService.CriarPlanilhaRepasse(planilhas);
        }
    }
}
