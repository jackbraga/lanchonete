using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.DTO
{
    public class CaixaDTO
    {
        public int Id { get; set; }
        public DateTime DataEvento { get; set; }
        public string TipoEvento { get; set; }
        public double Valor { get; set; }
        public string DescricaoCategoria { get; set; }
        public string Observacao { get; set; }
   
        public int IdCategoria { get; set; }

        public string EspecieMoeda { get; set; }

        public string Frente { get; set; }
    }
}
