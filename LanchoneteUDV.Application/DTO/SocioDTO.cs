using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.DTO
{
    public class SocioDTO 
    {
        public int Id { get; set; }
        public string Nome { get;  set; }
        public string Email { get;  set; }
        public int ResponsavelFinanceiro { get; set; }
        public string NomeResponsavel { get; set; }
        public int TipoSocio { get; set; }
        //public DateTime DataCriacao { get; set; }

    }
}
