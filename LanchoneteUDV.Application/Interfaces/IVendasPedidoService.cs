using LanchoneteUDV.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.Interfaces
{
    public interface IVendasPedidoService
    {
        IEnumerable<VendasPedidoSocioDTO> ListarVendasPedido(int idVenda);

        IEnumerable<VendasPedidoEscalaDTO> ListarTodosVendasPedido(int idEscala);

        void Add(VendasPedidoDTO vendaPedido);

        void RegistrarRetirada(int idVendaPedido);

        void DesmarcarRetirada(int idVendaPedido);

        void Remove(int idVendaPedido);
    }
}
