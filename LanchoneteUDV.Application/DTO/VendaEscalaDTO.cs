using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.DTO
{
    public class VendaEscalaDTO
    {
        public int IdVenda { get; set; }
        public int IdSocio { get; set; }
        public string NomeSocio { get; set; }
        public string TipoPagamento { get; set; }
        public double TotalVenda { get; set; }
        public bool PendenteRetirada { get; set; }
    }
}
