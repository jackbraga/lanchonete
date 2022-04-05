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