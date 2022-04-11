using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Entidades
{
    public class Estoque
    {
        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public double PrecoVenda { get; set; }
        public int EstoqueInicial { get; set; }
        public int Entrada { get; set; }
        public int Saida { get; set; }
        public int QtdEstoque { get; set; }

    }
}
