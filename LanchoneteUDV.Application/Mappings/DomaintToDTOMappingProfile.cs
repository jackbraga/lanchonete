using AutoMapper;
using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Domain.Entidades;
using static LanchoneteUDV.Application.DTO.RepasseFinanceiroDTO;

namespace LanchoneteUDV.Application.Mappings
{
    public class DomaintToDTOMappingProfile : Profile
    {
        public DomaintToDTOMappingProfile()
        {
            CreateMap<Categoria, CategoriaDTO>().ReverseMap();
            CreateMap<Escala, EscalaDTO>().ReverseMap();
            CreateMap<Produto, ProdutoDTO>().ReverseMap();
            CreateMap<Socio, SocioDTO>().ReverseMap();
            CreateMap<Compra, CompraDTO>().ReverseMap();
            CreateMap<Estoque, EstoqueDTO>().ReverseMap();
            CreateMap<EstoqueEscala, EstoqueEscalaDTO>().ReverseMap();
            CreateMap<EstoquePorEscala, EstoquePorEscalaDTO>().ReverseMap();
            CreateMap<Venda, VendaDTO>().ReverseMap();
            CreateMap<VendaEscala, VendaEscalaDTO>().ReverseMap();
            CreateMap<VendaEscalaResumoVenda, VendaEscalaResumoVendaDTO>().ReverseMap();
            CreateMap<VendaEscalaSocio, VendaEscalaSocioDTO>().ReverseMap();
            CreateMap<VendasPedido, VendasPedidoDTO>().ReverseMap();
            CreateMap<VendasPedidoEscala, VendasPedidoEscalaDTO>().ReverseMap();
            CreateMap<VendasPedidoSocio, VendasPedidoSocioDTO>().ReverseMap();
            CreateMap<RepasseFinanceiro, RepasseFinanceiroDTO>().ReverseMap();
            CreateMap<VendaRepasseFinanceiro, VendaRepasseFinanceiroDTO>().ReverseMap();
            CreateMap<CategoriaLancamento, CategoriaLancamentoDTO>().ReverseMap();
            CreateMap<Caixa, CaixaDTO>().ReverseMap();
            CreateMap<Parcerias, ParceriasDTO>().ReverseMap();
            CreateMap<ResumoVendas, ResumoVendasDTO>().ReverseMap();
            CreateMap<RepasseFinanceiroExcel, RepasseFinanceiroExcelDTO>().ReverseMap();
            CreateMap<ParceriasProduto, ParceriasProdutoDTO>().ReverseMap();
            CreateMap<VendasParceriaEscala, VendasParceriaEscalaDTO>().ReverseMap();
            CreateMap<VendasParceriaProduto, VendasParceriaProdutoDTO>().ReverseMap();
            
        }
    }
}
