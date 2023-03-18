using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Domain.Entidades;
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

        //IEnumerable<VendasPedidoSocioDTO> ListarVendasPedidoPago(int idVenda);

        IEnumerable<VendasPedidoEscalaDTO> ListarTodosVendasPedido(int idEscala, string filtro, bool exibeSoSemRetirar, bool agrupar);

        void Add(VendasPedidoDTO vendaPedido);

        void RegistrarRetirada(int idVendaPedido);

        void DesmarcarRetirada(int idVendaPedido);

        void Remove(int idVendaPedido);

        void AtualizaFormaPagamentoItem(int idVendaPedido, string tipoPagamento);

        void RegistrarPagamentoItem(int idVendaPedido);

        void DesmarcarPagamentoItem(int idVendaPedido);


    }
}
