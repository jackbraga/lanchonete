using AutoMapper;
using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;
using LanchoneteUDV.Domain.Entidades;
using LanchoneteUDV.Domain.Interfaces;

namespace LanchoneteUDV.Application.Services
{
    public class VendaService : IVendaService
    {

        private readonly IVendaRepository _vendaRepository;
        private readonly IMapper _mapper;

        public VendaService(IVendaRepository vendaRepository,IMapper mapper)
        {
            _vendaRepository = vendaRepository;
            _mapper = mapper;
        }
        public int Add(VendaDTO vendaDTO)
        {
            var venda = _mapper.Map<Venda>(vendaDTO);
            return _vendaRepository.Add(venda);
            
        }

        public async Task<IEnumerable<EstoquePorEscalaDTO>> ListarEstoquePorEscala(int idEscala)
        {
            var estoques = await _vendaRepository.ListarEstoquePorEscala(idEscala);
            return _mapper.Map<IEnumerable<EstoquePorEscalaDTO>>(estoques.OrderBy(x=>x.DescricaoProduto).ToList());
        }

        public async Task<IEnumerable<EstoquePorEscalaDTO>> ListarEstoqueSalgadosPorEscala(int idEscala, bool exibeSalgados, bool exibeChurrasco)
        {
            var estoques = await _vendaRepository.ListarEstoqueSalgadosPorEscala(idEscala, exibeSalgados, exibeChurrasco);
            return _mapper.Map<IEnumerable<EstoquePorEscalaDTO>>(estoques.OrderBy(x => x.DescricaoProduto).ToList());
        }

        public IEnumerable<VendaEscalaDTO> ListarVendasEscala(int idEscala)
        {
            var estoques = _vendaRepository.ListarVendasEscala(idEscala);
            return _mapper.Map<IEnumerable<VendaEscalaDTO>>(estoques);
        }

        public IEnumerable<VendaEscalaDTO> ListarVendasPesquisa(int idEscala, string pesquisa)
        {
            var estoques = _vendaRepository.ListarVendasPesquisa(idEscala,pesquisa);
            return _mapper.Map<IEnumerable<VendaEscalaDTO>>(estoques);
        }

        public IEnumerable<VendaEscalaResumoVendaDTO> TrazerVendaEscalaResumoVenda(int idEscala)
        {
            var estoques = _vendaRepository.TrazerVendaEscalaResumoVenda(idEscala);
            return _mapper.Map<IEnumerable<VendaEscalaResumoVendaDTO>>(estoques);
        }

        public IEnumerable<VendaEscalaResumoVendaDTO> TrazerVendaEscalaResumoVendaParcerias(int idEscala)
        {
            var estoques = _vendaRepository.TrazerVendaEscalaResumoVendaParcerias(idEscala);
            return _mapper.Map<IEnumerable<VendaEscalaResumoVendaDTO>>(estoques);
        }

        public IEnumerable<VendaEscalaResumoVendaDTO> TrazerVendaEscalaResumoVendaChurrasco(int idEscala)
        {
            var estoques = _vendaRepository.TrazerVendaEscalaResumoVendaChurrasco(idEscala);
            return _mapper.Map<IEnumerable<VendaEscalaResumoVendaDTO>>(estoques);
        }

        public IEnumerable<VendaEscalaSocioDTO> TrazerVendaEscalaSocio(int idEscala, int idSocio)
        {
            var estoques = _vendaRepository.TrazerVendaEscalaSocio(idEscala,idSocio);
            return _mapper.Map<IEnumerable<VendaEscalaSocioDTO>>(estoques);
        }

        public VendaDTO Update(VendaDTO vendaDTO)
        {
            var venda = _mapper.Map<Venda>(vendaDTO);
            _vendaRepository.Update(venda);
            return vendaDTO;
        }
    }
}
