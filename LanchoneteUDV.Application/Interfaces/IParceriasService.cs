using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Domain.Entidades;
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

        IEnumerable<VendasParceriaEscalaDTO> BuscarParceriaEscala(int idParceria);

        IEnumerable<VendasParceriaProdutoDTO> BuscarVendasProdutosParceria(int idParceria, bool retirados);

        void RegistraRepasseParceria(int idEscala, int idParceria, bool repasse);
        void DesregistraRepasseParceria(int idEscala, int idParceria);
    }        
}
