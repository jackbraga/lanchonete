using AutoMapper;
using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;
using LanchoneteUDV.Domain.Entidades;
using LanchoneteUDV.Domain.Interfaces;

namespace LanchoneteUDV.Application.Services
{
    public class EstoqueEscalaService : IEstoqueEscalaService
    {
        private readonly IEstoqueEscalaRepository _estoqueEscalaRepository;
        private readonly IMapper _mapper;

        public EstoqueEscalaService(IEstoqueEscalaRepository estoqueEscalaRepository, IMapper mapper)
        {
            _estoqueEscalaRepository= estoqueEscalaRepository;
            _mapper = mapper;
        }

        public EstoqueEscalaDTO Add(EstoqueEscalaDTO estoqueDTO)
        {
            var estoque = _mapper.Map<EstoqueEscala>(estoqueDTO);
            _estoqueEscalaRepository.Add(estoque);
            return estoqueDTO;
        }

        public void CompletarEstoqueEscala(int idEscala)
        {
            _estoqueEscalaRepository.CompletarEstoqueEscala(idEscala);
        }

        public IEnumerable<EstoqueDTO> ListarEstoque()
        {
            var estoque = _estoqueEscalaRepository.ListarEstoque();
            return _mapper.Map<IEnumerable<EstoqueDTO>>(estoque);
        }
        public IEnumerable<EstoqueDTO> ListarEstoqueComboProdutos(int idEscala)
        {
            var estoque = _estoqueEscalaRepository.ListarEstoqueComboProdutos(idEscala).OrderBy(x=>x.DescricaoProduto);
            return _mapper.Map<IEnumerable<EstoqueDTO>>(estoque);
        }
     
        public IEnumerable<EstoqueEscalaDTO> ListarProdutosEstoqueEscala(int idEscala)
        {
            var estoques = _estoqueEscalaRepository.ListarProdutosEstoqueEscala(idEscala);
            return _mapper.Map<IEnumerable<EstoqueEscalaDTO>>(estoques);
        }

        public IEnumerable<EstoqueDTO> PesquisarEstoque(string pesquisa)
        {
            var estoques = _estoqueEscalaRepository.PesquisarEstoque(pesquisa);
            return _mapper.Map<IEnumerable<EstoqueDTO>>(estoques);
        }

        public void Remove(int id)
        {
            _estoqueEscalaRepository.Remove(id);
        }

        public EstoqueEscalaDTO Update(EstoqueEscalaDTO estoqueDTO)
        {
            var estoque = _mapper.Map<EstoqueEscala>(estoqueDTO);
            _estoqueEscalaRepository.Update(estoque);
            return estoqueDTO;
            
        }
    }
}
