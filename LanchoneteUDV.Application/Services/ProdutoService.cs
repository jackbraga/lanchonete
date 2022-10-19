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
    public class ProdutoService : IProdutoService
    {
        private IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository produtosRepository, IMapper mapper)
        {
            _produtoRepository = produtosRepository;
            _mapper = mapper;
        }

        public ProdutoDTO Add(ProdutoDTO produtoDTO)
        {
            var produto = _mapper.Map<Produto>(produtoDTO);
            var retorno = _produtoRepository.Add(produto);
            return _mapper.Map<ProdutoDTO>(retorno);
        }

        public IEnumerable<ProdutoDTO> GetAll()
        {
            var produtos = _produtoRepository.GetAll();
            return _mapper.Map<IEnumerable<ProdutoDTO>>(produtos);
        }

        public ProdutoDTO GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProdutoDTO> GetByName(string texto)
        {
            var produtos = _produtoRepository.GetByName(texto);
            return _mapper.Map<IEnumerable<ProdutoDTO>>(produtos);
        }

        public IEnumerable<ProdutoDTO> ListarProdutosParaVenda()
        {
            var produtos = _produtoRepository.ListarProdutosParaVenda();
            return _mapper.Map<IEnumerable<ProdutoDTO>>(produtos);
        }

        public IEnumerable<ProdutoDTO> ListarProdutosParaVendaPorEscala(int idEscala,bool exibeSalgados=true, bool exibeChurrasco=true)
        {
            var produtos = _produtoRepository.ListarProdutosParaVendaPorEscala(idEscala, exibeSalgados, exibeChurrasco);
            return _mapper.Map<IEnumerable<ProdutoDTO>>(produtos);
        }

        public void Remove(int id)
        {
            _produtoRepository.Remove(id);
        }

        public void Update(ProdutoDTO produtoDTO)
        {
            var produto = _mapper.Map<Produto>(produtoDTO);
            _produtoRepository.Update(produto);
        }
    }
}
