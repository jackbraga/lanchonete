using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.DTO
{
    public class ProdutoDTO 
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int CategoriaId { get; set; }
        public string Categoria { get; set; }
        public double PrecoCustoCaixa { get; set; }
        public int QtdPorCaixa { get; set; }
        public double PrecoCustoUnitario { get; set; }
        public double PrecoVenda { get; set; }
        public int EstoqueInicial { get; set; }
        public bool ProdutoVenda { get; set; }

        //public CategoriaDTO Categoria { get; set; }
    }
}
