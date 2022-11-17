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
    public class ParceriasService : IParceriasService
    {
        private readonly IParceriasRepository _parceriasRepository;
        private readonly IMapper _mapper;

        public ParceriasService(IParceriasRepository parceriasRepository, IMapper mapper)
        {
            _parceriasRepository = parceriasRepository;
            _mapper = mapper;
        }

        public ParceriasDTO Add(ParceriasDTO objeto)
        {
            var retorno = _parceriasRepository.Add(_mapper.Map<Parcerias>(objeto));
            return _mapper.Map<ParceriasDTO>(retorno);
        }

        public IEnumerable<ParceriasDTO> GetAll()
        {
            var parcerias = _parceriasRepository.GetAll();
            return _mapper.Map<IEnumerable<ParceriasDTO>>(parcerias);
        }

        public ParceriasDTO GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ParceriasDTO> GetByName(string texto)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            _parceriasRepository.Remove(id);
        }

        public void Update(ParceriasDTO objeto)
        {
            _parceriasRepository.Update(_mapper.Map<Parcerias>(objeto));
        }


        public IEnumerable<ParceriasProdutoDTO> BuscarProdutosParceria(int idParceria)
        {
            var produtos = _parceriasRepository.BuscarProdutosParceria(idParceria);
            return _mapper.Map<IEnumerable<ParceriasProdutoDTO>>(produtos);
        }

        public ParceriasProdutoDTO AdicionaProdutoParceria(ParceriasProdutoDTO parceriasProduto)
        {
            var produto = _mapper.Map<ParceriasProduto>(parceriasProduto);
            var retorno = _parceriasRepository.AdicionaProdutoParceria(produto);
            return _mapper.Map<ParceriasProdutoDTO>(retorno);
        }

        public IEnumerable<VendasParceriaEscalaDTO> BuscarParceriaEscala(int idParceria)
        {
            var retorno = _parceriasRepository.BuscarParceriaEscala(idParceria);
            return _mapper.Map<IEnumerable<VendasParceriaEscalaDTO>>(retorno);
        }

        public IEnumerable<VendasParceriaProdutoDTO> BuscarVendasProdutosParceria(int idParceria, bool retirados)
        {
            var retorno = _parceriasRepository.BuscarVendasProdutosParceria(idParceria, retirados);
            return _mapper.Map<IEnumerable<VendasParceriaProdutoDTO>>(retorno);
        }

        public void RegistraRepasseParceria(int idEscala, int idParceria, bool repasse)
        {
            _parceriasRepository.RegistraRepasseParceria(idEscala, idParceria, repasse);
        }
        public void DesregistraRepasseParceria(int idEscala, int idParceria)
        {
            _parceriasRepository.DesregistraRepasseParceria(idEscala, idParceria);
        }


    }
}
