using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Entidades
{
    public class EstoqueEscala : BaseEntity
    {
        public int IdEscala { get; set; }
        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public int QtdVenda { get; set; }
        public string Observacao { get; set; }
    
    
    }
}
