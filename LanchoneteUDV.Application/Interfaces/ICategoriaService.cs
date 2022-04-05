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
        IEnumerable<CategoriaDTO> GetCategorias();

        IEnumerable<CategoriaDTO> GetByName(string texto);

        CategoriaDTO GetById(int? id);

        void Add(CategoriaDTO categoryDTO);
        void Update(CategoriaDTO categoryDTO);
        void Remove(CategoriaDTO categoria);
    }
}
