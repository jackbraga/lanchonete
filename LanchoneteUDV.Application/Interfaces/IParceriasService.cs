using LanchoneteUDV.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.Interfaces
{
    public interface IParceriasService: IBaseService<ParceriasDTO>
    {
        IEnumerable<ParceriasProdutoDTO> BuscarProdutosParceria(int idParceria);

        ParceriasProdutoDTO AdicionaProdutoParceria(ParceriasProdutoDTO parceriasProduto);
    }

    
}
