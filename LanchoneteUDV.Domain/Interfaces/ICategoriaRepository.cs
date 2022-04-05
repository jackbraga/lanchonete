using LanchoneteUDV.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> GetCategorias();
        Categoria GetById(int? id);

        IEnumerable<Categoria> GetByName(string texto);
        Categoria Create(Categoria categoria);
        Categoria Update(Categoria categoria);
        Categoria Remove(Categoria categoria);
    }
}
