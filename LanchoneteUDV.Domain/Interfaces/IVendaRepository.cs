using LanchoneteUDV.Domain.Entidades;

namespace LanchoneteUDV.Domain.Interfaces
{
    public interface IVendaRepository
    {
        public IEnumerable<VendaEscala> ListarVendasEscala(int idEscala);

        public IEnumerable<VendaEscala> ListarVendasPesquisa(int idEscala, string pesquisa);

        public IEnumerable<VendaEscalaResumoVenda> TrazerVendaEscalaResumoVenda(int idEscala);

        public IEnumerable<VendaEscalaResumoVenda> TrazerVendaEscalaResumoVendaChurrasco(int idEscala);

        public IEnumerable<VendaEscalaSocio> TrazerVendaEscalaSocio(int idEscala, int idSocio);

         Task<IEnumerable<EstoquePorEscala>> ListarEstoquePorEscala(int idEscala);

        Task<IEnumerable<EstoquePorEscala>> ListarEstoqueSalgadosPorEscala(int idEscala);

        public int Add(Venda classe);

        public Venda Update(Venda classe);
    }
}
