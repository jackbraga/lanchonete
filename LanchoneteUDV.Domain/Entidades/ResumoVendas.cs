using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Entidades
{
    public class ResumoVendas
    {
        public string Mes { get; set; }        
        public double Boleto { get; set; }
        public double Cartao { get; set; }
        public double Entradas{ get; set; }
        public double Saidas { get; set; }
        public double Faturado { get; set; }
        public double Lucro { get; set; }
        public double Dinheiro { get; set; }
        public double Saldo { get; set; }

        public double Parceria { get; set; }
    }
}
