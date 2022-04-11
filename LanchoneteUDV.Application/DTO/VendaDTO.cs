using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.DTO
{
    public class VendaDTO
    {
        public int Id { get; set; }
        public int IdEscala { get; set; }
        public int IdSocio { get; set; }
        public string TipoPagamento { get; set; }
        public bool EmailDisparado { get; set; }
    }
}
