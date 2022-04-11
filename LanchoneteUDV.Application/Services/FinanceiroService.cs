﻿using AutoMapper;
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
        private readonly IMapper _mapper;

        public FinanceiroService(IFinanceiroRepository financeiroRepository, IMapper mapper)
        {
            _financeiroRepository = financeiroRepository;
            _mapper = mapper;
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
    }
}