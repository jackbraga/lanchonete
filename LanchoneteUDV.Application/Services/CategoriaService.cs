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

        public async Task<IEnumerable<CategoriaDTO>> GetCategorias()
        {
            var categorias = await _categoriaRepository.GetCategoriasAsync();

            return _mapper.Map<IEnumerable<CategoriaDTO>>(categorias);
        }

        public async Task<IEnumerable<CategoriaDTO>> GetByNameAsync(string texto)
        {
            var categorias = await _categoriaRepository.GetByNameAsync(texto);

            return _mapper.Map<IEnumerable<CategoriaDTO>>(categorias);
        }

        public Task<CategoriaDTO> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task Add(CategoriaDTO categoryDTO)
        {
            var categoria = _mapper.Map<Categoria>(categoryDTO);
            await _categoriaRepository.CreateAsync(categoria);
        }

        public async Task Update(CategoriaDTO categoryDTO)
        {
            var categoria = _mapper.Map<Categoria>(categoryDTO);
            await _categoriaRepository.UpdateAsync(categoria);
        }

        public async Task Remove(CategoriaDTO categoriaDTO)
        {
            var categoria = _mapper.Map<Categoria>(categoriaDTO);
            await _categoriaRepository.RemoveAsync(categoria);
        }


    }
}
