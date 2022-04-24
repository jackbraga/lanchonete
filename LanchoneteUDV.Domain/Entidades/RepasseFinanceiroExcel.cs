using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Entidades
{
    public class RepasseFinanceiroExcel
    {
        public string Nome { get; set; }
        public DateTime DataEscala { get; set; }
        public string TipoPagamento { get; set; }
        public string Frente { get; set; }
        public double Valor { get; set; }
    }
}
