using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.DataObject
{
    public class CaixaDTO : BaseDTO
    {
        public DateTime DataEvento { get; set; }
        public string TipoEvento { get; set; }
        public int Categoria { get; set; }

        public double Valor { get; set; }
        public string Observacao { get; set; }
    }
}
