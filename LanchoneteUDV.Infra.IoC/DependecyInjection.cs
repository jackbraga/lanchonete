using AutoMapper;
using LanchoneteUDV.Application.Interfaces;
using LanchoneteUDV.Application.Mappings;
using LanchoneteUDV.Application.Services;
using LanchoneteUDV.Domain.Interfaces;
using LanchoneteUDV.Infra.Data;
using LanchoneteUDV.Infra.Data.Repositories;
using Ninject.Modules;

namespace LanchoneteUDV.Infra.IoC
{
    public class DependecyInjectionModule: NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(ICategoriaService)).To(typeof(CategoriaService));
            Bind(typeof(ICategoriaRepository)).To(typeof(CategoriaRepository));
            Bind(typeof(IEscalaService)).To(typeof(EscalaService));
            Bind(typeof(IEscalaRepository)).To(typeof(EscalaRepository));
            Bind(typeof(IProdutoService)).To(typeof(ProdutoService));
            Bind(typeof(IProdutoRepository)).To(typeof(ProdutoRepository));
            Bind(typeof(ISocioService)).To(typeof(SocioService));
            Bind(typeof(ISocioRepository)).To(typeof(SocioRepository));
            Bind(typeof(ICompraService)).To(typeof(CompraService));
            Bind(typeof(ICompraRepository)).To(typeof(CompraRepository));
            Bind(typeof(IEstoqueEscalaService)).To(typeof(EstoqueEscalaService));
            Bind(typeof(IEstoqueEscalaRepository)).To(typeof(EstoqueEscalaRepository));
            Bind(typeof(IVendaService)).To(typeof(VendaService));
            Bind(typeof(IVendaRepository)).To(typeof(VendaRepository));
            Bind(typeof(IVendasPedidoService)).To(typeof(VendasPedidoService));
            Bind(typeof(IVendasPedidoRepository)).To(typeof(VendasPedidoRepository));
            Bind(typeof(ICaixaRepository)).To(typeof(CaixaRepository));
            Bind(typeof(ICaixaService)).To(typeof(CaixaService));
            Bind(typeof(IFinanceiroRepository)).To(typeof(FinanceiroRepository));
            Bind(typeof(IFinanceiroService)).To(typeof(FinanceiroService));
            Bind(typeof(IExcelService)).To(typeof(ExcelService));

            Bind(typeof(IParceriasRepository)).To(typeof(ParceriasRepository));
            Bind(typeof(IParceriasService)).To(typeof(ParceriasService));


            Bind(typeof(IConnectionFactory)).To(typeof(DefaultSqlConnectionFactory));
            var mapperConfiguration = new MapperConfiguration(cfg => { cfg.AddProfile<DomaintToDTOMappingProfile>(); });
            this.Bind<IMapper>().ToConstructor(c => new Mapper(mapperConfiguration)).InSingletonScope();
            this.Bind<Root>().ToSelf().InSingletonScope();
        }

    }

    public class Root
    {
        public Root(IMapper mapper)
        {
        }
    }
}