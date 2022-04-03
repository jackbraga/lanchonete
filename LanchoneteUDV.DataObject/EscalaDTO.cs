using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.DataObject
{
    public class EscalaDTO : BaseDTO
    {
        public DateTime DataEscala { get; set; }
        public string TipoSessao { get; set; }
        public string Descricao { get; set; }
        public bool Finalizada { get; set; }
        public string Observacao { get; set; }
    }
}
