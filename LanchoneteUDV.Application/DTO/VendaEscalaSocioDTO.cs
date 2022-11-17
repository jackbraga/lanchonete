using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.DTO
{
    public class VendaEscalaSocioDTO
    {
        public int IdVenda { get; set; }
        public string TipoPagamento { get; set; }
        public double TotalConsumido { get; set; }

        public bool ItemPago { get; set; }
    }
}
