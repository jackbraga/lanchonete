using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Entidades
{
    public class VendaEscalaSocio
    {
        public int IdVenda { get; set; }
        public string TipoPagamento { get; set; }
        public double TotalConsumido { get; set; }

                //        "SELECT tbVendas.ID, tbVendas.TipoPagamento, SUM(tbVendasPedido.Quantidade * tbVendasPedido.PrecoProduto) AS TotalConsumido " +
                //"FROM tbVendas " +
                //"INNER JOIN tbVendasPedido ON tbVendasPedido.Venda=tbVendas.ID " +
                //"WHERE Escala=" + idEscala + " AND Socio=" + idSocio + " " +
                //"GROUP BY tbVendas.ID, tbVendas.TipoPagamento ;";
    }
}
