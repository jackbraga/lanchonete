using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.DataObject
{
    public class LoggingDTO
    {
        public int IDUsuario { get; set; }

        public string Formulario { get; set; }

        public string Log { get; set; }

        public string Acao { get; set; }

        public DateTime DataHora { get; set; }

        public int IDTabela { get; set; }

        public string NomeTabela { get; set; }

    }
}