using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Entidades
{
    public class VendaEscalaResumoVenda
    {
        public int IdEscala { get; set; }
        public string Descricao { get; set; }
        public DateTime DataEscala { get; set; }
        public double ResumoVendas { get; set; }
        public double EscalaFinalizada { get; set; }
        public string TipoPagamento { get; set; }




                //       "SELECT " +
                //"tbEscalas.ID,  " +
                //"tbEscalas.Descricao, " +
                //"tbEscalas.DataEscala, " +
                //"SUM((tbVendasPedido.PrecoProduto * tbVendasPedido.Quantidade)) AS Resumo, " +
                //"tbEscalas.Finalizada, " +
                //"TipoPagamento " +
                //"FROM tbEscalas " +
                //"LEFT JOIN tbVendas ON tbEscalas.ID = tbVendas.Escala " +
                //"LEFT JOIN tbVendasPedido ON tbVendas.ID = tbVendasPedido.Venda " +
                //"WHERE tbEscalas.ID = " + idEscala + " " +
                //"GROUP BY  tbEscalas.ID, tbEscalas.Descricao, tbEscalas.DataEscala, TipoPagamento,tbEscalas.Finalizada ";
    }
}
