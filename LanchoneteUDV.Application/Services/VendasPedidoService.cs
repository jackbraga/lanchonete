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

        public VendasPedidoService(IVendasPedidoRepository vendasPedido,IMapper mapper)
        {
            _vendasPedido = vendasPedido;
            _mapper = mapper;
        }

        public void Add(VendasPedidoDTO pedidoDTO)
        {
            var pedido = _mapper.Map<VendasPedido>(pedidoDTO);
            _vendasPedido.Add(pedido);

        }

        public void DesmarcarRetirada(int idVendaPedido)
        {
            _vendasPedido.DesmarcarRetirada(idVendaPedido);
        }

        public IEnumerable<VendasPedidoEscalaDTO> ListarTodosVendasPedido(int idEscala)
        {
            var pedidos = _vendasPedido.ListarTodosVendasPedido(idEscala);
            return _mapper.Map<IEnumerable<VendasPedidoEscalaDTO>>(pedidos);
        }

        public IEnumerable<VendasPedidoSocioDTO> ListarVendasPedido(int idVenda)
        {
            var pedidos = _vendasPedido.ListarVendasPedido(idVenda);
            return _mapper.Map<IEnumerable<VendasPedidoSocioDTO>>(pedidos);
        }

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
