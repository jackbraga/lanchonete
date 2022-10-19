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
    public class EscalaService : IEscalaService
    {
        private IEscalaRepository _escalaRepository;
        private readonly IMapper _mapper;

        public EscalaService(IEscalaRepository escalaRepository, IMapper mapper)
        {
            _escalaRepository = escalaRepository;
            _mapper = mapper;
        }

        public EscalaDTO Add(EscalaDTO escala)
        {
            var escalaDTO = _mapper.Map<Escala>(escala);
            var retorno = _escalaRepository.Add(escalaDTO);
            return _mapper.Map<EscalaDTO>(retorno);

        }

        public IEnumerable<EscalaDTO> GetAll()
        {
            var escalas = _escalaRepository.GetAll().OrderByDescending(x => x.DataEscala);
            return _mapper.Map<IEnumerable<EscalaDTO>>(escalas);
        }

        public EscalaDTO GetById(int? id)
        {
            var escala = _escalaRepository.GetById(id);
            return _mapper.Map<EscalaDTO>(escala);
        }

        public IEnumerable<EscalaDTO> GetByName(string texto)
        {
            var escalas = _escalaRepository.GetByName(texto);
            return _mapper.Map<IEnumerable<EscalaDTO>>(escalas);
        }

        public void Remove(int idEscala)
        {
            _escalaRepository.Remove(idEscala);
        }

        public void Update(EscalaDTO escala)
        {
            var escalaDTO = _mapper.Map<Escala>(escala);
            _escalaRepository.Update(escalaDTO);
        }

        public void FinalizarEscala(int idEscala)
        {
            _escalaRepository.FinalizarEscala(idEscala);
        }
    }
}
