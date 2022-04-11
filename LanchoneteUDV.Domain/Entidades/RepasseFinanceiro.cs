using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Entidades
{
    public class RepasseFinanceiro
    {
        public DateTime DataEscala { get; set; }
        public string Escala { get; set; }
        public string Nome { get; set; }
        public int IdProduto { get; set; }
        public string Produto { get; set; }
        public double PrecoProduto { get; set; }
        public int Quantidade { get; set; }

 

    }
}