using AutoMapper;
using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;
using LanchoneteUDV.Domain.Entidades;
using LanchoneteUDV.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.Services
{
    public class VendasPedidoService : IVendasPedidoService
    {

        private readonly IVendasPedidoRepository _vendasPedido;
        private readonly IMapper _mapper;

        public VendasPedidoService(IVendasPedidoRepository vendasPedido, IMapper mapper)
        {
            _vendasPedido = vendasPedido;
            _mapper = mapper;
        }

        public void Add(VendasPedidoDTO pedidoDTO)
        {
            var pedido = _mapper.Map<VendasPedido>(pedidoDTO);
            _vendasPedido.Add(pedido);

        }

        public void AtualizaFormaPagamentoItem(int idVendaPedido, string tipoPagamento)
        {
            _vendasPedido.AtualizaFormaPagamentoItem(idVendaPedido, tipoPagamento);
        }

        public void DesmarcarPagamentoItem(int idVendaPedido)
        {
            _vendasPedido.DesmarcarPagamentoItem(idVendaPedido);
        }

        public void DesmarcarRetirada(int idVendaPedido)
        {
            _vendasPedido.DesmarcarRetirada(idVendaPedido);
        }

        public IEnumerable<VendasPedidoEscalaDTO> ListarTodosVendasPedido(int idEscala, string filtro, bool soSemRetirar, bool agrupar)
        {
            var pedidos = _vendasPedido.ListarTodosVendasPedido(idEscala, filtro, soSemRetirar);

            if (agrupar)
            {
                IEnumerable<VendasPedidoEscalaDTO> pedidos2 = pedidos.GroupBy(p => new { p.Nome, p.Descricao })
                    .Select(i => new VendasPedidoEscalaDTO
                    {
                        Nome = i.Key.Nome,
                        Descricao = i.Key.Descricao,
                        Quantidade = i.Sum(s => s.Quantidade),
                        DataHoraPedido = i.First().DataHoraPedido,
                    }).ToList();
                return _mapper.Map<IEnumerable<VendasPedidoEscalaDTO>>(pedidos2);
            }


            return _mapper.Map<IEnumerable<VendasPedidoEscalaDTO>>(pedidos);
        }

        public IEnumerable<VendasPedidoSocioDTO> ListarVendasPedido(int idVenda)
        {
            var pedidos = _vendasPedido.ListarVendasPedido(idVenda);
            return _mapper.Map<IEnumerable<VendasPedidoSocioDTO>>(pedidos);
        }

        public void RegistrarPagamentoItem(int idVendaPedido)
        {
            _vendasPedido.RegistrarPagamentoItem(idVendaPedido);
        }

        //public IEnumerable<VendasPedidoSocioDTO> ListarVendasPedidoPago(int idVenda)
        //{
        //    var pedidos = _vendasPedido.ListarVendasPedidoPago(idVenda);
        //    return _mapper.Map<IEnumerable<VendasPedidoSocioDTO>>(pedidos);
        //}

        public void RegistrarRetirada(int idVendaPedido)
        {
            _vendasPedido.RegistrarRetirada(idVendaPedido);
        }

        public void Remove(int idVendaPedido)
        {
            _vendasPedido.Remove(idVendaPedido);
        }
    }
}
