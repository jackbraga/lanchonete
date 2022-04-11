using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Entidades
{
    public class VendaRepasseFinanceiro
    {
        public int IdVenda { get; set; }
        public int IdSocio { get; set; }
        public string Nome { get; set; }
        public string TipoPagamento { get; set; }
        public double Total { get; set; }
        public bool EmailDisparado { get; set; }
        public string Email { get; set; }
    }
}
