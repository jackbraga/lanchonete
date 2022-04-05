using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Interfaces
{
    public interface IBaseRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
       T GetById(int? id);
        IEnumerable<T> GetByName(string texto);
        T Add(T classe);
        T Update(T classe);
        void Remove(int id);
    }
}
