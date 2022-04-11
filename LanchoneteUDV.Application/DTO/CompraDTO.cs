using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.DTO
{
    public class CompraDTO 

    {
        public int Id { get; set; }
        public DateTime DataCompra { get; set; }
        public string DescricaoProduto { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        public string CompradoPor { get; set; }

        public int IdProduto { get; set; }

        public string TipoEntrada { get; set; }
        public string Observacao { get; set; }
    }
}
