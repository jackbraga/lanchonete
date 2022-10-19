using LanchoneteUDV.Application.DTO;

namespace LanchoneteUDV.Application.Interfaces
{
    public interface IVendaService
    {
        public IEnumerable<VendaEscalaDTO> ListarVendasEscala(int idEscala);

        public IEnumerable<VendaEscalaDTO> ListarVendasPesquisa(int idEscala, string pesquisa);

        public IEnumerable<VendaEscalaResumoVendaDTO> TrazerVendaEscalaResumoVenda(int idEscala);

        public IEnumerable<VendaEscalaResumoVendaDTO> TrazerVendaEscalaResumoVendaChurrasco(int idEscala);

        public IEnumerable<VendaEscalaSocioDTO> TrazerVendaEscalaSocio(int idEscala, int idSocio);

        public Task<IEnumerable<EstoquePorEscalaDTO>> ListarEstoquePorEscala(int idEscala);

        public Task<IEnumerable<EstoquePorEscalaDTO>> ListarEstoqueSalgadosPorEscala(int idEscala, bool exibeSalgados, bool exibeChurrasco);

        public int Add(VendaDTO classe);

        public VendaDTO Update(VendaDTO classe);
    }
}
