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
    public class CompraService : ICompraService
    {
        private ICompraRepository _compraRepository;
        private readonly IMapper _mapper;

        public CompraService(ICompraRepository compraRepository, IMapper mapper)
        {
            _compraRepository = compraRepository;
            _mapper = mapper;
        }

        public IEnumerable<CompraDTO> GetAll()
        {
            var compras = _compraRepository.GetAll().OrderByDescending(x=>x.DataCompra);
            return _mapper.Map<IEnumerable<CompraDTO>>(compras);
        }

        public IEnumerable<CompraDTO> GetByName(string texto)
        {
            var compras = _compraRepository.GetByName(texto);
            return _mapper.Map<IEnumerable<CompraDTO>>(compras);
        }

        public CompraDTO GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public void Add(CompraDTO compraDTO)
        {
            var compra = _mapper.Map<Compra>(compraDTO);
            _compraRepository.Add(compra);
        }

        public void Update(CompraDTO compraDTO)
        {
            var compra = _mapper.Map<Compra>(compraDTO);
            _compraRepository.Update(compra);
        }

        public void Remove(int id)
        {
            _compraRepository.Remove(id);
        }
    }
}
