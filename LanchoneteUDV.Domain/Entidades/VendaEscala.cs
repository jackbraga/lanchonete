using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Entidades
{
    public class VendaEscala
    {
        public int IdVenda { get; set; }
        public int IdSocio { get; set; }
        public string NomeSocio { get; set; }
        public string TipoPagamento { get; set; }
        public double TotalVenda { get; set; }
        public bool PendenteRetirada { get; set; }
    }
}


//"SELECT tbVendas.ID, tbSocios.ID,  tbSocios.Nome, tbVendas.TipoPagamento, " +
//    "SUM(tbVendasPedido.Quantidade * tbVendasPedido.PrecoProduto) AS Total," +
//    "" +
//    "(SELECT COUNT(*) FROM tbVendasPedido WHERE Venda=tbVendas.ID AND Retirado=0) AS PendenteRetirada " +