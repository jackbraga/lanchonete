using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.DTO
{
    public class VendaEscalaResumoVendaDTO
    {
        public int IdEscala { get; set; }
        public string Descricao { get; set; }
        public DateTime DataEscala { get; set; }
        public double ResumoVendas { get; set; }
        public bool EscalaFinalizada { get; set; }
        public string TipoPagamento { get; set; }
    }
}
