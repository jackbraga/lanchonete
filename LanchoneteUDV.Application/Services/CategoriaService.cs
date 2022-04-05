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
    public class CategoriaService : ICategoriaService
    {
        private ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;

        public CategoriaService(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }

        public IEnumerable<CategoriaDTO> GetCategorias()
        {
            var categorias = _categoriaRepository.GetCategorias();

            return _mapper.Map<IEnumerable<CategoriaDTO>>(categorias);
        }

        public IEnumerable<CategoriaDTO> GetByName(string texto)
        {
            var categorias = _categoriaRepository.GetByName(texto);

            return _mapper.Map<IEnumerable<CategoriaDTO>>(categorias);
        }

        public CategoriaDTO GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public void Add(CategoriaDTO categoryDTO)
        {
            var categoria = _mapper.Map<Categoria>(categoryDTO);
             _categoriaRepository.Create(categoria);
        }

        public void Update(CategoriaDTO categoryDTO)
        {
            var categoria = _mapper.Map<Categoria>(categoryDTO);
             _categoriaRepository.Update(categoria);
        }

        public void Remove(CategoriaDTO categoriaDTO)
        {
            var categoria = _mapper.Map<Categoria>(categoriaDTO);
             _categoriaRepository.Remove(categoria);
        }


    }
}
