using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.DTO
{
    public class EstoquePorEscalaDTO
    {
        public string DescricaoProduto { get; set; }
        public double PrecoVenda { get; set; }
        public int QtdVenda { get; set; }
        public int Saida { get; set; }
        public int Estoque { get; set; }
    }
}
