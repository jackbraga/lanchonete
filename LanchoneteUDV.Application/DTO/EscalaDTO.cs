using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.DTO
{
    public class EscalaDTO
    {
        public int Id { get; set; }
        public DateTime DataEscala { get; set; }
        public string Descricao { get; set; }
        public string TipoSessao { get; set; }
        public string Observacao { get; set; }
        public bool Finalizada { get; set; }
        public bool RepasseTesouraria { get; set; }
        public double ResumoVendas { get; set; }
    }
}
