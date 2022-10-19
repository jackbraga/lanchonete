using LanchoneteUDV.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Interfaces
{
    public interface IParceriasRepository: IBaseRepository<Parcerias>
    {
        IEnumerable<ParceriasProduto> BuscarProdutosParceria(int idParceria);

        ParceriasProduto AdicionaProdutoParceria(ParceriasProduto produto);
    }

}
