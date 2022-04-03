using LanchoneteUDV.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaDTO>> GetCategorias();

        Task<IEnumerable<CategoriaDTO>> GetByNameAsync(string texto);

        Task<CategoriaDTO> GetById(int? id);

        Task Add(CategoriaDTO categoryDTO);
        Task Update(CategoriaDTO categoryDTO);
        Task Remove(CategoriaDTO categoria);
    }
}
