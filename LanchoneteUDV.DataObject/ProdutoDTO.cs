using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.DataObject
{
    public class ProdutoDTO : BaseDTO
    {
        public string Descricao { get; set; }
        public int IDCategoria { get; set; }
        public double PrecoCustoCaixa { get; set; }
        public int QuantidadePorCaixa { get; set; }
        public double PrecoCustoUnitario { get; set; }
        public double PrecoVenda { get; set; }
        public int EstoqueInicial { get; set; }
        public bool ProdutoVenda { get; set; }
    }
}
