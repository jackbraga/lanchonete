using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.DataObject
{
    public class CompraDTO: BaseDTO
    {
        public DateTime DataCompra { get; set; }
        public int IDProduto { get; set; }

        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        public string CompradoPor { get; set; }

        public string TipoEntrada { get; set; }

        public string Observacao { get; set; }
    }
}
