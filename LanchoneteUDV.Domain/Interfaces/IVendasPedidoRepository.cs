using LanchoneteUDV.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Interfaces
{
    public interface IVendasPedidoRepository
    {
        IEnumerable<VendasPedidoSocio> ListarVendasPedido(int idVenda);

        //IEnumerable<VendasPedidoSocio> ListarVendasPedidoPago(int idVenda);

        IEnumerable<VendasPedidoEscala> ListarTodosVendasPedido(int idEscala, string filtro, bool soSemRetirar);

        void Add(VendasPedido vendaPedido);

        void RegistrarRetirada(int idVendaPedido);

        void DesmarcarRetirada(int idVendaPedido);

        void Remove(int idVendaPedido);

        void AtualizaFormaPagamentoItem(int idVendaPedido, string tipoPagamento);

        void RegistrarPagamentoItem(int idVendaPedido);

        void DesmarcarPagamentoItem(int idVendaPedido);


    }
}

