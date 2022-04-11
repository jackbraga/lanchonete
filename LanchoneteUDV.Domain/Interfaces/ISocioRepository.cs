using LanchoneteUDV.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Interfaces
{
    public interface ISocioRepository : IBaseRepository<Socio>
    {
        IEnumerable<Socio> ListarSociosVenda();
        IEnumerable<Socio> ListarSociosVisitantes();
        
    }
}
