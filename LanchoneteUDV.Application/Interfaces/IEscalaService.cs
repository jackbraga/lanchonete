using LanchoneteUDV.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.Interfaces
{
    public interface IEscalaService : IBaseService<EscalaDTO>
    {
        void FinalizarEscala(int idEscala);
    }
}
