using LanchoneteUDV.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Interfaces
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        IEnumerable<Produto> ListarProdutosParaVenda();
        IEnumerable<Produto> ListarProdutosParaVendaPorEscala(int idEscala);
    }
}
