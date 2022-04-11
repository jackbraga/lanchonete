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
    public class SocioService : ISocioService
    {
        private readonly ISocioRepository _socioRepository;
        private readonly IMapper _mapper;

        public SocioService(ISocioRepository socioRepository, IMapper mapper)
        {
            _socioRepository = socioRepository;
            _mapper=mapper;
        }
        public void Add(SocioDTO socioDTO)
        {
            var produto = _mapper.Map<Socio>(socioDTO);
            _socioRepository.Add(produto);
        }

        public IEnumerable<SocioDTO> GetAll()
        {
            var socios = _socioRepository.GetAll();
            return _mapper.Map<IEnumerable<SocioDTO>>(socios);
        }

        public SocioDTO GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SocioDTO> GetByName(string texto)
        {
            var socios = _socioRepository.GetByName(texto);
            return _mapper.Map<IEnumerable<SocioDTO>>(socios);
        }

        public IEnumerable<SocioDTO> ListarSociosVenda()
        {
            var socios = _socioRepository.ListarSociosVenda();
            return _mapper.Map<IEnumerable<SocioDTO>>(socios);
        }

        public IEnumerable<SocioDTO> ListarSociosVisitantes()
        {
            var socios = _socioRepository.ListarSociosVisitantes();
            return _mapper.Map<IEnumerable<SocioDTO>>(socios);
        }

        public void Remove(int id)
        {
            _socioRepository.Remove(id);
        }

        public void Update(SocioDTO socioDTO)
        {
            var socio = _mapper.Map<Socio>(socioDTO);
            _socioRepository.Update(socio);
        }
    }
}
