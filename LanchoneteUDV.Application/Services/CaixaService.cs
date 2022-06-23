using AutoMapper;
using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;
using LanchoneteUDV.Domain.Entidades;
using LanchoneteUDV.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.Services
{
    public class CaixaService : ICaixaService
    {
        private readonly ICaixaRepository _caixaRepository;
        private readonly IMapper _mapper;

        public CaixaService(ICaixaRepository caixaRepository, IMapper mapper)
        {
            _caixaRepository = caixaRepository;
            _mapper = mapper;
        }

        public void Add(CaixaDTO caixaDTO)
        {
            var caixa = _mapper.Map<Caixa>(caixaDTO);
            _caixaRepository.Add(caixa);
        }

        public IEnumerable<CaixaDTO> GetAll()
        {
            var lista = _caixaRepository.GetAll();
            return _mapper.Map<IEnumerable<CaixaDTO>>(lista);
        }

        public CaixaDTO GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CaixaDTO> GetByName(string texto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriaLancamentoDTO> ListarCategoriaLancamento()
        {
            var lista = _caixaRepository.ListarCategoriaLancamento();
            return _mapper.Map<IEnumerable<CategoriaLancamentoDTO>>(lista);
        }

        public async Task<ResumoVendasDTO> ListarResumo()
        {
            var lista = await _caixaRepository.ListarResumo();
            return _mapper.Map<ResumoVendasDTO>(lista);
        }

        public async Task<IEnumerable<ResumoVendasDTO>> ListarResumoMesAMes(int ano)
        {
            var lista = await _caixaRepository.ListarResumoMesAMes(ano);
            return _mapper.Map<IEnumerable<ResumoVendasDTO>>(lista);
        }

        public void Remove(int id)
        {
            _caixaRepository.Remove(id);
        }

        public void Update(CaixaDTO objeto)
        {
            var caixa = _mapper.Map<Caixa>(objeto);
            _caixaRepository.Update(caixa);
        }

        public void AtualizarDinheiroCaixa(double valor)
        {            
            _caixaRepository.AtualizarDinheiroCaixa(valor);
        }
    }
}
