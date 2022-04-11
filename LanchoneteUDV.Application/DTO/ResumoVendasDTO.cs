using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.DTO
{
    public class ResumoVendasDTO
    {
        public string Mes { get; set; }
        public double SaldoInicial { get; set; }
        public double Entradas { get; set; }
        public double Saidas { get; set; }
        public double Faturado { get; set; }
        public double Lucro { get; set; }
        public double Dinheiro { get; set; }
        public double Saldo { get; set; }
    }
}
